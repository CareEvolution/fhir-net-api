using System;
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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A set of rules about how FHIR is used
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "ImplementationGuide", IsResource=true)]
    [DataContract]
    public partial class ImplementationGuide : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImplementationGuide; } }
        [NotMapped]
        public override string TypeName { get { return "ImplementationGuide"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DependsOnComponent")]
        [DataContract]
        public partial class DependsOnComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DependsOnComponent"; } }
            
            /// <summary>
            /// Identity of the IG that this depends on
            /// </summary>
            [FhirElement("uri", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.canonical Uri
            {
                get { return _Uri; }
                set { _Uri = value; OnPropertyChanged("Uri"); }
            }
            
            private Hl7.Fhir.Model.canonical _Uri;
            
            /// <summary>
            /// Version of the IG
            /// </summary>
            [FhirElement("version", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString VersionElement
            {
                get { return _VersionElement; }
                set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _VersionElement;
            
            /// <summary>
            /// Version of the IG
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
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DependsOnComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Uri != null) dest.Uri = (Hl7.Fhir.Model.canonical)Uri.DeepCopy();
                    if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Uri, otherT.Uri)) return false;
                if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DependsOnComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Uri, otherT.Uri)) return false;
                if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Uri != null) yield return Uri;
                    if (VersionElement != null) yield return VersionElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Uri != null) yield return new ElementValue("uri", false, Uri);
                    if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "GlobalComponent")]
        [DataContract]
        public partial class GlobalComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "GlobalComponent"; } }
            
            /// <summary>
            /// Type this profile applies to
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _TypeElement;
            
            /// <summary>
            /// Type this profile applies to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Profile that all resources must conform to
            /// </summary>
            [FhirElement("profile", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.canonical Profile
            {
                get { return _Profile; }
                set { _Profile = value; OnPropertyChanged("Profile"); }
            }
            
            private Hl7.Fhir.Model.canonical _Profile;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GlobalComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.R4.Code)TypeElement.DeepCopy();
                    if(Profile != null) dest.Profile = (Hl7.Fhir.Model.canonical)Profile.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GlobalComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
            
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
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (Profile != null) yield return new ElementValue("profile", false, Profile);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DefinitionComponent")]
        [DataContract]
        public partial class DefinitionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
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
                get { if(_Package==null) _Package = new List<PackageComponent>(); return _Package; }
                set { _Package = value; OnPropertyChanged("Package"); }
            }
            
            private List<PackageComponent> _Package;
            
            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceComponent> Resource
            {
                get { if(_Resource==null) _Resource = new List<ResourceComponent>(); return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private List<ResourceComponent> _Resource;
            
            /// <summary>
            /// Page/Section in the Guide
            /// </summary>
            [FhirElement("page", Order=60)]
            [DataMember]
            public PageComponent Page
            {
                get { return _Page; }
                set { _Page = value; OnPropertyChanged("Page"); }
            }
            
            private PageComponent _Page;
            
            /// <summary>
            /// Defines how IG is built by tools
            /// </summary>
            [FhirElement("parameter", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Parameter
            {
                get { if(_Parameter==null) _Parameter = new List<ParameterComponent>(); return _Parameter; }
                set { _Parameter = value; OnPropertyChanged("Parameter"); }
            }
            
            private List<ParameterComponent> _Parameter;
            
            /// <summary>
            /// A template for building resources
            /// </summary>
            [FhirElement("template", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TemplateComponent> Template
            {
                get { if(_Template==null) _Template = new List<TemplateComponent>(); return _Template; }
                set { _Template = value; OnPropertyChanged("Template"); }
            }
            
            private List<TemplateComponent> _Template;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DefinitionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Package != null) dest.Package = new List<PackageComponent>(Package.DeepCopy());
                    if(Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
                    if(Page != null) dest.Page = (PageComponent)Page.DeepCopy();
                    if(Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                    if(Template != null) dest.Template = new List<TemplateComponent>(Template.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Package, otherT.Package)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Page, otherT.Page)) return false;
                if( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;
                if( !DeepComparable.Matches(Template, otherT.Template)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DefinitionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Package, otherT.Package)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Page, otherT.Page)) return false;
                if( !DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;
                if( !DeepComparable.IsExactly(Template, otherT.Template)) return false;
            
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
                    foreach (var elem in Package) { if (elem != null) yield return new ElementValue("package", true, elem); }
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", true, elem); }
                    if (Page != null) yield return new ElementValue("page", false, Page);
                    foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", true, elem); }
                    foreach (var elem in Template) { if (elem != null) yield return new ElementValue("template", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PackageComponent")]
        [DataContract]
        public partial class PackageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PackageComponent"; } }
            
            /// <summary>
            /// Name used .resource.package and .page.package
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name used .resource.package and .page.package
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
            /// Human readable text describing the package
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Human readable text describing the package
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
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            
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
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ResourceComponent")]
        [DataContract]
        public partial class ResourceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceComponent"; } }
            
            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("reference", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Reference;
            
            /// <summary>
            /// Human Name for the resource
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Human Name for the resource
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
            /// Reason why included in guide
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Reason why included in guide
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
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Is an example/What is this an example of?
            /// </summary>
            [FhirElement("example", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.canonical))]
            [DataMember]
            public Hl7.Fhir.Model.Element Example
            {
                get { return _Example; }
                set { _Example = value; OnPropertyChanged("Example"); }
            }
            
            private Hl7.Fhir.Model.Element _Example;
            
            /// <summary>
            /// Pack this is part of
            /// </summary>
            [FhirElement("package", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Id PackageElement
            {
                get { return _PackageElement; }
                set { _PackageElement = value; OnPropertyChanged("PackageElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Id _PackageElement;
            
            /// <summary>
            /// Pack this is part of
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Package
            {
                get { return PackageElement != null ? PackageElement.Value : null; }
                set
                {
                    if (value == null)
                        PackageElement = null;
                    else
                        PackageElement = new Hl7.Fhir.Model.R4.Id(value);
                    OnPropertyChanged("Package");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.R4.ResourceReference)Reference.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Example != null) dest.Example = (Hl7.Fhir.Model.Element)Example.DeepCopy();
                    if(PackageElement != null) dest.PackageElement = (Hl7.Fhir.Model.R4.Id)PackageElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Example, otherT.Example)) return false;
                if( !DeepComparable.Matches(PackageElement, otherT.PackageElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Example, otherT.Example)) return false;
                if( !DeepComparable.IsExactly(PackageElement, otherT.PackageElement)) return false;
            
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
                    if (Reference != null) yield return new ElementValue("reference", false, Reference);
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (Example != null) yield return new ElementValue("example", false, Example);
                    if (PackageElement != null) yield return new ElementValue("package", false, PackageElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PageComponent")]
        [DataContract]
        public partial class PageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PageComponent"; } }
            
            /// <summary>
            /// Where to find that page
            /// </summary>
            [FhirElement("name", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.url),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Name
            {
                get { return _Name; }
                set { _Name = value; OnPropertyChanged("Name"); }
            }
            
            private Hl7.Fhir.Model.Element _Name;
            
            /// <summary>
            /// Short title shown for navigational assistance
            /// </summary>
            [FhirElement("title", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TitleElement
            {
                get { return _TitleElement; }
                set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TitleElement;
            
            /// <summary>
            /// Short title shown for navigational assistance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Title");
                }
            }
            
            /// <summary>
            /// html | markdown | xml | generated
            /// </summary>
            [FhirElement("generation", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code GenerationElement
            {
                get { return _GenerationElement; }
                set { _GenerationElement = value; OnPropertyChanged("GenerationElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _GenerationElement;
            
            /// <summary>
            /// html | markdown | xml | generated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Generation
            {
                get { return GenerationElement != null ? GenerationElement.Value : null; }
                set
                {
                    if (value == null)
                        GenerationElement = null;
                    else
                        GenerationElement = new Hl7.Fhir.Model.R4.Code(value);
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
                get { if(_Page==null) _Page = new List<PageComponent>(); return _Page; }
                set { _Page = value; OnPropertyChanged("Page"); }
            }
            
            private List<PageComponent> _Page;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Name != null) dest.Name = (Hl7.Fhir.Model.Element)Name.DeepCopy();
                    if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                    if(GenerationElement != null) dest.GenerationElement = (Hl7.Fhir.Model.R4.Code)GenerationElement.DeepCopy();
                    if(Page != null) dest.Page = new List<PageComponent>(Page.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Name, otherT.Name)) return false;
                if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if( !DeepComparable.Matches(GenerationElement, otherT.GenerationElement)) return false;
                if( !DeepComparable.Matches(Page, otherT.Page)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if( !DeepComparable.IsExactly(GenerationElement, otherT.GenerationElement)) return false;
                if( !DeepComparable.IsExactly(Page, otherT.Page)) return false;
            
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
                    if (Name != null) yield return new ElementValue("name", false, Name);
                    if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                    if (GenerationElement != null) yield return new ElementValue("generation", false, GenerationElement);
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }
            
            /// <summary>
            /// apply-business-version | apply-jurisdiction | path-resource | path-pages | path-tx-cache | expansion-profile | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _CodeElement;
            
            /// <summary>
            /// apply-business-version | apply-jurisdiction | path-resource | path-pages | path-tx-cache | expansion-profile | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template
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
                        CodeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Value for named type
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// Value for named type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.R4.Code)CodeElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            
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
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    if (ValueElement != null) yield return new ElementValue("value", false, ValueElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "TemplateComponent")]
        [DataContract]
        public partial class TemplateComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TemplateComponent"; } }
            
            /// <summary>
            /// Type of template specified
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _CodeElement;
            
            /// <summary>
            /// Type of template specified
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
                        CodeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// The source location for the template
            /// </summary>
            [FhirElement("source", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString SourceElement
            {
                get { return _SourceElement; }
                set { _SourceElement = value; OnPropertyChanged("SourceElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _SourceElement;
            
            /// <summary>
            /// The source location for the template
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Source");
                }
            }
            
            /// <summary>
            /// The scope in which the template applies
            /// </summary>
            [FhirElement("scope", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ScopeElement
            {
                get { return _ScopeElement; }
                set { _ScopeElement = value; OnPropertyChanged("ScopeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ScopeElement;
            
            /// <summary>
            /// The scope in which the template applies
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Scope
            {
                get { return ScopeElement != null ? ScopeElement.Value : null; }
                set
                {
                    if (value == null)
                        ScopeElement = null;
                    else
                        ScopeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Scope");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TemplateComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.R4.Code)CodeElement.DeepCopy();
                    if(SourceElement != null) dest.SourceElement = (Hl7.Fhir.Model.FhirString)SourceElement.DeepCopy();
                    if(ScopeElement != null) dest.ScopeElement = (Hl7.Fhir.Model.FhirString)ScopeElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if( !DeepComparable.Matches(ScopeElement, otherT.ScopeElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TemplateComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if( !DeepComparable.IsExactly(ScopeElement, otherT.ScopeElement)) return false;
            
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
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    if (SourceElement != null) yield return new ElementValue("source", false, SourceElement);
                    if (ScopeElement != null) yield return new ElementValue("scope", false, ScopeElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ManifestComponent")]
        [DataContract]
        public partial class ManifestComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ManifestComponent"; } }
            
            /// <summary>
            /// Location of rendered implementation guide
            /// </summary>
            [FhirElement("rendering", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.url Rendering
            {
                get { return _Rendering; }
                set { _Rendering = value; OnPropertyChanged("Rendering"); }
            }
            
            private Hl7.Fhir.Model.url _Rendering;
            
            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceComponent> Resource
            {
                get { if(_Resource==null) _Resource = new List<ResourceComponent>(); return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private List<ResourceComponent> _Resource;
            
            /// <summary>
            /// HTML page within the parent IG
            /// </summary>
            [FhirElement("page", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PageComponent> Page
            {
                get { if(_Page==null) _Page = new List<PageComponent>(); return _Page; }
                set { _Page = value; OnPropertyChanged("Page"); }
            }
            
            private List<PageComponent> _Page;
            
            /// <summary>
            /// Image within the IG
            /// </summary>
            [FhirElement("image", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> ImageElement
            {
                get { if(_ImageElement==null) _ImageElement = new List<Hl7.Fhir.Model.FhirString>(); return _ImageElement; }
                set { _ImageElement = value; OnPropertyChanged("ImageElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _ImageElement;
            
            /// <summary>
            /// Image within the IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Image
            {
                get { return ImageElement != null ? ImageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ImageElement = null;
                    else
                        ImageElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Image");
                }
            }
            
            /// <summary>
            /// Additional linkable file in IG
            /// </summary>
            [FhirElement("other", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> OtherElement
            {
                get { if(_OtherElement==null) _OtherElement = new List<Hl7.Fhir.Model.FhirString>(); return _OtherElement; }
                set { _OtherElement = value; OnPropertyChanged("OtherElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _OtherElement;
            
            /// <summary>
            /// Additional linkable file in IG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Other
            {
                get { return OtherElement != null ? OtherElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OtherElement = null;
                    else
                        OtherElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Other");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManifestComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Rendering != null) dest.Rendering = (Hl7.Fhir.Model.url)Rendering.DeepCopy();
                    if(Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
                    if(Page != null) dest.Page = new List<PageComponent>(Page.DeepCopy());
                    if(ImageElement != null) dest.ImageElement = new List<Hl7.Fhir.Model.FhirString>(ImageElement.DeepCopy());
                    if(OtherElement != null) dest.OtherElement = new List<Hl7.Fhir.Model.FhirString>(OtherElement.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Rendering, otherT.Rendering)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Page, otherT.Page)) return false;
                if( !DeepComparable.Matches(ImageElement, otherT.ImageElement)) return false;
                if( !DeepComparable.Matches(OtherElement, otherT.OtherElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManifestComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Rendering, otherT.Rendering)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Page, otherT.Page)) return false;
                if( !DeepComparable.IsExactly(ImageElement, otherT.ImageElement)) return false;
                if( !DeepComparable.IsExactly(OtherElement, otherT.OtherElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Rendering != null) yield return Rendering;
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
                    if (Rendering != null) yield return new ElementValue("rendering", false, Rendering);
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", true, elem); }
                    foreach (var elem in Page) { if (elem != null) yield return new ElementValue("page", true, elem); }
                    foreach (var elem in ImageElement) { if (elem != null) yield return new ElementValue("image", true, elem); }
                    foreach (var elem in OtherElement) { if (elem != null) yield return new ElementValue("other", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ResourceComponent")]
        [DataContract]
        public partial class ResourceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceComponent"; } }
            
            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("reference", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Reference;
            
            /// <summary>
            /// Is an example/What is this an example of?
            /// </summary>
            [FhirElement("example", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.canonical))]
            [DataMember]
            public Hl7.Fhir.Model.Element Example
            {
                get { return _Example; }
                set { _Example = value; OnPropertyChanged("Example"); }
            }
            
            private Hl7.Fhir.Model.Element _Example;
            
            /// <summary>
            /// Relative path for page in IG
            /// </summary>
            [FhirElement("relativePath", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.url RelativePath
            {
                get { return _RelativePath; }
                set { _RelativePath = value; OnPropertyChanged("RelativePath"); }
            }
            
            private Hl7.Fhir.Model.url _RelativePath;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.R4.ResourceReference)Reference.DeepCopy();
                    if(Example != null) dest.Example = (Hl7.Fhir.Model.Element)Example.DeepCopy();
                    if(RelativePath != null) dest.RelativePath = (Hl7.Fhir.Model.url)RelativePath.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if( !DeepComparable.Matches(Example, otherT.Example)) return false;
                if( !DeepComparable.Matches(RelativePath, otherT.RelativePath)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if( !DeepComparable.IsExactly(Example, otherT.Example)) return false;
                if( !DeepComparable.IsExactly(RelativePath, otherT.RelativePath)) return false;
            
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
                    if (RelativePath != null) yield return RelativePath;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Reference != null) yield return new ElementValue("reference", false, Reference);
                    if (Example != null) yield return new ElementValue("example", false, Example);
                    if (RelativePath != null) yield return new ElementValue("relativePath", false, RelativePath);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PageComponent")]
        [DataContract]
        public partial class PageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PageComponent"; } }
            
            /// <summary>
            /// HTML page name
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// HTML page name
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
            /// Title of the page, for references
            /// </summary>
            [FhirElement("title", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TitleElement
            {
                get { return _TitleElement; }
                set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TitleElement;
            
            /// <summary>
            /// Title of the page, for references
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Title");
                }
            }
            
            /// <summary>
            /// Anchor available on the page
            /// </summary>
            [FhirElement("anchor", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> AnchorElement
            {
                get { if(_AnchorElement==null) _AnchorElement = new List<Hl7.Fhir.Model.FhirString>(); return _AnchorElement; }
                set { _AnchorElement = value; OnPropertyChanged("AnchorElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _AnchorElement;
            
            /// <summary>
            /// Anchor available on the page
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Anchor
            {
                get { return AnchorElement != null ? AnchorElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        AnchorElement = null;
                    else
                        AnchorElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Anchor");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                    if(AnchorElement != null) dest.AnchorElement = new List<Hl7.Fhir.Model.FhirString>(AnchorElement.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if( !DeepComparable.Matches(AnchorElement, otherT.AnchorElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if( !DeepComparable.IsExactly(AnchorElement, otherT.AnchorElement)) return false;
            
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
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                    foreach (var elem in AnchorElement) { if (elem != null) yield return new ElementValue("anchor", true, elem); }
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Canonical identifier for this implementation guide, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
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
        /// Canonical identifier for this implementation guide, represented as a URI (globally unique)
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
        /// Business version of the implementation guide
        /// </summary>
        [FhirElement("version", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Business version of the implementation guide
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
        /// Name for this implementation guide (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
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
        /// Name for this implementation guide (computer friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
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
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
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
                    DateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
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
        [FhirElement("contact", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
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
        /// Natural language description of the implementation guide
        /// </summary>
        [FhirElement("description", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _DescriptionElement;
        
        /// <summary>
        /// Natural language description of the implementation guide
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
        [FhirElement("useContext", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.R4.UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.R4.UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for implementation guide (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown CopyrightElement
        {
            get { return _CopyrightElement; }
            set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _CopyrightElement;
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }
        
        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Id FhirVersionElement
        {
            get { return _FhirVersionElement; }
            set { _FhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Id _FhirVersionElement;
        
        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if (value == null)
                    FhirVersionElement = null;
                else
                    FhirVersionElement = new Hl7.Fhir.Model.R4.Id(value);
                OnPropertyChanged("FhirVersion");
            }
        }
        
        /// <summary>
        /// Another Implementation guide this depends on
        /// </summary>
        [FhirElement("dependsOn", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DependsOnComponent> DependsOn
        {
            get { if(_DependsOn==null) _DependsOn = new List<DependsOnComponent>(); return _DependsOn; }
            set { _DependsOn = value; OnPropertyChanged("DependsOn"); }
        }
        
        private List<DependsOnComponent> _DependsOn;
        
        /// <summary>
        /// Profiles that apply globally
        /// </summary>
        [FhirElement("global", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GlobalComponent> Global
        {
            get { if(_Global==null) _Global = new List<GlobalComponent>(); return _Global; }
            set { _Global = value; OnPropertyChanged("Global"); }
        }
        
        private List<GlobalComponent> _Global;
        
        /// <summary>
        /// Information needed to build the IG
        /// </summary>
        [FhirElement("definition", Order=240)]
        [DataMember]
        public DefinitionComponent Definition
        {
            get { return _Definition; }
            set { _Definition = value; OnPropertyChanged("Definition"); }
        }
        
        private DefinitionComponent _Definition;
        
        /// <summary>
        /// Information about an assembled IG
        /// </summary>
        [FhirElement("manifest", Order=250)]
        [DataMember]
        public ManifestComponent Manifest
        {
            get { return _Manifest; }
            set { _Manifest = value; OnPropertyChanged("Manifest"); }
        }
        
        private ManifestComponent _Manifest;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImplementationGuide;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.R4.ContactDetail>(Contact.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.R4.UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Jurisdiction.DeepCopy());
                if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.Markdown)CopyrightElement.DeepCopy();
                if(FhirVersionElement != null) dest.FhirVersionElement = (Hl7.Fhir.Model.R4.Id)FhirVersionElement.DeepCopy();
                if(DependsOn != null) dest.DependsOn = new List<DependsOnComponent>(DependsOn.DeepCopy());
                if(Global != null) dest.Global = new List<GlobalComponent>(Global.DeepCopy());
                if(Definition != null) dest.Definition = (DefinitionComponent)Definition.DeepCopy();
                if(Manifest != null) dest.Manifest = (ManifestComponent)Manifest.DeepCopy();
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if( !DeepComparable.Matches(DependsOn, otherT.DependsOn)) return false;
            if( !DeepComparable.Matches(Global, otherT.Global)) return false;
            if( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if( !DeepComparable.Matches(Manifest, otherT.Manifest)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if( !DeepComparable.IsExactly(DependsOn, otherT.DependsOn)) return false;
            if( !DeepComparable.IsExactly(Global, otherT.Global)) return false;
            if( !DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if( !DeepComparable.IsExactly(Manifest, otherT.Manifest)) return false;
        
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
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (CopyrightElement != null) yield return CopyrightElement;
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
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", false, ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", false, PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", true, elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                if (CopyrightElement != null) yield return new ElementValue("copyright", false, CopyrightElement);
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", false, FhirVersionElement);
                foreach (var elem in DependsOn) { if (elem != null) yield return new ElementValue("dependsOn", true, elem); }
                foreach (var elem in Global) { if (elem != null) yield return new ElementValue("global", true, elem); }
                if (Definition != null) yield return new ElementValue("definition", false, Definition);
                if (Manifest != null) yield return new ElementValue("manifest", false, Manifest);
            }
        }
    
    }

}
