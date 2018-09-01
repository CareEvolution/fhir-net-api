using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Definition of an element in a resource or extension
    /// </summary>
    [FhirType("ElementDefinition")]
    [DataContract]
    public partial class ElementDefinition : BackboneElement
    {
        [NotMapped]
        public override string TypeName { get { return "ElementDefinition"; } }

        /// <summary>
        /// How a property is represented when serialized.
        /// (url: http://hl7.org/fhir/ValueSet/property-representation)
        /// </summary>
        [FhirEnumeration("PropertyRepresentation")]
        public enum PropertyRepresentation
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/property-representation)
            /// </summary>
            [EnumLiteral("xmlAttr", "http://hl7.org/fhir/property-representation"), Description("XML Attribute")]
            XmlAttr,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/property-representation)
            /// </summary>
            [EnumLiteral("xmlText", "http://hl7.org/fhir/property-representation"), Description("XML Text")]
            XmlText,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/property-representation)
            /// </summary>
            [EnumLiteral("typeAttr", "http://hl7.org/fhir/property-representation"), Description("Type Attribute")]
            TypeAttr,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/property-representation)
            /// </summary>
            [EnumLiteral("cdaText", "http://hl7.org/fhir/property-representation"), Description("CDA Text Format")]
            CdaText,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/property-representation)
            /// </summary>
            [EnumLiteral("xhtml", "http://hl7.org/fhir/property-representation"), Description("XHTML")]
            Xhtml,
        }

        /// <summary>
        /// How an element value is interpreted when discrimination is evaluated.
        /// (url: http://hl7.org/fhir/ValueSet/discriminator-type)
        /// </summary>
        [FhirEnumeration("DiscriminatorType")]
        public enum DiscriminatorType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/discriminator-type)
            /// </summary>
            [EnumLiteral("value", "http://hl7.org/fhir/discriminator-type"), Description("Value")]
            Value,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/discriminator-type)
            /// </summary>
            [EnumLiteral("exists", "http://hl7.org/fhir/discriminator-type"), Description("Exists")]
            Exists,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/discriminator-type)
            /// </summary>
            [EnumLiteral("pattern", "http://hl7.org/fhir/discriminator-type"), Description("Pattern")]
            Pattern,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/discriminator-type)
            /// </summary>
            [EnumLiteral("type", "http://hl7.org/fhir/discriminator-type"), Description("Type")]
            Type,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/discriminator-type)
            /// </summary>
            [EnumLiteral("profile", "http://hl7.org/fhir/discriminator-type"), Description("Profile")]
            Profile,
        }

        /// <summary>
        /// How slices are interpreted when evaluating an instance.
        /// (url: http://hl7.org/fhir/ValueSet/resource-slicing-rules)
        /// </summary>
        [FhirEnumeration("SlicingRules")]
        public enum SlicingRules
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-slicing-rules)
            /// </summary>
            [EnumLiteral("closed", "http://hl7.org/fhir/resource-slicing-rules"), Description("Closed")]
            Closed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-slicing-rules)
            /// </summary>
            [EnumLiteral("open", "http://hl7.org/fhir/resource-slicing-rules"), Description("Open")]
            Open,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-slicing-rules)
            /// </summary>
            [EnumLiteral("openAtEnd", "http://hl7.org/fhir/resource-slicing-rules"), Description("Open at End")]
            OpenAtEnd,
        }

        /// <summary>
        /// How resource references can be aggregated.
        /// (url: http://hl7.org/fhir/ValueSet/resource-aggregation-mode)
        /// </summary>
        [FhirEnumeration("AggregationMode")]
        public enum AggregationMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-aggregation-mode)
            /// </summary>
            [EnumLiteral("contained", "http://hl7.org/fhir/resource-aggregation-mode"), Description("Contained")]
            Contained,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-aggregation-mode)
            /// </summary>
            [EnumLiteral("referenced", "http://hl7.org/fhir/resource-aggregation-mode"), Description("Referenced")]
            Referenced,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-aggregation-mode)
            /// </summary>
            [EnumLiteral("bundled", "http://hl7.org/fhir/resource-aggregation-mode"), Description("Bundled")]
            Bundled,
        }

        /// <summary>
        /// Whether a reference needs to be version specific or version independent, or whether either can be used.
        /// (url: http://hl7.org/fhir/ValueSet/reference-version-rules)
        /// </summary>
        [FhirEnumeration("ReferenceVersionRules")]
        public enum ReferenceVersionRules
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-version-rules)
            /// </summary>
            [EnumLiteral("either", "http://hl7.org/fhir/reference-version-rules"), Description("Either Specific or independent")]
            Either,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-version-rules)
            /// </summary>
            [EnumLiteral("independent", "http://hl7.org/fhir/reference-version-rules"), Description("Version independent")]
            Independent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-version-rules)
            /// </summary>
            [EnumLiteral("specific", "http://hl7.org/fhir/reference-version-rules"), Description("Version Specific")]
            Specific,
        }

        /// <summary>
        /// SHALL applications comply with this constraint?
        /// (url: http://hl7.org/fhir/ValueSet/constraint-severity)
        /// </summary>
        [FhirEnumeration("ConstraintSeverity")]
        public enum ConstraintSeverity
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/constraint-severity)
            /// </summary>
            [EnumLiteral("error", "http://hl7.org/fhir/constraint-severity"), Description("Error")]
            Error,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/constraint-severity)
            /// </summary>
            [EnumLiteral("warning", "http://hl7.org/fhir/constraint-severity"), Description("Warning")]
            Warning,
        }


        [FhirType("SlicingComponent")]
        [DataContract]
        public partial class SlicingComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SlicingComponent"; } }

            /// <summary>
            /// Element values that are used to distinguish the slices
            /// </summary>
            [FhirElement("discriminator", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DiscriminatorComponent> Discriminator
            {
                get { if (_discriminator==null) _discriminator = new List<DiscriminatorComponent>(); return _discriminator; }
                set { _discriminator = value; OnPropertyChanged("Discriminator"); }
            }

            private List<DiscriminatorComponent> _discriminator;

            /// <summary>
            /// Text description of how slicing works (or not)
            /// </summary>
            [FhirElement("description", InSummary=true, Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Text description of how slicing works (or not)
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
            /// If elements must be in same order as slices
            /// </summary>
            [FhirElement("ordered", InSummary=true, Order=60)]
            [DataMember]
            public FhirBoolean OrderedElement
            {
                get { return _orderedElement; }
                set { _orderedElement = value; OnPropertyChanged("OrderedElement"); }
            }

            private FhirBoolean _orderedElement;

            /// <summary>
            /// If elements must be in same order as slices
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Ordered
            {
                get { return OrderedElement != null ? OrderedElement.Value : null; }
                set
                {
                    if (value == null)
                        OrderedElement = null;
                    else
                        OrderedElement = new FhirBoolean(value);
                    OnPropertyChanged("Ordered");
                }
            }

            /// <summary>
            /// closed | open | openAtEnd
            /// </summary>
            [FhirElement("rules", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<SlicingRules> RulesElement
            {
                get { return _rulesElement; }
                set { _rulesElement = value; OnPropertyChanged("RulesElement"); }
            }

            private Code<SlicingRules> _rulesElement;

            /// <summary>
            /// closed | open | openAtEnd
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SlicingRules? Rules
            {
                get { return RulesElement != null ? RulesElement.Value : null; }
                set
                {
                    if (value == null)
                        RulesElement = null;
                    else
                        RulesElement = new Code<SlicingRules>(value);
                    OnPropertyChanged("Rules");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SlicingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Discriminator != null) dest.Discriminator = new List<DiscriminatorComponent>(Discriminator.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (OrderedElement != null) dest.OrderedElement = (FhirBoolean)OrderedElement.DeepCopy();
                    if (RulesElement != null) dest.RulesElement = (Code<SlicingRules>)RulesElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SlicingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SlicingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Discriminator, otherT.Discriminator)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(OrderedElement, otherT.OrderedElement)) return false;
                if (!DeepComparable.Matches(RulesElement, otherT.RulesElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SlicingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Discriminator, otherT.Discriminator)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(OrderedElement, otherT.OrderedElement)) return false;
                if (!DeepComparable.IsExactly(RulesElement, otherT.RulesElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Discriminator) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (OrderedElement != null) yield return OrderedElement;
                    if (RulesElement != null) yield return RulesElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Discriminator) { if (elem != null) yield return new ElementValue("discriminator", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (OrderedElement != null) yield return new ElementValue("ordered", OrderedElement);
                    if (RulesElement != null) yield return new ElementValue("rules", RulesElement);
                }
            }


        }


        [FhirType("DiscriminatorComponent")]
        [DataContract]
        public partial class DiscriminatorComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DiscriminatorComponent"; } }

            /// <summary>
            /// value | exists | pattern | type | profile
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<DiscriminatorType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<DiscriminatorType> _typeElement;

            /// <summary>
            /// value | exists | pattern | type | profile
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DiscriminatorType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<DiscriminatorType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Path to element value
            /// </summary>
            [FhirElement("path", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// Path to element value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiscriminatorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<DiscriminatorType>)TypeElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DiscriminatorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DiscriminatorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiscriminatorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (PathElement != null) yield return PathElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                }
            }


        }


        [FhirType("BaseComponent")]
        [DataContract]
        public partial class BaseComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BaseComponent"; } }

            /// <summary>
            /// Path that identifies the base element
            /// </summary>
            [FhirElement("path", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// Path that identifies the base element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// Min cardinality of the base element
            /// </summary>
            [FhirElement("min", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public UnsignedInt MinElement
            {
                get { return _minElement; }
                set { _minElement = value; OnPropertyChanged("MinElement"); }
            }

            private UnsignedInt _minElement;

            /// <summary>
            /// Min cardinality of the base element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Min
            {
                get { return MinElement != null ? MinElement.Value : null; }
                set
                {
                    if (value == null)
                        MinElement = null;
                    else
                        MinElement = new UnsignedInt(value);
                    OnPropertyChanged("Min");
                }
            }

            /// <summary>
            /// Max cardinality of the base element
            /// </summary>
            [FhirElement("max", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString MaxElement
            {
                get { return _maxElement; }
                set { _maxElement = value; OnPropertyChanged("MaxElement"); }
            }

            private FhirString _maxElement;

            /// <summary>
            /// Max cardinality of the base element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Max
            {
                get { return MaxElement != null ? MaxElement.Value : null; }
                set
                {
                    if (value == null)
                        MaxElement = null;
                    else
                        MaxElement = new FhirString(value);
                    OnPropertyChanged("Max");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BaseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (MinElement != null) dest.MinElement = (UnsignedInt)MinElement.DeepCopy();
                    if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BaseComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BaseComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BaseComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PathElement != null) yield return PathElement;
                    if (MinElement != null) yield return MinElement;
                    if (MaxElement != null) yield return MaxElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (MinElement != null) yield return new ElementValue("min", MinElement);
                    if (MaxElement != null) yield return new ElementValue("max", MaxElement);
                }
            }


        }


        [FhirType("TypeRefComponent")]
        [DataContract]
        public partial class TypeRefComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TypeRefComponent"; } }

            /// <summary>
            /// Data type or Resource (reference to definition)
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private FhirUri _codeElement;

            /// <summary>
            /// Data type or Resource (reference to definition)
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
                        CodeElement = new FhirUri(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Profiles (StructureDefinition or IG) - one must apply
            /// </summary>
            [FhirElement("profile", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Canonical> ProfileElement
            {
                get { if (_profileElement==null) _profileElement = new List<Canonical>(); return _profileElement; }
                set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
            }

            private List<Canonical> _profileElement;

            /// <summary>
            /// Profiles (StructureDefinition or IG) - one must apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Profile
            {
                get { return ProfileElement != null ? ProfileElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ProfileElement = null;
                    else
                        ProfileElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                    OnPropertyChanged("Profile");
                }
            }

            /// <summary>
            /// Profile (StructureDefinition or IG) on the Reference/canonical target - one must apply
            /// </summary>
            [FhirElement("targetProfile", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Canonical> TargetProfileElement
            {
                get { if (_targetProfileElement==null) _targetProfileElement = new List<Canonical>(); return _targetProfileElement; }
                set { _targetProfileElement = value; OnPropertyChanged("TargetProfileElement"); }
            }

            private List<Canonical> _targetProfileElement;

            /// <summary>
            /// Profile (StructureDefinition or IG) on the Reference/canonical target - one must apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> TargetProfile
            {
                get { return TargetProfileElement != null ? TargetProfileElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        TargetProfileElement = null;
                    else
                        TargetProfileElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                    OnPropertyChanged("TargetProfile");
                }
            }

            /// <summary>
            /// contained | referenced | bundled - how aggregated
            /// </summary>
            [FhirElement("aggregation", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<AggregationMode>> AggregationElement
            {
                get { if (_aggregationElement==null) _aggregationElement = new List<Code<AggregationMode>>(); return _aggregationElement; }
                set { _aggregationElement = value; OnPropertyChanged("AggregationElement"); }
            }

            private List<Code<AggregationMode>> _aggregationElement;

            /// <summary>
            /// contained | referenced | bundled - how aggregated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<AggregationMode?> Aggregation
            {
                get { return AggregationElement != null ? AggregationElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        AggregationElement = null;
                    else
                        AggregationElement = new List<Code<AggregationMode>>(value.Select(elem=>new Code<AggregationMode>(elem)));
                    OnPropertyChanged("Aggregation");
                }
            }

            /// <summary>
            /// either | independent | specific
            /// </summary>
            [FhirElement("versioning", InSummary=true, Order=80)]
            [DataMember]
            public Code<ReferenceVersionRules> VersioningElement
            {
                get { return _versioningElement; }
                set { _versioningElement = value; OnPropertyChanged("VersioningElement"); }
            }

            private Code<ReferenceVersionRules> _versioningElement;

            /// <summary>
            /// either | independent | specific
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ReferenceVersionRules? Versioning
            {
                get { return VersioningElement != null ? VersioningElement.Value : null; }
                set
                {
                    if (value == null)
                        VersioningElement = null;
                    else
                        VersioningElement = new Code<ReferenceVersionRules>(value);
                    OnPropertyChanged("Versioning");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TypeRefComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (FhirUri)CodeElement.DeepCopy();
                    if (ProfileElement != null) dest.ProfileElement = new List<Canonical>(ProfileElement.DeepCopy());
                    if (TargetProfileElement != null) dest.TargetProfileElement = new List<Canonical>(TargetProfileElement.DeepCopy());
                    if (AggregationElement != null) dest.AggregationElement = new List<Code<AggregationMode>>(AggregationElement.DeepCopy());
                    if (VersioningElement != null) dest.VersioningElement = (Code<ReferenceVersionRules>)VersioningElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TypeRefComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TypeRefComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if ( !DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;
                if ( !DeepComparable.Matches(TargetProfileElement, otherT.TargetProfileElement)) return false;
                if ( !DeepComparable.Matches(AggregationElement, otherT.AggregationElement)) return false;
                if (!DeepComparable.Matches(VersioningElement, otherT.VersioningElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TypeRefComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
                if (!DeepComparable.IsExactly(TargetProfileElement, otherT.TargetProfileElement)) return false;
                if (!DeepComparable.IsExactly(AggregationElement, otherT.AggregationElement)) return false;
                if (!DeepComparable.IsExactly(VersioningElement, otherT.VersioningElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    foreach (var elem in ProfileElement) { if (elem != null) yield return elem; }
                    foreach (var elem in TargetProfileElement) { if (elem != null) yield return elem; }
                    foreach (var elem in AggregationElement) { if (elem != null) yield return elem; }
                    if (VersioningElement != null) yield return VersioningElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    foreach (var elem in ProfileElement) { if (elem != null) yield return new ElementValue("profile", elem); }
                    foreach (var elem in TargetProfileElement) { if (elem != null) yield return new ElementValue("targetProfile", elem); }
                    foreach (var elem in AggregationElement) { if (elem != null) yield return new ElementValue("aggregation", elem); }
                    if (VersioningElement != null) yield return new ElementValue("versioning", VersioningElement);
                }
            }


        }


        [FhirType("ExampleComponent")]
        [DataContract]
        public partial class ExampleComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExampleComponent"; } }

            /// <summary>
            /// Describes the purpose of this example
            /// </summary>
            [FhirElement("label", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString LabelElement
            {
                get { return _labelElement; }
                set { _labelElement = value; OnPropertyChanged("LabelElement"); }
            }

            private FhirString _labelElement;

            /// <summary>
            /// Describes the purpose of this example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if (value == null)
                        LabelElement = null;
                    else
                        LabelElement = new FhirString(value);
                    OnPropertyChanged("Label");
                }
            }

            /// <summary>
            /// Value of Example (one of allowed types)
            /// </summary>
            [FhirElement("value", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Canonical),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(FhirUrl),typeof(Uuid),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(ParameterDefinition),typeof(DataRequirement),typeof(RelatedArtifact),typeof(ContactDetail),typeof(Contributor),typeof(TriggerDefinition),typeof(Expression),typeof(UsageContext),typeof(Dosage))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExampleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LabelElement != null) dest.LabelElement = (FhirString)LabelElement.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExampleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExampleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExampleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LabelElement != null) yield return LabelElement;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LabelElement != null) yield return new ElementValue("label", LabelElement);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        [FhirType("ConstraintComponent")]
        [DataContract]
        public partial class ConstraintComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ConstraintComponent"; } }

            /// <summary>
            /// Target of 'condition' reference above
            /// </summary>
            [FhirElement("key", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id KeyElement
            {
                get { return _keyElement; }
                set { _keyElement = value; OnPropertyChanged("KeyElement"); }
            }

            private Id _keyElement;

            /// <summary>
            /// Target of 'condition' reference above
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Key
            {
                get { return KeyElement != null ? KeyElement.Value : null; }
                set
                {
                    if (value == null)
                        KeyElement = null;
                    else
                        KeyElement = new Id(value);
                    OnPropertyChanged("Key");
                }
            }

            /// <summary>
            /// Why this constraint is necessary or appropriate
            /// </summary>
            [FhirElement("requirements", InSummary=true, Order=50)]
            [DataMember]
            public FhirString RequirementsElement
            {
                get { return _requirementsElement; }
                set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
            }

            private FhirString _requirementsElement;

            /// <summary>
            /// Why this constraint is necessary or appropriate
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
            /// error | warning
            /// </summary>
            [FhirElement("severity", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConstraintSeverity> SeverityElement
            {
                get { return _severityElement; }
                set { _severityElement = value; OnPropertyChanged("SeverityElement"); }
            }

            private Code<ConstraintSeverity> _severityElement;

            /// <summary>
            /// error | warning
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConstraintSeverity? Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if (value == null)
                        SeverityElement = null;
                    else
                        SeverityElement = new Code<ConstraintSeverity>(value);
                    OnPropertyChanged("Severity");
                }
            }

            /// <summary>
            /// Human description of constraint
            /// </summary>
            [FhirElement("human", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString HumanElement
            {
                get { return _humanElement; }
                set { _humanElement = value; OnPropertyChanged("HumanElement"); }
            }

            private FhirString _humanElement;

            /// <summary>
            /// Human description of constraint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Human
            {
                get { return HumanElement != null ? HumanElement.Value : null; }
                set
                {
                    if (value == null)
                        HumanElement = null;
                    else
                        HumanElement = new FhirString(value);
                    OnPropertyChanged("Human");
                }
            }

            /// <summary>
            /// FHIRPath expression of constraint
            /// </summary>
            [FhirElement("expression", InSummary=true, Order=80)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// FHIRPath expression of constraint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new FhirString(value);
                    OnPropertyChanged("Expression");
                }
            }

            /// <summary>
            /// XPath expression of constraint
            /// </summary>
            [FhirElement("xpath", InSummary=true, Order=90)]
            [DataMember]
            public FhirString XpathElement
            {
                get { return _xpathElement; }
                set { _xpathElement = value; OnPropertyChanged("XpathElement"); }
            }

            private FhirString _xpathElement;

            /// <summary>
            /// XPath expression of constraint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Xpath
            {
                get { return XpathElement != null ? XpathElement.Value : null; }
                set
                {
                    if (value == null)
                        XpathElement = null;
                    else
                        XpathElement = new FhirString(value);
                    OnPropertyChanged("Xpath");
                }
            }

            /// <summary>
            /// Reference to original source of constraint
            /// </summary>
            [FhirElement("source", InSummary=true, Order=100)]
            [DataMember]
            public Canonical SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private Canonical _sourceElement;

            /// <summary>
            /// Reference to original source of constraint
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
                        SourceElement = new Canonical(value);
                    OnPropertyChanged("Source");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ConstraintComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (KeyElement != null) dest.KeyElement = (Id)KeyElement.DeepCopy();
                    if (RequirementsElement != null) dest.RequirementsElement = (FhirString)RequirementsElement.DeepCopy();
                    if (SeverityElement != null) dest.SeverityElement = (Code<ConstraintSeverity>)SeverityElement.DeepCopy();
                    if (HumanElement != null) dest.HumanElement = (FhirString)HumanElement.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                    if (XpathElement != null) dest.XpathElement = (FhirString)XpathElement.DeepCopy();
                    if (SourceElement != null) dest.SourceElement = (Canonical)SourceElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ConstraintComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ConstraintComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(KeyElement, otherT.KeyElement)) return false;
                if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
                if (!DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
                if (!DeepComparable.Matches(HumanElement, otherT.HumanElement)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
                if (!DeepComparable.Matches(XpathElement, otherT.XpathElement)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConstraintComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(KeyElement, otherT.KeyElement)) return false;
                if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
                if (!DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
                if (!DeepComparable.IsExactly(HumanElement, otherT.HumanElement)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
                if (!DeepComparable.IsExactly(XpathElement, otherT.XpathElement)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (KeyElement != null) yield return KeyElement;
                    if (RequirementsElement != null) yield return RequirementsElement;
                    if (SeverityElement != null) yield return SeverityElement;
                    if (HumanElement != null) yield return HumanElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                    if (XpathElement != null) yield return XpathElement;
                    if (SourceElement != null) yield return SourceElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (KeyElement != null) yield return new ElementValue("key", KeyElement);
                    if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                    if (SeverityElement != null) yield return new ElementValue("severity", SeverityElement);
                    if (HumanElement != null) yield return new ElementValue("human", HumanElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                    if (XpathElement != null) yield return new ElementValue("xpath", XpathElement);
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                }
            }


        }


        [FhirType("ElementDefinitionBindingComponent")]
        [DataContract]
        public partial class ElementDefinitionBindingComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ElementDefinitionBindingComponent"; } }

            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            [FhirElement("strength", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<BindingStrength> StrengthElement
            {
                get { return _strengthElement; }
                set { _strengthElement = value; OnPropertyChanged("StrengthElement"); }
            }

            private Code<BindingStrength> _strengthElement;

            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public BindingStrength? Strength
            {
                get { return StrengthElement != null ? StrengthElement.Value : null; }
                set
                {
                    if (value == null)
                        StrengthElement = null;
                    else
                        StrengthElement = new Code<BindingStrength>(value);
                    OnPropertyChanged("Strength");
                }
            }

            /// <summary>
            /// Human explanation of the value set
            /// </summary>
            [FhirElement("description", InSummary=true, Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Human explanation of the value set
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
            /// Source of value set
            /// </summary>
            [FhirElement("valueSet", InSummary=true, Order=60)]
            [DataMember]
            public Canonical ValueSetElement
            {
                get { return _valueSetElement; }
                set { _valueSetElement = value; OnPropertyChanged("ValueSetElement"); }
            }

            private Canonical _valueSetElement;

            /// <summary>
            /// Source of value set
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ValueSet
            {
                get { return ValueSetElement != null ? ValueSetElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueSetElement = null;
                    else
                        ValueSetElement = new Canonical(value);
                    OnPropertyChanged("ValueSet");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ElementDefinitionBindingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StrengthElement != null) dest.StrengthElement = (Code<BindingStrength>)StrengthElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (ValueSetElement != null) dest.ValueSetElement = (Canonical)ValueSetElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ElementDefinitionBindingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ElementDefinitionBindingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(ValueSetElement, otherT.ValueSetElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ElementDefinitionBindingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(ValueSetElement, otherT.ValueSetElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StrengthElement != null) yield return StrengthElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (ValueSetElement != null) yield return ValueSetElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StrengthElement != null) yield return new ElementValue("strength", StrengthElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (ValueSetElement != null) yield return new ElementValue("valueSet", ValueSetElement);
                }
            }


        }


        [FhirType("MappingComponent")]
        [DataContract]
        public partial class MappingComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MappingComponent"; } }

            /// <summary>
            /// Reference to mapping declaration
            /// </summary>
            [FhirElement("identity", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id IdentityElement
            {
                get { return _identityElement; }
                set { _identityElement = value; OnPropertyChanged("IdentityElement"); }
            }

            private Id _identityElement;

            /// <summary>
            /// Reference to mapping declaration
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Identity
            {
                get { return IdentityElement != null ? IdentityElement.Value : null; }
                set
                {
                    if (value == null)
                        IdentityElement = null;
                    else
                        IdentityElement = new Id(value);
                    OnPropertyChanged("Identity");
                }
            }

            /// <summary>
            /// Computable language of mapping
            /// </summary>
            [FhirElement("language", InSummary=true, Order=50)]
            [DataMember]
            public Code LanguageElement
            {
                get { return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private Code _languageElement;

            /// <summary>
            /// Computable language of mapping
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Language
            {
                get { return LanguageElement != null ? LanguageElement.Value : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new Code(value);
                    OnPropertyChanged("Language");
                }
            }

            /// <summary>
            /// Details of the mapping
            /// </summary>
            [FhirElement("map", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString MapElement
            {
                get { return _mapElement; }
                set { _mapElement = value; OnPropertyChanged("MapElement"); }
            }

            private FhirString _mapElement;

            /// <summary>
            /// Details of the mapping
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Map
            {
                get { return MapElement != null ? MapElement.Value : null; }
                set
                {
                    if (value == null)
                        MapElement = null;
                    else
                        MapElement = new FhirString(value);
                    OnPropertyChanged("Map");
                }
            }

            /// <summary>
            /// Comments about the mapping or its use
            /// </summary>
            [FhirElement("comment", InSummary=true, Order=70)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Comments about the mapping or its use
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MappingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (IdentityElement != null) dest.IdentityElement = (Id)IdentityElement.DeepCopy();
                    if (LanguageElement != null) dest.LanguageElement = (Code)LanguageElement.DeepCopy();
                    if (MapElement != null) dest.MapElement = (FhirString)MapElement.DeepCopy();
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MappingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(IdentityElement, otherT.IdentityElement)) return false;
                if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.Matches(MapElement, otherT.MapElement)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(IdentityElement, otherT.IdentityElement)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(MapElement, otherT.MapElement)) return false;
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IdentityElement != null) yield return IdentityElement;
                    if (LanguageElement != null) yield return LanguageElement;
                    if (MapElement != null) yield return MapElement;
                    if (CommentElement != null) yield return CommentElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IdentityElement != null) yield return new ElementValue("identity", IdentityElement);
                    if (LanguageElement != null) yield return new ElementValue("language", LanguageElement);
                    if (MapElement != null) yield return new ElementValue("map", MapElement);
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                }
            }


        }


        /// <summary>
        /// Path of the element in the hierarchy of elements
        /// </summary>
        [FhirElement("path", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString PathElement
        {
            get { return _pathElement; }
            set { _pathElement = value; OnPropertyChanged("PathElement"); }
        }

        private FhirString _pathElement;

        /// <summary>
        /// Path of the element in the hierarchy of elements
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Path
        {
            get { return PathElement != null ? PathElement.Value : null; }
            set
            {
                if (value == null)
                    PathElement = null;
                else
                    PathElement = new FhirString(value);
                OnPropertyChanged("Path");
            }
        }

        /// <summary>
        /// xmlAttr | xmlText | typeAttr | cdaText | xhtml
        /// </summary>
        [FhirElement("representation", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<PropertyRepresentation>> RepresentationElement
        {
            get { if (_representationElement==null) _representationElement = new List<Code<PropertyRepresentation>>(); return _representationElement; }
            set { _representationElement = value; OnPropertyChanged("RepresentationElement"); }
        }

        private List<Code<PropertyRepresentation>> _representationElement;

        /// <summary>
        /// xmlAttr | xmlText | typeAttr | cdaText | xhtml
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<PropertyRepresentation?> Representation
        {
            get { return RepresentationElement != null ? RepresentationElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    RepresentationElement = null;
                else
                    RepresentationElement = new List<Code<PropertyRepresentation>>(value.Select(elem=>new Code<PropertyRepresentation>(elem)));
                OnPropertyChanged("Representation");
            }
        }

        /// <summary>
        /// Name for this particular element (in a set of slices)
        /// </summary>
        [FhirElement("sliceName", InSummary=true, Order=110)]
        [DataMember]
        public FhirString SliceNameElement
        {
            get { return _sliceNameElement; }
            set { _sliceNameElement = value; OnPropertyChanged("SliceNameElement"); }
        }

        private FhirString _sliceNameElement;

        /// <summary>
        /// Name for this particular element (in a set of slices)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string SliceName
        {
            get { return SliceNameElement != null ? SliceNameElement.Value : null; }
            set
            {
                if (value == null)
                    SliceNameElement = null;
                else
                    SliceNameElement = new FhirString(value);
                OnPropertyChanged("SliceName");
            }
        }

        /// <summary>
        /// If this slice definition constrains an inherited slice definition (or not)
        /// </summary>
        [FhirElement("sliceIsConstraining", InSummary=true, Order=120)]
        [DataMember]
        public FhirBoolean SliceIsConstrainingElement
        {
            get { return _sliceIsConstrainingElement; }
            set { _sliceIsConstrainingElement = value; OnPropertyChanged("SliceIsConstrainingElement"); }
        }

        private FhirBoolean _sliceIsConstrainingElement;

        /// <summary>
        /// If this slice definition constrains an inherited slice definition (or not)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? SliceIsConstraining
        {
            get { return SliceIsConstrainingElement != null ? SliceIsConstrainingElement.Value : null; }
            set
            {
                if (value == null)
                    SliceIsConstrainingElement = null;
                else
                    SliceIsConstrainingElement = new FhirBoolean(value);
                OnPropertyChanged("SliceIsConstraining");
            }
        }

        /// <summary>
        /// Name for element to display with or prompt for element
        /// </summary>
        [FhirElement("label", InSummary=true, Order=130)]
        [DataMember]
        public FhirString LabelElement
        {
            get { return _labelElement; }
            set { _labelElement = value; OnPropertyChanged("LabelElement"); }
        }

        private FhirString _labelElement;

        /// <summary>
        /// Name for element to display with or prompt for element
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Label
        {
            get { return LabelElement != null ? LabelElement.Value : null; }
            set
            {
                if (value == null)
                    LabelElement = null;
                else
                    LabelElement = new FhirString(value);
                OnPropertyChanged("Label");
            }
        }

        /// <summary>
        /// Corresponding codes in terminologies
        /// </summary>
        [FhirElement("code", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Code
        {
            get { if (_code==null) _code = new List<Coding>(); return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private List<Coding> _code;

        /// <summary>
        /// This element is sliced - slices follow
        /// </summary>
        [FhirElement("slicing", InSummary=true, Order=150)]
        [DataMember]
        public SlicingComponent Slicing
        {
            get { return _slicing; }
            set { _slicing = value; OnPropertyChanged("Slicing"); }
        }

        private SlicingComponent _slicing;

        /// <summary>
        /// Concise definition for space-constrained presentation
        /// </summary>
        [FhirElement("short", InSummary=true, Order=160)]
        [DataMember]
        public FhirString ShortElement
        {
            get { return _shortElement; }
            set { _shortElement = value; OnPropertyChanged("ShortElement"); }
        }

        private FhirString _shortElement;

        /// <summary>
        /// Concise definition for space-constrained presentation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Short
        {
            get { return ShortElement != null ? ShortElement.Value : null; }
            set
            {
                if (value == null)
                    ShortElement = null;
                else
                    ShortElement = new FhirString(value);
                OnPropertyChanged("Short");
            }
        }

        /// <summary>
        /// Full formal definition as narrative text
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=170)]
        [DataMember]
        public Markdown DefinitionElement
        {
            get { return _definitionElement; }
            set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
        }

        private Markdown _definitionElement;

        /// <summary>
        /// Full formal definition as narrative text
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Definition
        {
            get { return DefinitionElement != null ? DefinitionElement.Value : null; }
            set
            {
                if (value == null)
                    DefinitionElement = null;
                else
                    DefinitionElement = new Markdown(value);
                OnPropertyChanged("Definition");
            }
        }

        /// <summary>
        /// Comments about the use of this element
        /// </summary>
        [FhirElement("comment", InSummary=true, Order=180)]
        [DataMember]
        public Markdown CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private Markdown _commentElement;

        /// <summary>
        /// Comments about the use of this element
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
                    CommentElement = new Markdown(value);
                OnPropertyChanged("Comment");
            }
        }

        /// <summary>
        /// Why this resource has been created
        /// </summary>
        [FhirElement("requirements", InSummary=true, Order=190)]
        [DataMember]
        public Markdown RequirementsElement
        {
            get { return _requirementsElement; }
            set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }

        private Markdown _requirementsElement;

        /// <summary>
        /// Why this resource has been created
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
                    RequirementsElement = new Markdown(value);
                OnPropertyChanged("Requirements");
            }
        }

        /// <summary>
        /// Other names
        /// </summary>
        [FhirElement("alias", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> AliasElement
        {
            get { if (_aliasElement==null) _aliasElement = new List<FhirString>(); return _aliasElement; }
            set { _aliasElement = value; OnPropertyChanged("AliasElement"); }
        }

        private List<FhirString> _aliasElement;

        /// <summary>
        /// Other names
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Alias
        {
            get { return AliasElement != null ? AliasElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    AliasElement = null;
                else
                    AliasElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Alias");
            }
        }

        /// <summary>
        /// Minimum Cardinality
        /// </summary>
        [FhirElement("min", InSummary=true, Order=210)]
        [DataMember]
        public UnsignedInt MinElement
        {
            get { return _minElement; }
            set { _minElement = value; OnPropertyChanged("MinElement"); }
        }

        private UnsignedInt _minElement;

        /// <summary>
        /// Minimum Cardinality
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Min
        {
            get { return MinElement != null ? MinElement.Value : null; }
            set
            {
                if (value == null)
                    MinElement = null;
                else
                    MinElement = new UnsignedInt(value);
                OnPropertyChanged("Min");
            }
        }

        /// <summary>
        /// Maximum Cardinality (a number or *)
        /// </summary>
        [FhirElement("max", InSummary=true, Order=220)]
        [DataMember]
        public FhirString MaxElement
        {
            get { return _maxElement; }
            set { _maxElement = value; OnPropertyChanged("MaxElement"); }
        }

        private FhirString _maxElement;

        /// <summary>
        /// Maximum Cardinality (a number or *)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Max
        {
            get { return MaxElement != null ? MaxElement.Value : null; }
            set
            {
                if (value == null)
                    MaxElement = null;
                else
                    MaxElement = new FhirString(value);
                OnPropertyChanged("Max");
            }
        }

        /// <summary>
        /// Base definition information for tools
        /// </summary>
        [FhirElement("base", InSummary=true, Order=230)]
        [DataMember]
        public BaseComponent Base
        {
            get { return _base; }
            set { _base = value; OnPropertyChanged("Base"); }
        }

        private BaseComponent _base;

        /// <summary>
        /// Reference to definition of content for the element
        /// </summary>
        [FhirElement("contentReference", InSummary=true, Order=240)]
        [DataMember]
        public FhirUri ContentReferenceElement
        {
            get { return _contentReferenceElement; }
            set { _contentReferenceElement = value; OnPropertyChanged("ContentReferenceElement"); }
        }

        private FhirUri _contentReferenceElement;

        /// <summary>
        /// Reference to definition of content for the element
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ContentReference
        {
            get { return ContentReferenceElement != null ? ContentReferenceElement.Value : null; }
            set
            {
                if (value == null)
                    ContentReferenceElement = null;
                else
                    ContentReferenceElement = new FhirUri(value);
                OnPropertyChanged("ContentReference");
            }
        }

        /// <summary>
        /// Data type and Profile for this element
        /// </summary>
        [FhirElement("type", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TypeRefComponent> Type
        {
            get { if (_type==null) _type = new List<TypeRefComponent>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<TypeRefComponent> _type;

        /// <summary>
        /// Specified value if missing from instance
        /// </summary>
        [FhirElement("defaultValue", InSummary=true, Order=260, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Canonical),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(FhirUrl),typeof(Uuid),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(ParameterDefinition),typeof(DataRequirement),typeof(RelatedArtifact),typeof(ContactDetail),typeof(Contributor),typeof(TriggerDefinition),typeof(Expression),typeof(UsageContext),typeof(Dosage))]
        [DataMember]
        public Element DefaultValue
        {
            get { return _defaultValue; }
            set { _defaultValue = value; OnPropertyChanged("DefaultValue"); }
        }

        private Element _defaultValue;

        /// <summary>
        /// Implicit meaning when this element is missing
        /// </summary>
        [FhirElement("meaningWhenMissing", InSummary=true, Order=270)]
        [DataMember]
        public Markdown MeaningWhenMissingElement
        {
            get { return _meaningWhenMissingElement; }
            set { _meaningWhenMissingElement = value; OnPropertyChanged("MeaningWhenMissingElement"); }
        }

        private Markdown _meaningWhenMissingElement;

        /// <summary>
        /// Implicit meaning when this element is missing
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string MeaningWhenMissing
        {
            get { return MeaningWhenMissingElement != null ? MeaningWhenMissingElement.Value : null; }
            set
            {
                if (value == null)
                    MeaningWhenMissingElement = null;
                else
                    MeaningWhenMissingElement = new Markdown(value);
                OnPropertyChanged("MeaningWhenMissing");
            }
        }

        /// <summary>
        /// What the order of the elements means
        /// </summary>
        [FhirElement("orderMeaning", InSummary=true, Order=280)]
        [DataMember]
        public FhirString OrderMeaningElement
        {
            get { return _orderMeaningElement; }
            set { _orderMeaningElement = value; OnPropertyChanged("OrderMeaningElement"); }
        }

        private FhirString _orderMeaningElement;

        /// <summary>
        /// What the order of the elements means
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OrderMeaning
        {
            get { return OrderMeaningElement != null ? OrderMeaningElement.Value : null; }
            set
            {
                if (value == null)
                    OrderMeaningElement = null;
                else
                    OrderMeaningElement = new FhirString(value);
                OnPropertyChanged("OrderMeaning");
            }
        }

        /// <summary>
        /// Value must be exactly this
        /// </summary>
        [FhirElement("fixed", InSummary=true, Order=290, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Canonical),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(FhirUrl),typeof(Uuid),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(ParameterDefinition),typeof(DataRequirement),typeof(RelatedArtifact),typeof(ContactDetail),typeof(Contributor),typeof(TriggerDefinition),typeof(Expression),typeof(UsageContext),typeof(Dosage))]
        [DataMember]
        public Element Fixed
        {
            get { return _fixed; }
            set { _fixed = value; OnPropertyChanged("Fixed"); }
        }

        private Element _fixed;

        /// <summary>
        /// Value must have at least these property values
        /// </summary>
        [FhirElement("pattern", InSummary=true, Order=300, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Canonical),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(FhirUrl),typeof(Uuid),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(ParameterDefinition),typeof(DataRequirement),typeof(RelatedArtifact),typeof(ContactDetail),typeof(Contributor),typeof(TriggerDefinition),typeof(Expression),typeof(UsageContext),typeof(Dosage))]
        [DataMember]
        public Element Pattern
        {
            get { return _pattern; }
            set { _pattern = value; OnPropertyChanged("Pattern"); }
        }

        private Element _pattern;

        /// <summary>
        /// Example value (as defined for type)
        /// </summary>
        [FhirElement("example", InSummary=true, Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ExampleComponent> Example
        {
            get { if (_example==null) _example = new List<ExampleComponent>(); return _example; }
            set { _example = value; OnPropertyChanged("Example"); }
        }

        private List<ExampleComponent> _example;

        /// <summary>
        /// Minimum Allowed Value (for some types)
        /// </summary>
        [FhirElement("minValue", InSummary=true, Order=320, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Date),typeof(FhirDateTime),typeof(Instant),typeof(Time),typeof(FhirDecimal),typeof(Integer),typeof(PositiveInt),typeof(UnsignedInt),typeof(Quantity))]
        [DataMember]
        public Element MinValue
        {
            get { return _minValue; }
            set { _minValue = value; OnPropertyChanged("MinValue"); }
        }

        private Element _minValue;

        /// <summary>
        /// Maximum Allowed Value (for some types)
        /// </summary>
        [FhirElement("maxValue", InSummary=true, Order=330, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Date),typeof(FhirDateTime),typeof(Instant),typeof(Time),typeof(FhirDecimal),typeof(Integer),typeof(PositiveInt),typeof(UnsignedInt),typeof(Quantity))]
        [DataMember]
        public Element MaxValue
        {
            get { return _maxValue; }
            set { _maxValue = value; OnPropertyChanged("MaxValue"); }
        }

        private Element _maxValue;

        /// <summary>
        /// Max length for strings
        /// </summary>
        [FhirElement("maxLength", InSummary=true, Order=340)]
        [DataMember]
        public Integer MaxLengthElement
        {
            get { return _maxLengthElement; }
            set { _maxLengthElement = value; OnPropertyChanged("MaxLengthElement"); }
        }

        private Integer _maxLengthElement;

        /// <summary>
        /// Max length for strings
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? MaxLength
        {
            get { return MaxLengthElement != null ? MaxLengthElement.Value : null; }
            set
            {
                if (value == null)
                    MaxLengthElement = null;
                else
                    MaxLengthElement = new Integer(value);
                OnPropertyChanged("MaxLength");
            }
        }

        /// <summary>
        /// Reference to invariant about presence
        /// </summary>
        [FhirElement("condition", InSummary=true, Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Id> ConditionElement
        {
            get { if (_conditionElement==null) _conditionElement = new List<Id>(); return _conditionElement; }
            set { _conditionElement = value; OnPropertyChanged("ConditionElement"); }
        }

        private List<Id> _conditionElement;

        /// <summary>
        /// Reference to invariant about presence
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Condition
        {
            get { return ConditionElement != null ? ConditionElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ConditionElement = null;
                else
                    ConditionElement = new List<Id>(value.Select(elem=>new Id(elem)));
                OnPropertyChanged("Condition");
            }
        }

        /// <summary>
        /// Condition that must evaluate to true
        /// </summary>
        [FhirElement("constraint", InSummary=true, Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ConstraintComponent> Constraint
        {
            get { if (_constraint==null) _constraint = new List<ConstraintComponent>(); return _constraint; }
            set { _constraint = value; OnPropertyChanged("Constraint"); }
        }

        private List<ConstraintComponent> _constraint;

        /// <summary>
        /// If the element must be supported
        /// </summary>
        [FhirElement("mustSupport", InSummary=true, Order=370)]
        [DataMember]
        public FhirBoolean MustSupportElement
        {
            get { return _mustSupportElement; }
            set { _mustSupportElement = value; OnPropertyChanged("MustSupportElement"); }
        }

        private FhirBoolean _mustSupportElement;

        /// <summary>
        /// If the element must be supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? MustSupport
        {
            get { return MustSupportElement != null ? MustSupportElement.Value : null; }
            set
            {
                if (value == null)
                    MustSupportElement = null;
                else
                    MustSupportElement = new FhirBoolean(value);
                OnPropertyChanged("MustSupport");
            }
        }

        /// <summary>
        /// If this modifies the meaning of other elements
        /// </summary>
        [FhirElement("isModifier", InSummary=true, Order=380)]
        [DataMember]
        public FhirBoolean IsModifierElement
        {
            get { return _isModifierElement; }
            set { _isModifierElement = value; OnPropertyChanged("IsModifierElement"); }
        }

        private FhirBoolean _isModifierElement;

        /// <summary>
        /// If this modifies the meaning of other elements
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IsModifier
        {
            get { return IsModifierElement != null ? IsModifierElement.Value : null; }
            set
            {
                if (value == null)
                    IsModifierElement = null;
                else
                    IsModifierElement = new FhirBoolean(value);
                OnPropertyChanged("IsModifier");
            }
        }

        /// <summary>
        /// Reason that this element is marked as a modifier
        /// </summary>
        [FhirElement("isModifierReason", InSummary=true, Order=390)]
        [DataMember]
        public FhirString IsModifierReasonElement
        {
            get { return _isModifierReasonElement; }
            set { _isModifierReasonElement = value; OnPropertyChanged("IsModifierReasonElement"); }
        }

        private FhirString _isModifierReasonElement;

        /// <summary>
        /// Reason that this element is marked as a modifier
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string IsModifierReason
        {
            get { return IsModifierReasonElement != null ? IsModifierReasonElement.Value : null; }
            set
            {
                if (value == null)
                    IsModifierReasonElement = null;
                else
                    IsModifierReasonElement = new FhirString(value);
                OnPropertyChanged("IsModifierReason");
            }
        }

        /// <summary>
        /// Include when _summary = true?
        /// </summary>
        [FhirElement("isSummary", InSummary=true, Order=400)]
        [DataMember]
        public FhirBoolean IsSummaryElement
        {
            get { return _isSummaryElement; }
            set { _isSummaryElement = value; OnPropertyChanged("IsSummaryElement"); }
        }

        private FhirBoolean _isSummaryElement;

        /// <summary>
        /// Include when _summary = true?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IsSummary
        {
            get { return IsSummaryElement != null ? IsSummaryElement.Value : null; }
            set
            {
                if (value == null)
                    IsSummaryElement = null;
                else
                    IsSummaryElement = new FhirBoolean(value);
                OnPropertyChanged("IsSummary");
            }
        }

        /// <summary>
        /// ValueSet details if this is coded
        /// </summary>
        [FhirElement("binding", InSummary=true, Order=410)]
        [DataMember]
        public ElementDefinitionBindingComponent Binding
        {
            get { return _binding; }
            set { _binding = value; OnPropertyChanged("Binding"); }
        }

        private ElementDefinitionBindingComponent _binding;

        /// <summary>
        /// Map element to another set of definitions
        /// </summary>
        [FhirElement("mapping", InSummary=true, Order=420)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MappingComponent> Mapping
        {
            get { if (_mapping==null) _mapping = new List<MappingComponent>(); return _mapping; }
            set { _mapping = value; OnPropertyChanged("Mapping"); }
        }

        private List<MappingComponent> _mapping;


        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_19 = new ElementDefinition.ConstraintComponent
        {
            Expression = "path.matches('[^\\\\s#\\\\/]+')",
            Key = "eld-19",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Element names cannot include some special characters",
            Xpath = "matches(path/@value, '[^\\s#\\/]+')"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "min.empty() or max.empty() or (max = '*') or iif(max != '*', min <= max.toInteger())",
            Key = "eld-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Min <= Max",
            Xpath = "not(exists(f:min)) or not(exists(f:max)) or (not(f:max/@value) and not(f:min/@value)) or (f:max/@value = '*') or (number(f:max/@value) >= f:min/@value)"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "contentReference.empty() or (type.empty() and defaultValue.empty() and fixed.empty() and pattern.empty() and example.empty() and minValue.empty() and maxValue.empty() and maxLength.empty() and binding.empty())",
            Key = "eld-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "if the element definition has a contentReference, it cannot have type, defaultValue, fixed, pattern, example, minValue, maxValue, maxLength, or binding",
            Xpath = "not(exists(f:contentReference) and (exists(f:type) or exists(f:*[starts-with(local-name(.), 'value')]) or exists(f:*[starts-with(local-name(.), 'defaultValue')])  or exists(f:*[starts-with(local-name(.), 'fixed')]) or exists(f:*[starts-with(local-name(.), 'pattern')]) or exists(f:*[starts-with(local-name(.), 'example')]) or exists(f:*[starts-with(local-name(.), 'f:minValue')]) or exists(f:*[starts-with(local-name(.), 'f:maxValue')]) or exists(f:maxLength) or exists(f:binding)))"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "pattern.empty() or (type.count() <= 1)",
            Key = "eld-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Pattern may only be specified if there is one type",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'pattern')])) or (count(f:type)<=1)"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "fixed.empty() or (type.count()  <= 1)",
            Key = "eld-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Fixed value may only be specified if there is one type",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'fixed')])) or (count(f:type)<=1)"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_11 = new ElementDefinition.ConstraintComponent
        {
            Expression = "binding.empty() or type.code.empty() or type.select((code = 'code') or (code = 'Coding') or (code='CodeableConcept') or (code = 'Quantity') or (code = 'string') or (code = 'uri')).exists()",
            Key = "eld-11",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Binding can only be present for coded elements, string, and uri",
            Xpath = "not(exists(f:binding)) or (count(f:type/f:code) = 0) or  f:type/f:code/@value=('code','Coding','CodeableConcept','Quantity','string', 'uri')"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_22 = new ElementDefinition.ConstraintComponent
        {
            Expression = "sliceIsConstraining.exists() implies sliceName.exists()",
            Key = "eld-22",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "sliceIsConstraining can only appear if slicename is present",
            Xpath = "exists(f:sliceName) or not(exists(f:sliceIsConstraining))"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "pattern.empty() or fixed.empty()",
            Key = "eld-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Pattern and value are mutually exclusive",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'pattern')])) or not(exists(f:*[starts-with(local-name(.), 'fixed')]))"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_14 = new ElementDefinition.ConstraintComponent
        {
            Expression = "constraint.select(key).isDistinct()",
            Key = "eld-14",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Constraints must be unique by key",
            Xpath = "count(f:constraint) = count(distinct-values(f:constraint/f:key/@value))"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_13 = new ElementDefinition.ConstraintComponent
        {
            Expression = "type.select(code).isDistinct()",
            Key = "eld-13",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Types must be unique by code",
            Xpath = "not(exists(for $type in f:type return $type/preceding-sibling::f:type[f:code/@value=$type/f:code/@value))"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_16 = new ElementDefinition.ConstraintComponent
        {
            Expression = "sliceName.empty() or sliceName.matches('^[a-zA-Z0-9\\\\/\\\\-_\\\\[\\\\]\\\\@]+$')",
            Key = "eld-16",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "sliceName must be composed of proper tokens separated by \"/\"",
            Xpath = "not(exists(f:sliceName/@value)) or matches(f:sliceName/@value, '^[a-zA-Z0-9\\/\\-_\\[\\]\\@]+$')"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_15 = new ElementDefinition.ConstraintComponent
        {
            Expression = "defaultValue.empty() or meaningWhenMissing.empty()",
            Key = "eld-15",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "default value and meaningWhenMissing are mutually exclusive",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'fixed')])) or not(exists(f:meaningWhenMissing))"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_18 = new ElementDefinition.ConstraintComponent
        {
            Expression = "isModifier implies isModifierReason.exists()",
            Key = "eld-18",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Must have a modifier reason if isModifier = true",
            Xpath = "not(f:isModifier/@value = 'true') or exists(f:isModifierReason)"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_20 = new ElementDefinition.ConstraintComponent
        {
            Expression = "path.matches('[A-Za-z][A-Za-z0-9]*(\\\\.[a-z][A-Za-z0-9]*)*')",
            Key = "eld-20",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Element names should be simple alphanumerics, or code generation tools may be broken",
            Xpath = "matches(path/@value, '[A-Za-z][A-Za-z0-9]*(\\.[a-z][A-Za-z0-9]*)*')"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "slicing.all(discriminator.exists() or description.exists())",
            Key = "eld-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If there are no discriminators, there must be a definition",
            Xpath = "(f:discriminator) or (f:description)"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "max.all(empty() or ($this = '*') or (toInteger() >= 0))",
            Key = "eld-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Max SHALL be a number or \"*\"",
            Xpath = "@value='*' or (normalize-space(@value)!='' and normalize-space(translate(@value, '0123456789',''))='')"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "type.all(aggregation.empty() or (code = 'Reference'))",
            Key = "eld-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Aggregation may only be specified if one of the allowed types for the element is a reference",
            Xpath = "not(exists(f:aggregation)) or exists(f:code[@value = 'Reference'])"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_17 = new ElementDefinition.ConstraintComponent
        {
            Expression = "type.all((code='Reference' or code = 'canonical') or targetProfile.empty())",
            Key = "eld-17",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "targetProfile is only allowed if the type is reference or canonical",
            Xpath = "not(exists(f:targetProfile)) or (f:code/@value = 'Reference')"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_21 = new ElementDefinition.ConstraintComponent
        {
            Expression = "constraint.all(expression.exists())",
            Key = "eld-21",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Constraints should have an expression or else validators will not be able to enforce them",
            Xpath = "exists(f:expression/@value)"
        };

        public static ElementDefinition.ConstraintComponent ElementDefinition_ELD_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "binding.all(valueSet.exists() implies (valueSet.startsWith('http:') or valueSet.startsWith('https') or valueSet.startsWith('urn:')))",
            Key = "eld-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "ValueSet SHALL start with http:// or https:// or urn:",
            Xpath = "(starts-with(string(f:valueSet/@value), 'http:') or starts-with(string(f:valueSet/@value), 'https:') or starts-with(string(f:valueSet/@value), 'urn:'))"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ElementDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                if (RepresentationElement != null) dest.RepresentationElement = new List<Code<PropertyRepresentation>>(RepresentationElement.DeepCopy());
                if (SliceNameElement != null) dest.SliceNameElement = (FhirString)SliceNameElement.DeepCopy();
                if (SliceIsConstrainingElement != null) dest.SliceIsConstrainingElement = (FhirBoolean)SliceIsConstrainingElement.DeepCopy();
                if (LabelElement != null) dest.LabelElement = (FhirString)LabelElement.DeepCopy();
                if (Code != null) dest.Code = new List<Coding>(Code.DeepCopy());
                if (Slicing != null) dest.Slicing = (SlicingComponent)Slicing.DeepCopy();
                if (ShortElement != null) dest.ShortElement = (FhirString)ShortElement.DeepCopy();
                if (DefinitionElement != null) dest.DefinitionElement = (Markdown)DefinitionElement.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (Markdown)CommentElement.DeepCopy();
                if (RequirementsElement != null) dest.RequirementsElement = (Markdown)RequirementsElement.DeepCopy();
                if (AliasElement != null) dest.AliasElement = new List<FhirString>(AliasElement.DeepCopy());
                if (MinElement != null) dest.MinElement = (UnsignedInt)MinElement.DeepCopy();
                if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                if (Base != null) dest.Base = (BaseComponent)Base.DeepCopy();
                if (ContentReferenceElement != null) dest.ContentReferenceElement = (FhirUri)ContentReferenceElement.DeepCopy();
                if (Type != null) dest.Type = new List<TypeRefComponent>(Type.DeepCopy());
                if (DefaultValue != null) dest.DefaultValue = (Element)DefaultValue.DeepCopy();
                if (MeaningWhenMissingElement != null) dest.MeaningWhenMissingElement = (Markdown)MeaningWhenMissingElement.DeepCopy();
                if (OrderMeaningElement != null) dest.OrderMeaningElement = (FhirString)OrderMeaningElement.DeepCopy();
                if (Fixed != null) dest.Fixed = (Element)Fixed.DeepCopy();
                if (Pattern != null) dest.Pattern = (Element)Pattern.DeepCopy();
                if (Example != null) dest.Example = new List<ExampleComponent>(Example.DeepCopy());
                if (MinValue != null) dest.MinValue = (Element)MinValue.DeepCopy();
                if (MaxValue != null) dest.MaxValue = (Element)MaxValue.DeepCopy();
                if (MaxLengthElement != null) dest.MaxLengthElement = (Integer)MaxLengthElement.DeepCopy();
                if (ConditionElement != null) dest.ConditionElement = new List<Id>(ConditionElement.DeepCopy());
                if (Constraint != null) dest.Constraint = new List<ConstraintComponent>(Constraint.DeepCopy());
                if (MustSupportElement != null) dest.MustSupportElement = (FhirBoolean)MustSupportElement.DeepCopy();
                if (IsModifierElement != null) dest.IsModifierElement = (FhirBoolean)IsModifierElement.DeepCopy();
                if (IsModifierReasonElement != null) dest.IsModifierReasonElement = (FhirString)IsModifierReasonElement.DeepCopy();
                if (IsSummaryElement != null) dest.IsSummaryElement = (FhirBoolean)IsSummaryElement.DeepCopy();
                if (Binding != null) dest.Binding = (ElementDefinitionBindingComponent)Binding.DeepCopy();
                if (Mapping != null) dest.Mapping = new List<MappingComponent>(Mapping.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ElementDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ElementDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
            if ( !DeepComparable.Matches(RepresentationElement, otherT.RepresentationElement)) return false;
            if (!DeepComparable.Matches(SliceNameElement, otherT.SliceNameElement)) return false;
            if (!DeepComparable.Matches(SliceIsConstrainingElement, otherT.SliceIsConstrainingElement)) return false;
            if (!DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
            if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Slicing, otherT.Slicing)) return false;
            if (!DeepComparable.Matches(ShortElement, otherT.ShortElement)) return false;
            if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
            if ( !DeepComparable.Matches(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
            if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;
            if (!DeepComparable.Matches(Base, otherT.Base)) return false;
            if (!DeepComparable.Matches(ContentReferenceElement, otherT.ContentReferenceElement)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(DefaultValue, otherT.DefaultValue)) return false;
            if (!DeepComparable.Matches(MeaningWhenMissingElement, otherT.MeaningWhenMissingElement)) return false;
            if (!DeepComparable.Matches(OrderMeaningElement, otherT.OrderMeaningElement)) return false;
            if (!DeepComparable.Matches(Fixed, otherT.Fixed)) return false;
            if (!DeepComparable.Matches(Pattern, otherT.Pattern)) return false;
            if ( !DeepComparable.Matches(Example, otherT.Example)) return false;
            if (!DeepComparable.Matches(MinValue, otherT.MinValue)) return false;
            if (!DeepComparable.Matches(MaxValue, otherT.MaxValue)) return false;
            if (!DeepComparable.Matches(MaxLengthElement, otherT.MaxLengthElement)) return false;
            if ( !DeepComparable.Matches(ConditionElement, otherT.ConditionElement)) return false;
            if ( !DeepComparable.Matches(Constraint, otherT.Constraint)) return false;
            if (!DeepComparable.Matches(MustSupportElement, otherT.MustSupportElement)) return false;
            if (!DeepComparable.Matches(IsModifierElement, otherT.IsModifierElement)) return false;
            if (!DeepComparable.Matches(IsModifierReasonElement, otherT.IsModifierReasonElement)) return false;
            if (!DeepComparable.Matches(IsSummaryElement, otherT.IsSummaryElement)) return false;
            if (!DeepComparable.Matches(Binding, otherT.Binding)) return false;
            if ( !DeepComparable.Matches(Mapping, otherT.Mapping)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ElementDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
            if (!DeepComparable.IsExactly(RepresentationElement, otherT.RepresentationElement)) return false;
            if (!DeepComparable.IsExactly(SliceNameElement, otherT.SliceNameElement)) return false;
            if (!DeepComparable.IsExactly(SliceIsConstrainingElement, otherT.SliceIsConstrainingElement)) return false;
            if (!DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Slicing, otherT.Slicing)) return false;
            if (!DeepComparable.IsExactly(ShortElement, otherT.ShortElement)) return false;
            if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.IsExactly(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
            if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;
            if (!DeepComparable.IsExactly(Base, otherT.Base)) return false;
            if (!DeepComparable.IsExactly(ContentReferenceElement, otherT.ContentReferenceElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(DefaultValue, otherT.DefaultValue)) return false;
            if (!DeepComparable.IsExactly(MeaningWhenMissingElement, otherT.MeaningWhenMissingElement)) return false;
            if (!DeepComparable.IsExactly(OrderMeaningElement, otherT.OrderMeaningElement)) return false;
            if (!DeepComparable.IsExactly(Fixed, otherT.Fixed)) return false;
            if (!DeepComparable.IsExactly(Pattern, otherT.Pattern)) return false;
            if (!DeepComparable.IsExactly(Example, otherT.Example)) return false;
            if (!DeepComparable.IsExactly(MinValue, otherT.MinValue)) return false;
            if (!DeepComparable.IsExactly(MaxValue, otherT.MaxValue)) return false;
            if (!DeepComparable.IsExactly(MaxLengthElement, otherT.MaxLengthElement)) return false;
            if (!DeepComparable.IsExactly(ConditionElement, otherT.ConditionElement)) return false;
            if (!DeepComparable.IsExactly(Constraint, otherT.Constraint)) return false;
            if (!DeepComparable.IsExactly(MustSupportElement, otherT.MustSupportElement)) return false;
            if (!DeepComparable.IsExactly(IsModifierElement, otherT.IsModifierElement)) return false;
            if (!DeepComparable.IsExactly(IsModifierReasonElement, otherT.IsModifierReasonElement)) return false;
            if (!DeepComparable.IsExactly(IsSummaryElement, otherT.IsSummaryElement)) return false;
            if (!DeepComparable.IsExactly(Binding, otherT.Binding)) return false;
            if (!DeepComparable.IsExactly(Mapping, otherT.Mapping)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (PathElement != null) yield return PathElement;
                foreach (var elem in RepresentationElement) { if (elem != null) yield return elem; }
                if (SliceNameElement != null) yield return SliceNameElement;
                if (SliceIsConstrainingElement != null) yield return SliceIsConstrainingElement;
                if (LabelElement != null) yield return LabelElement;
                foreach (var elem in Code) { if (elem != null) yield return elem; }
                if (Slicing != null) yield return Slicing;
                if (ShortElement != null) yield return ShortElement;
                if (DefinitionElement != null) yield return DefinitionElement;
                if (CommentElement != null) yield return CommentElement;
                if (RequirementsElement != null) yield return RequirementsElement;
                foreach (var elem in AliasElement) { if (elem != null) yield return elem; }
                if (MinElement != null) yield return MinElement;
                if (MaxElement != null) yield return MaxElement;
                if (Base != null) yield return Base;
                if (ContentReferenceElement != null) yield return ContentReferenceElement;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (DefaultValue != null) yield return DefaultValue;
                if (MeaningWhenMissingElement != null) yield return MeaningWhenMissingElement;
                if (OrderMeaningElement != null) yield return OrderMeaningElement;
                if (Fixed != null) yield return Fixed;
                if (Pattern != null) yield return Pattern;
                foreach (var elem in Example) { if (elem != null) yield return elem; }
                if (MinValue != null) yield return MinValue;
                if (MaxValue != null) yield return MaxValue;
                if (MaxLengthElement != null) yield return MaxLengthElement;
                foreach (var elem in ConditionElement) { if (elem != null) yield return elem; }
                foreach (var elem in Constraint) { if (elem != null) yield return elem; }
                if (MustSupportElement != null) yield return MustSupportElement;
                if (IsModifierElement != null) yield return IsModifierElement;
                if (IsModifierReasonElement != null) yield return IsModifierReasonElement;
                if (IsSummaryElement != null) yield return IsSummaryElement;
                if (Binding != null) yield return Binding;
                foreach (var elem in Mapping) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (PathElement != null) yield return new ElementValue("path", PathElement);
                foreach (var elem in RepresentationElement) { if (elem != null) yield return new ElementValue("representation", elem); }
                if (SliceNameElement != null) yield return new ElementValue("sliceName", SliceNameElement);
                if (SliceIsConstrainingElement != null) yield return new ElementValue("sliceIsConstraining", SliceIsConstrainingElement);
                if (LabelElement != null) yield return new ElementValue("label", LabelElement);
                foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                if (Slicing != null) yield return new ElementValue("slicing", Slicing);
                if (ShortElement != null) yield return new ElementValue("short", ShortElement);
                if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                foreach (var elem in AliasElement) { if (elem != null) yield return new ElementValue("alias", elem); }
                if (MinElement != null) yield return new ElementValue("min", MinElement);
                if (MaxElement != null) yield return new ElementValue("max", MaxElement);
                if (Base != null) yield return new ElementValue("base", Base);
                if (ContentReferenceElement != null) yield return new ElementValue("contentReference", ContentReferenceElement);
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                if (DefaultValue != null) yield return new ElementValue("defaultValue", DefaultValue);
                if (MeaningWhenMissingElement != null) yield return new ElementValue("meaningWhenMissing", MeaningWhenMissingElement);
                if (OrderMeaningElement != null) yield return new ElementValue("orderMeaning", OrderMeaningElement);
                if (Fixed != null) yield return new ElementValue("fixed", Fixed);
                if (Pattern != null) yield return new ElementValue("pattern", Pattern);
                foreach (var elem in Example) { if (elem != null) yield return new ElementValue("example", elem); }
                if (MinValue != null) yield return new ElementValue("minValue", MinValue);
                if (MaxValue != null) yield return new ElementValue("maxValue", MaxValue);
                if (MaxLengthElement != null) yield return new ElementValue("maxLength", MaxLengthElement);
                foreach (var elem in ConditionElement) { if (elem != null) yield return new ElementValue("condition", elem); }
                foreach (var elem in Constraint) { if (elem != null) yield return new ElementValue("constraint", elem); }
                if (MustSupportElement != null) yield return new ElementValue("mustSupport", MustSupportElement);
                if (IsModifierElement != null) yield return new ElementValue("isModifier", IsModifierElement);
                if (IsModifierReasonElement != null) yield return new ElementValue("isModifierReason", IsModifierReasonElement);
                if (IsSummaryElement != null) yield return new ElementValue("isSummary", IsSummaryElement);
                if (Binding != null) yield return new ElementValue("binding", Binding);
                foreach (var elem in Mapping) { if (elem != null) yield return new ElementValue("mapping", elem); }
            }
        }

    }

}
