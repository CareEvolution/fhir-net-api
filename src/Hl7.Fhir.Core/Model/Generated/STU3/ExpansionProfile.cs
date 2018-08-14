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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// Defines behaviour and contraints on the ValueSet Expansion operation
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.STU3, "ExpansionProfile", IsResource=true)]
    [DataContract]
    public partial class ExpansionProfile : Hl7.Fhir.Model.STU3.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ExpansionProfile; } }
        [NotMapped]
        public override string TypeName { get { return "ExpansionProfile"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "FixedVersionComponent")]
        [DataContract]
        public partial class FixedVersionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "FixedVersionComponent"; } }
            
            /// <summary>
            /// System to have its version fixed
            /// </summary>
            [FhirElement("system", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri SystemElement
            {
                get { return _SystemElement; }
                set { _SystemElement = value; OnPropertyChanged("SystemElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _SystemElement;
            
            /// <summary>
            /// System to have its version fixed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if (value == null)
                        SystemElement = null;
                    else
                        SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("System");
                }
            }
            
            /// <summary>
            /// Specific version of the code system referred to
            /// </summary>
            [FhirElement("version", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString VersionElement
            {
                get { return _VersionElement; }
                set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _VersionElement;
            
            /// <summary>
            /// Specific version of the code system referred to
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
            /// default | check | override
            /// </summary>
            [FhirElement("mode", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.STU3.SystemVersionProcessingMode> ModeElement
            {
                get { return _ModeElement; }
                set { _ModeElement = value; OnPropertyChanged("ModeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.STU3.SystemVersionProcessingMode> _ModeElement;
            
            /// <summary>
            /// default | check | override
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.STU3.SystemVersionProcessingMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<Hl7.Fhir.Model.STU3.SystemVersionProcessingMode>(value);
                    OnPropertyChanged("Mode");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FixedVersionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SystemElement != null) dest.SystemElement = (Hl7.Fhir.Model.FhirUri)SystemElement.DeepCopy();
                    if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                    if(ModeElement != null) dest.ModeElement = (Code<Hl7.Fhir.Model.STU3.SystemVersionProcessingMode>)ModeElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
                if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
                if( !DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FixedVersionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
                if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
                if( !DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
            
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
                    if (SystemElement != null) yield return new ElementValue("system", false, SystemElement);
                    if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                    if (ModeElement != null) yield return new ElementValue("mode", false, ModeElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ExcludedSystemComponent")]
        [DataContract]
        public partial class ExcludedSystemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ExcludedSystemComponent"; } }
            
            /// <summary>
            /// The specific code system to be excluded
            /// </summary>
            [FhirElement("system", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri SystemElement
            {
                get { return _SystemElement; }
                set { _SystemElement = value; OnPropertyChanged("SystemElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _SystemElement;
            
            /// <summary>
            /// The specific code system to be excluded
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if (value == null)
                        SystemElement = null;
                    else
                        SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("System");
                }
            }
            
            /// <summary>
            /// Specific version of the code system referred to
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
            /// Specific version of the code system referred to
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
                var dest = other as ExcludedSystemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SystemElement != null) dest.SystemElement = (Hl7.Fhir.Model.FhirUri)SystemElement.DeepCopy();
                    if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
                if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExcludedSystemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
                if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            
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
                    if (SystemElement != null) yield return new ElementValue("system", false, SystemElement);
                    if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "DesignationComponent")]
        [DataContract]
        public partial class DesignationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationComponent"; } }
            
            /// <summary>
            /// Designations to be included
            /// </summary>
            [FhirElement("include", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public DesignationIncludeComponent Include
            {
                get { return _Include; }
                set { _Include = value; OnPropertyChanged("Include"); }
            }
            
            private DesignationIncludeComponent _Include;
            
            /// <summary>
            /// Designations to be excluded
            /// </summary>
            [FhirElement("exclude", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public DesignationExcludeComponent Exclude
            {
                get { return _Exclude; }
                set { _Exclude = value; OnPropertyChanged("Exclude"); }
            }
            
            private DesignationExcludeComponent _Exclude;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Include != null) dest.Include = (DesignationIncludeComponent)Include.DeepCopy();
                    if(Exclude != null) dest.Exclude = (DesignationExcludeComponent)Exclude.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Include, otherT.Include)) return false;
                if( !DeepComparable.Matches(Exclude, otherT.Exclude)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Include, otherT.Include)) return false;
                if( !DeepComparable.IsExactly(Exclude, otherT.Exclude)) return false;
            
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
                    if (Include != null) yield return new ElementValue("include", false, Include);
                    if (Exclude != null) yield return new ElementValue("exclude", false, Exclude);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "DesignationIncludeComponent")]
        [DataContract]
        public partial class DesignationIncludeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationIncludeComponent"; } }
            
            /// <summary>
            /// The designation to be included
            /// </summary>
            [FhirElement("designation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DesignationIncludeDesignationComponent> Designation
            {
                get { if(_Designation==null) _Designation = new List<DesignationIncludeDesignationComponent>(); return _Designation; }
                set { _Designation = value; OnPropertyChanged("Designation"); }
            }
            
            private List<DesignationIncludeDesignationComponent> _Designation;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationIncludeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Designation != null) dest.Designation = new List<DesignationIncludeDesignationComponent>(Designation.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Designation, otherT.Designation)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationIncludeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Designation, otherT.Designation)) return false;
            
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
                    foreach (var elem in Designation) { if (elem != null) yield return new ElementValue("designation", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "DesignationIncludeDesignationComponent")]
        [DataContract]
        public partial class DesignationIncludeDesignationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationIncludeDesignationComponent"; } }
            
            /// <summary>
            /// Human language of the designation to be included
            /// </summary>
            [FhirElement("language", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Code LanguageElement
            {
                get { return _LanguageElement; }
                set { _LanguageElement = value; OnPropertyChanged("LanguageElement"); }
            }
            
            private Hl7.Fhir.Model.STU3.Code _LanguageElement;
            
            /// <summary>
            /// Human language of the designation to be included
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Language
            {
                get { return LanguageElement != null ? LanguageElement.Value : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new Hl7.Fhir.Model.STU3.Code(value);
                    OnPropertyChanged("Language");
                }
            }
            
            /// <summary>
            /// What kind of Designation to include
            /// </summary>
            [FhirElement("use", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Coding Use
            {
                get { return _Use; }
                set { _Use = value; OnPropertyChanged("Use"); }
            }
            
            private Hl7.Fhir.Model.STU3.Coding _Use;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationIncludeDesignationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(LanguageElement != null) dest.LanguageElement = (Hl7.Fhir.Model.STU3.Code)LanguageElement.DeepCopy();
                    if(Use != null) dest.Use = (Hl7.Fhir.Model.STU3.Coding)Use.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.Matches(Use, otherT.Use)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationIncludeDesignationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.IsExactly(Use, otherT.Use)) return false;
            
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
                    if (LanguageElement != null) yield return new ElementValue("language", false, LanguageElement);
                    if (Use != null) yield return new ElementValue("use", false, Use);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "DesignationExcludeComponent")]
        [DataContract]
        public partial class DesignationExcludeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationExcludeComponent"; } }
            
            /// <summary>
            /// The designation to be excluded
            /// </summary>
            [FhirElement("designation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DesignationExcludeDesignationComponent> Designation
            {
                get { if(_Designation==null) _Designation = new List<DesignationExcludeDesignationComponent>(); return _Designation; }
                set { _Designation = value; OnPropertyChanged("Designation"); }
            }
            
            private List<DesignationExcludeDesignationComponent> _Designation;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationExcludeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Designation != null) dest.Designation = new List<DesignationExcludeDesignationComponent>(Designation.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Designation, otherT.Designation)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationExcludeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Designation, otherT.Designation)) return false;
            
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
                    foreach (var elem in Designation) { if (elem != null) yield return new ElementValue("designation", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "DesignationExcludeDesignationComponent")]
        [DataContract]
        public partial class DesignationExcludeDesignationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DesignationExcludeDesignationComponent"; } }
            
            /// <summary>
            /// Human language of the designation to be excluded
            /// </summary>
            [FhirElement("language", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Code LanguageElement
            {
                get { return _LanguageElement; }
                set { _LanguageElement = value; OnPropertyChanged("LanguageElement"); }
            }
            
            private Hl7.Fhir.Model.STU3.Code _LanguageElement;
            
            /// <summary>
            /// Human language of the designation to be excluded
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Language
            {
                get { return LanguageElement != null ? LanguageElement.Value : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new Hl7.Fhir.Model.STU3.Code(value);
                    OnPropertyChanged("Language");
                }
            }
            
            /// <summary>
            /// What kind of Designation to exclude
            /// </summary>
            [FhirElement("use", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Coding Use
            {
                get { return _Use; }
                set { _Use = value; OnPropertyChanged("Use"); }
            }
            
            private Hl7.Fhir.Model.STU3.Coding _Use;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DesignationExcludeDesignationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(LanguageElement != null) dest.LanguageElement = (Hl7.Fhir.Model.STU3.Code)LanguageElement.DeepCopy();
                    if(Use != null) dest.Use = (Hl7.Fhir.Model.STU3.Coding)Use.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.Matches(Use, otherT.Use)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DesignationExcludeDesignationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.IsExactly(Use, otherT.Use)) return false;
            
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
                    if (LanguageElement != null) yield return new ElementValue("language", false, LanguageElement);
                    if (Use != null) yield return new ElementValue("use", false, Use);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Logical URI to reference this expansion profile (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Logical URI to reference this expansion profile (globally unique)
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
        /// Additional identifier for the expansion profile
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.STU3.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.STU3.Identifier _Identifier;
        
        /// <summary>
        /// Business version of the expansion profile
        /// </summary>
        [FhirElement("version", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Business version of the expansion profile
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
        /// Name for this expansion profile (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Name for this expansion profile (computer friendly)
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
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.STU3.PublicationStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.STU3.PublicationStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.STU3.PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.STU3.PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
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
        /// Date this was last changed
        /// </summary>
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.STU3.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.STU3.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date this was last changed
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
                    DateElement = new Hl7.Fhir.Model.STU3.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
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
        [FhirElement("contact", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ContactDetail> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.STU3.ContactDetail>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ContactDetail> _Contact;
        
        /// <summary>
        /// Natural language description of the expansion profile
        /// </summary>
        [FhirElement("description", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _DescriptionElement;
        
        /// <summary>
        /// Natural language description of the expansion profile
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
        /// Context the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.STU3.UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for expansion profile (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.STU3.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Fix use of a code system to a particular version
        /// </summary>
        [FhirElement("fixedVersion", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FixedVersionComponent> FixedVersion
        {
            get { if(_FixedVersion==null) _FixedVersion = new List<FixedVersionComponent>(); return _FixedVersion; }
            set { _FixedVersion = value; OnPropertyChanged("FixedVersion"); }
        }
        
        private List<FixedVersionComponent> _FixedVersion;
        
        /// <summary>
        /// Systems/Versions to be exclude
        /// </summary>
        [FhirElement("excludedSystem", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [DataMember]
        public ExcludedSystemComponent ExcludedSystem
        {
            get { return _ExcludedSystem; }
            set { _ExcludedSystem = value; OnPropertyChanged("ExcludedSystem"); }
        }
        
        private ExcludedSystemComponent _ExcludedSystem;
        
        /// <summary>
        /// Whether the expansion should include concept designations
        /// </summary>
        [FhirElement("includeDesignations", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean IncludeDesignationsElement
        {
            get { return _IncludeDesignationsElement; }
            set { _IncludeDesignationsElement = value; OnPropertyChanged("IncludeDesignationsElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _IncludeDesignationsElement;
        
        /// <summary>
        /// Whether the expansion should include concept designations
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? IncludeDesignations
        {
            get { return IncludeDesignationsElement != null ? IncludeDesignationsElement.Value : null; }
            set
            {
                if (value == null)
                    IncludeDesignationsElement = null;
                else
                    IncludeDesignationsElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("IncludeDesignations");
            }
        }
        
        /// <summary>
        /// When the expansion profile imposes designation contraints
        /// </summary>
        [FhirElement("designation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=240)]
        [CLSCompliant(false)]
        [DataMember]
        public DesignationComponent Designation
        {
            get { return _Designation; }
            set { _Designation = value; OnPropertyChanged("Designation"); }
        }
        
        private DesignationComponent _Designation;
        
        /// <summary>
        /// Include or exclude the value set definition in the expansion
        /// </summary>
        [FhirElement("includeDefinition", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=250)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean IncludeDefinitionElement
        {
            get { return _IncludeDefinitionElement; }
            set { _IncludeDefinitionElement = value; OnPropertyChanged("IncludeDefinitionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _IncludeDefinitionElement;
        
        /// <summary>
        /// Include or exclude the value set definition in the expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? IncludeDefinition
        {
            get { return IncludeDefinitionElement != null ? IncludeDefinitionElement.Value : null; }
            set
            {
                if (value == null)
                    IncludeDefinitionElement = null;
                else
                    IncludeDefinitionElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("IncludeDefinition");
            }
        }
        
        /// <summary>
        /// Include or exclude inactive concepts in the expansion
        /// </summary>
        [FhirElement("activeOnly", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=260)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ActiveOnlyElement
        {
            get { return _ActiveOnlyElement; }
            set { _ActiveOnlyElement = value; OnPropertyChanged("ActiveOnlyElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ActiveOnlyElement;
        
        /// <summary>
        /// Include or exclude inactive concepts in the expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? ActiveOnly
        {
            get { return ActiveOnlyElement != null ? ActiveOnlyElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveOnlyElement = null;
                else
                    ActiveOnlyElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("ActiveOnly");
            }
        }
        
        /// <summary>
        /// Nested codes in the expansion or not
        /// </summary>
        [FhirElement("excludeNested", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=270)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExcludeNestedElement
        {
            get { return _ExcludeNestedElement; }
            set { _ExcludeNestedElement = value; OnPropertyChanged("ExcludeNestedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExcludeNestedElement;
        
        /// <summary>
        /// Nested codes in the expansion or not
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? ExcludeNested
        {
            get { return ExcludeNestedElement != null ? ExcludeNestedElement.Value : null; }
            set
            {
                if (value == null)
                    ExcludeNestedElement = null;
                else
                    ExcludeNestedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("ExcludeNested");
            }
        }
        
        /// <summary>
        /// Include or exclude codes which cannot be rendered in user interfaces in the value set expansion
        /// </summary>
        [FhirElement("excludeNotForUI", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=280)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExcludeNotForUIElement
        {
            get { return _ExcludeNotForUIElement; }
            set { _ExcludeNotForUIElement = value; OnPropertyChanged("ExcludeNotForUIElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExcludeNotForUIElement;
        
        /// <summary>
        /// Include or exclude codes which cannot be rendered in user interfaces in the value set expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? ExcludeNotForUI
        {
            get { return ExcludeNotForUIElement != null ? ExcludeNotForUIElement.Value : null; }
            set
            {
                if (value == null)
                    ExcludeNotForUIElement = null;
                else
                    ExcludeNotForUIElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("ExcludeNotForUI");
            }
        }
        
        /// <summary>
        /// Include or exclude codes which are post coordinated expressions in the value set expansion
        /// </summary>
        [FhirElement("excludePostCoordinated", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=290)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExcludePostCoordinatedElement
        {
            get { return _ExcludePostCoordinatedElement; }
            set { _ExcludePostCoordinatedElement = value; OnPropertyChanged("ExcludePostCoordinatedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExcludePostCoordinatedElement;
        
        /// <summary>
        /// Include or exclude codes which are post coordinated expressions in the value set expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? ExcludePostCoordinated
        {
            get { return ExcludePostCoordinatedElement != null ? ExcludePostCoordinatedElement.Value : null; }
            set
            {
                if (value == null)
                    ExcludePostCoordinatedElement = null;
                else
                    ExcludePostCoordinatedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("ExcludePostCoordinated");
            }
        }
        
        /// <summary>
        /// Specify the language for the display element of codes in the value set expansion
        /// </summary>
        [FhirElement("displayLanguage", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=300)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.STU3.Code DisplayLanguageElement
        {
            get { return _DisplayLanguageElement; }
            set { _DisplayLanguageElement = value; OnPropertyChanged("DisplayLanguageElement"); }
        }
        
        private Hl7.Fhir.Model.STU3.Code _DisplayLanguageElement;
        
        /// <summary>
        /// Specify the language for the display element of codes in the value set expansion
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DisplayLanguage
        {
            get { return DisplayLanguageElement != null ? DisplayLanguageElement.Value : null; }
            set
            {
                if (value == null)
                    DisplayLanguageElement = null;
                else
                    DisplayLanguageElement = new Hl7.Fhir.Model.STU3.Code(value);
                OnPropertyChanged("DisplayLanguage");
            }
        }
        
        /// <summary>
        /// Controls behaviour of the value set expand operation when value sets are too large to be completely expanded
        /// </summary>
        [FhirElement("limitedExpansion", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=310)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean LimitedExpansionElement
        {
            get { return _LimitedExpansionElement; }
            set { _LimitedExpansionElement = value; OnPropertyChanged("LimitedExpansionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _LimitedExpansionElement;
        
        /// <summary>
        /// Controls behaviour of the value set expand operation when value sets are too large to be completely expanded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? LimitedExpansion
        {
            get { return LimitedExpansionElement != null ? LimitedExpansionElement.Value : null; }
            set
            {
                if (value == null)
                    LimitedExpansionElement = null;
                else
                    LimitedExpansionElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("LimitedExpansion");
            }
        }
    
    
        public static ElementDefinitionConstraint ExpansionProfile_EXP_3 = new ElementDefinitionConstraint
        {
            Expression = "designation.include.designation.all(language.exists() or use.exists())",
            Key = "exp-3",
            Severity = ConstraintSeverity.Warning,
            Human = "SHALL have at least one of language or use",
            Xpath = "exists(f:language) or exists(f:use)"
        };
    
        public static ElementDefinitionConstraint ExpansionProfile_EXP_4 = new ElementDefinitionConstraint
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
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.STU3.Identifier)Identifier.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.STU3.PublicationStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.STU3.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.STU3.ContactDetail>(Contact.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.STU3.UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.STU3.CodeableConcept>(Jurisdiction.DeepCopy());
                if(FixedVersion != null) dest.FixedVersion = new List<FixedVersionComponent>(FixedVersion.DeepCopy());
                if(ExcludedSystem != null) dest.ExcludedSystem = (ExcludedSystemComponent)ExcludedSystem.DeepCopy();
                if(IncludeDesignationsElement != null) dest.IncludeDesignationsElement = (Hl7.Fhir.Model.FhirBoolean)IncludeDesignationsElement.DeepCopy();
                if(Designation != null) dest.Designation = (DesignationComponent)Designation.DeepCopy();
                if(IncludeDefinitionElement != null) dest.IncludeDefinitionElement = (Hl7.Fhir.Model.FhirBoolean)IncludeDefinitionElement.DeepCopy();
                if(ActiveOnlyElement != null) dest.ActiveOnlyElement = (Hl7.Fhir.Model.FhirBoolean)ActiveOnlyElement.DeepCopy();
                if(ExcludeNestedElement != null) dest.ExcludeNestedElement = (Hl7.Fhir.Model.FhirBoolean)ExcludeNestedElement.DeepCopy();
                if(ExcludeNotForUIElement != null) dest.ExcludeNotForUIElement = (Hl7.Fhir.Model.FhirBoolean)ExcludeNotForUIElement.DeepCopy();
                if(ExcludePostCoordinatedElement != null) dest.ExcludePostCoordinatedElement = (Hl7.Fhir.Model.FhirBoolean)ExcludePostCoordinatedElement.DeepCopy();
                if(DisplayLanguageElement != null) dest.DisplayLanguageElement = (Hl7.Fhir.Model.STU3.Code)DisplayLanguageElement.DeepCopy();
                if(LimitedExpansionElement != null) dest.LimitedExpansionElement = (Hl7.Fhir.Model.FhirBoolean)LimitedExpansionElement.DeepCopy();
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
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
            if( !DeepComparable.Matches(FixedVersion, otherT.FixedVersion)) return false;
            if( !DeepComparable.Matches(ExcludedSystem, otherT.ExcludedSystem)) return false;
            if( !DeepComparable.Matches(IncludeDesignationsElement, otherT.IncludeDesignationsElement)) return false;
            if( !DeepComparable.Matches(Designation, otherT.Designation)) return false;
            if( !DeepComparable.Matches(IncludeDefinitionElement, otherT.IncludeDefinitionElement)) return false;
            if( !DeepComparable.Matches(ActiveOnlyElement, otherT.ActiveOnlyElement)) return false;
            if( !DeepComparable.Matches(ExcludeNestedElement, otherT.ExcludeNestedElement)) return false;
            if( !DeepComparable.Matches(ExcludeNotForUIElement, otherT.ExcludeNotForUIElement)) return false;
            if( !DeepComparable.Matches(ExcludePostCoordinatedElement, otherT.ExcludePostCoordinatedElement)) return false;
            if( !DeepComparable.Matches(DisplayLanguageElement, otherT.DisplayLanguageElement)) return false;
            if( !DeepComparable.Matches(LimitedExpansionElement, otherT.LimitedExpansionElement)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ExpansionProfile;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
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
            if( !DeepComparable.IsExactly(FixedVersion, otherT.FixedVersion)) return false;
            if( !DeepComparable.IsExactly(ExcludedSystem, otherT.ExcludedSystem)) return false;
            if( !DeepComparable.IsExactly(IncludeDesignationsElement, otherT.IncludeDesignationsElement)) return false;
            if( !DeepComparable.IsExactly(Designation, otherT.Designation)) return false;
            if( !DeepComparable.IsExactly(IncludeDefinitionElement, otherT.IncludeDefinitionElement)) return false;
            if( !DeepComparable.IsExactly(ActiveOnlyElement, otherT.ActiveOnlyElement)) return false;
            if( !DeepComparable.IsExactly(ExcludeNestedElement, otherT.ExcludeNestedElement)) return false;
            if( !DeepComparable.IsExactly(ExcludeNotForUIElement, otherT.ExcludeNotForUIElement)) return false;
            if( !DeepComparable.IsExactly(ExcludePostCoordinatedElement, otherT.ExcludePostCoordinatedElement)) return false;
            if( !DeepComparable.IsExactly(DisplayLanguageElement, otherT.DisplayLanguageElement)) return false;
            if( !DeepComparable.IsExactly(LimitedExpansionElement, otherT.LimitedExpansionElement)) return false;
        
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
                if (DescriptionElement != null) yield return DescriptionElement;
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
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
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
                foreach (var elem in FixedVersion) { if (elem != null) yield return new ElementValue("fixedVersion", true, elem); }
                if (ExcludedSystem != null) yield return new ElementValue("excludedSystem", false, ExcludedSystem);
                if (IncludeDesignationsElement != null) yield return new ElementValue("includeDesignations", false, IncludeDesignationsElement);
                if (Designation != null) yield return new ElementValue("designation", false, Designation);
                if (IncludeDefinitionElement != null) yield return new ElementValue("includeDefinition", false, IncludeDefinitionElement);
                if (ActiveOnlyElement != null) yield return new ElementValue("activeOnly", false, ActiveOnlyElement);
                if (ExcludeNestedElement != null) yield return new ElementValue("excludeNested", false, ExcludeNestedElement);
                if (ExcludeNotForUIElement != null) yield return new ElementValue("excludeNotForUI", false, ExcludeNotForUIElement);
                if (ExcludePostCoordinatedElement != null) yield return new ElementValue("excludePostCoordinated", false, ExcludePostCoordinatedElement);
                if (DisplayLanguageElement != null) yield return new ElementValue("displayLanguage", false, DisplayLanguageElement);
                if (LimitedExpansionElement != null) yield return new ElementValue("limitedExpansion", false, LimitedExpansionElement);
            }
        }
    
    }

}
