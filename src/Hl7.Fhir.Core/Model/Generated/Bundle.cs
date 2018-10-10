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
    /// Contains a collection of resources
    /// </summary>
    [FhirType("Bundle", IsResource=true)]
    [DataContract]
    public partial class Bundle : Resource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Bundle; } }
        [NotMapped]
        public override string TypeName { get { return "Bundle"; } }

        /// <summary>
        /// Indicates the purpose of a bundle - how it was intended to be used.
        /// (url: http://hl7.org/fhir/ValueSet/bundle-type)
        /// </summary>
        [FhirEnumeration("BundleType")]
        public enum BundleType
        {
            /// <summary>
            /// The bundle is a document. The first resource is a Composition.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("document", "http://hl7.org/fhir/bundle-type"), Description("Document")]
            Document,
            /// <summary>
            /// The bundle is a message. The first resource is a MessageHeader.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("message", "http://hl7.org/fhir/bundle-type"), Description("Message")]
            Message,
            /// <summary>
            /// The bundle is a transaction - intended to be processed by a server as an atomic commit.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("transaction", "http://hl7.org/fhir/bundle-type"), Description("Transaction")]
            Transaction,
            /// <summary>
            /// The bundle is a transaction response. Because the response is a transaction response, the transactionhas succeeded, and all responses are error free.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("transaction-response", "http://hl7.org/fhir/bundle-type"), Description("Transaction Response")]
            TransactionResponse,
            /// <summary>
            /// The bundle is a transaction - intended to be processed by a server as a group of actions.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("batch", "http://hl7.org/fhir/bundle-type"), Description("Batch")]
            Batch,
            /// <summary>
            /// The bundle is a batch response. Note that as a batch, some responses may indicate failure and others success.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("batch-response", "http://hl7.org/fhir/bundle-type"), Description("Batch Response")]
            BatchResponse,
            /// <summary>
            /// The bundle is a list of resources from a history interaction on a server.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("history", "http://hl7.org/fhir/bundle-type"), Description("History List")]
            History,
            /// <summary>
            /// The bundle is a list of resources returned as a result of a search/query interaction, operation, or message.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("searchset", "http://hl7.org/fhir/bundle-type"), Description("Search Results")]
            Searchset,
            /// <summary>
            /// The bundle is a set of resources collected into a single document for ease of distribution.
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("collection", "http://hl7.org/fhir/bundle-type"), Description("Collection")]
            Collection,
        }

        /// <summary>
        /// Why an entry is in the result set - whether it's included as a match or because of an _include requirement.
        /// (url: http://hl7.org/fhir/ValueSet/search-entry-mode)
        /// </summary>
        [FhirEnumeration("SearchEntryMode")]
        public enum SearchEntryMode
        {
            /// <summary>
            /// This resource matched the search specification.
            /// (system: http://hl7.org/fhir/search-entry-mode)
            /// </summary>
            [EnumLiteral("match", "http://hl7.org/fhir/search-entry-mode"), Description("Match")]
            Match,
            /// <summary>
            /// This resource is returned because it is referred to from another resource in the search set.
            /// (system: http://hl7.org/fhir/search-entry-mode)
            /// </summary>
            [EnumLiteral("include", "http://hl7.org/fhir/search-entry-mode"), Description("Include")]
            Include,
            /// <summary>
            /// An OperationOutcome that provides additional information about the processing of a search.
            /// (system: http://hl7.org/fhir/search-entry-mode)
            /// </summary>
            [EnumLiteral("outcome", "http://hl7.org/fhir/search-entry-mode"), Description("Outcome")]
            Outcome,
        }

        /// <summary>
        /// HTTP verbs (in the HTTP command line).
        /// (url: http://hl7.org/fhir/ValueSet/http-verb)
        /// </summary>
        [FhirEnumeration("HTTPVerb")]
        public enum HTTPVerb
        {
            /// <summary>
            /// HTTP GET
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("GET", "http://hl7.org/fhir/http-verb"), Description("GET")]
            GET,
            /// <summary>
            /// HTTP POST
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("POST", "http://hl7.org/fhir/http-verb"), Description("POST")]
            POST,
            /// <summary>
            /// HTTP PUT
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("PUT", "http://hl7.org/fhir/http-verb"), Description("PUT")]
            PUT,
            /// <summary>
            /// HTTP DELETE
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("DELETE", "http://hl7.org/fhir/http-verb"), Description("DELETE")]
            DELETE,
        }


        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }

            /// <summary>
            /// http://www.iana.org/assignments/link-relations/link-relations.xhtml
            /// </summary>
            [FhirElement("relation", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString RelationElement
            {
                get { return _relationElement; }
                set { _relationElement = value; OnPropertyChanged("RelationElement"); }
            }

            private FhirString _relationElement;

            /// <summary>
            /// http://www.iana.org/assignments/link-relations/link-relations.xhtml
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Relation
            {
                get { return RelationElement != null ? RelationElement.Value : null; }
                set
                {
                    if (value == null)
                        RelationElement = null;
                    else
                        RelationElement = new FhirString(value);
                    OnPropertyChanged("Relation");
                }
            }

            /// <summary>
            /// Reference details for the link
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Reference details for the link
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RelationElement != null) dest.RelationElement = (FhirString)RelationElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
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
                if (!DeepComparable.Matches(RelationElement, otherT.RelationElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RelationElement, otherT.RelationElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RelationElement != null) yield return RelationElement;
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RelationElement != null) yield return new ElementValue("relation", RelationElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        [FhirType("EntryComponent")]
        [DataContract]
        public partial class EntryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EntryComponent"; } }

            /// <summary>
            /// Links related to this entry
            /// </summary>
            [FhirElement("link", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<LinkComponent> Link
            {
                get { if (_link == null) _link = new List<LinkComponent>(); return _link; }
                set { _link = value; OnPropertyChanged("Link"); }
            }

            private List<LinkComponent> _link;

            /// <summary>
            /// Absolute URL for resource (server address, or UUID/OID)
            /// </summary>
            [FhirElement("fullUrl", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri FullUrlElement
            {
                get { return _fullUrlElement; }
                set { _fullUrlElement = value; OnPropertyChanged("FullUrlElement"); }
            }

            private FhirUri _fullUrlElement;

            /// <summary>
            /// Absolute URL for resource (server address, or UUID/OID)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string FullUrl
            {
                get { return FullUrlElement != null ? FullUrlElement.Value : null; }
                set
                {
                    if (value == null)
                        FullUrlElement = null;
                    else
                        FullUrlElement = new FhirUri(value);
                    OnPropertyChanged("FullUrl");
                }
            }

            /// <summary>
            /// A resource in the bundle
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=60, Choice=ChoiceType.ResourceChoice)]
            [AllowedTypes(typeof(Resource))]
            [DataMember]
            public Resource Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private Resource _resource;

            /// <summary>
            /// Search related information
            /// </summary>
            [FhirElement("search", InSummary=true, Order=70)]
            [DataMember]
            public SearchComponent Search
            {
                get { return _search; }
                set { _search = value; OnPropertyChanged("Search"); }
            }

            private SearchComponent _search;

            /// <summary>
            /// Transaction Related Information
            /// </summary>
            [FhirElement("request", InSummary=true, Order=80)]
            [DataMember]
            public RequestComponent Request
            {
                get { return _request; }
                set { _request = value; OnPropertyChanged("Request"); }
            }

            private RequestComponent _request;

            /// <summary>
            /// Transaction Related Information
            /// </summary>
            [FhirElement("response", InSummary=true, Order=90)]
            [DataMember]
            public ResponseComponent Response
            {
                get { return _response; }
                set { _response = value; OnPropertyChanged("Response"); }
            }

            private ResponseComponent _response;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                    if (FullUrlElement != null) dest.FullUrlElement = (FhirUri)FullUrlElement.DeepCopy();
                    if (Resource != null) dest.Resource = (Resource)Resource.DeepCopy();
                    if (Search != null) dest.Search = (SearchComponent)Search.DeepCopy();
                    if (Request != null) dest.Request = (RequestComponent)Request.DeepCopy();
                    if (Response != null) dest.Response = (ResponseComponent)Response.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EntryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EntryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Link, otherT.Link)) return false;
                if (!DeepComparable.Matches(FullUrlElement, otherT.FullUrlElement)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if (!DeepComparable.Matches(Search, otherT.Search)) return false;
                if (!DeepComparable.Matches(Request, otherT.Request)) return false;
                if (!DeepComparable.Matches(Response, otherT.Response)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Link, otherT.Link)) return false;
                if (!DeepComparable.IsExactly(FullUrlElement, otherT.FullUrlElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Search, otherT.Search)) return false;
                if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
                if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Link) { if (elem != null) yield return elem; }
                    if (FullUrlElement != null) yield return FullUrlElement;
                    if (Resource != null) yield return Resource;
                    if (Search != null) yield return Search;
                    if (Request != null) yield return Request;
                    if (Response != null) yield return Response;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
                    if (FullUrlElement != null) yield return new ElementValue("fullUrl", FullUrlElement);
                    if (Resource != null) yield return new ElementValue("resource", Resource);
                    if (Search != null) yield return new ElementValue("search", Search);
                    if (Request != null) yield return new ElementValue("request", Request);
                    if (Response != null) yield return new ElementValue("response", Response);
                }
            }


        }


        [FhirType("SearchComponent")]
        [DataContract]
        public partial class SearchComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SearchComponent"; } }

            /// <summary>
            /// match | include | outcome - why this is in the result set
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=40)]
            [DataMember]
            public Code<SearchEntryMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<SearchEntryMode> _modeElement;

            /// <summary>
            /// match | include | outcome - why this is in the result set
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SearchEntryMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ModeElement = null;
                    else
                        ModeElement = new Code<SearchEntryMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Search ranking (between 0 and 1)
            /// </summary>
            [FhirElement("score", InSummary=true, Order=50)]
            [DataMember]
            public FhirDecimal ScoreElement
            {
                get { return _scoreElement; }
                set { _scoreElement = value; OnPropertyChanged("ScoreElement"); }
            }

            private FhirDecimal _scoreElement;

            /// <summary>
            /// Search ranking (between 0 and 1)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Score
            {
                get { return ScoreElement != null ? ScoreElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ScoreElement = null;
                    else
                        ScoreElement = new FhirDecimal(value);
                    OnPropertyChanged("Score");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SearchComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<SearchEntryMode>)ModeElement.DeepCopy();
                    if (ScoreElement != null) dest.ScoreElement = (FhirDecimal)ScoreElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SearchComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SearchComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(ScoreElement, otherT.ScoreElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SearchComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(ScoreElement, otherT.ScoreElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ModeElement != null) yield return ModeElement;
                    if (ScoreElement != null) yield return ScoreElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (ScoreElement != null) yield return new ElementValue("score", ScoreElement);
                }
            }


        }


        [FhirType("RequestComponent")]
        [DataContract]
        public partial class RequestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RequestComponent"; } }

            /// <summary>
            /// GET | POST | PUT | DELETE
            /// </summary>
            [FhirElement("method", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<HTTPVerb> MethodElement
            {
                get { return _methodElement; }
                set { _methodElement = value; OnPropertyChanged("MethodElement"); }
            }

            private Code<HTTPVerb> _methodElement;

            /// <summary>
            /// GET | POST | PUT | DELETE
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public HTTPVerb? Method
            {
                get { return MethodElement != null ? MethodElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        MethodElement = null;
                    else
                        MethodElement = new Code<HTTPVerb>(value);
                    OnPropertyChanged("Method");
                }
            }

            /// <summary>
            /// URL for HTTP equivalent of this entry
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// URL for HTTP equivalent of this entry
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
            /// For managing cache currency
            /// </summary>
            [FhirElement("ifNoneMatch", InSummary=true, Order=60)]
            [DataMember]
            public FhirString IfNoneMatchElement
            {
                get { return _ifNoneMatchElement; }
                set { _ifNoneMatchElement = value; OnPropertyChanged("IfNoneMatchElement"); }
            }

            private FhirString _ifNoneMatchElement;

            /// <summary>
            /// For managing cache currency
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string IfNoneMatch
            {
                get { return IfNoneMatchElement != null ? IfNoneMatchElement.Value : null; }
                set
                {
                    if (value == null)
                        IfNoneMatchElement = null;
                    else
                        IfNoneMatchElement = new FhirString(value);
                    OnPropertyChanged("IfNoneMatch");
                }
            }

            /// <summary>
            /// For managing update contention
            /// </summary>
            [FhirElement("ifModifiedSince", InSummary=true, Order=70)]
            [DataMember]
            public Instant IfModifiedSinceElement
            {
                get { return _ifModifiedSinceElement; }
                set { _ifModifiedSinceElement = value; OnPropertyChanged("IfModifiedSinceElement"); }
            }

            private Instant _ifModifiedSinceElement;

            /// <summary>
            /// For managing update contention
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DateTimeOffset? IfModifiedSince
            {
                get { return IfModifiedSinceElement != null ? IfModifiedSinceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        IfModifiedSinceElement = null;
                    else
                        IfModifiedSinceElement = new Instant(value);
                    OnPropertyChanged("IfModifiedSince");
                }
            }

            /// <summary>
            /// For managing update contention
            /// </summary>
            [FhirElement("ifMatch", InSummary=true, Order=80)]
            [DataMember]
            public FhirString IfMatchElement
            {
                get { return _ifMatchElement; }
                set { _ifMatchElement = value; OnPropertyChanged("IfMatchElement"); }
            }

            private FhirString _ifMatchElement;

            /// <summary>
            /// For managing update contention
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string IfMatch
            {
                get { return IfMatchElement != null ? IfMatchElement.Value : null; }
                set
                {
                    if (value == null)
                        IfMatchElement = null;
                    else
                        IfMatchElement = new FhirString(value);
                    OnPropertyChanged("IfMatch");
                }
            }

            /// <summary>
            /// For conditional creates
            /// </summary>
            [FhirElement("ifNoneExist", InSummary=true, Order=90)]
            [DataMember]
            public FhirString IfNoneExistElement
            {
                get { return _ifNoneExistElement; }
                set { _ifNoneExistElement = value; OnPropertyChanged("IfNoneExistElement"); }
            }

            private FhirString _ifNoneExistElement;

            /// <summary>
            /// For conditional creates
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string IfNoneExist
            {
                get { return IfNoneExistElement != null ? IfNoneExistElement.Value : null; }
                set
                {
                    if (value == null)
                        IfNoneExistElement = null;
                    else
                        IfNoneExistElement = new FhirString(value);
                    OnPropertyChanged("IfNoneExist");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (MethodElement != null) dest.MethodElement = (Code<HTTPVerb>)MethodElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (IfNoneMatchElement != null) dest.IfNoneMatchElement = (FhirString)IfNoneMatchElement.DeepCopy();
                    if (IfModifiedSinceElement != null) dest.IfModifiedSinceElement = (Instant)IfModifiedSinceElement.DeepCopy();
                    if (IfMatchElement != null) dest.IfMatchElement = (FhirString)IfMatchElement.DeepCopy();
                    if (IfNoneExistElement != null) dest.IfNoneExistElement = (FhirString)IfNoneExistElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RequestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(MethodElement, otherT.MethodElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.Matches(IfNoneMatchElement, otherT.IfNoneMatchElement)) return false;
                if (!DeepComparable.Matches(IfModifiedSinceElement, otherT.IfModifiedSinceElement)) return false;
                if (!DeepComparable.Matches(IfMatchElement, otherT.IfMatchElement)) return false;
                if (!DeepComparable.Matches(IfNoneExistElement, otherT.IfNoneExistElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(MethodElement, otherT.MethodElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(IfNoneMatchElement, otherT.IfNoneMatchElement)) return false;
                if (!DeepComparable.IsExactly(IfModifiedSinceElement, otherT.IfModifiedSinceElement)) return false;
                if (!DeepComparable.IsExactly(IfMatchElement, otherT.IfMatchElement)) return false;
                if (!DeepComparable.IsExactly(IfNoneExistElement, otherT.IfNoneExistElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (MethodElement != null) yield return MethodElement;
                    if (UrlElement != null) yield return UrlElement;
                    if (IfNoneMatchElement != null) yield return IfNoneMatchElement;
                    if (IfModifiedSinceElement != null) yield return IfModifiedSinceElement;
                    if (IfMatchElement != null) yield return IfMatchElement;
                    if (IfNoneExistElement != null) yield return IfNoneExistElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (MethodElement != null) yield return new ElementValue("method", MethodElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    if (IfNoneMatchElement != null) yield return new ElementValue("ifNoneMatch", IfNoneMatchElement);
                    if (IfModifiedSinceElement != null) yield return new ElementValue("ifModifiedSince", IfModifiedSinceElement);
                    if (IfMatchElement != null) yield return new ElementValue("ifMatch", IfMatchElement);
                    if (IfNoneExistElement != null) yield return new ElementValue("ifNoneExist", IfNoneExistElement);
                }
            }


        }


        [FhirType("ResponseComponent")]
        [DataContract]
        public partial class ResponseComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResponseComponent"; } }

            /// <summary>
            /// Status return code for entry
            /// </summary>
            [FhirElement("status", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private FhirString _statusElement;

            /// <summary>
            /// Status return code for entry
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusElement = null;
                    else
                        StatusElement = new FhirString(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// The location, if the operation returns a location
            /// </summary>
            [FhirElement("location", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri LocationElement
            {
                get { return _locationElement; }
                set { _locationElement = value; OnPropertyChanged("LocationElement"); }
            }

            private FhirUri _locationElement;

            /// <summary>
            /// The location, if the operation returns a location
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Location
            {
                get { return LocationElement != null ? LocationElement.Value : null; }
                set
                {
                    if (value == null)
                        LocationElement = null;
                    else
                        LocationElement = new FhirUri(value);
                    OnPropertyChanged("Location");
                }
            }

            /// <summary>
            /// The etag for the resource (if relevant)
            /// </summary>
            [FhirElement("etag", InSummary=true, Order=60)]
            [DataMember]
            public FhirString EtagElement
            {
                get { return _etagElement; }
                set { _etagElement = value; OnPropertyChanged("EtagElement"); }
            }

            private FhirString _etagElement;

            /// <summary>
            /// The etag for the resource (if relevant)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Etag
            {
                get { return EtagElement != null ? EtagElement.Value : null; }
                set
                {
                    if (value == null)
                        EtagElement = null;
                    else
                        EtagElement = new FhirString(value);
                    OnPropertyChanged("Etag");
                }
            }

            /// <summary>
            /// Server's date time modified
            /// </summary>
            [FhirElement("lastModified", InSummary=true, Order=70)]
            [DataMember]
            public Instant LastModifiedElement
            {
                get { return _lastModifiedElement; }
                set { _lastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
            }

            private Instant _lastModifiedElement;

            /// <summary>
            /// Server's date time modified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DateTimeOffset? LastModified
            {
                get { return LastModifiedElement != null ? LastModifiedElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        LastModifiedElement = null;
                    else
                        LastModifiedElement = new Instant(value);
                    OnPropertyChanged("LastModified");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResponseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StatusElement != null) dest.StatusElement = (FhirString)StatusElement.DeepCopy();
                    if (LocationElement != null) dest.LocationElement = (FhirUri)LocationElement.DeepCopy();
                    if (EtagElement != null) dest.EtagElement = (FhirString)EtagElement.DeepCopy();
                    if (LastModifiedElement != null) dest.LastModifiedElement = (Instant)LastModifiedElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ResponseComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResponseComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(LocationElement, otherT.LocationElement)) return false;
                if (!DeepComparable.Matches(EtagElement, otherT.EtagElement)) return false;
                if (!DeepComparable.Matches(LastModifiedElement, otherT.LastModifiedElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResponseComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(LocationElement, otherT.LocationElement)) return false;
                if (!DeepComparable.IsExactly(EtagElement, otherT.EtagElement)) return false;
                if (!DeepComparable.IsExactly(LastModifiedElement, otherT.LastModifiedElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StatusElement != null) yield return StatusElement;
                    if (LocationElement != null) yield return LocationElement;
                    if (EtagElement != null) yield return EtagElement;
                    if (LastModifiedElement != null) yield return LastModifiedElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (LocationElement != null) yield return new ElementValue("location", LocationElement);
                    if (EtagElement != null) yield return new ElementValue("etag", EtagElement);
                    if (LastModifiedElement != null) yield return new ElementValue("lastModified", LastModifiedElement);
                }
            }


        }


        /// <summary>
        /// document | message | transaction | transaction-response | batch | batch-response | history | searchset | collection
        /// </summary>
        [FhirElement("type", InSummary=true, Order=50)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<BundleType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<BundleType> _typeElement;

        /// <summary>
        /// document | message | transaction | transaction-response | batch | batch-response | history | searchset | collection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public BundleType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    TypeElement = null;
                else
                    TypeElement = new Code<BundleType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// If search, the total number of matches
        /// </summary>
        [FhirElement("total", InSummary=true, Order=60)]
        [DataMember]
        public UnsignedInt TotalElement
        {
            get { return _totalElement; }
            set { _totalElement = value; OnPropertyChanged("TotalElement"); }
        }

        private UnsignedInt _totalElement;

        /// <summary>
        /// If search, the total number of matches
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Total
        {
            get { return TotalElement != null ? TotalElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    TotalElement = null;
                else
                    TotalElement = new UnsignedInt(value);
                OnPropertyChanged("Total");
            }
        }

        /// <summary>
        /// Links related to this Bundle
        /// </summary>
        [FhirElement("link", InSummary=true, Order=70)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LinkComponent> Link
        {
            get { if (_link == null) _link = new List<LinkComponent>(); return _link; }
            set { _link = value; OnPropertyChanged("Link"); }
        }

        private List<LinkComponent> _link;

        /// <summary>
        /// Entry in the bundle - will have a resource, or information
        /// </summary>
        [FhirElement("entry", InSummary=true, Order=80)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EntryComponent> Entry
        {
            get { if (_entry == null) _entry = new List<EntryComponent>(); return _entry; }
            set { _entry = value; OnPropertyChanged("Entry"); }
        }

        private List<EntryComponent> _entry;

        /// <summary>
        /// Digital Signature
        /// </summary>
        [FhirElement("signature", InSummary=true, Order=90)]
        [DataMember]
        public Signature Signature
        {
            get { return _signature; }
            set { _signature = value; OnPropertyChanged("Signature"); }
        }

        private Signature _signature;


        public static ElementDefinition.ConstraintComponent Bundle_BDL_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entry.search.empty() or (type = 'searchset')",
            Key = "bdl-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "entry.search only when a search",
            Xpath = "not(f:entry/f:search) or (f:type/@value = 'searchset')"
        };

        public static ElementDefinition.ConstraintComponent Bundle_BDL_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "total.empty() or (type = 'searchset') or (type = 'history')",
            Key = "bdl-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "total only when a search or history",
            Xpath = "not(f:total) or (f:type/@value = 'searchset') or (f:type/@value = 'history')"
        };

        public static ElementDefinition.ConstraintComponent Bundle_BDL_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entry.where(fullUrl).select(fullUrl|resource.meta.versionId).isDistinct()",
            Key = "bdl-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "FullUrl must be unique in a bundle, or else entries with the same fullUrl must have different meta.versionId",
            Xpath = "count(for $entry in f:entry[f:resource] return $entry[count(parent::f:Bundle/f:entry[f:fullUrl/@value=$entry/f:fullUrl/@value and ((not(f:resource/*/f:meta/f:versionId/@value) and not($entry/f:resource/*/f:meta/f:versionId/@value)) or f:resource/*/f:meta/f:versionId/@value=$entry/f:resource/*/f:meta/f:versionId/@value)])!=1])=0"
        };

        public static ElementDefinition.ConstraintComponent Bundle_BDL_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entry.request.empty() or type = 'batch' or type = 'transaction' or type = 'history'",
            Key = "bdl-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "entry.request only for some types of bundles",
            Xpath = "not(f:entry/f:request) or (f:type/@value = 'batch') or (f:type/@value = 'transaction') or (f:type/@value = 'history')"
        };

        public static ElementDefinition.ConstraintComponent Bundle_BDL_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entry.response.empty() or type = 'batch-response' or type = 'transaction-response'",
            Key = "bdl-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "entry.response only for some types of bundles",
            Xpath = "not(f:entry/f:response) or (f:type/@value = 'batch-response') or (f:type/@value = 'transaction-response')"
        };

        public static ElementDefinition.ConstraintComponent Bundle_BDL_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entry.all(resource or request or response)",
            Key = "bdl-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "must be a resource unless there's a request or response",
            Xpath = "f:resource or f:request or f:response"
        };

        public static ElementDefinition.ConstraintComponent Bundle_BDL_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entry.all(fullUrl.empty() xor resource)",
            Key = "bdl-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The fullUrl element must be present when a resource is present, and not present otherwise",
            Xpath = "(not(exists(f:fullUrl)) and not(exists(f:resource))) or (exists(f:fullUrl) and exists(f:resource))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Bundle_BDL_2);
            InvariantConstraints.Add(Bundle_BDL_1);
            InvariantConstraints.Add(Bundle_BDL_7);
            InvariantConstraints.Add(Bundle_BDL_3);
            InvariantConstraints.Add(Bundle_BDL_4);
            InvariantConstraints.Add(Bundle_BDL_5);
            InvariantConstraints.Add(Bundle_BDL_6);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Bundle;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<BundleType>)TypeElement.DeepCopy();
                if (TotalElement != null) dest.TotalElement = (UnsignedInt)TotalElement.DeepCopy();
                if (Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                if (Entry != null) dest.Entry = new List<EntryComponent>(Entry.DeepCopy());
                if (Signature != null) dest.Signature = (Signature)Signature.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Bundle());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Bundle;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(TotalElement, otherT.TotalElement)) return false;
            if (!DeepComparable.Matches(Link, otherT.Link)) return false;
            if (!DeepComparable.Matches(Entry, otherT.Entry)) return false;
            if (!DeepComparable.Matches(Signature, otherT.Signature)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Bundle;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(TotalElement, otherT.TotalElement)) return false;
            if (!DeepComparable.IsExactly(Link, otherT.Link)) return false;
            if (!DeepComparable.IsExactly(Entry, otherT.Entry)) return false;
            if (!DeepComparable.IsExactly(Signature, otherT.Signature)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (TypeElement != null) yield return TypeElement;
                if (TotalElement != null) yield return TotalElement;
                foreach (var elem in Link) { if (elem != null) yield return elem; }
                foreach (var elem in Entry) { if (elem != null) yield return elem; }
                if (Signature != null) yield return Signature;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (TotalElement != null) yield return new ElementValue("total", TotalElement);
                foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
                foreach (var elem in Entry) { if (elem != null) yield return new ElementValue("entry", elem); }
                if (Signature != null) yield return new ElementValue("signature", Signature);
            }
        }

    }

}
