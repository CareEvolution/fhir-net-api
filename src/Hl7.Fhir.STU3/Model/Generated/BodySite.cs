﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Specific and identified anatomical location
    /// </summary>
    [FhirType("BodySite", IsResource=true)]
    [DataContract]
    public partial class BodySite : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.BodySite; } }
        [NotMapped]
        public override string TypeName { get { return "BodySite"; } }


        /// <summary>
        /// Bodysite identifier
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
        /// Whether this body site record is in active use
        /// </summary>
        [FhirElement("active", InSummary=true, Order=100)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// Whether this body site record is in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// Named anatomical location
        /// </summary>
        [FhirElement("code", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Modification to location code
        /// </summary>
        [FhirElement("qualifier", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Qualifier
        {
            get { if (_qualifier==null) _qualifier = new List<CodeableConcept>(); return _qualifier; }
            set { _qualifier = value; OnPropertyChanged("Qualifier"); }
        }

        private List<CodeableConcept> _qualifier;

        /// <summary>
        /// Anatomical location description
        /// </summary>
        [FhirElement("description", InSummary=true, Order=130)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Anatomical location description
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Attached images
        /// </summary>
        [FhirElement("image", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> Image
        {
            get { if (_image==null) _image = new List<Attachment>(); return _image; }
            set { _image = value; OnPropertyChanged("Image"); }
        }

        private List<Attachment> _image;

        /// <summary>
        /// Who this is about
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=150)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as BodySite;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Qualifier != null) dest.Qualifier = new List<CodeableConcept>(Qualifier.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Image != null) dest.Image = new List<Attachment>(Image.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new BodySite());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as BodySite;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(Qualifier, otherT.Qualifier)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Image, otherT.Image)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as BodySite;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Qualifier, otherT.Qualifier)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Image, otherT.Image)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                if (Code != null) yield return Code;
                foreach (var elem in Qualifier) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Image) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
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
                if (Code != null) yield return new ElementValue("code", Code);
                foreach (var elem in Qualifier) { if (elem != null) yield return new ElementValue("qualifier", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
            }
        }

    }

}