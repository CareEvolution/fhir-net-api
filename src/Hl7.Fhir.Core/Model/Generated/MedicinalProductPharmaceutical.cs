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
    /// A pharmaceutical product described in terms of its composition and dose form
    /// </summary>
    [FhirType("MedicinalProductPharmaceutical", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductPharmaceutical : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductPharmaceutical; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductPharmaceutical"; } }


        [FhirType("CharacteristicsComponent")]
        [DataContract]
        public partial class CharacteristicsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CharacteristicsComponent"; } }

            /// <summary>
            /// A coded characteristic
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// The status of characteristic e.g. assigned or pending
            /// </summary>
            [FhirElement("status", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Status
            {
                get { return _status; }
                set { _status = value; OnPropertyChanged("Status"); }
            }

            private CodeableConcept _status;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CharacteristicsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Status != null) dest.Status = (CodeableConcept)Status.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CharacteristicsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CharacteristicsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Status, otherT.Status)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CharacteristicsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Status, otherT.Status)) return false;

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
                }
            }


        }


        /// <summary>
        /// An identifier for the pharmaceutical medicinal product
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// The administrable dose form, after necessary reconstitution
        /// </summary>
        [FhirElement("administrableDoseForm", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept AdministrableDoseForm
        {
            get { return _administrableDoseForm; }
            set { _administrableDoseForm = value; OnPropertyChanged("AdministrableDoseForm"); }
        }

        private CodeableConcept _administrableDoseForm;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("unitOfPresentation", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept UnitOfPresentation
        {
            get { return _unitOfPresentation; }
            set { _unitOfPresentation = value; OnPropertyChanged("UnitOfPresentation"); }
        }

        private CodeableConcept _unitOfPresentation;

        /// <summary>
        /// The path by which the pharmaceutical product is taken into or makes contact with the body
        /// </summary>
        [FhirElement("routeOfAdministration", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<CodeableConcept> RouteOfAdministration
        {
            get { if (_routeOfAdministration==null) _routeOfAdministration = new List<CodeableConcept>(); return _routeOfAdministration; }
            set { _routeOfAdministration = value; OnPropertyChanged("RouteOfAdministration"); }
        }

        private List<CodeableConcept> _routeOfAdministration;

        /// <summary>
        /// Ingredient
        /// </summary>
        [FhirElement("ingredient", InSummary=true, Order=130)]
        [References("MedicinalProductIngredient")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Ingredient
        {
            get { if (_ingredient==null) _ingredient = new List<ResourceReference>(); return _ingredient; }
            set { _ingredient = value; OnPropertyChanged("Ingredient"); }
        }

        private List<ResourceReference> _ingredient;

        /// <summary>
        /// Accompanying device
        /// </summary>
        [FhirElement("device", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> DeviceElement
        {
            get { if (_deviceElement==null) _deviceElement = new List<FhirString>(); return _deviceElement; }
            set { _deviceElement = value; OnPropertyChanged("DeviceElement"); }
        }

        private List<FhirString> _deviceElement;

        /// <summary>
        /// Accompanying device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Device
        {
            get { return DeviceElement != null ? DeviceElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    DeviceElement = null;
                else
                    DeviceElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Device");
            }
        }

        /// <summary>
        /// Characteristics e.g. a products onset of action
        /// </summary>
        [FhirElement("characteristics", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CharacteristicsComponent> Characteristics
        {
            get { if (_characteristics==null) _characteristics = new List<CharacteristicsComponent>(); return _characteristics; }
            set { _characteristics = value; OnPropertyChanged("Characteristics"); }
        }

        private List<CharacteristicsComponent> _characteristics;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductPharmaceutical;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (AdministrableDoseForm != null) dest.AdministrableDoseForm = (CodeableConcept)AdministrableDoseForm.DeepCopy();
                if (UnitOfPresentation != null) dest.UnitOfPresentation = (CodeableConcept)UnitOfPresentation.DeepCopy();
                if (RouteOfAdministration != null) dest.RouteOfAdministration = new List<CodeableConcept>(RouteOfAdministration.DeepCopy());
                if (Ingredient != null) dest.Ingredient = new List<ResourceReference>(Ingredient.DeepCopy());
                if (DeviceElement != null) dest.DeviceElement = new List<FhirString>(DeviceElement.DeepCopy());
                if (Characteristics != null) dest.Characteristics = new List<CharacteristicsComponent>(Characteristics.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProductPharmaceutical());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductPharmaceutical;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(AdministrableDoseForm, otherT.AdministrableDoseForm)) return false;
            if (!DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
            if ( !DeepComparable.Matches(RouteOfAdministration, otherT.RouteOfAdministration)) return false;
            if ( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            if ( !DeepComparable.Matches(DeviceElement, otherT.DeviceElement)) return false;
            if ( !DeepComparable.Matches(Characteristics, otherT.Characteristics)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductPharmaceutical;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(AdministrableDoseForm, otherT.AdministrableDoseForm)) return false;
            if (!DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
            if (!DeepComparable.IsExactly(RouteOfAdministration, otherT.RouteOfAdministration)) return false;
            if (!DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.IsExactly(DeviceElement, otherT.DeviceElement)) return false;
            if (!DeepComparable.IsExactly(Characteristics, otherT.Characteristics)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (AdministrableDoseForm != null) yield return AdministrableDoseForm;
                if (UnitOfPresentation != null) yield return UnitOfPresentation;
                foreach (var elem in RouteOfAdministration) { if (elem != null) yield return elem; }
                foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
                foreach (var elem in DeviceElement) { if (elem != null) yield return elem; }
                foreach (var elem in Characteristics) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (AdministrableDoseForm != null) yield return new ElementValue("administrableDoseForm", AdministrableDoseForm);
                if (UnitOfPresentation != null) yield return new ElementValue("unitOfPresentation", UnitOfPresentation);
                foreach (var elem in RouteOfAdministration) { if (elem != null) yield return new ElementValue("routeOfAdministration", elem); }
                foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                foreach (var elem in DeviceElement) { if (elem != null) yield return new ElementValue("device", elem); }
                foreach (var elem in Characteristics) { if (elem != null) yield return new ElementValue("characteristics", elem); }
            }
        }

    }

}
