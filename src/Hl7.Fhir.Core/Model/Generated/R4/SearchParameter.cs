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
// Generated for FHIR v4.0.1
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Search parameter for a resource
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "SearchParameter", IsResource=true)]
    [DataContract]
    public partial class SearchParameter : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.ISearchParameter, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SearchParameter; } }
        [NotMapped]
        public override string TypeName { get { return "SearchParameter"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ComponentComponent")]
        [DataContract]
        public partial class ComponentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ComponentComponent"; } }
            
            /// <summary>
            /// Defines how the part works
            /// </summary>
            [FhirElement("definition", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Canonical DefinitionElement
            {
                get { return _DefinitionElement; }
                set { _DefinitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }
            
            private Hl7.Fhir.Model.Canonical _DefinitionElement;
            
            /// <summary>
            /// Defines how the part works
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Definition
            {
                get { return DefinitionElement != null ? DefinitionElement.Value : null; }
                set
                {
                    if (value == null)
                        DefinitionElement = null;
                    else
                        DefinitionElement = new Hl7.Fhir.Model.Canonical(value);
                    OnPropertyChanged("Definition");
                }
            }
            
            /// <summary>
            /// Subexpression relative to main expression
            /// </summary>
            [FhirElement("expression", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ExpressionElement
            {
                get { return _ExpressionElement; }
                set { _ExpressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ExpressionElement;
            
            /// <summary>
            /// Subexpression relative to main expression
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Expression");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ComponentComponent");
                base.Serialize(sink);
                sink.Element("definition", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); DefinitionElement?.Serialize(sink);
                sink.Element("expression", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); ExpressionElement?.Serialize(sink);
                sink.End();
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComponentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DefinitionElement != null) dest.DefinitionElement = (Hl7.Fhir.Model.Canonical)DefinitionElement.DeepCopy();
                    if(ExpressionElement != null) dest.ExpressionElement = (Hl7.Fhir.Model.FhirString)ExpressionElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if( !DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if( !DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DefinitionElement != null) yield return DefinitionElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Canonical identifier for this search parameter, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=Hl7.Fhir.Model.Version.All, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Canonical identifier for this search parameter, represented as a URI (globally unique)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Url");
            }
        }
        
        /// <summary>
        /// Business version of the search parameter
        /// </summary>
        [FhirElement("version", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Business version of the search parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Version");
            }
        }
        
        /// <summary>
        /// Name for this search parameter (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Name for this search parameter (computer friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// Original definition for the search parameter
        /// </summary>
        [FhirElement("derivedFrom", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.Canonical DerivedFromElement
        {
            get { return _DerivedFromElement; }
            set { _DerivedFromElement = value; OnPropertyChanged("DerivedFromElement"); }
        }
        
        private Hl7.Fhir.Model.Canonical _DerivedFromElement;
        
        /// <summary>
        /// Original definition for the search parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DerivedFrom
        {
            get { return DerivedFromElement != null ? DerivedFromElement.Value : null; }
            set
            {
                if (value == null)
                    DerivedFromElement = null;
                else
                    DerivedFromElement = new Hl7.Fhir.Model.Canonical(value);
                OnPropertyChanged("DerivedFrom");
            }
        }
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=Hl7.Fhir.Model.Version.All, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=Hl7.Fhir.Model.Version.All, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=Hl7.Fhir.Model.Version.All, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date last changed
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
                    DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=Hl7.Fhir.Model.Version.All, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=Hl7.Fhir.Model.Version.All, Order=170)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ContactDetail> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.R4.ContactDetail>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ContactDetail> _Contact;
        
        /// <summary>
        /// Natural language description of the search parameter
        /// </summary>
        [FhirElement("description", InSummary=Hl7.Fhir.Model.Version.All, Order=180)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _DescriptionElement;
        
        /// <summary>
        /// Natural language description of the search parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=Hl7.Fhir.Model.Version.All, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for search parameter (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=Hl7.Fhir.Model.Version.All, Order=200)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Why this search parameter is defined
        /// </summary>
        [FhirElement("purpose", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown PurposeElement
        {
            get { return _PurposeElement; }
            set { _PurposeElement = value; OnPropertyChanged("PurposeElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _PurposeElement;
        
        /// <summary>
        /// Why this search parameter is defined
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Value : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("Purpose");
            }
        }
        
        /// <summary>
        /// Code used in URL
        /// </summary>
        [FhirElement("code", InSummary=Hl7.Fhir.Model.Version.All, Order=220)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Code CodeElement
        {
            get { return _CodeElement; }
            set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
        }
        
        private Hl7.Fhir.Model.Code _CodeElement;
        
        /// <summary>
        /// Code used in URL
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
                    CodeElement = new Hl7.Fhir.Model.Code(value);
                OnPropertyChanged("Code");
            }
        }
        
        /// <summary>
        /// The resource type(s) this search parameter applies to
        /// </summary>
        [FhirElement("base", InSummary=Hl7.Fhir.Model.Version.All, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.ResourceType>> BaseElement
        {
            get { if(_BaseElement==null) _BaseElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(); return _BaseElement; }
            set { _BaseElement = value; OnPropertyChanged("BaseElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.ResourceType>> _BaseElement;
        
        /// <summary>
        /// The resource type(s) this search parameter applies to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.ResourceType?> Base
        {
            get { return BaseElement != null ? BaseElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    BaseElement = null;
                else
                    BaseElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>(elem)));
                OnPropertyChanged("Base");
            }
        }
        
        /// <summary>
        /// number | date | string | token | reference | composite | quantity | uri | special
        /// </summary>
        [FhirElement("type", InSummary=Hl7.Fhir.Model.Version.All, Order=240)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.SearchParamType> TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.SearchParamType> _TypeElement;
        
        /// <summary>
        /// number | date | string | token | reference | composite | quantity | uri | special
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.SearchParamType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<Hl7.Fhir.Model.SearchParamType>(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// FHIRPath expression that extracts the values
        /// </summary>
        [FhirElement("expression", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ExpressionElement
        {
            get { return _ExpressionElement; }
            set { _ExpressionElement = value; OnPropertyChanged("ExpressionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _ExpressionElement;
        
        /// <summary>
        /// FHIRPath expression that extracts the values
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Expression
        {
            get { return ExpressionElement != null ? ExpressionElement.Value : null; }
            set
            {
                if (value == null)
                    ExpressionElement = null;
                else
                    ExpressionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Expression");
            }
        }
        
        /// <summary>
        /// XPath that extracts the values
        /// </summary>
        [FhirElement("xpath", Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString XpathElement
        {
            get { return _XpathElement; }
            set { _XpathElement = value; OnPropertyChanged("XpathElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _XpathElement;
        
        /// <summary>
        /// XPath that extracts the values
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Xpath
        {
            get { return XpathElement != null ? XpathElement.Value : null; }
            set
            {
                if (value == null)
                    XpathElement = null;
                else
                    XpathElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Xpath");
            }
        }
        
        /// <summary>
        /// normal | phonetic | nearby | distance | other
        /// </summary>
        [FhirElement("xpathUsage", Order=270)]
        [DataMember]
        public Code<Hl7.Fhir.Model.XPathUsageType> XpathUsageElement
        {
            get { return _XpathUsageElement; }
            set { _XpathUsageElement = value; OnPropertyChanged("XpathUsageElement"); }
        }
        
        private Code<Hl7.Fhir.Model.XPathUsageType> _XpathUsageElement;
        
        /// <summary>
        /// normal | phonetic | nearby | distance | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.XPathUsageType? XpathUsage
        {
            get { return XpathUsageElement != null ? XpathUsageElement.Value : null; }
            set
            {
                if (value == null)
                    XpathUsageElement = null;
                else
                    XpathUsageElement = new Code<Hl7.Fhir.Model.XPathUsageType>(value);
                OnPropertyChanged("XpathUsage");
            }
        }
        
        /// <summary>
        /// Types of resource (if a resource reference)
        /// </summary>
        [FhirElement("target", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.ResourceType>> TargetElement
        {
            get { if(_TargetElement==null) _TargetElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(); return _TargetElement; }
            set { _TargetElement = value; OnPropertyChanged("TargetElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.ResourceType>> _TargetElement;
        
        /// <summary>
        /// Types of resource (if a resource reference)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.ResourceType?> Target
        {
            get { return TargetElement != null ? TargetElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    TargetElement = null;
                else
                    TargetElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>(elem)));
                OnPropertyChanged("Target");
            }
        }
        
        /// <summary>
        /// Allow multiple values per parameter (or)
        /// </summary>
        [FhirElement("multipleOr", Order=290)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean MultipleOrElement
        {
            get { return _MultipleOrElement; }
            set { _MultipleOrElement = value; OnPropertyChanged("MultipleOrElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _MultipleOrElement;
        
        /// <summary>
        /// Allow multiple values per parameter (or)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? MultipleOr
        {
            get { return MultipleOrElement != null ? MultipleOrElement.Value : null; }
            set
            {
                if (value == null)
                    MultipleOrElement = null;
                else
                    MultipleOrElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("MultipleOr");
            }
        }
        
        /// <summary>
        /// Allow multiple parameters (and)
        /// </summary>
        [FhirElement("multipleAnd", Order=300)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean MultipleAndElement
        {
            get { return _MultipleAndElement; }
            set { _MultipleAndElement = value; OnPropertyChanged("MultipleAndElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _MultipleAndElement;
        
        /// <summary>
        /// Allow multiple parameters (and)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? MultipleAnd
        {
            get { return MultipleAndElement != null ? MultipleAndElement.Value : null; }
            set
            {
                if (value == null)
                    MultipleAndElement = null;
                else
                    MultipleAndElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("MultipleAnd");
            }
        }
        
        /// <summary>
        /// eq | ne | gt | lt | ge | le | sa | eb | ap
        /// </summary>
        [FhirElement("comparator", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.SearchComparator>> ComparatorElement
        {
            get { if(_ComparatorElement==null) _ComparatorElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchComparator>>(); return _ComparatorElement; }
            set { _ComparatorElement = value; OnPropertyChanged("ComparatorElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.SearchComparator>> _ComparatorElement;
        
        /// <summary>
        /// eq | ne | gt | lt | ge | le | sa | eb | ap
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.SearchComparator?> Comparator
        {
            get { return ComparatorElement != null ? ComparatorElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ComparatorElement = null;
                else
                    ComparatorElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchComparator>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SearchComparator>(elem)));
                OnPropertyChanged("Comparator");
            }
        }
        
        /// <summary>
        /// missing | exact | contains | not | text | in | not-in | below | above | type | identifier | ofType
        /// </summary>
        [FhirElement("modifier", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.R4.SearchModifierCode>> ModifierElement
        {
            get { if(_ModifierElement==null) _ModifierElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.R4.SearchModifierCode>>(); return _ModifierElement; }
            set { _ModifierElement = value; OnPropertyChanged("ModifierElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.R4.SearchModifierCode>> _ModifierElement;
        
        /// <summary>
        /// missing | exact | contains | not | text | in | not-in | below | above | type | identifier | ofType
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.R4.SearchModifierCode?> Modifier
        {
            get { return ModifierElement != null ? ModifierElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ModifierElement = null;
                else
                    ModifierElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.R4.SearchModifierCode>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.R4.SearchModifierCode>(elem)));
                OnPropertyChanged("Modifier");
            }
        }
        
        /// <summary>
        /// Chained names supported
        /// </summary>
        [FhirElement("chain", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> ChainElement
        {
            get { if(_ChainElement==null) _ChainElement = new List<Hl7.Fhir.Model.FhirString>(); return _ChainElement; }
            set { _ChainElement = value; OnPropertyChanged("ChainElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _ChainElement;
        
        /// <summary>
        /// Chained names supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Chain
        {
            get { return ChainElement != null ? ChainElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ChainElement = null;
                else
                    ChainElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("Chain");
            }
        }
        
        /// <summary>
        /// For Composite resources to define the parts
        /// </summary>
        [FhirElement("component", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ComponentComponent> Component
        {
            get { if(_Component==null) _Component = new List<ComponentComponent>(); return _Component; }
            set { _Component = value; OnPropertyChanged("Component"); }
        }
        
        private List<ComponentComponent> _Component;
    
    
        public static ElementDefinitionConstraint[] SearchParameter_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.R4},
                key: "spd-0",
                severity: ConstraintSeverity.Warning,
                expression: "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
                human: "Name should be usable as an identifier for the module by machine processing applications such as code generation",
                xpath: "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.R4},
                key: "spd-1",
                severity: ConstraintSeverity.Warning,
                expression: "xpath.empty() or xpathUsage.exists()",
                human: "If an xpath is present, there SHALL be an xpathUsage",
                xpath: "not(exists(f:xpath)) or exists(f:xpathUsage)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.R4},
                key: "spd-2",
                severity: ConstraintSeverity.Warning,
                expression: "chain.empty() or type = 'reference'",
                human: "Search parameters can only have chain names when the search parameter type is 'reference'",
                xpath: "not(exists(f:chain)) or (f:type/@value = 'reference')"
            ),
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
            InvariantConstraints.AddRange(SearchParameter_Constraints);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SearchParameter;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(DerivedFromElement != null) dest.DerivedFromElement = (Hl7.Fhir.Model.Canonical)DerivedFromElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.R4.ContactDetail>(Contact.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
                if(PurposeElement != null) dest.PurposeElement = (Hl7.Fhir.Model.Markdown)PurposeElement.DeepCopy();
                if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.Code)CodeElement.DeepCopy();
                if(BaseElement != null) dest.BaseElement = new List<Code<Hl7.Fhir.Model.ResourceType>>(BaseElement.DeepCopy());
                if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.SearchParamType>)TypeElement.DeepCopy();
                if(ExpressionElement != null) dest.ExpressionElement = (Hl7.Fhir.Model.FhirString)ExpressionElement.DeepCopy();
                if(XpathElement != null) dest.XpathElement = (Hl7.Fhir.Model.FhirString)XpathElement.DeepCopy();
                if(XpathUsageElement != null) dest.XpathUsageElement = (Code<Hl7.Fhir.Model.XPathUsageType>)XpathUsageElement.DeepCopy();
                if(TargetElement != null) dest.TargetElement = new List<Code<Hl7.Fhir.Model.ResourceType>>(TargetElement.DeepCopy());
                if(MultipleOrElement != null) dest.MultipleOrElement = (Hl7.Fhir.Model.FhirBoolean)MultipleOrElement.DeepCopy();
                if(MultipleAndElement != null) dest.MultipleAndElement = (Hl7.Fhir.Model.FhirBoolean)MultipleAndElement.DeepCopy();
                if(ComparatorElement != null) dest.ComparatorElement = new List<Code<Hl7.Fhir.Model.SearchComparator>>(ComparatorElement.DeepCopy());
                if(ModifierElement != null) dest.ModifierElement = new List<Code<Hl7.Fhir.Model.R4.SearchModifierCode>>(ModifierElement.DeepCopy());
                if(ChainElement != null) dest.ChainElement = new List<Hl7.Fhir.Model.FhirString>(ChainElement.DeepCopy());
                if(Component != null) dest.Component = new List<ComponentComponent>(Component.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(DerivedFromElement, otherT.DerivedFromElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if( !DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
            if( !DeepComparable.Matches(XpathElement, otherT.XpathElement)) return false;
            if( !DeepComparable.Matches(XpathUsageElement, otherT.XpathUsageElement)) return false;
            if( !DeepComparable.Matches(TargetElement, otherT.TargetElement)) return false;
            if( !DeepComparable.Matches(MultipleOrElement, otherT.MultipleOrElement)) return false;
            if( !DeepComparable.Matches(MultipleAndElement, otherT.MultipleAndElement)) return false;
            if( !DeepComparable.Matches(ComparatorElement, otherT.ComparatorElement)) return false;
            if( !DeepComparable.Matches(ModifierElement, otherT.ModifierElement)) return false;
            if( !DeepComparable.Matches(ChainElement, otherT.ChainElement)) return false;
            if( !DeepComparable.Matches(Component, otherT.Component)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SearchParameter;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(DerivedFromElement, otherT.DerivedFromElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if( !DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
            if( !DeepComparable.IsExactly(XpathElement, otherT.XpathElement)) return false;
            if( !DeepComparable.IsExactly(XpathUsageElement, otherT.XpathUsageElement)) return false;
            if( !DeepComparable.IsExactly(TargetElement, otherT.TargetElement)) return false;
            if( !DeepComparable.IsExactly(MultipleOrElement, otherT.MultipleOrElement)) return false;
            if( !DeepComparable.IsExactly(MultipleAndElement, otherT.MultipleAndElement)) return false;
            if( !DeepComparable.IsExactly(ComparatorElement, otherT.ComparatorElement)) return false;
            if( !DeepComparable.IsExactly(ModifierElement, otherT.ModifierElement)) return false;
            if( !DeepComparable.IsExactly(ChainElement, otherT.ChainElement)) return false;
            if( !DeepComparable.IsExactly(Component, otherT.Component)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("SearchParameter");
            base.Serialize(sink);
            sink.Element("url", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); UrlElement?.Serialize(sink);
            sink.Element("version", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); VersionElement?.Serialize(sink);
            sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); NameElement?.Serialize(sink);
            sink.Element("derivedFrom", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DerivedFromElement?.Serialize(sink);
            sink.Element("status", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); StatusElement?.Serialize(sink);
            sink.Element("experimental", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); ExperimentalElement?.Serialize(sink);
            sink.Element("date", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); DateElement?.Serialize(sink);
            sink.Element("publisher", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); PublisherElement?.Serialize(sink);
            sink.BeginList("contact", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Contact)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("description", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); DescriptionElement?.Serialize(sink);
            sink.BeginList("useContext", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in UseContext)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("jurisdiction", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Jurisdiction)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("purpose", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); PurposeElement?.Serialize(sink);
            sink.Element("code", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); CodeElement?.Serialize(sink);
            sink.BeginList("base", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true);
            sink.Serialize(BaseElement);
            sink.End();
            sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); TypeElement?.Serialize(sink);
            sink.Element("expression", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ExpressionElement?.Serialize(sink);
            sink.Element("xpath", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); XpathElement?.Serialize(sink);
            sink.Element("xpathUsage", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); XpathUsageElement?.Serialize(sink);
            sink.BeginList("target", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            sink.Serialize(TargetElement);
            sink.End();
            sink.Element("multipleOr", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); MultipleOrElement?.Serialize(sink);
            sink.Element("multipleAnd", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); MultipleAndElement?.Serialize(sink);
            sink.BeginList("comparator", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            sink.Serialize(ComparatorElement);
            sink.End();
            sink.BeginList("modifier", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            sink.Serialize(ModifierElement);
            sink.End();
            sink.BeginList("chain", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            sink.Serialize(ChainElement);
            sink.End();
            sink.BeginList("component", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Component)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.End();
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
                if (DerivedFromElement != null) yield return DerivedFromElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (PurposeElement != null) yield return PurposeElement;
                if (CodeElement != null) yield return CodeElement;
                foreach (var elem in BaseElement) { if (elem != null) yield return elem; }
                if (TypeElement != null) yield return TypeElement;
                if (ExpressionElement != null) yield return ExpressionElement;
                if (XpathElement != null) yield return XpathElement;
                if (XpathUsageElement != null) yield return XpathUsageElement;
                foreach (var elem in TargetElement) { if (elem != null) yield return elem; }
                if (MultipleOrElement != null) yield return MultipleOrElement;
                if (MultipleAndElement != null) yield return MultipleAndElement;
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
                if (DerivedFromElement != null) yield return new ElementValue("derivedFrom", DerivedFromElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                foreach (var elem in BaseElement) { if (elem != null) yield return new ElementValue("base", elem); }
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                if (XpathElement != null) yield return new ElementValue("xpath", XpathElement);
                if (XpathUsageElement != null) yield return new ElementValue("xpathUsage", XpathUsageElement);
                foreach (var elem in TargetElement) { if (elem != null) yield return new ElementValue("target", elem); }
                if (MultipleOrElement != null) yield return new ElementValue("multipleOr", MultipleOrElement);
                if (MultipleAndElement != null) yield return new ElementValue("multipleAnd", MultipleAndElement);
                foreach (var elem in ComparatorElement) { if (elem != null) yield return new ElementValue("comparator", elem); }
                foreach (var elem in ModifierElement) { if (elem != null) yield return new ElementValue("modifier", elem); }
                foreach (var elem in ChainElement) { if (elem != null) yield return new ElementValue("chain", elem); }
                foreach (var elem in Component) { if (elem != null) yield return new ElementValue("component", elem); }
            }
        }
    
    }

}
