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
    /// Request to perform some action on or in regards to an existing resource
    /// </summary>
    [FhirType("ProcessRequest", IsResource=true)]
    [DataContract]
    public partial class ProcessRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ProcessRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ProcessRequest"; } }


        [FhirType("ItemsComponent")]
        [DataContract]
        public partial class ItemsComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemsComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequenceLinkId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer SequenceLinkIdElement
            {
                get { return _sequenceLinkIdElement; }
                set { _sequenceLinkIdElement = value; OnPropertyChanged("SequenceLinkIdElement"); }
            }

            private Integer _sequenceLinkIdElement;

            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? SequenceLinkId
            {
                get { return SequenceLinkIdElement != null ? SequenceLinkIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new Integer(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (Integer)SequenceLinkIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceLinkIdElement != null) yield return SequenceLinkIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceLinkIdElement != null) yield return new ElementValue("sequenceLinkId", false, SequenceLinkIdElement);
                }
            }


        }


        /// <summary>
        /// Business Identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<FinancialResourceStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<FinancialResourceStatusCodes> _statusElement;

        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FinancialResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<FinancialResourceStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// cancel | poll | reprocess | status
        /// </summary>
        [FhirElement("action", Order=110)]
        [DataMember]
        public Code<ActionList> ActionElement
        {
            get { return _actionElement; }
            set { _actionElement = value; OnPropertyChanged("ActionElement"); }
        }

        private Code<ActionList> _actionElement;

        /// <summary>
        /// cancel | poll | reprocess | status
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ActionList? Action
        {
            get { return ActionElement != null ? ActionElement.Value : null; }
            set
            {
                if (value == null)
                    ActionElement = null;
                else
                    ActionElement = new Code<ActionList>(value);
                OnPropertyChanged("Action");
            }
        }

        /// <summary>
        /// Party which is the target of the request
        /// </summary>
        [FhirElement("target", Order=120)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private ResourceReference _target;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=130)]
        [DataMember]
        public FhirDateTime CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private FhirDateTime _createdElement;

        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("provider", Order=140)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public ResourceReference Provider
        {
            get { return _provider; }
            set { _provider = value; OnPropertyChanged("Provider"); }
        }

        private ResourceReference _provider;

        /// <summary>
        /// Reference to the Request resource
        /// </summary>
        [FhirElement("request", Order=150)]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// Reference to the Response resource
        /// </summary>
        [FhirElement("response", Order=160)]
        [DataMember]
        public ResourceReference Response
        {
            get { return _response; }
            set { _response = value; OnPropertyChanged("Response"); }
        }

        private ResourceReference _response;

        /// <summary>
        /// Remove history
        /// </summary>
        [FhirElement("nullify", Order=170)]
        [DataMember]
        public FhirBoolean NullifyElement
        {
            get { return _nullifyElement; }
            set { _nullifyElement = value; OnPropertyChanged("NullifyElement"); }
        }

        private FhirBoolean _nullifyElement;

        /// <summary>
        /// Remove history
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Nullify
        {
            get { return NullifyElement != null ? NullifyElement.Value : null; }
            set
            {
                if (value == null)
                    NullifyElement = null;
                else
                    NullifyElement = new FhirBoolean(value);
                OnPropertyChanged("Nullify");
            }
        }

        /// <summary>
        /// Reference number/string
        /// </summary>
        [FhirElement("reference", Order=180)]
        [DataMember]
        public FhirString ReferenceElement
        {
            get { return _referenceElement; }
            set { _referenceElement = value; OnPropertyChanged("ReferenceElement"); }
        }

        private FhirString _referenceElement;

        /// <summary>
        /// Reference number/string
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Reference
        {
            get { return ReferenceElement != null ? ReferenceElement.Value : null; }
            set
            {
                if (value == null)
                    ReferenceElement = null;
                else
                    ReferenceElement = new FhirString(value);
                OnPropertyChanged("Reference");
            }
        }

        /// <summary>
        /// Items to re-adjudicate
        /// </summary>
        [FhirElement("item", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemsComponent> Item
        {
            get { if (_item==null) _item = new List<ItemsComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemsComponent> _item;

        /// <summary>
        /// Resource type(s) to include
        /// </summary>
        [FhirElement("include", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> IncludeElement
        {
            get { if (_includeElement==null) _includeElement = new List<FhirString>(); return _includeElement; }
            set { _includeElement = value; OnPropertyChanged("IncludeElement"); }
        }

        private List<FhirString> _includeElement;

        /// <summary>
        /// Resource type(s) to include
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Include
        {
            get { return IncludeElement != null ? IncludeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    IncludeElement = null;
                else
                    IncludeElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Include");
            }
        }

        /// <summary>
        /// Resource type(s) to exclude
        /// </summary>
        [FhirElement("exclude", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ExcludeElement
        {
            get { if (_excludeElement==null) _excludeElement = new List<FhirString>(); return _excludeElement; }
            set { _excludeElement = value; OnPropertyChanged("ExcludeElement"); }
        }

        private List<FhirString> _excludeElement;

        /// <summary>
        /// Resource type(s) to exclude
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Exclude
        {
            get { return ExcludeElement != null ? ExcludeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ExcludeElement = null;
                else
                    ExcludeElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Exclude");
            }
        }

        /// <summary>
        /// Selection period
        /// </summary>
        [FhirElement("period", Order=220)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProcessRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (ActionElement != null) dest.ActionElement = (Code<ActionList>)ActionElement.DeepCopy();
                if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Response != null) dest.Response = (ResourceReference)Response.DeepCopy();
                if (NullifyElement != null) dest.NullifyElement = (FhirBoolean)NullifyElement.DeepCopy();
                if (ReferenceElement != null) dest.ReferenceElement = (FhirString)ReferenceElement.DeepCopy();
                if (Item != null) dest.Item = new List<ItemsComponent>(Item.DeepCopy());
                if (IncludeElement != null) dest.IncludeElement = new List<FhirString>(IncludeElement.DeepCopy());
                if (ExcludeElement != null) dest.ExcludeElement = new List<FhirString>(ExcludeElement.DeepCopy());
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ProcessRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ProcessRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ActionElement, otherT.ActionElement)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Response, otherT.Response)) return false;
            if (!DeepComparable.Matches(NullifyElement, otherT.NullifyElement)) return false;
            if (!DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;
            if ( !DeepComparable.Matches(IncludeElement, otherT.IncludeElement)) return false;
            if ( !DeepComparable.Matches(ExcludeElement, otherT.ExcludeElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProcessRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ActionElement, otherT.ActionElement)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;
            if (!DeepComparable.IsExactly(NullifyElement, otherT.NullifyElement)) return false;
            if (!DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(IncludeElement, otherT.IncludeElement)) return false;
            if (!DeepComparable.IsExactly(ExcludeElement, otherT.ExcludeElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

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
                if (ActionElement != null) yield return ActionElement;
                if (Target != null) yield return Target;
                if (CreatedElement != null) yield return CreatedElement;
                if (Provider != null) yield return Provider;
                if (Request != null) yield return Request;
                if (Response != null) yield return Response;
                if (NullifyElement != null) yield return NullifyElement;
                if (ReferenceElement != null) yield return ReferenceElement;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                foreach (var elem in IncludeElement) { if (elem != null) yield return elem; }
                foreach (var elem in ExcludeElement) { if (elem != null) yield return elem; }
                if (Period != null) yield return Period;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (ActionElement != null) yield return new ElementValue("action", false, ActionElement);
                if (Target != null) yield return new ElementValue("target", false, Target);
                if (CreatedElement != null) yield return new ElementValue("created", false, CreatedElement);
                if (Provider != null) yield return new ElementValue("provider", false, Provider);
                if (Request != null) yield return new ElementValue("request", false, Request);
                if (Response != null) yield return new ElementValue("response", false, Response);
                if (NullifyElement != null) yield return new ElementValue("nullify", false, NullifyElement);
                if (ReferenceElement != null) yield return new ElementValue("reference", false, ReferenceElement);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", true, elem); }
                foreach (var elem in IncludeElement) { if (elem != null) yield return new ElementValue("include", true, elem); }
                foreach (var elem in ExcludeElement) { if (elem != null) yield return new ElementValue("exclude", true, elem); }
                if (Period != null) yield return new ElementValue("period", false, Period);
            }
        }

    }

}
