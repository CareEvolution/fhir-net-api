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
    /// Describes a set of tests
    /// </summary>
    [FhirType("TestScript", IsResource=true)]
    [DataContract]
    public partial class TestScript : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.TestScript; } }
        [NotMapped]
        public override string TypeName { get { return "TestScript"; } }

        /// <summary>
        /// The content or mime type.
        /// The content type or mime type to be specified in Accept or Content-Type header.
        /// (url: http://hl7.org/fhir/ValueSet/content-type)
        /// </summary>
        [FhirEnumeration("ContentType")]
        public enum ContentType
        {
            /// <summary>
            /// XML content-type corresponding to the application/xml+fhir mime-type.
            /// (system: http://hl7.org/fhir/content-type)
            /// </summary>
            [EnumLiteral("xml", "http://hl7.org/fhir/content-type"), Description("xml")]
            Xml,
            /// <summary>
            /// JSON content-type corresponding to the application/json+fhir mime-type.
            /// (system: http://hl7.org/fhir/content-type)
            /// </summary>
            [EnumLiteral("json", "http://hl7.org/fhir/content-type"), Description("json")]
            Json,
        }

        /// <summary>
        /// The type of direction to use for assertion.
        /// The direction to use for assertions.
        /// (url: http://hl7.org/fhir/ValueSet/assert-direction-codes)
        /// </summary>
        [FhirEnumeration("AssertionDirectionType")]
        public enum AssertionDirectionType
        {
            /// <summary>
            /// The assertion is evaluated on the response. This is the default value.
            /// (system: http://hl7.org/fhir/assert-direction-codes)
            /// </summary>
            [EnumLiteral("response", "http://hl7.org/fhir/assert-direction-codes"), Description("response")]
            Response,
            /// <summary>
            /// The assertion is evaluated on the request.
            /// (system: http://hl7.org/fhir/assert-direction-codes)
            /// </summary>
            [EnumLiteral("request", "http://hl7.org/fhir/assert-direction-codes"), Description("request")]
            Request,
        }

        /// <summary>
        /// The type of operator to use for assertion.
        /// The type of operator to use for assertions.
        /// (url: http://hl7.org/fhir/ValueSet/assert-operator-codes)
        /// </summary>
        [FhirEnumeration("AssertionOperatorType")]
        public enum AssertionOperatorType
        {
            /// <summary>
            /// Default value. Equals comparison.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("equals", "http://hl7.org/fhir/assert-operator-codes"), Description("equals")]
            Equals,
            /// <summary>
            /// Not equals comparison.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notEquals", "http://hl7.org/fhir/assert-operator-codes"), Description("notEquals")]
            NotEquals,
            /// <summary>
            /// Compare value within a known set of values.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("in", "http://hl7.org/fhir/assert-operator-codes"), Description("in")]
            In,
            /// <summary>
            /// Compare value not within a known set of values.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notIn", "http://hl7.org/fhir/assert-operator-codes"), Description("notIn")]
            NotIn,
            /// <summary>
            /// Compare value to be greater than a known value.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("greaterThan", "http://hl7.org/fhir/assert-operator-codes"), Description("greaterThan")]
            GreaterThan,
            /// <summary>
            /// Compare value to be less than a known value.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("lessThan", "http://hl7.org/fhir/assert-operator-codes"), Description("lessThan")]
            LessThan,
            /// <summary>
            /// Compare value is empty.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("empty", "http://hl7.org/fhir/assert-operator-codes"), Description("empty")]
            Empty,
            /// <summary>
            /// Compare value is not empty.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notEmpty", "http://hl7.org/fhir/assert-operator-codes"), Description("notEmpty")]
            NotEmpty,
            /// <summary>
            /// Compare value string contains a known value.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("contains", "http://hl7.org/fhir/assert-operator-codes"), Description("contains")]
            Contains,
            /// <summary>
            /// Compare value string does not contain a known value.
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notContains", "http://hl7.org/fhir/assert-operator-codes"), Description("notContains")]
            NotContains,
        }

        /// <summary>
        /// The type of response code to use for assertion.
        /// The response code to expect in the response.
        /// (url: http://hl7.org/fhir/ValueSet/assert-response-code-types)
        /// </summary>
        [FhirEnumeration("AssertionResponseTypes")]
        public enum AssertionResponseTypes
        {
            /// <summary>
            /// Response code is 200.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("okay", "http://hl7.org/fhir/assert-response-code-types"), Description("okay")]
            Okay,
            /// <summary>
            /// Response code is 201.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("created", "http://hl7.org/fhir/assert-response-code-types"), Description("created")]
            Created,
            /// <summary>
            /// Response code is 204.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("noContent", "http://hl7.org/fhir/assert-response-code-types"), Description("noContent")]
            NoContent,
            /// <summary>
            /// Response code is 304.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("notModified", "http://hl7.org/fhir/assert-response-code-types"), Description("notModified")]
            NotModified,
            /// <summary>
            /// Response code is 400.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("bad", "http://hl7.org/fhir/assert-response-code-types"), Description("bad")]
            Bad,
            /// <summary>
            /// Response code is 403.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("forbidden", "http://hl7.org/fhir/assert-response-code-types"), Description("forbidden")]
            Forbidden,
            /// <summary>
            /// Response code is 404.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("notFound", "http://hl7.org/fhir/assert-response-code-types"), Description("notFound")]
            NotFound,
            /// <summary>
            /// Response code is 405.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("methodNotAllowed", "http://hl7.org/fhir/assert-response-code-types"), Description("methodNotAllowed")]
            MethodNotAllowed,
            /// <summary>
            /// Response code is 409.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("conflict", "http://hl7.org/fhir/assert-response-code-types"), Description("conflict")]
            Conflict,
            /// <summary>
            /// Response code is 410.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("gone", "http://hl7.org/fhir/assert-response-code-types"), Description("gone")]
            Gone,
            /// <summary>
            /// Response code is 412.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("preconditionFailed", "http://hl7.org/fhir/assert-response-code-types"), Description("preconditionFailed")]
            PreconditionFailed,
            /// <summary>
            /// Response code is 422.
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("unprocessable", "http://hl7.org/fhir/assert-response-code-types"), Description("unprocessable")]
            Unprocessable,
        }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of a individual to contact
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
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom == null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Telecom, otherT.Telecom)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                }
            }


        }


        [FhirType("MetadataComponent")]
        [DataContract]
        public partial class MetadataComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MetadataComponent"; } }

            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            [FhirElement("link", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<LinkComponent> Link
            {
                get { if (_link == null) _link = new List<LinkComponent>(); return _link; }
                set { _link = value; OnPropertyChanged("Link"); }
            }

            private List<LinkComponent> _link;

            /// <summary>
            /// Capabilities  that are assumed to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("capability", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<CapabilityComponent> Capability
            {
                get { if (_capability == null) _capability = new List<CapabilityComponent>(); return _capability; }
                set { _capability = value; OnPropertyChanged("Capability"); }
            }

            private List<CapabilityComponent> _capability;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MetadataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                    if (Capability != null) dest.Capability = new List<CapabilityComponent>(Capability.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MetadataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MetadataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Link, otherT.Link)) return false;
                if (!DeepComparable.Matches(Capability, otherT.Capability)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MetadataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Link, otherT.Link)) return false;
                if (!DeepComparable.IsExactly(Capability, otherT.Capability)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Link) { if (elem != null) yield return elem; }
                    foreach (var elem in Capability) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
                    foreach (var elem in Capability) { if (elem != null) yield return new ElementValue("capability", elem); }
                }
            }


        }


        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }

            /// <summary>
            /// URL to the specification
            /// </summary>
            [FhirElement("url", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// URL to the specification
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if (value == null)
                        UrlElement = null;
                    else
                        UrlElement = new FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }

            /// <summary>
            /// Short description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Short description
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LinkComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UrlElement != null) yield return UrlElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        [FhirType("CapabilityComponent")]
        [DataContract]
        public partial class CapabilityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CapabilityComponent"; } }

            /// <summary>
            /// Are the capabilities required?
            /// </summary>
            [FhirElement("required", Order=40)]
            [DataMember]
            public FhirBoolean RequiredElement
            {
                get { return _requiredElement; }
                set { _requiredElement = value; OnPropertyChanged("RequiredElement"); }
            }

            private FhirBoolean _requiredElement;

            /// <summary>
            /// Are the capabilities required?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RequiredElement = null;
                    else
                        RequiredElement = new FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// Are the capabilities validated?
            /// </summary>
            [FhirElement("validated", Order=50)]
            [DataMember]
            public FhirBoolean ValidatedElement
            {
                get { return _validatedElement; }
                set { _validatedElement = value; OnPropertyChanged("ValidatedElement"); }
            }

            private FhirBoolean _validatedElement;

            /// <summary>
            /// Are the capabilities validated?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Validated
            {
                get { return ValidatedElement != null ? ValidatedElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ValidatedElement = null;
                    else
                        ValidatedElement = new FhirBoolean(value);
                    OnPropertyChanged("Validated");
                }
            }

            /// <summary>
            /// The expected capabilities of the server
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// The expected capabilities of the server
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
            /// Which server these requirements apply to
            /// </summary>
            [FhirElement("destination", Order=70)]
            [DataMember]
            public Integer DestinationElement
            {
                get { return _destinationElement; }
                set { _destinationElement = value; OnPropertyChanged("DestinationElement"); }
            }

            private Integer _destinationElement;

            /// <summary>
            /// Which server these requirements apply to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Destination
            {
                get { return DestinationElement != null ? DestinationElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DestinationElement = null;
                    else
                        DestinationElement = new Integer(value);
                    OnPropertyChanged("Destination");
                }
            }

            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            [FhirElement("link", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirUri> LinkElement
            {
                get { if (_linkElement == null) _linkElement = new List<FhirUri>(); return _linkElement; }
                set { _linkElement = value; OnPropertyChanged("LinkElement"); }
            }

            private List<FhirUri> _linkElement;

            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Link
            {
                get { return LinkElement != null ? LinkElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LinkElement = null;
                    else
                        LinkElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                    OnPropertyChanged("Link");
                }
            }

            /// <summary>
            /// Required Conformance
            /// </summary>
            [FhirElement("conformance", Order=90)]
            [References("Conformance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Conformance
            {
                get { return _conformance; }
                set { _conformance = value; OnPropertyChanged("Conformance"); }
            }

            private ResourceReference _conformance;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CapabilityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RequiredElement != null) dest.RequiredElement = (FhirBoolean)RequiredElement.DeepCopy();
                    if (ValidatedElement != null) dest.ValidatedElement = (FhirBoolean)ValidatedElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (DestinationElement != null) dest.DestinationElement = (Integer)DestinationElement.DeepCopy();
                    if (LinkElement != null) dest.LinkElement = new List<FhirUri>(LinkElement.DeepCopy());
                    if (Conformance != null) dest.Conformance = (ResourceReference)Conformance.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CapabilityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.Matches(ValidatedElement, otherT.ValidatedElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.Matches(LinkElement, otherT.LinkElement)) return false;
                if (!DeepComparable.Matches(Conformance, otherT.Conformance)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.IsExactly(ValidatedElement, otherT.ValidatedElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.IsExactly(LinkElement, otherT.LinkElement)) return false;
                if (!DeepComparable.IsExactly(Conformance, otherT.Conformance)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RequiredElement != null) yield return RequiredElement;
                    if (ValidatedElement != null) yield return ValidatedElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (DestinationElement != null) yield return DestinationElement;
                    foreach (var elem in LinkElement) { if (elem != null) yield return elem; }
                    if (Conformance != null) yield return Conformance;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RequiredElement != null) yield return new ElementValue("required", RequiredElement);
                    if (ValidatedElement != null) yield return new ElementValue("validated", ValidatedElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (DestinationElement != null) yield return new ElementValue("destination", DestinationElement);
                    foreach (var elem in LinkElement) { if (elem != null) yield return new ElementValue("link", elem); }
                    if (Conformance != null) yield return new ElementValue("conformance", Conformance);
                }
            }


        }


        [FhirType("FixtureComponent")]
        [DataContract]
        public partial class FixtureComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FixtureComponent"; } }

            /// <summary>
            /// Whether or not to implicitly create the fixture during setup
            /// </summary>
            [FhirElement("autocreate", Order=40)]
            [DataMember]
            public FhirBoolean AutocreateElement
            {
                get { return _autocreateElement; }
                set { _autocreateElement = value; OnPropertyChanged("AutocreateElement"); }
            }

            private FhirBoolean _autocreateElement;

            /// <summary>
            /// Whether or not to implicitly create the fixture during setup
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Autocreate
            {
                get { return AutocreateElement != null ? AutocreateElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        AutocreateElement = null;
                    else
                        AutocreateElement = new FhirBoolean(value);
                    OnPropertyChanged("Autocreate");
                }
            }

            /// <summary>
            /// Whether or not to implicitly delete the fixture during teardown
            /// </summary>
            [FhirElement("autodelete", Order=50)]
            [DataMember]
            public FhirBoolean AutodeleteElement
            {
                get { return _autodeleteElement; }
                set { _autodeleteElement = value; OnPropertyChanged("AutodeleteElement"); }
            }

            private FhirBoolean _autodeleteElement;

            /// <summary>
            /// Whether or not to implicitly delete the fixture during teardown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Autodelete
            {
                get { return AutodeleteElement != null ? AutodeleteElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        AutodeleteElement = null;
                    else
                        AutodeleteElement = new FhirBoolean(value);
                    OnPropertyChanged("Autodelete");
                }
            }

            /// <summary>
            /// Reference of the resource
            /// </summary>
            [FhirElement("resource", Order=60)]
            [DataMember]
            public ResourceReference Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private ResourceReference _resource;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FixtureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AutocreateElement != null) dest.AutocreateElement = (FhirBoolean)AutocreateElement.DeepCopy();
                    if (AutodeleteElement != null) dest.AutodeleteElement = (FhirBoolean)AutodeleteElement.DeepCopy();
                    if (Resource != null) dest.Resource = (ResourceReference)Resource.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FixtureComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FixtureComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AutocreateElement, otherT.AutocreateElement)) return false;
                if (!DeepComparable.Matches(AutodeleteElement, otherT.AutodeleteElement)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FixtureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AutocreateElement, otherT.AutocreateElement)) return false;
                if (!DeepComparable.IsExactly(AutodeleteElement, otherT.AutodeleteElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AutocreateElement != null) yield return AutocreateElement;
                    if (AutodeleteElement != null) yield return AutodeleteElement;
                    if (Resource != null) yield return Resource;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AutocreateElement != null) yield return new ElementValue("autocreate", AutocreateElement);
                    if (AutodeleteElement != null) yield return new ElementValue("autodelete", AutodeleteElement);
                    if (Resource != null) yield return new ElementValue("resource", Resource);
                }
            }


        }


        [FhirType("VariableComponent")]
        [DataContract]
        public partial class VariableComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VariableComponent"; } }

            /// <summary>
            /// Descriptive name for this variable
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Descriptive name for this variable
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
            /// HTTP header field name for source
            /// </summary>
            [FhirElement("headerField", Order=50)]
            [DataMember]
            public FhirString HeaderFieldElement
            {
                get { return _headerFieldElement; }
                set { _headerFieldElement = value; OnPropertyChanged("HeaderFieldElement"); }
            }

            private FhirString _headerFieldElement;

            /// <summary>
            /// HTTP header field name for source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string HeaderField
            {
                get { return HeaderFieldElement != null ? HeaderFieldElement.Value : null; }
                set
                {
                    if (value == null)
                        HeaderFieldElement = null;
                    else
                        HeaderFieldElement = new FhirString(value);
                    OnPropertyChanged("HeaderField");
                }
            }

            /// <summary>
            /// XPath or JSONPath against the fixture body
            /// </summary>
            [FhirElement("path", Order=60)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// XPath or JSONPath against the fixture body
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// Fixture Id of source expression or headerField within this variable
            /// </summary>
            [FhirElement("sourceId", Order=70)]
            [DataMember]
            public Id SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private Id _sourceIdElement;

            /// <summary>
            /// Fixture Id of source expression or headerField within this variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new Id(value);
                    OnPropertyChanged("SourceId");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VariableComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (HeaderFieldElement != null) dest.HeaderFieldElement = (FhirString)HeaderFieldElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (Id)SourceIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VariableComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VariableComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VariableComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (HeaderFieldElement != null) yield return HeaderFieldElement;
                    if (PathElement != null) yield return PathElement;
                    if (SourceIdElement != null) yield return SourceIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (HeaderFieldElement != null) yield return new ElementValue("headerField", HeaderFieldElement);
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                }
            }


        }


        [FhirType("SetupComponent")]
        [DataContract]
        public partial class SetupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SetupComponent"; } }

            /// <summary>
            /// Capabilities  that are assumed to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("metadata", Order=40)]
            [DataMember]
            public MetadataComponent Metadata
            {
                get { return _metadata; }
                set { _metadata = value; OnPropertyChanged("Metadata"); }
            }

            private MetadataComponent _metadata;

            /// <summary>
            /// A setup operation or assert to perform
            /// </summary>
            [FhirElement("action", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<SetupActionComponent> Action
            {
                get { if (_action == null) _action = new List<SetupActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<SetupActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Metadata != null) dest.Metadata = (MetadataComponent)Metadata.DeepCopy();
                    if (Action != null) dest.Action = new List<SetupActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SetupComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
                if (!DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Metadata != null) yield return Metadata;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Metadata != null) yield return new ElementValue("metadata", Metadata);
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("SetupActionComponent")]
        [DataContract]
        public partial class SetupActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SetupActionComponent"; } }

            /// <summary>
            /// The setup operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// The assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public AssertComponent Assert
            {
                get { return _assert; }
                set { _assert = value; OnPropertyChanged("Assert"); }
            }

            private AssertComponent _assert;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Assert != null) dest.Assert = (AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SetupActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Assert, otherT.Assert)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Assert, otherT.Assert)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                    if (Assert != null) yield return Assert;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Assert != null) yield return new ElementValue("assert", Assert);
                }
            }


        }


        [FhirType("OperationComponent")]
        [DataContract]
        public partial class OperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OperationComponent"; } }

            /// <summary>
            /// The setup operation type that will be executed
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Resource type
            /// </summary>
            [FhirElement("resource", Order=50)]
            [DataMember]
            public Code<FHIRDefinedType> ResourceElement
            {
                get { return _resourceElement; }
                set { _resourceElement = value; OnPropertyChanged("ResourceElement"); }
            }

            private Code<FHIRDefinedType> _resourceElement;

            /// <summary>
            /// Resource type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public FHIRDefinedType? Resource
            {
                get { return ResourceElement != null ? ResourceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ResourceElement = null;
                    else
                        ResourceElement = new Code<FHIRDefinedType>(value);
                    OnPropertyChanged("Resource");
                }
            }

            /// <summary>
            /// Tracking/logging operation label
            /// </summary>
            [FhirElement("label", Order=60)]
            [DataMember]
            public FhirString LabelElement
            {
                get { return _labelElement; }
                set { _labelElement = value; OnPropertyChanged("LabelElement"); }
            }

            private FhirString _labelElement;

            /// <summary>
            /// Tracking/logging operation label
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if (value == null)
                        LabelElement = null;
                    else
                        LabelElement = new FhirString(value);
                    OnPropertyChanged("Label");
                }
            }

            /// <summary>
            /// Tracking/reporting operation description
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Tracking/reporting operation description
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
            /// xml | json
            /// </summary>
            [FhirElement("accept", Order=80)]
            [DataMember]
            public Code<ContentType> AcceptElement
            {
                get { return _acceptElement; }
                set { _acceptElement = value; OnPropertyChanged("AcceptElement"); }
            }

            private Code<ContentType> _acceptElement;

            /// <summary>
            /// xml | json
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ContentType? Accept
            {
                get { return AcceptElement != null ? AcceptElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        AcceptElement = null;
                    else
                        AcceptElement = new Code<ContentType>(value);
                    OnPropertyChanged("Accept");
                }
            }

            /// <summary>
            /// xml | json
            /// </summary>
            [FhirElement("contentType", Order=90)]
            [DataMember]
            public Code<ContentType> ContentTypeElement
            {
                get { return _contentTypeElement; }
                set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
            }

            private Code<ContentType> _contentTypeElement;

            /// <summary>
            /// xml | json
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ContentType? ContentType
            {
                get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ContentTypeElement = null;
                    else
                        ContentTypeElement = new Code<ContentType>(value);
                    OnPropertyChanged("ContentType");
                }
            }

            /// <summary>
            /// Which server to perform the operation on
            /// </summary>
            [FhirElement("destination", Order=100)]
            [DataMember]
            public Integer DestinationElement
            {
                get { return _destinationElement; }
                set { _destinationElement = value; OnPropertyChanged("DestinationElement"); }
            }

            private Integer _destinationElement;

            /// <summary>
            /// Which server to perform the operation on
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Destination
            {
                get { return DestinationElement != null ? DestinationElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DestinationElement = null;
                    else
                        DestinationElement = new Integer(value);
                    OnPropertyChanged("Destination");
                }
            }

            /// <summary>
            /// Whether or not to send the request url in encoded format
            /// </summary>
            [FhirElement("encodeRequestUrl", Order=110)]
            [DataMember]
            public FhirBoolean EncodeRequestUrlElement
            {
                get { return _encodeRequestUrlElement; }
                set { _encodeRequestUrlElement = value; OnPropertyChanged("EncodeRequestUrlElement"); }
            }

            private FhirBoolean _encodeRequestUrlElement;

            /// <summary>
            /// Whether or not to send the request url in encoded format
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? EncodeRequestUrl
            {
                get { return EncodeRequestUrlElement != null ? EncodeRequestUrlElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        EncodeRequestUrlElement = null;
                    else
                        EncodeRequestUrlElement = new FhirBoolean(value);
                    OnPropertyChanged("EncodeRequestUrl");
                }
            }

            /// <summary>
            /// Explicitly defined path parameters
            /// </summary>
            [FhirElement("params", Order=120)]
            [DataMember]
            public FhirString ParamsElement
            {
                get { return _paramsElement; }
                set { _paramsElement = value; OnPropertyChanged("ParamsElement"); }
            }

            private FhirString _paramsElement;

            /// <summary>
            /// Explicitly defined path parameters
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Params
            {
                get { return ParamsElement != null ? ParamsElement.Value : null; }
                set
                {
                    if (value == null)
                        ParamsElement = null;
                    else
                        ParamsElement = new FhirString(value);
                    OnPropertyChanged("Params");
                }
            }

            /// <summary>
            /// Each operation can have one ore more header elements
            /// </summary>
            [FhirElement("requestHeader", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RequestHeaderComponent> RequestHeader
            {
                get { if (_requestHeader == null) _requestHeader = new List<RequestHeaderComponent>(); return _requestHeader; }
                set { _requestHeader = value; OnPropertyChanged("RequestHeader"); }
            }

            private List<RequestHeaderComponent> _requestHeader;

            /// <summary>
            /// Fixture Id of mapped response
            /// </summary>
            [FhirElement("responseId", Order=140)]
            [DataMember]
            public Id ResponseIdElement
            {
                get { return _responseIdElement; }
                set { _responseIdElement = value; OnPropertyChanged("ResponseIdElement"); }
            }

            private Id _responseIdElement;

            /// <summary>
            /// Fixture Id of mapped response
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ResponseId
            {
                get { return ResponseIdElement != null ? ResponseIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponseIdElement = null;
                    else
                        ResponseIdElement = new Id(value);
                    OnPropertyChanged("ResponseId");
                }
            }

            /// <summary>
            /// Fixture Id of body for PUT and POST requests
            /// </summary>
            [FhirElement("sourceId", Order=150)]
            [DataMember]
            public Id SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private Id _sourceIdElement;

            /// <summary>
            /// Fixture Id of body for PUT and POST requests
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new Id(value);
                    OnPropertyChanged("SourceId");
                }
            }

            /// <summary>
            /// Id of fixture used for extracting the [id],  [type], and [vid] for GET requests
            /// </summary>
            [FhirElement("targetId", Order=160)]
            [DataMember]
            public Id TargetIdElement
            {
                get { return _targetIdElement; }
                set { _targetIdElement = value; OnPropertyChanged("TargetIdElement"); }
            }

            private Id _targetIdElement;

            /// <summary>
            /// Id of fixture used for extracting the [id],  [type], and [vid] for GET requests
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string TargetId
            {
                get { return TargetIdElement != null ? TargetIdElement.Value : null; }
                set
                {
                    if (value == null)
                        TargetIdElement = null;
                    else
                        TargetIdElement = new Id(value);
                    OnPropertyChanged("TargetId");
                }
            }

            /// <summary>
            /// Request URL
            /// </summary>
            [FhirElement("url", Order=170)]
            [DataMember]
            public FhirString UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirString _urlElement;

            /// <summary>
            /// Request URL
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if (value == null)
                        UrlElement = null;
                    else
                        UrlElement = new FhirString(value);
                    OnPropertyChanged("Url");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (ResourceElement != null) dest.ResourceElement = (Code<FHIRDefinedType>)ResourceElement.DeepCopy();
                    if (LabelElement != null) dest.LabelElement = (FhirString)LabelElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (AcceptElement != null) dest.AcceptElement = (Code<ContentType>)AcceptElement.DeepCopy();
                    if (ContentTypeElement != null) dest.ContentTypeElement = (Code<ContentType>)ContentTypeElement.DeepCopy();
                    if (DestinationElement != null) dest.DestinationElement = (Integer)DestinationElement.DeepCopy();
                    if (EncodeRequestUrlElement != null) dest.EncodeRequestUrlElement = (FhirBoolean)EncodeRequestUrlElement.DeepCopy();
                    if (ParamsElement != null) dest.ParamsElement = (FhirString)ParamsElement.DeepCopy();
                    if (RequestHeader != null) dest.RequestHeader = new List<RequestHeaderComponent>(RequestHeader.DeepCopy());
                    if (ResponseIdElement != null) dest.ResponseIdElement = (Id)ResponseIdElement.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (Id)SourceIdElement.DeepCopy();
                    if (TargetIdElement != null) dest.TargetIdElement = (Id)TargetIdElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirString)UrlElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(AcceptElement, otherT.AcceptElement)) return false;
                if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.Matches(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.Matches(EncodeRequestUrlElement, otherT.EncodeRequestUrlElement)) return false;
                if (!DeepComparable.Matches(ParamsElement, otherT.ParamsElement)) return false;
                if (!DeepComparable.Matches(RequestHeader, otherT.RequestHeader)) return false;
                if (!DeepComparable.Matches(ResponseIdElement, otherT.ResponseIdElement)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.Matches(TargetIdElement, otherT.TargetIdElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(AcceptElement, otherT.AcceptElement)) return false;
                if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.IsExactly(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.IsExactly(EncodeRequestUrlElement, otherT.EncodeRequestUrlElement)) return false;
                if (!DeepComparable.IsExactly(ParamsElement, otherT.ParamsElement)) return false;
                if (!DeepComparable.IsExactly(RequestHeader, otherT.RequestHeader)) return false;
                if (!DeepComparable.IsExactly(ResponseIdElement, otherT.ResponseIdElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.IsExactly(TargetIdElement, otherT.TargetIdElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (ResourceElement != null) yield return ResourceElement;
                    if (LabelElement != null) yield return LabelElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (AcceptElement != null) yield return AcceptElement;
                    if (ContentTypeElement != null) yield return ContentTypeElement;
                    if (DestinationElement != null) yield return DestinationElement;
                    if (EncodeRequestUrlElement != null) yield return EncodeRequestUrlElement;
                    if (ParamsElement != null) yield return ParamsElement;
                    foreach (var elem in RequestHeader) { if (elem != null) yield return elem; }
                    if (ResponseIdElement != null) yield return ResponseIdElement;
                    if (SourceIdElement != null) yield return SourceIdElement;
                    if (TargetIdElement != null) yield return TargetIdElement;
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (ResourceElement != null) yield return new ElementValue("resource", ResourceElement);
                    if (LabelElement != null) yield return new ElementValue("label", LabelElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (AcceptElement != null) yield return new ElementValue("accept", AcceptElement);
                    if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                    if (DestinationElement != null) yield return new ElementValue("destination", DestinationElement);
                    if (EncodeRequestUrlElement != null) yield return new ElementValue("encodeRequestUrl", EncodeRequestUrlElement);
                    if (ParamsElement != null) yield return new ElementValue("params", ParamsElement);
                    foreach (var elem in RequestHeader) { if (elem != null) yield return new ElementValue("requestHeader", elem); }
                    if (ResponseIdElement != null) yield return new ElementValue("responseId", ResponseIdElement);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                    if (TargetIdElement != null) yield return new ElementValue("targetId", TargetIdElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        [FhirType("RequestHeaderComponent")]
        [DataContract]
        public partial class RequestHeaderComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RequestHeaderComponent"; } }

            /// <summary>
            /// HTTP header field name
            /// </summary>
            [FhirElement("field", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString FieldElement
            {
                get { return _fieldElement; }
                set { _fieldElement = value; OnPropertyChanged("FieldElement"); }
            }

            private FhirString _fieldElement;

            /// <summary>
            /// HTTP header field name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Field
            {
                get { return FieldElement != null ? FieldElement.Value : null; }
                set
                {
                    if (value == null)
                        FieldElement = null;
                    else
                        FieldElement = new FhirString(value);
                    OnPropertyChanged("Field");
                }
            }

            /// <summary>
            /// HTTP headerfield value
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// HTTP headerfield value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequestHeaderComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (FieldElement != null) dest.FieldElement = (FhirString)FieldElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RequestHeaderComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequestHeaderComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(FieldElement, otherT.FieldElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequestHeaderComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(FieldElement, otherT.FieldElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (FieldElement != null) yield return FieldElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (FieldElement != null) yield return new ElementValue("field", FieldElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("AssertComponent")]
        [DataContract]
        public partial class AssertComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AssertComponent"; } }

            /// <summary>
            /// Tracking/logging assertion label
            /// </summary>
            [FhirElement("label", Order=40)]
            [DataMember]
            public FhirString LabelElement
            {
                get { return _labelElement; }
                set { _labelElement = value; OnPropertyChanged("LabelElement"); }
            }

            private FhirString _labelElement;

            /// <summary>
            /// Tracking/logging assertion label
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if (value == null)
                        LabelElement = null;
                    else
                        LabelElement = new FhirString(value);
                    OnPropertyChanged("Label");
                }
            }

            /// <summary>
            /// Tracking/reporting assertion description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Tracking/reporting assertion description
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
            /// response | request
            /// </summary>
            [FhirElement("direction", Order=60)]
            [DataMember]
            public Code<AssertionDirectionType> DirectionElement
            {
                get { return _directionElement; }
                set { _directionElement = value; OnPropertyChanged("DirectionElement"); }
            }

            private Code<AssertionDirectionType> _directionElement;

            /// <summary>
            /// response | request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AssertionDirectionType? Direction
            {
                get { return DirectionElement != null ? DirectionElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DirectionElement = null;
                    else
                        DirectionElement = new Code<AssertionDirectionType>(value);
                    OnPropertyChanged("Direction");
                }
            }

            /// <summary>
            /// Id of fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            [FhirElement("compareToSourceId", Order=70)]
            [DataMember]
            public FhirString CompareToSourceIdElement
            {
                get { return _compareToSourceIdElement; }
                set { _compareToSourceIdElement = value; OnPropertyChanged("CompareToSourceIdElement"); }
            }

            private FhirString _compareToSourceIdElement;

            /// <summary>
            /// Id of fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CompareToSourceId
            {
                get { return CompareToSourceIdElement != null ? CompareToSourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        CompareToSourceIdElement = null;
                    else
                        CompareToSourceIdElement = new FhirString(value);
                    OnPropertyChanged("CompareToSourceId");
                }
            }

            /// <summary>
            /// XPath or JSONPath expression against fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            [FhirElement("compareToSourcePath", Order=80)]
            [DataMember]
            public FhirString CompareToSourcePathElement
            {
                get { return _compareToSourcePathElement; }
                set { _compareToSourcePathElement = value; OnPropertyChanged("CompareToSourcePathElement"); }
            }

            private FhirString _compareToSourcePathElement;

            /// <summary>
            /// XPath or JSONPath expression against fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CompareToSourcePath
            {
                get { return CompareToSourcePathElement != null ? CompareToSourcePathElement.Value : null; }
                set
                {
                    if (value == null)
                        CompareToSourcePathElement = null;
                    else
                        CompareToSourcePathElement = new FhirString(value);
                    OnPropertyChanged("CompareToSourcePath");
                }
            }

            /// <summary>
            /// xml | json
            /// </summary>
            [FhirElement("contentType", Order=90)]
            [DataMember]
            public Code<ContentType> ContentTypeElement
            {
                get { return _contentTypeElement; }
                set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
            }

            private Code<ContentType> _contentTypeElement;

            /// <summary>
            /// xml | json
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ContentType? ContentType
            {
                get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ContentTypeElement = null;
                    else
                        ContentTypeElement = new Code<ContentType>(value);
                    OnPropertyChanged("ContentType");
                }
            }

            /// <summary>
            /// HTTP header field name
            /// </summary>
            [FhirElement("headerField", Order=100)]
            [DataMember]
            public FhirString HeaderFieldElement
            {
                get { return _headerFieldElement; }
                set { _headerFieldElement = value; OnPropertyChanged("HeaderFieldElement"); }
            }

            private FhirString _headerFieldElement;

            /// <summary>
            /// HTTP header field name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string HeaderField
            {
                get { return HeaderFieldElement != null ? HeaderFieldElement.Value : null; }
                set
                {
                    if (value == null)
                        HeaderFieldElement = null;
                    else
                        HeaderFieldElement = new FhirString(value);
                    OnPropertyChanged("HeaderField");
                }
            }

            /// <summary>
            /// Fixture Id of minimum content resource
            /// </summary>
            [FhirElement("minimumId", Order=110)]
            [DataMember]
            public FhirString MinimumIdElement
            {
                get { return _minimumIdElement; }
                set { _minimumIdElement = value; OnPropertyChanged("MinimumIdElement"); }
            }

            private FhirString _minimumIdElement;

            /// <summary>
            /// Fixture Id of minimum content resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string MinimumId
            {
                get { return MinimumIdElement != null ? MinimumIdElement.Value : null; }
                set
                {
                    if (value == null)
                        MinimumIdElement = null;
                    else
                        MinimumIdElement = new FhirString(value);
                    OnPropertyChanged("MinimumId");
                }
            }

            /// <summary>
            /// Perform validation on navigation links?
            /// </summary>
            [FhirElement("navigationLinks", Order=120)]
            [DataMember]
            public FhirBoolean NavigationLinksElement
            {
                get { return _navigationLinksElement; }
                set { _navigationLinksElement = value; OnPropertyChanged("NavigationLinksElement"); }
            }

            private FhirBoolean _navigationLinksElement;

            /// <summary>
            /// Perform validation on navigation links?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? NavigationLinks
            {
                get { return NavigationLinksElement != null ? NavigationLinksElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        NavigationLinksElement = null;
                    else
                        NavigationLinksElement = new FhirBoolean(value);
                    OnPropertyChanged("NavigationLinks");
                }
            }

            /// <summary>
            /// equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains
            /// </summary>
            [FhirElement("operator", Order=130)]
            [DataMember]
            public Code<AssertionOperatorType> OperatorElement
            {
                get { return _operatorElement; }
                set { _operatorElement = value; OnPropertyChanged("OperatorElement"); }
            }

            private Code<AssertionOperatorType> _operatorElement;

            /// <summary>
            /// equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AssertionOperatorType? Operator
            {
                get { return OperatorElement != null ? OperatorElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        OperatorElement = null;
                    else
                        OperatorElement = new Code<AssertionOperatorType>(value);
                    OnPropertyChanged("Operator");
                }
            }

            /// <summary>
            /// XPath or JSONPath expression
            /// </summary>
            [FhirElement("path", Order=140)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// XPath or JSONPath expression
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// Resource type
            /// </summary>
            [FhirElement("resource", Order=150)]
            [DataMember]
            public Code<FHIRDefinedType> ResourceElement
            {
                get { return _resourceElement; }
                set { _resourceElement = value; OnPropertyChanged("ResourceElement"); }
            }

            private Code<FHIRDefinedType> _resourceElement;

            /// <summary>
            /// Resource type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public FHIRDefinedType? Resource
            {
                get { return ResourceElement != null ? ResourceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ResourceElement = null;
                    else
                        ResourceElement = new Code<FHIRDefinedType>(value);
                    OnPropertyChanged("Resource");
                }
            }

            /// <summary>
            /// okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable
            /// </summary>
            [FhirElement("response", Order=160)]
            [DataMember]
            public Code<AssertionResponseTypes> ResponseElement
            {
                get { return _responseElement; }
                set { _responseElement = value; OnPropertyChanged("ResponseElement"); }
            }

            private Code<AssertionResponseTypes> _responseElement;

            /// <summary>
            /// okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AssertionResponseTypes? Response
            {
                get { return ResponseElement != null ? ResponseElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ResponseElement = null;
                    else
                        ResponseElement = new Code<AssertionResponseTypes>(value);
                    OnPropertyChanged("Response");
                }
            }

            /// <summary>
            /// HTTP response code to test
            /// </summary>
            [FhirElement("responseCode", Order=170)]
            [DataMember]
            public FhirString ResponseCodeElement
            {
                get { return _responseCodeElement; }
                set { _responseCodeElement = value; OnPropertyChanged("ResponseCodeElement"); }
            }

            private FhirString _responseCodeElement;

            /// <summary>
            /// HTTP response code to test
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ResponseCode
            {
                get { return ResponseCodeElement != null ? ResponseCodeElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponseCodeElement = null;
                    else
                        ResponseCodeElement = new FhirString(value);
                    OnPropertyChanged("ResponseCode");
                }
            }

            /// <summary>
            /// Fixture Id of source expression or headerField
            /// </summary>
            [FhirElement("sourceId", Order=180)]
            [DataMember]
            public Id SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private Id _sourceIdElement;

            /// <summary>
            /// Fixture Id of source expression or headerField
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new Id(value);
                    OnPropertyChanged("SourceId");
                }
            }

            /// <summary>
            /// Profile Id of validation profile reference
            /// </summary>
            [FhirElement("validateProfileId", Order=190)]
            [DataMember]
            public Id ValidateProfileIdElement
            {
                get { return _validateProfileIdElement; }
                set { _validateProfileIdElement = value; OnPropertyChanged("ValidateProfileIdElement"); }
            }

            private Id _validateProfileIdElement;

            /// <summary>
            /// Profile Id of validation profile reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ValidateProfileId
            {
                get { return ValidateProfileIdElement != null ? ValidateProfileIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ValidateProfileIdElement = null;
                    else
                        ValidateProfileIdElement = new Id(value);
                    OnPropertyChanged("ValidateProfileId");
                }
            }

            /// <summary>
            /// The value to compare to
            /// </summary>
            [FhirElement("value", Order=200)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// The value to compare to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            /// <summary>
            /// Will this assert produce a warning only on error?
            /// </summary>
            [FhirElement("warningOnly", Order=210)]
            [DataMember]
            public FhirBoolean WarningOnlyElement
            {
                get { return _warningOnlyElement; }
                set { _warningOnlyElement = value; OnPropertyChanged("WarningOnlyElement"); }
            }

            private FhirBoolean _warningOnlyElement;

            /// <summary>
            /// Will this assert produce a warning only on error?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? WarningOnly
            {
                get { return WarningOnlyElement != null ? WarningOnlyElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        WarningOnlyElement = null;
                    else
                        WarningOnlyElement = new FhirBoolean(value);
                    OnPropertyChanged("WarningOnly");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AssertComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LabelElement != null) dest.LabelElement = (FhirString)LabelElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (DirectionElement != null) dest.DirectionElement = (Code<AssertionDirectionType>)DirectionElement.DeepCopy();
                    if (CompareToSourceIdElement != null) dest.CompareToSourceIdElement = (FhirString)CompareToSourceIdElement.DeepCopy();
                    if (CompareToSourcePathElement != null) dest.CompareToSourcePathElement = (FhirString)CompareToSourcePathElement.DeepCopy();
                    if (ContentTypeElement != null) dest.ContentTypeElement = (Code<ContentType>)ContentTypeElement.DeepCopy();
                    if (HeaderFieldElement != null) dest.HeaderFieldElement = (FhirString)HeaderFieldElement.DeepCopy();
                    if (MinimumIdElement != null) dest.MinimumIdElement = (FhirString)MinimumIdElement.DeepCopy();
                    if (NavigationLinksElement != null) dest.NavigationLinksElement = (FhirBoolean)NavigationLinksElement.DeepCopy();
                    if (OperatorElement != null) dest.OperatorElement = (Code<AssertionOperatorType>)OperatorElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (ResourceElement != null) dest.ResourceElement = (Code<FHIRDefinedType>)ResourceElement.DeepCopy();
                    if (ResponseElement != null) dest.ResponseElement = (Code<AssertionResponseTypes>)ResponseElement.DeepCopy();
                    if (ResponseCodeElement != null) dest.ResponseCodeElement = (FhirString)ResponseCodeElement.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (Id)SourceIdElement.DeepCopy();
                    if (ValidateProfileIdElement != null) dest.ValidateProfileIdElement = (Id)ValidateProfileIdElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    if (WarningOnlyElement != null) dest.WarningOnlyElement = (FhirBoolean)WarningOnlyElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AssertComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(DirectionElement, otherT.DirectionElement)) return false;
                if (!DeepComparable.Matches(CompareToSourceIdElement, otherT.CompareToSourceIdElement)) return false;
                if (!DeepComparable.Matches(CompareToSourcePathElement, otherT.CompareToSourcePathElement)) return false;
                if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.Matches(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.Matches(MinimumIdElement, otherT.MinimumIdElement)) return false;
                if (!DeepComparable.Matches(NavigationLinksElement, otherT.NavigationLinksElement)) return false;
                if (!DeepComparable.Matches(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.Matches(ResponseElement, otherT.ResponseElement)) return false;
                if (!DeepComparable.Matches(ResponseCodeElement, otherT.ResponseCodeElement)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.Matches(ValidateProfileIdElement, otherT.ValidateProfileIdElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.Matches(WarningOnlyElement, otherT.WarningOnlyElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(DirectionElement, otherT.DirectionElement)) return false;
                if (!DeepComparable.IsExactly(CompareToSourceIdElement, otherT.CompareToSourceIdElement)) return false;
                if (!DeepComparable.IsExactly(CompareToSourcePathElement, otherT.CompareToSourcePathElement)) return false;
                if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.IsExactly(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.IsExactly(MinimumIdElement, otherT.MinimumIdElement)) return false;
                if (!DeepComparable.IsExactly(NavigationLinksElement, otherT.NavigationLinksElement)) return false;
                if (!DeepComparable.IsExactly(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.IsExactly(ResponseElement, otherT.ResponseElement)) return false;
                if (!DeepComparable.IsExactly(ResponseCodeElement, otherT.ResponseCodeElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.IsExactly(ValidateProfileIdElement, otherT.ValidateProfileIdElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.IsExactly(WarningOnlyElement, otherT.WarningOnlyElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LabelElement != null) yield return LabelElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (DirectionElement != null) yield return DirectionElement;
                    if (CompareToSourceIdElement != null) yield return CompareToSourceIdElement;
                    if (CompareToSourcePathElement != null) yield return CompareToSourcePathElement;
                    if (ContentTypeElement != null) yield return ContentTypeElement;
                    if (HeaderFieldElement != null) yield return HeaderFieldElement;
                    if (MinimumIdElement != null) yield return MinimumIdElement;
                    if (NavigationLinksElement != null) yield return NavigationLinksElement;
                    if (OperatorElement != null) yield return OperatorElement;
                    if (PathElement != null) yield return PathElement;
                    if (ResourceElement != null) yield return ResourceElement;
                    if (ResponseElement != null) yield return ResponseElement;
                    if (ResponseCodeElement != null) yield return ResponseCodeElement;
                    if (SourceIdElement != null) yield return SourceIdElement;
                    if (ValidateProfileIdElement != null) yield return ValidateProfileIdElement;
                    if (ValueElement != null) yield return ValueElement;
                    if (WarningOnlyElement != null) yield return WarningOnlyElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LabelElement != null) yield return new ElementValue("label", LabelElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (DirectionElement != null) yield return new ElementValue("direction", DirectionElement);
                    if (CompareToSourceIdElement != null) yield return new ElementValue("compareToSourceId", CompareToSourceIdElement);
                    if (CompareToSourcePathElement != null) yield return new ElementValue("compareToSourcePath", CompareToSourcePathElement);
                    if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                    if (HeaderFieldElement != null) yield return new ElementValue("headerField", HeaderFieldElement);
                    if (MinimumIdElement != null) yield return new ElementValue("minimumId", MinimumIdElement);
                    if (NavigationLinksElement != null) yield return new ElementValue("navigationLinks", NavigationLinksElement);
                    if (OperatorElement != null) yield return new ElementValue("operator", OperatorElement);
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (ResourceElement != null) yield return new ElementValue("resource", ResourceElement);
                    if (ResponseElement != null) yield return new ElementValue("response", ResponseElement);
                    if (ResponseCodeElement != null) yield return new ElementValue("responseCode", ResponseCodeElement);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                    if (ValidateProfileIdElement != null) yield return new ElementValue("validateProfileId", ValidateProfileIdElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                    if (WarningOnlyElement != null) yield return new ElementValue("warningOnly", WarningOnlyElement);
                }
            }


        }


        [FhirType("TestComponent")]
        [DataContract]
        public partial class TestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TestComponent"; } }

            /// <summary>
            /// Tracking/logging name of this test
            /// </summary>
            [FhirElement("name", Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Tracking/logging name of this test
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
            /// Tracking/reporting short description of the test
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Tracking/reporting short description of the test
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
            /// Capabilities  that are expected to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("metadata", Order=60)]
            [DataMember]
            public MetadataComponent Metadata
            {
                get { return _metadata; }
                set { _metadata = value; OnPropertyChanged("Metadata"); }
            }

            private MetadataComponent _metadata;

            /// <summary>
            /// A test operation or assert to perform
            /// </summary>
            [FhirElement("action", Order=70)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<TestActionComponent> Action
            {
                get { if (_action == null) _action = new List<TestActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<TestActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Metadata != null) dest.Metadata = (MetadataComponent)Metadata.DeepCopy();
                    if (Action != null) dest.Action = new List<TestActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
                if (!DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Metadata != null) yield return Metadata;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Metadata != null) yield return new ElementValue("metadata", Metadata);
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("TestActionComponent")]
        [DataContract]
        public partial class TestActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TestActionComponent"; } }

            /// <summary>
            /// The setup operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// The setup assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public AssertComponent Assert
            {
                get { return _assert; }
                set { _assert = value; OnPropertyChanged("Assert"); }
            }

            private AssertComponent _assert;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Assert != null) dest.Assert = (AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TestActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Assert, otherT.Assert)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Assert, otherT.Assert)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                    if (Assert != null) yield return Assert;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Assert != null) yield return new ElementValue("assert", Assert);
                }
            }


        }


        [FhirType("TeardownComponent")]
        [DataContract]
        public partial class TeardownComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownComponent"; } }

            /// <summary>
            /// One or more teardown operations to perform
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<TearDownActionComponent> Action
            {
                get { if (_action == null) _action = new List<TearDownActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<TearDownActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = new List<TearDownActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TeardownComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("TearDownActionComponent")]
        [DataContract]
        public partial class TearDownActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TearDownActionComponent"; } }

            /// <summary>
            /// The teardown operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TearDownActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TearDownActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TearDownActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TearDownActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                }
            }


        }


        /// <summary>
        /// Absolute URL used to reference this TestScript
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Absolute URL used to reference this TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Logical id for this version of the TestScript
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Logical id for this version of the TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Informal name for this TestScript
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Informal name for this TestScript
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
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConformanceResourceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ConformanceResourceStatus> _statusElement;

        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=130)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=140)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=150)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact == null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Date for this version of the TestScript
        /// </summary>
        [FhirElement("date", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date for this version of the TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Natural language description of the TestScript
        /// </summary>
        [FhirElement("description", InSummary=true, Order=180)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Natural language description of the TestScript
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
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> UseContext
        {
            get { if (_useContext == null) _useContext = new List<CodeableConcept>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<CodeableConcept> _useContext;

        /// <summary>
        /// Scope and Usage this Test Script is for
        /// </summary>
        [FhirElement("requirements", Order=200)]
        [DataMember]
        public FhirString RequirementsElement
        {
            get { return _requirementsElement; }
            set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }

        private FhirString _requirementsElement;

        /// <summary>
        /// Scope and Usage this Test Script is for
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Requirements
        {
            get { return RequirementsElement != null ? RequirementsElement.Value : null; }
            set
            {
                if (value == null)
                    RequirementsElement = null;
                else
                    RequirementsElement = new FhirString(value);
                OnPropertyChanged("Requirements");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=210)]
        [DataMember]
        public FhirString CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private FhirString _copyrightElement;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new FhirString(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// Required capability that is assumed to function correctly on the FHIR server being tested
        /// </summary>
        [FhirElement("metadata", Order=220)]
        [DataMember]
        public MetadataComponent Metadata
        {
            get { return _metadata; }
            set { _metadata = value; OnPropertyChanged("Metadata"); }
        }

        private MetadataComponent _metadata;

        /// <summary>
        /// Whether or not the tests apply to more than one FHIR server
        /// </summary>
        [FhirElement("multiserver", Order=230)]
        [DataMember]
        public FhirBoolean MultiserverElement
        {
            get { return _multiserverElement; }
            set { _multiserverElement = value; OnPropertyChanged("MultiserverElement"); }
        }

        private FhirBoolean _multiserverElement;

        /// <summary>
        /// Whether or not the tests apply to more than one FHIR server
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Multiserver
        {
            get { return MultiserverElement != null ? MultiserverElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    MultiserverElement = null;
                else
                    MultiserverElement = new FhirBoolean(value);
                OnPropertyChanged("Multiserver");
            }
        }

        /// <summary>
        /// Fixture in the test script - by reference (uri)
        /// </summary>
        [FhirElement("fixture", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FixtureComponent> Fixture
        {
            get { if (_fixture == null) _fixture = new List<FixtureComponent>(); return _fixture; }
            set { _fixture = value; OnPropertyChanged("Fixture"); }
        }

        private List<FixtureComponent> _fixture;

        /// <summary>
        /// Reference of the validation profile
        /// </summary>
        [FhirElement("profile", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Profile
        {
            get { if (_profile == null) _profile = new List<ResourceReference>(); return _profile; }
            set { _profile = value; OnPropertyChanged("Profile"); }
        }

        private List<ResourceReference> _profile;

        /// <summary>
        /// Placeholder for evaluated elements
        /// </summary>
        [FhirElement("variable", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<VariableComponent> Variable
        {
            get { if (_variable == null) _variable = new List<VariableComponent>(); return _variable; }
            set { _variable = value; OnPropertyChanged("Variable"); }
        }

        private List<VariableComponent> _variable;

        /// <summary>
        /// A series of required setup operations before tests are executed
        /// </summary>
        [FhirElement("setup", Order=270)]
        [DataMember]
        public SetupComponent Setup
        {
            get { return _setup; }
            set { _setup = value; OnPropertyChanged("Setup"); }
        }

        private SetupComponent _setup;

        /// <summary>
        /// A test in this script
        /// </summary>
        [FhirElement("test", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TestComponent> Test
        {
            get { if (_test == null) _test = new List<TestComponent>(); return _test; }
            set { _test = value; OnPropertyChanged("Test"); }
        }

        private List<TestComponent> _test;

        /// <summary>
        /// A series of required clean up steps
        /// </summary>
        [FhirElement("teardown", Order=290)]
        [DataMember]
        public TeardownComponent Teardown
        {
            get { return _teardown; }
            set { _teardown = value; OnPropertyChanged("Teardown"); }
        }

        private TeardownComponent _teardown;


        public static ElementDefinition.ConstraintComponent TestScript_INV_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "metadata.all(capability.required or capability.validated)",
            Key = "inv-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "TestScript metadata capability SHALL contain required or validated or both.",
            Xpath = "f:capability/f:required or f:capability/f:validated or (f:capability/f:required and f:capability/f:validated)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "variable.all(headerField.empty() or path.empty())",
            Key = "inv-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Variable cannot contain both headerField and path.",
            Xpath = "not(f:headerField and f:path)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.metadata.all(capability.required or capability.validated)",
            Key = "inv-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup metadata capability SHALL contain required or validated or both.",
            Xpath = "f:capability/f:required or f:capability/f:validated or (f:capability/f:required and f:capability/f:validated)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.all(operation xor assert)",
            Key = "inv-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup action SHALL contain either an operation or assert but not both.",
            Xpath = "(f:operation or f:assert) and not(f:operation and f:assert)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_10 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.operation.all(sourceId or (targetId.count() + url.count() + params.count() = 1) or (type.code in ('conformance' |'search' | 'transaction' | 'history')))",
            Key = "inv-10",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup operation SHALL contain either sourceId or targetId or params or url.",
            Xpath = "f:sourceId or ((f:targetId or f:url or f:params) and (count(f:targetId) + count(f:url) + count(f:params) =1)) or (f:type/f:code/@value='conformance' or f:type/f:code/@value='search' or f:type/f:code/@value='transaction' or f:type/f:code/@value='history')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_13 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.assert.all(compareToSourceId.empty() xor compareToSourcePath)",
            Key = "inv-13",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup action assert shall contain both compareToSourceId and compareToSourcePath or neither.",
            Xpath = "(f:compareToSourceId and f:compareToSourcePath) or not(f:compareToSourceId or f:compareToSourcePath)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.assert.all(contentType.count() + headerField.count() + minimumId.count() + navigationLinks.count() + path.count() + resource.count() + responseCode.count() + response.count() + validateProfileId.count() <=1)",
            Key = "inv-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only a single assertion SHALL be present within setup action assert element.",
            Xpath = "count(f:contentType) + count(f:headerField) + count(f:minimumId) + count(f:navigationLinks) + count(f:path) + count(f:resource) + count(f:responseCode) + count(f:response) + count(f:validateProfileId)  <=1"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.metadata.all(capability.required or capability.validated)",
            Key = "inv-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test metadata capability SHALL contain required or validated or both.",
            Xpath = "f:capability/f:required or f:capability/f:validated or (f:capability/f:required and f:capability/f:validated)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.all(operation xor assert)",
            Key = "inv-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test action SHALL contain either an operation or assert but not both.",
            Xpath = "(f:operation or f:assert) and not(f:operation and f:assert)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_11 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.operation.all(sourceId or (targetId.count() + url.count() + params.count() = 1) or (type.code in ('conformance' | 'search' | 'transaction' | 'history')))",
            Key = "inv-11",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test operation SHALL contain either sourceId or targetId or params or url.",
            Xpath = "f:sourceId or (f:targetId or f:url or f:params) and (count(f:targetId) + count(f:url) + count(f:params) =1) or (f:type/f:code/@value='conformance' or f:type/f:code/@value='search' or f:type/f:code/@value='transaction' or f:type/f:code/@value='history')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_14 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.assert.all(compareToSourceId.empty() xor compareToSourcePath)",
            Key = "inv-14",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test action assert shall contain both compareToSourceId and compareToSourcePath or neither.",
            Xpath = "(f:compareToSourceId and f:compareToSourcePath) or not(f:compareToSourceId or f:compareToSourcePath)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.assert.all(contentType.count() + headerField.count() + minimumId.count() + navigationLinks.count() + path.count() + resource.count() + responseCode.count() + response.count() + validateProfileId.count() <=1)",
            Key = "inv-9",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only a single assertion SHALL be present within test action assert element.",
            Xpath = "count(f:contentType) + count(f:headerField) + count(f:minimumId) + count(f:navigationLinks) + count(f:path) + count(f:resource) + count(f:responseCode) + count(f:response) + count(f:validateProfileId)  <=1"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "teardown.action.all(operation)",
            Key = "inv-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Teardown action SHALL contain an operation.",
            Xpath = "f:operation"
        };

        public static ElementDefinition.ConstraintComponent TestScript_INV_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "teardown.action.operation.all(sourceId or (targetId.count() + url.count() + params.count() = 1) or (type.code in ('conformance' | 'search' | 'transaction' | 'history')))",
            Key = "inv-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Teardown operation SHALL contain either sourceId or targetId or params or url.",
            Xpath = "f:sourceId or (f:targetId or f:url or (f:params and f:resource)) and (count(f:targetId) + count(f:url) + count(f:params) =1) or (f:type/f:code/@value='conformance' or f:type/f:code/@value='search' or f:type/f:code/@value='transaction' or f:type/f:code/@value='history')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(TestScript_INV_5);
            InvariantConstraints.Add(TestScript_INV_4);
            InvariantConstraints.Add(TestScript_INV_6);
            InvariantConstraints.Add(TestScript_INV_1);
            InvariantConstraints.Add(TestScript_INV_10);
            InvariantConstraints.Add(TestScript_INV_13);
            InvariantConstraints.Add(TestScript_INV_8);
            InvariantConstraints.Add(TestScript_INV_7);
            InvariantConstraints.Add(TestScript_INV_2);
            InvariantConstraints.Add(TestScript_INV_11);
            InvariantConstraints.Add(TestScript_INV_14);
            InvariantConstraints.Add(TestScript_INV_9);
            InvariantConstraints.Add(TestScript_INV_3);
            InvariantConstraints.Add(TestScript_INV_12);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as TestScript;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConformanceResourceStatus>)StatusElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<CodeableConcept>(UseContext.DeepCopy());
                if (RequirementsElement != null) dest.RequirementsElement = (FhirString)RequirementsElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (FhirString)CopyrightElement.DeepCopy();
                if (Metadata != null) dest.Metadata = (MetadataComponent)Metadata.DeepCopy();
                if (MultiserverElement != null) dest.MultiserverElement = (FhirBoolean)MultiserverElement.DeepCopy();
                if (Fixture != null) dest.Fixture = new List<FixtureComponent>(Fixture.DeepCopy());
                if (Profile != null) dest.Profile = new List<ResourceReference>(Profile.DeepCopy());
                if (Variable != null) dest.Variable = new List<VariableComponent>(Variable.DeepCopy());
                if (Setup != null) dest.Setup = (SetupComponent)Setup.DeepCopy();
                if (Test != null) dest.Test = new List<TestComponent>(Test.DeepCopy());
                if (Teardown != null) dest.Teardown = (TeardownComponent)Teardown.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new TestScript());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as TestScript;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
            if (!DeepComparable.Matches(MultiserverElement, otherT.MultiserverElement)) return false;
            if (!DeepComparable.Matches(Fixture, otherT.Fixture)) return false;
            if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;
            if (!DeepComparable.Matches(Variable, otherT.Variable)) return false;
            if (!DeepComparable.Matches(Setup, otherT.Setup)) return false;
            if (!DeepComparable.Matches(Test, otherT.Test)) return false;
            if (!DeepComparable.Matches(Teardown, otherT.Teardown)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TestScript;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
            if (!DeepComparable.IsExactly(MultiserverElement, otherT.MultiserverElement)) return false;
            if (!DeepComparable.IsExactly(Fixture, otherT.Fixture)) return false;
            if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
            if (!DeepComparable.IsExactly(Variable, otherT.Variable)) return false;
            if (!DeepComparable.IsExactly(Setup, otherT.Setup)) return false;
            if (!DeepComparable.IsExactly(Test, otherT.Test)) return false;
            if (!DeepComparable.IsExactly(Teardown, otherT.Teardown)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (Identifier != null) yield return Identifier;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                if (RequirementsElement != null) yield return RequirementsElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                if (Metadata != null) yield return Metadata;
                if (MultiserverElement != null) yield return MultiserverElement;
                foreach (var elem in Fixture) { if (elem != null) yield return elem; }
                foreach (var elem in Profile) { if (elem != null) yield return elem; }
                foreach (var elem in Variable) { if (elem != null) yield return elem; }
                if (Setup != null) yield return Setup;
                foreach (var elem in Test) { if (elem != null) yield return elem; }
                if (Teardown != null) yield return Teardown;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (Metadata != null) yield return new ElementValue("metadata", Metadata);
                if (MultiserverElement != null) yield return new ElementValue("multiserver", MultiserverElement);
                foreach (var elem in Fixture) { if (elem != null) yield return new ElementValue("fixture", elem); }
                foreach (var elem in Profile) { if (elem != null) yield return new ElementValue("profile", elem); }
                foreach (var elem in Variable) { if (elem != null) yield return new ElementValue("variable", elem); }
                if (Setup != null) yield return new ElementValue("setup", Setup);
                foreach (var elem in Test) { if (elem != null) yield return new ElementValue("test", elem); }
                if (Teardown != null) yield return new ElementValue("teardown", Teardown);
            }
        }

    }

}
