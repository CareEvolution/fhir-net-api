﻿using System;
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
    /// Pure binary content defined by a format other than FHIR
    /// </summary>
    [FhirType("Binary", IsResource=true)]
    [DataContract]
    public partial class Binary : Resource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Binary; } }
        [NotMapped]
        public override string TypeName { get { return "Binary"; } }


        /// <summary>
        /// MimeType of the binary content
        /// </summary>
        [FhirElement("contentType", InSummary=true, Order=50)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code ContentTypeElement
        {
            get { return _contentTypeElement; }
            set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
        }

        private Code _contentTypeElement;

        /// <summary>
        /// MimeType of the binary content
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ContentType
        {
            get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
            set
            {
                if (value == null)
                    ContentTypeElement = null;
                else
                    ContentTypeElement = new Code(value);
                OnPropertyChanged("ContentType");
            }
        }

        /// <summary>
        /// Identifies another resource to use as proxy when enforcing access control
        /// </summary>
        [FhirElement("securityContext", InSummary=true, Order=60)]
        [DataMember]
        public ResourceReference SecurityContext
        {
            get { return _securityContext; }
            set { _securityContext = value; OnPropertyChanged("SecurityContext"); }
        }

        private ResourceReference _securityContext;

        /// <summary>
        /// The actual content
        /// </summary>
        [FhirElement("data", Order=70)]
        [DataMember]
        public Base64Binary DataElement
        {
            get { return _dataElement; }
            set { _dataElement = value; OnPropertyChanged("DataElement"); }
        }

        private Base64Binary _dataElement;

        /// <summary>
        /// The actual content
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public byte[] Data
        {
            get { return DataElement != null ? DataElement.Value : null; }
            set
            {
                if (value == null)
                    DataElement = null;
                else
                    DataElement = new Base64Binary(value);
                OnPropertyChanged("Data");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Binary;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (ContentTypeElement != null) dest.ContentTypeElement = (Code)ContentTypeElement.DeepCopy();
                if (SecurityContext != null) dest.SecurityContext = (ResourceReference)SecurityContext.DeepCopy();
                if (DataElement != null) dest.DataElement = (Base64Binary)DataElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Binary());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Binary;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
            if (!DeepComparable.Matches(SecurityContext, otherT.SecurityContext)) return false;
            if (!DeepComparable.Matches(DataElement, otherT.DataElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Binary;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
            if (!DeepComparable.IsExactly(SecurityContext, otherT.SecurityContext)) return false;
            if (!DeepComparable.IsExactly(DataElement, otherT.DataElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (ContentTypeElement != null) yield return ContentTypeElement;
                if (SecurityContext != null) yield return SecurityContext;
                if (DataElement != null) yield return DataElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                if (SecurityContext != null) yield return new ElementValue("securityContext", SecurityContext);
                if (DataElement != null) yield return new ElementValue("data", DataElement);
            }
        }

    }

}