using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Kind of specimen
    /// </summary>
    [FhirType("SpecimenDefinition", IsResource=true)]
    [DataContract]
    public partial class SpecimenDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SpecimenDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "SpecimenDefinition"; } }

        /// <summary>
        /// Degree of preference of a type of conditioned specimen
        /// (url: http://hl7.org/fhir/ValueSet/specimen-contained-preference)
        /// </summary>
        [FhirEnumeration("SpecimenContainedPreference")]
        public enum SpecimenContainedPreference
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/specimen-contained-preference)
            /// </summary>
            [EnumLiteral("preferred", "http://hl7.org/fhir/specimen-contained-preference"), Description("Preferred")]
            Preferred,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/specimen-contained-preference)
            /// </summary>
            [EnumLiteral("alternate", "http://hl7.org/fhir/specimen-contained-preference"), Description("Alternate")]
            Alternate,
        }


        [FhirType("SpecimenToLabComponent")]
        [DataContract]
        public partial class SpecimenToLabComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SpecimenToLabComponent"; } }

            /// <summary>
            /// Primary or secondary specimen
            /// </summary>
            [FhirElement("isDerived", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean IsDerivedElement
            {
                get { return _isDerivedElement; }
                set { _isDerivedElement = value; OnPropertyChanged("IsDerivedElement"); }
            }

            private FhirBoolean _isDerivedElement;

            /// <summary>
            /// Primary or secondary specimen
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? IsDerived
            {
                get { return IsDerivedElement != null ? IsDerivedElement.Value : null; }
                set
                {
                    if (value == null)
                        IsDerivedElement = null;
                    else
                        IsDerivedElement = new FhirBoolean(value);
                    OnPropertyChanged("IsDerived");
                }
            }

            /// <summary>
            /// Type of intended specimen
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// preferred | alternate
            /// </summary>
            [FhirElement("preference", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<SpecimenContainedPreference> PreferenceElement
            {
                get { return _preferenceElement; }
                set { _preferenceElement = value; OnPropertyChanged("PreferenceElement"); }
            }

            private Code<SpecimenContainedPreference> _preferenceElement;

            /// <summary>
            /// preferred | alternate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SpecimenContainedPreference? Preference
            {
                get { return PreferenceElement != null ? PreferenceElement.Value : null; }
                set
                {
                    if (value == null)
                        PreferenceElement = null;
                    else
                        PreferenceElement = new Code<SpecimenContainedPreference>(value);
                    OnPropertyChanged("Preference");
                }
            }

            /// <summary>
            /// Container material
            /// </summary>
            [FhirElement("containerMaterial", Order=70)]
            [DataMember]
            public CodeableConcept ContainerMaterial
            {
                get { return _containerMaterial; }
                set { _containerMaterial = value; OnPropertyChanged("ContainerMaterial"); }
            }

            private CodeableConcept _containerMaterial;

            /// <summary>
            /// Kind of container associated with the kind of specimen
            /// </summary>
            [FhirElement("containerType", Order=80)]
            [DataMember]
            public CodeableConcept ContainerType
            {
                get { return _containerType; }
                set { _containerType = value; OnPropertyChanged("ContainerType"); }
            }

            private CodeableConcept _containerType;

            /// <summary>
            /// Color of container cap
            /// </summary>
            [FhirElement("containerCap", Order=90)]
            [DataMember]
            public CodeableConcept ContainerCap
            {
                get { return _containerCap; }
                set { _containerCap = value; OnPropertyChanged("ContainerCap"); }
            }

            private CodeableConcept _containerCap;

            /// <summary>
            /// Container description
            /// </summary>
            [FhirElement("containerDescription", Order=100)]
            [DataMember]
            public FhirString ContainerDescriptionElement
            {
                get { return _containerDescriptionElement; }
                set { _containerDescriptionElement = value; OnPropertyChanged("ContainerDescriptionElement"); }
            }

            private FhirString _containerDescriptionElement;

            /// <summary>
            /// Container description
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ContainerDescription
            {
                get { return ContainerDescriptionElement != null ? ContainerDescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        ContainerDescriptionElement = null;
                    else
                        ContainerDescriptionElement = new FhirString(value);
                    OnPropertyChanged("ContainerDescription");
                }
            }

            /// <summary>
            /// Container capacity
            /// </summary>
            [FhirElement("containerCapacity", Order=110)]
            [DataMember]
            public SimpleQuantity ContainerCapacity
            {
                get { return _containerCapacity; }
                set { _containerCapacity = value; OnPropertyChanged("ContainerCapacity"); }
            }

            private SimpleQuantity _containerCapacity;

            /// <summary>
            /// Minimum volume
            /// </summary>
            [FhirElement("containerMinimumVolume", Order=120)]
            [DataMember]
            public SimpleQuantity ContainerMinimumVolume
            {
                get { return _containerMinimumVolume; }
                set { _containerMinimumVolume = value; OnPropertyChanged("ContainerMinimumVolume"); }
            }

            private SimpleQuantity _containerMinimumVolume;

            /// <summary>
            /// Additive associated with container
            /// </summary>
            [FhirElement("containerAdditive", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContainerAdditiveComponent> ContainerAdditive
            {
                get { if (_containerAdditive==null) _containerAdditive = new List<ContainerAdditiveComponent>(); return _containerAdditive; }
                set { _containerAdditive = value; OnPropertyChanged("ContainerAdditive"); }
            }

            private List<ContainerAdditiveComponent> _containerAdditive;

            /// <summary>
            /// Specimen container preparation
            /// </summary>
            [FhirElement("containerPreparation", Order=140)]
            [DataMember]
            public FhirString ContainerPreparationElement
            {
                get { return _containerPreparationElement; }
                set { _containerPreparationElement = value; OnPropertyChanged("ContainerPreparationElement"); }
            }

            private FhirString _containerPreparationElement;

            /// <summary>
            /// Specimen container preparation
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ContainerPreparation
            {
                get { return ContainerPreparationElement != null ? ContainerPreparationElement.Value : null; }
                set
                {
                    if (value == null)
                        ContainerPreparationElement = null;
                    else
                        ContainerPreparationElement = new FhirString(value);
                    OnPropertyChanged("ContainerPreparation");
                }
            }

            /// <summary>
            /// Specimen requirements
            /// </summary>
            [FhirElement("requirement", Order=150)]
            [DataMember]
            public FhirString RequirementElement
            {
                get { return _requirementElement; }
                set { _requirementElement = value; OnPropertyChanged("RequirementElement"); }
            }

            private FhirString _requirementElement;

            /// <summary>
            /// Specimen requirements
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Requirement
            {
                get { return RequirementElement != null ? RequirementElement.Value : null; }
                set
                {
                    if (value == null)
                        RequirementElement = null;
                    else
                        RequirementElement = new FhirString(value);
                    OnPropertyChanged("Requirement");
                }
            }

            /// <summary>
            /// Specimen retention time
            /// </summary>
            [FhirElement("retentionTime", Order=160)]
            [DataMember]
            public Duration RetentionTime
            {
                get { return _retentionTime; }
                set { _retentionTime = value; OnPropertyChanged("RetentionTime"); }
            }

            private Duration _retentionTime;

            /// <summary>
            /// Rejection criterion
            /// </summary>
            [FhirElement("rejectionCriterion", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> RejectionCriterion
            {
                get { if (_rejectionCriterion==null) _rejectionCriterion = new List<CodeableConcept>(); return _rejectionCriterion; }
                set { _rejectionCriterion = value; OnPropertyChanged("RejectionCriterion"); }
            }

            private List<CodeableConcept> _rejectionCriterion;

            /// <summary>
            /// Specimen handling before testing
            /// </summary>
            [FhirElement("handling", Order=180)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<HandlingComponent> Handling
            {
                get { if (_handling==null) _handling = new List<HandlingComponent>(); return _handling; }
                set { _handling = value; OnPropertyChanged("Handling"); }
            }

            private List<HandlingComponent> _handling;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SpecimenToLabComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (IsDerivedElement != null) dest.IsDerivedElement = (FhirBoolean)IsDerivedElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (PreferenceElement != null) dest.PreferenceElement = (Code<SpecimenContainedPreference>)PreferenceElement.DeepCopy();
                    if (ContainerMaterial != null) dest.ContainerMaterial = (CodeableConcept)ContainerMaterial.DeepCopy();
                    if (ContainerType != null) dest.ContainerType = (CodeableConcept)ContainerType.DeepCopy();
                    if (ContainerCap != null) dest.ContainerCap = (CodeableConcept)ContainerCap.DeepCopy();
                    if (ContainerDescriptionElement != null) dest.ContainerDescriptionElement = (FhirString)ContainerDescriptionElement.DeepCopy();
                    if (ContainerCapacity != null) dest.ContainerCapacity = (SimpleQuantity)ContainerCapacity.DeepCopy();
                    if (ContainerMinimumVolume != null) dest.ContainerMinimumVolume = (SimpleQuantity)ContainerMinimumVolume.DeepCopy();
                    if (ContainerAdditive != null) dest.ContainerAdditive = new List<ContainerAdditiveComponent>(ContainerAdditive.DeepCopy());
                    if (ContainerPreparationElement != null) dest.ContainerPreparationElement = (FhirString)ContainerPreparationElement.DeepCopy();
                    if (RequirementElement != null) dest.RequirementElement = (FhirString)RequirementElement.DeepCopy();
                    if (RetentionTime != null) dest.RetentionTime = (Duration)RetentionTime.DeepCopy();
                    if (RejectionCriterion != null) dest.RejectionCriterion = new List<CodeableConcept>(RejectionCriterion.DeepCopy());
                    if (Handling != null) dest.Handling = new List<HandlingComponent>(Handling.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SpecimenToLabComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SpecimenToLabComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(IsDerivedElement, otherT.IsDerivedElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(PreferenceElement, otherT.PreferenceElement)) return false;
                if (!DeepComparable.Matches(ContainerMaterial, otherT.ContainerMaterial)) return false;
                if (!DeepComparable.Matches(ContainerType, otherT.ContainerType)) return false;
                if (!DeepComparable.Matches(ContainerCap, otherT.ContainerCap)) return false;
                if (!DeepComparable.Matches(ContainerDescriptionElement, otherT.ContainerDescriptionElement)) return false;
                if (!DeepComparable.Matches(ContainerCapacity, otherT.ContainerCapacity)) return false;
                if (!DeepComparable.Matches(ContainerMinimumVolume, otherT.ContainerMinimumVolume)) return false;
                if ( !DeepComparable.Matches(ContainerAdditive, otherT.ContainerAdditive)) return false;
                if (!DeepComparable.Matches(ContainerPreparationElement, otherT.ContainerPreparationElement)) return false;
                if (!DeepComparable.Matches(RequirementElement, otherT.RequirementElement)) return false;
                if (!DeepComparable.Matches(RetentionTime, otherT.RetentionTime)) return false;
                if ( !DeepComparable.Matches(RejectionCriterion, otherT.RejectionCriterion)) return false;
                if ( !DeepComparable.Matches(Handling, otherT.Handling)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SpecimenToLabComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(IsDerivedElement, otherT.IsDerivedElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(PreferenceElement, otherT.PreferenceElement)) return false;
                if (!DeepComparable.IsExactly(ContainerMaterial, otherT.ContainerMaterial)) return false;
                if (!DeepComparable.IsExactly(ContainerType, otherT.ContainerType)) return false;
                if (!DeepComparable.IsExactly(ContainerCap, otherT.ContainerCap)) return false;
                if (!DeepComparable.IsExactly(ContainerDescriptionElement, otherT.ContainerDescriptionElement)) return false;
                if (!DeepComparable.IsExactly(ContainerCapacity, otherT.ContainerCapacity)) return false;
                if (!DeepComparable.IsExactly(ContainerMinimumVolume, otherT.ContainerMinimumVolume)) return false;
                if (!DeepComparable.IsExactly(ContainerAdditive, otherT.ContainerAdditive)) return false;
                if (!DeepComparable.IsExactly(ContainerPreparationElement, otherT.ContainerPreparationElement)) return false;
                if (!DeepComparable.IsExactly(RequirementElement, otherT.RequirementElement)) return false;
                if (!DeepComparable.IsExactly(RetentionTime, otherT.RetentionTime)) return false;
                if (!DeepComparable.IsExactly(RejectionCriterion, otherT.RejectionCriterion)) return false;
                if (!DeepComparable.IsExactly(Handling, otherT.Handling)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IsDerivedElement != null) yield return IsDerivedElement;
                    if (Type != null) yield return Type;
                    if (PreferenceElement != null) yield return PreferenceElement;
                    if (ContainerMaterial != null) yield return ContainerMaterial;
                    if (ContainerType != null) yield return ContainerType;
                    if (ContainerCap != null) yield return ContainerCap;
                    if (ContainerDescriptionElement != null) yield return ContainerDescriptionElement;
                    if (ContainerCapacity != null) yield return ContainerCapacity;
                    if (ContainerMinimumVolume != null) yield return ContainerMinimumVolume;
                    foreach (var elem in ContainerAdditive) { if (elem != null) yield return elem; }
                    if (ContainerPreparationElement != null) yield return ContainerPreparationElement;
                    if (RequirementElement != null) yield return RequirementElement;
                    if (RetentionTime != null) yield return RetentionTime;
                    foreach (var elem in RejectionCriterion) { if (elem != null) yield return elem; }
                    foreach (var elem in Handling) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IsDerivedElement != null) yield return new ElementValue("isDerived", IsDerivedElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (PreferenceElement != null) yield return new ElementValue("preference", PreferenceElement);
                    if (ContainerMaterial != null) yield return new ElementValue("containerMaterial", ContainerMaterial);
                    if (ContainerType != null) yield return new ElementValue("containerType", ContainerType);
                    if (ContainerCap != null) yield return new ElementValue("containerCap", ContainerCap);
                    if (ContainerDescriptionElement != null) yield return new ElementValue("containerDescription", ContainerDescriptionElement);
                    if (ContainerCapacity != null) yield return new ElementValue("containerCapacity", ContainerCapacity);
                    if (ContainerMinimumVolume != null) yield return new ElementValue("containerMinimumVolume", ContainerMinimumVolume);
                    foreach (var elem in ContainerAdditive) { if (elem != null) yield return new ElementValue("containerAdditive", elem); }
                    if (ContainerPreparationElement != null) yield return new ElementValue("containerPreparation", ContainerPreparationElement);
                    if (RequirementElement != null) yield return new ElementValue("requirement", RequirementElement);
                    if (RetentionTime != null) yield return new ElementValue("retentionTime", RetentionTime);
                    foreach (var elem in RejectionCriterion) { if (elem != null) yield return new ElementValue("rejectionCriterion", elem); }
                    foreach (var elem in Handling) { if (elem != null) yield return new ElementValue("handling", elem); }
                }
            }


        }


        [FhirType("ContainerAdditiveComponent")]
        [DataContract]
        public partial class ContainerAdditiveComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContainerAdditiveComponent"; } }

            /// <summary>
            /// Additive associated with container
            /// </summary>
            [FhirElement("additive", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Additive
            {
                get { return _additive; }
                set { _additive = value; OnPropertyChanged("Additive"); }
            }

            private Element _additive;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContainerAdditiveComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Additive != null) dest.Additive = (Element)Additive.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContainerAdditiveComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContainerAdditiveComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Additive, otherT.Additive)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContainerAdditiveComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Additive, otherT.Additive)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Additive != null) yield return Additive;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Additive != null) yield return new ElementValue("additive", Additive);
                }
            }


        }


        [FhirType("HandlingComponent")]
        [DataContract]
        public partial class HandlingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "HandlingComponent"; } }

            /// <summary>
            /// Conservation condition set
            /// </summary>
            [FhirElement("conditionSet", Order=40)]
            [DataMember]
            public CodeableConcept ConditionSet
            {
                get { return _conditionSet; }
                set { _conditionSet = value; OnPropertyChanged("ConditionSet"); }
            }

            private CodeableConcept _conditionSet;

            /// <summary>
            /// Temperature range
            /// </summary>
            [FhirElement("tempRange", Order=50)]
            [DataMember]
            public Range TempRange
            {
                get { return _tempRange; }
                set { _tempRange = value; OnPropertyChanged("TempRange"); }
            }

            private Range _tempRange;

            /// <summary>
            /// Maximum conservation time
            /// </summary>
            [FhirElement("maxDuration", Order=60)]
            [DataMember]
            public Duration MaxDuration
            {
                get { return _maxDuration; }
                set { _maxDuration = value; OnPropertyChanged("MaxDuration"); }
            }

            private Duration _maxDuration;

            /// <summary>
            /// Light exposure
            /// </summary>
            [FhirElement("lightExposure", Order=70)]
            [DataMember]
            public FhirString LightExposureElement
            {
                get { return _lightExposureElement; }
                set { _lightExposureElement = value; OnPropertyChanged("LightExposureElement"); }
            }

            private FhirString _lightExposureElement;

            /// <summary>
            /// Light exposure
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string LightExposure
            {
                get { return LightExposureElement != null ? LightExposureElement.Value : null; }
                set
                {
                    if (value == null)
                        LightExposureElement = null;
                    else
                        LightExposureElement = new FhirString(value);
                    OnPropertyChanged("LightExposure");
                }
            }

            /// <summary>
            /// Conservation instruction
            /// </summary>
            [FhirElement("instruction", Order=80)]
            [DataMember]
            public FhirString InstructionElement
            {
                get { return _instructionElement; }
                set { _instructionElement = value; OnPropertyChanged("InstructionElement"); }
            }

            private FhirString _instructionElement;

            /// <summary>
            /// Conservation instruction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Instruction
            {
                get { return InstructionElement != null ? InstructionElement.Value : null; }
                set
                {
                    if (value == null)
                        InstructionElement = null;
                    else
                        InstructionElement = new FhirString(value);
                    OnPropertyChanged("Instruction");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as HandlingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ConditionSet != null) dest.ConditionSet = (CodeableConcept)ConditionSet.DeepCopy();
                    if (TempRange != null) dest.TempRange = (Range)TempRange.DeepCopy();
                    if (MaxDuration != null) dest.MaxDuration = (Duration)MaxDuration.DeepCopy();
                    if (LightExposureElement != null) dest.LightExposureElement = (FhirString)LightExposureElement.DeepCopy();
                    if (InstructionElement != null) dest.InstructionElement = (FhirString)InstructionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new HandlingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as HandlingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ConditionSet, otherT.ConditionSet)) return false;
                if (!DeepComparable.Matches(TempRange, otherT.TempRange)) return false;
                if (!DeepComparable.Matches(MaxDuration, otherT.MaxDuration)) return false;
                if (!DeepComparable.Matches(LightExposureElement, otherT.LightExposureElement)) return false;
                if (!DeepComparable.Matches(InstructionElement, otherT.InstructionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as HandlingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ConditionSet, otherT.ConditionSet)) return false;
                if (!DeepComparable.IsExactly(TempRange, otherT.TempRange)) return false;
                if (!DeepComparable.IsExactly(MaxDuration, otherT.MaxDuration)) return false;
                if (!DeepComparable.IsExactly(LightExposureElement, otherT.LightExposureElement)) return false;
                if (!DeepComparable.IsExactly(InstructionElement, otherT.InstructionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ConditionSet != null) yield return ConditionSet;
                    if (TempRange != null) yield return TempRange;
                    if (MaxDuration != null) yield return MaxDuration;
                    if (LightExposureElement != null) yield return LightExposureElement;
                    if (InstructionElement != null) yield return InstructionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ConditionSet != null) yield return new ElementValue("conditionSet", ConditionSet);
                    if (TempRange != null) yield return new ElementValue("tempRange", TempRange);
                    if (MaxDuration != null) yield return new ElementValue("maxDuration", MaxDuration);
                    if (LightExposureElement != null) yield return new ElementValue("lightExposure", LightExposureElement);
                    if (InstructionElement != null) yield return new ElementValue("instruction", InstructionElement);
                }
            }


        }


        /// <summary>
        /// Business identifier of a kind of specimen
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
        /// Kind of material to collect
        /// </summary>
        [FhirElement("typeCollected", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept TypeCollected
        {
            get { return _typeCollected; }
            set { _typeCollected = value; OnPropertyChanged("TypeCollected"); }
        }

        private CodeableConcept _typeCollected;

        /// <summary>
        /// Patient preparation for collection
        /// </summary>
        [FhirElement("patientPreparation", Order=110)]
        [DataMember]
        public FhirString PatientPreparationElement
        {
            get { return _patientPreparationElement; }
            set { _patientPreparationElement = value; OnPropertyChanged("PatientPreparationElement"); }
        }

        private FhirString _patientPreparationElement;

        /// <summary>
        /// Patient preparation for collection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PatientPreparation
        {
            get { return PatientPreparationElement != null ? PatientPreparationElement.Value : null; }
            set
            {
                if (value == null)
                    PatientPreparationElement = null;
                else
                    PatientPreparationElement = new FhirString(value);
                OnPropertyChanged("PatientPreparation");
            }
        }

        /// <summary>
        /// Time aspect for collection
        /// </summary>
        [FhirElement("timeAspect", InSummary=true, Order=120)]
        [DataMember]
        public FhirString TimeAspectElement
        {
            get { return _timeAspectElement; }
            set { _timeAspectElement = value; OnPropertyChanged("TimeAspectElement"); }
        }

        private FhirString _timeAspectElement;

        /// <summary>
        /// Time aspect for collection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string TimeAspect
        {
            get { return TimeAspectElement != null ? TimeAspectElement.Value : null; }
            set
            {
                if (value == null)
                    TimeAspectElement = null;
                else
                    TimeAspectElement = new FhirString(value);
                OnPropertyChanged("TimeAspect");
            }
        }

        /// <summary>
        /// Specimen collection procedure
        /// </summary>
        [FhirElement("collection", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Collection
        {
            get { if (_collection==null) _collection = new List<CodeableConcept>(); return _collection; }
            set { _collection = value; OnPropertyChanged("Collection"); }
        }

        private List<CodeableConcept> _collection;

        /// <summary>
        /// Specimen in container intended for testing by lab
        /// </summary>
        [FhirElement("specimenToLab", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SpecimenToLabComponent> SpecimenToLab
        {
            get { if (_specimenToLab==null) _specimenToLab = new List<SpecimenToLabComponent>(); return _specimenToLab; }
            set { _specimenToLab = value; OnPropertyChanged("SpecimenToLab"); }
        }

        private List<SpecimenToLabComponent> _specimenToLab;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SpecimenDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (TypeCollected != null) dest.TypeCollected = (CodeableConcept)TypeCollected.DeepCopy();
                if (PatientPreparationElement != null) dest.PatientPreparationElement = (FhirString)PatientPreparationElement.DeepCopy();
                if (TimeAspectElement != null) dest.TimeAspectElement = (FhirString)TimeAspectElement.DeepCopy();
                if (Collection != null) dest.Collection = new List<CodeableConcept>(Collection.DeepCopy());
                if (SpecimenToLab != null) dest.SpecimenToLab = new List<SpecimenToLabComponent>(SpecimenToLab.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SpecimenDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SpecimenDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(TypeCollected, otherT.TypeCollected)) return false;
            if (!DeepComparable.Matches(PatientPreparationElement, otherT.PatientPreparationElement)) return false;
            if (!DeepComparable.Matches(TimeAspectElement, otherT.TimeAspectElement)) return false;
            if ( !DeepComparable.Matches(Collection, otherT.Collection)) return false;
            if ( !DeepComparable.Matches(SpecimenToLab, otherT.SpecimenToLab)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SpecimenDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(TypeCollected, otherT.TypeCollected)) return false;
            if (!DeepComparable.IsExactly(PatientPreparationElement, otherT.PatientPreparationElement)) return false;
            if (!DeepComparable.IsExactly(TimeAspectElement, otherT.TimeAspectElement)) return false;
            if (!DeepComparable.IsExactly(Collection, otherT.Collection)) return false;
            if (!DeepComparable.IsExactly(SpecimenToLab, otherT.SpecimenToLab)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (TypeCollected != null) yield return TypeCollected;
                if (PatientPreparationElement != null) yield return PatientPreparationElement;
                if (TimeAspectElement != null) yield return TimeAspectElement;
                foreach (var elem in Collection) { if (elem != null) yield return elem; }
                foreach (var elem in SpecimenToLab) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (TypeCollected != null) yield return new ElementValue("typeCollected", TypeCollected);
                if (PatientPreparationElement != null) yield return new ElementValue("patientPreparation", PatientPreparationElement);
                if (TimeAspectElement != null) yield return new ElementValue("timeAspect", TimeAspectElement);
                foreach (var elem in Collection) { if (elem != null) yield return new ElementValue("collection", elem); }
                foreach (var elem in SpecimenToLab) { if (elem != null) yield return new ElementValue("specimenToLab", elem); }
            }
        }

    }

}
