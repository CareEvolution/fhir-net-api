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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// MedicinalProductContraindication
    /// </summary>
    [FhirType("MedicinalProductContraindication", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductContraindication : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductContraindication; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductContraindication"; } }


        [FhirType("OtherTherapyComponent")]
        [DataContract]
        public partial class OtherTherapyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OtherTherapyComponent"; } }

            /// <summary>
            /// The type of relationship between the medicinal product indication or contraindication and another therapy
            /// </summary>
            [FhirElement("therapyRelationshipType", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept TherapyRelationshipType
            {
                get { return _therapyRelationshipType; }
                set { _therapyRelationshipType = value; OnPropertyChanged("TherapyRelationshipType"); }
            }

            private CodeableConcept _therapyRelationshipType;

            /// <summary>
            /// Reference to a specific medication (active substance, medicinal product or class of products) as part of an indication or contraindication
            /// </summary>
            [FhirElement("medication", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Medication
            {
                get { return _medication; }
                set { _medication = value; OnPropertyChanged("Medication"); }
            }

            private Element _medication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OtherTherapyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TherapyRelationshipType != null) dest.TherapyRelationshipType = (CodeableConcept)TherapyRelationshipType.DeepCopy();
                    if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OtherTherapyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OtherTherapyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TherapyRelationshipType, otherT.TherapyRelationshipType)) return false;
                if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OtherTherapyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TherapyRelationshipType, otherT.TherapyRelationshipType)) return false;
                if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TherapyRelationshipType != null) yield return TherapyRelationshipType;
                    if (Medication != null) yield return Medication;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TherapyRelationshipType != null) yield return new ElementValue("therapyRelationshipType", TherapyRelationshipType);
                    if (Medication != null) yield return new ElementValue("medication", Medication);
                }
            }


        }


        [FhirType("PopulationComponent")]
        [DataContract]
        public partial class PopulationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PopulationComponent"; } }

            /// <summary>
            /// The age of the specific population
            /// </summary>
            [FhirElement("age", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Range),typeof(CodeableConcept))]
            [DataMember]
            public Element Age
            {
                get { return _age; }
                set { _age = value; OnPropertyChanged("Age"); }
            }

            private Element _age;

            /// <summary>
            /// The gender of the specific population
            /// </summary>
            [FhirElement("gender", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Gender
            {
                get { return _gender; }
                set { _gender = value; OnPropertyChanged("Gender"); }
            }

            private CodeableConcept _gender;

            /// <summary>
            /// Race of the specific population
            /// </summary>
            [FhirElement("race", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept Race
            {
                get { return _race; }
                set { _race = value; OnPropertyChanged("Race"); }
            }

            private CodeableConcept _race;

            /// <summary>
            /// The existing physiological conditions of the specific population to which this applies
            /// </summary>
            [FhirElement("physiologicalCondition", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept PhysiologicalCondition
            {
                get { return _physiologicalCondition; }
                set { _physiologicalCondition = value; OnPropertyChanged("PhysiologicalCondition"); }
            }

            private CodeableConcept _physiologicalCondition;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PopulationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Age != null) dest.Age = (Element)Age.DeepCopy();
                    if (Gender != null) dest.Gender = (CodeableConcept)Gender.DeepCopy();
                    if (Race != null) dest.Race = (CodeableConcept)Race.DeepCopy();
                    if (PhysiologicalCondition != null) dest.PhysiologicalCondition = (CodeableConcept)PhysiologicalCondition.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PopulationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Age, otherT.Age)) return false;
                if (!DeepComparable.Matches(Gender, otherT.Gender)) return false;
                if (!DeepComparable.Matches(Race, otherT.Race)) return false;
                if (!DeepComparable.Matches(PhysiologicalCondition, otherT.PhysiologicalCondition)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Age, otherT.Age)) return false;
                if (!DeepComparable.IsExactly(Gender, otherT.Gender)) return false;
                if (!DeepComparable.IsExactly(Race, otherT.Race)) return false;
                if (!DeepComparable.IsExactly(PhysiologicalCondition, otherT.PhysiologicalCondition)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Age != null) yield return Age;
                    if (Gender != null) yield return Gender;
                    if (Race != null) yield return Race;
                    if (PhysiologicalCondition != null) yield return PhysiologicalCondition;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Age != null) yield return new ElementValue("age", Age);
                    if (Gender != null) yield return new ElementValue("gender", Gender);
                    if (Race != null) yield return new ElementValue("race", Race);
                    if (PhysiologicalCondition != null) yield return new ElementValue("physiologicalCondition", PhysiologicalCondition);
                }
            }


        }


        /// <summary>
        /// The medication for which this is an indication
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=90)]
        [References("MedicinalProduct","Medication")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Subject
        {
            get { if (_subject==null) _subject = new List<ResourceReference>(); return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private List<ResourceReference> _subject;

        /// <summary>
        /// The disease, symptom or procedure for the contraindication
        /// </summary>
        [FhirElement("disease", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept Disease
        {
            get { return _disease; }
            set { _disease = value; OnPropertyChanged("Disease"); }
        }

        private CodeableConcept _disease;

        /// <summary>
        /// The status of the disease or symptom for the contraindication
        /// </summary>
        [FhirElement("diseaseStatus", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept DiseaseStatus
        {
            get { return _diseaseStatus; }
            set { _diseaseStatus = value; OnPropertyChanged("DiseaseStatus"); }
        }

        private CodeableConcept _diseaseStatus;

        /// <summary>
        /// A comorbidity (concurrent condition) or coinfection
        /// </summary>
        [FhirElement("comorbidity", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Comorbidity
        {
            get { if (_comorbidity==null) _comorbidity = new List<CodeableConcept>(); return _comorbidity; }
            set { _comorbidity = value; OnPropertyChanged("Comorbidity"); }
        }

        private List<CodeableConcept> _comorbidity;

        /// <summary>
        /// Information about the use of the medicinal product in relation to other therapies as part of the indication
        /// </summary>
        [FhirElement("therapeuticIndication", InSummary=true, Order=130)]
        [References("MedicinalProductIndication")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> TherapeuticIndication
        {
            get { if (_therapeuticIndication==null) _therapeuticIndication = new List<ResourceReference>(); return _therapeuticIndication; }
            set { _therapeuticIndication = value; OnPropertyChanged("TherapeuticIndication"); }
        }

        private List<ResourceReference> _therapeuticIndication;

        /// <summary>
        /// Information about the use of the medicinal product in relation to other therapies described as part of the indication
        /// </summary>
        [FhirElement("otherTherapy", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OtherTherapyComponent> OtherTherapy
        {
            get { if (_otherTherapy==null) _otherTherapy = new List<OtherTherapyComponent>(); return _otherTherapy; }
            set { _otherTherapy = value; OnPropertyChanged("OtherTherapy"); }
        }

        private List<OtherTherapyComponent> _otherTherapy;

        /// <summary>
        /// The population group to which this applies
        /// </summary>
        [FhirElement("population", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PopulationComponent> Population
        {
            get { if (_population==null) _population = new List<PopulationComponent>(); return _population; }
            set { _population = value; OnPropertyChanged("Population"); }
        }

        private List<PopulationComponent> _population;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductContraindication;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Subject != null) dest.Subject = new List<ResourceReference>(Subject.DeepCopy());
                if (Disease != null) dest.Disease = (CodeableConcept)Disease.DeepCopy();
                if (DiseaseStatus != null) dest.DiseaseStatus = (CodeableConcept)DiseaseStatus.DeepCopy();
                if (Comorbidity != null) dest.Comorbidity = new List<CodeableConcept>(Comorbidity.DeepCopy());
                if (TherapeuticIndication != null) dest.TherapeuticIndication = new List<ResourceReference>(TherapeuticIndication.DeepCopy());
                if (OtherTherapy != null) dest.OtherTherapy = new List<OtherTherapyComponent>(OtherTherapy.DeepCopy());
                if (Population != null) dest.Population = new List<PopulationComponent>(Population.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProductContraindication());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductContraindication;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Disease, otherT.Disease)) return false;
            if (!DeepComparable.Matches(DiseaseStatus, otherT.DiseaseStatus)) return false;
            if ( !DeepComparable.Matches(Comorbidity, otherT.Comorbidity)) return false;
            if ( !DeepComparable.Matches(TherapeuticIndication, otherT.TherapeuticIndication)) return false;
            if ( !DeepComparable.Matches(OtherTherapy, otherT.OtherTherapy)) return false;
            if ( !DeepComparable.Matches(Population, otherT.Population)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductContraindication;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Disease, otherT.Disease)) return false;
            if (!DeepComparable.IsExactly(DiseaseStatus, otherT.DiseaseStatus)) return false;
            if (!DeepComparable.IsExactly(Comorbidity, otherT.Comorbidity)) return false;
            if (!DeepComparable.IsExactly(TherapeuticIndication, otherT.TherapeuticIndication)) return false;
            if (!DeepComparable.IsExactly(OtherTherapy, otherT.OtherTherapy)) return false;
            if (!DeepComparable.IsExactly(Population, otherT.Population)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Subject) { if (elem != null) yield return elem; }
                if (Disease != null) yield return Disease;
                if (DiseaseStatus != null) yield return DiseaseStatus;
                foreach (var elem in Comorbidity) { if (elem != null) yield return elem; }
                foreach (var elem in TherapeuticIndication) { if (elem != null) yield return elem; }
                foreach (var elem in OtherTherapy) { if (elem != null) yield return elem; }
                foreach (var elem in Population) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
                if (Disease != null) yield return new ElementValue("disease", Disease);
                if (DiseaseStatus != null) yield return new ElementValue("diseaseStatus", DiseaseStatus);
                foreach (var elem in Comorbidity) { if (elem != null) yield return new ElementValue("comorbidity", elem); }
                foreach (var elem in TherapeuticIndication) { if (elem != null) yield return new ElementValue("therapeuticIndication", elem); }
                foreach (var elem in OtherTherapy) { if (elem != null) yield return new ElementValue("otherTherapy", elem); }
                foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", elem); }
            }
        }

    }

}
