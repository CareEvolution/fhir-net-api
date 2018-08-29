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
    /// A Map of relationships between 2 structures that can be used to transform data
    /// </summary>
    [FhirType("StructureMap", IsResource=true)]
    [DataContract]
    public partial class StructureMap : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.StructureMap; } }
        [NotMapped]
        public override string TypeName { get { return "StructureMap"; } }


        [FhirType("StructureComponent")]
        [DataContract]
        public partial class StructureComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StructureComponent"; } }

            /// <summary>
            /// Canonical URL for structure definition
            /// </summary>
            [FhirElement("url", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Canonical URL for structure definition
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
            /// source | queried | target | produced
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<StructureMapModelMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<StructureMapModelMode> _modeElement;

            /// <summary>
            /// source | queried | target | produced
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public StructureMapModelMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<StructureMapModelMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Name for type in this map
            /// </summary>
            [FhirElement("alias", InSummary=true, Order=60)]
            [DataMember]
            public FhirString AliasElement
            {
                get { return _aliasElement; }
                set { _aliasElement = value; OnPropertyChanged("AliasElement"); }
            }

            private FhirString _aliasElement;

            /// <summary>
            /// Name for type in this map
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Alias
            {
                get { return AliasElement != null ? AliasElement.Value : null; }
                set
                {
                    if (value == null)
                        AliasElement = null;
                    else
                        AliasElement = new FhirString(value);
                    OnPropertyChanged("Alias");
                }
            }

            /// <summary>
            /// Documentation on use of structure
            /// </summary>
            [FhirElement("documentation", Order=70)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Documentation on use of structure
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StructureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (ModeElement != null) dest.ModeElement = (Code<StructureMapModelMode>)ModeElement.DeepCopy();
                    if (AliasElement != null) dest.AliasElement = (FhirString)AliasElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StructureComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StructureComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(AliasElement, otherT.AliasElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(AliasElement, otherT.AliasElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UrlElement != null) yield return UrlElement;
                    if (ModeElement != null) yield return ModeElement;
                    if (AliasElement != null) yield return AliasElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (AliasElement != null) yield return new ElementValue("alias", AliasElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GroupComponent"; } }

            /// <summary>
            /// Human-readable label
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private Id _nameElement;

            /// <summary>
            /// Human-readable label
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
                        NameElement = new Id(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Another group that this group adds rules to
            /// </summary>
            [FhirElement("extends", InSummary=true, Order=50)]
            [DataMember]
            public Id ExtendsElement
            {
                get { return _extendsElement; }
                set { _extendsElement = value; OnPropertyChanged("ExtendsElement"); }
            }

            private Id _extendsElement;

            /// <summary>
            /// Another group that this group adds rules to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Extends
            {
                get { return ExtendsElement != null ? ExtendsElement.Value : null; }
                set
                {
                    if (value == null)
                        ExtendsElement = null;
                    else
                        ExtendsElement = new Id(value);
                    OnPropertyChanged("Extends");
                }
            }

            /// <summary>
            /// none | types | type-and-types
            /// </summary>
            [FhirElement("typeMode", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<StructureMapGroupTypeMode> TypeModeElement
            {
                get { return _typeModeElement; }
                set { _typeModeElement = value; OnPropertyChanged("TypeModeElement"); }
            }

            private Code<StructureMapGroupTypeMode> _typeModeElement;

            /// <summary>
            /// none | types | type-and-types
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public StructureMapGroupTypeMode? TypeMode
            {
                get { return TypeModeElement != null ? TypeModeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeModeElement = null;
                    else
                        TypeModeElement = new Code<StructureMapGroupTypeMode>(value);
                    OnPropertyChanged("TypeMode");
                }
            }

            /// <summary>
            /// Additional description/explaination for group
            /// </summary>
            [FhirElement("documentation", InSummary=true, Order=70)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Additional description/explaination for group
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// Named instance provided when invoking the map
            /// </summary>
            [FhirElement("input", InSummary=true, Order=80)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<InputComponent> Input
            {
                get { if (_input==null) _input = new List<InputComponent>(); return _input; }
                set { _input = value; OnPropertyChanged("Input"); }
            }

            private List<InputComponent> _input;

            /// <summary>
            /// Transform Rule from source to target
            /// </summary>
            [FhirElement("rule", InSummary=true, Order=90)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<RuleComponent> Rule
            {
                get { if (_rule==null) _rule = new List<RuleComponent>(); return _rule; }
                set { _rule = value; OnPropertyChanged("Rule"); }
            }

            private List<RuleComponent> _rule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GroupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Id)NameElement.DeepCopy();
                    if (ExtendsElement != null) dest.ExtendsElement = (Id)ExtendsElement.DeepCopy();
                    if (TypeModeElement != null) dest.TypeModeElement = (Code<StructureMapGroupTypeMode>)TypeModeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (Input != null) dest.Input = new List<InputComponent>(Input.DeepCopy());
                    if (Rule != null) dest.Rule = new List<RuleComponent>(Rule.DeepCopy());
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
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(ExtendsElement, otherT.ExtendsElement)) return false;
                if (!DeepComparable.Matches(TypeModeElement, otherT.TypeModeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if ( !DeepComparable.Matches(Input, otherT.Input)) return false;
                if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(ExtendsElement, otherT.ExtendsElement)) return false;
                if (!DeepComparable.IsExactly(TypeModeElement, otherT.TypeModeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(Input, otherT.Input)) return false;
                if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (ExtendsElement != null) yield return ExtendsElement;
                    if (TypeModeElement != null) yield return TypeModeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    foreach (var elem in Input) { if (elem != null) yield return elem; }
                    foreach (var elem in Rule) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (ExtendsElement != null) yield return new ElementValue("extends", ExtendsElement);
                    if (TypeModeElement != null) yield return new ElementValue("typeMode", TypeModeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    foreach (var elem in Input) { if (elem != null) yield return new ElementValue("input", elem); }
                    foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
                }
            }


        }


        [FhirType("InputComponent")]
        [DataContract]
        public partial class InputComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InputComponent"; } }

            /// <summary>
            /// Name for this instance of data
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private Id _nameElement;

            /// <summary>
            /// Name for this instance of data
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
                        NameElement = new Id(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Type for this instance of data
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public FhirString TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private FhirString _typeElement;

            /// <summary>
            /// Type for this instance of data
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
            /// source | target
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<StructureMapInputMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<StructureMapInputMode> _modeElement;

            /// <summary>
            /// source | target
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public StructureMapInputMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<StructureMapInputMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Documentation for this instance of data
            /// </summary>
            [FhirElement("documentation", Order=70)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Documentation for this instance of data
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InputComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Id)NameElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (FhirString)TypeElement.DeepCopy();
                    if (ModeElement != null) dest.ModeElement = (Code<StructureMapInputMode>)ModeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InputComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InputComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InputComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (ModeElement != null) yield return ModeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("RuleComponent")]
        [DataContract]
        public partial class RuleComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RuleComponent"; } }

            /// <summary>
            /// Name of the rule for internal references
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private Id _nameElement;

            /// <summary>
            /// Name of the rule for internal references
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
                        NameElement = new Id(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Source inputs to the mapping
            /// </summary>
            [FhirElement("source", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<SourceComponent> Source
            {
                get { if (_source==null) _source = new List<SourceComponent>(); return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private List<SourceComponent> _source;

            /// <summary>
            /// Content to create because of this mapping rule
            /// </summary>
            [FhirElement("target", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TargetComponent> Target
            {
                get { if (_target==null) _target = new List<TargetComponent>(); return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private List<TargetComponent> _target;

            /// <summary>
            /// Rules contained in this rule
            /// </summary>
            [FhirElement("rule", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RuleComponent> Rule
            {
                get { if (_rule==null) _rule = new List<RuleComponent>(); return _rule; }
                set { _rule = value; OnPropertyChanged("Rule"); }
            }

            private List<RuleComponent> _rule;

            /// <summary>
            /// Which other rules to apply in the context of this rule
            /// </summary>
            [FhirElement("dependent", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DependentComponent> Dependent
            {
                get { if (_dependent==null) _dependent = new List<DependentComponent>(); return _dependent; }
                set { _dependent = value; OnPropertyChanged("Dependent"); }
            }

            private List<DependentComponent> _dependent;

            /// <summary>
            /// Documentation for this instance of data
            /// </summary>
            [FhirElement("documentation", Order=90)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Documentation for this instance of data
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RuleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Id)NameElement.DeepCopy();
                    if (Source != null) dest.Source = new List<SourceComponent>(Source.DeepCopy());
                    if (Target != null) dest.Target = new List<TargetComponent>(Target.DeepCopy());
                    if (Rule != null) dest.Rule = new List<RuleComponent>(Rule.DeepCopy());
                    if (Dependent != null) dest.Dependent = new List<DependentComponent>(Dependent.DeepCopy());
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RuleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RuleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if ( !DeepComparable.Matches(Source, otherT.Source)) return false;
                if ( !DeepComparable.Matches(Target, otherT.Target)) return false;
                if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
                if ( !DeepComparable.Matches(Dependent, otherT.Dependent)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RuleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
                if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
                if (!DeepComparable.IsExactly(Dependent, otherT.Dependent)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                    foreach (var elem in Target) { if (elem != null) yield return elem; }
                    foreach (var elem in Rule) { if (elem != null) yield return elem; }
                    foreach (var elem in Dependent) { if (elem != null) yield return elem; }
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                    foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
                    foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
                    foreach (var elem in Dependent) { if (elem != null) yield return new ElementValue("dependent", elem); }
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("SourceComponent")]
        [DataContract]
        public partial class SourceComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SourceComponent"; } }

            /// <summary>
            /// Type or variable this rule applies to
            /// </summary>
            [FhirElement("context", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id ContextElement
            {
                get { return _contextElement; }
                set { _contextElement = value; OnPropertyChanged("ContextElement"); }
            }

            private Id _contextElement;

            /// <summary>
            /// Type or variable this rule applies to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Context
            {
                get { return ContextElement != null ? ContextElement.Value : null; }
                set
                {
                    if (value == null)
                        ContextElement = null;
                    else
                        ContextElement = new Id(value);
                    OnPropertyChanged("Context");
                }
            }

            /// <summary>
            /// Specified minimum cardinality
            /// </summary>
            [FhirElement("min", InSummary=true, Order=50)]
            [DataMember]
            public Integer MinElement
            {
                get { return _minElement; }
                set { _minElement = value; OnPropertyChanged("MinElement"); }
            }

            private Integer _minElement;

            /// <summary>
            /// Specified minimum cardinality
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
                        MinElement = new Integer(value);
                    OnPropertyChanged("Min");
                }
            }

            /// <summary>
            /// Specified maximum cardinality (number or *)
            /// </summary>
            [FhirElement("max", InSummary=true, Order=60)]
            [DataMember]
            public FhirString MaxElement
            {
                get { return _maxElement; }
                set { _maxElement = value; OnPropertyChanged("MaxElement"); }
            }

            private FhirString _maxElement;

            /// <summary>
            /// Specified maximum cardinality (number or *)
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
            /// Rule only applies if source has this type
            /// </summary>
            [FhirElement("type", InSummary=true, Order=70)]
            [DataMember]
            public FhirString TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private FhirString _typeElement;

            /// <summary>
            /// Rule only applies if source has this type
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
            /// Default value if no value exists
            /// </summary>
            [FhirElement("defaultValue", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(Meta))]
            [DataMember]
            public Element DefaultValue
            {
                get { return _defaultValue; }
                set { _defaultValue = value; OnPropertyChanged("DefaultValue"); }
            }

            private Element _defaultValue;

            /// <summary>
            /// Optional field for this source
            /// </summary>
            [FhirElement("element", InSummary=true, Order=90)]
            [DataMember]
            public FhirString ElementElement
            {
                get { return _elementElement; }
                set { _elementElement = value; OnPropertyChanged("ElementElement"); }
            }

            private FhirString _elementElement;

            /// <summary>
            /// Optional field for this source
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
                        ElementElement = new FhirString(value);
                    OnPropertyChanged("Element");
                }
            }

            /// <summary>
            /// first | not_first | last | not_last | only_one
            /// </summary>
            [FhirElement("listMode", InSummary=true, Order=100)]
            [DataMember]
            public Code<StructureMapSourceListMode> ListModeElement
            {
                get { return _listModeElement; }
                set { _listModeElement = value; OnPropertyChanged("ListModeElement"); }
            }

            private Code<StructureMapSourceListMode> _listModeElement;

            /// <summary>
            /// first | not_first | last | not_last | only_one
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public StructureMapSourceListMode? ListMode
            {
                get { return ListModeElement != null ? ListModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ListModeElement = null;
                    else
                        ListModeElement = new Code<StructureMapSourceListMode>(value);
                    OnPropertyChanged("ListMode");
                }
            }

            /// <summary>
            /// Named context for field, if a field is specified
            /// </summary>
            [FhirElement("variable", InSummary=true, Order=110)]
            [DataMember]
            public Id VariableElement
            {
                get { return _variableElement; }
                set { _variableElement = value; OnPropertyChanged("VariableElement"); }
            }

            private Id _variableElement;

            /// <summary>
            /// Named context for field, if a field is specified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Variable
            {
                get { return VariableElement != null ? VariableElement.Value : null; }
                set
                {
                    if (value == null)
                        VariableElement = null;
                    else
                        VariableElement = new Id(value);
                    OnPropertyChanged("Variable");
                }
            }

            /// <summary>
            /// FHIRPath expression  - must be true or the rule does not apply
            /// </summary>
            [FhirElement("condition", InSummary=true, Order=120)]
            [DataMember]
            public FhirString ConditionElement
            {
                get { return _conditionElement; }
                set { _conditionElement = value; OnPropertyChanged("ConditionElement"); }
            }

            private FhirString _conditionElement;

            /// <summary>
            /// FHIRPath expression  - must be true or the rule does not apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Condition
            {
                get { return ConditionElement != null ? ConditionElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionElement = null;
                    else
                        ConditionElement = new FhirString(value);
                    OnPropertyChanged("Condition");
                }
            }

            /// <summary>
            /// FHIRPath expression  - must be true or the mapping engine throws an error instead of completing
            /// </summary>
            [FhirElement("check", InSummary=true, Order=130)]
            [DataMember]
            public FhirString CheckElement
            {
                get { return _checkElement; }
                set { _checkElement = value; OnPropertyChanged("CheckElement"); }
            }

            private FhirString _checkElement;

            /// <summary>
            /// FHIRPath expression  - must be true or the mapping engine throws an error instead of completing
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Check
            {
                get { return CheckElement != null ? CheckElement.Value : null; }
                set
                {
                    if (value == null)
                        CheckElement = null;
                    else
                        CheckElement = new FhirString(value);
                    OnPropertyChanged("Check");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ContextElement != null) dest.ContextElement = (Id)ContextElement.DeepCopy();
                    if (MinElement != null) dest.MinElement = (Integer)MinElement.DeepCopy();
                    if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (FhirString)TypeElement.DeepCopy();
                    if (DefaultValue != null) dest.DefaultValue = (Element)DefaultValue.DeepCopy();
                    if (ElementElement != null) dest.ElementElement = (FhirString)ElementElement.DeepCopy();
                    if (ListModeElement != null) dest.ListModeElement = (Code<StructureMapSourceListMode>)ListModeElement.DeepCopy();
                    if (VariableElement != null) dest.VariableElement = (Id)VariableElement.DeepCopy();
                    if (ConditionElement != null) dest.ConditionElement = (FhirString)ConditionElement.DeepCopy();
                    if (CheckElement != null) dest.CheckElement = (FhirString)CheckElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ContextElement, otherT.ContextElement)) return false;
                if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(DefaultValue, otherT.DefaultValue)) return false;
                if (!DeepComparable.Matches(ElementElement, otherT.ElementElement)) return false;
                if (!DeepComparable.Matches(ListModeElement, otherT.ListModeElement)) return false;
                if (!DeepComparable.Matches(VariableElement, otherT.VariableElement)) return false;
                if (!DeepComparable.Matches(ConditionElement, otherT.ConditionElement)) return false;
                if (!DeepComparable.Matches(CheckElement, otherT.CheckElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ContextElement, otherT.ContextElement)) return false;
                if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(DefaultValue, otherT.DefaultValue)) return false;
                if (!DeepComparable.IsExactly(ElementElement, otherT.ElementElement)) return false;
                if (!DeepComparable.IsExactly(ListModeElement, otherT.ListModeElement)) return false;
                if (!DeepComparable.IsExactly(VariableElement, otherT.VariableElement)) return false;
                if (!DeepComparable.IsExactly(ConditionElement, otherT.ConditionElement)) return false;
                if (!DeepComparable.IsExactly(CheckElement, otherT.CheckElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ContextElement != null) yield return ContextElement;
                    if (MinElement != null) yield return MinElement;
                    if (MaxElement != null) yield return MaxElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (DefaultValue != null) yield return DefaultValue;
                    if (ElementElement != null) yield return ElementElement;
                    if (ListModeElement != null) yield return ListModeElement;
                    if (VariableElement != null) yield return VariableElement;
                    if (ConditionElement != null) yield return ConditionElement;
                    if (CheckElement != null) yield return CheckElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ContextElement != null) yield return new ElementValue("context", ContextElement);
                    if (MinElement != null) yield return new ElementValue("min", MinElement);
                    if (MaxElement != null) yield return new ElementValue("max", MaxElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (DefaultValue != null) yield return new ElementValue("defaultValue", DefaultValue);
                    if (ElementElement != null) yield return new ElementValue("element", ElementElement);
                    if (ListModeElement != null) yield return new ElementValue("listMode", ListModeElement);
                    if (VariableElement != null) yield return new ElementValue("variable", VariableElement);
                    if (ConditionElement != null) yield return new ElementValue("condition", ConditionElement);
                    if (CheckElement != null) yield return new ElementValue("check", CheckElement);
                }
            }


        }


        [FhirType("TargetComponent")]
        [DataContract]
        public partial class TargetComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TargetComponent"; } }

            /// <summary>
            /// Type or variable this rule applies to
            /// </summary>
            [FhirElement("context", InSummary=true, Order=40)]
            [DataMember]
            public Id ContextElement
            {
                get { return _contextElement; }
                set { _contextElement = value; OnPropertyChanged("ContextElement"); }
            }

            private Id _contextElement;

            /// <summary>
            /// Type or variable this rule applies to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Context
            {
                get { return ContextElement != null ? ContextElement.Value : null; }
                set
                {
                    if (value == null)
                        ContextElement = null;
                    else
                        ContextElement = new Id(value);
                    OnPropertyChanged("Context");
                }
            }

            /// <summary>
            /// type | variable
            /// </summary>
            [FhirElement("contextType", InSummary=true, Order=50)]
            [DataMember]
            public Code<StructureMapContextType> ContextTypeElement
            {
                get { return _contextTypeElement; }
                set { _contextTypeElement = value; OnPropertyChanged("ContextTypeElement"); }
            }

            private Code<StructureMapContextType> _contextTypeElement;

            /// <summary>
            /// type | variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public StructureMapContextType? ContextType
            {
                get { return ContextTypeElement != null ? ContextTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        ContextTypeElement = null;
                    else
                        ContextTypeElement = new Code<StructureMapContextType>(value);
                    OnPropertyChanged("ContextType");
                }
            }

            /// <summary>
            /// Field to create in the context
            /// </summary>
            [FhirElement("element", InSummary=true, Order=60)]
            [DataMember]
            public FhirString ElementElement
            {
                get { return _elementElement; }
                set { _elementElement = value; OnPropertyChanged("ElementElement"); }
            }

            private FhirString _elementElement;

            /// <summary>
            /// Field to create in the context
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
                        ElementElement = new FhirString(value);
                    OnPropertyChanged("Element");
                }
            }

            /// <summary>
            /// Named context for field, if desired, and a field is specified
            /// </summary>
            [FhirElement("variable", InSummary=true, Order=70)]
            [DataMember]
            public Id VariableElement
            {
                get { return _variableElement; }
                set { _variableElement = value; OnPropertyChanged("VariableElement"); }
            }

            private Id _variableElement;

            /// <summary>
            /// Named context for field, if desired, and a field is specified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Variable
            {
                get { return VariableElement != null ? VariableElement.Value : null; }
                set
                {
                    if (value == null)
                        VariableElement = null;
                    else
                        VariableElement = new Id(value);
                    OnPropertyChanged("Variable");
                }
            }

            /// <summary>
            /// first | share | last | collate
            /// </summary>
            [FhirElement("listMode", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<StructureMapTargetListMode>> ListModeElement
            {
                get { if (_listModeElement==null) _listModeElement = new List<Code<StructureMapTargetListMode>>(); return _listModeElement; }
                set { _listModeElement = value; OnPropertyChanged("ListModeElement"); }
            }

            private List<Code<StructureMapTargetListMode>> _listModeElement;

            /// <summary>
            /// first | share | last | collate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<StructureMapTargetListMode?> ListMode
            {
                get { return ListModeElement != null ? ListModeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ListModeElement = null;
                    else
                        ListModeElement = new List<Code<StructureMapTargetListMode>>(value.Select(elem=>new Code<StructureMapTargetListMode>(elem)));
                    OnPropertyChanged("ListMode");
                }
            }

            /// <summary>
            /// Internal rule reference for shared list items
            /// </summary>
            [FhirElement("listRuleId", InSummary=true, Order=90)]
            [DataMember]
            public Id ListRuleIdElement
            {
                get { return _listRuleIdElement; }
                set { _listRuleIdElement = value; OnPropertyChanged("ListRuleIdElement"); }
            }

            private Id _listRuleIdElement;

            /// <summary>
            /// Internal rule reference for shared list items
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ListRuleId
            {
                get { return ListRuleIdElement != null ? ListRuleIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ListRuleIdElement = null;
                    else
                        ListRuleIdElement = new Id(value);
                    OnPropertyChanged("ListRuleId");
                }
            }

            /// <summary>
            /// create | copy +
            /// </summary>
            [FhirElement("transform", InSummary=true, Order=100)]
            [DataMember]
            public Code<StructureMapTransform> TransformElement
            {
                get { return _transformElement; }
                set { _transformElement = value; OnPropertyChanged("TransformElement"); }
            }

            private Code<StructureMapTransform> _transformElement;

            /// <summary>
            /// create | copy +
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public StructureMapTransform? Transform
            {
                get { return TransformElement != null ? TransformElement.Value : null; }
                set
                {
                    if (value == null)
                        TransformElement = null;
                    else
                        TransformElement = new Code<StructureMapTransform>(value);
                    OnPropertyChanged("Transform");
                }
            }

            /// <summary>
            /// Parameters to the transform
            /// </summary>
            [FhirElement("parameter", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Parameter
            {
                get { if (_parameter==null) _parameter = new List<ParameterComponent>(); return _parameter; }
                set { _parameter = value; OnPropertyChanged("Parameter"); }
            }

            private List<ParameterComponent> _parameter;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TargetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ContextElement != null) dest.ContextElement = (Id)ContextElement.DeepCopy();
                    if (ContextTypeElement != null) dest.ContextTypeElement = (Code<StructureMapContextType>)ContextTypeElement.DeepCopy();
                    if (ElementElement != null) dest.ElementElement = (FhirString)ElementElement.DeepCopy();
                    if (VariableElement != null) dest.VariableElement = (Id)VariableElement.DeepCopy();
                    if (ListModeElement != null) dest.ListModeElement = new List<Code<StructureMapTargetListMode>>(ListModeElement.DeepCopy());
                    if (ListRuleIdElement != null) dest.ListRuleIdElement = (Id)ListRuleIdElement.DeepCopy();
                    if (TransformElement != null) dest.TransformElement = (Code<StructureMapTransform>)TransformElement.DeepCopy();
                    if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TargetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ContextElement, otherT.ContextElement)) return false;
                if (!DeepComparable.Matches(ContextTypeElement, otherT.ContextTypeElement)) return false;
                if (!DeepComparable.Matches(ElementElement, otherT.ElementElement)) return false;
                if (!DeepComparable.Matches(VariableElement, otherT.VariableElement)) return false;
                if ( !DeepComparable.Matches(ListModeElement, otherT.ListModeElement)) return false;
                if (!DeepComparable.Matches(ListRuleIdElement, otherT.ListRuleIdElement)) return false;
                if (!DeepComparable.Matches(TransformElement, otherT.TransformElement)) return false;
                if ( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ContextElement, otherT.ContextElement)) return false;
                if (!DeepComparable.IsExactly(ContextTypeElement, otherT.ContextTypeElement)) return false;
                if (!DeepComparable.IsExactly(ElementElement, otherT.ElementElement)) return false;
                if (!DeepComparable.IsExactly(VariableElement, otherT.VariableElement)) return false;
                if (!DeepComparable.IsExactly(ListModeElement, otherT.ListModeElement)) return false;
                if (!DeepComparable.IsExactly(ListRuleIdElement, otherT.ListRuleIdElement)) return false;
                if (!DeepComparable.IsExactly(TransformElement, otherT.TransformElement)) return false;
                if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ContextElement != null) yield return ContextElement;
                    if (ContextTypeElement != null) yield return ContextTypeElement;
                    if (ElementElement != null) yield return ElementElement;
                    if (VariableElement != null) yield return VariableElement;
                    foreach (var elem in ListModeElement) { if (elem != null) yield return elem; }
                    if (ListRuleIdElement != null) yield return ListRuleIdElement;
                    if (TransformElement != null) yield return TransformElement;
                    foreach (var elem in Parameter) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ContextElement != null) yield return new ElementValue("context", ContextElement);
                    if (ContextTypeElement != null) yield return new ElementValue("contextType", ContextTypeElement);
                    if (ElementElement != null) yield return new ElementValue("element", ElementElement);
                    if (VariableElement != null) yield return new ElementValue("variable", VariableElement);
                    foreach (var elem in ListModeElement) { if (elem != null) yield return new ElementValue("listMode", elem); }
                    if (ListRuleIdElement != null) yield return new ElementValue("listRuleId", ListRuleIdElement);
                    if (TransformElement != null) yield return new ElementValue("transform", TransformElement);
                    foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
                }
            }


        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// Parameter value - variable or literal
            /// </summary>
            [FhirElement("value", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Id),typeof(FhirString),typeof(FhirBoolean),typeof(Integer),typeof(FhirDecimal))]
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
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
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
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        [FhirType("DependentComponent")]
        [DataContract]
        public partial class DependentComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DependentComponent"; } }

            /// <summary>
            /// Name of a rule or group to apply
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private Id _nameElement;

            /// <summary>
            /// Name of a rule or group to apply
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
                        NameElement = new Id(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Variable to pass to the rule or group
            /// </summary>
            [FhirElement("variable", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<FhirString> VariableElement
            {
                get { if (_variableElement==null) _variableElement = new List<FhirString>(); return _variableElement; }
                set { _variableElement = value; OnPropertyChanged("VariableElement"); }
            }

            private List<FhirString> _variableElement;

            /// <summary>
            /// Variable to pass to the rule or group
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Variable
            {
                get { return VariableElement != null ? VariableElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        VariableElement = null;
                    else
                        VariableElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Variable");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DependentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Id)NameElement.DeepCopy();
                    if (VariableElement != null) dest.VariableElement = new List<FhirString>(VariableElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DependentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DependentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if ( !DeepComparable.Matches(VariableElement, otherT.VariableElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DependentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(VariableElement, otherT.VariableElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in VariableElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in VariableElement) { if (elem != null) yield return new ElementValue("variable", elem); }
                }
            }


        }


        /// <summary>
        /// Logical URI to reference this structure map (globally unique)
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
        /// Logical URI to reference this structure map (globally unique)
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
        /// Additional identifier for the structure map
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
        /// Business version of the structure map
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
        /// Business version of the structure map
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
        /// Name for this structure map (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this structure map (computer friendly)
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
        /// Name for this structure map (human friendly)
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
        /// Name for this structure map (human friendly)
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
        /// Date this was last changed
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
        /// Natural language description of the structure map
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
        /// Context the content is intended to support
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
        /// Intended jurisdiction for structure map (if applicable)
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
        /// Why this structure map is defined
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
        /// Structure Definition used by this map
        /// </summary>
        [FhirElement("structure", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<StructureComponent> Structure
        {
            get { if (_structure==null) _structure = new List<StructureComponent>(); return _structure; }
            set { _structure = value; OnPropertyChanged("Structure"); }
        }

        private List<StructureComponent> _structure;

        /// <summary>
        /// Other maps used by this map (canonical URLs)
        /// </summary>
        [FhirElement("import", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> ImportElement
        {
            get { if (_importElement==null) _importElement = new List<FhirUri>(); return _importElement; }
            set { _importElement = value; OnPropertyChanged("ImportElement"); }
        }

        private List<FhirUri> _importElement;

        /// <summary>
        /// Other maps used by this map (canonical URLs)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Import
        {
            get { return ImportElement != null ? ImportElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ImportElement = null;
                else
                    ImportElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Import");
            }
        }

        /// <summary>
        /// Named sections for reader convenience
        /// </summary>
        [FhirElement("group", InSummary=true, Order=260)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<GroupComponent> Group
        {
            get { if (_group==null) _group = new List<GroupComponent>(); return _group; }
            set { _group = value; OnPropertyChanged("Group"); }
        }

        private List<GroupComponent> _group;


        public static ElementDefinition.ConstraintComponent StructureMap_SMP_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.rule.target.all(context.exists() implies contextType.exists())",
            Key = "smp-2",
            Severity = ConstraintSeverity.Warning,
            Human = "Must have a contextType if you have a context",
            Xpath = "not(f:context) or (f:contextType)"
        };

        public static ElementDefinition.ConstraintComponent StructureMap_SMP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.rule.target.all(element.exists() implies context.exists())",
            Key = "smp-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Can only have a element if you have a context",
            Xpath = "not(f:element) or (f:context)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(StructureMap_SMP_2);
            InvariantConstraints.Add(StructureMap_SMP_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as StructureMap;

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
                if (Structure != null) dest.Structure = new List<StructureComponent>(Structure.DeepCopy());
                if (ImportElement != null) dest.ImportElement = new List<FhirUri>(ImportElement.DeepCopy());
                if (Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new StructureMap());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as StructureMap;
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
            if ( !DeepComparable.Matches(Structure, otherT.Structure)) return false;
            if ( !DeepComparable.Matches(ImportElement, otherT.ImportElement)) return false;
            if ( !DeepComparable.Matches(Group, otherT.Group)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as StructureMap;
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
            if (!DeepComparable.IsExactly(Structure, otherT.Structure)) return false;
            if (!DeepComparable.IsExactly(ImportElement, otherT.ImportElement)) return false;
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
                foreach (var elem in Structure) { if (elem != null) yield return elem; }
                foreach (var elem in ImportElement) { if (elem != null) yield return elem; }
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
                foreach (var elem in Structure) { if (elem != null) yield return new ElementValue("structure", elem); }
                foreach (var elem in ImportElement) { if (elem != null) yield return new ElementValue("import", elem); }
                foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
            }
        }

    }

}
