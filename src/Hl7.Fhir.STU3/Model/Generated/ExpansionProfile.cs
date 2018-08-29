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
    /// Defines behaviour and contraints on the ValueSet Expansion operation
    /// </summary>
    [FhirType("ExpansionProfile", IsResource=true)]
    [DataContract]
    public partial class ExpansionProfile : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ExpansionProfile; } }
        [NotMapped]
        public override string TypeName { get { return "ExpansionProfile"; } }


        [FhirType("FixedVersionComponent")]
        [DataContract]
        public partial class FixedVersionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FixedVersionComponent"; } }

            /// <summary>
            /// System to have its version fixed
            /// </summary>
            [FhirElement("system", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri SystemElement
            {
                get { return _systemElement; }
                set { _systemElement = value; OnPropertyChanged("SystemElement"); }
            }

            private FhirUri _systemElement;

            /// <summary>
            /// System to have its version fixed
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
                        SystemElement = new FhirUri(value);
                    OnPropertyChanged("System");
                }
            }

            /// <summary>
            /// Specific version of the code system referred to
            /// </summary>
            [FhirElement("version", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// Specific version of the code system referred to
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
            /// default | check | override
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<SystemVersionProcessingMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<SystemVersionProcessingMode> _modeElement;

            /// <summary>
            /// default | check | override
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SystemVersionProcessingMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<SystemVersionProcessingMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FixedVersionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SystemElement != null) dest.SystemElement = (FhirUri)SystemElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    if (ModeElement != null) dest.ModeElement = (Code<SystemVersionProcessingMode>)ModeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FixedVersionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FixedVersionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FixedVersionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SystemElement != null) yield return SystemElement;
                    if (VersionElement != null) yield return VersionElement;
                    if (ModeElement != null) yield return ModeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                }
            }


        }


        [FhirType("ExcludedSystemComponent")]
        [DataContract]
        public partial class ExcludedSystemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExcludedSystemComponent"; } }

            /// <summary>
            /// The specific code system to be excluded
            /// </summary>
            [FhirElement("system", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri SystemElement
            {
                get { return _systemElement; }
                set { _systemElement = value; OnPropertyChanged("SystemElement"); }
            }

            private FhirUri _systemElement;

            /// <summary>
            /// The specific code system to be excluded
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
                        SystemElement = new FhirUri(value);
                    OnPropertyChanged("System");
                }
            }

            /// <summary>
            /// Specific version of the code system referred to
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
            /// Specific version of the code system referred to
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
                var dest = other as ExcludedSystemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SystemElement != null) dest.SystemElement = (FhirUri)SystemElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExcludedSystemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExcludedSystemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExcludedSystemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SystemElement != null) yield return SystemElement;
                    if (VersionElement != null) yield return VersionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
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
            /// Designations to be included
            /// </summary>
            [FhirElement("include", InSummary=true, Order=40)]
            [DataMember]
            public DesignationIncludeComponent Include
            {
                get { return _include; }
                set { _include = value; OnPropertyChanged("Include"); }
            }

            private DesignationIncludeComponent _include;

            /// <summary>
            /// Designations to be excluded
            /// </summary>
            [FhirElement("exclude", InSummary=true, Order=50)]
            [DataMember]
            public DesignationExcludeComponent Exclude
            {
                get { return _exclude; }
                set { _exclude = value; OnPropertyChanged("Exclude"); }
            }

            private DesignationExcludeComponent _exclude;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Include != null) dest.Include = (DesignationIncludeComponent)Include.DeepCopy();
                    if (Exclude != null) dest.Exclude = (DesignationExcludeComponent)Exclude.DeepCopy();
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
                if (!DeepComparable.Matches(Include, otherT.Include)) return false;
                if (!DeepComparable.Matches(Exclude, otherT.Exclude)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Include, otherT.Include)) return false;
                if (!DeepComparable.IsExactly(Exclude, otherT.Exclude)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Include != null) yield return Include;
                    if (Exclude != null) yield return Exclude;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Include != null) yield return new ElementValue("include", Include);
                    if (Exclude != null) yield return new ElementValue("exclude", Exclude);
                }
            }


        }


        [FhirType("DesignationIncludeComponent")]
        [DataContract]
        public partial class DesignationIncludeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationIncludeComponent"; } }

            /// <summary>
            /// The designation to be included
            /// </summary>
            [FhirElement("designation", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DesignationIncludeDesignationComponent> Designation
            {
                get { if (_designation==null) _designation = new List<DesignationIncludeDesignationComponent>(); return _designation; }
                set { _designation = value; OnPropertyChanged("Designation"); }
            }

            private List<DesignationIncludeDesignationComponent> _designation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationIncludeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Designation != null) dest.Designation = new List<DesignationIncludeDesignationComponent>(Designation.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DesignationIncludeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DesignationIncludeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Designation, otherT.Designation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationIncludeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Designation, otherT.Designation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Designation) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Designation) { if (elem != null) yield return new ElementValue("designation", elem); }
                }
            }


        }


        [FhirType("DesignationIncludeDesignationComponent")]
        [DataContract]
        public partial class DesignationIncludeDesignationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationIncludeDesignationComponent"; } }

            /// <summary>
            /// Human language of the designation to be included
            /// </summary>
            [FhirElement("language", InSummary=true, Order=40)]
            [DataMember]
            public Code LanguageElement
            {
                get { return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private Code _languageElement;

            /// <summary>
            /// Human language of the designation to be included
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
            /// What kind of Designation to include
            /// </summary>
            [FhirElement("use", InSummary=true, Order=50)]
            [DataMember]
            public Coding Use
            {
                get { return _use; }
                set { _use = value; OnPropertyChanged("Use"); }
            }

            private Coding _use;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationIncludeDesignationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LanguageElement != null) dest.LanguageElement = (Code)LanguageElement.DeepCopy();
                    if (Use != null) dest.Use = (Coding)Use.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DesignationIncludeDesignationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DesignationIncludeDesignationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.Matches(Use, otherT.Use)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationIncludeDesignationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(Use, otherT.Use)) return false;

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
                }
            }


        }


        [FhirType("DesignationExcludeComponent")]
        [DataContract]
        public partial class DesignationExcludeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationExcludeComponent"; } }

            /// <summary>
            /// The designation to be excluded
            /// </summary>
            [FhirElement("designation", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DesignationExcludeDesignationComponent> Designation
            {
                get { if (_designation==null) _designation = new List<DesignationExcludeDesignationComponent>(); return _designation; }
                set { _designation = value; OnPropertyChanged("Designation"); }
            }

            private List<DesignationExcludeDesignationComponent> _designation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationExcludeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Designation != null) dest.Designation = new List<DesignationExcludeDesignationComponent>(Designation.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DesignationExcludeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DesignationExcludeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Designation, otherT.Designation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationExcludeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Designation, otherT.Designation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Designation) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Designation) { if (elem != null) yield return new ElementValue("designation", elem); }
                }
            }


        }


        [FhirType("DesignationExcludeDesignationComponent")]
        [DataContract]
        public partial class DesignationExcludeDesignationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationExcludeDesignationComponent"; } }

            /// <summary>
            /// Human language of the designation to be excluded
            /// </summary>
            [FhirElement("language", InSummary=true, Order=40)]
            [DataMember]
            public Code LanguageElement
            {
                get { return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private Code _languageElement;

            /// <summary>
            /// Human language of the designation to be excluded
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
            /// What kind of Designation to exclude
            /// </summary>
            [FhirElement("use", InSummary=true, Order=50)]
            [DataMember]
            public Coding Use
            {
                get { return _use; }
                set { _use = value; OnPropertyChanged("Use"); }
            }

            private Coding _use;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationExcludeDesignationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LanguageElement != null) dest.LanguageElement = (Code)LanguageElement.DeepCopy();
                    if (Use != null) dest.Use = (Coding)Use.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DesignationExcludeDesignationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DesignationExcludeDesignationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.Matches(Use, otherT.Use)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationExcludeDesignationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(Use, otherT.Use)) return false;

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
                }
            }


        }


        /// <summary>
        /// Logical URI to reference this expansion profile (globally unique)
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
        /// Logical URI to reference this expansion profile (globally unique)
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
        /// Additional identifier for the expansion profile
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
        /// Business version of the expansion profile
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
        /// Business version of the expansion profile
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
        /// Name for this expansion profile (computer friendly)
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
        /// Name for this expansion profile (computer friendly)
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
        /// Date this was last changed
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
        /// Natural language description of the expansion profile
        /// </summary>
        [FhirElement("description", Order=180)]
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
        [FhirElement("useContext", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for expansion profile (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Fix use of a code system to a particular version
        /// </summary>
        [FhirElement("fixedVersion", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FixedVersionComponent> FixedVersion
        {
            get { if (_fixedVersion==null) _fixedVersion = new List<FixedVersionComponent>(); return _fixedVersion; }
            set { _fixedVersion = value; OnPropertyChanged("FixedVersion"); }
        }

        private List<FixedVersionComponent> _fixedVersion;

        /// <summary>
        /// Systems/Versions to be exclude
        /// </summary>
        [FhirElement("excludedSystem", InSummary=true, Order=220)]
        [DataMember]
        public ExcludedSystemComponent ExcludedSystem
        {
            get { return _excludedSystem; }
            set { _excludedSystem = value; OnPropertyChanged("ExcludedSystem"); }
        }

        private ExcludedSystemComponent _excludedSystem;

        /// <summary>
        /// Whether the expansion should include concept designations
        /// </summary>
        [FhirElement("includeDesignations", InSummary=true, Order=230)]
        [DataMember]
        public FhirBoolean IncludeDesignationsElement
        {
            get { return _includeDesignationsElement; }
            set { _includeDesignationsElement = value; OnPropertyChanged("IncludeDesignationsElement"); }
        }

        private FhirBoolean _includeDesignationsElement;

        /// <summary>
        /// Whether the expansion should include concept designations
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IncludeDesignations
        {
            get { return IncludeDesignationsElement != null ? IncludeDesignationsElement.Value : null; }
            set
            {
                if (value == null)
                    IncludeDesignationsElement = null;
                else
                    IncludeDesignationsElement = new FhirBoolean(value);
                OnPropertyChanged("IncludeDesignations");
            }
        }

        /// <summary>
        /// When the expansion profile imposes designation contraints
        /// </summary>
        [FhirElement("designation", InSummary=true, Order=240)]
        [DataMember]
        public DesignationComponent Designation
        {
            get { return _designation; }
            set { _designation = value; OnPropertyChanged("Designation"); }
        }

        private DesignationComponent _designation;

        /// <summary>
        /// Include or exclude the value set definition in the expansion
        /// </summary>
        [FhirElement("includeDefinition", InSummary=true, Order=250)]
        [DataMember]
        public FhirBoolean IncludeDefinitionElement
        {
            get { return _includeDefinitionElement; }
            set { _includeDefinitionElement = value; OnPropertyChanged("IncludeDefinitionElement"); }
        }

        private FhirBoolean _includeDefinitionElement;

        /// <summary>
        /// Include or exclude the value set definition in the expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IncludeDefinition
        {
            get { return IncludeDefinitionElement != null ? IncludeDefinitionElement.Value : null; }
            set
            {
                if (value == null)
                    IncludeDefinitionElement = null;
                else
                    IncludeDefinitionElement = new FhirBoolean(value);
                OnPropertyChanged("IncludeDefinition");
            }
        }

        /// <summary>
        /// Include or exclude inactive concepts in the expansion
        /// </summary>
        [FhirElement("activeOnly", InSummary=true, Order=260)]
        [DataMember]
        public FhirBoolean ActiveOnlyElement
        {
            get { return _activeOnlyElement; }
            set { _activeOnlyElement = value; OnPropertyChanged("ActiveOnlyElement"); }
        }

        private FhirBoolean _activeOnlyElement;

        /// <summary>
        /// Include or exclude inactive concepts in the expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? ActiveOnly
        {
            get { return ActiveOnlyElement != null ? ActiveOnlyElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveOnlyElement = null;
                else
                    ActiveOnlyElement = new FhirBoolean(value);
                OnPropertyChanged("ActiveOnly");
            }
        }

        /// <summary>
        /// Nested codes in the expansion or not
        /// </summary>
        [FhirElement("excludeNested", InSummary=true, Order=270)]
        [DataMember]
        public FhirBoolean ExcludeNestedElement
        {
            get { return _excludeNestedElement; }
            set { _excludeNestedElement = value; OnPropertyChanged("ExcludeNestedElement"); }
        }

        private FhirBoolean _excludeNestedElement;

        /// <summary>
        /// Nested codes in the expansion or not
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? ExcludeNested
        {
            get { return ExcludeNestedElement != null ? ExcludeNestedElement.Value : null; }
            set
            {
                if (value == null)
                    ExcludeNestedElement = null;
                else
                    ExcludeNestedElement = new FhirBoolean(value);
                OnPropertyChanged("ExcludeNested");
            }
        }

        /// <summary>
        /// Include or exclude codes which cannot be rendered in user interfaces in the value set expansion
        /// </summary>
        [FhirElement("excludeNotForUI", InSummary=true, Order=280)]
        [DataMember]
        public FhirBoolean ExcludeNotForUIElement
        {
            get { return _excludeNotForUIElement; }
            set { _excludeNotForUIElement = value; OnPropertyChanged("ExcludeNotForUIElement"); }
        }

        private FhirBoolean _excludeNotForUIElement;

        /// <summary>
        /// Include or exclude codes which cannot be rendered in user interfaces in the value set expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? ExcludeNotForUI
        {
            get { return ExcludeNotForUIElement != null ? ExcludeNotForUIElement.Value : null; }
            set
            {
                if (value == null)
                    ExcludeNotForUIElement = null;
                else
                    ExcludeNotForUIElement = new FhirBoolean(value);
                OnPropertyChanged("ExcludeNotForUI");
            }
        }

        /// <summary>
        /// Include or exclude codes which are post coordinated expressions in the value set expansion
        /// </summary>
        [FhirElement("excludePostCoordinated", InSummary=true, Order=290)]
        [DataMember]
        public FhirBoolean ExcludePostCoordinatedElement
        {
            get { return _excludePostCoordinatedElement; }
            set { _excludePostCoordinatedElement = value; OnPropertyChanged("ExcludePostCoordinatedElement"); }
        }

        private FhirBoolean _excludePostCoordinatedElement;

        /// <summary>
        /// Include or exclude codes which are post coordinated expressions in the value set expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? ExcludePostCoordinated
        {
            get { return ExcludePostCoordinatedElement != null ? ExcludePostCoordinatedElement.Value : null; }
            set
            {
                if (value == null)
                    ExcludePostCoordinatedElement = null;
                else
                    ExcludePostCoordinatedElement = new FhirBoolean(value);
                OnPropertyChanged("ExcludePostCoordinated");
            }
        }

        /// <summary>
        /// Specify the language for the display element of codes in the value set expansion
        /// </summary>
        [FhirElement("displayLanguage", InSummary=true, Order=300)]
        [DataMember]
        public Code DisplayLanguageElement
        {
            get { return _displayLanguageElement; }
            set { _displayLanguageElement = value; OnPropertyChanged("DisplayLanguageElement"); }
        }

        private Code _displayLanguageElement;

        /// <summary>
        /// Specify the language for the display element of codes in the value set expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DisplayLanguage
        {
            get { return DisplayLanguageElement != null ? DisplayLanguageElement.Value : null; }
            set
            {
                if (value == null)
                    DisplayLanguageElement = null;
                else
                    DisplayLanguageElement = new Code(value);
                OnPropertyChanged("DisplayLanguage");
            }
        }

        /// <summary>
        /// Controls behaviour of the value set expand operation when value sets are too large to be completely expanded
        /// </summary>
        [FhirElement("limitedExpansion", InSummary=true, Order=310)]
        [DataMember]
        public FhirBoolean LimitedExpansionElement
        {
            get { return _limitedExpansionElement; }
            set { _limitedExpansionElement = value; OnPropertyChanged("LimitedExpansionElement"); }
        }

        private FhirBoolean _limitedExpansionElement;

        /// <summary>
        /// Controls behaviour of the value set expand operation when value sets are too large to be completely expanded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? LimitedExpansion
        {
            get { return LimitedExpansionElement != null ? LimitedExpansionElement.Value : null; }
            set
            {
                if (value == null)
                    LimitedExpansionElement = null;
                else
                    LimitedExpansionElement = new FhirBoolean(value);
                OnPropertyChanged("LimitedExpansion");
            }
        }


        public static ElementDefinition.ConstraintComponent ExpansionProfile_EXP_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "designation.include.designation.all(language.exists() or use.exists())",
            Key = "exp-3",
            Severity = ConstraintSeverity.Warning,
            Human = "SHALL have at least one of language or use",
            Xpath = "exists(f:language) or exists(f:use)"
        };

        public static ElementDefinition.ConstraintComponent ExpansionProfile_EXP_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "designation.exclude.designation.all(language.exists() or use.exists())",
            Key = "exp-4",
            Severity = ConstraintSeverity.Warning,
            Human = "SHALL have at least one of language or use",
            Xpath = "exists(f:language) or exists(f:use)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ExpansionProfile_EXP_3);
            InvariantConstraints.Add(ExpansionProfile_EXP_4);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ExpansionProfile;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
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
                if (FixedVersion != null) dest.FixedVersion = new List<FixedVersionComponent>(FixedVersion.DeepCopy());
                if (ExcludedSystem != null) dest.ExcludedSystem = (ExcludedSystemComponent)ExcludedSystem.DeepCopy();
                if (IncludeDesignationsElement != null) dest.IncludeDesignationsElement = (FhirBoolean)IncludeDesignationsElement.DeepCopy();
                if (Designation != null) dest.Designation = (DesignationComponent)Designation.DeepCopy();
                if (IncludeDefinitionElement != null) dest.IncludeDefinitionElement = (FhirBoolean)IncludeDefinitionElement.DeepCopy();
                if (ActiveOnlyElement != null) dest.ActiveOnlyElement = (FhirBoolean)ActiveOnlyElement.DeepCopy();
                if (ExcludeNestedElement != null) dest.ExcludeNestedElement = (FhirBoolean)ExcludeNestedElement.DeepCopy();
                if (ExcludeNotForUIElement != null) dest.ExcludeNotForUIElement = (FhirBoolean)ExcludeNotForUIElement.DeepCopy();
                if (ExcludePostCoordinatedElement != null) dest.ExcludePostCoordinatedElement = (FhirBoolean)ExcludePostCoordinatedElement.DeepCopy();
                if (DisplayLanguageElement != null) dest.DisplayLanguageElement = (Code)DisplayLanguageElement.DeepCopy();
                if (LimitedExpansionElement != null) dest.LimitedExpansionElement = (FhirBoolean)LimitedExpansionElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ExpansionProfile());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ExpansionProfile;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
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
            if ( !DeepComparable.Matches(FixedVersion, otherT.FixedVersion)) return false;
            if (!DeepComparable.Matches(ExcludedSystem, otherT.ExcludedSystem)) return false;
            if (!DeepComparable.Matches(IncludeDesignationsElement, otherT.IncludeDesignationsElement)) return false;
            if (!DeepComparable.Matches(Designation, otherT.Designation)) return false;
            if (!DeepComparable.Matches(IncludeDefinitionElement, otherT.IncludeDefinitionElement)) return false;
            if (!DeepComparable.Matches(ActiveOnlyElement, otherT.ActiveOnlyElement)) return false;
            if (!DeepComparable.Matches(ExcludeNestedElement, otherT.ExcludeNestedElement)) return false;
            if (!DeepComparable.Matches(ExcludeNotForUIElement, otherT.ExcludeNotForUIElement)) return false;
            if (!DeepComparable.Matches(ExcludePostCoordinatedElement, otherT.ExcludePostCoordinatedElement)) return false;
            if (!DeepComparable.Matches(DisplayLanguageElement, otherT.DisplayLanguageElement)) return false;
            if (!DeepComparable.Matches(LimitedExpansionElement, otherT.LimitedExpansionElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ExpansionProfile;
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
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(FixedVersion, otherT.FixedVersion)) return false;
            if (!DeepComparable.IsExactly(ExcludedSystem, otherT.ExcludedSystem)) return false;
            if (!DeepComparable.IsExactly(IncludeDesignationsElement, otherT.IncludeDesignationsElement)) return false;
            if (!DeepComparable.IsExactly(Designation, otherT.Designation)) return false;
            if (!DeepComparable.IsExactly(IncludeDefinitionElement, otherT.IncludeDefinitionElement)) return false;
            if (!DeepComparable.IsExactly(ActiveOnlyElement, otherT.ActiveOnlyElement)) return false;
            if (!DeepComparable.IsExactly(ExcludeNestedElement, otherT.ExcludeNestedElement)) return false;
            if (!DeepComparable.IsExactly(ExcludeNotForUIElement, otherT.ExcludeNotForUIElement)) return false;
            if (!DeepComparable.IsExactly(ExcludePostCoordinatedElement, otherT.ExcludePostCoordinatedElement)) return false;
            if (!DeepComparable.IsExactly(DisplayLanguageElement, otherT.DisplayLanguageElement)) return false;
            if (!DeepComparable.IsExactly(LimitedExpansionElement, otherT.LimitedExpansionElement)) return false;

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
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                foreach (var elem in FixedVersion) { if (elem != null) yield return elem; }
                if (ExcludedSystem != null) yield return ExcludedSystem;
                if (IncludeDesignationsElement != null) yield return IncludeDesignationsElement;
                if (Designation != null) yield return Designation;
                if (IncludeDefinitionElement != null) yield return IncludeDefinitionElement;
                if (ActiveOnlyElement != null) yield return ActiveOnlyElement;
                if (ExcludeNestedElement != null) yield return ExcludeNestedElement;
                if (ExcludeNotForUIElement != null) yield return ExcludeNotForUIElement;
                if (ExcludePostCoordinatedElement != null) yield return ExcludePostCoordinatedElement;
                if (DisplayLanguageElement != null) yield return DisplayLanguageElement;
                if (LimitedExpansionElement != null) yield return LimitedExpansionElement;
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
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                foreach (var elem in FixedVersion) { if (elem != null) yield return new ElementValue("fixedVersion", elem); }
                if (ExcludedSystem != null) yield return new ElementValue("excludedSystem", ExcludedSystem);
                if (IncludeDesignationsElement != null) yield return new ElementValue("includeDesignations", IncludeDesignationsElement);
                if (Designation != null) yield return new ElementValue("designation", Designation);
                if (IncludeDefinitionElement != null) yield return new ElementValue("includeDefinition", IncludeDefinitionElement);
                if (ActiveOnlyElement != null) yield return new ElementValue("activeOnly", ActiveOnlyElement);
                if (ExcludeNestedElement != null) yield return new ElementValue("excludeNested", ExcludeNestedElement);
                if (ExcludeNotForUIElement != null) yield return new ElementValue("excludeNotForUI", ExcludeNotForUIElement);
                if (ExcludePostCoordinatedElement != null) yield return new ElementValue("excludePostCoordinated", ExcludePostCoordinatedElement);
                if (DisplayLanguageElement != null) yield return new ElementValue("displayLanguage", DisplayLanguageElement);
                if (LimitedExpansionElement != null) yield return new ElementValue("limitedExpansion", LimitedExpansionElement);
            }
        }

    }

}
