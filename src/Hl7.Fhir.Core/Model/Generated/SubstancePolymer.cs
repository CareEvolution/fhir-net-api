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
    /// Todo
    /// </summary>
    [FhirType("SubstancePolymer", IsResource=true)]
    [DataContract]
    public partial class SubstancePolymer : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubstancePolymer; } }
        [NotMapped]
        public override string TypeName { get { return "SubstancePolymer"; } }


        [FhirType("MonomerSetComponent")]
        [DataContract]
        public partial class MonomerSetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MonomerSetComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("ratioType", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept RatioType
            {
                get { return _ratioType; }
                set { _ratioType = value; OnPropertyChanged("RatioType"); }
            }

            private CodeableConcept _ratioType;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("startingMaterial", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StartingMaterialComponent> StartingMaterial
            {
                get { if (_startingMaterial==null) _startingMaterial = new List<StartingMaterialComponent>(); return _startingMaterial; }
                set { _startingMaterial = value; OnPropertyChanged("StartingMaterial"); }
            }

            private List<StartingMaterialComponent> _startingMaterial;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MonomerSetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RatioType != null) dest.RatioType = (CodeableConcept)RatioType.DeepCopy();
                    if (StartingMaterial != null) dest.StartingMaterial = new List<StartingMaterialComponent>(StartingMaterial.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MonomerSetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MonomerSetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RatioType, otherT.RatioType)) return false;
                if ( !DeepComparable.Matches(StartingMaterial, otherT.StartingMaterial)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MonomerSetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RatioType, otherT.RatioType)) return false;
                if (!DeepComparable.IsExactly(StartingMaterial, otherT.StartingMaterial)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RatioType != null) yield return RatioType;
                    foreach (var elem in StartingMaterial) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RatioType != null) yield return new ElementValue("ratioType", RatioType);
                    foreach (var elem in StartingMaterial) { if (elem != null) yield return new ElementValue("startingMaterial", elem); }
                }
            }


        }


        [FhirType("StartingMaterialComponent")]
        [DataContract]
        public partial class StartingMaterialComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StartingMaterialComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("material", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Material
            {
                get { return _material; }
                set { _material = value; OnPropertyChanged("Material"); }
            }

            private CodeableConcept _material;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("isDefining", InSummary=true, Order=60)]
            [DataMember]
            public FhirBoolean IsDefiningElement
            {
                get { return _isDefiningElement; }
                set { _isDefiningElement = value; OnPropertyChanged("IsDefiningElement"); }
            }

            private FhirBoolean _isDefiningElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? IsDefining
            {
                get { return IsDefiningElement != null ? IsDefiningElement.Value : null; }
                set
                {
                    if (value == null)
                        IsDefiningElement = null;
                    else
                        IsDefiningElement = new FhirBoolean(value);
                    OnPropertyChanged("IsDefining");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=70)]
            [DataMember]
            public SubstanceAmount Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private SubstanceAmount _amount;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StartingMaterialComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Material != null) dest.Material = (CodeableConcept)Material.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (IsDefiningElement != null) dest.IsDefiningElement = (FhirBoolean)IsDefiningElement.DeepCopy();
                    if (Amount != null) dest.Amount = (SubstanceAmount)Amount.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StartingMaterialComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StartingMaterialComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Material, otherT.Material)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StartingMaterialComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Material, otherT.Material)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Material != null) yield return Material;
                    if (Type != null) yield return Type;
                    if (IsDefiningElement != null) yield return IsDefiningElement;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Material != null) yield return new ElementValue("material", Material);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (IsDefiningElement != null) yield return new ElementValue("isDefining", IsDefiningElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                }
            }


        }


        [FhirType("RepeatComponent")]
        [DataContract]
        public partial class RepeatComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RepeatComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("numberOfUnits", InSummary=true, Order=40)]
            [DataMember]
            public Integer NumberOfUnitsElement
            {
                get { return _numberOfUnitsElement; }
                set { _numberOfUnitsElement = value; OnPropertyChanged("NumberOfUnitsElement"); }
            }

            private Integer _numberOfUnitsElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? NumberOfUnits
            {
                get { return NumberOfUnitsElement != null ? NumberOfUnitsElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberOfUnitsElement = null;
                    else
                        NumberOfUnitsElement = new Integer(value);
                    OnPropertyChanged("NumberOfUnits");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("averageMolecularFormula", InSummary=true, Order=50)]
            [DataMember]
            public FhirString AverageMolecularFormulaElement
            {
                get { return _averageMolecularFormulaElement; }
                set { _averageMolecularFormulaElement = value; OnPropertyChanged("AverageMolecularFormulaElement"); }
            }

            private FhirString _averageMolecularFormulaElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string AverageMolecularFormula
            {
                get { return AverageMolecularFormulaElement != null ? AverageMolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        AverageMolecularFormulaElement = null;
                    else
                        AverageMolecularFormulaElement = new FhirString(value);
                    OnPropertyChanged("AverageMolecularFormula");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("repeatUnitAmountType", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept RepeatUnitAmountType
            {
                get { return _repeatUnitAmountType; }
                set { _repeatUnitAmountType = value; OnPropertyChanged("RepeatUnitAmountType"); }
            }

            private CodeableConcept _repeatUnitAmountType;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("repeatUnit", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RepeatUnitComponent> RepeatUnit
            {
                get { if (_repeatUnit==null) _repeatUnit = new List<RepeatUnitComponent>(); return _repeatUnit; }
                set { _repeatUnit = value; OnPropertyChanged("RepeatUnit"); }
            }

            private List<RepeatUnitComponent> _repeatUnit;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RepeatComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NumberOfUnitsElement != null) dest.NumberOfUnitsElement = (Integer)NumberOfUnitsElement.DeepCopy();
                    if (AverageMolecularFormulaElement != null) dest.AverageMolecularFormulaElement = (FhirString)AverageMolecularFormulaElement.DeepCopy();
                    if (RepeatUnitAmountType != null) dest.RepeatUnitAmountType = (CodeableConcept)RepeatUnitAmountType.DeepCopy();
                    if (RepeatUnit != null) dest.RepeatUnit = new List<RepeatUnitComponent>(RepeatUnit.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RepeatComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RepeatComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NumberOfUnitsElement, otherT.NumberOfUnitsElement)) return false;
                if (!DeepComparable.Matches(AverageMolecularFormulaElement, otherT.AverageMolecularFormulaElement)) return false;
                if (!DeepComparable.Matches(RepeatUnitAmountType, otherT.RepeatUnitAmountType)) return false;
                if ( !DeepComparable.Matches(RepeatUnit, otherT.RepeatUnit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RepeatComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NumberOfUnitsElement, otherT.NumberOfUnitsElement)) return false;
                if (!DeepComparable.IsExactly(AverageMolecularFormulaElement, otherT.AverageMolecularFormulaElement)) return false;
                if (!DeepComparable.IsExactly(RepeatUnitAmountType, otherT.RepeatUnitAmountType)) return false;
                if (!DeepComparable.IsExactly(RepeatUnit, otherT.RepeatUnit)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NumberOfUnitsElement != null) yield return NumberOfUnitsElement;
                    if (AverageMolecularFormulaElement != null) yield return AverageMolecularFormulaElement;
                    if (RepeatUnitAmountType != null) yield return RepeatUnitAmountType;
                    foreach (var elem in RepeatUnit) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NumberOfUnitsElement != null) yield return new ElementValue("numberOfUnits", NumberOfUnitsElement);
                    if (AverageMolecularFormulaElement != null) yield return new ElementValue("averageMolecularFormula", AverageMolecularFormulaElement);
                    if (RepeatUnitAmountType != null) yield return new ElementValue("repeatUnitAmountType", RepeatUnitAmountType);
                    foreach (var elem in RepeatUnit) { if (elem != null) yield return new ElementValue("repeatUnit", elem); }
                }
            }


        }


        [FhirType("RepeatUnitComponent")]
        [DataContract]
        public partial class RepeatUnitComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RepeatUnitComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("orientationOfPolymerisation", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept OrientationOfPolymerisation
            {
                get { return _orientationOfPolymerisation; }
                set { _orientationOfPolymerisation = value; OnPropertyChanged("OrientationOfPolymerisation"); }
            }

            private CodeableConcept _orientationOfPolymerisation;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("repeatUnit", InSummary=true, Order=50)]
            [DataMember]
            public FhirString RepeatUnitElement
            {
                get { return _repeatUnitElement; }
                set { _repeatUnitElement = value; OnPropertyChanged("RepeatUnitElement"); }
            }

            private FhirString _repeatUnitElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RepeatUnit
            {
                get { return RepeatUnitElement != null ? RepeatUnitElement.Value : null; }
                set
                {
                    if (value == null)
                        RepeatUnitElement = null;
                    else
                        RepeatUnitElement = new FhirString(value);
                    OnPropertyChanged("RepeatUnit");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=60)]
            [DataMember]
            public SubstanceAmount Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private SubstanceAmount _amount;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("degreeOfPolymerisation", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DegreeOfPolymerisationComponent> DegreeOfPolymerisation
            {
                get { if (_degreeOfPolymerisation==null) _degreeOfPolymerisation = new List<DegreeOfPolymerisationComponent>(); return _degreeOfPolymerisation; }
                set { _degreeOfPolymerisation = value; OnPropertyChanged("DegreeOfPolymerisation"); }
            }

            private List<DegreeOfPolymerisationComponent> _degreeOfPolymerisation;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("structuralRepresentation", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StructuralRepresentationComponent> StructuralRepresentation
            {
                get { if (_structuralRepresentation==null) _structuralRepresentation = new List<StructuralRepresentationComponent>(); return _structuralRepresentation; }
                set { _structuralRepresentation = value; OnPropertyChanged("StructuralRepresentation"); }
            }

            private List<StructuralRepresentationComponent> _structuralRepresentation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RepeatUnitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (OrientationOfPolymerisation != null) dest.OrientationOfPolymerisation = (CodeableConcept)OrientationOfPolymerisation.DeepCopy();
                    if (RepeatUnitElement != null) dest.RepeatUnitElement = (FhirString)RepeatUnitElement.DeepCopy();
                    if (Amount != null) dest.Amount = (SubstanceAmount)Amount.DeepCopy();
                    if (DegreeOfPolymerisation != null) dest.DegreeOfPolymerisation = new List<DegreeOfPolymerisationComponent>(DegreeOfPolymerisation.DeepCopy());
                    if (StructuralRepresentation != null) dest.StructuralRepresentation = new List<StructuralRepresentationComponent>(StructuralRepresentation.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RepeatUnitComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RepeatUnitComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(OrientationOfPolymerisation, otherT.OrientationOfPolymerisation)) return false;
                if (!DeepComparable.Matches(RepeatUnitElement, otherT.RepeatUnitElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if ( !DeepComparable.Matches(DegreeOfPolymerisation, otherT.DegreeOfPolymerisation)) return false;
                if ( !DeepComparable.Matches(StructuralRepresentation, otherT.StructuralRepresentation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RepeatUnitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(OrientationOfPolymerisation, otherT.OrientationOfPolymerisation)) return false;
                if (!DeepComparable.IsExactly(RepeatUnitElement, otherT.RepeatUnitElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(DegreeOfPolymerisation, otherT.DegreeOfPolymerisation)) return false;
                if (!DeepComparable.IsExactly(StructuralRepresentation, otherT.StructuralRepresentation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (OrientationOfPolymerisation != null) yield return OrientationOfPolymerisation;
                    if (RepeatUnitElement != null) yield return RepeatUnitElement;
                    if (Amount != null) yield return Amount;
                    foreach (var elem in DegreeOfPolymerisation) { if (elem != null) yield return elem; }
                    foreach (var elem in StructuralRepresentation) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (OrientationOfPolymerisation != null) yield return new ElementValue("orientationOfPolymerisation", OrientationOfPolymerisation);
                    if (RepeatUnitElement != null) yield return new ElementValue("repeatUnit", RepeatUnitElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    foreach (var elem in DegreeOfPolymerisation) { if (elem != null) yield return new ElementValue("degreeOfPolymerisation", elem); }
                    foreach (var elem in StructuralRepresentation) { if (elem != null) yield return new ElementValue("structuralRepresentation", elem); }
                }
            }


        }


        [FhirType("DegreeOfPolymerisationComponent")]
        [DataContract]
        public partial class DegreeOfPolymerisationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DegreeOfPolymerisationComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("degree", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Degree
            {
                get { return _degree; }
                set { _degree = value; OnPropertyChanged("Degree"); }
            }

            private CodeableConcept _degree;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public SubstanceAmount Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private SubstanceAmount _amount;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DegreeOfPolymerisationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Degree != null) dest.Degree = (CodeableConcept)Degree.DeepCopy();
                    if (Amount != null) dest.Amount = (SubstanceAmount)Amount.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DegreeOfPolymerisationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DegreeOfPolymerisationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Degree, otherT.Degree)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DegreeOfPolymerisationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Degree, otherT.Degree)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Degree != null) yield return Degree;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Degree != null) yield return new ElementValue("degree", Degree);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                }
            }


        }


        [FhirType("StructuralRepresentationComponent")]
        [DataContract]
        public partial class StructuralRepresentationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StructuralRepresentationComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("representation", InSummary=true, Order=50)]
            [DataMember]
            public FhirString RepresentationElement
            {
                get { return _representationElement; }
                set { _representationElement = value; OnPropertyChanged("RepresentationElement"); }
            }

            private FhirString _representationElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Representation
            {
                get { return RepresentationElement != null ? RepresentationElement.Value : null; }
                set
                {
                    if (value == null)
                        RepresentationElement = null;
                    else
                        RepresentationElement = new FhirString(value);
                    OnPropertyChanged("Representation");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("attachment", InSummary=true, Order=60)]
            [DataMember]
            public Attachment Attachment
            {
                get { return _attachment; }
                set { _attachment = value; OnPropertyChanged("Attachment"); }
            }

            private Attachment _attachment;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StructuralRepresentationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (RepresentationElement != null) dest.RepresentationElement = (FhirString)RepresentationElement.DeepCopy();
                    if (Attachment != null) dest.Attachment = (Attachment)Attachment.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(RepresentationElement, otherT.RepresentationElement)) return false;
                if (!DeepComparable.Matches(Attachment, otherT.Attachment)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructuralRepresentationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(RepresentationElement, otherT.RepresentationElement)) return false;
                if (!DeepComparable.IsExactly(Attachment, otherT.Attachment)) return false;

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
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (RepresentationElement != null) yield return new ElementValue("representation", RepresentationElement);
                    if (Attachment != null) yield return new ElementValue("attachment", Attachment);
                }
            }


        }


        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("class", InSummary=true, Order=90)]
        [DataMember]
        public CodeableConcept Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged("Class"); }
        }

        private CodeableConcept _class;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("geometry", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept Geometry
        {
            get { return _geometry; }
            set { _geometry = value; OnPropertyChanged("Geometry"); }
        }

        private CodeableConcept _geometry;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("copolymerConnectivity", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> CopolymerConnectivity
        {
            get { if (_copolymerConnectivity==null) _copolymerConnectivity = new List<CodeableConcept>(); return _copolymerConnectivity; }
            set { _copolymerConnectivity = value; OnPropertyChanged("CopolymerConnectivity"); }
        }

        private List<CodeableConcept> _copolymerConnectivity;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("modification", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ModificationElement
        {
            get { if (_modificationElement==null) _modificationElement = new List<FhirString>(); return _modificationElement; }
            set { _modificationElement = value; OnPropertyChanged("ModificationElement"); }
        }

        private List<FhirString> _modificationElement;

        /// <summary>
        /// Todo
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Modification
        {
            get { return ModificationElement != null ? ModificationElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ModificationElement = null;
                else
                    ModificationElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Modification");
            }
        }

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("monomerSet", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MonomerSetComponent> MonomerSet
        {
            get { if (_monomerSet==null) _monomerSet = new List<MonomerSetComponent>(); return _monomerSet; }
            set { _monomerSet = value; OnPropertyChanged("MonomerSet"); }
        }

        private List<MonomerSetComponent> _monomerSet;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("repeat", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RepeatComponent> Repeat
        {
            get { if (_repeat==null) _repeat = new List<RepeatComponent>(); return _repeat; }
            set { _repeat = value; OnPropertyChanged("Repeat"); }
        }

        private List<RepeatComponent> _repeat;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstancePolymer;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Class != null) dest.Class = (CodeableConcept)Class.DeepCopy();
                if (Geometry != null) dest.Geometry = (CodeableConcept)Geometry.DeepCopy();
                if (CopolymerConnectivity != null) dest.CopolymerConnectivity = new List<CodeableConcept>(CopolymerConnectivity.DeepCopy());
                if (ModificationElement != null) dest.ModificationElement = new List<FhirString>(ModificationElement.DeepCopy());
                if (MonomerSet != null) dest.MonomerSet = new List<MonomerSetComponent>(MonomerSet.DeepCopy());
                if (Repeat != null) dest.Repeat = new List<RepeatComponent>(Repeat.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SubstancePolymer());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubstancePolymer;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Class, otherT.Class)) return false;
            if (!DeepComparable.Matches(Geometry, otherT.Geometry)) return false;
            if ( !DeepComparable.Matches(CopolymerConnectivity, otherT.CopolymerConnectivity)) return false;
            if ( !DeepComparable.Matches(ModificationElement, otherT.ModificationElement)) return false;
            if ( !DeepComparable.Matches(MonomerSet, otherT.MonomerSet)) return false;
            if ( !DeepComparable.Matches(Repeat, otherT.Repeat)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstancePolymer;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if (!DeepComparable.IsExactly(Geometry, otherT.Geometry)) return false;
            if (!DeepComparable.IsExactly(CopolymerConnectivity, otherT.CopolymerConnectivity)) return false;
            if (!DeepComparable.IsExactly(ModificationElement, otherT.ModificationElement)) return false;
            if (!DeepComparable.IsExactly(MonomerSet, otherT.MonomerSet)) return false;
            if (!DeepComparable.IsExactly(Repeat, otherT.Repeat)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Class != null) yield return Class;
                if (Geometry != null) yield return Geometry;
                foreach (var elem in CopolymerConnectivity) { if (elem != null) yield return elem; }
                foreach (var elem in ModificationElement) { if (elem != null) yield return elem; }
                foreach (var elem in MonomerSet) { if (elem != null) yield return elem; }
                foreach (var elem in Repeat) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Class != null) yield return new ElementValue("class", Class);
                if (Geometry != null) yield return new ElementValue("geometry", Geometry);
                foreach (var elem in CopolymerConnectivity) { if (elem != null) yield return new ElementValue("copolymerConnectivity", elem); }
                foreach (var elem in ModificationElement) { if (elem != null) yield return new ElementValue("modification", elem); }
                foreach (var elem in MonomerSet) { if (elem != null) yield return new ElementValue("monomerSet", elem); }
                foreach (var elem in Repeat) { if (elem != null) yield return new ElementValue("repeat", elem); }
            }
        }

    }

}
