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
    /// Metadata about a resource
    /// </summary>
    [FhirType("Meta")]
    [DataContract]
    public partial class Meta : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Meta"; } }


        /// <summary>
        /// Version specific identifier
        /// </summary>
        [FhirElement("versionId", InSummary=true, Order=30)]
        [DataMember]
        public Id VersionIdElement
        {
            get { return _versionIdElement; }
            set { _versionIdElement = value; OnPropertyChanged("VersionIdElement"); }
        }

        private Id _versionIdElement;

        /// <summary>
        /// Version specific identifier
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string VersionId
        {
            get { return VersionIdElement != null ? VersionIdElement.Value : null; }
            set
            {
                if (value == null)
                    VersionIdElement = null;
                else
                    VersionIdElement = new Id(value);
                OnPropertyChanged("VersionId");
            }
        }

        /// <summary>
        /// When the resource version last changed
        /// </summary>
        [FhirElement("lastUpdated", InSummary=true, Order=40)]
        [DataMember]
        public Instant LastUpdatedElement
        {
            get { return _lastUpdatedElement; }
            set { _lastUpdatedElement = value; OnPropertyChanged("LastUpdatedElement"); }
        }

        private Instant _lastUpdatedElement;

        /// <summary>
        /// When the resource version last changed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? LastUpdated
        {
            get { return LastUpdatedElement != null ? LastUpdatedElement.Value : null; }
            set
            {
                if (value == null)
                    LastUpdatedElement = null;
                else
                    LastUpdatedElement = new Instant(value);
                OnPropertyChanged("LastUpdated");
            }
        }

        /// <summary>
        /// Identifies where the resource comes from
        /// </summary>
        [FhirElement("source", InSummary=true, Order=50)]
        [DataMember]
        public FhirUri SourceElement
        {
            get { return _sourceElement; }
            set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
        }

        private FhirUri _sourceElement;

        /// <summary>
        /// Identifies where the resource comes from
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
                    SourceElement = new FhirUri(value);
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// Profiles this resource claims to conform to
        /// </summary>
        [FhirElement("profile", InSummary=true, Order=60)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> ProfileElement
        {
            get { if (_profileElement==null) _profileElement = new List<Canonical>(); return _profileElement; }
            set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
        }

        private List<Canonical> _profileElement;

        /// <summary>
        /// Profiles this resource claims to conform to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Profile
        {
            get { return ProfileElement != null ? ProfileElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ProfileElement = null;
                else
                    ProfileElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Profile");
            }
        }

        /// <summary>
        /// Security Labels applied to this resource
        /// </summary>
        [FhirElement("security", InSummary=true, Order=70)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Security
        {
            get { if (_security==null) _security = new List<Coding>(); return _security; }
            set { _security = value; OnPropertyChanged("Security"); }
        }

        private List<Coding> _security;

        /// <summary>
        /// Tags applied to this resource
        /// </summary>
        [FhirElement("tag", InSummary=true, Order=80)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Tag
        {
            get { if (_tag==null) _tag = new List<Coding>(); return _tag; }
            set { _tag = value; OnPropertyChanged("Tag"); }
        }

        private List<Coding> _tag;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Meta;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (VersionIdElement != null) dest.VersionIdElement = (Id)VersionIdElement.DeepCopy();
                if (LastUpdatedElement != null) dest.LastUpdatedElement = (Instant)LastUpdatedElement.DeepCopy();
                if (SourceElement != null) dest.SourceElement = (FhirUri)SourceElement.DeepCopy();
                if (ProfileElement != null) dest.ProfileElement = new List<Canonical>(ProfileElement.DeepCopy());
                if (Security != null) dest.Security = new List<Coding>(Security.DeepCopy());
                if (Tag != null) dest.Tag = new List<Coding>(Tag.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Meta());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Meta;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(VersionIdElement, otherT.VersionIdElement)) return false;
            if (!DeepComparable.Matches(LastUpdatedElement, otherT.LastUpdatedElement)) return false;
            if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
            if ( !DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;
            if ( !DeepComparable.Matches(Security, otherT.Security)) return false;
            if ( !DeepComparable.Matches(Tag, otherT.Tag)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Meta;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(VersionIdElement, otherT.VersionIdElement)) return false;
            if (!DeepComparable.IsExactly(LastUpdatedElement, otherT.LastUpdatedElement)) return false;
            if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
            if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
            if (!DeepComparable.IsExactly(Security, otherT.Security)) return false;
            if (!DeepComparable.IsExactly(Tag, otherT.Tag)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (VersionIdElement != null) yield return VersionIdElement;
                if (LastUpdatedElement != null) yield return LastUpdatedElement;
                if (SourceElement != null) yield return SourceElement;
                foreach (var elem in ProfileElement) { if (elem != null) yield return elem; }
                foreach (var elem in Security) { if (elem != null) yield return elem; }
                foreach (var elem in Tag) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (VersionIdElement != null) yield return new ElementValue("versionId", VersionIdElement);
                if (LastUpdatedElement != null) yield return new ElementValue("lastUpdated", LastUpdatedElement);
                if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                foreach (var elem in ProfileElement) { if (elem != null) yield return new ElementValue("profile", elem); }
                foreach (var elem in Security) { if (elem != null) yield return new ElementValue("security", elem); }
                foreach (var elem in Tag) { if (elem != null) yield return new ElementValue("tag", elem); }
            }
        }

    }

}
