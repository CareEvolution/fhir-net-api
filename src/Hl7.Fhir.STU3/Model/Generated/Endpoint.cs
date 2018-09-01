using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
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
    /// The technical details of an endpoint that can be used for electronic services
    /// </summary>
    [FhirType("Endpoint", IsResource=true)]
    [DataContract]
    public partial class Endpoint : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Endpoint; } }
        [NotMapped]
        public override string TypeName { get { return "Endpoint"; } }


        /// <summary>
        /// Identifies this endpoint across multiple systems
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
        /// active | suspended | error | off | entered-in-error | test
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<EndpointStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<EndpointStatus> _statusElement;

        /// <summary>
        /// active | suspended | error | off | entered-in-error | test
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EndpointStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<EndpointStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Protocol/Profile/Standard to be used with this endpoint connection
        /// </summary>
        [FhirElement("connectionType", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Coding ConnectionType
        {
            get { return _connectionType; }
            set { _connectionType = value; OnPropertyChanged("ConnectionType"); }
        }

        private Coding _connectionType;

        /// <summary>
        /// A name that this endpoint can be identified by
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// A name that this endpoint can be identified by
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
        /// Organization that manages this endpoint (may not be the organization that exposes the endpoint)
        /// </summary>
        [FhirElement("managingOrganization", InSummary=true, Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ManagingOrganization
        {
            get { return _managingOrganization; }
            set { _managingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }

        private ResourceReference _managingOrganization;

        /// <summary>
        /// Contact details for source (e.g. troubleshooting)
        /// </summary>
        [FhirElement("contact", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Contact
        {
            get { if (_contact==null) _contact = new List<ContactPoint>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactPoint> _contact;

        /// <summary>
        /// Interval the endpoint is expected to be operational
        /// </summary>
        [FhirElement("period", InSummary=true, Order=150)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// The type of content that may be used at this endpoint (e.g. XDS Discharge summaries)
        /// </summary>
        [FhirElement("payloadType", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<CodeableConcept> PayloadType
        {
            get { if (_payloadType==null) _payloadType = new List<CodeableConcept>(); return _payloadType; }
            set { _payloadType = value; OnPropertyChanged("PayloadType"); }
        }

        private List<CodeableConcept> _payloadType;

        /// <summary>
        /// Mimetype to send. If not specified, the content could be anything (including no payload, if the connectionType defined this)
        /// </summary>
        [FhirElement("payloadMimeType", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code> PayloadMimeTypeElement
        {
            get { if (_payloadMimeTypeElement==null) _payloadMimeTypeElement = new List<Code>(); return _payloadMimeTypeElement; }
            set { _payloadMimeTypeElement = value; OnPropertyChanged("PayloadMimeTypeElement"); }
        }

        private List<Code> _payloadMimeTypeElement;

        /// <summary>
        /// Mimetype to send. If not specified, the content could be anything (including no payload, if the connectionType defined this)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> PayloadMimeType
        {
            get { return PayloadMimeTypeElement != null ? PayloadMimeTypeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    PayloadMimeTypeElement = null;
                else
                    PayloadMimeTypeElement = new List<Code>(value.Select(elem=>new Code(elem)));
                OnPropertyChanged("PayloadMimeType");
            }
        }

        /// <summary>
        /// The technical base address for connecting to this endpoint
        /// </summary>
        [FhirElement("address", InSummary=true, Order=180)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri AddressElement
        {
            get { return _addressElement; }
            set { _addressElement = value; OnPropertyChanged("AddressElement"); }
        }

        private FhirUri _addressElement;

        /// <summary>
        /// The technical base address for connecting to this endpoint
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Address
        {
            get { return AddressElement != null ? AddressElement.Value : null; }
            set
            {
                if (value == null)
                    AddressElement = null;
                else
                    AddressElement = new FhirUri(value);
                OnPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Usage depends on the channel type
        /// </summary>
        [FhirElement("header", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> HeaderElement
        {
            get { if (_headerElement==null) _headerElement = new List<FhirString>(); return _headerElement; }
            set { _headerElement = value; OnPropertyChanged("HeaderElement"); }
        }

        private List<FhirString> _headerElement;

        /// <summary>
        /// Usage depends on the channel type
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Header
        {
            get { return HeaderElement != null ? HeaderElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    HeaderElement = null;
                else
                    HeaderElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Header");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Endpoint;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EndpointStatus>)StatusElement.DeepCopy();
                if (ConnectionType != null) dest.ConnectionType = (Coding)ConnectionType.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (ManagingOrganization != null) dest.ManagingOrganization = (ResourceReference)ManagingOrganization.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactPoint>(Contact.DeepCopy());
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (PayloadType != null) dest.PayloadType = new List<CodeableConcept>(PayloadType.DeepCopy());
                if (PayloadMimeTypeElement != null) dest.PayloadMimeTypeElement = new List<Code>(PayloadMimeTypeElement.DeepCopy());
                if (AddressElement != null) dest.AddressElement = (FhirUri)AddressElement.DeepCopy();
                if (HeaderElement != null) dest.HeaderElement = new List<FhirString>(HeaderElement.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Endpoint());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Endpoint;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ConnectionType, otherT.ConnectionType)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if ( !DeepComparable.Matches(PayloadType, otherT.PayloadType)) return false;
            if ( !DeepComparable.Matches(PayloadMimeTypeElement, otherT.PayloadMimeTypeElement)) return false;
            if (!DeepComparable.Matches(AddressElement, otherT.AddressElement)) return false;
            if ( !DeepComparable.Matches(HeaderElement, otherT.HeaderElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Endpoint;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ConnectionType, otherT.ConnectionType)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(PayloadType, otherT.PayloadType)) return false;
            if (!DeepComparable.IsExactly(PayloadMimeTypeElement, otherT.PayloadMimeTypeElement)) return false;
            if (!DeepComparable.IsExactly(AddressElement, otherT.AddressElement)) return false;
            if (!DeepComparable.IsExactly(HeaderElement, otherT.HeaderElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (ConnectionType != null) yield return ConnectionType;
                if (NameElement != null) yield return NameElement;
                if (ManagingOrganization != null) yield return ManagingOrganization;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Period != null) yield return Period;
                foreach (var elem in PayloadType) { if (elem != null) yield return elem; }
                foreach (var elem in PayloadMimeTypeElement) { if (elem != null) yield return elem; }
                if (AddressElement != null) yield return AddressElement;
                foreach (var elem in HeaderElement) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ConnectionType != null) yield return new ElementValue("connectionType", ConnectionType);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Period != null) yield return new ElementValue("period", Period);
                foreach (var elem in PayloadType) { if (elem != null) yield return new ElementValue("payloadType", elem); }
                foreach (var elem in PayloadMimeTypeElement) { if (elem != null) yield return new ElementValue("payloadMimeType", elem); }
                if (AddressElement != null) yield return new ElementValue("address", AddressElement);
                foreach (var elem in HeaderElement) { if (elem != null) yield return new ElementValue("header", elem); }
            }
        }

    }

}
