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
    /// Example of workflow instance
    /// </summary>
    [FhirType("ExampleScenario", IsResource=true)]
    [DataContract]
    public partial class ExampleScenario : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ExampleScenario; } }
        [NotMapped]
        public override string TypeName { get { return "ExampleScenario"; } }

        /// <summary>
        /// The type of actor - system or human.
        /// (url: http://hl7.org/fhir/ValueSet/examplescenario-actor-type)
        /// </summary>
        [FhirEnumeration("ExampleScenarioActorType")]
        public enum ExampleScenarioActorType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/examplescenario-actor-type)
            /// </summary>
            [EnumLiteral("person", "http://hl7.org/fhir/examplescenario-actor-type"), Description("Person")]
            Person,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/examplescenario-actor-type)
            /// </summary>
            [EnumLiteral("entity", "http://hl7.org/fhir/examplescenario-actor-type"), Description("System")]
            Entity,
        }


        [FhirType("ActorComponent")]
        [DataContract]
        public partial class ActorComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActorComponent"; } }

            /// <summary>
            /// ID or acronym of the actor
            /// </summary>
            [FhirElement("actorId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ActorIdElement
            {
                get { return _actorIdElement; }
                set { _actorIdElement = value; OnPropertyChanged("ActorIdElement"); }
            }

            private FhirString _actorIdElement;

            /// <summary>
            /// ID or acronym of the actor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ActorId
            {
                get { return ActorIdElement != null ? ActorIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ActorIdElement = null;
                    else
                        ActorIdElement = new FhirString(value);
                    OnPropertyChanged("ActorId");
                }
            }

            /// <summary>
            /// person | entity
            /// </summary>
            [FhirElement("type", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ExampleScenarioActorType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ExampleScenarioActorType> _typeElement;

            /// <summary>
            /// person | entity
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ExampleScenarioActorType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ExampleScenarioActorType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// The name of the actor as shown in the page
            /// </summary>
            [FhirElement("name", Order=60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// The name of the actor as shown in the page
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
            /// The description of the actor
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public Markdown DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private Markdown _descriptionElement;

            /// <summary>
            /// The description of the actor
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
                        DescriptionElement = new Markdown(value);
                    OnPropertyChanged("Description");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ActorIdElement != null) dest.ActorIdElement = (FhirString)ActorIdElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<ExampleScenarioActorType>)TypeElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ActorIdElement, otherT.ActorIdElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ActorIdElement, otherT.ActorIdElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
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
                    if (ActorIdElement != null) yield return ActorIdElement;
                    if (TypeElement != null) yield return TypeElement;
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
                    if (ActorIdElement != null) yield return new ElementValue("actorId", ActorIdElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        [FhirType("InstanceComponent")]
        [DataContract]
        public partial class InstanceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InstanceComponent"; } }

            /// <summary>
            /// The id of the resource for referencing
            /// </summary>
            [FhirElement("resourceId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ResourceIdElement
            {
                get { return _resourceIdElement; }
                set { _resourceIdElement = value; OnPropertyChanged("ResourceIdElement"); }
            }

            private FhirString _resourceIdElement;

            /// <summary>
            /// The id of the resource for referencing
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ResourceId
            {
                get { return ResourceIdElement != null ? ResourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ResourceIdElement = null;
                    else
                        ResourceIdElement = new FhirString(value);
                    OnPropertyChanged("ResourceId");
                }
            }

            /// <summary>
            /// The type of the resource
            /// </summary>
            [FhirElement("resourceType", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResourceType> ResourceTypeElement
            {
                get { return _resourceTypeElement; }
                set { _resourceTypeElement = value; OnPropertyChanged("ResourceTypeElement"); }
            }

            private Code<ResourceType> _resourceTypeElement;

            /// <summary>
            /// The type of the resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceType? ResourceType
            {
                get { return ResourceTypeElement != null ? ResourceTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        ResourceTypeElement = null;
                    else
                        ResourceTypeElement = new Code<ResourceType>(value);
                    OnPropertyChanged("ResourceType");
                }
            }

            /// <summary>
            /// A short name for the resource instance
            /// </summary>
            [FhirElement("name", Order=60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// A short name for the resource instance
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
            /// Human-friendly description of the resource instance
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public Markdown DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private Markdown _descriptionElement;

            /// <summary>
            /// Human-friendly description of the resource instance
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
                        DescriptionElement = new Markdown(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// A specific version of the resource
            /// </summary>
            [FhirElement("version", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<VersionComponent> Version
            {
                get { if (_version==null) _version = new List<VersionComponent>(); return _version; }
                set { _version = value; OnPropertyChanged("Version"); }
            }

            private List<VersionComponent> _version;

            /// <summary>
            /// Resources contained in the instance
            /// </summary>
            [FhirElement("containedInstance", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContainedInstanceComponent> ContainedInstance
            {
                get { if (_containedInstance==null) _containedInstance = new List<ContainedInstanceComponent>(); return _containedInstance; }
                set { _containedInstance = value; OnPropertyChanged("ContainedInstance"); }
            }

            private List<ContainedInstanceComponent> _containedInstance;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InstanceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ResourceIdElement != null) dest.ResourceIdElement = (FhirString)ResourceIdElement.DeepCopy();
                    if (ResourceTypeElement != null) dest.ResourceTypeElement = (Code<ResourceType>)ResourceTypeElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                    if (Version != null) dest.Version = new List<VersionComponent>(Version.DeepCopy());
                    if (ContainedInstance != null) dest.ContainedInstance = new List<ContainedInstanceComponent>(ContainedInstance.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InstanceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InstanceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ResourceIdElement, otherT.ResourceIdElement)) return false;
                if (!DeepComparable.Matches(ResourceTypeElement, otherT.ResourceTypeElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(Version, otherT.Version)) return false;
                if ( !DeepComparable.Matches(ContainedInstance, otherT.ContainedInstance)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InstanceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ResourceIdElement, otherT.ResourceIdElement)) return false;
                if (!DeepComparable.IsExactly(ResourceTypeElement, otherT.ResourceTypeElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Version, otherT.Version)) return false;
                if (!DeepComparable.IsExactly(ContainedInstance, otherT.ContainedInstance)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ResourceIdElement != null) yield return ResourceIdElement;
                    if (ResourceTypeElement != null) yield return ResourceTypeElement;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in Version) { if (elem != null) yield return elem; }
                    foreach (var elem in ContainedInstance) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ResourceIdElement != null) yield return new ElementValue("resourceId", ResourceIdElement);
                    if (ResourceTypeElement != null) yield return new ElementValue("resourceType", ResourceTypeElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in Version) { if (elem != null) yield return new ElementValue("version", elem); }
                    foreach (var elem in ContainedInstance) { if (elem != null) yield return new ElementValue("containedInstance", elem); }
                }
            }


        }


        [FhirType("VersionComponent")]
        [DataContract]
        public partial class VersionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VersionComponent"; } }

            /// <summary>
            /// The identifier of a specific version of a resource
            /// </summary>
            [FhirElement("versionId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString VersionIdElement
            {
                get { return _versionIdElement; }
                set { _versionIdElement = value; OnPropertyChanged("VersionIdElement"); }
            }

            private FhirString _versionIdElement;

            /// <summary>
            /// The identifier of a specific version of a resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string VersionId
            {
                get { return VersionIdElement != null ? VersionIdElement.Value : null; }
                set
                {
                    if (value == null)
                        VersionIdElement = null;
                    else
                        VersionIdElement = new FhirString(value);
                    OnPropertyChanged("VersionId");
                }
            }

            /// <summary>
            /// The description of the resource version
            /// </summary>
            [FhirElement("description", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Markdown DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private Markdown _descriptionElement;

            /// <summary>
            /// The description of the resource version
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
                        DescriptionElement = new Markdown(value);
                    OnPropertyChanged("Description");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VersionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (VersionIdElement != null) dest.VersionIdElement = (FhirString)VersionIdElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VersionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(VersionIdElement, otherT.VersionIdElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(VersionIdElement, otherT.VersionIdElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (VersionIdElement != null) yield return VersionIdElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (VersionIdElement != null) yield return new ElementValue("versionId", VersionIdElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        [FhirType("ContainedInstanceComponent")]
        [DataContract]
        public partial class ContainedInstanceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContainedInstanceComponent"; } }

            /// <summary>
            /// Each resource contained in the instance
            /// </summary>
            [FhirElement("resourceId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ResourceIdElement
            {
                get { return _resourceIdElement; }
                set { _resourceIdElement = value; OnPropertyChanged("ResourceIdElement"); }
            }

            private FhirString _resourceIdElement;

            /// <summary>
            /// Each resource contained in the instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ResourceId
            {
                get { return ResourceIdElement != null ? ResourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ResourceIdElement = null;
                    else
                        ResourceIdElement = new FhirString(value);
                    OnPropertyChanged("ResourceId");
                }
            }

            /// <summary>
            /// A specific version of a resource contained in the instance
            /// </summary>
            [FhirElement("versionId", Order=50)]
            [DataMember]
            public FhirString VersionIdElement
            {
                get { return _versionIdElement; }
                set { _versionIdElement = value; OnPropertyChanged("VersionIdElement"); }
            }

            private FhirString _versionIdElement;

            /// <summary>
            /// A specific version of a resource contained in the instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string VersionId
            {
                get { return VersionIdElement != null ? VersionIdElement.Value : null; }
                set
                {
                    if (value == null)
                        VersionIdElement = null;
                    else
                        VersionIdElement = new FhirString(value);
                    OnPropertyChanged("VersionId");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContainedInstanceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ResourceIdElement != null) dest.ResourceIdElement = (FhirString)ResourceIdElement.DeepCopy();
                    if (VersionIdElement != null) dest.VersionIdElement = (FhirString)VersionIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContainedInstanceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContainedInstanceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ResourceIdElement, otherT.ResourceIdElement)) return false;
                if (!DeepComparable.Matches(VersionIdElement, otherT.VersionIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContainedInstanceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ResourceIdElement, otherT.ResourceIdElement)) return false;
                if (!DeepComparable.IsExactly(VersionIdElement, otherT.VersionIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ResourceIdElement != null) yield return ResourceIdElement;
                    if (VersionIdElement != null) yield return VersionIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ResourceIdElement != null) yield return new ElementValue("resourceId", ResourceIdElement);
                    if (VersionIdElement != null) yield return new ElementValue("versionId", VersionIdElement);
                }
            }


        }


        [FhirType("ProcessComponent")]
        [DataContract]
        public partial class ProcessComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProcessComponent"; } }

            /// <summary>
            /// The diagram title of the group of operations
            /// </summary>
            [FhirElement("title", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// The diagram title of the group of operations
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
            /// A longer description of the group of operations
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public Markdown DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private Markdown _descriptionElement;

            /// <summary>
            /// A longer description of the group of operations
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
                        DescriptionElement = new Markdown(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// Description of initial status before the process starts
            /// </summary>
            [FhirElement("preConditions", Order=60)]
            [DataMember]
            public Markdown PreConditionsElement
            {
                get { return _preConditionsElement; }
                set { _preConditionsElement = value; OnPropertyChanged("PreConditionsElement"); }
            }

            private Markdown _preConditionsElement;

            /// <summary>
            /// Description of initial status before the process starts
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PreConditions
            {
                get { return PreConditionsElement != null ? PreConditionsElement.Value : null; }
                set
                {
                    if (value == null)
                        PreConditionsElement = null;
                    else
                        PreConditionsElement = new Markdown(value);
                    OnPropertyChanged("PreConditions");
                }
            }

            /// <summary>
            /// Description of final status after the process ends
            /// </summary>
            [FhirElement("postConditions", Order=70)]
            [DataMember]
            public Markdown PostConditionsElement
            {
                get { return _postConditionsElement; }
                set { _postConditionsElement = value; OnPropertyChanged("PostConditionsElement"); }
            }

            private Markdown _postConditionsElement;

            /// <summary>
            /// Description of final status after the process ends
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PostConditions
            {
                get { return PostConditionsElement != null ? PostConditionsElement.Value : null; }
                set
                {
                    if (value == null)
                        PostConditionsElement = null;
                    else
                        PostConditionsElement = new Markdown(value);
                    OnPropertyChanged("PostConditions");
                }
            }

            /// <summary>
            /// Each step of the process
            /// </summary>
            [FhirElement("step", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StepComponent> Step
            {
                get { if (_step==null) _step = new List<StepComponent>(); return _step; }
                set { _step = value; OnPropertyChanged("Step"); }
            }

            private List<StepComponent> _step;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcessComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                    if (PreConditionsElement != null) dest.PreConditionsElement = (Markdown)PreConditionsElement.DeepCopy();
                    if (PostConditionsElement != null) dest.PostConditionsElement = (Markdown)PostConditionsElement.DeepCopy();
                    if (Step != null) dest.Step = new List<StepComponent>(Step.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProcessComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcessComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(PreConditionsElement, otherT.PreConditionsElement)) return false;
                if (!DeepComparable.Matches(PostConditionsElement, otherT.PostConditionsElement)) return false;
                if ( !DeepComparable.Matches(Step, otherT.Step)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcessComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(PreConditionsElement, otherT.PreConditionsElement)) return false;
                if (!DeepComparable.IsExactly(PostConditionsElement, otherT.PostConditionsElement)) return false;
                if (!DeepComparable.IsExactly(Step, otherT.Step)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TitleElement != null) yield return TitleElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (PreConditionsElement != null) yield return PreConditionsElement;
                    if (PostConditionsElement != null) yield return PostConditionsElement;
                    foreach (var elem in Step) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (PreConditionsElement != null) yield return new ElementValue("preConditions", PreConditionsElement);
                    if (PostConditionsElement != null) yield return new ElementValue("postConditions", PostConditionsElement);
                    foreach (var elem in Step) { if (elem != null) yield return new ElementValue("step", elem); }
                }
            }


        }


        [FhirType("StepComponent")]
        [DataContract]
        public partial class StepComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StepComponent"; } }

            /// <summary>
            /// Nested process
            /// </summary>
            [FhirElement("process", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ProcessComponent> Process
            {
                get { if (_process==null) _process = new List<ProcessComponent>(); return _process; }
                set { _process = value; OnPropertyChanged("Process"); }
            }

            private List<ProcessComponent> _process;

            /// <summary>
            /// If there is a pause in the flow
            /// </summary>
            [FhirElement("pause", Order=50)]
            [DataMember]
            public FhirBoolean PauseElement
            {
                get { return _pauseElement; }
                set { _pauseElement = value; OnPropertyChanged("PauseElement"); }
            }

            private FhirBoolean _pauseElement;

            /// <summary>
            /// If there is a pause in the flow
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Pause
            {
                get { return PauseElement != null ? PauseElement.Value : null; }
                set
                {
                    if (value == null)
                        PauseElement = null;
                    else
                        PauseElement = new FhirBoolean(value);
                    OnPropertyChanged("Pause");
                }
            }

            /// <summary>
            /// Each interaction or action
            /// </summary>
            [FhirElement("operation", Order=60)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// Each interaction in the process
            /// </summary>
            [FhirElement("alternative", Order=70)]
            [DataMember]
            public AlternativeComponent Alternative
            {
                get { return _alternative; }
                set { _alternative = value; OnPropertyChanged("Alternative"); }
            }

            private AlternativeComponent _alternative;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StepComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Process != null) dest.Process = new List<ProcessComponent>(Process.DeepCopy());
                    if (PauseElement != null) dest.PauseElement = (FhirBoolean)PauseElement.DeepCopy();
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Alternative != null) dest.Alternative = (AlternativeComponent)Alternative.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StepComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StepComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Process, otherT.Process)) return false;
                if (!DeepComparable.Matches(PauseElement, otherT.PauseElement)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Alternative, otherT.Alternative)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StepComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Process, otherT.Process)) return false;
                if (!DeepComparable.IsExactly(PauseElement, otherT.PauseElement)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Alternative, otherT.Alternative)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Process) { if (elem != null) yield return elem; }
                    if (PauseElement != null) yield return PauseElement;
                    if (Operation != null) yield return Operation;
                    if (Alternative != null) yield return Alternative;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Process) { if (elem != null) yield return new ElementValue("process", elem); }
                    if (PauseElement != null) yield return new ElementValue("pause", PauseElement);
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Alternative != null) yield return new ElementValue("alternative", Alternative);
                }
            }


        }


        [FhirType("OperationComponent")]
        [DataContract]
        public partial class OperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OperationComponent"; } }

            /// <summary>
            /// The sequential number of the interaction
            /// </summary>
            [FhirElement("number", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NumberElement
            {
                get { return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private FhirString _numberElement;

            /// <summary>
            /// The sequential number of the interaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new FhirString(value);
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// The type of operation - CRUD
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public FhirString TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private FhirString _typeElement;

            /// <summary>
            /// The type of operation - CRUD
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new FhirString(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// The human-friendly name of the interaction
            /// </summary>
            [FhirElement("name", Order=60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// The human-friendly name of the interaction
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
            /// Who starts the transaction
            /// </summary>
            [FhirElement("initiator", Order=70)]
            [DataMember]
            public FhirString InitiatorElement
            {
                get { return _initiatorElement; }
                set { _initiatorElement = value; OnPropertyChanged("InitiatorElement"); }
            }

            private FhirString _initiatorElement;

            /// <summary>
            /// Who starts the transaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Initiator
            {
                get { return InitiatorElement != null ? InitiatorElement.Value : null; }
                set
                {
                    if (value == null)
                        InitiatorElement = null;
                    else
                        InitiatorElement = new FhirString(value);
                    OnPropertyChanged("Initiator");
                }
            }

            /// <summary>
            /// Who receives the transaction
            /// </summary>
            [FhirElement("receiver", Order=80)]
            [DataMember]
            public FhirString ReceiverElement
            {
                get { return _receiverElement; }
                set { _receiverElement = value; OnPropertyChanged("ReceiverElement"); }
            }

            private FhirString _receiverElement;

            /// <summary>
            /// Who receives the transaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Receiver
            {
                get { return ReceiverElement != null ? ReceiverElement.Value : null; }
                set
                {
                    if (value == null)
                        ReceiverElement = null;
                    else
                        ReceiverElement = new FhirString(value);
                    OnPropertyChanged("Receiver");
                }
            }

            /// <summary>
            /// A comment to be inserted in the diagram
            /// </summary>
            [FhirElement("description", Order=90)]
            [DataMember]
            public Markdown DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private Markdown _descriptionElement;

            /// <summary>
            /// A comment to be inserted in the diagram
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
                        DescriptionElement = new Markdown(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// Whether the initiator is deactivated right after the transaction
            /// </summary>
            [FhirElement("initiatorActive", Order=100)]
            [DataMember]
            public FhirBoolean InitiatorActiveElement
            {
                get { return _initiatorActiveElement; }
                set { _initiatorActiveElement = value; OnPropertyChanged("InitiatorActiveElement"); }
            }

            private FhirBoolean _initiatorActiveElement;

            /// <summary>
            /// Whether the initiator is deactivated right after the transaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? InitiatorActive
            {
                get { return InitiatorActiveElement != null ? InitiatorActiveElement.Value : null; }
                set
                {
                    if (value == null)
                        InitiatorActiveElement = null;
                    else
                        InitiatorActiveElement = new FhirBoolean(value);
                    OnPropertyChanged("InitiatorActive");
                }
            }

            /// <summary>
            /// Whether the receiver is deactivated right after the transaction
            /// </summary>
            [FhirElement("receiverActive", Order=110)]
            [DataMember]
            public FhirBoolean ReceiverActiveElement
            {
                get { return _receiverActiveElement; }
                set { _receiverActiveElement = value; OnPropertyChanged("ReceiverActiveElement"); }
            }

            private FhirBoolean _receiverActiveElement;

            /// <summary>
            /// Whether the receiver is deactivated right after the transaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? ReceiverActive
            {
                get { return ReceiverActiveElement != null ? ReceiverActiveElement.Value : null; }
                set
                {
                    if (value == null)
                        ReceiverActiveElement = null;
                    else
                        ReceiverActiveElement = new FhirBoolean(value);
                    OnPropertyChanged("ReceiverActive");
                }
            }

            /// <summary>
            /// Each resource instance used by the initiator
            /// </summary>
            [FhirElement("request", Order=120)]
            [DataMember]
            public ContainedInstanceComponent Request
            {
                get { return _request; }
                set { _request = value; OnPropertyChanged("Request"); }
            }

            private ContainedInstanceComponent _request;

            /// <summary>
            /// Each resource instance used by the responder
            /// </summary>
            [FhirElement("response", Order=130)]
            [DataMember]
            public ContainedInstanceComponent Response
            {
                get { return _response; }
                set { _response = value; OnPropertyChanged("Response"); }
            }

            private ContainedInstanceComponent _response;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NumberElement != null) dest.NumberElement = (FhirString)NumberElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (FhirString)TypeElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (InitiatorElement != null) dest.InitiatorElement = (FhirString)InitiatorElement.DeepCopy();
                    if (ReceiverElement != null) dest.ReceiverElement = (FhirString)ReceiverElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                    if (InitiatorActiveElement != null) dest.InitiatorActiveElement = (FhirBoolean)InitiatorActiveElement.DeepCopy();
                    if (ReceiverActiveElement != null) dest.ReceiverActiveElement = (FhirBoolean)ReceiverActiveElement.DeepCopy();
                    if (Request != null) dest.Request = (ContainedInstanceComponent)Request.DeepCopy();
                    if (Response != null) dest.Response = (ContainedInstanceComponent)Response.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(InitiatorElement, otherT.InitiatorElement)) return false;
                if (!DeepComparable.Matches(ReceiverElement, otherT.ReceiverElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(InitiatorActiveElement, otherT.InitiatorActiveElement)) return false;
                if (!DeepComparable.Matches(ReceiverActiveElement, otherT.ReceiverActiveElement)) return false;
                if (!DeepComparable.Matches(Request, otherT.Request)) return false;
                if (!DeepComparable.Matches(Response, otherT.Response)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(InitiatorElement, otherT.InitiatorElement)) return false;
                if (!DeepComparable.IsExactly(ReceiverElement, otherT.ReceiverElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(InitiatorActiveElement, otherT.InitiatorActiveElement)) return false;
                if (!DeepComparable.IsExactly(ReceiverActiveElement, otherT.ReceiverActiveElement)) return false;
                if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
                if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NumberElement != null) yield return NumberElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (NameElement != null) yield return NameElement;
                    if (InitiatorElement != null) yield return InitiatorElement;
                    if (ReceiverElement != null) yield return ReceiverElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (InitiatorActiveElement != null) yield return InitiatorActiveElement;
                    if (ReceiverActiveElement != null) yield return ReceiverActiveElement;
                    if (Request != null) yield return Request;
                    if (Response != null) yield return Response;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NumberElement != null) yield return new ElementValue("number", NumberElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (InitiatorElement != null) yield return new ElementValue("initiator", InitiatorElement);
                    if (ReceiverElement != null) yield return new ElementValue("receiver", ReceiverElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (InitiatorActiveElement != null) yield return new ElementValue("initiatorActive", InitiatorActiveElement);
                    if (ReceiverActiveElement != null) yield return new ElementValue("receiverActive", ReceiverActiveElement);
                    if (Request != null) yield return new ElementValue("request", Request);
                    if (Response != null) yield return new ElementValue("response", Response);
                }
            }


        }


        [FhirType("AlternativeComponent")]
        [DataContract]
        public partial class AlternativeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AlternativeComponent"; } }

            /// <summary>
            /// The name of each alternative
            /// </summary>
            [FhirElement("name", Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// The name of each alternative
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
            /// Each of the possible options in an alternative
            /// </summary>
            [FhirElement("option", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<OptionComponent> Option
            {
                get { if (_option==null) _option = new List<OptionComponent>(); return _option; }
                set { _option = value; OnPropertyChanged("Option"); }
            }

            private List<OptionComponent> _option;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AlternativeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Option != null) dest.Option = new List<OptionComponent>(Option.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AlternativeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AlternativeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if ( !DeepComparable.Matches(Option, otherT.Option)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AlternativeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Option, otherT.Option)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Option) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Option) { if (elem != null) yield return new ElementValue("option", elem); }
                }
            }


        }


        [FhirType("OptionComponent")]
        [DataContract]
        public partial class OptionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OptionComponent"; } }

            /// <summary>
            /// A human-readable description of each option
            /// </summary>
            [FhirElement("description", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Markdown DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private Markdown _descriptionElement;

            /// <summary>
            /// A human-readable description of each option
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
                        DescriptionElement = new Markdown(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// What happens in each alternative option
            /// </summary>
            [FhirElement("step", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StepComponent> Step
            {
                get { if (_step==null) _step = new List<StepComponent>(); return _step; }
                set { _step = value; OnPropertyChanged("Step"); }
            }

            private List<StepComponent> _step;

            /// <summary>
            /// If there is a pause in the flow
            /// </summary>
            [FhirElement("pause", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirBoolean> PauseElement
            {
                get { if (_pauseElement==null) _pauseElement = new List<FhirBoolean>(); return _pauseElement; }
                set { _pauseElement = value; OnPropertyChanged("PauseElement"); }
            }

            private List<FhirBoolean> _pauseElement;

            /// <summary>
            /// If there is a pause in the flow
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<bool?> Pause
            {
                get { return PauseElement != null ? PauseElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PauseElement = null;
                    else
                        PauseElement = new List<FhirBoolean>(value.Select(elem=>new FhirBoolean(elem)));
                    OnPropertyChanged("Pause");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OptionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                    if (Step != null) dest.Step = new List<StepComponent>(Step.DeepCopy());
                    if (PauseElement != null) dest.PauseElement = new List<FhirBoolean>(PauseElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OptionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OptionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(Step, otherT.Step)) return false;
                if ( !DeepComparable.Matches(PauseElement, otherT.PauseElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OptionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Step, otherT.Step)) return false;
                if (!DeepComparable.IsExactly(PauseElement, otherT.PauseElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in Step) { if (elem != null) yield return elem; }
                    foreach (var elem in PauseElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in Step) { if (elem != null) yield return new ElementValue("step", elem); }
                    foreach (var elem in PauseElement) { if (elem != null) yield return new ElementValue("pause", elem); }
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this example scenario, represented as a URI (globally unique)
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
        /// Canonical identifier for this example scenario, represented as a URI (globally unique)
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
        /// Additional identifier for the example scenario
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
        /// Business version of the example scenario
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
        /// Business version of the example scenario
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
        /// Name for this example scenario (computer friendly)
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
        /// Name for this example scenario (computer friendly)
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
        [FhirElement("status", InSummary=true, Order=130)]
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
        [FhirElement("experimental", InSummary=true, Order=140)]
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
        [FhirElement("date", InSummary=true, Order=150)]
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
        [FhirElement("publisher", InSummary=true, Order=160)]
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
        [FhirElement("contact", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

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
        /// Intended jurisdiction for example scenario (if applicable)
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
        public Markdown CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private Markdown _copyrightElement;

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
                    CopyrightElement = new Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// The purpose of the example, e.g. to illustrate a scenario
        /// </summary>
        [FhirElement("purpose", Order=210)]
        [DataMember]
        public Markdown PurposeElement
        {
            get { return _purposeElement; }
            set { _purposeElement = value; OnPropertyChanged("PurposeElement"); }
        }

        private Markdown _purposeElement;

        /// <summary>
        /// The purpose of the example, e.g. to illustrate a scenario
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Value : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new Markdown(value);
                OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        /// Actor participating in the resource
        /// </summary>
        [FhirElement("actor", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ActorComponent> Actor
        {
            get { if (_actor==null) _actor = new List<ActorComponent>(); return _actor; }
            set { _actor = value; OnPropertyChanged("Actor"); }
        }

        private List<ActorComponent> _actor;

        /// <summary>
        /// Each resource and each version that is present in the workflow
        /// </summary>
        [FhirElement("instance", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InstanceComponent> Instance
        {
            get { if (_instance==null) _instance = new List<InstanceComponent>(); return _instance; }
            set { _instance = value; OnPropertyChanged("Instance"); }
        }

        private List<InstanceComponent> _instance;

        /// <summary>
        /// Each major process - a group of operations
        /// </summary>
        [FhirElement("process", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProcessComponent> Process
        {
            get { if (_process==null) _process = new List<ProcessComponent>(); return _process; }
            set { _process = value; OnPropertyChanged("Process"); }
        }

        private List<ProcessComponent> _process;

        /// <summary>
        /// Another nested workflow
        /// </summary>
        [FhirElement("workflow", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> WorkflowElement
        {
            get { if (_workflowElement==null) _workflowElement = new List<Canonical>(); return _workflowElement; }
            set { _workflowElement = value; OnPropertyChanged("WorkflowElement"); }
        }

        private List<Canonical> _workflowElement;

        /// <summary>
        /// Another nested workflow
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Workflow
        {
            get { return WorkflowElement != null ? WorkflowElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    WorkflowElement = null;
                else
                    WorkflowElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Workflow");
            }
        }


        public static ElementDefinition.ConstraintComponent ExampleScenario_ESC_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "esc-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ExampleScenario_ESC_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ExampleScenario;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (CopyrightElement != null) dest.CopyrightElement = (Markdown)CopyrightElement.DeepCopy();
                if (PurposeElement != null) dest.PurposeElement = (Markdown)PurposeElement.DeepCopy();
                if (Actor != null) dest.Actor = new List<ActorComponent>(Actor.DeepCopy());
                if (Instance != null) dest.Instance = new List<InstanceComponent>(Instance.DeepCopy());
                if (Process != null) dest.Process = new List<ProcessComponent>(Process.DeepCopy());
                if (WorkflowElement != null) dest.WorkflowElement = new List<Canonical>(WorkflowElement.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ExampleScenario());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ExampleScenario;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            if ( !DeepComparable.Matches(Instance, otherT.Instance)) return false;
            if ( !DeepComparable.Matches(Process, otherT.Process)) return false;
            if ( !DeepComparable.Matches(WorkflowElement, otherT.WorkflowElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ExampleScenario;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            if (!DeepComparable.IsExactly(Instance, otherT.Instance)) return false;
            if (!DeepComparable.IsExactly(Process, otherT.Process)) return false;
            if (!DeepComparable.IsExactly(WorkflowElement, otherT.WorkflowElement)) return false;

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
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (CopyrightElement != null) yield return CopyrightElement;
                if (PurposeElement != null) yield return PurposeElement;
                foreach (var elem in Actor) { if (elem != null) yield return elem; }
                foreach (var elem in Instance) { if (elem != null) yield return elem; }
                foreach (var elem in Process) { if (elem != null) yield return elem; }
                foreach (var elem in WorkflowElement) { if (elem != null) yield return elem; }
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
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                foreach (var elem in Instance) { if (elem != null) yield return new ElementValue("instance", elem); }
                foreach (var elem in Process) { if (elem != null) yield return new ElementValue("process", elem); }
                foreach (var elem in WorkflowElement) { if (elem != null) yield return new ElementValue("workflow", elem); }
            }
        }

    }

}
