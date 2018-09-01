using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Definition of Medication Knowledge
    /// </summary>
    [FhirType("MedicationKnowledge", IsResource=true)]
    [DataContract]
    public partial class MedicationKnowledge : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationKnowledge; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationKnowledge"; } }

        /// <summary>
        /// A coded concept defining if the medication is in active use.
        /// (url: http://hl7.org/fhir/ValueSet/medicationKnowledge-status)
        /// </summary>
        [FhirEnumeration("MedicationKnowledgeStatus")]
        public enum MedicationKnowledgeStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medicationKnowledge-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/medicationKnowledge-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medicationKnowledge-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/medicationKnowledge-status"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medicationKnowledge-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medicationKnowledge-status"), Description("Entered in Error")]
            EnteredInError,
        }


        [FhirType("RelatedMedicationKnowledgeComponent")]
        [DataContract]
        public partial class RelatedMedicationKnowledgeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedMedicationKnowledgeComponent"; } }

            /// <summary>
            /// Category of medicationKnowledge
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Associated documentation about the associated medication knowledge
            /// </summary>
            [FhirElement("reference", Order=50)]
            [References("MedicationKnowledge")]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceReference> Reference
            {
                get { if (_reference==null) _reference = new List<ResourceReference>(); return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private List<ResourceReference> _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedMedicationKnowledgeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Reference != null) dest.Reference = new List<ResourceReference>(Reference.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedMedicationKnowledgeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedMedicationKnowledgeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedMedicationKnowledgeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Reference) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Reference) { if (elem != null) yield return new ElementValue("reference", elem); }
                }
            }


        }


        [FhirType("MonographComponent")]
        [DataContract]
        public partial class MonographComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MonographComponent"; } }

            /// <summary>
            /// The category of medication document
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Associated documentation about the medication
            /// </summary>
            [FhirElement("source", Order=50)]
            [References("DocumentReference","Media")]
            [DataMember]
            public ResourceReference Source
            {
                get { return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private ResourceReference _source;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MonographComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MonographComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MonographComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Source, otherT.Source)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MonographComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Source != null) yield return Source;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Source != null) yield return new ElementValue("source", Source);
                }
            }


        }


        [FhirType("IngredientComponent")]
        [DataContract]
        public partial class IngredientComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "IngredientComponent"; } }

            /// <summary>
            /// Medication(s) or substance(s) contained in the medication
            /// </summary>
            [FhirElement("item", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Item
            {
                get { return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private Element _item;

            /// <summary>
            /// Active ingredient indicator
            /// </summary>
            [FhirElement("isActive", Order=50)]
            [DataMember]
            public FhirBoolean IsActiveElement
            {
                get { return _isActiveElement; }
                set { _isActiveElement = value; OnPropertyChanged("IsActiveElement"); }
            }

            private FhirBoolean _isActiveElement;

            /// <summary>
            /// Active ingredient indicator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? IsActive
            {
                get { return IsActiveElement != null ? IsActiveElement.Value : null; }
                set
                {
                    if (value == null)
                        IsActiveElement = null;
                    else
                        IsActiveElement = new FhirBoolean(value);
                    OnPropertyChanged("IsActive");
                }
            }

            /// <summary>
            /// Quantity of ingredient present
            /// </summary>
            [FhirElement("strength", Order=60)]
            [DataMember]
            public Ratio Strength
            {
                get { return _strength; }
                set { _strength = value; OnPropertyChanged("Strength"); }
            }

            private Ratio _strength;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IngredientComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Item != null) dest.Item = (Element)Item.DeepCopy();
                    if (IsActiveElement != null) dest.IsActiveElement = (FhirBoolean)IsActiveElement.DeepCopy();
                    if (Strength != null) dest.Strength = (Ratio)Strength.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new IngredientComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IngredientComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;
                if (!DeepComparable.Matches(IsActiveElement, otherT.IsActiveElement)) return false;
                if (!DeepComparable.Matches(Strength, otherT.Strength)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IngredientComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
                if (!DeepComparable.IsExactly(IsActiveElement, otherT.IsActiveElement)) return false;
                if (!DeepComparable.IsExactly(Strength, otherT.Strength)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                    if (IsActiveElement != null) yield return IsActiveElement;
                    if (Strength != null) yield return Strength;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                    if (IsActiveElement != null) yield return new ElementValue("isActive", IsActiveElement);
                    if (Strength != null) yield return new ElementValue("strength", Strength);
                }
            }


        }


        [FhirType("CostComponent")]
        [DataContract]
        public partial class CostComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CostComponent"; } }

            /// <summary>
            /// The category of the cost information
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// The source or owner for the price information
            /// </summary>
            [FhirElement("source", Order=50)]
            [DataMember]
            public FhirString SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private FhirString _sourceElement;

            /// <summary>
            /// The source or owner for the price information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new FhirString(value);
                    OnPropertyChanged("Source");
                }
            }

            /// <summary>
            /// The price of the medication
            /// </summary>
            [FhirElement("cost", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Money Cost
            {
                get { return _cost; }
                set { _cost = value; OnPropertyChanged("Cost"); }
            }

            private Money _cost;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CostComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (SourceElement != null) dest.SourceElement = (FhirString)SourceElement.DeepCopy();
                    if (Cost != null) dest.Cost = (Money)Cost.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CostComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CostComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.Matches(Cost, otherT.Cost)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CostComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.IsExactly(Cost, otherT.Cost)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (SourceElement != null) yield return SourceElement;
                    if (Cost != null) yield return Cost;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (Cost != null) yield return new ElementValue("cost", Cost);
                }
            }


        }


        [FhirType("MonitoringProgramComponent")]
        [DataContract]
        public partial class MonitoringProgramComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MonitoringProgramComponent"; } }

            /// <summary>
            /// Type of program under which the medication is monitored
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Name of the reviewing program
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of the reviewing program
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MonitoringProgramComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MonitoringProgramComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MonitoringProgramComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MonitoringProgramComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (NameElement != null) yield return NameElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                }
            }


        }


        [FhirType("AdministrationGuidelinesComponent")]
        [DataContract]
        public partial class AdministrationGuidelinesComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AdministrationGuidelinesComponent"; } }

            /// <summary>
            /// Dosage for the medication for the specific guidelines
            /// </summary>
            [FhirElement("dosage", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DosageComponent> Dosage
            {
                get { if (_dosage==null) _dosage = new List<DosageComponent>(); return _dosage; }
                set { _dosage = value; OnPropertyChanged("Dosage"); }
            }

            private List<DosageComponent> _dosage;

            /// <summary>
            /// Indication for use that apply to the specific administration guidelines
            /// </summary>
            [FhirElement("indication", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Indication
            {
                get { return _indication; }
                set { _indication = value; OnPropertyChanged("Indication"); }
            }

            private Element _indication;

            /// <summary>
            /// Characteristics of the patient that are relevant to the administration guidelines
            /// </summary>
            [FhirElement("patientCharacteristics", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PatientCharacteristicsComponent> PatientCharacteristics
            {
                get { if (_patientCharacteristics==null) _patientCharacteristics = new List<PatientCharacteristicsComponent>(); return _patientCharacteristics; }
                set { _patientCharacteristics = value; OnPropertyChanged("PatientCharacteristics"); }
            }

            private List<PatientCharacteristicsComponent> _patientCharacteristics;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdministrationGuidelinesComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Dosage != null) dest.Dosage = new List<DosageComponent>(Dosage.DeepCopy());
                    if (Indication != null) dest.Indication = (Element)Indication.DeepCopy();
                    if (PatientCharacteristics != null) dest.PatientCharacteristics = new List<PatientCharacteristicsComponent>(PatientCharacteristics.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AdministrationGuidelinesComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AdministrationGuidelinesComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;
                if (!DeepComparable.Matches(Indication, otherT.Indication)) return false;
                if ( !DeepComparable.Matches(PatientCharacteristics, otherT.PatientCharacteristics)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdministrationGuidelinesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;
                if (!DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
                if (!DeepComparable.IsExactly(PatientCharacteristics, otherT.PatientCharacteristics)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Dosage) { if (elem != null) yield return elem; }
                    if (Indication != null) yield return Indication;
                    foreach (var elem in PatientCharacteristics) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
                    if (Indication != null) yield return new ElementValue("indication", Indication);
                    foreach (var elem in PatientCharacteristics) { if (elem != null) yield return new ElementValue("patientCharacteristics", elem); }
                }
            }


        }


        [FhirType("DosageComponent")]
        [DataContract]
        public partial class DosageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DosageComponent"; } }

            /// <summary>
            /// Type of dosage
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Dosage for the medication for the specific guidelines
            /// </summary>
            [FhirElement("dosage", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Dosage> Dosage
            {
                get { if (_dosage==null) _dosage = new List<Dosage>(); return _dosage; }
                set { _dosage = value; OnPropertyChanged("Dosage"); }
            }

            private List<Dosage> _dosage;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Dosage != null) dest.Dosage = new List<Dosage>(Dosage.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DosageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Dosage) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
                }
            }


        }


        [FhirType("PatientCharacteristicsComponent")]
        [DataContract]
        public partial class PatientCharacteristicsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PatientCharacteristicsComponent"; } }

            /// <summary>
            /// Specific characteristic that is relevant to the administration guideline
            /// </summary>
            [FhirElement("characteristic", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(SimpleQuantity))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Characteristic
            {
                get { return _characteristic; }
                set { _characteristic = value; OnPropertyChanged("Characteristic"); }
            }

            private Element _characteristic;

            /// <summary>
            /// The specific characteristic
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ValueElement
            {
                get { if (_valueElement==null) _valueElement = new List<FhirString>(); return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private List<FhirString> _valueElement;

            /// <summary>
            /// The specific characteristic
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Value
            {
                get { return ValueElement != null ? ValueElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PatientCharacteristicsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Characteristic != null) dest.Characteristic = (Element)Characteristic.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = new List<FhirString>(ValueElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PatientCharacteristicsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PatientCharacteristicsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Characteristic, otherT.Characteristic)) return false;
                if ( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PatientCharacteristicsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Characteristic, otherT.Characteristic)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Characteristic != null) yield return Characteristic;
                    foreach (var elem in ValueElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Characteristic != null) yield return new ElementValue("characteristic", Characteristic);
                    foreach (var elem in ValueElement) { if (elem != null) yield return new ElementValue("value", elem); }
                }
            }


        }


        [FhirType("MedicineClassificationComponent")]
        [DataContract]
        public partial class MedicineClassificationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MedicineClassificationComponent"; } }

            /// <summary>
            /// The type of category for the medication (for example, therapeutic classification, therapeutic sub-classification)
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Specific category assigned to the medication
            /// </summary>
            [FhirElement("classification", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Classification
            {
                get { if (_classification==null) _classification = new List<CodeableConcept>(); return _classification; }
                set { _classification = value; OnPropertyChanged("Classification"); }
            }

            private List<CodeableConcept> _classification;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MedicineClassificationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Classification != null) dest.Classification = new List<CodeableConcept>(Classification.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MedicineClassificationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MedicineClassificationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Classification, otherT.Classification)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MedicineClassificationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Classification, otherT.Classification)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Classification) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Classification) { if (elem != null) yield return new ElementValue("classification", elem); }
                }
            }


        }


        [FhirType("PackagingComponent")]
        [DataContract]
        public partial class PackagingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PackagingComponent"; } }

            /// <summary>
            /// A code that defines the specific type of packaging that the medication can be found in
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// The number of product units the package would contain if fully loaded
            /// </summary>
            [FhirElement("quantity", Order=50)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackagingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PackagingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PackagingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackagingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Quantity != null) yield return Quantity;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                }
            }


        }


        [FhirType("DrugCharacteristicComponent")]
        [DataContract]
        public partial class DrugCharacteristicComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DrugCharacteristicComponent"; } }

            /// <summary>
            /// Code specifying the type of characteristic of medication
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Description of the characteristic
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(FhirString),typeof(SimpleQuantity),typeof(Base64Binary))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DrugCharacteristicComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DrugCharacteristicComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DrugCharacteristicComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DrugCharacteristicComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        [FhirType("RegulatoryComponent")]
        [DataContract]
        public partial class RegulatoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RegulatoryComponent"; } }

            /// <summary>
            /// Specifies the authority of the regulation
            /// </summary>
            [FhirElement("regulatoryAuthority", Order=40)]
            [References("Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference RegulatoryAuthority
            {
                get { return _regulatoryAuthority; }
                set { _regulatoryAuthority = value; OnPropertyChanged("RegulatoryAuthority"); }
            }

            private ResourceReference _regulatoryAuthority;

            /// <summary>
            /// Specifies if changes are allowed when dispensing a medication from a regulatory perspective
            /// </summary>
            [FhirElement("substitution", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubstitutionComponent> Substitution
            {
                get { if (_substitution==null) _substitution = new List<SubstitutionComponent>(); return _substitution; }
                set { _substitution = value; OnPropertyChanged("Substitution"); }
            }

            private List<SubstitutionComponent> _substitution;

            /// <summary>
            /// Specifies the schedule of a medication in jurisdiction
            /// </summary>
            [FhirElement("schedule", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ScheduleComponent> Schedule
            {
                get { if (_schedule==null) _schedule = new List<ScheduleComponent>(); return _schedule; }
                set { _schedule = value; OnPropertyChanged("Schedule"); }
            }

            private List<ScheduleComponent> _schedule;

            /// <summary>
            /// The maximum number of units of the medicaton that can be dispensed in a period
            /// </summary>
            [FhirElement("maxDispense", Order=70)]
            [DataMember]
            public MaxDispenseComponent MaxDispense
            {
                get { return _maxDispense; }
                set { _maxDispense = value; OnPropertyChanged("MaxDispense"); }
            }

            private MaxDispenseComponent _maxDispense;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RegulatoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RegulatoryAuthority != null) dest.RegulatoryAuthority = (ResourceReference)RegulatoryAuthority.DeepCopy();
                    if (Substitution != null) dest.Substitution = new List<SubstitutionComponent>(Substitution.DeepCopy());
                    if (Schedule != null) dest.Schedule = new List<ScheduleComponent>(Schedule.DeepCopy());
                    if (MaxDispense != null) dest.MaxDispense = (MaxDispenseComponent)MaxDispense.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RegulatoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RegulatoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RegulatoryAuthority, otherT.RegulatoryAuthority)) return false;
                if ( !DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
                if ( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
                if (!DeepComparable.Matches(MaxDispense, otherT.MaxDispense)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RegulatoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RegulatoryAuthority, otherT.RegulatoryAuthority)) return false;
                if (!DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
                if (!DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
                if (!DeepComparable.IsExactly(MaxDispense, otherT.MaxDispense)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RegulatoryAuthority != null) yield return RegulatoryAuthority;
                    foreach (var elem in Substitution) { if (elem != null) yield return elem; }
                    foreach (var elem in Schedule) { if (elem != null) yield return elem; }
                    if (MaxDispense != null) yield return MaxDispense;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RegulatoryAuthority != null) yield return new ElementValue("regulatoryAuthority", RegulatoryAuthority);
                    foreach (var elem in Substitution) { if (elem != null) yield return new ElementValue("substitution", elem); }
                    foreach (var elem in Schedule) { if (elem != null) yield return new ElementValue("schedule", elem); }
                    if (MaxDispense != null) yield return new ElementValue("maxDispense", MaxDispense);
                }
            }


        }


        [FhirType("SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }

            /// <summary>
            /// Specifies the type of substitution allowed
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Specifies if regulation allows for changes in the medication when dispensing
            /// </summary>
            [FhirElement("allowed", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean AllowedElement
            {
                get { return _allowedElement; }
                set { _allowedElement = value; OnPropertyChanged("AllowedElement"); }
            }

            private FhirBoolean _allowedElement;

            /// <summary>
            /// Specifies if regulation allows for changes in the medication when dispensing
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Allowed
            {
                get { return AllowedElement != null ? AllowedElement.Value : null; }
                set
                {
                    if (value == null)
                        AllowedElement = null;
                    else
                        AllowedElement = new FhirBoolean(value);
                    OnPropertyChanged("Allowed");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (AllowedElement != null) dest.AllowedElement = (FhirBoolean)AllowedElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubstitutionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(AllowedElement, otherT.AllowedElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(AllowedElement, otherT.AllowedElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (AllowedElement != null) yield return AllowedElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (AllowedElement != null) yield return new ElementValue("allowed", AllowedElement);
                }
            }


        }


        [FhirType("ScheduleComponent")]
        [DataContract]
        public partial class ScheduleComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ScheduleComponent"; } }

            /// <summary>
            /// Specifies the specific drug schedule
            /// </summary>
            [FhirElement("schedule", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Schedule
            {
                get { return _schedule; }
                set { _schedule = value; OnPropertyChanged("Schedule"); }
            }

            private CodeableConcept _schedule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ScheduleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Schedule != null) dest.Schedule = (CodeableConcept)Schedule.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ScheduleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ScheduleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Schedule, otherT.Schedule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ScheduleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Schedule != null) yield return Schedule;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Schedule != null) yield return new ElementValue("schedule", Schedule);
                }
            }


        }


        [FhirType("MaxDispenseComponent")]
        [DataContract]
        public partial class MaxDispenseComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MaxDispenseComponent"; } }

            /// <summary>
            /// The maximum number of units of the medicaton that can be dispensed
            /// </summary>
            [FhirElement("quantity", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// The period that applies to the maximum number of units
            /// </summary>
            [FhirElement("period", Order=50)]
            [DataMember]
            public Duration Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Duration _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MaxDispenseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (Period != null) dest.Period = (Duration)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MaxDispenseComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MaxDispenseComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MaxDispenseComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Quantity != null) yield return Quantity;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        [FhirType("KineticsComponent")]
        [DataContract]
        public partial class KineticsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "KineticsComponent"; } }

            /// <summary>
            /// The drug concentration measured at certain discrete points in time
            /// </summary>
            [FhirElement("areaUnderCurve", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SimpleQuantity> AreaUnderCurve
            {
                get { if (_areaUnderCurve==null) _areaUnderCurve = new List<SimpleQuantity>(); return _areaUnderCurve; }
                set { _areaUnderCurve = value; OnPropertyChanged("AreaUnderCurve"); }
            }

            private List<SimpleQuantity> _areaUnderCurve;

            /// <summary>
            /// The median lethal dose of a drug
            /// </summary>
            [FhirElement("lethalDose50", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SimpleQuantity> LethalDose50
            {
                get { if (_lethalDose50==null) _lethalDose50 = new List<SimpleQuantity>(); return _lethalDose50; }
                set { _lethalDose50 = value; OnPropertyChanged("LethalDose50"); }
            }

            private List<SimpleQuantity> _lethalDose50;

            /// <summary>
            /// Time required for concentration in the body to decrease by half
            /// </summary>
            [FhirElement("halfLifePeriod", Order=60)]
            [DataMember]
            public Duration HalfLifePeriod
            {
                get { return _halfLifePeriod; }
                set { _halfLifePeriod = value; OnPropertyChanged("HalfLifePeriod"); }
            }

            private Duration _halfLifePeriod;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as KineticsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AreaUnderCurve != null) dest.AreaUnderCurve = new List<SimpleQuantity>(AreaUnderCurve.DeepCopy());
                    if (LethalDose50 != null) dest.LethalDose50 = new List<SimpleQuantity>(LethalDose50.DeepCopy());
                    if (HalfLifePeriod != null) dest.HalfLifePeriod = (Duration)HalfLifePeriod.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new KineticsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as KineticsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(AreaUnderCurve, otherT.AreaUnderCurve)) return false;
                if ( !DeepComparable.Matches(LethalDose50, otherT.LethalDose50)) return false;
                if (!DeepComparable.Matches(HalfLifePeriod, otherT.HalfLifePeriod)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as KineticsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AreaUnderCurve, otherT.AreaUnderCurve)) return false;
                if (!DeepComparable.IsExactly(LethalDose50, otherT.LethalDose50)) return false;
                if (!DeepComparable.IsExactly(HalfLifePeriod, otherT.HalfLifePeriod)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in AreaUnderCurve) { if (elem != null) yield return elem; }
                    foreach (var elem in LethalDose50) { if (elem != null) yield return elem; }
                    if (HalfLifePeriod != null) yield return HalfLifePeriod;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in AreaUnderCurve) { if (elem != null) yield return new ElementValue("areaUnderCurve", elem); }
                    foreach (var elem in LethalDose50) { if (elem != null) yield return new ElementValue("lethalDose50", elem); }
                    if (HalfLifePeriod != null) yield return new ElementValue("halfLifePeriod", HalfLifePeriod);
                }
            }


        }


        /// <summary>
        /// Code that identifies this medication
        /// </summary>
        [FhirElement("code", InSummary=true, Order=90)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<MedicationKnowledgeStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationKnowledgeStatus> _statusElement;

        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationKnowledgeStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationKnowledgeStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Manufacturer of the item
        /// </summary>
        [FhirElement("manufacturer", InSummary=true, Order=110)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }

        private ResourceReference _manufacturer;

        /// <summary>
        /// powder | tablets | capsule +
        /// </summary>
        [FhirElement("doseForm", Order=120)]
        [DataMember]
        public CodeableConcept DoseForm
        {
            get { return _doseForm; }
            set { _doseForm = value; OnPropertyChanged("DoseForm"); }
        }

        private CodeableConcept _doseForm;

        /// <summary>
        /// Amount of drug in package
        /// </summary>
        [FhirElement("amount", InSummary=true, Order=130)]
        [DataMember]
        public SimpleQuantity Amount
        {
            get { return _amount; }
            set { _amount = value; OnPropertyChanged("Amount"); }
        }

        private SimpleQuantity _amount;

        /// <summary>
        /// Additional names for a medication
        /// </summary>
        [FhirElement("synonym", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> SynonymElement
        {
            get { if (_synonymElement==null) _synonymElement = new List<FhirString>(); return _synonymElement; }
            set { _synonymElement = value; OnPropertyChanged("SynonymElement"); }
        }

        private List<FhirString> _synonymElement;

        /// <summary>
        /// Additional names for a medication
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Synonym
        {
            get { return SynonymElement != null ? SynonymElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    SynonymElement = null;
                else
                    SynonymElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Synonym");
            }
        }

        /// <summary>
        /// Associated or related medication information
        /// </summary>
        [FhirElement("relatedMedicationKnowledge", Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedMedicationKnowledgeComponent> RelatedMedicationKnowledge
        {
            get { if (_relatedMedicationKnowledge==null) _relatedMedicationKnowledge = new List<RelatedMedicationKnowledgeComponent>(); return _relatedMedicationKnowledge; }
            set { _relatedMedicationKnowledge = value; OnPropertyChanged("RelatedMedicationKnowledge"); }
        }

        private List<RelatedMedicationKnowledgeComponent> _relatedMedicationKnowledge;

        /// <summary>
        /// A medication resource that is associated with this medication
        /// </summary>
        [FhirElement("associatedMedication", Order=160)]
        [References("Medication")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> AssociatedMedication
        {
            get { if (_associatedMedication==null) _associatedMedication = new List<ResourceReference>(); return _associatedMedication; }
            set { _associatedMedication = value; OnPropertyChanged("AssociatedMedication"); }
        }

        private List<ResourceReference> _associatedMedication;

        /// <summary>
        /// Category of the medication or product
        /// </summary>
        [FhirElement("productType", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ProductType
        {
            get { if (_productType==null) _productType = new List<CodeableConcept>(); return _productType; }
            set { _productType = value; OnPropertyChanged("ProductType"); }
        }

        private List<CodeableConcept> _productType;

        /// <summary>
        /// Associated documentation about the medication
        /// </summary>
        [FhirElement("monograph", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MonographComponent> Monograph
        {
            get { if (_monograph==null) _monograph = new List<MonographComponent>(); return _monograph; }
            set { _monograph = value; OnPropertyChanged("Monograph"); }
        }

        private List<MonographComponent> _monograph;

        /// <summary>
        /// Active or inactive ingredient
        /// </summary>
        [FhirElement("ingredient", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<IngredientComponent> Ingredient
        {
            get { if (_ingredient==null) _ingredient = new List<IngredientComponent>(); return _ingredient; }
            set { _ingredient = value; OnPropertyChanged("Ingredient"); }
        }

        private List<IngredientComponent> _ingredient;

        /// <summary>
        /// The instructions for preparing the medication
        /// </summary>
        [FhirElement("preparationInstruction", Order=200)]
        [DataMember]
        public Markdown PreparationInstructionElement
        {
            get { return _preparationInstructionElement; }
            set { _preparationInstructionElement = value; OnPropertyChanged("PreparationInstructionElement"); }
        }

        private Markdown _preparationInstructionElement;

        /// <summary>
        /// The instructions for preparing the medication
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PreparationInstruction
        {
            get { return PreparationInstructionElement != null ? PreparationInstructionElement.Value : null; }
            set
            {
                if (value == null)
                    PreparationInstructionElement = null;
                else
                    PreparationInstructionElement = new Markdown(value);
                OnPropertyChanged("PreparationInstruction");
            }
        }

        /// <summary>
        /// The intended or approved route of administration
        /// </summary>
        [FhirElement("intendedRoute", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> IntendedRoute
        {
            get { if (_intendedRoute==null) _intendedRoute = new List<CodeableConcept>(); return _intendedRoute; }
            set { _intendedRoute = value; OnPropertyChanged("IntendedRoute"); }
        }

        private List<CodeableConcept> _intendedRoute;

        /// <summary>
        /// The pricing of the medication
        /// </summary>
        [FhirElement("cost", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CostComponent> Cost
        {
            get { if (_cost==null) _cost = new List<CostComponent>(); return _cost; }
            set { _cost = value; OnPropertyChanged("Cost"); }
        }

        private List<CostComponent> _cost;

        /// <summary>
        /// Program under which a medication is reviewed
        /// </summary>
        [FhirElement("monitoringProgram", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MonitoringProgramComponent> MonitoringProgram
        {
            get { if (_monitoringProgram==null) _monitoringProgram = new List<MonitoringProgramComponent>(); return _monitoringProgram; }
            set { _monitoringProgram = value; OnPropertyChanged("MonitoringProgram"); }
        }

        private List<MonitoringProgramComponent> _monitoringProgram;

        /// <summary>
        /// Gudelines for administration of the medication
        /// </summary>
        [FhirElement("administrationGuidelines", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AdministrationGuidelinesComponent> AdministrationGuidelines
        {
            get { if (_administrationGuidelines==null) _administrationGuidelines = new List<AdministrationGuidelinesComponent>(); return _administrationGuidelines; }
            set { _administrationGuidelines = value; OnPropertyChanged("AdministrationGuidelines"); }
        }

        private List<AdministrationGuidelinesComponent> _administrationGuidelines;

        /// <summary>
        /// Categorization of the medication within a formulary or classification system
        /// </summary>
        [FhirElement("medicineClassification", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MedicineClassificationComponent> MedicineClassification
        {
            get { if (_medicineClassification==null) _medicineClassification = new List<MedicineClassificationComponent>(); return _medicineClassification; }
            set { _medicineClassification = value; OnPropertyChanged("MedicineClassification"); }
        }

        private List<MedicineClassificationComponent> _medicineClassification;

        /// <summary>
        /// Details about packaged medications
        /// </summary>
        [FhirElement("packaging", Order=260)]
        [DataMember]
        public PackagingComponent Packaging
        {
            get { return _packaging; }
            set { _packaging = value; OnPropertyChanged("Packaging"); }
        }

        private PackagingComponent _packaging;

        /// <summary>
        /// Specifies descriptive properties of the medicine
        /// </summary>
        [FhirElement("drugCharacteristic", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DrugCharacteristicComponent> DrugCharacteristic
        {
            get { if (_drugCharacteristic==null) _drugCharacteristic = new List<DrugCharacteristicComponent>(); return _drugCharacteristic; }
            set { _drugCharacteristic = value; OnPropertyChanged("DrugCharacteristic"); }
        }

        private List<DrugCharacteristicComponent> _drugCharacteristic;

        /// <summary>
        /// Potential clinical issue with or between medication(s)
        /// </summary>
        [FhirElement("contraindication", Order=280)]
        [References("DetectedIssue")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Contraindication
        {
            get { if (_contraindication==null) _contraindication = new List<ResourceReference>(); return _contraindication; }
            set { _contraindication = value; OnPropertyChanged("Contraindication"); }
        }

        private List<ResourceReference> _contraindication;

        /// <summary>
        /// Regulatory information about a medication
        /// </summary>
        [FhirElement("regulatory", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RegulatoryComponent> Regulatory
        {
            get { if (_regulatory==null) _regulatory = new List<RegulatoryComponent>(); return _regulatory; }
            set { _regulatory = value; OnPropertyChanged("Regulatory"); }
        }

        private List<RegulatoryComponent> _regulatory;

        /// <summary>
        /// The time course of drug absorption, distribution, metabolism and excretion of a medication from the body
        /// </summary>
        [FhirElement("kinetics", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<KineticsComponent> Kinetics
        {
            get { if (_kinetics==null) _kinetics = new List<KineticsComponent>(); return _kinetics; }
            set { _kinetics = value; OnPropertyChanged("Kinetics"); }
        }

        private List<KineticsComponent> _kinetics;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationKnowledge;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<MedicationKnowledgeStatus>)StatusElement.DeepCopy();
                if (Manufacturer != null) dest.Manufacturer = (ResourceReference)Manufacturer.DeepCopy();
                if (DoseForm != null) dest.DoseForm = (CodeableConcept)DoseForm.DeepCopy();
                if (Amount != null) dest.Amount = (SimpleQuantity)Amount.DeepCopy();
                if (SynonymElement != null) dest.SynonymElement = new List<FhirString>(SynonymElement.DeepCopy());
                if (RelatedMedicationKnowledge != null) dest.RelatedMedicationKnowledge = new List<RelatedMedicationKnowledgeComponent>(RelatedMedicationKnowledge.DeepCopy());
                if (AssociatedMedication != null) dest.AssociatedMedication = new List<ResourceReference>(AssociatedMedication.DeepCopy());
                if (ProductType != null) dest.ProductType = new List<CodeableConcept>(ProductType.DeepCopy());
                if (Monograph != null) dest.Monograph = new List<MonographComponent>(Monograph.DeepCopy());
                if (Ingredient != null) dest.Ingredient = new List<IngredientComponent>(Ingredient.DeepCopy());
                if (PreparationInstructionElement != null) dest.PreparationInstructionElement = (Markdown)PreparationInstructionElement.DeepCopy();
                if (IntendedRoute != null) dest.IntendedRoute = new List<CodeableConcept>(IntendedRoute.DeepCopy());
                if (Cost != null) dest.Cost = new List<CostComponent>(Cost.DeepCopy());
                if (MonitoringProgram != null) dest.MonitoringProgram = new List<MonitoringProgramComponent>(MonitoringProgram.DeepCopy());
                if (AdministrationGuidelines != null) dest.AdministrationGuidelines = new List<AdministrationGuidelinesComponent>(AdministrationGuidelines.DeepCopy());
                if (MedicineClassification != null) dest.MedicineClassification = new List<MedicineClassificationComponent>(MedicineClassification.DeepCopy());
                if (Packaging != null) dest.Packaging = (PackagingComponent)Packaging.DeepCopy();
                if (DrugCharacteristic != null) dest.DrugCharacteristic = new List<DrugCharacteristicComponent>(DrugCharacteristic.DeepCopy());
                if (Contraindication != null) dest.Contraindication = new List<ResourceReference>(Contraindication.DeepCopy());
                if (Regulatory != null) dest.Regulatory = new List<RegulatoryComponent>(Regulatory.DeepCopy());
                if (Kinetics != null) dest.Kinetics = new List<KineticsComponent>(Kinetics.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationKnowledge());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationKnowledge;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.Matches(DoseForm, otherT.DoseForm)) return false;
            if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
            if ( !DeepComparable.Matches(SynonymElement, otherT.SynonymElement)) return false;
            if ( !DeepComparable.Matches(RelatedMedicationKnowledge, otherT.RelatedMedicationKnowledge)) return false;
            if ( !DeepComparable.Matches(AssociatedMedication, otherT.AssociatedMedication)) return false;
            if ( !DeepComparable.Matches(ProductType, otherT.ProductType)) return false;
            if ( !DeepComparable.Matches(Monograph, otherT.Monograph)) return false;
            if ( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.Matches(PreparationInstructionElement, otherT.PreparationInstructionElement)) return false;
            if ( !DeepComparable.Matches(IntendedRoute, otherT.IntendedRoute)) return false;
            if ( !DeepComparable.Matches(Cost, otherT.Cost)) return false;
            if ( !DeepComparable.Matches(MonitoringProgram, otherT.MonitoringProgram)) return false;
            if ( !DeepComparable.Matches(AdministrationGuidelines, otherT.AdministrationGuidelines)) return false;
            if ( !DeepComparable.Matches(MedicineClassification, otherT.MedicineClassification)) return false;
            if (!DeepComparable.Matches(Packaging, otherT.Packaging)) return false;
            if ( !DeepComparable.Matches(DrugCharacteristic, otherT.DrugCharacteristic)) return false;
            if ( !DeepComparable.Matches(Contraindication, otherT.Contraindication)) return false;
            if ( !DeepComparable.Matches(Regulatory, otherT.Regulatory)) return false;
            if ( !DeepComparable.Matches(Kinetics, otherT.Kinetics)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationKnowledge;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.IsExactly(DoseForm, otherT.DoseForm)) return false;
            if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
            if (!DeepComparable.IsExactly(SynonymElement, otherT.SynonymElement)) return false;
            if (!DeepComparable.IsExactly(RelatedMedicationKnowledge, otherT.RelatedMedicationKnowledge)) return false;
            if (!DeepComparable.IsExactly(AssociatedMedication, otherT.AssociatedMedication)) return false;
            if (!DeepComparable.IsExactly(ProductType, otherT.ProductType)) return false;
            if (!DeepComparable.IsExactly(Monograph, otherT.Monograph)) return false;
            if (!DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.IsExactly(PreparationInstructionElement, otherT.PreparationInstructionElement)) return false;
            if (!DeepComparable.IsExactly(IntendedRoute, otherT.IntendedRoute)) return false;
            if (!DeepComparable.IsExactly(Cost, otherT.Cost)) return false;
            if (!DeepComparable.IsExactly(MonitoringProgram, otherT.MonitoringProgram)) return false;
            if (!DeepComparable.IsExactly(AdministrationGuidelines, otherT.AdministrationGuidelines)) return false;
            if (!DeepComparable.IsExactly(MedicineClassification, otherT.MedicineClassification)) return false;
            if (!DeepComparable.IsExactly(Packaging, otherT.Packaging)) return false;
            if (!DeepComparable.IsExactly(DrugCharacteristic, otherT.DrugCharacteristic)) return false;
            if (!DeepComparable.IsExactly(Contraindication, otherT.Contraindication)) return false;
            if (!DeepComparable.IsExactly(Regulatory, otherT.Regulatory)) return false;
            if (!DeepComparable.IsExactly(Kinetics, otherT.Kinetics)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Code != null) yield return Code;
                if (StatusElement != null) yield return StatusElement;
                if (Manufacturer != null) yield return Manufacturer;
                if (DoseForm != null) yield return DoseForm;
                if (Amount != null) yield return Amount;
                foreach (var elem in SynonymElement) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedMedicationKnowledge) { if (elem != null) yield return elem; }
                foreach (var elem in AssociatedMedication) { if (elem != null) yield return elem; }
                foreach (var elem in ProductType) { if (elem != null) yield return elem; }
                foreach (var elem in Monograph) { if (elem != null) yield return elem; }
                foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
                if (PreparationInstructionElement != null) yield return PreparationInstructionElement;
                foreach (var elem in IntendedRoute) { if (elem != null) yield return elem; }
                foreach (var elem in Cost) { if (elem != null) yield return elem; }
                foreach (var elem in MonitoringProgram) { if (elem != null) yield return elem; }
                foreach (var elem in AdministrationGuidelines) { if (elem != null) yield return elem; }
                foreach (var elem in MedicineClassification) { if (elem != null) yield return elem; }
                if (Packaging != null) yield return Packaging;
                foreach (var elem in DrugCharacteristic) { if (elem != null) yield return elem; }
                foreach (var elem in Contraindication) { if (elem != null) yield return elem; }
                foreach (var elem in Regulatory) { if (elem != null) yield return elem; }
                foreach (var elem in Kinetics) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Code != null) yield return new ElementValue("code", Code);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (DoseForm != null) yield return new ElementValue("doseForm", DoseForm);
                if (Amount != null) yield return new ElementValue("amount", Amount);
                foreach (var elem in SynonymElement) { if (elem != null) yield return new ElementValue("synonym", elem); }
                foreach (var elem in RelatedMedicationKnowledge) { if (elem != null) yield return new ElementValue("relatedMedicationKnowledge", elem); }
                foreach (var elem in AssociatedMedication) { if (elem != null) yield return new ElementValue("associatedMedication", elem); }
                foreach (var elem in ProductType) { if (elem != null) yield return new ElementValue("productType", elem); }
                foreach (var elem in Monograph) { if (elem != null) yield return new ElementValue("monograph", elem); }
                foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                if (PreparationInstructionElement != null) yield return new ElementValue("preparationInstruction", PreparationInstructionElement);
                foreach (var elem in IntendedRoute) { if (elem != null) yield return new ElementValue("intendedRoute", elem); }
                foreach (var elem in Cost) { if (elem != null) yield return new ElementValue("cost", elem); }
                foreach (var elem in MonitoringProgram) { if (elem != null) yield return new ElementValue("monitoringProgram", elem); }
                foreach (var elem in AdministrationGuidelines) { if (elem != null) yield return new ElementValue("administrationGuidelines", elem); }
                foreach (var elem in MedicineClassification) { if (elem != null) yield return new ElementValue("medicineClassification", elem); }
                if (Packaging != null) yield return new ElementValue("packaging", Packaging);
                foreach (var elem in DrugCharacteristic) { if (elem != null) yield return new ElementValue("drugCharacteristic", elem); }
                foreach (var elem in Contraindication) { if (elem != null) yield return new ElementValue("contraindication", elem); }
                foreach (var elem in Regulatory) { if (elem != null) yield return new ElementValue("regulatory", elem); }
                foreach (var elem in Kinetics) { if (elem != null) yield return new ElementValue("kinetics", elem); }
            }
        }

    }

}
