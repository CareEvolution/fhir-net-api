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
    /// A healthcare consumer's policy choices to permits or denies recipients or roles to perform actions for specific purposes and periods of time
    /// </summary>
    [FhirType("Consent", IsResource=true)]
    [DataContract]
    public partial class Consent : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Consent; } }
        [NotMapped]
        public override string TypeName { get { return "Consent"; } }


        [FhirType("ActorComponent")]
        [DataContract]
        public partial class ActorComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActorComponent"; } }

            /// <summary>
            /// How the actor is involved
            /// </summary>
            [FhirElement("role", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Resource for the actor (or group, by role)
            /// </summary>
            [FhirElement("reference", Order=50)]
            [References("Device","Group","CareTeam","Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
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
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        [FhirType("PolicyComponent")]
        [DataContract]
        public partial class PolicyComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PolicyComponent"; } }

            /// <summary>
            /// Enforcement source for policy
            /// </summary>
            [FhirElement("authority", Order=40)]
            [DataMember]
            public FhirUri AuthorityElement
            {
                get { return _authorityElement; }
                set { _authorityElement = value; OnPropertyChanged("AuthorityElement"); }
            }

            private FhirUri _authorityElement;

            /// <summary>
            /// Enforcement source for policy
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Authority
            {
                get { return AuthorityElement != null ? AuthorityElement.Value : null; }
                set
                {
                    if (value == null)
                        AuthorityElement = null;
                    else
                        AuthorityElement = new FhirUri(value);
                    OnPropertyChanged("Authority");
                }
            }

            /// <summary>
            /// Specific policy covered by this consent
            /// </summary>
            [FhirElement("uri", Order=50)]
            [DataMember]
            public FhirUri UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private FhirUri _uriElement;

            /// <summary>
            /// Specific policy covered by this consent
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
                var dest = other as PolicyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AuthorityElement != null) dest.AuthorityElement = (FhirUri)AuthorityElement.DeepCopy();
                    if (UriElement != null) dest.UriElement = (FhirUri)UriElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PolicyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PolicyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AuthorityElement, otherT.AuthorityElement)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PolicyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AuthorityElement, otherT.AuthorityElement)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AuthorityElement != null) yield return AuthorityElement;
                    if (UriElement != null) yield return UriElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AuthorityElement != null) yield return new ElementValue("authority", AuthorityElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                }
            }


        }


        [FhirType("DataComponent")]
        [DataContract]
        public partial class DataComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DataComponent"; } }

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            [FhirElement("meaning", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConsentDataMeaning> MeaningElement
            {
                get { return _meaningElement; }
                set { _meaningElement = value; OnPropertyChanged("MeaningElement"); }
            }

            private Code<ConsentDataMeaning> _meaningElement;

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConsentDataMeaning? Meaning
            {
                get { return MeaningElement != null ? MeaningElement.Value : null; }
                set
                {
                    if (value == null)
                        MeaningElement = null;
                    else
                        MeaningElement = new Code<ConsentDataMeaning>(value);
                    OnPropertyChanged("Meaning");
                }
            }

            /// <summary>
            /// The actual data reference
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (MeaningElement != null) dest.MeaningElement = (Code<ConsentDataMeaning>)MeaningElement.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (MeaningElement != null) yield return MeaningElement;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (MeaningElement != null) yield return new ElementValue("meaning", MeaningElement);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        [FhirType("ExceptComponent")]
        [DataContract]
        public partial class ExceptComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExceptComponent"; } }

            /// <summary>
            /// deny | permit
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConsentExceptType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ConsentExceptType> _typeElement;

            /// <summary>
            /// deny | permit
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConsentExceptType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ConsentExceptType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Timeframe for this exception
            /// </summary>
            [FhirElement("period", InSummary=true, Order=50)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// Who|what controlled by this exception (or group, by role)
            /// </summary>
            [FhirElement("actor", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ExceptActorComponent> Actor
            {
                get { if (_actor==null) _actor = new List<ExceptActorComponent>(); return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private List<ExceptActorComponent> _actor;

            /// <summary>
            /// Actions controlled by this exception
            /// </summary>
            [FhirElement("action", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Action
            {
                get { if (_action==null) _action = new List<CodeableConcept>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<CodeableConcept> _action;

            /// <summary>
            /// Security Labels that define affected resources
            /// </summary>
            [FhirElement("securityLabel", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> SecurityLabel
            {
                get { if (_securityLabel==null) _securityLabel = new List<Coding>(); return _securityLabel; }
                set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }

            private List<Coding> _securityLabel;

            /// <summary>
            /// Context of activities covered by this exception
            /// </summary>
            [FhirElement("purpose", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Purpose
            {
                get { if (_purpose==null) _purpose = new List<Coding>(); return _purpose; }
                set { _purpose = value; OnPropertyChanged("Purpose"); }
            }

            private List<Coding> _purpose;

            /// <summary>
            /// e.g. Resource Type, Profile, or CDA etc
            /// </summary>
            [FhirElement("class", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Class
            {
                get { if (_class==null) _class = new List<Coding>(); return _class; }
                set { _class = value; OnPropertyChanged("Class"); }
            }

            private List<Coding> _class;

            /// <summary>
            /// e.g. LOINC or SNOMED CT code, etc in the content
            /// </summary>
            [FhirElement("code", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Code
            {
                get { if (_code==null) _code = new List<Coding>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<Coding> _code;

            /// <summary>
            /// Timeframe for data controlled by this exception
            /// </summary>
            [FhirElement("dataPeriod", InSummary=true, Order=120)]
            [DataMember]
            public Period DataPeriod
            {
                get { return _dataPeriod; }
                set { _dataPeriod = value; OnPropertyChanged("DataPeriod"); }
            }

            private Period _dataPeriod;

            /// <summary>
            /// Data controlled by this exception
            /// </summary>
            [FhirElement("data", InSummary=true, Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ExceptDataComponent> Data
            {
                get { if (_data==null) _data = new List<ExceptDataComponent>(); return _data; }
                set { _data = value; OnPropertyChanged("Data"); }
            }

            private List<ExceptDataComponent> _data;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExceptComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ConsentExceptType>)TypeElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Actor != null) dest.Actor = new List<ExceptActorComponent>(Actor.DeepCopy());
                    if (Action != null) dest.Action = new List<CodeableConcept>(Action.DeepCopy());
                    if (SecurityLabel != null) dest.SecurityLabel = new List<Coding>(SecurityLabel.DeepCopy());
                    if (Purpose != null) dest.Purpose = new List<Coding>(Purpose.DeepCopy());
                    if (Class != null) dest.Class = new List<Coding>(Class.DeepCopy());
                    if (Code != null) dest.Code = new List<Coding>(Code.DeepCopy());
                    if (DataPeriod != null) dest.DataPeriod = (Period)DataPeriod.DeepCopy();
                    if (Data != null) dest.Data = new List<ExceptDataComponent>(Data.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExceptComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExceptComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
                if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
                if ( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
                if ( !DeepComparable.Matches(Class, otherT.Class)) return false;
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(DataPeriod, otherT.DataPeriod)) return false;
                if ( !DeepComparable.Matches(Data, otherT.Data)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExceptComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
                if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
                if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DataPeriod, otherT.DataPeriod)) return false;
                if (!DeepComparable.IsExactly(Data, otherT.Data)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Period != null) yield return Period;
                    foreach (var elem in Actor) { if (elem != null) yield return elem; }
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                    foreach (var elem in Purpose) { if (elem != null) yield return elem; }
                    foreach (var elem in Class) { if (elem != null) yield return elem; }
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    if (DataPeriod != null) yield return DataPeriod;
                    foreach (var elem in Data) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                    foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                    foreach (var elem in Purpose) { if (elem != null) yield return new ElementValue("purpose", elem); }
                    foreach (var elem in Class) { if (elem != null) yield return new ElementValue("class", elem); }
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    if (DataPeriod != null) yield return new ElementValue("dataPeriod", DataPeriod);
                    foreach (var elem in Data) { if (elem != null) yield return new ElementValue("data", elem); }
                }
            }


        }


        [FhirType("ExceptActorComponent")]
        [DataContract]
        public partial class ExceptActorComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExceptActorComponent"; } }

            /// <summary>
            /// How the actor is involved
            /// </summary>
            [FhirElement("role", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Resource for the actor (or group, by role)
            /// </summary>
            [FhirElement("reference", Order=50)]
            [References("Device","Group","CareTeam","Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExceptActorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExceptActorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExceptActorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExceptActorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        [FhirType("ExceptDataComponent")]
        [DataContract]
        public partial class ExceptDataComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExceptDataComponent"; } }

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            [FhirElement("meaning", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConsentDataMeaning> MeaningElement
            {
                get { return _meaningElement; }
                set { _meaningElement = value; OnPropertyChanged("MeaningElement"); }
            }

            private Code<ConsentDataMeaning> _meaningElement;

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConsentDataMeaning? Meaning
            {
                get { return MeaningElement != null ? MeaningElement.Value : null; }
                set
                {
                    if (value == null)
                        MeaningElement = null;
                    else
                        MeaningElement = new Code<ConsentDataMeaning>(value);
                    OnPropertyChanged("Meaning");
                }
            }

            /// <summary>
            /// The actual data reference
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExceptDataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (MeaningElement != null) dest.MeaningElement = (Code<ConsentDataMeaning>)MeaningElement.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExceptDataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExceptDataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExceptDataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (MeaningElement != null) yield return MeaningElement;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (MeaningElement != null) yield return new ElementValue("meaning", MeaningElement);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        /// <summary>
        /// Identifier for this record (external references)
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
        /// draft | proposed | active | rejected | inactive | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConsentState> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ConsentState> _statusElement;

        /// <summary>
        /// draft | proposed | active | rejected | inactive | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConsentState? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConsentState>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Classification of the consent statement - for indexing/retrieval
        /// </summary>
        [FhirElement("category", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Who the consent applies to
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=120)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Period that this consent applies
        /// </summary>
        [FhirElement("period", InSummary=true, Order=130)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// When this Consent was created or indexed
        /// </summary>
        [FhirElement("dateTime", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime DateTimeElement
        {
            get { return _dateTimeElement; }
            set { _dateTimeElement = value; OnPropertyChanged("DateTimeElement"); }
        }

        private FhirDateTime _dateTimeElement;

        /// <summary>
        /// When this Consent was created or indexed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateTime
        {
            get { return DateTimeElement != null ? DateTimeElement.Value : null; }
            set
            {
                if (value == null)
                    DateTimeElement = null;
                else
                    DateTimeElement = new FhirDateTime(value);
                OnPropertyChanged("DateTime");
            }
        }

        /// <summary>
        /// Who is agreeing to the policy and exceptions
        /// </summary>
        [FhirElement("consentingParty", InSummary=true, Order=150)]
        [References("Organization","Patient","Practitioner","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ConsentingParty
        {
            get { if (_consentingParty==null) _consentingParty = new List<ResourceReference>(); return _consentingParty; }
            set { _consentingParty = value; OnPropertyChanged("ConsentingParty"); }
        }

        private List<ResourceReference> _consentingParty;

        /// <summary>
        /// Who|what controlled by this consent (or group, by role)
        /// </summary>
        [FhirElement("actor", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ActorComponent> Actor
        {
            get { if (_actor==null) _actor = new List<ActorComponent>(); return _actor; }
            set { _actor = value; OnPropertyChanged("Actor"); }
        }

        private List<ActorComponent> _actor;

        /// <summary>
        /// Actions controlled by this consent
        /// </summary>
        [FhirElement("action", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Action
        {
            get { if (_action==null) _action = new List<CodeableConcept>(); return _action; }
            set { _action = value; OnPropertyChanged("Action"); }
        }

        private List<CodeableConcept> _action;

        /// <summary>
        /// Custodian of the consent
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=180)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Organization
        {
            get { if (_organization==null) _organization = new List<ResourceReference>(); return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private List<ResourceReference> _organization;

        /// <summary>
        /// Source from which this consent is taken
        /// </summary>
        [FhirElement("source", InSummary=true, Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Attachment),typeof(Identifier),typeof(ResourceReference))]
        [DataMember]
        public Element Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private Element _source;

        /// <summary>
        /// Policies covered by this consent
        /// </summary>
        [FhirElement("policy", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PolicyComponent> Policy
        {
            get { if (_policy==null) _policy = new List<PolicyComponent>(); return _policy; }
            set { _policy = value; OnPropertyChanged("Policy"); }
        }

        private List<PolicyComponent> _policy;

        /// <summary>
        /// Policy that this consents to
        /// </summary>
        [FhirElement("policyRule", InSummary=true, Order=210)]
        [DataMember]
        public FhirUri PolicyRuleElement
        {
            get { return _policyRuleElement; }
            set { _policyRuleElement = value; OnPropertyChanged("PolicyRuleElement"); }
        }

        private FhirUri _policyRuleElement;

        /// <summary>
        /// Policy that this consents to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PolicyRule
        {
            get { return PolicyRuleElement != null ? PolicyRuleElement.Value : null; }
            set
            {
                if (value == null)
                    PolicyRuleElement = null;
                else
                    PolicyRuleElement = new FhirUri(value);
                OnPropertyChanged("PolicyRule");
            }
        }

        /// <summary>
        /// Security Labels that define affected resources
        /// </summary>
        [FhirElement("securityLabel", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> SecurityLabel
        {
            get { if (_securityLabel==null) _securityLabel = new List<Coding>(); return _securityLabel; }
            set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
        }

        private List<Coding> _securityLabel;

        /// <summary>
        /// Context of activities for which the agreement is made
        /// </summary>
        [FhirElement("purpose", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Purpose
        {
            get { if (_purpose==null) _purpose = new List<Coding>(); return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private List<Coding> _purpose;

        /// <summary>
        /// Timeframe for data controlled by this consent
        /// </summary>
        [FhirElement("dataPeriod", InSummary=true, Order=240)]
        [DataMember]
        public Period DataPeriod
        {
            get { return _dataPeriod; }
            set { _dataPeriod = value; OnPropertyChanged("DataPeriod"); }
        }

        private Period _dataPeriod;

        /// <summary>
        /// Data controlled by this consent
        /// </summary>
        [FhirElement("data", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DataComponent> Data
        {
            get { if (_data==null) _data = new List<DataComponent>(); return _data; }
            set { _data = value; OnPropertyChanged("Data"); }
        }

        private List<DataComponent> _data;

        /// <summary>
        /// Additional rule -  addition or removal of permissions
        /// </summary>
        [FhirElement("except", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ExceptComponent> Except
        {
            get { if (_except==null) _except = new List<ExceptComponent>(); return _except; }
            set { _except = value; OnPropertyChanged("Except"); }
        }

        private List<ExceptComponent> _except;


        public static ElementDefinition.ConstraintComponent Consent_PPC_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "policy.exists() or policyRule.exists()",
            Key = "ppc-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Either a Policy or PolicyRule",
            Xpath = "exists(f:policy) or exists(f:policyRule)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Consent_PPC_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Consent;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConsentState>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (DateTimeElement != null) dest.DateTimeElement = (FhirDateTime)DateTimeElement.DeepCopy();
                if (ConsentingParty != null) dest.ConsentingParty = new List<ResourceReference>(ConsentingParty.DeepCopy());
                if (Actor != null) dest.Actor = new List<ActorComponent>(Actor.DeepCopy());
                if (Action != null) dest.Action = new List<CodeableConcept>(Action.DeepCopy());
                if (Organization != null) dest.Organization = new List<ResourceReference>(Organization.DeepCopy());
                if (Source != null) dest.Source = (Element)Source.DeepCopy();
                if (Policy != null) dest.Policy = new List<PolicyComponent>(Policy.DeepCopy());
                if (PolicyRuleElement != null) dest.PolicyRuleElement = (FhirUri)PolicyRuleElement.DeepCopy();
                if (SecurityLabel != null) dest.SecurityLabel = new List<Coding>(SecurityLabel.DeepCopy());
                if (Purpose != null) dest.Purpose = new List<Coding>(Purpose.DeepCopy());
                if (DataPeriod != null) dest.DataPeriod = (Period)DataPeriod.DeepCopy();
                if (Data != null) dest.Data = new List<DataComponent>(Data.DeepCopy());
                if (Except != null) dest.Except = new List<ExceptComponent>(Except.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Consent());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Consent;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(DateTimeElement, otherT.DateTimeElement)) return false;
            if ( !DeepComparable.Matches(ConsentingParty, otherT.ConsentingParty)) return false;
            if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
            if ( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if ( !DeepComparable.Matches(Policy, otherT.Policy)) return false;
            if (!DeepComparable.Matches(PolicyRuleElement, otherT.PolicyRuleElement)) return false;
            if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
            if ( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(DataPeriod, otherT.DataPeriod)) return false;
            if ( !DeepComparable.Matches(Data, otherT.Data)) return false;
            if ( !DeepComparable.Matches(Except, otherT.Except)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Consent;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(DateTimeElement, otherT.DateTimeElement)) return false;
            if (!DeepComparable.IsExactly(ConsentingParty, otherT.ConsentingParty)) return false;
            if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Policy, otherT.Policy)) return false;
            if (!DeepComparable.IsExactly(PolicyRuleElement, otherT.PolicyRuleElement)) return false;
            if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(DataPeriod, otherT.DataPeriod)) return false;
            if (!DeepComparable.IsExactly(Data, otherT.Data)) return false;
            if (!DeepComparable.IsExactly(Except, otherT.Except)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (Period != null) yield return Period;
                if (DateTimeElement != null) yield return DateTimeElement;
                foreach (var elem in ConsentingParty) { if (elem != null) yield return elem; }
                foreach (var elem in Actor) { if (elem != null) yield return elem; }
                foreach (var elem in Action) { if (elem != null) yield return elem; }
                foreach (var elem in Organization) { if (elem != null) yield return elem; }
                if (Source != null) yield return Source;
                foreach (var elem in Policy) { if (elem != null) yield return elem; }
                if (PolicyRuleElement != null) yield return PolicyRuleElement;
                foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                foreach (var elem in Purpose) { if (elem != null) yield return elem; }
                if (DataPeriod != null) yield return DataPeriod;
                foreach (var elem in Data) { if (elem != null) yield return elem; }
                foreach (var elem in Except) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Period != null) yield return new ElementValue("period", Period);
                if (DateTimeElement != null) yield return new ElementValue("dateTime", DateTimeElement);
                foreach (var elem in ConsentingParty) { if (elem != null) yield return new ElementValue("consentingParty", elem); }
                foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                foreach (var elem in Organization) { if (elem != null) yield return new ElementValue("organization", elem); }
                if (Source != null) yield return new ElementValue("source", Source);
                foreach (var elem in Policy) { if (elem != null) yield return new ElementValue("policy", elem); }
                if (PolicyRuleElement != null) yield return new ElementValue("policyRule", PolicyRuleElement);
                foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                foreach (var elem in Purpose) { if (elem != null) yield return new ElementValue("purpose", elem); }
                if (DataPeriod != null) yield return new ElementValue("dataPeriod", DataPeriod);
                foreach (var elem in Data) { if (elem != null) yield return new ElementValue("data", elem); }
                foreach (var elem in Except) { if (elem != null) yield return new ElementValue("except", elem); }
            }
        }

    }

}
