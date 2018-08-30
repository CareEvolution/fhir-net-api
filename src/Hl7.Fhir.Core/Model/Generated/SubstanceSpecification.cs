﻿using System;
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
    /// The detailed description of a substance, typically at a level beyond what is used for prescribing
    /// </summary>
    [FhirType("SubstanceSpecification", IsResource=true)]
    [DataContract]
    public partial class SubstanceSpecification : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubstanceSpecification; } }
        [NotMapped]
        public override string TypeName { get { return "SubstanceSpecification"; } }


        [FhirType("MoietyComponent")]
        [DataContract]
        public partial class MoietyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MoietyComponent"; } }

            /// <summary>
            /// Role that the moiety is playing
            /// </summary>
            [FhirElement("role", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Identifier by which this moiety substance is known
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=50)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Textual name for this moiety substance
            /// </summary>
            [FhirElement("name", InSummary=true, Order=60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Textual name for this moiety substance
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
            /// Stereochemistry type
            /// </summary>
            [FhirElement("stereochemistry", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept Stereochemistry
            {
                get { return _stereochemistry; }
                set { _stereochemistry = value; OnPropertyChanged("Stereochemistry"); }
            }

            private CodeableConcept _stereochemistry;

            /// <summary>
            /// Optical activity type
            /// </summary>
            [FhirElement("opticalActivity", InSummary=true, Order=80)]
            [DataMember]
            public CodeableConcept OpticalActivity
            {
                get { return _opticalActivity; }
                set { _opticalActivity = value; OnPropertyChanged("OpticalActivity"); }
            }

            private CodeableConcept _opticalActivity;

            /// <summary>
            /// Molecular formula
            /// </summary>
            [FhirElement("molecularFormula", InSummary=true, Order=90)]
            [DataMember]
            public FhirString MolecularFormulaElement
            {
                get { return _molecularFormulaElement; }
                set { _molecularFormulaElement = value; OnPropertyChanged("MolecularFormulaElement"); }
            }

            private FhirString _molecularFormulaElement;

            /// <summary>
            /// Molecular formula
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string MolecularFormula
            {
                get { return MolecularFormulaElement != null ? MolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaElement = null;
                    else
                        MolecularFormulaElement = new FhirString(value);
                    OnPropertyChanged("MolecularFormula");
                }
            }

            /// <summary>
            /// Quantitative value for this moiety
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=100)]
            [DataMember]
            public FhirString AmountElement
            {
                get { return _amountElement; }
                set { _amountElement = value; OnPropertyChanged("AmountElement"); }
            }

            private FhirString _amountElement;

            /// <summary>
            /// Quantitative value for this moiety
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MoietyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Stereochemistry != null) dest.Stereochemistry = (CodeableConcept)Stereochemistry.DeepCopy();
                    if (OpticalActivity != null) dest.OpticalActivity = (CodeableConcept)OpticalActivity.DeepCopy();
                    if (MolecularFormulaElement != null) dest.MolecularFormulaElement = (FhirString)MolecularFormulaElement.DeepCopy();
                    if (AmountElement != null) dest.AmountElement = (FhirString)AmountElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Stereochemistry, otherT.Stereochemistry)) return false;
                if (!DeepComparable.Matches(OpticalActivity, otherT.OpticalActivity)) return false;
                if (!DeepComparable.Matches(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if (!DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MoietyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Stereochemistry, otherT.Stereochemistry)) return false;
                if (!DeepComparable.IsExactly(OpticalActivity, otherT.OpticalActivity)) return false;
                if (!DeepComparable.IsExactly(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if (!DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;

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
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Stereochemistry != null) yield return new ElementValue("stereochemistry", Stereochemistry);
                    if (OpticalActivity != null) yield return new ElementValue("opticalActivity", OpticalActivity);
                    if (MolecularFormulaElement != null) yield return new ElementValue("molecularFormula", MolecularFormulaElement);
                    if (AmountElement != null) yield return new ElementValue("amount", AmountElement);
                }
            }


        }


        [FhirType("PropertyComponent")]
        [DataContract]
        public partial class PropertyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PropertyComponent"; } }

            /// <summary>
            /// Description todo
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
            /// Description todo
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Name
            {
                get { return _name; }
                set { _name = value; OnPropertyChanged("Name"); }
            }

            private CodeableConcept _name;

            /// <summary>
            /// A field that should be used to capture parameters that were used in the measurement of a property
            /// </summary>
            [FhirElement("parameters", InSummary=true, Order=60)]
            [DataMember]
            public FhirString ParametersElement
            {
                get { return _parametersElement; }
                set { _parametersElement = value; OnPropertyChanged("ParametersElement"); }
            }

            private FhirString _parametersElement;

            /// <summary>
            /// A field that should be used to capture parameters that were used in the measurement of a property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Parameters
            {
                get { return ParametersElement != null ? ParametersElement.Value : null; }
                set
                {
                    if (value == null)
                        ParametersElement = null;
                    else
                        ParametersElement = new FhirString(value);
                    OnPropertyChanged("Parameters");
                }
            }

            /// <summary>
            /// Identifier for a substance upon which a defining property depends
            /// </summary>
            [FhirElement("substanceId", InSummary=true, Order=70)]
            [DataMember]
            public Identifier SubstanceId
            {
                get { return _substanceId; }
                set { _substanceId = value; OnPropertyChanged("SubstanceId"); }
            }

            private Identifier _substanceId;

            /// <summary>
            /// Description todo
            /// </summary>
            [FhirElement("substanceName", InSummary=true, Order=80)]
            [DataMember]
            public FhirString SubstanceNameElement
            {
                get { return _substanceNameElement; }
                set { _substanceNameElement = value; OnPropertyChanged("SubstanceNameElement"); }
            }

            private FhirString _substanceNameElement;

            /// <summary>
            /// Description todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SubstanceName
            {
                get { return SubstanceNameElement != null ? SubstanceNameElement.Value : null; }
                set
                {
                    if (value == null)
                        SubstanceNameElement = null;
                    else
                        SubstanceNameElement = new FhirString(value);
                    OnPropertyChanged("SubstanceName");
                }
            }

            /// <summary>
            /// Quantitative value for this property
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=90)]
            [DataMember]
            public FhirString AmountElement
            {
                get { return _amountElement; }
                set { _amountElement = value; OnPropertyChanged("AmountElement"); }
            }

            private FhirString _amountElement;

            /// <summary>
            /// Quantitative value for this property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PropertyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Name != null) dest.Name = (CodeableConcept)Name.DeepCopy();
                    if (ParametersElement != null) dest.ParametersElement = (FhirString)ParametersElement.DeepCopy();
                    if (SubstanceId != null) dest.SubstanceId = (Identifier)SubstanceId.DeepCopy();
                    if (SubstanceNameElement != null) dest.SubstanceNameElement = (FhirString)SubstanceNameElement.DeepCopy();
                    if (AmountElement != null) dest.AmountElement = (FhirString)AmountElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Name, otherT.Name)) return false;
                if (!DeepComparable.Matches(ParametersElement, otherT.ParametersElement)) return false;
                if (!DeepComparable.Matches(SubstanceId, otherT.SubstanceId)) return false;
                if (!DeepComparable.Matches(SubstanceNameElement, otherT.SubstanceNameElement)) return false;
                if (!DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if (!DeepComparable.IsExactly(ParametersElement, otherT.ParametersElement)) return false;
                if (!DeepComparable.IsExactly(SubstanceId, otherT.SubstanceId)) return false;
                if (!DeepComparable.IsExactly(SubstanceNameElement, otherT.SubstanceNameElement)) return false;
                if (!DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;

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
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Name != null) yield return new ElementValue("name", Name);
                    if (ParametersElement != null) yield return new ElementValue("parameters", ParametersElement);
                    if (SubstanceId != null) yield return new ElementValue("substanceId", SubstanceId);
                    if (SubstanceNameElement != null) yield return new ElementValue("substanceName", SubstanceNameElement);
                    if (AmountElement != null) yield return new ElementValue("amount", AmountElement);
                }
            }


        }


        [FhirType("StructureComponent")]
        [DataContract]
        public partial class StructureComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StructureComponent"; } }

            /// <summary>
            /// Stereochemistry type
            /// </summary>
            [FhirElement("stereochemistry", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Stereochemistry
            {
                get { return _stereochemistry; }
                set { _stereochemistry = value; OnPropertyChanged("Stereochemistry"); }
            }

            private CodeableConcept _stereochemistry;

            /// <summary>
            /// Optical activity type
            /// </summary>
            [FhirElement("opticalActivity", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept OpticalActivity
            {
                get { return _opticalActivity; }
                set { _opticalActivity = value; OnPropertyChanged("OpticalActivity"); }
            }

            private CodeableConcept _opticalActivity;

            /// <summary>
            /// Molecular formula
            /// </summary>
            [FhirElement("molecularFormula", InSummary=true, Order=60)]
            [DataMember]
            public FhirString MolecularFormulaElement
            {
                get { return _molecularFormulaElement; }
                set { _molecularFormulaElement = value; OnPropertyChanged("MolecularFormulaElement"); }
            }

            private FhirString _molecularFormulaElement;

            /// <summary>
            /// Molecular formula
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string MolecularFormula
            {
                get { return MolecularFormulaElement != null ? MolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaElement = null;
                    else
                        MolecularFormulaElement = new FhirString(value);
                    OnPropertyChanged("MolecularFormula");
                }
            }

            /// <summary>
            /// Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical. and each moiety separated by a dot
            /// </summary>
            [FhirElement("molecularFormulaByMoiety", InSummary=true, Order=70)]
            [DataMember]
            public FhirString MolecularFormulaByMoietyElement
            {
                get { return _molecularFormulaByMoietyElement; }
                set { _molecularFormulaByMoietyElement = value; OnPropertyChanged("MolecularFormulaByMoietyElement"); }
            }

            private FhirString _molecularFormulaByMoietyElement;

            /// <summary>
            /// Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical. and each moiety separated by a dot
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string MolecularFormulaByMoiety
            {
                get { return MolecularFormulaByMoietyElement != null ? MolecularFormulaByMoietyElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaByMoietyElement = null;
                    else
                        MolecularFormulaByMoietyElement = new FhirString(value);
                    OnPropertyChanged("MolecularFormulaByMoiety");
                }
            }

            /// <summary>
            /// Applicable for single substances that contain a radionuclide or a non-natural isotopic ratio
            /// </summary>
            [FhirElement("isotope", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<IsotopeComponent> Isotope
            {
                get { if (_isotope==null) _isotope = new List<IsotopeComponent>(); return _isotope; }
                set { _isotope = value; OnPropertyChanged("Isotope"); }
            }

            private List<IsotopeComponent> _isotope;

            /// <summary>
            /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
            /// </summary>
            [FhirElement("molecularWeight", InSummary=true, Order=90)]
            [DataMember]
            public MolecularWeightComponent MolecularWeight
            {
                get { return _molecularWeight; }
                set { _molecularWeight = value; OnPropertyChanged("MolecularWeight"); }
            }

            private MolecularWeightComponent _molecularWeight;

            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("referenceSource", InSummary=true, Order=100)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> ReferenceSource
            {
                get { if (_referenceSource==null) _referenceSource = new List<ResourceReference>(); return _referenceSource; }
                set { _referenceSource = value; OnPropertyChanged("ReferenceSource"); }
            }

            private List<ResourceReference> _referenceSource;

            /// <summary>
            /// Molectular structural representation
            /// </summary>
            [FhirElement("structuralRepresentation", InSummary=true, Order=110)]
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
                var dest = other as StructureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Stereochemistry != null) dest.Stereochemistry = (CodeableConcept)Stereochemistry.DeepCopy();
                    if (OpticalActivity != null) dest.OpticalActivity = (CodeableConcept)OpticalActivity.DeepCopy();
                    if (MolecularFormulaElement != null) dest.MolecularFormulaElement = (FhirString)MolecularFormulaElement.DeepCopy();
                    if (MolecularFormulaByMoietyElement != null) dest.MolecularFormulaByMoietyElement = (FhirString)MolecularFormulaByMoietyElement.DeepCopy();
                    if (Isotope != null) dest.Isotope = new List<IsotopeComponent>(Isotope.DeepCopy());
                    if (MolecularWeight != null) dest.MolecularWeight = (MolecularWeightComponent)MolecularWeight.DeepCopy();
                    if (ReferenceSource != null) dest.ReferenceSource = new List<ResourceReference>(ReferenceSource.DeepCopy());
                    if (StructuralRepresentation != null) dest.StructuralRepresentation = new List<StructuralRepresentationComponent>(StructuralRepresentation.DeepCopy());
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
                if (!DeepComparable.Matches(Stereochemistry, otherT.Stereochemistry)) return false;
                if (!DeepComparable.Matches(OpticalActivity, otherT.OpticalActivity)) return false;
                if (!DeepComparable.Matches(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if (!DeepComparable.Matches(MolecularFormulaByMoietyElement, otherT.MolecularFormulaByMoietyElement)) return false;
                if ( !DeepComparable.Matches(Isotope, otherT.Isotope)) return false;
                if (!DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
                if ( !DeepComparable.Matches(ReferenceSource, otherT.ReferenceSource)) return false;
                if ( !DeepComparable.Matches(StructuralRepresentation, otherT.StructuralRepresentation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Stereochemistry, otherT.Stereochemistry)) return false;
                if (!DeepComparable.IsExactly(OpticalActivity, otherT.OpticalActivity)) return false;
                if (!DeepComparable.IsExactly(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if (!DeepComparable.IsExactly(MolecularFormulaByMoietyElement, otherT.MolecularFormulaByMoietyElement)) return false;
                if (!DeepComparable.IsExactly(Isotope, otherT.Isotope)) return false;
                if (!DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
                if (!DeepComparable.IsExactly(ReferenceSource, otherT.ReferenceSource)) return false;
                if (!DeepComparable.IsExactly(StructuralRepresentation, otherT.StructuralRepresentation)) return false;

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
                    if (Stereochemistry != null) yield return new ElementValue("stereochemistry", Stereochemistry);
                    if (OpticalActivity != null) yield return new ElementValue("opticalActivity", OpticalActivity);
                    if (MolecularFormulaElement != null) yield return new ElementValue("molecularFormula", MolecularFormulaElement);
                    if (MolecularFormulaByMoietyElement != null) yield return new ElementValue("molecularFormulaByMoiety", MolecularFormulaByMoietyElement);
                    foreach (var elem in Isotope) { if (elem != null) yield return new ElementValue("isotope", elem); }
                    if (MolecularWeight != null) yield return new ElementValue("molecularWeight", MolecularWeight);
                    foreach (var elem in ReferenceSource) { if (elem != null) yield return new ElementValue("referenceSource", elem); }
                    foreach (var elem in StructuralRepresentation) { if (elem != null) yield return new ElementValue("structuralRepresentation", elem); }
                }
            }


        }


        [FhirType("IsotopeComponent")]
        [DataContract]
        public partial class IsotopeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "IsotopeComponent"; } }

            /// <summary>
            /// Substance identifier for each non-natural or radioisotope
            /// </summary>
            [FhirElement("nuclideId", InSummary=true, Order=40)]
            [DataMember]
            public Identifier NuclideId
            {
                get { return _nuclideId; }
                set { _nuclideId = value; OnPropertyChanged("NuclideId"); }
            }

            private Identifier _nuclideId;

            /// <summary>
            /// Substance name for each non-natural or radioisotope
            /// </summary>
            [FhirElement("nuclideName", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept NuclideName
            {
                get { return _nuclideName; }
                set { _nuclideName = value; OnPropertyChanged("NuclideName"); }
            }

            private CodeableConcept _nuclideName;

            /// <summary>
            /// The type of isotopic substitution present in a single substance
            /// </summary>
            [FhirElement("substitutionType", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept SubstitutionType
            {
                get { return _substitutionType; }
                set { _substitutionType = value; OnPropertyChanged("SubstitutionType"); }
            }

            private CodeableConcept _substitutionType;

            /// <summary>
            /// Half life - for a non-natural nuclide
            /// </summary>
            [FhirElement("nuclideHalfLife", InSummary=true, Order=70)]
            [DataMember]
            public Quantity NuclideHalfLife
            {
                get { return _nuclideHalfLife; }
                set { _nuclideHalfLife = value; OnPropertyChanged("NuclideHalfLife"); }
            }

            private Quantity _nuclideHalfLife;

            /// <summary>
            /// Quantitative values for this isotope
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=80)]
            [DataMember]
            public FhirString AmountElement
            {
                get { return _amountElement; }
                set { _amountElement = value; OnPropertyChanged("AmountElement"); }
            }

            private FhirString _amountElement;

            /// <summary>
            /// Quantitative values for this isotope
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }

            /// <summary>
            /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
            /// </summary>
            [FhirElement("molecularWeight", InSummary=true, Order=90)]
            [DataMember]
            public MolecularWeightComponent MolecularWeight
            {
                get { return _molecularWeight; }
                set { _molecularWeight = value; OnPropertyChanged("MolecularWeight"); }
            }

            private MolecularWeightComponent _molecularWeight;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IsotopeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NuclideId != null) dest.NuclideId = (Identifier)NuclideId.DeepCopy();
                    if (NuclideName != null) dest.NuclideName = (CodeableConcept)NuclideName.DeepCopy();
                    if (SubstitutionType != null) dest.SubstitutionType = (CodeableConcept)SubstitutionType.DeepCopy();
                    if (NuclideHalfLife != null) dest.NuclideHalfLife = (Quantity)NuclideHalfLife.DeepCopy();
                    if (AmountElement != null) dest.AmountElement = (FhirString)AmountElement.DeepCopy();
                    if (MolecularWeight != null) dest.MolecularWeight = (MolecularWeightComponent)MolecularWeight.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NuclideId, otherT.NuclideId)) return false;
                if (!DeepComparable.Matches(NuclideName, otherT.NuclideName)) return false;
                if (!DeepComparable.Matches(SubstitutionType, otherT.SubstitutionType)) return false;
                if (!DeepComparable.Matches(NuclideHalfLife, otherT.NuclideHalfLife)) return false;
                if (!DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
                if (!DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IsotopeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NuclideId, otherT.NuclideId)) return false;
                if (!DeepComparable.IsExactly(NuclideName, otherT.NuclideName)) return false;
                if (!DeepComparable.IsExactly(SubstitutionType, otherT.SubstitutionType)) return false;
                if (!DeepComparable.IsExactly(NuclideHalfLife, otherT.NuclideHalfLife)) return false;
                if (!DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
                if (!DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;

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
                    if (NuclideId != null) yield return new ElementValue("nuclideId", NuclideId);
                    if (NuclideName != null) yield return new ElementValue("nuclideName", NuclideName);
                    if (SubstitutionType != null) yield return new ElementValue("substitutionType", SubstitutionType);
                    if (NuclideHalfLife != null) yield return new ElementValue("nuclideHalfLife", NuclideHalfLife);
                    if (AmountElement != null) yield return new ElementValue("amount", AmountElement);
                    if (MolecularWeight != null) yield return new ElementValue("molecularWeight", MolecularWeight);
                }
            }


        }


        [FhirType("MolecularWeightComponent")]
        [DataContract]
        public partial class MolecularWeightComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MolecularWeightComponent"; } }

            /// <summary>
            /// The method by which the molecular weight was determined
            /// </summary>
            [FhirElement("method", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// Type of molecular weight such as exact, average (also known as. number average), weight average
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
            /// Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=60)]
            [DataMember]
            public FhirString AmountElement
            {
                get { return _amountElement; }
                set { _amountElement = value; OnPropertyChanged("AmountElement"); }
            }

            private FhirString _amountElement;

            /// <summary>
            /// Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new FhirString(value);
                    OnPropertyChanged("Amount");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MolecularWeightComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (AmountElement != null) dest.AmountElement = (FhirString)AmountElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MolecularWeightComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;

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
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (AmountElement != null) yield return new ElementValue("amount", AmountElement);
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
            /// The type of structure (e.g. Full, Partial, Representative)
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
            /// The structural representation as text string in a format e.g. InChI, SMILES, MOLFILE, CDX
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
            /// The structural representation as text string in a format e.g. InChI, SMILES, MOLFILE, CDX
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
            /// An attached file with the structural representation
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


        [FhirType("SubstanceCodeComponent")]
        [DataContract]
        public partial class SubstanceCodeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstanceCodeComponent"; } }

            /// <summary>
            /// The specific code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Status of the code assignment
            /// </summary>
            [FhirElement("status", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Status
            {
                get { return _status; }
                set { _status = value; OnPropertyChanged("Status"); }
            }

            private CodeableConcept _status;

            /// <summary>
            /// The date at which the code status is changed as part of the terminology maintenance
            /// </summary>
            [FhirElement("statusDate", InSummary=true, Order=60)]
            [DataMember]
            public FhirDateTime StatusDateElement
            {
                get { return _statusDateElement; }
                set { _statusDateElement = value; OnPropertyChanged("StatusDateElement"); }
            }

            private FhirDateTime _statusDateElement;

            /// <summary>
            /// The date at which the code status is changed as part of the terminology maintenance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string StatusDate
            {
                get { return StatusDateElement != null ? StatusDateElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusDateElement = null;
                    else
                        StatusDateElement = new FhirDateTime(value);
                    OnPropertyChanged("StatusDate");
                }
            }

            /// <summary>
            /// Any comment can be provided in this field, if necessary
            /// </summary>
            [FhirElement("comment", InSummary=true, Order=70)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Any comment can be provided in this field, if necessary
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }

            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("referenceSource", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ReferenceSourceElement
            {
                get { if (_referenceSourceElement==null) _referenceSourceElement = new List<FhirString>(); return _referenceSourceElement; }
                set { _referenceSourceElement = value; OnPropertyChanged("ReferenceSourceElement"); }
            }

            private List<FhirString> _referenceSourceElement;

            /// <summary>
            /// Supporting literature
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> ReferenceSource
            {
                get { return ReferenceSourceElement != null ? ReferenceSourceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReferenceSourceElement = null;
                    else
                        ReferenceSourceElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("ReferenceSource");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceCodeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Status != null) dest.Status = (CodeableConcept)Status.DeepCopy();
                    if (StatusDateElement != null) dest.StatusDateElement = (FhirDateTime)StatusDateElement.DeepCopy();
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                    if (ReferenceSourceElement != null) dest.ReferenceSourceElement = new List<FhirString>(ReferenceSourceElement.DeepCopy());
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Status, otherT.Status)) return false;
                if (!DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
                if ( !DeepComparable.Matches(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceCodeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if (!DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
                if (!DeepComparable.IsExactly(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;

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
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Status != null) yield return new ElementValue("status", Status);
                    if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                    foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return new ElementValue("referenceSource", elem); }
                }
            }


        }


        [FhirType("SubstanceNameComponent")]
        [DataContract]
        public partial class SubstanceNameComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstanceNameComponent"; } }

            /// <summary>
            /// The actual name
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// The actual name
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
            /// Name type
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
            /// Language of the name
            /// </summary>
            [FhirElement("language", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Language
            {
                get { if (_language==null) _language = new List<CodeableConcept>(); return _language; }
                set { _language = value; OnPropertyChanged("Language"); }
            }

            private List<CodeableConcept> _language;

            /// <summary>
            /// The use context of this name for example if there is a different name a drug active ingredient as opposed to a food colour additive
            /// </summary>
            [FhirElement("domain", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Domain
            {
                get { if (_domain==null) _domain = new List<CodeableConcept>(); return _domain; }
                set { _domain = value; OnPropertyChanged("Domain"); }
            }

            private List<CodeableConcept> _domain;

            /// <summary>
            /// The jurisdiction where this name applies
            /// </summary>
            [FhirElement("jurisdiction", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Jurisdiction
            {
                get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
                set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }

            private List<CodeableConcept> _jurisdiction;

            /// <summary>
            /// Details of the official nature of this name
            /// </summary>
            [FhirElement("officialName", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<OfficialNameComponent> OfficialName
            {
                get { if (_officialName==null) _officialName = new List<OfficialNameComponent>(); return _officialName; }
                set { _officialName = value; OnPropertyChanged("OfficialName"); }
            }

            private List<OfficialNameComponent> _officialName;

            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("referenceSource", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ReferenceSourceElement
            {
                get { if (_referenceSourceElement==null) _referenceSourceElement = new List<FhirString>(); return _referenceSourceElement; }
                set { _referenceSourceElement = value; OnPropertyChanged("ReferenceSourceElement"); }
            }

            private List<FhirString> _referenceSourceElement;

            /// <summary>
            /// Supporting literature
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> ReferenceSource
            {
                get { return ReferenceSourceElement != null ? ReferenceSourceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReferenceSourceElement = null;
                    else
                        ReferenceSourceElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("ReferenceSource");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceNameComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Language != null) dest.Language = new List<CodeableConcept>(Language.DeepCopy());
                    if (Domain != null) dest.Domain = new List<CodeableConcept>(Domain.DeepCopy());
                    if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                    if (OfficialName != null) dest.OfficialName = new List<OfficialNameComponent>(OfficialName.DeepCopy());
                    if (ReferenceSourceElement != null) dest.ReferenceSourceElement = new List<FhirString>(ReferenceSourceElement.DeepCopy());
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Language, otherT.Language)) return false;
                if ( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
                if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if ( !DeepComparable.Matches(OfficialName, otherT.OfficialName)) return false;
                if ( !DeepComparable.Matches(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceNameComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Language, otherT.Language)) return false;
                if (!DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
                if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if (!DeepComparable.IsExactly(OfficialName, otherT.OfficialName)) return false;
                if (!DeepComparable.IsExactly(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;

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
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Language) { if (elem != null) yield return new ElementValue("language", elem); }
                    foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", elem); }
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                    foreach (var elem in OfficialName) { if (elem != null) yield return new ElementValue("officialName", elem); }
                    foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return new ElementValue("referenceSource", elem); }
                }
            }


        }


        [FhirType("OfficialNameComponent")]
        [DataContract]
        public partial class OfficialNameComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OfficialNameComponent"; } }

            /// <summary>
            /// Which authority uses this official name
            /// </summary>
            [FhirElement("authority", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Authority
            {
                get { return _authority; }
                set { _authority = value; OnPropertyChanged("Authority"); }
            }

            private CodeableConcept _authority;

            /// <summary>
            /// The status of the official name
            /// </summary>
            [FhirElement("status", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Status
            {
                get { return _status; }
                set { _status = value; OnPropertyChanged("Status"); }
            }

            private CodeableConcept _status;

            /// <summary>
            /// Date of official name change
            /// </summary>
            [FhirElement("date", InSummary=true, Order=60)]
            [DataMember]
            public FhirDateTime DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private FhirDateTime _dateElement;

            /// <summary>
            /// Date of official name change
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OfficialNameComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Authority != null) dest.Authority = (CodeableConcept)Authority.DeepCopy();
                    if (Status != null) dest.Status = (CodeableConcept)Status.DeepCopy();
                    if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if (!DeepComparable.Matches(Status, otherT.Status)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OfficialNameComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if (!DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;

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
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    if (Status != null) yield return new ElementValue("status", Status);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                }
            }


        }


        /// <summary>
        /// Textual comment
        /// </summary>
        [FhirElement("comment", InSummary=true, Order=90)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Textual comment
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if (value == null)
                    CommentElement = null;
                else
                    CommentElement = new FhirString(value);
                OnPropertyChanged("Comment");
            }
        }

        /// <summary>
        /// Chemicals may be stoichiometric or non-stoichiometric
        /// </summary>
        [FhirElement("stoichiometric", InSummary=true, Order=100)]
        [DataMember]
        public FhirBoolean StoichiometricElement
        {
            get { return _stoichiometricElement; }
            set { _stoichiometricElement = value; OnPropertyChanged("StoichiometricElement"); }
        }

        private FhirBoolean _stoichiometricElement;

        /// <summary>
        /// Chemicals may be stoichiometric or non-stoichiometric
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Stoichiometric
        {
            get { return StoichiometricElement != null ? StoichiometricElement.Value : null; }
            set
            {
                if (value == null)
                    StoichiometricElement = null;
                else
                    StoichiometricElement = new FhirBoolean(value);
                OnPropertyChanged("Stoichiometric");
            }
        }

        /// <summary>
        /// Identifier by which this substance is known
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=110)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// High level categorization, e.g. polymer or nucleic acid
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Supporting literature
        /// </summary>
        [FhirElement("referenceSource", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ReferenceSourceElement
        {
            get { if (_referenceSourceElement==null) _referenceSourceElement = new List<FhirString>(); return _referenceSourceElement; }
            set { _referenceSourceElement = value; OnPropertyChanged("ReferenceSourceElement"); }
        }

        private List<FhirString> _referenceSourceElement;

        /// <summary>
        /// Supporting literature
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> ReferenceSource
        {
            get { return ReferenceSourceElement != null ? ReferenceSourceElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ReferenceSourceElement = null;
                else
                    ReferenceSourceElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("ReferenceSource");
            }
        }

        /// <summary>
        /// Moiety, for structural modifications
        /// </summary>
        [FhirElement("moiety", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MoietyComponent> Moiety
        {
            get { if (_moiety==null) _moiety = new List<MoietyComponent>(); return _moiety; }
            set { _moiety = value; OnPropertyChanged("Moiety"); }
        }

        private List<MoietyComponent> _moiety;

        /// <summary>
        /// General specifications for this substance, including how it is related to other substances
        /// </summary>
        [FhirElement("property", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PropertyComponent> Property
        {
            get { if (_property==null) _property = new List<PropertyComponent>(); return _property; }
            set { _property = value; OnPropertyChanged("Property"); }
        }

        private List<PropertyComponent> _property;

        /// <summary>
        /// General information detailing this substance
        /// </summary>
        [FhirElement("referenceInformation", InSummary=true, Order=160)]
        [References("SubstanceReferenceInformation")]
        [DataMember]
        public ResourceReference ReferenceInformation
        {
            get { return _referenceInformation; }
            set { _referenceInformation = value; OnPropertyChanged("ReferenceInformation"); }
        }

        private ResourceReference _referenceInformation;

        /// <summary>
        /// Structural information
        /// </summary>
        [FhirElement("structure", InSummary=true, Order=170)]
        [DataMember]
        public StructureComponent Structure
        {
            get { return _structure; }
            set { _structure = value; OnPropertyChanged("Structure"); }
        }

        private StructureComponent _structure;

        /// <summary>
        /// Codes associated with the substance
        /// </summary>
        [FhirElement("substanceCode", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SubstanceCodeComponent> SubstanceCode
        {
            get { if (_substanceCode==null) _substanceCode = new List<SubstanceCodeComponent>(); return _substanceCode; }
            set { _substanceCode = value; OnPropertyChanged("SubstanceCode"); }
        }

        private List<SubstanceCodeComponent> _substanceCode;

        /// <summary>
        /// Names applicable to this substence
        /// </summary>
        [FhirElement("substanceName", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SubstanceNameComponent> SubstanceName
        {
            get { if (_substanceName==null) _substanceName = new List<SubstanceNameComponent>(); return _substanceName; }
            set { _substanceName = value; OnPropertyChanged("SubstanceName"); }
        }

        private List<SubstanceNameComponent> _substanceName;

        /// <summary>
        /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
        /// </summary>
        [FhirElement("molecularWeight", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MolecularWeightComponent> MolecularWeight
        {
            get { if (_molecularWeight==null) _molecularWeight = new List<MolecularWeightComponent>(); return _molecularWeight; }
            set { _molecularWeight = value; OnPropertyChanged("MolecularWeight"); }
        }

        private List<MolecularWeightComponent> _molecularWeight;

        /// <summary>
        /// Data items specific to polymers
        /// </summary>
        [FhirElement("polymer", InSummary=true, Order=210)]
        [References("SubstancePolymer")]
        [DataMember]
        public ResourceReference Polymer
        {
            get { return _polymer; }
            set { _polymer = value; OnPropertyChanged("Polymer"); }
        }

        private ResourceReference _polymer;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstanceSpecification;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (StoichiometricElement != null) dest.StoichiometricElement = (FhirBoolean)StoichiometricElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (ReferenceSourceElement != null) dest.ReferenceSourceElement = new List<FhirString>(ReferenceSourceElement.DeepCopy());
                if (Moiety != null) dest.Moiety = new List<MoietyComponent>(Moiety.DeepCopy());
                if (Property != null) dest.Property = new List<PropertyComponent>(Property.DeepCopy());
                if (ReferenceInformation != null) dest.ReferenceInformation = (ResourceReference)ReferenceInformation.DeepCopy();
                if (Structure != null) dest.Structure = (StructureComponent)Structure.DeepCopy();
                if (SubstanceCode != null) dest.SubstanceCode = new List<SubstanceCodeComponent>(SubstanceCode.DeepCopy());
                if (SubstanceName != null) dest.SubstanceName = new List<SubstanceNameComponent>(SubstanceName.DeepCopy());
                if (MolecularWeight != null) dest.MolecularWeight = new List<MolecularWeightComponent>(MolecularWeight.DeepCopy());
                if (Polymer != null) dest.Polymer = (ResourceReference)Polymer.DeepCopy();
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.Matches(StoichiometricElement, otherT.StoichiometricElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            if ( !DeepComparable.Matches(Moiety, otherT.Moiety)) return false;
            if ( !DeepComparable.Matches(Property, otherT.Property)) return false;
            if (!DeepComparable.Matches(ReferenceInformation, otherT.ReferenceInformation)) return false;
            if (!DeepComparable.Matches(Structure, otherT.Structure)) return false;
            if ( !DeepComparable.Matches(SubstanceCode, otherT.SubstanceCode)) return false;
            if ( !DeepComparable.Matches(SubstanceName, otherT.SubstanceName)) return false;
            if ( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
            if (!DeepComparable.Matches(Polymer, otherT.Polymer)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstanceSpecification;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(StoichiometricElement, otherT.StoichiometricElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(ReferenceSourceElement, otherT.ReferenceSourceElement)) return false;
            if (!DeepComparable.IsExactly(Moiety, otherT.Moiety)) return false;
            if (!DeepComparable.IsExactly(Property, otherT.Property)) return false;
            if (!DeepComparable.IsExactly(ReferenceInformation, otherT.ReferenceInformation)) return false;
            if (!DeepComparable.IsExactly(Structure, otherT.Structure)) return false;
            if (!DeepComparable.IsExactly(SubstanceCode, otherT.SubstanceCode)) return false;
            if (!DeepComparable.IsExactly(SubstanceName, otherT.SubstanceName)) return false;
            if (!DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
            if (!DeepComparable.IsExactly(Polymer, otherT.Polymer)) return false;

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
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                if (StoichiometricElement != null) yield return new ElementValue("stoichiometric", StoichiometricElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in ReferenceSourceElement) { if (elem != null) yield return new ElementValue("referenceSource", elem); }
                foreach (var elem in Moiety) { if (elem != null) yield return new ElementValue("moiety", elem); }
                foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
                if (ReferenceInformation != null) yield return new ElementValue("referenceInformation", ReferenceInformation);
                if (Structure != null) yield return new ElementValue("structure", Structure);
                foreach (var elem in SubstanceCode) { if (elem != null) yield return new ElementValue("substanceCode", elem); }
                foreach (var elem in SubstanceName) { if (elem != null) yield return new ElementValue("substanceName", elem); }
                foreach (var elem in MolecularWeight) { if (elem != null) yield return new ElementValue("molecularWeight", elem); }
                if (Polymer != null) yield return new ElementValue("polymer", Polymer);
            }
        }

    }

}
