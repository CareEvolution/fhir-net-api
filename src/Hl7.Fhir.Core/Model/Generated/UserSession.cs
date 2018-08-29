using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
    /// Information about a user's current session
    /// </summary>
    [FhirType("UserSession", IsResource=true)]
    [DataContract]
    public partial class UserSession : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.UserSession; } }
        [NotMapped]
        public override string TypeName { get { return "UserSession"; } }


        [FhirType("StatusComponent")]
        [DataContract]
        public partial class StatusComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StatusComponent"; } }

            /// <summary>
            /// activating | active | suspended | closing | closed
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<UserSessionStatus> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<UserSessionStatus> _codeElement;

            /// <summary>
            /// activating | active | suspended | closing | closed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public UserSessionStatus? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<UserSessionStatus>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// user | system
            /// </summary>
            [FhirElement("source", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<UserSessionStatusSource> SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private Code<UserSessionStatusSource> _sourceElement;

            /// <summary>
            /// user | system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public UserSessionStatusSource? Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new Code<UserSessionStatusSource>(value);
                    OnPropertyChanged("Source");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StatusComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<UserSessionStatus>)CodeElement.DeepCopy();
                    if (SourceElement != null) dest.SourceElement = (Code<UserSessionStatusSource>)SourceElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StatusComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StatusComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StatusComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;

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
                }
            }


        }


        [FhirType("ContextComponent")]
        [DataContract]
        public partial class ContextComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContextComponent"; } }

            /// <summary>
            /// What type of context value
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private FhirString _typeElement;

            /// <summary>
            /// What type of context value
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
            /// Value of the context
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(Quantity))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContextComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (FhirString)TypeElement.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContextComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (Value != null) yield return new ElementValue("value", false, Value);
                }
            }


        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// User engaged in the session
        /// </summary>
        [FhirElement("user", InSummary=true, Order=100)]
        [References("Device","Practitioner","Patient","RelatedPerson")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged("User"); }
        }

        private ResourceReference _user;

        /// <summary>
        /// Status of the session
        /// </summary>
        [FhirElement("status", Order=110)]
        [DataMember]
        public StatusComponent Status
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged("Status"); }
        }

        private StatusComponent _status;

        /// <summary>
        /// Where is the session
        /// </summary>
        [FhirElement("workstation", Order=120)]
        [DataMember]
        public Identifier Workstation
        {
            get { return _workstation; }
            set { _workstation = value; OnPropertyChanged("Workstation"); }
        }

        private Identifier _workstation;

        /// <summary>
        /// What is the user's current focus
        /// </summary>
        [FhirElement("focus", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Focus
        {
            get { if (_focus==null) _focus = new List<ResourceReference>(); return _focus; }
            set { _focus = value; OnPropertyChanged("Focus"); }
        }

        private List<ResourceReference> _focus;

        /// <summary>
        /// When was the session created
        /// </summary>
        [FhirElement("created", Order=140)]
        [DataMember]
        public Instant CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private Instant _createdElement;

        /// <summary>
        /// When was the session created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new Instant(value);
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// When does the session expire
        /// </summary>
        [FhirElement("expires", InSummary=true, Order=150)]
        [DataMember]
        public Instant ExpiresElement
        {
            get { return _expiresElement; }
            set { _expiresElement = value; OnPropertyChanged("ExpiresElement"); }
        }

        private Instant _expiresElement;

        /// <summary>
        /// When does the session expire
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Expires
        {
            get { return ExpiresElement != null ? ExpiresElement.Value : null; }
            set
            {
                if (value == null)
                    ExpiresElement = null;
                else
                    ExpiresElement = new Instant(value);
                OnPropertyChanged("Expires");
            }
        }

        /// <summary>
        /// Additional information about the session
        /// </summary>
        [FhirElement("context", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContextComponent> Context
        {
            get { if (_context==null) _context = new List<ContextComponent>(); return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private List<ContextComponent> _context;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as UserSession;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (User != null) dest.User = (ResourceReference)User.DeepCopy();
                if (Status != null) dest.Status = (StatusComponent)Status.DeepCopy();
                if (Workstation != null) dest.Workstation = (Identifier)Workstation.DeepCopy();
                if (Focus != null) dest.Focus = new List<ResourceReference>(Focus.DeepCopy());
                if (CreatedElement != null) dest.CreatedElement = (Instant)CreatedElement.DeepCopy();
                if (ExpiresElement != null) dest.ExpiresElement = (Instant)ExpiresElement.DeepCopy();
                if (Context != null) dest.Context = new List<ContextComponent>(Context.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new UserSession());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as UserSession;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(User, otherT.User)) return false;
            if (!DeepComparable.Matches(Status, otherT.Status)) return false;
            if (!DeepComparable.Matches(Workstation, otherT.Workstation)) return false;
            if ( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(ExpiresElement, otherT.ExpiresElement)) return false;
            if ( !DeepComparable.Matches(Context, otherT.Context)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as UserSession;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(User, otherT.User)) return false;
            if (!DeepComparable.IsExactly(Status, otherT.Status)) return false;
            if (!DeepComparable.IsExactly(Workstation, otherT.Workstation)) return false;
            if (!DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(ExpiresElement, otherT.ExpiresElement)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (User != null) yield return User;
                if (Status != null) yield return Status;
                if (Workstation != null) yield return Workstation;
                foreach (var elem in Focus) { if (elem != null) yield return elem; }
                if (CreatedElement != null) yield return CreatedElement;
                if (ExpiresElement != null) yield return ExpiresElement;
                foreach (var elem in Context) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (User != null) yield return new ElementValue("user", false, User);
                if (Status != null) yield return new ElementValue("status", false, Status);
                if (Workstation != null) yield return new ElementValue("workstation", false, Workstation);
                foreach (var elem in Focus) { if (elem != null) yield return new ElementValue("focus", true, elem); }
                if (CreatedElement != null) yield return new ElementValue("created", false, CreatedElement);
                if (ExpiresElement != null) yield return new ElementValue("expires", false, ExpiresElement);
                foreach (var elem in Context) { if (elem != null) yield return new ElementValue("context", true, elem); }
            }
        }

    }

}
