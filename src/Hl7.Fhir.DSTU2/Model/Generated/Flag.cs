using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.DSTU2;
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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// Key information to flag to healthcare providers
    /// </summary>
    [FhirType("Flag", IsResource = true)]
    [DataContract]
    public partial class Flag : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Flag; } }
        [NotMapped]
        public override string TypeName { get { return "Flag"; } }

        /// <summary>
        /// Indicates whether this flag is active and needs to be displayed to a user, or whether it is no longer needed or entered in error.
        /// (url: http://hl7.org/fhir/ValueSet/flag-status)
        /// </summary>
        [FhirEnumeration("FlagStatus")]
        public enum FlagStatus
        {
            /// <summary>
            /// A current flag that should be displayed to a user. A system may use the category to determine which roles should view the flag.
            /// (system: http://hl7.org/fhir/flag-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/flag-status"), Description("Active")]
            Active,
            /// <summary>
            /// The flag does not need to be displayed any more.
            /// (system: http://hl7.org/fhir/flag-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/flag-status"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// The flag was added in error, and should no longer be displayed.
            /// (system: http://hl7.org/fhir/flag-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/flag-status"), Description("Entered in Error")]
            EnteredInError,
        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 90)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Clinical, administrative, etc.
        /// </summary>
        [FhirElement("category", InSummary = true, Order = 100)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 110)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<FlagStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<FlagStatus> _statusElement;

        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FlagStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<FlagStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Time period when flag is active
        /// </summary>
        [FhirElement("period", InSummary = true, Order = 120)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Who/What is flag about?
        /// </summary>
        [FhirElement("subject", InSummary = true, Order = 130)]
        [References("Patient", "Location", "Group", "Organization", "Practitioner")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Alert relevant during encounter
        /// </summary>
        [FhirElement("encounter", InSummary = true, Order = 140)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Flag creator
        /// </summary>
        [FhirElement("author", InSummary = true, Order = 150)]
        [References("Device", "Organization", "Patient", "Practitioner")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Partially deaf, Requires easy open caps, No permanent address, etc.
        /// </summary>
        [FhirElement("code", InSummary = true, Order = 160)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Flag;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<FlagStatus>)StatusElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Flag());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Flag;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Flag;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Category != null) yield return Category;
                if (StatusElement != null) yield return StatusElement;
                if (Period != null) yield return Period;
                if (Subject != null) yield return Subject;
                if (Encounter != null) yield return Encounter;
                if (Author != null) yield return Author;
                if (Code != null) yield return Code;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Category != null) yield return new ElementValue("category", Category);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Period != null) yield return new ElementValue("period", Period);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Author != null) yield return new ElementValue("author", Author);
                if (Code != null) yield return new ElementValue("code", Code);
            }
        }

    }

}
