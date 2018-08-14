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
    /// The detailed description of a substance, typically at a level beyond what is used for prescribing
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "SubstanceSpecification", IsResource=true)]
    [DataContract]
    public partial class SubstanceSpecification : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubstanceSpecification; } }
        [NotMapped]
        public override string TypeName { get { return "SubstanceSpecification"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MoietyComponent")]
        [DataContract]
        public partial class MoietyComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MoietyComponent"; } }
            
            /// <summary>
            /// Role that the moiety is playing
            /// </summary>
            [FhirElement("role", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Role;
            
            /// <summary>
            /// Identifier by which this moiety substance is known
            /// </summary>
            [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Identifier;
            
            /// <summary>
            /// Textual name for this moiety substance
            /// </summary>
            [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Textual name for this moiety substance
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
            /// Stereochemistry type
            /// </summary>
            [FhirElement("stereochemistry", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Stereochemistry
            {
                get { return _Stereochemistry; }
                set { _Stereochemistry = value; OnPropertyChanged("Stereochemistry"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Stereochemistry;
            
            /// <summary>
            /// Optical activity type
            /// </summary>
            [FhirElement("opticalActivity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept OpticalActivity
            {
                get { return _OpticalActivity; }
                set { _OpticalActivity = value; OnPropertyChanged("OpticalActivity"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _OpticalActivity;
            
            /// <summary>
            /// Molecular formula
            /// </summary>
            [FhirElement("molecularFormula", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MolecularFormulaElement
            {
                get { return _MolecularFormulaElement; }
                set { _MolecularFormulaElement = value; OnPropertyChanged("MolecularFormulaElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MolecularFormulaElement;
            
            /// <summary>
            /// Molecular formula
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MolecularFormula
            {
                get { return MolecularFormulaElement != null ? MolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaElement = null;
                    else
                        MolecularFormulaElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MolecularFormula");
                }
            }
            
            /// <summary>
            /// Quantitative value for this moiety
            /// </summary>
            [FhirElement("amount", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AmountElement
            {
                get { return _AmountElement; }
                set { _AmountElement = value; OnPropertyChanged("AmountElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AmountElement;
            
            /// <summary>
            /// Quantitative value for this moiety
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MoietyComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.R4.CodeableConcept)Role.DeepCopy();
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Stereochemistry != null) dest.Stereochemistry = (Hl7.Fhir.Model.R4.CodeableConcept)Stereochemistry.DeepCopy();
                    if(OpticalActivity != null) dest.OpticalActivity = (Hl7.Fhir.Model.R4.CodeableConcept)OpticalActivity.DeepCopy();
                    if(MolecularFormulaElement != null) dest.MolecularFormulaElement = (Hl7.Fhir.Model.FhirString)MolecularFormulaElement.DeepCopy();
                    if(AmountElement != null) dest.AmountElement = (Hl7.Fhir.Model.FhirString)AmountElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MoietyComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MoietyComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.Matches(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.Matches(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MoietyComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.IsExactly(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.IsExactly(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Identifier != null) yield return Identifier;
                    if (NameElement != null) yield return NameElement;
                    if (Stereochemistry != null) yield return Stereochemistry;
                    if (OpticalActivity != null) yield return OpticalActivity;
                    if (MolecularFormulaElement != null) yield return MolecularFormulaElement;
                    if (AmountElement != null) yield return AmountElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", false, Role);
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (Stereochemistry != null) yield return new ElementValue("stereochemistry", false, Stereochemistry);
                    if (OpticalActivity != null) yield return new ElementValue("opticalActivity", false, OpticalActivity);
                    if (MolecularFormulaElement != null) yield return new ElementValue("molecularFormula", false, MolecularFormulaElement);
                    if (AmountElement != null) yield return new ElementValue("amount", false, AmountElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PropertyComponent")]
        [DataContract]
        public partial class PropertyComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PropertyComponent"; } }
            
            /// <summary>
            /// Description todo
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Description todo
            /// </summary>
            [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Name
            {
                get { return _Name; }
                set { _Name = value; OnPropertyChanged("Name"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Name;
            
            /// <summary>
            /// A field that should be used to capture parameters that were used in the measurement of a property
            /// </summary>
            [FhirElement("parameters", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ParametersElement
            {
                get { return _ParametersElement; }
                set { _ParametersElement = value; OnPropertyChanged("ParametersElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ParametersElement;
            
            /// <summary>
            /// A field that should be used to capture parameters that were used in the measurement of a property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Parameters
            {
                get { return ParametersElement != null ? ParametersElement.Value : null; }
                set
                {
                    if (value == null)
                        ParametersElement = null;
                    else
                        ParametersElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Parameters");
                }
            }
            
            /// <summary>
            /// Identifier for a substance upon which a defining property depends
            /// </summary>
            [FhirElement("substanceId", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier SubstanceId
            {
                get { return _SubstanceId; }
                set { _SubstanceId = value; OnPropertyChanged("SubstanceId"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _SubstanceId;
            
            /// <summary>
            /// Description todo
            /// </summary>
            [FhirElement("substanceName", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString SubstanceNameElement
            {
                get { return _SubstanceNameElement; }
                set { _SubstanceNameElement = value; OnPropertyChanged("SubstanceNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _SubstanceNameElement;
            
            /// <summary>
            /// Description todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string SubstanceName
            {
                get { return SubstanceNameElement != null ? SubstanceNameElement.Value : null; }
                set
                {
                    if (value == null)
                        SubstanceNameElement = null;
                    else
                        SubstanceNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("SubstanceName");
                }
            }
            
            /// <summary>
            /// Quantitative value for this property
            /// </summary>
            [FhirElement("amount", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AmountElement
            {
                get { return _AmountElement; }
                set { _AmountElement = value; OnPropertyChanged("AmountElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AmountElement;
            
            /// <summary>
            /// Quantitative value for this property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PropertyComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Name != null) dest.Name = (Hl7.Fhir.Model.R4.CodeableConcept)Name.DeepCopy();
                    if(ParametersElement != null) dest.ParametersElement = (Hl7.Fhir.Model.FhirString)ParametersElement.DeepCopy();
                    if(SubstanceId != null) dest.SubstanceId = (Hl7.Fhir.Model.R4.Identifier)SubstanceId.DeepCopy();
                    if(SubstanceNameElement != null) dest.SubstanceNameElement = (Hl7.Fhir.Model.FhirString)SubstanceNameElement.DeepCopy();
                    if(AmountElement != null) dest.AmountElement = (Hl7.Fhir.Model.FhirString)AmountElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PropertyComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Name, otherT.Name)) return false;
                if( !DeepComparable.Matches(ParametersElement, otherT.ParametersElement)) return false;
                if( !DeepComparable.Matches(SubstanceId, otherT.SubstanceId)) return false;
                if( !DeepComparable.Matches(SubstanceNameElement, otherT.SubstanceNameElement)) return false;
                if( !DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if( !DeepComparable.IsExactly(ParametersElement, otherT.ParametersElement)) return false;
                if( !DeepComparable.IsExactly(SubstanceId, otherT.SubstanceId)) return false;
                if( !DeepComparable.IsExactly(SubstanceNameElement, otherT.SubstanceNameElement)) return false;
                if( !DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Name != null) yield return Name;
                    if (ParametersElement != null) yield return ParametersElement;
                    if (SubstanceId != null) yield return SubstanceId;
                    if (SubstanceNameElement != null) yield return SubstanceNameElement;
                    if (AmountElement != null) yield return AmountElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Name != null) yield return new ElementValue("name", false, Name);
                    if (ParametersElement != null) yield return new ElementValue("parameters", false, ParametersElement);
                    if (SubstanceId != null) yield return new ElementValue("substanceId", false, SubstanceId);
                    if (SubstanceNameElement != null) yield return new ElementValue("substanceName", false, SubstanceNameElement);
                    if (AmountElement != null) yield return new ElementValue("amount", false, AmountElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "StructureComponent")]
        [DataContract]
        public partial class StructureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StructureComponent"; } }
            
            /// <summary>
            /// Stereochemistry type
            /// </summary>
            [FhirElement("stereochemistry", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Stereochemistry
            {
                get { return _Stereochemistry; }
                set { _Stereochemistry = value; OnPropertyChanged("Stereochemistry"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Stereochemistry;
            
            /// <summary>
            /// Optical activity type
            /// </summary>
            [FhirElement("opticalActivity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept OpticalActivity
            {
                get { return _OpticalActivity; }
                set { _OpticalActivity = value; OnPropertyChanged("OpticalActivity"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _OpticalActivity;
            
            /// <summary>
            /// Molecular formula
            /// </summary>
            [FhirElement("molecularFormula", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MolecularFormulaElement
            {
                get { return _MolecularFormulaElement; }
                set { _MolecularFormulaElement = value; OnPropertyChanged("MolecularFormulaElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MolecularFormulaElement;
            
            /// <summary>
            /// Molecular formula
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MolecularFormula
            {
                get { return MolecularFormulaElement != null ? MolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaElement = null;
                    else
                        MolecularFormulaElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MolecularFormula");
                }
            }
            
            /// <summary>
            /// Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical. and each moiety separated by a dot
            /// </summary>
            [FhirElement("molecularFormulaByMoiety", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MolecularFormulaByMoietyElement
            {
                get { return _MolecularFormulaByMoietyElement; }
                set { _MolecularFormulaByMoietyElement = value; OnPropertyChanged("MolecularFormulaByMoietyElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MolecularFormulaByMoietyElement;
            
            /// <summary>
            /// Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical. and each moiety separated by a dot
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MolecularFormulaByMoiety
            {
                get { return MolecularFormulaByMoietyElement != null ? MolecularFormulaByMoietyElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaByMoietyElement = null;
                    else
                        MolecularFormulaByMoietyElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MolecularFormulaByMoiety");
                }
            }
            
            /// <summary>
            /// Applicable for single substances that contain a radionuclide or a non-natural isotopic ratio
            /// </summary>
            [FhirElement("isotope", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<IsotopeComponent> Isotope
            {
                get { if(_Isotope==null) _Isotope = new List<IsotopeComponent>(); return _Isotope; }
                set { _Isotope = value; OnPropertyChanged("Isotope"); }
            }
            
            private List<IsotopeComponent> _Isotope;
            
            /// <summary>
            /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
            /// </summary>
            [FhirElement("molecularWeight", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public MolecularWeightComponent MolecularWeight
            {
                get { return _MolecularWeight; }
                set { _MolecularWeight = value; OnPropertyChanged("MolecularWeight"); }
            }
            
            private MolecularWeightComponent _MolecularWeight;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("referenceSource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> ReferenceSource
            {
                get { if(_ReferenceSource==null) _ReferenceSource = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ReferenceSource; }
                set { _ReferenceSource = value; OnPropertyChanged("ReferenceSource"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _ReferenceSource;
            
            /// <summary>
            /// Molectular structural representation
            /// </summary>
            [FhirElement("structuralRepresentation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StructuralRepresentationComponent> StructuralRepresentation
            {
                get { if(_StructuralRepresentation==null) _StructuralRepresentation = new List<StructuralRepresentationComponent>(); return _StructuralRepresentation; }
                set { _StructuralRepresentation = value; OnPropertyChanged("StructuralRepresentation"); }
            }
            
            private List<StructuralRepresentationComponent> _StructuralRepresentation;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StructureComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Stereochemistry != null) dest.Stereochemistry = (Hl7.Fhir.Model.R4.CodeableConcept)Stereochemistry.DeepCopy();
                    if(OpticalActivity != null) dest.OpticalActivity = (Hl7.Fhir.Model.R4.CodeableConcept)OpticalActivity.DeepCopy();
                    if(MolecularFormulaElement != null) dest.MolecularFormulaElement = (Hl7.Fhir.Model.FhirString)MolecularFormulaElement.DeepCopy();
                    if(MolecularFormulaByMoietyElement != null) dest.MolecularFormulaByMoietyElement = (Hl7.Fhir.Model.FhirString)MolecularFormulaByMoietyElement.DeepCopy();
                    if(Isotope != null) dest.Isotope = new List<IsotopeComponent>(Isotope.DeepCopy());
                    if(MolecularWeight != null) dest.MolecularWeight = (MolecularWeightComponent)MolecularWeight.DeepCopy();
                    if(ReferenceSource != null) dest.ReferenceSource = new List<Hl7.Fhir.Model.R4.ResourceReference>(ReferenceSource.DeepCopy());
                    if(StructuralRepresentation != null) dest.StructuralRepresentation = new List<StructuralRepresentationComponent>(StructuralRepresentation.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.Matches(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.Matches(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.Matches(MolecularFormulaByMoietyElement, otherT.MolecularFormulaByMoietyElement)) return false;
                if( !DeepComparable.Matches(Isotope, otherT.Isotope)) return false;
                if( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
                if( !DeepComparable.Matches(ReferenceSource, otherT.ReferenceSource)) return false;
                if( !DeepComparable.Matches(StructuralRepresentation, otherT.StructuralRepresentation)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructureComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.IsExactly(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.IsExactly(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.IsExactly(MolecularFormulaByMoietyElement, otherT.MolecularFormulaByMoietyElement)) return false;
                if( !DeepComparable.IsExactly(Isotope, otherT.Isotope)) return false;
                if( !DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
                if( !DeepComparable.IsExactly(ReferenceSource, otherT.ReferenceSource)) return false;
                if( !DeepComparable.IsExactly(StructuralRepresentation, otherT.StructuralRepresentation)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Stereochemistry != null) yield return Stereochemistry;
                    if (OpticalActivity != null) yield return OpticalActivity;
                    if (MolecularFormulaElement != null) yield return MolecularFormulaElement;
                    if (MolecularFormulaByMoietyElement != null) yield return MolecularFormulaByMoietyElement;
                    foreach (var elem in Isotope) { if (elem != null) yield return elem; }
                    if (MolecularWeight != null) yield return MolecularWeight;
                    foreach (var elem in ReferenceSource) { if (elem != null) yield return elem; }
                    foreach (var elem in StructuralRepresentation) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Stereochemistry != null) yield return new ElementValue("stereochemistry", false, Stereochemistry);
                    if (OpticalActivity != null) yield return new ElementValue("opticalActivity", false, OpticalActivity);
                    if (MolecularFormulaElement != null) yield return new ElementValue("molecularFormula", false, MolecularFormulaElement);
                    if (MolecularFormulaByMoietyElement != null) yield return new ElementValue("molecularFormulaByMoiety", false, MolecularFormulaByMoietyElement);
                    foreach (var elem in Isotope) { if (elem != null) yield return new ElementValue("isotope", true, elem); }
                    if (MolecularWeight != null) yield return new ElementValue("molecularWeight", false, MolecularWeight);
                    foreach (var elem in ReferenceSource) { if (elem != null) yield return new ElementValue("referenceSource", true, elem); }
                    foreach (var elem in StructuralRepresentation) { if (elem != null) yield return new ElementValue("structuralRepresentation", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "IsotopeComponent")]
        [DataContract]
        public partial class IsotopeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "IsotopeComponent"; } }
            
            /// <summary>
            /// Substance identifier for each non-natural or radioisotope
            /// </summary>
            [FhirElement("nuclideId", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier NuclideId
            {
                get { return _NuclideId; }
                set { _NuclideId = value; OnPropertyChanged("NuclideId"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _NuclideId;
            
            /// <summary>
            /// Substance name for each non-natural or radioisotope
            /// </summary>
            [FhirElement("nuclideName", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept NuclideName
            {
                get { return _NuclideName; }
                set { _NuclideName = value; OnPropertyChanged("NuclideName"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _NuclideName;
            
            /// <summary>
            /// The type of isotopic substitution present in a single substance
            /// </summary>
            [FhirElement("substitutionType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept SubstitutionType
            {
                get { return _SubstitutionType; }
                set { _SubstitutionType = value; OnPropertyChanged("SubstitutionType"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _SubstitutionType;
            
            /// <summary>
            /// Half life - for a non-natural nuclide
            /// </summary>
            [FhirElement("nuclideHalfLife", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Quantity NuclideHalfLife
            {
                get { return _NuclideHalfLife; }
                set { _NuclideHalfLife = value; OnPropertyChanged("NuclideHalfLife"); }
            }
            
            private Hl7.Fhir.Model.R4.Quantity _NuclideHalfLife;
            
            /// <summary>
            /// Quantitative values for this isotope
            /// </summary>
            [FhirElement("amount", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AmountElement
            {
                get { return _AmountElement; }
                set { _AmountElement = value; OnPropertyChanged("AmountElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AmountElement;
            
            /// <summary>
            /// Quantitative values for this isotope
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }
            
            /// <summary>
            /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
            /// </summary>
            [FhirElement("molecularWeight", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public MolecularWeightComponent MolecularWeight
            {
                get { return _MolecularWeight; }
                set { _MolecularWeight = value; OnPropertyChanged("MolecularWeight"); }
            }
            
            private MolecularWeightComponent _MolecularWeight;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IsotopeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NuclideId != null) dest.NuclideId = (Hl7.Fhir.Model.R4.Identifier)NuclideId.DeepCopy();
                    if(NuclideName != null) dest.NuclideName = (Hl7.Fhir.Model.R4.CodeableConcept)NuclideName.DeepCopy();
                    if(SubstitutionType != null) dest.SubstitutionType = (Hl7.Fhir.Model.R4.CodeableConcept)SubstitutionType.DeepCopy();
                    if(NuclideHalfLife != null) dest.NuclideHalfLife = (Hl7.Fhir.Model.R4.Quantity)NuclideHalfLife.DeepCopy();
                    if(AmountElement != null) dest.AmountElement = (Hl7.Fhir.Model.FhirString)AmountElement.DeepCopy();
                    if(MolecularWeight != null) dest.MolecularWeight = (MolecularWeightComponent)MolecularWeight.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new IsotopeComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IsotopeComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NuclideId, otherT.NuclideId)) return false;
                if( !DeepComparable.Matches(NuclideName, otherT.NuclideName)) return false;
                if( !DeepComparable.Matches(SubstitutionType, otherT.SubstitutionType)) return false;
                if( !DeepComparable.Matches(NuclideHalfLife, otherT.NuclideHalfLife)) return false;
                if( !DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
                if( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IsotopeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NuclideId, otherT.NuclideId)) return false;
                if( !DeepComparable.IsExactly(NuclideName, otherT.NuclideName)) return false;
                if( !DeepComparable.IsExactly(SubstitutionType, otherT.SubstitutionType)) return false;
                if( !DeepComparable.IsExactly(NuclideHalfLife, otherT.NuclideHalfLife)) return false;
                if( !DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
                if( !DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NuclideId != null) yield return NuclideId;
                    if (NuclideName != null) yield return NuclideName;
                    if (SubstitutionType != null) yield return SubstitutionType;
                    if (NuclideHalfLife != null) yield return NuclideHalfLife;
                    if (AmountElement != null) yield return AmountElement;
                    if (MolecularWeight != null) yield return MolecularWeight;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NuclideId != null) yield return new ElementValue("nuclideId", false, NuclideId);
                    if (NuclideName != null) yield return new ElementValue("nuclideName", false, NuclideName);
                    if (SubstitutionType != null) yield return new ElementValue("substitutionType", false, SubstitutionType);
                    if (NuclideHalfLife != null) yield return new ElementValue("nuclideHalfLife", false, NuclideHalfLife);
                    if (AmountElement != null) yield return new ElementValue("amount", false, AmountElement);
                    if (MolecularWeight != null) yield return new ElementValue("molecularWeight", false, MolecularWeight);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MolecularWeightComponent")]
        [DataContract]
        public partial class MolecularWeightComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MolecularWeightComponent"; } }
            
            /// <summary>
            /// The method by which the molecular weight was determined
            /// </summary>
            [FhirElement("method", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Method
            {
                get { return _Method; }
                set { _Method = value; OnPropertyChanged("Method"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Method;
            
            /// <summary>
            /// Type of molecular weight such as exact, average (also known as. number average), weight average
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field
            /// </summary>
            [FhirElement("amount", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AmountElement
            {
                get { return _AmountElement; }
                set { _AmountElement = value; OnPropertyChanged("AmountElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AmountElement;
            
            /// <summary>
            /// Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MolecularWeightComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Method != null) dest.Method = (Hl7.Fhir.Model.R4.CodeableConcept)Method.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(AmountElement != null) dest.AmountElement = (Hl7.Fhir.Model.FhirString)AmountElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MolecularWeightComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MolecularWeightComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Method, otherT.Method)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MolecularWeightComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Method != null) yield return Method;
                    if (Type != null) yield return Type;
                    if (AmountElement != null) yield return AmountElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Method != null) yield return new ElementValue("method", false, Method);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (AmountElement != null) yield return new ElementValue("amount", false, AmountElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "StructuralRepresentationComponent")]
        [DataContract]
        public partial class StructuralRepresentationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StructuralRepresentationComponent"; } }
            
            /// <summary>
            /// The type of structure (e.g. Full, Partial, Representative)
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// The structural representation as text string in a format e.g. InChI, SMILES, MOLFILE, CDX
            /// </summary>
            [FhirElement("representation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RepresentationElement
            {
                get { return _RepresentationElement; }
                set { _RepresentationElement = value; OnPropertyChanged("RepresentationElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RepresentationElement;
            
            /// <summary>
            /// The structural representation as text string in a format e.g. InChI, SMILES, MOLFILE, CDX
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Representation
            {
                get { return RepresentationElement != null ? RepresentationElement.Value : null; }
                set
                {
                    if (value == null)
                        RepresentationElement = null;
                    else
                        RepresentationElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Representation");
                }
            }
            
            /// <summary>
            /// An attached file with the structural representation
            /// </summary>
            [FhirElement("attachment", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Attachment Attachment
            {
                get { return _Attachment; }
                set { _Attachment = value; OnPropertyChanged("Attachment"); }
            }
            
            private Hl7.Fhir.Model.R4.Attachment _Attachment;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StructuralRepresentationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(RepresentationElement != null) dest.RepresentationElement = (Hl7.Fhir.Model.FhirString)RepresentationElement.DeepCopy();
                    if(Attachment != null) dest.Attachment = (Hl7.Fhir.Model.R4.Attachment)Attachment.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StructuralRepresentationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StructuralRepresentationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(RepresentationElement, otherT.RepresentationElement)) return false;
                if( !DeepComparable.Matches(Attachment, otherT.Attachment)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructuralRepresentationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(RepresentationElement, otherT.RepresentationElement)) return false;
                if( !DeepComparable.IsExactly(Attachment, otherT.Attachment)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (RepresentationElement != null) yield return RepresentationElement;
                    if (Attachment != null) yield return Attachment;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (RepresentationElement != null) yield return new ElementValue("representation", false, RepresentationElement);
                    if (Attachment != null) yield return new ElementValue("attachment", false, Attachment);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SubstanceCodeComponent")]
        [DataContract]
        public partial class SubstanceCodeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SubstanceCodeComponent"; } }
            
            /// <summary>
            /// The specific code
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// Status of the code assignment
            /// </summary>
            [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Status
            {
                get { return _Status; }
                set { _Status = value; OnPropertyChanged("Status"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Status;
            
            /// <summary>
            /// The date at which the code status is changed as part of the terminology maintenance
            /// </summary>
            [FhirElement("statusDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime StatusDateElement
            {
                get { return _StatusDateElement; }
                set { _StatusDateElement = value; OnPropertyChanged("StatusDateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _StatusDateElement;
            
            /// <summary>
            /// The date at which the code status is changed as part of the terminology maintenance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string StatusDate
            {
                get { return StatusDateElement != null ? StatusDateElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusDateElement = null;
                    else
                        StatusDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                    OnPropertyChanged("StatusDate");
                }
            }
            
            /// <summary>
            /// Any comment can be provided in this field, if necessary
            /// </summary>
            [FhirElement("comment", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CommentElement
            {
                get { return _CommentElement; }
                set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CommentElement;
            
            /// <summary>
            /// Any comment can be provided in this field, if necessary
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("referenceSource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> ReferenceSourceElement
            {
                get { if(_ReferenceSourceElement==null) _ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(); return _ReferenceSourceElement; }
                set { _ReferenceSourceElement = value; OnPropertyChanged("ReferenceSourceElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _ReferenceSourceElement;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> ReferenceSource
            {
                get { return ReferenceSourceElement != null ? ReferenceSourceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReferenceSourceElement = null;
                    else
                        ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("ReferenceSource");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceCodeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(Status != null) dest.Status = (Hl7.Fhir.Model.R4.CodeableConcept)Status.DeepCopy();
                    if(StatusDateElement != null) dest.StatusDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)StatusDateElement.DeepCopy();
                    if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
                    if(ReferenceSourceElement != null) dest.ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(ReferenceSourceElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubstanceCodeComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstanceCodeComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Status, otherT.Status)) return false;
                if( !DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
                if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
                if( !DeepComparable.Matches(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceCodeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if( !DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
                if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
                if( !DeepComparable.IsExactly(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Status != null) yield return Status;
                    if (StatusDateElement != null) yield return StatusDateElement;
                    if (CommentElement != null) yield return CommentElement;
                    foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (Status != null) yield return new ElementValue("status", false, Status);
                    if (StatusDateElement != null) yield return new ElementValue("statusDate", false, StatusDateElement);
                    if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
                    foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return new ElementValue("referenceSource", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SubstanceNameComponent")]
        [DataContract]
        public partial class SubstanceNameComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SubstanceNameComponent"; } }
            
            /// <summary>
            /// The actual name
            /// </summary>
            [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// The actual name
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
            /// Name type
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Language of the name
            /// </summary>
            [FhirElement("language", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Language
            {
                get { if(_Language==null) _Language = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Language; }
                set { _Language = value; OnPropertyChanged("Language"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Language;
            
            /// <summary>
            /// The use context of this name for example if there is a different name a drug active ingredient as opposed to a food colour additive
            /// </summary>
            [FhirElement("domain", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Domain
            {
                get { if(_Domain==null) _Domain = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Domain; }
                set { _Domain = value; OnPropertyChanged("Domain"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Domain;
            
            /// <summary>
            /// The jurisdiction where this name applies
            /// </summary>
            [FhirElement("jurisdiction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
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
            /// Details of the official nature of this name
            /// </summary>
            [FhirElement("officialName", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<OfficialNameComponent> OfficialName
            {
                get { if(_OfficialName==null) _OfficialName = new List<OfficialNameComponent>(); return _OfficialName; }
                set { _OfficialName = value; OnPropertyChanged("OfficialName"); }
            }
            
            private List<OfficialNameComponent> _OfficialName;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("referenceSource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> ReferenceSourceElement
            {
                get { if(_ReferenceSourceElement==null) _ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(); return _ReferenceSourceElement; }
                set { _ReferenceSourceElement = value; OnPropertyChanged("ReferenceSourceElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _ReferenceSourceElement;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> ReferenceSource
            {
                get { return ReferenceSourceElement != null ? ReferenceSourceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReferenceSourceElement = null;
                    else
                        ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("ReferenceSource");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceNameComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Language != null) dest.Language = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Language.DeepCopy());
                    if(Domain != null) dest.Domain = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Domain.DeepCopy());
                    if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Jurisdiction.DeepCopy());
                    if(OfficialName != null) dest.OfficialName = new List<OfficialNameComponent>(OfficialName.DeepCopy());
                    if(ReferenceSourceElement != null) dest.ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(ReferenceSourceElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubstanceNameComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstanceNameComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Language, otherT.Language)) return false;
                if( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
                if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.Matches(OfficialName, otherT.OfficialName)) return false;
                if( !DeepComparable.Matches(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceNameComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Language, otherT.Language)) return false;
                if( !DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
                if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.IsExactly(OfficialName, otherT.OfficialName)) return false;
                if( !DeepComparable.IsExactly(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (Type != null) yield return Type;
                    foreach (var elem in Language) { if (elem != null) yield return elem; }
                    foreach (var elem in Domain) { if (elem != null) yield return elem; }
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                    foreach (var elem in OfficialName) { if (elem != null) yield return elem; }
                    foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Language) { if (elem != null) yield return new ElementValue("language", true, elem); }
                    foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", true, elem); }
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                    foreach (var elem in OfficialName) { if (elem != null) yield return new ElementValue("officialName", true, elem); }
                    foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return new ElementValue("referenceSource", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "OfficialNameComponent")]
        [DataContract]
        public partial class OfficialNameComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "OfficialNameComponent"; } }
            
            /// <summary>
            /// Which authority uses this official name
            /// </summary>
            [FhirElement("authority", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Authority
            {
                get { return _Authority; }
                set { _Authority = value; OnPropertyChanged("Authority"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Authority;
            
            /// <summary>
            /// The status of the official name
            /// </summary>
            [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Status
            {
                get { return _Status; }
                set { _Status = value; OnPropertyChanged("Status"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Status;
            
            /// <summary>
            /// Date of official name change
            /// </summary>
            [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
            
            /// <summary>
            /// Date of official name change
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
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OfficialNameComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Authority != null) dest.Authority = (Hl7.Fhir.Model.R4.CodeableConcept)Authority.DeepCopy();
                    if(Status != null) dest.Status = (Hl7.Fhir.Model.R4.CodeableConcept)Status.DeepCopy();
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OfficialNameComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OfficialNameComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if( !DeepComparable.Matches(Status, otherT.Status)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OfficialNameComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Authority != null) yield return Authority;
                    if (Status != null) yield return Status;
                    if (DateElement != null) yield return DateElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Authority != null) yield return new ElementValue("authority", false, Authority);
                    if (Status != null) yield return new ElementValue("status", false, Status);
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Textual comment
        /// </summary>
        [FhirElement("comment", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CommentElement
        {
            get { return _CommentElement; }
            set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CommentElement;
        
        /// <summary>
        /// Textual comment
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if (value == null)
                    CommentElement = null;
                else
                    CommentElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Comment");
            }
        }
        
        /// <summary>
        /// Chemicals may be stoichiometric or non-stoichiometric
        /// </summary>
        [FhirElement("stoichiometric", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean StoichiometricElement
        {
            get { return _StoichiometricElement; }
            set { _StoichiometricElement = value; OnPropertyChanged("StoichiometricElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _StoichiometricElement;
        
        /// <summary>
        /// Chemicals may be stoichiometric or non-stoichiometric
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Stoichiometric
        {
            get { return StoichiometricElement != null ? StoichiometricElement.Value : null; }
            set
            {
                if (value == null)
                    StoichiometricElement = null;
                else
                    StoichiometricElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Stoichiometric");
            }
        }
        
        /// <summary>
        /// Identifier by which this substance is known
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
        /// <summary>
        /// High level categorization, e.g. polymer or nucleic acid
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Type;
        
        /// <summary>
        /// Supporting literature
        /// </summary>
        [FhirElement("referenceSource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> ReferenceSourceElement
        {
            get { if(_ReferenceSourceElement==null) _ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(); return _ReferenceSourceElement; }
            set { _ReferenceSourceElement = value; OnPropertyChanged("ReferenceSourceElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _ReferenceSourceElement;
        
        /// <summary>
        /// Supporting literature
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> ReferenceSource
        {
            get { return ReferenceSourceElement != null ? ReferenceSourceElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ReferenceSourceElement = null;
                else
                    ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("ReferenceSource");
            }
        }
        
        /// <summary>
        /// Moiety, for structural modifications
        /// </summary>
        [FhirElement("moiety", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MoietyComponent> Moiety
        {
            get { if(_Moiety==null) _Moiety = new List<MoietyComponent>(); return _Moiety; }
            set { _Moiety = value; OnPropertyChanged("Moiety"); }
        }
        
        private List<MoietyComponent> _Moiety;
        
        /// <summary>
        /// General specifications for this substance, including how it is related to other substances
        /// </summary>
        [FhirElement("property", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PropertyComponent> Property
        {
            get { if(_Property==null) _Property = new List<PropertyComponent>(); return _Property; }
            set { _Property = value; OnPropertyChanged("Property"); }
        }
        
        private List<PropertyComponent> _Property;
        
        /// <summary>
        /// General information detailing this substance
        /// </summary>
        [FhirElement("referenceInformation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [References("SubstanceReferenceInformation")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference ReferenceInformation
        {
            get { return _ReferenceInformation; }
            set { _ReferenceInformation = value; OnPropertyChanged("ReferenceInformation"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _ReferenceInformation;
        
        /// <summary>
        /// Structural information
        /// </summary>
        [FhirElement("structure", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [DataMember]
        public StructureComponent Structure
        {
            get { return _Structure; }
            set { _Structure = value; OnPropertyChanged("Structure"); }
        }
        
        private StructureComponent _Structure;
        
        /// <summary>
        /// Codes associated with the substance
        /// </summary>
        [FhirElement("substanceCode", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SubstanceCodeComponent> SubstanceCode
        {
            get { if(_SubstanceCode==null) _SubstanceCode = new List<SubstanceCodeComponent>(); return _SubstanceCode; }
            set { _SubstanceCode = value; OnPropertyChanged("SubstanceCode"); }
        }
        
        private List<SubstanceCodeComponent> _SubstanceCode;
        
        /// <summary>
        /// Names applicable to this substence
        /// </summary>
        [FhirElement("substanceName", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SubstanceNameComponent> SubstanceName
        {
            get { if(_SubstanceName==null) _SubstanceName = new List<SubstanceNameComponent>(); return _SubstanceName; }
            set { _SubstanceName = value; OnPropertyChanged("SubstanceName"); }
        }
        
        private List<SubstanceNameComponent> _SubstanceName;
        
        /// <summary>
        /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
        /// </summary>
        [FhirElement("molecularWeight", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MolecularWeightComponent> MolecularWeight
        {
            get { if(_MolecularWeight==null) _MolecularWeight = new List<MolecularWeightComponent>(); return _MolecularWeight; }
            set { _MolecularWeight = value; OnPropertyChanged("MolecularWeight"); }
        }
        
        private List<MolecularWeightComponent> _MolecularWeight;
        
        /// <summary>
        /// Data items specific to polymers
        /// </summary>
        [FhirElement("polymer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [References("SubstancePolymer")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Polymer
        {
            get { return _Polymer; }
            set { _Polymer = value; OnPropertyChanged("Polymer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Polymer;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstanceSpecification;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
                if(StoichiometricElement != null) dest.StoichiometricElement = (Hl7.Fhir.Model.FhirBoolean)StoichiometricElement.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                if(ReferenceSourceElement != null) dest.ReferenceSourceElement = new List<Hl7.Fhir.Model.FhirString>(ReferenceSourceElement.DeepCopy());
                if(Moiety != null) dest.Moiety = new List<MoietyComponent>(Moiety.DeepCopy());
                if(Property != null) dest.Property = new List<PropertyComponent>(Property.DeepCopy());
                if(ReferenceInformation != null) dest.ReferenceInformation = (Hl7.Fhir.Model.R4.ResourceReference)ReferenceInformation.DeepCopy();
                if(Structure != null) dest.Structure = (StructureComponent)Structure.DeepCopy();
                if(SubstanceCode != null) dest.SubstanceCode = new List<SubstanceCodeComponent>(SubstanceCode.DeepCopy());
                if(SubstanceName != null) dest.SubstanceName = new List<SubstanceNameComponent>(SubstanceName.DeepCopy());
                if(MolecularWeight != null) dest.MolecularWeight = new List<MolecularWeightComponent>(MolecularWeight.DeepCopy());
                if(Polymer != null) dest.Polymer = (Hl7.Fhir.Model.R4.ResourceReference)Polymer.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SubstanceSpecification());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubstanceSpecification;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if( !DeepComparable.Matches(StoichiometricElement, otherT.StoichiometricElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            if( !DeepComparable.Matches(Moiety, otherT.Moiety)) return false;
            if( !DeepComparable.Matches(Property, otherT.Property)) return false;
            if( !DeepComparable.Matches(ReferenceInformation, otherT.ReferenceInformation)) return false;
            if( !DeepComparable.Matches(Structure, otherT.Structure)) return false;
            if( !DeepComparable.Matches(SubstanceCode, otherT.SubstanceCode)) return false;
            if( !DeepComparable.Matches(SubstanceName, otherT.SubstanceName)) return false;
            if( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
            if( !DeepComparable.Matches(Polymer, otherT.Polymer)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstanceSpecification;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if( !DeepComparable.IsExactly(StoichiometricElement, otherT.StoichiometricElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            if( !DeepComparable.IsExactly(Moiety, otherT.Moiety)) return false;
            if( !DeepComparable.IsExactly(Property, otherT.Property)) return false;
            if( !DeepComparable.IsExactly(ReferenceInformation, otherT.ReferenceInformation)) return false;
            if( !DeepComparable.IsExactly(Structure, otherT.Structure)) return false;
            if( !DeepComparable.IsExactly(SubstanceCode, otherT.SubstanceCode)) return false;
            if( !DeepComparable.IsExactly(SubstanceName, otherT.SubstanceName)) return false;
            if( !DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
            if( !DeepComparable.IsExactly(Polymer, otherT.Polymer)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (CommentElement != null) yield return CommentElement;
                if (StoichiometricElement != null) yield return StoichiometricElement;
                if (Identifier != null) yield return Identifier;
                if (Type != null) yield return Type;
                foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return elem; }
                foreach (var elem in Moiety) { if (elem != null) yield return elem; }
                foreach (var elem in Property) { if (elem != null) yield return elem; }
                if (ReferenceInformation != null) yield return ReferenceInformation;
                if (Structure != null) yield return Structure;
                foreach (var elem in SubstanceCode) { if (elem != null) yield return elem; }
                foreach (var elem in SubstanceName) { if (elem != null) yield return elem; }
                foreach (var elem in MolecularWeight) { if (elem != null) yield return elem; }
                if (Polymer != null) yield return Polymer;
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
                if (StoichiometricElement != null) yield return new ElementValue("stoichiometric", false, StoichiometricElement);
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (Type != null) yield return new ElementValue("type", false, Type);
                foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return new ElementValue("referenceSource", true, elem); }
                foreach (var elem in Moiety) { if (elem != null) yield return new ElementValue("moiety", true, elem); }
                foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", true, elem); }
                if (ReferenceInformation != null) yield return new ElementValue("referenceInformation", false, ReferenceInformation);
                if (Structure != null) yield return new ElementValue("structure", false, Structure);
                foreach (var elem in SubstanceCode) { if (elem != null) yield return new ElementValue("substanceCode", true, elem); }
                foreach (var elem in SubstanceName) { if (elem != null) yield return new ElementValue("substanceName", true, elem); }
                foreach (var elem in MolecularWeight) { if (elem != null) yield return new ElementValue("molecularWeight", true, elem); }
                if (Polymer != null) yield return new ElementValue("polymer", false, Polymer);
            }
        }
    
    }

}
