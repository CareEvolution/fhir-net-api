﻿using System;
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
    /// Declares the existence of and describes a code system or code system supplement
    /// </summary>
    [FhirType("CodeSystem", IsResource=true)]
    [DataContract]
    public partial class CodeSystem : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.CodeSystem; } }
        [NotMapped]
        public override string TypeName { get { return "CodeSystem"; } }

        /// <summary>
        /// The meaning of the hierarchy of concepts in a code system.
        /// (url: http://hl7.org/fhir/ValueSet/codesystem-hierarchy-meaning)
        /// </summary>
        [FhirEnumeration("CodeSystemHierarchyMeaning")]
        public enum CodeSystemHierarchyMeaning
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-hierarchy-meaning)
            /// </summary>
            [EnumLiteral("grouped-by", "http://hl7.org/fhir/codesystem-hierarchy-meaning"), Description("Grouped By")]
            GroupedBy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-hierarchy-meaning)
            /// </summary>
            [EnumLiteral("is-a", "http://hl7.org/fhir/codesystem-hierarchy-meaning"), Description("Is-A")]
            IsA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-hierarchy-meaning)
            /// </summary>
            [EnumLiteral("part-of", "http://hl7.org/fhir/codesystem-hierarchy-meaning"), Description("Part Of")]
            PartOf,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-hierarchy-meaning)
            /// </summary>
            [EnumLiteral("classified-with", "http://hl7.org/fhir/codesystem-hierarchy-meaning"), Description("Classified With")]
            ClassifiedWith,
        }

        /// <summary>
        /// The extent of the content of the code system (the concepts and codes it defines) are represented in a code system resource.
        /// (url: http://hl7.org/fhir/ValueSet/codesystem-content-mode)
        /// </summary>
        [FhirEnumeration("CodeSystemContentMode")]
        public enum CodeSystemContentMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-content-mode)
            /// </summary>
            [EnumLiteral("not-present", "http://hl7.org/fhir/codesystem-content-mode"), Description("Not Present")]
            NotPresent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-content-mode)
            /// </summary>
            [EnumLiteral("example", "http://hl7.org/fhir/codesystem-content-mode"), Description("Example")]
            Example,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-content-mode)
            /// </summary>
            [EnumLiteral("fragment", "http://hl7.org/fhir/codesystem-content-mode"), Description("Fragment")]
            Fragment,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-content-mode)
            /// </summary>
            [EnumLiteral("complete", "http://hl7.org/fhir/codesystem-content-mode"), Description("Complete")]
            Complete,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/codesystem-content-mode)
            /// </summary>
            [EnumLiteral("supplement", "http://hl7.org/fhir/codesystem-content-mode"), Description("Supplement")]
            Supplement,
        }

        /// <summary>
        /// The type of a property value.
        /// (url: http://hl7.org/fhir/ValueSet/concept-property-type)
        /// </summary>
        [FhirEnumeration("PropertyType")]
        public enum PropertyType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("code", "http://hl7.org/fhir/concept-property-type"), Description("code (internal reference)")]
            Code,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("Coding", "http://hl7.org/fhir/concept-property-type"), Description("Coding (external reference)")]
            Coding,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("string", "http://hl7.org/fhir/concept-property-type"), Description("string")]
            String,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("integer", "http://hl7.org/fhir/concept-property-type"), Description("integer")]
            Integer,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("boolean", "http://hl7.org/fhir/concept-property-type"), Description("boolean")]
            Boolean,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("dateTime", "http://hl7.org/fhir/concept-property-type"), Description("dateTime")]
            DateTime,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-property-type)
            /// </summary>
            [EnumLiteral("decimal", "http://hl7.org/fhir/concept-property-type"), Description("decimal")]
            Decimal,
        }


        [FhirType("FilterComponent")]
        [DataContract]
        public partial class FilterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FilterComponent"; } }

            /// <summary>
            /// Code that identifies the filter
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Code that identifies the filter
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
            /// How or why the filter is used
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
            /// How or why the filter is used
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
            /// Operators that can be used with filter
            /// </summary>
            [FhirElement("operator", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Code<FilterOperator>> OperatorElement
            {
                get { if (_operatorElement==null) _operatorElement = new List<Code<FilterOperator>>(); return _operatorElement; }
                set { _operatorElement = value; OnPropertyChanged("OperatorElement"); }
            }

            private List<Code<FilterOperator>> _operatorElement;

            /// <summary>
            /// Operators that can be used with filter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<FilterOperator?> Operator
            {
                get { return OperatorElement != null ? OperatorElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OperatorElement = null;
                    else
                        OperatorElement = new List<Code<FilterOperator>>(value.Select(elem=>new Code<FilterOperator>(elem)));
                    OnPropertyChanged("Operator");
                }
            }

            /// <summary>
            /// What to use for the value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// What to use for the value
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FilterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (OperatorElement != null) dest.OperatorElement = new List<Code<FilterOperator>>(OperatorElement.DeepCopy());
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FilterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FilterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FilterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in OperatorElement) { if (elem != null) yield return elem; }
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in OperatorElement) { if (elem != null) yield return new ElementValue("operator", elem); }
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("PropertyComponent")]
        [DataContract]
        public partial class PropertyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PropertyComponent"; } }

            /// <summary>
            /// Identifies the property on the concepts, and when referred to in operations
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Identifies the property on the concepts, and when referred to in operations
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
            /// Formal identifier for the property
            /// </summary>
            [FhirElement("uri", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private FhirUri _uriElement;

            /// <summary>
            /// Formal identifier for the property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }

            /// <summary>
            /// Why the property is defined, and/or what it conveys
            /// </summary>
            [FhirElement("description", InSummary=true, Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Why the property is defined, and/or what it conveys
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
            /// code | Coding | string | integer | boolean | dateTime | decimal
            /// </summary>
            [FhirElement("type", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<PropertyType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<PropertyType> _typeElement;

            /// <summary>
            /// code | Coding | string | integer | boolean | dateTime | decimal
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public PropertyType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<PropertyType>(value);
                    OnPropertyChanged("Type");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PropertyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (UriElement != null) dest.UriElement = (FhirUri)UriElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<PropertyType>)TypeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PropertyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (UriElement != null) yield return UriElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (TypeElement != null) yield return TypeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                }
            }


        }


        [FhirType("ConceptDefinitionComponent")]
        [DataContract]
        public partial class ConceptDefinitionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ConceptDefinitionComponent"; } }

            /// <summary>
            /// Code that identifies concept
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Code that identifies concept
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
            /// Text to display to the user
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
            /// Text to display to the user
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
            /// Formal definition
            /// </summary>
            [FhirElement("definition", Order=60)]
            [DataMember]
            public FhirString DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private FhirString _definitionElement;

            /// <summary>
            /// Formal definition
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
                        DefinitionElement = new FhirString(value);
                    OnPropertyChanged("Definition");
                }
            }

            /// <summary>
            /// Additional representations for the concept
            /// </summary>
            [FhirElement("designation", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DesignationComponent> Designation
            {
                get { if (_designation==null) _designation = new List<DesignationComponent>(); return _designation; }
                set { _designation = value; OnPropertyChanged("Designation"); }
            }

            private List<DesignationComponent> _designation;

            /// <summary>
            /// Property value for the concept
            /// </summary>
            [FhirElement("property", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ConceptPropertyComponent> Property
            {
                get { if (_property==null) _property = new List<ConceptPropertyComponent>(); return _property; }
                set { _property = value; OnPropertyChanged("Property"); }
            }

            private List<ConceptPropertyComponent> _property;

            /// <summary>
            /// Child Concepts (is-a/contains/categorizes)
            /// </summary>
            [FhirElement("concept", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ConceptDefinitionComponent> Concept
            {
                get { if (_concept==null) _concept = new List<ConceptDefinitionComponent>(); return _concept; }
                set { _concept = value; OnPropertyChanged("Concept"); }
            }

            private List<ConceptDefinitionComponent> _concept;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ConceptDefinitionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (FhirString)DefinitionElement.DeepCopy();
                    if (Designation != null) dest.Designation = new List<DesignationComponent>(Designation.DeepCopy());
                    if (Property != null) dest.Property = new List<ConceptPropertyComponent>(Property.DeepCopy());
                    if (Concept != null) dest.Concept = new List<ConceptDefinitionComponent>(Concept.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ConceptDefinitionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ConceptDefinitionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if ( !DeepComparable.Matches(Designation, otherT.Designation)) return false;
                if ( !DeepComparable.Matches(Property, otherT.Property)) return false;
                if ( !DeepComparable.Matches(Concept, otherT.Concept)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConceptDefinitionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.IsExactly(Designation, otherT.Designation)) return false;
                if (!DeepComparable.IsExactly(Property, otherT.Property)) return false;
                if (!DeepComparable.IsExactly(Concept, otherT.Concept)) return false;

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
                    if (DefinitionElement != null) yield return DefinitionElement;
                    foreach (var elem in Designation) { if (elem != null) yield return elem; }
                    foreach (var elem in Property) { if (elem != null) yield return elem; }
                    foreach (var elem in Concept) { if (elem != null) yield return elem; }
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
                    if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
                    foreach (var elem in Designation) { if (elem != null) yield return new ElementValue("designation", elem); }
                    foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
                    foreach (var elem in Concept) { if (elem != null) yield return new ElementValue("concept", elem); }
                }
            }


        }


        [FhirType("DesignationComponent")]
        [DataContract]
        public partial class DesignationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationComponent"; } }

            /// <summary>
            /// Human language of the designation
            /// </summary>
            [FhirElement("language", Order=40)]
            [DataMember]
            public Code LanguageElement
            {
                get { return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private Code _languageElement;

            /// <summary>
            /// Human language of the designation
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
            /// Details how this designation would be used
            /// </summary>
            [FhirElement("use", Order=50)]
            [DataMember]
            public Coding Use
            {
                get { return _use; }
                set { _use = value; OnPropertyChanged("Use"); }
            }

            private Coding _use;

            /// <summary>
            /// The text value for this designation
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
            /// The text value for this designation
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LanguageElement != null) dest.LanguageElement = (Code)LanguageElement.DeepCopy();
                    if (Use != null) dest.Use = (Coding)Use.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DesignationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DesignationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.Matches(Use, otherT.Use)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(Use, otherT.Use)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LanguageElement != null) yield return LanguageElement;
                    if (Use != null) yield return Use;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LanguageElement != null) yield return new ElementValue("language", LanguageElement);
                    if (Use != null) yield return new ElementValue("use", Use);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("ConceptPropertyComponent")]
        [DataContract]
        public partial class ConceptPropertyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ConceptPropertyComponent"; } }

            /// <summary>
            /// Reference to CodeSystem.property.code
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Reference to CodeSystem.property.code
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
            /// Value of the property for this concept
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Code),typeof(Coding),typeof(FhirString),typeof(Integer),typeof(FhirBoolean),typeof(FhirDateTime),typeof(FhirDecimal))]
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
                var dest = other as ConceptPropertyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ConceptPropertyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ConceptPropertyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConceptPropertyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this code system, represented as a URI (globally unique) (Coding.system)
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
        /// Canonical identifier for this code system, represented as a URI (globally unique) (Coding.system)
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
        /// Additional identifier for the code system
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Business version of the code system (Coding.version)
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
        /// Business version of the code system (Coding.version)
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
        /// Name for this code system (computer friendly)
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
        /// Name for this code system (computer friendly)
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
        /// Name for this code system (human friendly)
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
        /// Name for this code system (human friendly)
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
        /// Natural language description of the code system
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
        /// Intended jurisdiction for code system (if applicable)
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
        /// Why this code system is defined
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
        /// If code comparison is case sensitive
        /// </summary>
        [FhirElement("caseSensitive", InSummary=true, Order=240)]
        [DataMember]
        public FhirBoolean CaseSensitiveElement
        {
            get { return _caseSensitiveElement; }
            set { _caseSensitiveElement = value; OnPropertyChanged("CaseSensitiveElement"); }
        }

        private FhirBoolean _caseSensitiveElement;

        /// <summary>
        /// If code comparison is case sensitive
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? CaseSensitive
        {
            get { return CaseSensitiveElement != null ? CaseSensitiveElement.Value : null; }
            set
            {
                if (value == null)
                    CaseSensitiveElement = null;
                else
                    CaseSensitiveElement = new FhirBoolean(value);
                OnPropertyChanged("CaseSensitive");
            }
        }

        /// <summary>
        /// Canonical URL for value set with entire code system
        /// </summary>
        [FhirElement("valueSet", InSummary=true, Order=250)]
        [DataMember]
        public Canonical ValueSetElement
        {
            get { return _valueSetElement; }
            set { _valueSetElement = value; OnPropertyChanged("ValueSetElement"); }
        }

        private Canonical _valueSetElement;

        /// <summary>
        /// Canonical URL for value set with entire code system
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

        /// <summary>
        /// grouped-by | is-a | part-of | classified-with
        /// </summary>
        [FhirElement("hierarchyMeaning", InSummary=true, Order=260)]
        [DataMember]
        public Code<CodeSystemHierarchyMeaning> HierarchyMeaningElement
        {
            get { return _hierarchyMeaningElement; }
            set { _hierarchyMeaningElement = value; OnPropertyChanged("HierarchyMeaningElement"); }
        }

        private Code<CodeSystemHierarchyMeaning> _hierarchyMeaningElement;

        /// <summary>
        /// grouped-by | is-a | part-of | classified-with
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CodeSystemHierarchyMeaning? HierarchyMeaning
        {
            get { return HierarchyMeaningElement != null ? HierarchyMeaningElement.Value : null; }
            set
            {
                if (value == null)
                    HierarchyMeaningElement = null;
                else
                    HierarchyMeaningElement = new Code<CodeSystemHierarchyMeaning>(value);
                OnPropertyChanged("HierarchyMeaning");
            }
        }

        /// <summary>
        /// If code system defines a compositional grammar
        /// </summary>
        [FhirElement("compositional", InSummary=true, Order=270)]
        [DataMember]
        public FhirBoolean CompositionalElement
        {
            get { return _compositionalElement; }
            set { _compositionalElement = value; OnPropertyChanged("CompositionalElement"); }
        }

        private FhirBoolean _compositionalElement;

        /// <summary>
        /// If code system defines a compositional grammar
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Compositional
        {
            get { return CompositionalElement != null ? CompositionalElement.Value : null; }
            set
            {
                if (value == null)
                    CompositionalElement = null;
                else
                    CompositionalElement = new FhirBoolean(value);
                OnPropertyChanged("Compositional");
            }
        }

        /// <summary>
        /// If definitions are not stable
        /// </summary>
        [FhirElement("versionNeeded", InSummary=true, Order=280)]
        [DataMember]
        public FhirBoolean VersionNeededElement
        {
            get { return _versionNeededElement; }
            set { _versionNeededElement = value; OnPropertyChanged("VersionNeededElement"); }
        }

        private FhirBoolean _versionNeededElement;

        /// <summary>
        /// If definitions are not stable
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? VersionNeeded
        {
            get { return VersionNeededElement != null ? VersionNeededElement.Value : null; }
            set
            {
                if (value == null)
                    VersionNeededElement = null;
                else
                    VersionNeededElement = new FhirBoolean(value);
                OnPropertyChanged("VersionNeeded");
            }
        }

        /// <summary>
        /// not-present | example | fragment | complete | supplement
        /// </summary>
        [FhirElement("content", InSummary=true, Order=290)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CodeSystemContentMode> ContentElement
        {
            get { return _contentElement; }
            set { _contentElement = value; OnPropertyChanged("ContentElement"); }
        }

        private Code<CodeSystemContentMode> _contentElement;

        /// <summary>
        /// not-present | example | fragment | complete | supplement
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CodeSystemContentMode? Content
        {
            get { return ContentElement != null ? ContentElement.Value : null; }
            set
            {
                if (value == null)
                    ContentElement = null;
                else
                    ContentElement = new Code<CodeSystemContentMode>(value);
                OnPropertyChanged("Content");
            }
        }

        /// <summary>
        /// Code System this adds designations and properties to
        /// </summary>
        [FhirElement("supplements", InSummary=true, Order=300)]
        [DataMember]
        public Canonical SupplementsElement
        {
            get { return _supplementsElement; }
            set { _supplementsElement = value; OnPropertyChanged("SupplementsElement"); }
        }

        private Canonical _supplementsElement;

        /// <summary>
        /// Code System this adds designations and properties to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Supplements
        {
            get { return SupplementsElement != null ? SupplementsElement.Value : null; }
            set
            {
                if (value == null)
                    SupplementsElement = null;
                else
                    SupplementsElement = new Canonical(value);
                OnPropertyChanged("Supplements");
            }
        }

        /// <summary>
        /// Total concepts in the code system
        /// </summary>
        [FhirElement("count", InSummary=true, Order=310)]
        [DataMember]
        public UnsignedInt CountElement
        {
            get { return _countElement; }
            set { _countElement = value; OnPropertyChanged("CountElement"); }
        }

        private UnsignedInt _countElement;

        /// <summary>
        /// Total concepts in the code system
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Count
        {
            get { return CountElement != null ? CountElement.Value : null; }
            set
            {
                if (value == null)
                    CountElement = null;
                else
                    CountElement = new UnsignedInt(value);
                OnPropertyChanged("Count");
            }
        }

        /// <summary>
        /// Filter that can be used in a value set
        /// </summary>
        [FhirElement("filter", InSummary=true, Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FilterComponent> Filter
        {
            get { if (_filter==null) _filter = new List<FilterComponent>(); return _filter; }
            set { _filter = value; OnPropertyChanged("Filter"); }
        }

        private List<FilterComponent> _filter;

        /// <summary>
        /// Additional information supplied about each concept
        /// </summary>
        [FhirElement("property", InSummary=true, Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PropertyComponent> Property
        {
            get { if (_property==null) _property = new List<PropertyComponent>(); return _property; }
            set { _property = value; OnPropertyChanged("Property"); }
        }

        private List<PropertyComponent> _property;

        /// <summary>
        /// Concepts in the code system
        /// </summary>
        [FhirElement("concept", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ConceptDefinitionComponent> Concept
        {
            get { if (_concept==null) _concept = new List<ConceptDefinitionComponent>(); return _concept; }
            set { _concept = value; OnPropertyChanged("Concept"); }
        }

        private List<ConceptDefinitionComponent> _concept;


        public static ElementDefinition.ConstraintComponent CodeSystem_CSD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "concept.code.combine($this.descendants().concept.code).isDistinct()",
            Key = "csd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Within a code system definition, all the codes SHALL be unique",
            Xpath = "count(distinct-values(descendant::f:concept/f:code/@value))=count(descendant::f:concept)"
        };

        public static ElementDefinition.ConstraintComponent CodeSystem_CSD_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "csd-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(CodeSystem_CSD_1);
            InvariantConstraints.Add(CodeSystem_CSD_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as CodeSystem;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
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
                if (CaseSensitiveElement != null) dest.CaseSensitiveElement = (FhirBoolean)CaseSensitiveElement.DeepCopy();
                if (ValueSetElement != null) dest.ValueSetElement = (Canonical)ValueSetElement.DeepCopy();
                if (HierarchyMeaningElement != null) dest.HierarchyMeaningElement = (Code<CodeSystemHierarchyMeaning>)HierarchyMeaningElement.DeepCopy();
                if (CompositionalElement != null) dest.CompositionalElement = (FhirBoolean)CompositionalElement.DeepCopy();
                if (VersionNeededElement != null) dest.VersionNeededElement = (FhirBoolean)VersionNeededElement.DeepCopy();
                if (ContentElement != null) dest.ContentElement = (Code<CodeSystemContentMode>)ContentElement.DeepCopy();
                if (SupplementsElement != null) dest.SupplementsElement = (Canonical)SupplementsElement.DeepCopy();
                if (CountElement != null) dest.CountElement = (UnsignedInt)CountElement.DeepCopy();
                if (Filter != null) dest.Filter = new List<FilterComponent>(Filter.DeepCopy());
                if (Property != null) dest.Property = new List<PropertyComponent>(Property.DeepCopy());
                if (Concept != null) dest.Concept = new List<ConceptDefinitionComponent>(Concept.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new CodeSystem());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as CodeSystem;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
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
            if (!DeepComparable.Matches(CaseSensitiveElement, otherT.CaseSensitiveElement)) return false;
            if (!DeepComparable.Matches(ValueSetElement, otherT.ValueSetElement)) return false;
            if (!DeepComparable.Matches(HierarchyMeaningElement, otherT.HierarchyMeaningElement)) return false;
            if (!DeepComparable.Matches(CompositionalElement, otherT.CompositionalElement)) return false;
            if (!DeepComparable.Matches(VersionNeededElement, otherT.VersionNeededElement)) return false;
            if (!DeepComparable.Matches(ContentElement, otherT.ContentElement)) return false;
            if (!DeepComparable.Matches(SupplementsElement, otherT.SupplementsElement)) return false;
            if (!DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
            if ( !DeepComparable.Matches(Filter, otherT.Filter)) return false;
            if ( !DeepComparable.Matches(Property, otherT.Property)) return false;
            if ( !DeepComparable.Matches(Concept, otherT.Concept)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CodeSystem;
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
            if (!DeepComparable.IsExactly(CaseSensitiveElement, otherT.CaseSensitiveElement)) return false;
            if (!DeepComparable.IsExactly(ValueSetElement, otherT.ValueSetElement)) return false;
            if (!DeepComparable.IsExactly(HierarchyMeaningElement, otherT.HierarchyMeaningElement)) return false;
            if (!DeepComparable.IsExactly(CompositionalElement, otherT.CompositionalElement)) return false;
            if (!DeepComparable.IsExactly(VersionNeededElement, otherT.VersionNeededElement)) return false;
            if (!DeepComparable.IsExactly(ContentElement, otherT.ContentElement)) return false;
            if (!DeepComparable.IsExactly(SupplementsElement, otherT.SupplementsElement)) return false;
            if (!DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
            if (!DeepComparable.IsExactly(Filter, otherT.Filter)) return false;
            if (!DeepComparable.IsExactly(Property, otherT.Property)) return false;
            if (!DeepComparable.IsExactly(Concept, otherT.Concept)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
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
                if (CaseSensitiveElement != null) yield return CaseSensitiveElement;
                if (ValueSetElement != null) yield return ValueSetElement;
                if (HierarchyMeaningElement != null) yield return HierarchyMeaningElement;
                if (CompositionalElement != null) yield return CompositionalElement;
                if (VersionNeededElement != null) yield return VersionNeededElement;
                if (ContentElement != null) yield return ContentElement;
                if (SupplementsElement != null) yield return SupplementsElement;
                if (CountElement != null) yield return CountElement;
                foreach (var elem in Filter) { if (elem != null) yield return elem; }
                foreach (var elem in Property) { if (elem != null) yield return elem; }
                foreach (var elem in Concept) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
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
                if (CaseSensitiveElement != null) yield return new ElementValue("caseSensitive", CaseSensitiveElement);
                if (ValueSetElement != null) yield return new ElementValue("valueSet", ValueSetElement);
                if (HierarchyMeaningElement != null) yield return new ElementValue("hierarchyMeaning", HierarchyMeaningElement);
                if (CompositionalElement != null) yield return new ElementValue("compositional", CompositionalElement);
                if (VersionNeededElement != null) yield return new ElementValue("versionNeeded", VersionNeededElement);
                if (ContentElement != null) yield return new ElementValue("content", ContentElement);
                if (SupplementsElement != null) yield return new ElementValue("supplements", SupplementsElement);
                if (CountElement != null) yield return new ElementValue("count", CountElement);
                foreach (var elem in Filter) { if (elem != null) yield return new ElementValue("filter", elem); }
                foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
                foreach (var elem in Concept) { if (elem != null) yield return new ElementValue("concept", elem); }
            }
        }

    }

}
