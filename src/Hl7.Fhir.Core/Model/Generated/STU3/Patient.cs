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
    /// Information about an individual or animal receiving health care services
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.STU3, "Patient", IsResource=true)]
    [DataContract]
    public partial class Patient : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.IPatient, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Patient; } }
        [NotMapped]
        public override string TypeName { get { return "Patient"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ContactComponent")]
        [DataContract]
        public partial class ContactComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IPatientContactComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }
            
            [NotMapped]
            Hl7.Fhir.Model.IHumanName Hl7.Fhir.Model.IPatientContactComponent.Name { get { return Name; } }
            
            [NotMapped]
            IEnumerable<Hl7.Fhir.Model.IContactPoint> Hl7.Fhir.Model.IPatientContactComponent.Telecom { get { return Telecom; } }
            
            /// <summary>
            /// The kind of relationship
            /// </summary>
            [FhirElement("relationship", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Relationship
            {
                get { if(_Relationship==null) _Relationship = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Relationship; }
                set { _Relationship = value; OnPropertyChanged("Relationship"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Relationship;
            
            /// <summary>
            /// A name associated with the contact person
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.HumanName Name
            {
                get { return _Name; }
                set { _Name = value; OnPropertyChanged("Name"); }
            }
            
            private Hl7.Fhir.Model.STU3.HumanName _Name;
            
            /// <summary>
            /// A contact detail for the person
            /// </summary>
            [FhirElement("telecom", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.STU3.ContactPoint> Telecom
            {
                get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.STU3.ContactPoint>(); return _Telecom; }
                set { _Telecom = value; OnPropertyChanged("Telecom"); }
            }
            
            private List<Hl7.Fhir.Model.STU3.ContactPoint> _Telecom;
            
            /// <summary>
            /// Address for the contact person
            /// </summary>
            [FhirElement("address", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Address Address
            {
                get { return _Address; }
                set { _Address = value; OnPropertyChanged("Address"); }
            }
            
            private Hl7.Fhir.Model.Address _Address;
            
            /// <summary>
            /// male | female | other | unknown
            /// </summary>
            [FhirElement("gender", Order=80)]
            [DataMember]
            public Code<Hl7.Fhir.Model.AdministrativeGender> GenderElement
            {
                get { return _GenderElement; }
                set { _GenderElement = value; OnPropertyChanged("GenderElement"); }
            }
            
            private Code<Hl7.Fhir.Model.AdministrativeGender> _GenderElement;
            
            /// <summary>
            /// male | female | other | unknown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.AdministrativeGender? Gender
            {
                get { return GenderElement != null ? GenderElement.Value : null; }
                set
                {
                    if (value == null)
                        GenderElement = null;
                    else
                        GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(value);
                    OnPropertyChanged("Gender");
                }
            }
            
            /// <summary>
            /// Organization that is associated with the contact
            /// </summary>
            [FhirElement("organization", Order=90)]
            [CLSCompliant(false)]
            [References("Organization")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Organization
            {
                get { return _Organization; }
                set { _Organization = value; OnPropertyChanged("Organization"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Organization;
            
            /// <summary>
            /// The period during which this contact person or organization is valid to be contacted relating to this patient
            /// </summary>
            [FhirElement("period", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.Period _Period;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ContactComponent");
                base.Serialize(sink);
                sink.BeginList("relationship", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Relationship)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Name?.Serialize(sink);
                sink.BeginList("telecom", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Telecom)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("address", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Address?.Serialize(sink);
                sink.Element("gender", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); GenderElement?.Serialize(sink);
                sink.Element("organization", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Organization?.Serialize(sink);
                sink.Element("period", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Period?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Relationship = source.GetList<Hl7.Fhir.Model.CodeableConcept>("relationship", Hl7.Fhir.Model.Version.All);
                Name = source.GetProperty<Hl7.Fhir.Model.STU3.HumanName>("name", Hl7.Fhir.Model.Version.All);
                Telecom = source.GetList<Hl7.Fhir.Model.STU3.ContactPoint>("telecom", Hl7.Fhir.Model.Version.All);
                Address = source.GetProperty<Hl7.Fhir.Model.Address>("address", Hl7.Fhir.Model.Version.All);
                GenderElement = source.GetCodeEnumProperty<Hl7.Fhir.Model.AdministrativeGender>("gender", Hl7.Fhir.Model.Version.All);
                Organization = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("organization", Hl7.Fhir.Model.Version.All);
                Period = source.GetProperty<Hl7.Fhir.Model.Period>("period", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"relationship", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"name", typeof(Hl7.Fhir.Model.STU3.HumanName)},
                    {"telecom", typeof(Hl7.Fhir.Model.STU3.ContactPoint)},
                    {"address", typeof(Hl7.Fhir.Model.Address)},
                    {"gender", typeof(Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>)},
                    {"organization", typeof(Hl7.Fhir.Model.ResourceReference)},
                    {"period", typeof(Hl7.Fhir.Model.Period)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Relationship != null) dest.Relationship = new List<Hl7.Fhir.Model.CodeableConcept>(Relationship.DeepCopy());
                    if(Name != null) dest.Name = (Hl7.Fhir.Model.STU3.HumanName)Name.DeepCopy();
                    if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.STU3.ContactPoint>(Telecom.DeepCopy());
                    if(Address != null) dest.Address = (Hl7.Fhir.Model.Address)Address.DeepCopy();
                    if(GenderElement != null) dest.GenderElement = (Code<Hl7.Fhir.Model.AdministrativeGender>)GenderElement.DeepCopy();
                    if(Organization != null) dest.Organization = (Hl7.Fhir.Model.ResourceReference)Organization.DeepCopy();
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if( !DeepComparable.Matches(Name, otherT.Name)) return false;
                if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                if( !DeepComparable.Matches(Address, otherT.Address)) return false;
                if( !DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
                if( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                if( !DeepComparable.IsExactly(Address, otherT.Address)) return false;
                if( !DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
                if( !DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Relationship) { if (elem != null) yield return elem; }
                    if (Name != null) yield return Name;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                    if (Address != null) yield return Address;
                    if (GenderElement != null) yield return GenderElement;
                    if (Organization != null) yield return Organization;
                    if (Period != null) yield return Period;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Relationship) { if (elem != null) yield return new ElementValue("relationship", elem); }
                    if (Name != null) yield return new ElementValue("name", Name);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                    if (Address != null) yield return new ElementValue("address", Address);
                    if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                    if (Organization != null) yield return new ElementValue("organization", Organization);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "AnimalComponent")]
        [DataContract]
        public partial class AnimalComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "AnimalComponent"; } }
            
            /// <summary>
            /// E.g. Dog, Cow
            /// </summary>
            [FhirElement("species", InSummary=Hl7.Fhir.Model.Version.All, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Species
            {
                get { return _Species; }
                set { _Species = value; OnPropertyChanged("Species"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Species;
            
            /// <summary>
            /// E.g. Poodle, Angus
            /// </summary>
            [FhirElement("breed", InSummary=Hl7.Fhir.Model.Version.All, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Breed
            {
                get { return _Breed; }
                set { _Breed = value; OnPropertyChanged("Breed"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Breed;
            
            /// <summary>
            /// E.g. Neutered, Intact
            /// </summary>
            [FhirElement("genderStatus", InSummary=Hl7.Fhir.Model.Version.All, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept GenderStatus
            {
                get { return _GenderStatus; }
                set { _GenderStatus = value; OnPropertyChanged("GenderStatus"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _GenderStatus;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("AnimalComponent");
                base.Serialize(sink);
                sink.Element("species", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); Species?.Serialize(sink);
                sink.Element("breed", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Breed?.Serialize(sink);
                sink.Element("genderStatus", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); GenderStatus?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Species = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("species", Hl7.Fhir.Model.Version.All);
                Breed = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("breed", Hl7.Fhir.Model.Version.All);
                GenderStatus = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("genderStatus", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"species", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"breed", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"genderStatus", typeof(Hl7.Fhir.Model.CodeableConcept)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AnimalComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Species != null) dest.Species = (Hl7.Fhir.Model.CodeableConcept)Species.DeepCopy();
                    if(Breed != null) dest.Breed = (Hl7.Fhir.Model.CodeableConcept)Breed.DeepCopy();
                    if(GenderStatus != null) dest.GenderStatus = (Hl7.Fhir.Model.CodeableConcept)GenderStatus.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AnimalComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AnimalComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Species, otherT.Species)) return false;
                if( !DeepComparable.Matches(Breed, otherT.Breed)) return false;
                if( !DeepComparable.Matches(GenderStatus, otherT.GenderStatus)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AnimalComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Species, otherT.Species)) return false;
                if( !DeepComparable.IsExactly(Breed, otherT.Breed)) return false;
                if( !DeepComparable.IsExactly(GenderStatus, otherT.GenderStatus)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Species != null) yield return Species;
                    if (Breed != null) yield return Breed;
                    if (GenderStatus != null) yield return GenderStatus;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Species != null) yield return new ElementValue("species", Species);
                    if (Breed != null) yield return new ElementValue("breed", Breed);
                    if (GenderStatus != null) yield return new ElementValue("genderStatus", GenderStatus);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "CommunicationComponent")]
        [DataContract]
        public partial class CommunicationComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IPatientCommunicationComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "CommunicationComponent"; } }
            
            /// <summary>
            /// The language which can be used to communicate with the patient about his or her health
            /// </summary>
            [FhirElement("language", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Language
            {
                get { return _Language; }
                set { _Language = value; OnPropertyChanged("Language"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Language;
            
            /// <summary>
            /// Language preference indicator
            /// </summary>
            [FhirElement("preferred", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean PreferredElement
            {
                get { return _PreferredElement; }
                set { _PreferredElement = value; OnPropertyChanged("PreferredElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _PreferredElement;
            
            /// <summary>
            /// Language preference indicator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Preferred
            {
                get { return PreferredElement != null ? PreferredElement.Value : null; }
                set
                {
                    if (value == null)
                        PreferredElement = null;
                    else
                        PreferredElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Preferred");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("CommunicationComponent");
                base.Serialize(sink);
                sink.Element("language", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Language?.Serialize(sink);
                sink.Element("preferred", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); PreferredElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Language = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("language", Hl7.Fhir.Model.Version.All);
                PreferredElement = source.GetBooleanProperty("preferred", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"language", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"preferred", typeof(Hl7.Fhir.Model.FhirBoolean)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CommunicationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Language != null) dest.Language = (Hl7.Fhir.Model.CodeableConcept)Language.DeepCopy();
                    if(PreferredElement != null) dest.PreferredElement = (Hl7.Fhir.Model.FhirBoolean)PreferredElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CommunicationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CommunicationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Language, otherT.Language)) return false;
                if( !DeepComparable.Matches(PreferredElement, otherT.PreferredElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CommunicationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Language, otherT.Language)) return false;
                if( !DeepComparable.IsExactly(PreferredElement, otherT.PreferredElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Language != null) yield return Language;
                    if (PreferredElement != null) yield return PreferredElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Language != null) yield return new ElementValue("language", Language);
                    if (PreferredElement != null) yield return new ElementValue("preferred", PreferredElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "LinkComponent")]
        [DataContract]
        public partial class LinkComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IPatientLinkComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }
            
            /// <summary>
            /// The other patient or related person resource that the link refers to
            /// </summary>
            [FhirElement("other", InSummary=Hl7.Fhir.Model.Version.All, Order=40)]
            [CLSCompliant(false)]
            [References("Patient","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Other
            {
                get { return _Other; }
                set { _Other = value; OnPropertyChanged("Other"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Other;
            
            /// <summary>
            /// replaced-by | replaces | refer | seealso - type of link
            /// </summary>
            [FhirElement("type", InSummary=Hl7.Fhir.Model.Version.All, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.STU3.LinkType> TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.STU3.LinkType> _TypeElement;
            
            /// <summary>
            /// replaced-by | replaces | refer | seealso - type of link
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.STU3.LinkType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<Hl7.Fhir.Model.STU3.LinkType>(value);
                    OnPropertyChanged("Type");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("LinkComponent");
                base.Serialize(sink);
                sink.Element("other", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); Other?.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); TypeElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Other = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("other", Hl7.Fhir.Model.Version.All);
                TypeElement = source.GetCodeEnumProperty<Hl7.Fhir.Model.STU3.LinkType>("type", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"other", typeof(Hl7.Fhir.Model.ResourceReference)},
                    {"type", typeof(Hl7.Fhir.Model.Code<Hl7.Fhir.Model.STU3.LinkType>)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Other != null) dest.Other = (Hl7.Fhir.Model.ResourceReference)Other.DeepCopy();
                    if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.STU3.LinkType>)TypeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LinkComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Other, otherT.Other)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Other, otherT.Other)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Other != null) yield return Other;
                    if (TypeElement != null) yield return TypeElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Other != null) yield return new ElementValue("other", Other);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                }
            }
        
        
        }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IHumanName> Hl7.Fhir.Model.IPatient.Name { get { return Name; } }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IContactPoint> Hl7.Fhir.Model.IPatient.Telecom { get { return Telecom; } }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IPatientContactComponent> Hl7.Fhir.Model.IPatient.Contact { get { return Contact; } }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IPatientCommunicationComponent> Hl7.Fhir.Model.IPatient.Communication { get { return Communication; } }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IPatientLinkComponent> Hl7.Fhir.Model.IPatient.Link { get { return Link; } }
    
        
        /// <summary>
        /// An identifier for this patient
        /// </summary>
        [FhirElement("identifier", InSummary=Hl7.Fhir.Model.Version.All, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Whether this patient's record is in active use
        /// </summary>
        [FhirElement("active", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ActiveElement
        {
            get { return _ActiveElement; }
            set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ActiveElement;
        
        /// <summary>
        /// Whether this patient's record is in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }
        
        /// <summary>
        /// A name associated with the patient
        /// </summary>
        [FhirElement("name", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.HumanName> Name
        {
            get { if(_Name==null) _Name = new List<Hl7.Fhir.Model.STU3.HumanName>(); return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.HumanName> _Name;
        
        /// <summary>
        /// A contact detail for the individual
        /// </summary>
        [FhirElement("telecom", InSummary=Hl7.Fhir.Model.Version.All, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ContactPoint> Telecom
        {
            get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.STU3.ContactPoint>(); return _Telecom; }
            set { _Telecom = value; OnPropertyChanged("Telecom"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ContactPoint> _Telecom;
        
        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        [FhirElement("gender", InSummary=Hl7.Fhir.Model.Version.All, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AdministrativeGender> GenderElement
        {
            get { return _GenderElement; }
            set { _GenderElement = value; OnPropertyChanged("GenderElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AdministrativeGender> _GenderElement;
        
        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AdministrativeGender? Gender
        {
            get { return GenderElement != null ? GenderElement.Value : null; }
            set
            {
                if (value == null)
                    GenderElement = null;
                else
                    GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(value);
                OnPropertyChanged("Gender");
            }
        }
        
        /// <summary>
        /// The date of birth for the individual
        /// </summary>
        [FhirElement("birthDate", InSummary=Hl7.Fhir.Model.Version.All, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Date BirthDateElement
        {
            get { return _BirthDateElement; }
            set { _BirthDateElement = value; OnPropertyChanged("BirthDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _BirthDateElement;
        
        /// <summary>
        /// The date of birth for the individual
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string BirthDate
        {
            get { return BirthDateElement != null ? BirthDateElement.Value : null; }
            set
            {
                if (value == null)
                    BirthDateElement = null;
                else
                    BirthDateElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("BirthDate");
            }
        }
        
        /// <summary>
        /// Indicates if the individual is deceased or not
        /// </summary>
        [FhirElement("deceased", InSummary=Hl7.Fhir.Model.Version.All, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.FhirDateTime))]
        [DataMember]
        public Hl7.Fhir.Model.Element Deceased
        {
            get { return _Deceased; }
            set { _Deceased = value; OnPropertyChanged("Deceased"); }
        }
        
        private Hl7.Fhir.Model.Element _Deceased;
        
        /// <summary>
        /// Addresses for the individual
        /// </summary>
        [FhirElement("address", InSummary=Hl7.Fhir.Model.Version.All, Order=160)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Address> Address
        {
            get { if(_Address==null) _Address = new List<Hl7.Fhir.Model.Address>(); return _Address; }
            set { _Address = value; OnPropertyChanged("Address"); }
        }
        
        private List<Hl7.Fhir.Model.Address> _Address;
        
        /// <summary>
        /// Marital (civil) status of a patient
        /// </summary>
        [FhirElement("maritalStatus", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept MaritalStatus
        {
            get { return _MaritalStatus; }
            set { _MaritalStatus = value; OnPropertyChanged("MaritalStatus"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _MaritalStatus;
        
        /// <summary>
        /// Whether patient is part of a multiple birth
        /// </summary>
        [FhirElement("multipleBirth", Order=180, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Integer))]
        [DataMember]
        public Hl7.Fhir.Model.Element MultipleBirth
        {
            get { return _MultipleBirth; }
            set { _MultipleBirth = value; OnPropertyChanged("MultipleBirth"); }
        }
        
        private Hl7.Fhir.Model.Element _MultipleBirth;
        
        /// <summary>
        /// Image of the patient
        /// </summary>
        [FhirElement("photo", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Attachment> Photo
        {
            get { if(_Photo==null) _Photo = new List<Hl7.Fhir.Model.Attachment>(); return _Photo; }
            set { _Photo = value; OnPropertyChanged("Photo"); }
        }
        
        private List<Hl7.Fhir.Model.Attachment> _Photo;
        
        /// <summary>
        /// A contact party (e.g. guardian, partner, friend) for the patient
        /// </summary>
        [FhirElement("contact", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if(_Contact==null) _Contact = new List<ContactComponent>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<ContactComponent> _Contact;
        
        /// <summary>
        /// This patient is known to be an animal (non-human)
        /// </summary>
        [FhirElement("animal", InSummary=Hl7.Fhir.Model.Version.All, Order=210)]
        [CLSCompliant(false)]
        [DataMember]
        public AnimalComponent Animal
        {
            get { return _Animal; }
            set { _Animal = value; OnPropertyChanged("Animal"); }
        }
        
        private AnimalComponent _Animal;
        
        /// <summary>
        /// A list of Languages which may be used to communicate with the patient about his or her health
        /// </summary>
        [FhirElement("communication", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CommunicationComponent> Communication
        {
            get { if(_Communication==null) _Communication = new List<CommunicationComponent>(); return _Communication; }
            set { _Communication = value; OnPropertyChanged("Communication"); }
        }
        
        private List<CommunicationComponent> _Communication;
        
        /// <summary>
        /// Patient's nominated primary care provider
        /// </summary>
        [FhirElement("generalPractitioner", Order=230)]
        [CLSCompliant(false)]
        [References("Organization","Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> GeneralPractitioner
        {
            get { if(_GeneralPractitioner==null) _GeneralPractitioner = new List<Hl7.Fhir.Model.ResourceReference>(); return _GeneralPractitioner; }
            set { _GeneralPractitioner = value; OnPropertyChanged("GeneralPractitioner"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _GeneralPractitioner;
        
        /// <summary>
        /// Organization that is the custodian of the patient record
        /// </summary>
        [FhirElement("managingOrganization", InSummary=Hl7.Fhir.Model.Version.All, Order=240)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference ManagingOrganization
        {
            get { return _ManagingOrganization; }
            set { _ManagingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _ManagingOrganization;
        
        /// <summary>
        /// Link to another patient resource that concerns the same actual person
        /// </summary>
        [FhirElement("link", InSummary=Hl7.Fhir.Model.Version.All, Order=250)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LinkComponent> Link
        {
            get { if(_Link==null) _Link = new List<LinkComponent>(); return _Link; }
            set { _Link = value; OnPropertyChanged("Link"); }
        }
        
        private List<LinkComponent> _Link;
    
    
        public static ElementDefinitionConstraint[] Patient_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "pat-1",
                severity: ConstraintSeverity.Warning,
                expression: "contact.all(name.exists() or telecom.exists() or address.exists() or organization.exists())",
                human: "SHALL at least contain a contact's details or a reference to an organization",
                xpath: "exists(f:name) or exists(f:telecom) or exists(f:address) or exists(f:organization)"
            ),
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
            InvariantConstraints.AddRange(Patient_Constraints);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Patient;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
                if(Name != null) dest.Name = new List<Hl7.Fhir.Model.STU3.HumanName>(Name.DeepCopy());
                if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.STU3.ContactPoint>(Telecom.DeepCopy());
                if(GenderElement != null) dest.GenderElement = (Code<Hl7.Fhir.Model.AdministrativeGender>)GenderElement.DeepCopy();
                if(BirthDateElement != null) dest.BirthDateElement = (Hl7.Fhir.Model.Date)BirthDateElement.DeepCopy();
                if(Deceased != null) dest.Deceased = (Hl7.Fhir.Model.Element)Deceased.DeepCopy();
                if(Address != null) dest.Address = new List<Hl7.Fhir.Model.Address>(Address.DeepCopy());
                if(MaritalStatus != null) dest.MaritalStatus = (Hl7.Fhir.Model.CodeableConcept)MaritalStatus.DeepCopy();
                if(MultipleBirth != null) dest.MultipleBirth = (Hl7.Fhir.Model.Element)MultipleBirth.DeepCopy();
                if(Photo != null) dest.Photo = new List<Hl7.Fhir.Model.Attachment>(Photo.DeepCopy());
                if(Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if(Animal != null) dest.Animal = (AnimalComponent)Animal.DeepCopy();
                if(Communication != null) dest.Communication = new List<CommunicationComponent>(Communication.DeepCopy());
                if(GeneralPractitioner != null) dest.GeneralPractitioner = new List<Hl7.Fhir.Model.ResourceReference>(GeneralPractitioner.DeepCopy());
                if(ManagingOrganization != null) dest.ManagingOrganization = (Hl7.Fhir.Model.ResourceReference)ManagingOrganization.DeepCopy();
                if(Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Patient());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Patient;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if( !DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if( !DeepComparable.Matches(BirthDateElement, otherT.BirthDateElement)) return false;
            if( !DeepComparable.Matches(Deceased, otherT.Deceased)) return false;
            if( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if( !DeepComparable.Matches(MaritalStatus, otherT.MaritalStatus)) return false;
            if( !DeepComparable.Matches(MultipleBirth, otherT.MultipleBirth)) return false;
            if( !DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(Animal, otherT.Animal)) return false;
            if( !DeepComparable.Matches(Communication, otherT.Communication)) return false;
            if( !DeepComparable.Matches(GeneralPractitioner, otherT.GeneralPractitioner)) return false;
            if( !DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if( !DeepComparable.Matches(Link, otherT.Link)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Patient;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if( !DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if( !DeepComparable.IsExactly(BirthDateElement, otherT.BirthDateElement)) return false;
            if( !DeepComparable.IsExactly(Deceased, otherT.Deceased)) return false;
            if( !DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if( !DeepComparable.IsExactly(MaritalStatus, otherT.MaritalStatus)) return false;
            if( !DeepComparable.IsExactly(MultipleBirth, otherT.MultipleBirth)) return false;
            if( !DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(Animal, otherT.Animal)) return false;
            if( !DeepComparable.IsExactly(Communication, otherT.Communication)) return false;
            if( !DeepComparable.IsExactly(GeneralPractitioner, otherT.GeneralPractitioner)) return false;
            if( !DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if( !DeepComparable.IsExactly(Link, otherT.Link)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("Patient");
            base.Serialize(sink);
            sink.BeginList("identifier", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Identifier)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("active", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); ActiveElement?.Serialize(sink);
            sink.BeginList("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Name)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("telecom", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Telecom)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("gender", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); GenderElement?.Serialize(sink);
            sink.Element("birthDate", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); BirthDateElement?.Serialize(sink);
            sink.Element("deceased", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, true); Deceased?.Serialize(sink);
            sink.BeginList("address", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Address)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("maritalStatus", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); MaritalStatus?.Serialize(sink);
            sink.Element("multipleBirth", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, true); MultipleBirth?.Serialize(sink);
            sink.BeginList("photo", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Photo)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("contact", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Contact)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("animal", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Animal?.Serialize(sink);
            sink.BeginList("communication", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Communication)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("generalPractitioner", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in GeneralPractitioner)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("managingOrganization", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); ManagingOrganization?.Serialize(sink);
            sink.BeginList("link", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Link)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.End();
        }
        
        internal override void Parse(Serialization.IParserSource source)
        {
            base.Parse(source);
            Identifier = source.GetList<Hl7.Fhir.Model.Identifier>("identifier", Hl7.Fhir.Model.Version.All);
            ActiveElement = source.GetBooleanProperty("active", Hl7.Fhir.Model.Version.All);
            Name = source.GetList<Hl7.Fhir.Model.STU3.HumanName>("name", Hl7.Fhir.Model.Version.All);
            Telecom = source.GetList<Hl7.Fhir.Model.STU3.ContactPoint>("telecom", Hl7.Fhir.Model.Version.All);
            GenderElement = source.GetCodeEnumProperty<Hl7.Fhir.Model.AdministrativeGender>("gender", Hl7.Fhir.Model.Version.All);
            BirthDateElement = source.GetDateProperty("birthDate", Hl7.Fhir.Model.Version.All);
            Deceased = source.GetProperty<Hl7.Fhir.Model.Element>("deceased", Hl7.Fhir.Model.Version.All);
            Address = source.GetList<Hl7.Fhir.Model.Address>("address", Hl7.Fhir.Model.Version.All);
            MaritalStatus = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("maritalStatus", Hl7.Fhir.Model.Version.All);
            MultipleBirth = source.GetProperty<Hl7.Fhir.Model.Element>("multipleBirth", Hl7.Fhir.Model.Version.All);
            Photo = source.GetList<Hl7.Fhir.Model.Attachment>("photo", Hl7.Fhir.Model.Version.All);
            Contact = source.GetList<ContactComponent>("contact", Hl7.Fhir.Model.Version.All);
            Animal = source.GetProperty<AnimalComponent>("animal", Hl7.Fhir.Model.Version.All);
            Communication = source.GetList<CommunicationComponent>("communication", Hl7.Fhir.Model.Version.All);
            GeneralPractitioner = source.GetList<Hl7.Fhir.Model.ResourceReference>("generalPractitioner", Hl7.Fhir.Model.Version.All);
            ManagingOrganization = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("managingOrganization", Hl7.Fhir.Model.Version.All);
            Link = source.GetList<LinkComponent>("link", Hl7.Fhir.Model.Version.All);
        }
        
        internal override Type GetPropertyType(string fhirName)
        {
            if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
            return base.GetPropertyType(fhirName);
        }
        
        private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
        {
                {"identifier", typeof(Hl7.Fhir.Model.Identifier)},
                {"active", typeof(Hl7.Fhir.Model.FhirBoolean)},
                {"name", typeof(Hl7.Fhir.Model.STU3.HumanName)},
                {"telecom", typeof(Hl7.Fhir.Model.STU3.ContactPoint)},
                {"gender", typeof(Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>)},
                {"birthDate", typeof(Hl7.Fhir.Model.Date)},
                {"deceased", typeof(Hl7.Fhir.Model.Element)},
                {"address", typeof(Hl7.Fhir.Model.Address)},
                {"maritalStatus", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"multipleBirth", typeof(Hl7.Fhir.Model.Element)},
                {"photo", typeof(Hl7.Fhir.Model.Attachment)},
                {"contact", typeof(ContactComponent)},
                {"animal", typeof(AnimalComponent)},
                {"communication", typeof(CommunicationComponent)},
                {"generalPractitioner", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"managingOrganization", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"link", typeof(LinkComponent)},
        };
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                foreach (var elem in Name) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                if (GenderElement != null) yield return GenderElement;
                if (BirthDateElement != null) yield return BirthDateElement;
                if (Deceased != null) yield return Deceased;
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (MaritalStatus != null) yield return MaritalStatus;
                if (MultipleBirth != null) yield return MultipleBirth;
                foreach (var elem in Photo) { if (elem != null) yield return elem; }
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Animal != null) yield return Animal;
                foreach (var elem in Communication) { if (elem != null) yield return elem; }
                foreach (var elem in GeneralPractitioner) { if (elem != null) yield return elem; }
                if (ManagingOrganization != null) yield return ManagingOrganization;
                foreach (var elem in Link) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (BirthDateElement != null) yield return new ElementValue("birthDate", BirthDateElement);
                if (Deceased != null) yield return new ElementValue("deceased", Deceased);
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", elem); }
                if (MaritalStatus != null) yield return new ElementValue("maritalStatus", MaritalStatus);
                if (MultipleBirth != null) yield return new ElementValue("multipleBirth", MultipleBirth);
                foreach (var elem in Photo) { if (elem != null) yield return new ElementValue("photo", elem); }
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Animal != null) yield return new ElementValue("animal", Animal);
                foreach (var elem in Communication) { if (elem != null) yield return new ElementValue("communication", elem); }
                foreach (var elem in GeneralPractitioner) { if (elem != null) yield return new ElementValue("generalPractitioner", elem); }
                if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
                foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
            }
        }
    
    }

}
