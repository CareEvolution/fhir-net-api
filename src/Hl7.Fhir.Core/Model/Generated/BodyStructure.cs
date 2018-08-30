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
    /// Specific and identified anatomical structure
    /// </summary>
    [FhirType("BodyStructure", IsResource=true)]
    [DataContract]
    public partial class BodyStructure : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.BodyStructure; } }
        [NotMapped]
        public override string TypeName { get { return "BodyStructure"; } }


        /// <summary>
        /// Bodystructure identifier
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
        /// Whether this record is in active use
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
        /// Whether this record is in active use
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
        /// Kind of Structure
        /// </summary>
        [FhirElement("morphology", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Morphology
        {
            get { return _morphology; }
            set { _morphology = value; OnPropertyChanged("Morphology"); }
        }

        private CodeableConcept _morphology;

        /// <summary>
        /// Body site
        /// </summary>
        [FhirElement("location", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private CodeableConcept _location;

        /// <summary>
        /// Body site modifier
        /// </summary>
        [FhirElement("locationQualifier", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> LocationQualifier
        {
            get { if (_locationQualifier==null) _locationQualifier = new List<CodeableConcept>(); return _locationQualifier; }
            set { _locationQualifier = value; OnPropertyChanged("LocationQualifier"); }
        }

        private List<CodeableConcept> _locationQualifier;

        /// <summary>
        /// Text description
        /// </summary>
        [FhirElement("description", InSummary=true, Order=140)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Text description
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
        [FhirElement("image", Order=150)]
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
        [FhirElement("patient", InSummary=true, Order=160)]
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
            var dest = other as BodyStructure;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Morphology != null) dest.Morphology = (CodeableConcept)Morphology.DeepCopy();
                if (Location != null) dest.Location = (CodeableConcept)Location.DeepCopy();
                if (LocationQualifier != null) dest.LocationQualifier = new List<CodeableConcept>(LocationQualifier.DeepCopy());
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
             return CopyTo(new BodyStructure());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as BodyStructure;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.Matches(Morphology, otherT.Morphology)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if ( !DeepComparable.Matches(LocationQualifier, otherT.LocationQualifier)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Image, otherT.Image)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as BodyStructure;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Morphology, otherT.Morphology)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(LocationQualifier, otherT.LocationQualifier)) return false;
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
                if (Morphology != null) yield return Morphology;
                if (Location != null) yield return Location;
                foreach (var elem in LocationQualifier) { if (elem != null) yield return elem; }
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
                if (Morphology != null) yield return new ElementValue("morphology", Morphology);
                if (Location != null) yield return new ElementValue("location", Location);
                foreach (var elem in LocationQualifier) { if (elem != null) yield return new ElementValue("locationQualifier", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
            }
        }

    }

}
