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
    /// Search Parameter for a resource
    /// </summary>
    [FhirType("SearchParameter", IsResource=true)]
    [DataContract]
    public partial class SearchParameter : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SearchParameter; } }
        [NotMapped]
        public override string TypeName { get { return "SearchParameter"; } }


        [FhirType("ComponentComponent")]
        [DataContract]
        public partial class ComponentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ComponentComponent"; } }

            /// <summary>
            /// Defines how the part works
            /// </summary>
            [FhirElement("definition", Order=40)]
            [References("SearchParameter")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Definition
            {
                get { return _definition; }
                set { _definition = value; OnPropertyChanged("Definition"); }
            }

            private ResourceReference _definition;

            /// <summary>
            /// Subexpression relative to main expression
            /// </summary>
            [FhirElement("expression", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// Subexpression relative to main expression
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComponentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Definition != null) dest.Definition = (ResourceReference)Definition.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ComponentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Definition != null) yield return Definition;
                    if (ExpressionElement != null) yield return ExpressionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Definition != null) yield return new ElementValue("definition", Definition);
                    if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                }
            }


        }


        /// <summary>
        /// Logical URI to reference this search parameter (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Logical URI to reference this search parameter (globally unique)
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
        /// Business version of the search parameter
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business version of the search parameter
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
        /// Name for this search parameter (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this search parameter (computer friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
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
        [FhirElement("experimental", InSummary=true, Order=130)]
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
        /// Date this was last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date this was last changed
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
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Context the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for search parameter (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this search parameter is defined
        /// </summary>
        [FhirElement("purpose", Order=190)]
        [DataMember]
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

        /// <summary>
        /// Code used in URL
        /// </summary>
        [FhirElement("code", InSummary=true, Order=200)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code CodeElement
        {
            get { return _codeElement; }
            set { _codeElement = value; OnPropertyChanged("CodeElement"); }
        }

        private Code _codeElement;

        /// <summary>
        /// Code used in URL
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
        /// The resource type(s) this search parameter applies to
        /// </summary>
        [FhirElement("base", InSummary=true, Order=210)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Code<ResourceType>> BaseElement
        {
            get { if (_baseElement==null) _baseElement = new List<Code<ResourceType>>(); return _baseElement; }
            set { _baseElement = value; OnPropertyChanged("BaseElement"); }
        }

        private List<Code<ResourceType>> _baseElement;

        /// <summary>
        /// The resource type(s) this search parameter applies to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<ResourceType?> Base
        {
            get { return BaseElement != null ? BaseElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    BaseElement = null;
                else
                    BaseElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                OnPropertyChanged("Base");
            }
        }

        /// <summary>
        /// number | date | string | token | reference | composite | quantity | uri
        /// </summary>
        [FhirElement("type", InSummary=true, Order=220)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<SearchParamType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<SearchParamType> _typeElement;

        /// <summary>
        /// number | date | string | token | reference | composite | quantity | uri
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SearchParamType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<SearchParamType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Original Definition for the search parameter
        /// </summary>
        [FhirElement("derivedFrom", Order=230)]
        [DataMember]
        public FhirUri DerivedFromElement
        {
            get { return _derivedFromElement; }
            set { _derivedFromElement = value; OnPropertyChanged("DerivedFromElement"); }
        }

        private FhirUri _derivedFromElement;

        /// <summary>
        /// Original Definition for the search parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DerivedFrom
        {
            get { return DerivedFromElement != null ? DerivedFromElement.Value : null; }
            set
            {
                if (value == null)
                    DerivedFromElement = null;
                else
                    DerivedFromElement = new FhirUri(value);
                OnPropertyChanged("DerivedFrom");
            }
        }

        /// <summary>
        /// Natural language description of the search parameter
        /// </summary>
        [FhirElement("description", InSummary=true, Order=240)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Markdown Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private Markdown _description;

        /// <summary>
        /// FHIRPath expression that extracts the values
        /// </summary>
        [FhirElement("expression", Order=250)]
        [DataMember]
        public FhirString ExpressionElement
        {
            get { return _expressionElement; }
            set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
        }

        private FhirString _expressionElement;

        /// <summary>
        /// FHIRPath expression that extracts the values
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
        /// XPath that extracts the values
        /// </summary>
        [FhirElement("xpath", Order=260)]
        [DataMember]
        public FhirString XpathElement
        {
            get { return _xpathElement; }
            set { _xpathElement = value; OnPropertyChanged("XpathElement"); }
        }

        private FhirString _xpathElement;

        /// <summary>
        /// XPath that extracts the values
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
        /// normal | phonetic | nearby | distance | other
        /// </summary>
        [FhirElement("xpathUsage", Order=270)]
        [DataMember]
        public Code<XPathUsageType> XpathUsageElement
        {
            get { return _xpathUsageElement; }
            set { _xpathUsageElement = value; OnPropertyChanged("XpathUsageElement"); }
        }

        private Code<XPathUsageType> _xpathUsageElement;

        /// <summary>
        /// normal | phonetic | nearby | distance | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public XPathUsageType? XpathUsage
        {
            get { return XpathUsageElement != null ? XpathUsageElement.Value : null; }
            set
            {
                if (value == null)
                    XpathUsageElement = null;
                else
                    XpathUsageElement = new Code<XPathUsageType>(value);
                OnPropertyChanged("XpathUsage");
            }
        }

        /// <summary>
        /// Types of resource (if a resource reference)
        /// </summary>
        [FhirElement("target", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<ResourceType>> TargetElement
        {
            get { if (_targetElement==null) _targetElement = new List<Code<ResourceType>>(); return _targetElement; }
            set { _targetElement = value; OnPropertyChanged("TargetElement"); }
        }

        private List<Code<ResourceType>> _targetElement;

        /// <summary>
        /// Types of resource (if a resource reference)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<ResourceType?> Target
        {
            get { return TargetElement != null ? TargetElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    TargetElement = null;
                else
                    TargetElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                OnPropertyChanged("Target");
            }
        }

        /// <summary>
        /// eq | ne | gt | lt | ge | le | sa | eb | ap
        /// </summary>
        [FhirElement("comparator", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<SearchComparator>> ComparatorElement
        {
            get { if (_comparatorElement==null) _comparatorElement = new List<Code<SearchComparator>>(); return _comparatorElement; }
            set { _comparatorElement = value; OnPropertyChanged("ComparatorElement"); }
        }

        private List<Code<SearchComparator>> _comparatorElement;

        /// <summary>
        /// eq | ne | gt | lt | ge | le | sa | eb | ap
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<SearchComparator?> Comparator
        {
            get { return ComparatorElement != null ? ComparatorElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ComparatorElement = null;
                else
                    ComparatorElement = new List<Code<SearchComparator>>(value.Select(elem=>new Code<SearchComparator>(elem)));
                OnPropertyChanged("Comparator");
            }
        }

        /// <summary>
        /// missing | exact | contains | not | text | in | not-in | below | above | type
        /// </summary>
        [FhirElement("modifier", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<SearchModifierCode>> ModifierElement
        {
            get { if (_modifierElement==null) _modifierElement = new List<Code<SearchModifierCode>>(); return _modifierElement; }
            set { _modifierElement = value; OnPropertyChanged("ModifierElement"); }
        }

        private List<Code<SearchModifierCode>> _modifierElement;

        /// <summary>
        /// missing | exact | contains | not | text | in | not-in | below | above | type
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<SearchModifierCode?> Modifier
        {
            get { return ModifierElement != null ? ModifierElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ModifierElement = null;
                else
                    ModifierElement = new List<Code<SearchModifierCode>>(value.Select(elem=>new Code<SearchModifierCode>(elem)));
                OnPropertyChanged("Modifier");
            }
        }

        /// <summary>
        /// Chained names supported
        /// </summary>
        [FhirElement("chain", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ChainElement
        {
            get { if (_chainElement==null) _chainElement = new List<FhirString>(); return _chainElement; }
            set { _chainElement = value; OnPropertyChanged("ChainElement"); }
        }

        private List<FhirString> _chainElement;

        /// <summary>
        /// Chained names supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Chain
        {
            get { return ChainElement != null ? ChainElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ChainElement = null;
                else
                    ChainElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Chain");
            }
        }

        /// <summary>
        /// For Composite resources to define the parts
        /// </summary>
        [FhirElement("component", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ComponentComponent> Component
        {
            get { if (_component==null) _component = new List<ComponentComponent>(); return _component; }
            set { _component = value; OnPropertyChanged("Component"); }
        }

        private List<ComponentComponent> _component;


        public static ElementDefinition.ConstraintComponent SearchParameter_SPD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "xpath.empty() or xpathUsage.exists()",
            Key = "spd-1",
            Severity = ConstraintSeverity.Warning,
            Human = "If an xpath is present, there SHALL be an xpathUsage",
            Xpath = "not(exists(f:xpath)) or exists(f:xpathUsage)"
        };

        public static ElementDefinition.ConstraintComponent SearchParameter_SPD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "chain.empty() or type = 'reference'",
            Key = "spd-2",
            Severity = ConstraintSeverity.Warning,
            Human = "Search parameters can only have chain names when the search parameter type is 'reference'",
            Xpath = "not(exists(f:chain)) or (f:type/@value = 'reference')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(SearchParameter_SPD_1);
            InvariantConstraints.Add(SearchParameter_SPD_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SearchParameter;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                if (BaseElement != null) dest.BaseElement = new List<Code<ResourceType>>(BaseElement.DeepCopy());
                if (TypeElement != null) dest.TypeElement = (Code<SearchParamType>)TypeElement.DeepCopy();
                if (DerivedFromElement != null) dest.DerivedFromElement = (FhirUri)DerivedFromElement.DeepCopy();
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                if (XpathElement != null) dest.XpathElement = (FhirString)XpathElement.DeepCopy();
                if (XpathUsageElement != null) dest.XpathUsageElement = (Code<XPathUsageType>)XpathUsageElement.DeepCopy();
                if (TargetElement != null) dest.TargetElement = new List<Code<ResourceType>>(TargetElement.DeepCopy());
                if (ComparatorElement != null) dest.ComparatorElement = new List<Code<SearchComparator>>(ComparatorElement.DeepCopy());
                if (ModifierElement != null) dest.ModifierElement = new List<Code<SearchModifierCode>>(ModifierElement.DeepCopy());
                if (ChainElement != null) dest.ChainElement = new List<FhirString>(ChainElement.DeepCopy());
                if (Component != null) dest.Component = new List<ComponentComponent>(Component.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SearchParameter());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SearchParameter;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if ( !DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(DerivedFromElement, otherT.DerivedFromElement)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
            if (!DeepComparable.Matches(XpathElement, otherT.XpathElement)) return false;
            if (!DeepComparable.Matches(XpathUsageElement, otherT.XpathUsageElement)) return false;
            if ( !DeepComparable.Matches(TargetElement, otherT.TargetElement)) return false;
            if ( !DeepComparable.Matches(ComparatorElement, otherT.ComparatorElement)) return false;
            if ( !DeepComparable.Matches(ModifierElement, otherT.ModifierElement)) return false;
            if ( !DeepComparable.Matches(ChainElement, otherT.ChainElement)) return false;
            if ( !DeepComparable.Matches(Component, otherT.Component)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SearchParameter;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(DerivedFromElement, otherT.DerivedFromElement)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
            if (!DeepComparable.IsExactly(XpathElement, otherT.XpathElement)) return false;
            if (!DeepComparable.IsExactly(XpathUsageElement, otherT.XpathUsageElement)) return false;
            if (!DeepComparable.IsExactly(TargetElement, otherT.TargetElement)) return false;
            if (!DeepComparable.IsExactly(ComparatorElement, otherT.ComparatorElement)) return false;
            if (!DeepComparable.IsExactly(ModifierElement, otherT.ModifierElement)) return false;
            if (!DeepComparable.IsExactly(ChainElement, otherT.ChainElement)) return false;
            if (!DeepComparable.IsExactly(Component, otherT.Component)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (CodeElement != null) yield return CodeElement;
                foreach (var elem in BaseElement) { if (elem != null) yield return elem; }
                if (TypeElement != null) yield return TypeElement;
                if (DerivedFromElement != null) yield return DerivedFromElement;
                if (Description != null) yield return Description;
                if (ExpressionElement != null) yield return ExpressionElement;
                if (XpathElement != null) yield return XpathElement;
                if (XpathUsageElement != null) yield return XpathUsageElement;
                foreach (var elem in TargetElement) { if (elem != null) yield return elem; }
                foreach (var elem in ComparatorElement) { if (elem != null) yield return elem; }
                foreach (var elem in ModifierElement) { if (elem != null) yield return elem; }
                foreach (var elem in ChainElement) { if (elem != null) yield return elem; }
                foreach (var elem in Component) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                foreach (var elem in BaseElement) { if (elem != null) yield return new ElementValue("base", elem); }
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (DerivedFromElement != null) yield return new ElementValue("derivedFrom", DerivedFromElement);
                if (Description != null) yield return new ElementValue("description", Description);
                if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                if (XpathElement != null) yield return new ElementValue("xpath", XpathElement);
                if (XpathUsageElement != null) yield return new ElementValue("xpathUsage", XpathUsageElement);
                foreach (var elem in TargetElement) { if (elem != null) yield return new ElementValue("target", elem); }
                foreach (var elem in ComparatorElement) { if (elem != null) yield return new ElementValue("comparator", elem); }
                foreach (var elem in ModifierElement) { if (elem != null) yield return new ElementValue("modifier", elem); }
                foreach (var elem in ChainElement) { if (elem != null) yield return new ElementValue("chain", elem); }
                foreach (var elem in Component) { if (elem != null) yield return new ElementValue("component", elem); }
            }
        }

    }

}
