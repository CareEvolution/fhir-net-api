using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
    /// Definition of a parameter to a module
    /// </summary>
    [FhirType("ParameterDefinition")]
    [DataContract]
    public partial class ParameterDefinition : Element
    {
        [NotMapped]
        public override string TypeName { get { return "ParameterDefinition"; } }


        /// <summary>
        /// Name used to access the parameter value
        /// </summary>
        [FhirElement("name", InSummary=true, Order=30)]
        [DataMember]
        public Code NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private Code _nameElement;

        /// <summary>
        /// Name used to access the parameter value
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
                    NameElement = new Code(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// in | out
        /// </summary>
        [FhirElement("use", InSummary=true, Order=40)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<OperationParameterUse> UseElement
        {
            get { return _useElement; }
            set { _useElement = value; OnPropertyChanged("UseElement"); }
        }

        private Code<OperationParameterUse> _useElement;

        /// <summary>
        /// in | out
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public OperationParameterUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (value == null)
                    UseElement = null;
                else
                    UseElement = new Code<OperationParameterUse>(value);
                OnPropertyChanged("Use");
            }
        }

        /// <summary>
        /// Minimum cardinality
        /// </summary>
        [FhirElement("min", InSummary=true, Order=50)]
        [DataMember]
        public Integer MinElement
        {
            get { return _minElement; }
            set { _minElement = value; OnPropertyChanged("MinElement"); }
        }

        private Integer _minElement;

        /// <summary>
        /// Minimum cardinality
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Min
        {
            get { return MinElement != null ? MinElement.Value : null; }
            set
            {
                if (value == null)
                    MinElement = null;
                else
                    MinElement = new Integer(value);
                OnPropertyChanged("Min");
            }
        }

        /// <summary>
        /// Maximum cardinality (a number of *)
        /// </summary>
        [FhirElement("max", InSummary=true, Order=60)]
        [DataMember]
        public FhirString MaxElement
        {
            get { return _maxElement; }
            set { _maxElement = value; OnPropertyChanged("MaxElement"); }
        }

        private FhirString _maxElement;

        /// <summary>
        /// Maximum cardinality (a number of *)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Max
        {
            get { return MaxElement != null ? MaxElement.Value : null; }
            set
            {
                if (value == null)
                    MaxElement = null;
                else
                    MaxElement = new FhirString(value);
                OnPropertyChanged("Max");
            }
        }

        /// <summary>
        /// A brief description of the parameter
        /// </summary>
        [FhirElement("documentation", InSummary=true, Order=70)]
        [DataMember]
        public FhirString DocumentationElement
        {
            get { return _documentationElement; }
            set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
        }

        private FhirString _documentationElement;

        /// <summary>
        /// A brief description of the parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Documentation
        {
            get { return DocumentationElement != null ? DocumentationElement.Value : null; }
            set
            {
                if (value == null)
                    DocumentationElement = null;
                else
                    DocumentationElement = new FhirString(value);
                OnPropertyChanged("Documentation");
            }
        }

        /// <summary>
        /// What type of value
        /// </summary>
        [FhirElement("type", InSummary=true, Order=80)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<FHIRAllTypes> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<FHIRAllTypes> _typeElement;

        /// <summary>
        /// What type of value
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FHIRAllTypes? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<FHIRAllTypes>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// What profile the value is expected to be
        /// </summary>
        [FhirElement("profile", InSummary=true, Order=90)]
        [DataMember]
        public Canonical ProfileElement
        {
            get { return _profileElement; }
            set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
        }

        private Canonical _profileElement;

        /// <summary>
        /// What profile the value is expected to be
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Profile
        {
            get { return ProfileElement != null ? ProfileElement.Value : null; }
            set
            {
                if (value == null)
                    ProfileElement = null;
                else
                    ProfileElement = new Canonical(value);
                OnPropertyChanged("Profile");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ParameterDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (NameElement != null) dest.NameElement = (Code)NameElement.DeepCopy();
                if (UseElement != null) dest.UseElement = (Code<OperationParameterUse>)UseElement.DeepCopy();
                if (MinElement != null) dest.MinElement = (Integer)MinElement.DeepCopy();
                if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (Code<FHIRAllTypes>)TypeElement.DeepCopy();
                if (ProfileElement != null) dest.ProfileElement = (Canonical)ProfileElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ParameterDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ParameterDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
            if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;
            if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ParameterDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
            if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;
            if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (NameElement != null) yield return NameElement;
                if (UseElement != null) yield return UseElement;
                if (MinElement != null) yield return MinElement;
                if (MaxElement != null) yield return MaxElement;
                if (DocumentationElement != null) yield return DocumentationElement;
                if (TypeElement != null) yield return TypeElement;
                if (ProfileElement != null) yield return ProfileElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (UseElement != null) yield return new ElementValue("use", false, UseElement);
                if (MinElement != null) yield return new ElementValue("min", false, MinElement);
                if (MaxElement != null) yield return new ElementValue("max", false, MaxElement);
                if (DocumentationElement != null) yield return new ElementValue("documentation", false, DocumentationElement);
                if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                if (ProfileElement != null) yield return new ElementValue("profile", false, ProfileElement);
            }
        }

    }

}
