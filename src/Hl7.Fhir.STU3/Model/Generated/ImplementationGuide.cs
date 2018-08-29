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


        [FhirType("DependencyComponent")]
        [DataContract]
        public partial class DependencyComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DependencyComponent"; } }

            /// <summary>
            /// reference | inclusion
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<GuideDependencyType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<GuideDependencyType> _typeElement;

            /// <summary>
            /// reference | inclusion
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public GuideDependencyType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<GuideDependencyType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Where to find dependency
            /// </summary>
            [FhirElement("uri", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private FhirUri _uriElement;

            /// <summary>
            /// Where to find dependency
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DependencyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<GuideDependencyType>)TypeElement.DeepCopy();
                    if (UriElement != null) dest.UriElement = (FhirUri)UriElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DependencyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DependencyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DependencyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (UriElement != null) yield return UriElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                }
            }


        }


        [FhirType("PackageComponent")]
        [DataContract]
        public partial class PackageComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PackageComponent"; } }

            /// <summary>
            /// Name used .page.package
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name used .page.package
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

            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceComponent> Resource
            {
                get { if (_resource==null) _resource = new List<ResourceComponent>(); return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private List<ResourceComponent> _resource;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
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
                if ( !DeepComparable.Matches(Resource, otherT.Resource)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;

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
                    foreach (var elem in Resource) { if (elem != null) yield return elem; }
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
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", elem); }
                }
            }


        }


        [FhirType("ResourceComponent")]
        [DataContract]
        public partial class ResourceComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceComponent"; } }

            /// <summary>
            /// If not an example, has its normal meaning
            /// </summary>
            [FhirElement("example", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean ExampleElement
            {
                get { return _exampleElement; }
                set { _exampleElement = value; OnPropertyChanged("ExampleElement"); }
            }

            private FhirBoolean _exampleElement;

            /// <summary>
            /// If not an example, has its normal meaning
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Example
            {
                get { return ExampleElement != null ? ExampleElement.Value : null; }
                set
                {
                    if (value == null)
                        ExampleElement = null;
                    else
                        ExampleElement = new FhirBoolean(value);
                    OnPropertyChanged("Example");
                }
            }

            /// <summary>
            /// Human Name for the resource
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
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
            /// Short code to identify the resource
            /// </summary>
            [FhirElement("acronym", Order=70)]
            [DataMember]
            public FhirString AcronymElement
            {
                get { return _acronymElement; }
                set { _acronymElement = value; OnPropertyChanged("AcronymElement"); }
            }

            private FhirString _acronymElement;

            /// <summary>
            /// Short code to identify the resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Acronym
            {
                get { return AcronymElement != null ? AcronymElement.Value : null; }
                set
                {
                    if (value == null)
                        AcronymElement = null;
                    else
                        AcronymElement = new FhirString(value);
                    OnPropertyChanged("Acronym");
                }
            }

            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("source", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
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
            /// Resource this is an example of (if applicable)
            /// </summary>
            [FhirElement("exampleFor", Order=90)]
            [References("StructureDefinition")]
            [DataMember]
            public ResourceReference ExampleFor
            {
                get { return _exampleFor; }
                set { _exampleFor = value; OnPropertyChanged("ExampleFor"); }
            }

            private ResourceReference _exampleFor;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ExampleElement != null) dest.ExampleElement = (FhirBoolean)ExampleElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (AcronymElement != null) dest.AcronymElement = (FhirString)AcronymElement.DeepCopy();
                    if (Source != null) dest.Source = (Element)Source.DeepCopy();
                    if (ExampleFor != null) dest.ExampleFor = (ResourceReference)ExampleFor.DeepCopy();
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
                if (!DeepComparable.Matches(ExampleElement, otherT.ExampleElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(AcronymElement, otherT.AcronymElement)) return false;
                if (!DeepComparable.Matches(Source, otherT.Source)) return false;
                if (!DeepComparable.Matches(ExampleFor, otherT.ExampleFor)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ExampleElement, otherT.ExampleElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(AcronymElement, otherT.AcronymElement)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
                if (!DeepComparable.IsExactly(ExampleFor, otherT.ExampleFor)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ExampleElement != null) yield return ExampleElement;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (AcronymElement != null) yield return AcronymElement;
                    if (Source != null) yield return Source;
                    if (ExampleFor != null) yield return ExampleFor;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ExampleElement != null) yield return new ElementValue("example", ExampleElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (AcronymElement != null) yield return new ElementValue("acronym", AcronymElement);
                    if (Source != null) yield return new ElementValue("source", Source);
                    if (ExampleFor != null) yield return new ElementValue("exampleFor", ExampleFor);
                }
            }


        }


        [FhirType("GlobalComponent")]
        [DataContract]
        public partial class GlobalComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GlobalComponent"; } }

            /// <summary>
            /// Type this profiles applies to
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
            /// Type this profiles applies to
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
            [References("StructureDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private ResourceReference _profile;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GlobalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ResourceType>)TypeElement.DeepCopy();
                    if (Profile != null) dest.Profile = (ResourceReference)Profile.DeepCopy();
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
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GlobalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Profile != null) yield return Profile;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                }
            }


        }


        [FhirType("PageComponent")]
        [DataContract]
        public partial class PageComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PageComponent"; } }

            /// <summary>
            /// Where to find that page
            /// </summary>
            [FhirElement("source", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private FhirUri _sourceElement;

            /// <summary>
            /// Where to find that page
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
            /// Short title shown for navigational assistance
            /// </summary>
            [FhirElement("title", InSummary=true, Order=50)]
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
            /// page | example | list | include | directory | dictionary | toc | resource
            /// </summary>
            [FhirElement("kind", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<GuidePageKind> KindElement
            {
                get { return _kindElement; }
                set { _kindElement = value; OnPropertyChanged("KindElement"); }
            }

            private Code<GuidePageKind> _kindElement;

            /// <summary>
            /// page | example | list | include | directory | dictionary | toc | resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public GuidePageKind? Kind
            {
                get { return KindElement != null ? KindElement.Value : null; }
                set
                {
                    if (value == null)
                        KindElement = null;
                    else
                        KindElement = new Code<GuidePageKind>(value);
                    OnPropertyChanged("Kind");
                }
            }

            /// <summary>
            /// Kind of resource to include in the list
            /// </summary>
            [FhirElement("type", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<ResourceType>> TypeElement
            {
                get { if (_typeElement==null) _typeElement = new List<Code<ResourceType>>(); return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private List<Code<ResourceType>> _typeElement;

            /// <summary>
            /// Kind of resource to include in the list
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<ResourceType?> Type
            {
                get { return TypeElement != null ? TypeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Name of package to include
            /// </summary>
            [FhirElement("package", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> PackageElement
            {
                get { if (_packageElement==null) _packageElement = new List<FhirString>(); return _packageElement; }
                set { _packageElement = value; OnPropertyChanged("PackageElement"); }
            }

            private List<FhirString> _packageElement;

            /// <summary>
            /// Name of package to include
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Package
            {
                get { return PackageElement != null ? PackageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PackageElement = null;
                    else
                        PackageElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Package");
                }
            }

            /// <summary>
            /// Format of the page (e.g. html, markdown, etc.)
            /// </summary>
            [FhirElement("format", Order=90)]
            [DataMember]
            public Code FormatElement
            {
                get { return _formatElement; }
                set { _formatElement = value; OnPropertyChanged("FormatElement"); }
            }

            private Code _formatElement;

            /// <summary>
            /// Format of the page (e.g. html, markdown, etc.)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Format
            {
                get { return FormatElement != null ? FormatElement.Value : null; }
                set
                {
                    if (value == null)
                        FormatElement = null;
                    else
                        FormatElement = new Code(value);
                    OnPropertyChanged("Format");
                }
            }

            /// <summary>
            /// Nested Pages / Sections
            /// </summary>
            [FhirElement("page", Order=100)]
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
                    if (SourceElement != null) dest.SourceElement = (FhirUri)SourceElement.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (KindElement != null) dest.KindElement = (Code<GuidePageKind>)KindElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = new List<Code<ResourceType>>(TypeElement.DeepCopy());
                    if (PackageElement != null) dest.PackageElement = new List<FhirString>(PackageElement.DeepCopy());
                    if (FormatElement != null) dest.FormatElement = (Code)FormatElement.DeepCopy();
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
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
                if ( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if ( !DeepComparable.Matches(PackageElement, otherT.PackageElement)) return false;
                if (!DeepComparable.Matches(FormatElement, otherT.FormatElement)) return false;
                if ( !DeepComparable.Matches(Page, otherT.Page)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(PackageElement, otherT.PackageElement)) return false;
                if (!DeepComparable.IsExactly(FormatElement, otherT.FormatElement)) return false;
                if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SourceElement != null) yield return SourceElement;
                    if (TitleElement != null) yield return TitleElement;
                    if (KindElement != null) yield return KindElement;
                    foreach (var elem in TypeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in PackageElement) { if (elem != null) yield return elem; }
                    if (FormatElement != null) yield return FormatElement;
                    foreach (var elem in Page) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    if (KindElement != null) yield return new ElementValue("kind", KindElement);
                    foreach (var elem in TypeElement) { if (elem != null) yield return new ElementValue("type", elem); }
                    foreach (var elem in PackageElement) { if (elem != null) yield return new ElementValue("package", elem); }
                    if (FormatElement != null) yield return new ElementValue("format", FormatElement);
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", elem); }
                }
            }


        }


        /// <summary>
        /// Logical URI to reference this implementation guide (globally unique)
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
        /// Logical URI to reference this implementation guide (globally unique)
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
        /// Context the content is intended to support
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
        [FhirElement("dependency", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DependencyComponent> Dependency
        {
            get { if (_dependency==null) _dependency = new List<DependencyComponent>(); return _dependency; }
            set { _dependency = value; OnPropertyChanged("Dependency"); }
        }

        private List<DependencyComponent> _dependency;

        /// <summary>
        /// Group of resources as used in .page.package
        /// </summary>
        [FhirElement("package", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PackageComponent> Package
        {
            get { if (_package==null) _package = new List<PackageComponent>(); return _package; }
            set { _package = value; OnPropertyChanged("Package"); }
        }

        private List<PackageComponent> _package;

        /// <summary>
        /// Profiles that apply globally
        /// </summary>
        [FhirElement("global", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GlobalComponent> Global
        {
            get { if (_global==null) _global = new List<GlobalComponent>(); return _global; }
            set { _global = value; OnPropertyChanged("Global"); }
        }

        private List<GlobalComponent> _global;

        /// <summary>
        /// Image, css, script, etc.
        /// </summary>
        [FhirElement("binary", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> BinaryElement
        {
            get { if (_binaryElement==null) _binaryElement = new List<FhirUri>(); return _binaryElement; }
            set { _binaryElement = value; OnPropertyChanged("BinaryElement"); }
        }

        private List<FhirUri> _binaryElement;

        /// <summary>
        /// Image, css, script, etc.
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Binary
        {
            get { return BinaryElement != null ? BinaryElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    BinaryElement = null;
                else
                    BinaryElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Binary");
            }
        }

        /// <summary>
        /// Page/Section in the Guide
        /// </summary>
        [FhirElement("page", InSummary=true, Order=260)]
        [DataMember]
        public PageComponent Page
        {
            get { return _page; }
            set { _page = value; OnPropertyChanged("Page"); }
        }

        private PageComponent _page;


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
                if (Dependency != null) dest.Dependency = new List<DependencyComponent>(Dependency.DeepCopy());
                if (Package != null) dest.Package = new List<PackageComponent>(Package.DeepCopy());
                if (Global != null) dest.Global = new List<GlobalComponent>(Global.DeepCopy());
                if (BinaryElement != null) dest.BinaryElement = new List<FhirUri>(BinaryElement.DeepCopy());
                if (Page != null) dest.Page = (PageComponent)Page.DeepCopy();
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
            if ( !DeepComparable.Matches(Dependency, otherT.Dependency)) return false;
            if ( !DeepComparable.Matches(Package, otherT.Package)) return false;
            if ( !DeepComparable.Matches(Global, otherT.Global)) return false;
            if ( !DeepComparable.Matches(BinaryElement, otherT.BinaryElement)) return false;
            if (!DeepComparable.Matches(Page, otherT.Page)) return false;

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
            if (!DeepComparable.IsExactly(Dependency, otherT.Dependency)) return false;
            if (!DeepComparable.IsExactly(Package, otherT.Package)) return false;
            if (!DeepComparable.IsExactly(Global, otherT.Global)) return false;
            if (!DeepComparable.IsExactly(BinaryElement, otherT.BinaryElement)) return false;
            if (!DeepComparable.IsExactly(Page, otherT.Page)) return false;

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
                foreach (var elem in Dependency) { if (elem != null) yield return elem; }
                foreach (var elem in Package) { if (elem != null) yield return elem; }
                foreach (var elem in Global) { if (elem != null) yield return elem; }
                foreach (var elem in BinaryElement) { if (elem != null) yield return elem; }
                if (Page != null) yield return Page;
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
                foreach (var elem in Dependency) { if (elem != null) yield return new ElementValue("dependency", elem); }
                foreach (var elem in Package) { if (elem != null) yield return new ElementValue("package", elem); }
                foreach (var elem in Global) { if (elem != null) yield return new ElementValue("global", elem); }
                foreach (var elem in BinaryElement) { if (elem != null) yield return new ElementValue("binary", elem); }
                if (Page != null) yield return new ElementValue("page", Page);
            }
        }

    }

}
