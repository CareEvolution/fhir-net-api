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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Information about the success/failure of an action
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "OperationOutcome", IsResource=true)]
    [DataContract]
    public partial class OperationOutcome : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OperationOutcome; } }
        [NotMapped]
        public override string TypeName { get { return "OperationOutcome"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "IssueComponent")]
        [DataContract]
        public partial class IssueComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "IssueComponent"; } }
            
            /// <summary>
            /// fatal | error | warning | information
            /// </summary>
            [FhirElement("severity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code SeverityElement
            {
                get { return _SeverityElement; }
                set { _SeverityElement = value; OnPropertyChanged("SeverityElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _SeverityElement;
            
            /// <summary>
            /// fatal | error | warning | information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if (value == null)
                        SeverityElement = null;
                    else
                        SeverityElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Severity");
                }
            }
            
            /// <summary>
            /// Error or warning code
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _CodeElement;
            
            /// <summary>
            /// Error or warning code
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
            /// Additional details about the error
            /// </summary>
            [FhirElement("details", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Details
            {
                get { return _Details; }
                set { _Details = value; OnPropertyChanged("Details"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Details;
            
            /// <summary>
            /// Additional diagnostic information about the issue
            /// </summary>
            [FhirElement("diagnostics", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DiagnosticsElement
            {
                get { return _DiagnosticsElement; }
                set { _DiagnosticsElement = value; OnPropertyChanged("DiagnosticsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DiagnosticsElement;
            
            /// <summary>
            /// Additional diagnostic information about the issue
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Diagnostics
            {
                get { return DiagnosticsElement != null ? DiagnosticsElement.Value : null; }
                set
                {
                    if (value == null)
                        DiagnosticsElement = null;
                    else
                        DiagnosticsElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Diagnostics");
                }
            }
            
            /// <summary>
            /// Path of element(s) related to issue
            /// </summary>
            [FhirElement("location", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> LocationElement
            {
                get { if(_LocationElement==null) _LocationElement = new List<Hl7.Fhir.Model.FhirString>(); return _LocationElement; }
                set { _LocationElement = value; OnPropertyChanged("LocationElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _LocationElement;
            
            /// <summary>
            /// Path of element(s) related to issue
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Location
            {
                get { return LocationElement != null ? LocationElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LocationElement = null;
                    else
                        LocationElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Location");
                }
            }
            
            /// <summary>
            /// FHIRPath of element(s) related to issue
            /// </summary>
            [FhirElement("expression", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> ExpressionElement
            {
                get { if(_ExpressionElement==null) _ExpressionElement = new List<Hl7.Fhir.Model.FhirString>(); return _ExpressionElement; }
                set { _ExpressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _ExpressionElement;
            
            /// <summary>
            /// FHIRPath of element(s) related to issue
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Expression");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IssueComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SeverityElement != null) dest.SeverityElement = (Hl7.Fhir.Model.R4.Code)SeverityElement.DeepCopy();
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.R4.Code)CodeElement.DeepCopy();
                    if(Details != null) dest.Details = (Hl7.Fhir.Model.R4.CodeableConcept)Details.DeepCopy();
                    if(DiagnosticsElement != null) dest.DiagnosticsElement = (Hl7.Fhir.Model.FhirString)DiagnosticsElement.DeepCopy();
                    if(LocationElement != null) dest.LocationElement = new List<Hl7.Fhir.Model.FhirString>(LocationElement.DeepCopy());
                    if(ExpressionElement != null) dest.ExpressionElement = new List<Hl7.Fhir.Model.FhirString>(ExpressionElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new IssueComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IssueComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(Details, otherT.Details)) return false;
                if( !DeepComparable.Matches(DiagnosticsElement, otherT.DiagnosticsElement)) return false;
                if( !DeepComparable.Matches(LocationElement, otherT.LocationElement)) return false;
                if( !DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IssueComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(Details, otherT.Details)) return false;
                if( !DeepComparable.IsExactly(DiagnosticsElement, otherT.DiagnosticsElement)) return false;
                if( !DeepComparable.IsExactly(LocationElement, otherT.LocationElement)) return false;
                if( !DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SeverityElement != null) yield return SeverityElement;
                    if (CodeElement != null) yield return CodeElement;
                    if (Details != null) yield return Details;
                    if (DiagnosticsElement != null) yield return DiagnosticsElement;
                    foreach (var elem in LocationElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ExpressionElement) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SeverityElement != null) yield return new ElementValue("severity", false, SeverityElement);
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    if (Details != null) yield return new ElementValue("details", false, Details);
                    if (DiagnosticsElement != null) yield return new ElementValue("diagnostics", false, DiagnosticsElement);
                    foreach (var elem in LocationElement) { if (elem != null) yield return new ElementValue("location", true, elem); }
                    foreach (var elem in ExpressionElement) { if (elem != null) yield return new ElementValue("expression", true, elem); }
                }
            }
        
        
        }
    
        
        /// <summary>
        /// A single issue associated with the action
        /// </summary>
        [FhirElement("issue", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<IssueComponent> Issue
        {
            get { if(_Issue==null) _Issue = new List<IssueComponent>(); return _Issue; }
            set { _Issue = value; OnPropertyChanged("Issue"); }
        }
        
        private List<IssueComponent> _Issue;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OperationOutcome;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Issue != null) dest.Issue = new List<IssueComponent>(Issue.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new OperationOutcome());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OperationOutcome;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Issue, otherT.Issue)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OperationOutcome;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Issue, otherT.Issue)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Issue) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Issue) { if (elem != null) yield return new ElementValue("issue", true, elem); }
            }
        }
    
    }

}
