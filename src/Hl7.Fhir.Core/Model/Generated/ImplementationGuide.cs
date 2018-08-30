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
    /// A set of rules about how FHIR is used
    /// </summary>
    [FhirType("ImplementationGuide", IsResource=true)]
    [DataContract]
    public partial class ImplementationGuide : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImplementationGuide; } }
        [NotMapped]
        public override string TypeName { get { return "ImplementationGuide"; } }

        /// <summary>
        /// A code that indicates how the page is generated
        /// (url: http://hl7.org/fhir/ValueSet/guide-page-generation)
        /// </summary>
        [FhirEnumeration("GuidePageGeneration")]
        public enum GuidePageGeneration
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("html", "http://hl7.org/fhir/guide-page-generation"), Description("HTML")]
            Html,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("markdown", "http://hl7.org/fhir/guide-page-generation"), Description("Markdown")]
            Markdown,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("xml", "http://hl7.org/fhir/guide-page-generation"), Description("XML")]
            Xml,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-page-generation)
            /// </summary>
            [EnumLiteral("generated", "http://hl7.org/fhir/guide-page-generation"), Description("Generated")]
            Generated,
        }

        /// <summary>
        /// Code of parameter that is input to the guide
        /// (url: http://hl7.org/fhir/ValueSet/guide-parameter-code)
        /// </summary>
        [FhirEnumeration("GuideParameterCode")]
        public enum GuideParameterCode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("apply-business-version", "http://hl7.org/fhir/guide-parameter-code"), Description("Apply Business Version")]
            ApplyBusinessVersion,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("apply-jurisdiction", "http://hl7.org/fhir/guide-parameter-code"), Description("Apply Jurisdiction")]
            ApplyJurisdiction,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("path-resource", "http://hl7.org/fhir/guide-parameter-code"), Description("Resource Path")]
            PathResource,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("path-pages", "http://hl7.org/fhir/guide-parameter-code"), Description("Pages Path")]
            PathPages,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("path-tx-cache", "http://hl7.org/fhir/guide-parameter-code"), Description("Terminology Cache Path")]
            PathTxCache,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("expansion-profile", "http://hl7.org/fhir/guide-parameter-code"), Description("Expansion Profile")]
            ExpansionProfile,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("rule-broken-links", "http://hl7.org/fhir/guide-parameter-code"), Description("Broken Links Rule")]
            RuleBrokenLinks,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("generate-xml", "http://hl7.org/fhir/guide-parameter-code"), Description("Generate XML")]
            GenerateXml,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("generate-json", "http://hl7.org/fhir/guide-parameter-code"), Description("Generate JSON")]
            GenerateJson,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("generate-turtle", "http://hl7.org/fhir/guide-parameter-code"), Description("Generate Turtle")]
            GenerateTurtle,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/guide-parameter-code)
            /// </summary>
            [EnumLiteral("html-template", "http://hl7.org/fhir/guide-parameter-code"), Description("HTML Template")]
            HtmlTemplate,
        }


        [FhirType("DependsOnComponent")]
        [DataContract]
        public partial class DependsOnComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DependsOnComponent"; } }

            /// <summary>
            /// Identity of the IG that this depends on
            /// </summary>
            [FhirElement("uri", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private Canonical _uriElement;

            /// <summary>
            /// Identity of the IG that this depends on
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
                        UriElement = new Canonical(value);
                    OnPropertyChanged("Uri");
                }
            }

            /// <summary>
            /// Version of the IG
            /// </summary>
            [FhirElement("version", InSummary=true, Order=50)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// Version of the IG
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DependsOnComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UriElement != null) dest.UriElement = (Canonical)UriElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DependsOnComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DependsOnComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DependsOnComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UriElement != null) yield return UriElement;
                    if (VersionElement != null) yield return VersionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                }
            }


        }


        [FhirType("GlobalComponent")]
        [DataContract]
        public partial class GlobalComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GlobalComponent"; } }

            /// <summary>
            /// Type this profile applies to
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResourceType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ResourceType> _typeElement;

            /// <summary>
            /// Type this profile applies to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ResourceType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Profile that all resources must conform to
            /// </summary>
            [FhirElement("profile", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical ProfileElement
            {
                get { return _profileElement; }
                set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
            }

            private Canonical _profileElement;

            /// <summary>
            /// Profile that all resources must conform to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Profile
            {
                get { return ProfileElement != null ? ProfileElement.Value : null; }
                set
                {
                    if (value == null)
                        ProfileElement = null;
                    else
                        ProfileElement = new Canonical(value);
                    OnPropertyChanged("Profile");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GlobalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ResourceType>)TypeElement.DeepCopy();
                    if (ProfileElement != null) dest.ProfileElement = (Canonical)ProfileElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GlobalComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GlobalComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GlobalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (ProfileElement != null) yield return ProfileElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (ProfileElement != null) yield return new ElementValue("profile", ProfileElement);
                }
            }


        }


        [FhirType("DefinitionComponent")]
        [DataContract]
        public partial class DefinitionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DefinitionComponent"; } }

            /// <summary>
            /// Group of resources as used in .page.package
            /// </summary>
            [FhirElement("package", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PackageComponent> Package
            {
                get { if (_package==null) _package = new List<PackageComponent>(); return _package; }
                set { _package = value; OnPropertyChanged("Package"); }
            }

            private List<PackageComponent> _package;

            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceComponent> Resource
            {
                get { if (_resource==null) _resource = new List<ResourceComponent>(); return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private List<ResourceComponent> _resource;

            /// <summary>
            /// Page/Section in the Guide
            /// </summary>
            [FhirElement("page", Order=60)]
            [DataMember]
            public PageComponent Page
            {
                get { return _page; }
                set { _page = value; OnPropertyChanged("Page"); }
            }

            private PageComponent _page;

            /// <summary>
            /// Defines how IG is built by tools
            /// </summary>
            [FhirElement("parameter", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Parameter
            {
                get { if (_parameter==null) _parameter = new List<ParameterComponent>(); return _parameter; }
                set { _parameter = value; OnPropertyChanged("Parameter"); }
            }

            private List<ParameterComponent> _parameter;

            /// <summary>
            /// A template for building resources
            /// </summary>
            [FhirElement("template", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TemplateComponent> Template
            {
                get { if (_template==null) _template = new List<TemplateComponent>(); return _template; }
                set { _template = value; OnPropertyChanged("Template"); }
            }

            private List<TemplateComponent> _template;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DefinitionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Package != null) dest.Package = new List<PackageComponent>(Package.DeepCopy());
                    if (Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
                    if (Page != null) dest.Page = (PageComponent)Page.DeepCopy();
                    if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                    if (Template != null) dest.Template = new List<TemplateComponent>(Template.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DefinitionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DefinitionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Package, otherT.Package)) return false;
                if ( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if (!DeepComparable.Matches(Page, otherT.Page)) return false;
                if ( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;
                if ( !DeepComparable.Matches(Template, otherT.Template)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DefinitionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Package, otherT.Package)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;
                if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;
                if (!DeepComparable.IsExactly(Template, otherT.Template)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Package) { if (elem != null) yield return elem; }
                    foreach (var elem in Resource) { if (elem != null) yield return elem; }
                    if (Page != null) yield return Page;
                    foreach (var elem in Parameter) { if (elem != null) yield return elem; }
                    foreach (var elem in Template) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Package) { if (elem != null) yield return new ElementValue("package", elem); }
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", elem); }
                    if (Page != null) yield return new ElementValue("page", Page);
                    foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
                    foreach (var elem in Template) { if (elem != null) yield return new ElementValue("template", elem); }
                }
            }


        }


        [FhirType("PackageComponent")]
        [DataContract]
        public partial class PackageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PackageComponent"; } }

            /// <summary>
            /// Name used .resource.package and .page.package
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name used .resource.package and .page.package
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
            /// Human readable text describing the package
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Human readable text describing the package
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PackageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        [FhirType("ResourceComponent")]
        [DataContract]
        public partial class ResourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceComponent"; } }

            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("reference", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Human Name for the resource
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Human Name for the resource
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
            /// Reason why included in guide
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Reason why included in guide
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
            /// Is an example/What is this an example of?
            /// </summary>
            [FhirElement("example", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(Canonical))]
            [DataMember]
            public Element Example
            {
                get { return _example; }
                set { _example = value; OnPropertyChanged("Example"); }
            }

            private Element _example;

            /// <summary>
            /// Pack this is part of
            /// </summary>
            [FhirElement("package", Order=80)]
            [DataMember]
            public Id PackageElement
            {
                get { return _packageElement; }
                set { _packageElement = value; OnPropertyChanged("PackageElement"); }
            }

            private Id _packageElement;

            /// <summary>
            /// Pack this is part of
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Package
            {
                get { return PackageElement != null ? PackageElement.Value : null; }
                set
                {
                    if (value == null)
                        PackageElement = null;
                    else
                        PackageElement = new Id(value);
                    OnPropertyChanged("Package");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Example != null) dest.Example = (Element)Example.DeepCopy();
                    if (PackageElement != null) dest.PackageElement = (Id)PackageElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ResourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Example, otherT.Example)) return false;
                if (!DeepComparable.Matches(PackageElement, otherT.PackageElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Example, otherT.Example)) return false;
                if (!DeepComparable.IsExactly(PackageElement, otherT.PackageElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Reference != null) yield return Reference;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Example != null) yield return Example;
                    if (PackageElement != null) yield return PackageElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Example != null) yield return new ElementValue("example", Example);
                    if (PackageElement != null) yield return new ElementValue("package", PackageElement);
                }
            }


        }


        [FhirType("PageComponent")]
        [DataContract]
        public partial class PageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PageComponent"; } }

            /// <summary>
            /// Where to find that page
            /// </summary>
            [FhirElement("name", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirUrl),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Name
            {
                get { return _name; }
                set { _name = value; OnPropertyChanged("Name"); }
            }

            private Element _name;

            /// <summary>
            /// Short title shown for navigational assistance
            /// </summary>
            [FhirElement("title", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Short title shown for navigational assistance
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
            /// html | markdown | xml | generated
            /// </summary>
            [FhirElement("generation", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<GuidePageGeneration> GenerationElement
            {
                get { return _generationElement; }
                set { _generationElement = value; OnPropertyChanged("GenerationElement"); }
            }

            private Code<GuidePageGeneration> _generationElement;

            /// <summary>
            /// html | markdown | xml | generated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public GuidePageGeneration? Generation
            {
                get { return GenerationElement != null ? GenerationElement.Value : null; }
                set
                {
                    if (value == null)
                        GenerationElement = null;
                    else
                        GenerationElement = new Code<GuidePageGeneration>(value);
                    OnPropertyChanged("Generation");
                }
            }

            /// <summary>
            /// Nested Pages / Sections
            /// </summary>
            [FhirElement("page", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PageComponent> Page
            {
                get { if (_page==null) _page = new List<PageComponent>(); return _page; }
                set { _page = value; OnPropertyChanged("Page"); }
            }

            private List<PageComponent> _page;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Name != null) dest.Name = (Element)Name.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (GenerationElement != null) dest.GenerationElement = (Code<GuidePageGeneration>)GenerationElement.DeepCopy();
                    if (Page != null) dest.Page = new List<PageComponent>(Page.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Name, otherT.Name)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(GenerationElement, otherT.GenerationElement)) return false;
                if ( !DeepComparable.Matches(Page, otherT.Page)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(GenerationElement, otherT.GenerationElement)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Name != null) yield return Name;
                    if (TitleElement != null) yield return TitleElement;
                    if (GenerationElement != null) yield return GenerationElement;
                    foreach (var elem in Page) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Name != null) yield return new ElementValue("name", Name);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    if (GenerationElement != null) yield return new ElementValue("generation", GenerationElement);
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", elem); }
                }
            }


        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// apply-business-version | apply-jurisdiction | path-resource | path-pages | path-tx-cache | expansion-profile | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<GuideParameterCode> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<GuideParameterCode> _codeElement;

            /// <summary>
            /// apply-business-version | apply-jurisdiction | path-resource | path-pages | path-tx-cache | expansion-profile | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public GuideParameterCode? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<GuideParameterCode>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Value for named type
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Value for named type
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
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<GuideParameterCode>)CodeElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParameterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
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
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("TemplateComponent")]
        [DataContract]
        public partial class TemplateComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TemplateComponent"; } }

            /// <summary>
            /// Type of template specified
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
            /// Type of template specified
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
            /// The source location for the template
            /// </summary>
            [FhirElement("source", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private FhirString _sourceElement;

            /// <summary>
            /// The source location for the template
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
                        SourceElement = new FhirString(value);
                    OnPropertyChanged("Source");
                }
            }

            /// <summary>
            /// The scope in which the template applies
            /// </summary>
            [FhirElement("scope", Order=60)]
            [DataMember]
            public FhirString ScopeElement
            {
                get { return _scopeElement; }
                set { _scopeElement = value; OnPropertyChanged("ScopeElement"); }
            }

            private FhirString _scopeElement;

            /// <summary>
            /// The scope in which the template applies
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Scope
            {
                get { return ScopeElement != null ? ScopeElement.Value : null; }
                set
                {
                    if (value == null)
                        ScopeElement = null;
                    else
                        ScopeElement = new FhirString(value);
                    OnPropertyChanged("Scope");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TemplateComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (SourceElement != null) dest.SourceElement = (FhirString)SourceElement.DeepCopy();
                    if (ScopeElement != null) dest.ScopeElement = (FhirString)ScopeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TemplateComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TemplateComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.Matches(ScopeElement, otherT.ScopeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TemplateComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.IsExactly(ScopeElement, otherT.ScopeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (SourceElement != null) yield return SourceElement;
                    if (ScopeElement != null) yield return ScopeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (ScopeElement != null) yield return new ElementValue("scope", ScopeElement);
                }
            }


        }


        [FhirType("ManifestComponent")]
        [DataContract]
        public partial class ManifestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestComponent"; } }

            /// <summary>
            /// Location of rendered implementation guide
            /// </summary>
            [FhirElement("rendering", InSummary=true, Order=40)]
            [DataMember]
            public FhirUrl RenderingElement
            {
                get { return _renderingElement; }
                set { _renderingElement = value; OnPropertyChanged("RenderingElement"); }
            }

            private FhirUrl _renderingElement;

            /// <summary>
            /// Location of rendered implementation guide
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Rendering
            {
                get { return RenderingElement != null ? RenderingElement.Value : null; }
                set
                {
                    if (value == null)
                        RenderingElement = null;
                    else
                        RenderingElement = new FhirUrl(value);
                    OnPropertyChanged("Rendering");
                }
            }

            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ManifestResourceComponent> Resource
            {
                get { if (_resource==null) _resource = new List<ManifestResourceComponent>(); return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private List<ManifestResourceComponent> _resource;

            /// <summary>
            /// HTML page within the parent IG
            /// </summary>
            [FhirElement("page", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ManifestPageComponent> Page
            {
                get { if (_page==null) _page = new List<ManifestPageComponent>(); return _page; }
                set { _page = value; OnPropertyChanged("Page"); }
            }

            private List<ManifestPageComponent> _page;

            /// <summary>
            /// Image within the IG
            /// </summary>
            [FhirElement("image", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ImageElement
            {
                get { if (_imageElement==null) _imageElement = new List<FhirString>(); return _imageElement; }
                set { _imageElement = value; OnPropertyChanged("ImageElement"); }
            }

            private List<FhirString> _imageElement;

            /// <summary>
            /// Image within the IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Image
            {
                get { return ImageElement != null ? ImageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ImageElement = null;
                    else
                        ImageElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Image");
                }
            }

            /// <summary>
            /// Additional linkable file in IG
            /// </summary>
            [FhirElement("other", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> OtherElement
            {
                get { if (_otherElement==null) _otherElement = new List<FhirString>(); return _otherElement; }
                set { _otherElement = value; OnPropertyChanged("OtherElement"); }
            }

            private List<FhirString> _otherElement;

            /// <summary>
            /// Additional linkable file in IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Other
            {
                get { return OtherElement != null ? OtherElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OtherElement = null;
                    else
                        OtherElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Other");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RenderingElement != null) dest.RenderingElement = (FhirUrl)RenderingElement.DeepCopy();
                    if (Resource != null) dest.Resource = new List<ManifestResourceComponent>(Resource.DeepCopy());
                    if (Page != null) dest.Page = new List<ManifestPageComponent>(Page.DeepCopy());
                    if (ImageElement != null) dest.ImageElement = new List<FhirString>(ImageElement.DeepCopy());
                    if (OtherElement != null) dest.OtherElement = new List<FhirString>(OtherElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManifestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManifestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RenderingElement, otherT.RenderingElement)) return false;
                if ( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Page, otherT.Page)) return false;
                if ( !DeepComparable.Matches(ImageElement, otherT.ImageElement)) return false;
                if ( !DeepComparable.Matches(OtherElement, otherT.OtherElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RenderingElement, otherT.RenderingElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;
                if (!DeepComparable.IsExactly(ImageElement, otherT.ImageElement)) return false;
                if (!DeepComparable.IsExactly(OtherElement, otherT.OtherElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RenderingElement != null) yield return RenderingElement;
                    foreach (var elem in Resource) { if (elem != null) yield return elem; }
                    foreach (var elem in Page) { if (elem != null) yield return elem; }
                    foreach (var elem in ImageElement) { if (elem != null) yield return elem; }
                    foreach (var elem in OtherElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RenderingElement != null) yield return new ElementValue("rendering", RenderingElement);
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", elem); }
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", elem); }
                    foreach (var elem in ImageElement) { if (elem != null) yield return new ElementValue("image", elem); }
                    foreach (var elem in OtherElement) { if (elem != null) yield return new ElementValue("other", elem); }
                }
            }


        }


        [FhirType("ManifestResourceComponent")]
        [DataContract]
        public partial class ManifestResourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestResourceComponent"; } }

            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Is an example/What is this an example of?
            /// </summary>
            [FhirElement("example", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(Canonical))]
            [DataMember]
            public Element Example
            {
                get { return _example; }
                set { _example = value; OnPropertyChanged("Example"); }
            }

            private Element _example;

            /// <summary>
            /// Relative path for page in IG
            /// </summary>
            [FhirElement("relativePath", Order=60)]
            [DataMember]
            public FhirUrl RelativePathElement
            {
                get { return _relativePathElement; }
                set { _relativePathElement = value; OnPropertyChanged("RelativePathElement"); }
            }

            private FhirUrl _relativePathElement;

            /// <summary>
            /// Relative path for page in IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RelativePath
            {
                get { return RelativePathElement != null ? RelativePathElement.Value : null; }
                set
                {
                    if (value == null)
                        RelativePathElement = null;
                    else
                        RelativePathElement = new FhirUrl(value);
                    OnPropertyChanged("RelativePath");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (Example != null) dest.Example = (Element)Example.DeepCopy();
                    if (RelativePathElement != null) dest.RelativePathElement = (FhirUrl)RelativePathElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManifestResourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManifestResourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(Example, otherT.Example)) return false;
                if (!DeepComparable.Matches(RelativePathElement, otherT.RelativePathElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Example, otherT.Example)) return false;
                if (!DeepComparable.IsExactly(RelativePathElement, otherT.RelativePathElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Reference != null) yield return Reference;
                    if (Example != null) yield return Example;
                    if (RelativePathElement != null) yield return RelativePathElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (Example != null) yield return new ElementValue("example", Example);
                    if (RelativePathElement != null) yield return new ElementValue("relativePath", RelativePathElement);
                }
            }


        }


        [FhirType("ManifestPageComponent")]
        [DataContract]
        public partial class ManifestPageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestPageComponent"; } }

            /// <summary>
            /// HTML page name
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// HTML page name
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
            /// Title of the page, for references
            /// </summary>
            [FhirElement("title", Order=50)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Title of the page, for references
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
            /// Anchor available on the page
            /// </summary>
            [FhirElement("anchor", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> AnchorElement
            {
                get { if (_anchorElement==null) _anchorElement = new List<FhirString>(); return _anchorElement; }
                set { _anchorElement = value; OnPropertyChanged("AnchorElement"); }
            }

            private List<FhirString> _anchorElement;

            /// <summary>
            /// Anchor available on the page
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Anchor
            {
                get { return AnchorElement != null ? AnchorElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        AnchorElement = null;
                    else
                        AnchorElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Anchor");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestPageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (AnchorElement != null) dest.AnchorElement = new List<FhirString>(AnchorElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManifestPageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManifestPageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if ( !DeepComparable.Matches(AnchorElement, otherT.AnchorElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestPageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(AnchorElement, otherT.AnchorElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (TitleElement != null) yield return TitleElement;
                    foreach (var elem in AnchorElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    foreach (var elem in AnchorElement) { if (elem != null) yield return new ElementValue("anchor", elem); }
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this implementation guide, represented as a URI (globally unique)
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
        /// Canonical identifier for this implementation guide, represented as a URI (globally unique)
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
        /// Business version of the implementation guide
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
        /// Business version of the implementation guide
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
        /// Name for this implementation guide (computer friendly)
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
        /// Name for this implementation guide (computer friendly)
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
        /// Date last changed
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
        /// Natural language description of the implementation guide
        /// </summary>
        [FhirElement("description", Order=170)]
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
        [FhirElement("useContext", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for implementation guide (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=200)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary=true, Order=210)]
        [DataMember]
        public Id FhirVersionElement
        {
            get { return _fhirVersionElement; }
            set { _fhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }

        private Id _fhirVersionElement;

        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if (value == null)
                    FhirVersionElement = null;
                else
                    FhirVersionElement = new Id(value);
                OnPropertyChanged("FhirVersion");
            }
        }

        /// <summary>
        /// Another Implementation guide this depends on
        /// </summary>
        [FhirElement("dependsOn", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DependsOnComponent> DependsOn
        {
            get { if (_dependsOn==null) _dependsOn = new List<DependsOnComponent>(); return _dependsOn; }
            set { _dependsOn = value; OnPropertyChanged("DependsOn"); }
        }

        private List<DependsOnComponent> _dependsOn;

        /// <summary>
        /// Profiles that apply globally
        /// </summary>
        [FhirElement("global", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GlobalComponent> Global
        {
            get { if (_global==null) _global = new List<GlobalComponent>(); return _global; }
            set { _global = value; OnPropertyChanged("Global"); }
        }

        private List<GlobalComponent> _global;

        /// <summary>
        /// Information needed to build the IG
        /// </summary>
        [FhirElement("definition", Order=240)]
        [DataMember]
        public DefinitionComponent Definition
        {
            get { return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private DefinitionComponent _definition;

        /// <summary>
        /// Information about an assembled IG
        /// </summary>
        [FhirElement("manifest", Order=250)]
        [DataMember]
        public ManifestComponent Manifest
        {
            get { return _manifest; }
            set { _manifest = value; OnPropertyChanged("Manifest"); }
        }

        private ManifestComponent _manifest;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImplementationGuide;

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
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (FhirVersionElement != null) dest.FhirVersionElement = (Id)FhirVersionElement.DeepCopy();
                if (DependsOn != null) dest.DependsOn = new List<DependsOnComponent>(DependsOn.DeepCopy());
                if (Global != null) dest.Global = new List<GlobalComponent>(Global.DeepCopy());
                if (Definition != null) dest.Definition = (DefinitionComponent)Definition.DeepCopy();
                if (Manifest != null) dest.Manifest = (ManifestComponent)Manifest.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImplementationGuide());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
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
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if ( !DeepComparable.Matches(DependsOn, otherT.DependsOn)) return false;
            if ( !DeepComparable.Matches(Global, otherT.Global)) return false;
            if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if (!DeepComparable.Matches(Manifest, otherT.Manifest)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
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
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.IsExactly(DependsOn, otherT.DependsOn)) return false;
            if (!DeepComparable.IsExactly(Global, otherT.Global)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(Manifest, otherT.Manifest)) return false;

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
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Copyright != null) yield return Copyright;
                if (FhirVersionElement != null) yield return FhirVersionElement;
                foreach (var elem in DependsOn) { if (elem != null) yield return elem; }
                foreach (var elem in Global) { if (elem != null) yield return elem; }
                if (Definition != null) yield return Definition;
                if (Manifest != null) yield return Manifest;
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
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", FhirVersionElement);
                foreach (var elem in DependsOn) { if (elem != null) yield return new ElementValue("dependsOn", elem); }
                foreach (var elem in Global) { if (elem != null) yield return new ElementValue("global", elem); }
                if (Definition != null) yield return new ElementValue("definition", Definition);
                if (Manifest != null) yield return new ElementValue("manifest", Manifest);
            }
        }

    }

}
