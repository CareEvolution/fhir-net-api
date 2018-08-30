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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Legal Agreement
    /// </summary>
    [FhirType("Contract", IsResource=true)]
    [DataContract]
    public partial class Contract : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Contract; } }
        [NotMapped]
        public override string TypeName { get { return "Contract"; } }

        /// <summary>
        /// This value set contract specific codes for status.
        /// (url: http://hl7.org/fhir/ValueSet/contract-status)
        /// </summary>
        [FhirEnumeration("ContractResourceStatusCodes")]
        public enum ContractResourceStatusCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("amended", "http://hl7.org/fhir/contract-status"), Description("Amended")]
            Amended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("appended", "http://hl7.org/fhir/contract-status"), Description("Appended")]
            Appended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/contract-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("disputed", "http://hl7.org/fhir/contract-status"), Description("Disputed")]
            Disputed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/contract-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("executable", "http://hl7.org/fhir/contract-status"), Description("Executable")]
            Executable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("executed", "http://hl7.org/fhir/contract-status"), Description("Executed")]
            Executed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("negotiable", "http://hl7.org/fhir/contract-status"), Description("Negotiable")]
            Negotiable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("offered", "http://hl7.org/fhir/contract-status"), Description("Offered")]
            Offered,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("policy", "http://hl7.org/fhir/contract-status"), Description("Policy")]
            Policy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/contract-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("renewed", "http://hl7.org/fhir/contract-status"), Description("Renewed")]
            Renewed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("revoked", "http://hl7.org/fhir/contract-status"), Description("Revoked")]
            Revoked,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("resolved", "http://hl7.org/fhir/contract-status"), Description("Resolved")]
            Resolved,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("terminated", "http://hl7.org/fhir/contract-status"), Description("Terminated")]
            Terminated,
        }

        /// <summary>
        /// This value set contract specific codes for status.
        /// (url: http://hl7.org/fhir/ValueSet/contract-publicationstatus)
        /// </summary>
        [FhirEnumeration("ContractResourcePublicationStatusCodes")]
        public enum ContractResourcePublicationStatusCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("amended", "http://hl7.org/fhir/contract-publicationstatus"), Description("Amended")]
            Amended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("appended", "http://hl7.org/fhir/contract-publicationstatus"), Description("Appended")]
            Appended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/contract-publicationstatus"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("disputed", "http://hl7.org/fhir/contract-publicationstatus"), Description("Disputed")]
            Disputed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/contract-publicationstatus"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("executable", "http://hl7.org/fhir/contract-publicationstatus"), Description("Executable")]
            Executable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("executed", "http://hl7.org/fhir/contract-publicationstatus"), Description("Executed")]
            Executed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("negotiable", "http://hl7.org/fhir/contract-publicationstatus"), Description("Negotiable")]
            Negotiable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("offered", "http://hl7.org/fhir/contract-publicationstatus"), Description("Offered")]
            Offered,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("policy", "http://hl7.org/fhir/contract-publicationstatus"), Description("Policy")]
            Policy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/contract-publicationstatus"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("renewed", "http://hl7.org/fhir/contract-publicationstatus"), Description("Renewed")]
            Renewed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("revoked", "http://hl7.org/fhir/contract-publicationstatus"), Description("Revoked")]
            Revoked,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("resolved", "http://hl7.org/fhir/contract-publicationstatus"), Description("Resolved")]
            Resolved,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-publicationstatus)
            /// </summary>
            [EnumLiteral("terminated", "http://hl7.org/fhir/contract-publicationstatus"), Description("Terminated")]
            Terminated,
        }


        [FhirType("ContentDefinitionComponent")]
        [DataContract]
        public partial class ContentDefinitionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContentDefinitionComponent"; } }

            /// <summary>
            /// Content structure and use
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Detailed Content Type Definition
            /// </summary>
            [FhirElement("subType", Order=50)]
            [DataMember]
            public CodeableConcept SubType
            {
                get { return _subType; }
                set { _subType = value; OnPropertyChanged("SubType"); }
            }

            private CodeableConcept _subType;

            /// <summary>
            /// Publisher Entity
            /// </summary>
            [FhirElement("publisher", Order=60)]
            [References("Person","Practitioner","Organization")]
            [DataMember]
            public ResourceReference Publisher
            {
                get { return _publisher; }
                set { _publisher = value; OnPropertyChanged("Publisher"); }
            }

            private ResourceReference _publisher;

            /// <summary>
            /// When published
            /// </summary>
            [FhirElement("publicationDate", Order=70)]
            [DataMember]
            public FhirDateTime PublicationDateElement
            {
                get { return _publicationDateElement; }
                set { _publicationDateElement = value; OnPropertyChanged("PublicationDateElement"); }
            }

            private FhirDateTime _publicationDateElement;

            /// <summary>
            /// When published
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PublicationDate
            {
                get { return PublicationDateElement != null ? PublicationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PublicationDateElement = null;
                    else
                        PublicationDateElement = new FhirDateTime(value);
                    OnPropertyChanged("PublicationDate");
                }
            }

            /// <summary>
            /// draft | active | retired | unknown
            /// </summary>
            [FhirElement("publicationStatus", Order=80)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ContractResourcePublicationStatusCodes> PublicationStatusElement
            {
                get { return _publicationStatusElement; }
                set { _publicationStatusElement = value; OnPropertyChanged("PublicationStatusElement"); }
            }

            private Code<ContractResourcePublicationStatusCodes> _publicationStatusElement;

            /// <summary>
            /// draft | active | retired | unknown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ContractResourcePublicationStatusCodes? PublicationStatus
            {
                get { return PublicationStatusElement != null ? PublicationStatusElement.Value : null; }
                set
                {
                    if (value == null)
                        PublicationStatusElement = null;
                    else
                        PublicationStatusElement = new Code<ContractResourcePublicationStatusCodes>(value);
                    OnPropertyChanged("PublicationStatus");
                }
            }

            /// <summary>
            /// Publication Ownership
            /// </summary>
            [FhirElement("copyright", Order=90)]
            [DataMember]
            public Markdown Copyright
            {
                get { return _copyright; }
                set { _copyright = value; OnPropertyChanged("Copyright"); }
            }

            private Markdown _copyright;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContentDefinitionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (SubType != null) dest.SubType = (CodeableConcept)SubType.DeepCopy();
                    if (Publisher != null) dest.Publisher = (ResourceReference)Publisher.DeepCopy();
                    if (PublicationDateElement != null) dest.PublicationDateElement = (FhirDateTime)PublicationDateElement.DeepCopy();
                    if (PublicationStatusElement != null) dest.PublicationStatusElement = (Code<ContractResourcePublicationStatusCodes>)PublicationStatusElement.DeepCopy();
                    if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContentDefinitionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContentDefinitionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(SubType, otherT.SubType)) return false;
                if (!DeepComparable.Matches(Publisher, otherT.Publisher)) return false;
                if (!DeepComparable.Matches(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if (!DeepComparable.Matches(PublicationStatusElement, otherT.PublicationStatusElement)) return false;
                if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContentDefinitionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
                if (!DeepComparable.IsExactly(Publisher, otherT.Publisher)) return false;
                if (!DeepComparable.IsExactly(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if (!DeepComparable.IsExactly(PublicationStatusElement, otherT.PublicationStatusElement)) return false;
                if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (SubType != null) yield return SubType;
                    if (Publisher != null) yield return Publisher;
                    if (PublicationDateElement != null) yield return PublicationDateElement;
                    if (PublicationStatusElement != null) yield return PublicationStatusElement;
                    if (Copyright != null) yield return Copyright;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (SubType != null) yield return new ElementValue("subType", SubType);
                    if (Publisher != null) yield return new ElementValue("publisher", Publisher);
                    if (PublicationDateElement != null) yield return new ElementValue("publicationDate", PublicationDateElement);
                    if (PublicationStatusElement != null) yield return new ElementValue("publicationStatus", PublicationStatusElement);
                    if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                }
            }


        }


        [FhirType("TermComponent")]
        [DataContract]
        public partial class TermComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TermComponent"; } }

            /// <summary>
            /// Contract Term Number
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            [FhirElement("issued", InSummary=true, Order=50)]
            [DataMember]
            public FhirDateTime IssuedElement
            {
                get { return _issuedElement; }
                set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
            }

            private FhirDateTime _issuedElement;

            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Issued
            {
                get { return IssuedElement != null ? IssuedElement.Value : null; }
                set
                {
                    if (value == null)
                        IssuedElement = null;
                    else
                        IssuedElement = new FhirDateTime(value);
                    OnPropertyChanged("Issued");
                }
            }

            /// <summary>
            /// Contract Term Effective Time
            /// </summary>
            [FhirElement("applies", InSummary=true, Order=60)]
            [DataMember]
            public Period Applies
            {
                get { return _applies; }
                set { _applies = value; OnPropertyChanged("Applies"); }
            }

            private Period _applies;

            /// <summary>
            /// Term Concern
            /// </summary>
            [FhirElement("topic", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Topic
            {
                get { return _topic; }
                set { _topic = value; OnPropertyChanged("Topic"); }
            }

            private Element _topic;

            /// <summary>
            /// Contract Term Type or Form
            /// </summary>
            [FhirElement("type", Order=80)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Contract Term Type specific classification
            /// </summary>
            [FhirElement("subType", Order=90)]
            [DataMember]
            public CodeableConcept SubType
            {
                get { return _subType; }
                set { _subType = value; OnPropertyChanged("SubType"); }
            }

            private CodeableConcept _subType;

            /// <summary>
            /// Term Statement
            /// </summary>
            [FhirElement("text", InSummary=true, Order=100)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Term Statement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// Protection for the Term
            /// </summary>
            [FhirElement("securityLabel", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SecurityLabelComponent> SecurityLabel
            {
                get { if (_securityLabel==null) _securityLabel = new List<SecurityLabelComponent>(); return _securityLabel; }
                set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }

            private List<SecurityLabelComponent> _securityLabel;

            /// <summary>
            /// Context of the Contract term
            /// </summary>
            [FhirElement("offer", Order=120)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ContractOfferComponent Offer
            {
                get { return _offer; }
                set { _offer = value; OnPropertyChanged("Offer"); }
            }

            private ContractOfferComponent _offer;

            /// <summary>
            /// Contract Term Asset List
            /// </summary>
            [FhirElement("asset", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContractAssetComponent> Asset
            {
                get { if (_asset==null) _asset = new List<ContractAssetComponent>(); return _asset; }
                set { _asset = value; OnPropertyChanged("Asset"); }
            }

            private List<ContractAssetComponent> _asset;

            /// <summary>
            /// Entity being ascribed responsibility
            /// </summary>
            [FhirElement("action", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ActionComponent> Action
            {
                get { if (_action==null) _action = new List<ActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<ActionComponent> _action;

            /// <summary>
            /// Nested Contract Term Group
            /// </summary>
            [FhirElement("group", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermComponent> Group
            {
                get { if (_group==null) _group = new List<TermComponent>(); return _group; }
                set { _group = value; OnPropertyChanged("Group"); }
            }

            private List<TermComponent> _group;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                    if (Applies != null) dest.Applies = (Period)Applies.DeepCopy();
                    if (Topic != null) dest.Topic = (Element)Topic.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (SubType != null) dest.SubType = (CodeableConcept)SubType.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (SecurityLabel != null) dest.SecurityLabel = new List<SecurityLabelComponent>(SecurityLabel.DeepCopy());
                    if (Offer != null) dest.Offer = (ContractOfferComponent)Offer.DeepCopy();
                    if (Asset != null) dest.Asset = new List<ContractAssetComponent>(Asset.DeepCopy());
                    if (Action != null) dest.Action = new List<ActionComponent>(Action.DeepCopy());
                    if (Group != null) dest.Group = new List<TermComponent>(Group.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TermComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
                if (!DeepComparable.Matches(Applies, otherT.Applies)) return false;
                if (!DeepComparable.Matches(Topic, otherT.Topic)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(SubType, otherT.SubType)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
                if (!DeepComparable.Matches(Offer, otherT.Offer)) return false;
                if ( !DeepComparable.Matches(Asset, otherT.Asset)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
                if ( !DeepComparable.Matches(Group, otherT.Group)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
                if (!DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
                if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
                if (!DeepComparable.IsExactly(Offer, otherT.Offer)) return false;
                if (!DeepComparable.IsExactly(Asset, otherT.Asset)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (IssuedElement != null) yield return IssuedElement;
                    if (Applies != null) yield return Applies;
                    if (Topic != null) yield return Topic;
                    if (Type != null) yield return Type;
                    if (SubType != null) yield return SubType;
                    if (TextElement != null) yield return TextElement;
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                    if (Offer != null) yield return Offer;
                    foreach (var elem in Asset) { if (elem != null) yield return elem; }
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                    foreach (var elem in Group) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                    if (Applies != null) yield return new ElementValue("applies", Applies);
                    if (Topic != null) yield return new ElementValue("topic", Topic);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (SubType != null) yield return new ElementValue("subType", SubType);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                    if (Offer != null) yield return new ElementValue("offer", Offer);
                    foreach (var elem in Asset) { if (elem != null) yield return new ElementValue("asset", elem); }
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                    foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                }
            }


        }


        [FhirType("SecurityLabelComponent")]
        [DataContract]
        public partial class SecurityLabelComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SecurityLabelComponent"; } }

            /// <summary>
            /// Link to Security Labels
            /// </summary>
            [FhirElement("number", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<UnsignedInt> NumberElement
            {
                get { if (_numberElement==null) _numberElement = new List<UnsignedInt>(); return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private List<UnsignedInt> _numberElement;

            /// <summary>
            /// Link to Security Labels
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> Number
            {
                get { return NumberElement != null ? NumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new List<UnsignedInt>(value.Select(elem=>new UnsignedInt(elem)));
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// Confidentiality Protection
            /// </summary>
            [FhirElement("classification", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Classification
            {
                get { return _classification; }
                set { _classification = value; OnPropertyChanged("Classification"); }
            }

            private Coding _classification;

            /// <summary>
            /// Applicable Policy
            /// </summary>
            [FhirElement("category", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Category
            {
                get { if (_category==null) _category = new List<Coding>(); return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private List<Coding> _category;

            /// <summary>
            /// Handling Instructions
            /// </summary>
            [FhirElement("control", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Control
            {
                get { if (_control==null) _control = new List<Coding>(); return _control; }
                set { _control = value; OnPropertyChanged("Control"); }
            }

            private List<Coding> _control;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SecurityLabelComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NumberElement != null) dest.NumberElement = new List<UnsignedInt>(NumberElement.DeepCopy());
                    if (Classification != null) dest.Classification = (Coding)Classification.DeepCopy();
                    if (Category != null) dest.Category = new List<Coding>(Category.DeepCopy());
                    if (Control != null) dest.Control = new List<Coding>(Control.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SecurityLabelComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SecurityLabelComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(Classification, otherT.Classification)) return false;
                if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if ( !DeepComparable.Matches(Control, otherT.Control)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SecurityLabelComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Control, otherT.Control)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in NumberElement) { if (elem != null) yield return elem; }
                    if (Classification != null) yield return Classification;
                    foreach (var elem in Category) { if (elem != null) yield return elem; }
                    foreach (var elem in Control) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in NumberElement) { if (elem != null) yield return new ElementValue("number", elem); }
                    if (Classification != null) yield return new ElementValue("classification", Classification);
                    foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                    foreach (var elem in Control) { if (elem != null) yield return new ElementValue("control", elem); }
                }
            }


        }


        [FhirType("ContractOfferComponent")]
        [DataContract]
        public partial class ContractOfferComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContractOfferComponent"; } }

            /// <summary>
            /// Offer business ID
            /// </summary>
            [FhirElement("identifier", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Identifier> Identifier
            {
                get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private List<Identifier> _identifier;

            /// <summary>
            /// Offer Recipient
            /// </summary>
            [FhirElement("party", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContractPartyComponent> Party
            {
                get { if (_party==null) _party = new List<ContractPartyComponent>(); return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private List<ContractPartyComponent> _party;

            /// <summary>
            /// Negotiable offer asset
            /// </summary>
            [FhirElement("topic", InSummary=true, Order=60)]
            [DataMember]
            public ResourceReference Topic
            {
                get { return _topic; }
                set { _topic = value; OnPropertyChanged("Topic"); }
            }

            private ResourceReference _topic;

            /// <summary>
            /// Contract Offer Type or Form
            /// </summary>
            [FhirElement("type", Order=70)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Accepting party choice
            /// </summary>
            [FhirElement("decision", Order=80)]
            [DataMember]
            public CodeableConcept Decision
            {
                get { return _decision; }
                set { _decision = value; OnPropertyChanged("Decision"); }
            }

            private CodeableConcept _decision;

            /// <summary>
            /// How decision is conveyed
            /// </summary>
            [FhirElement("decisionMode", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> DecisionMode
            {
                get { if (_decisionMode==null) _decisionMode = new List<CodeableConcept>(); return _decisionMode; }
                set { _decisionMode = value; OnPropertyChanged("DecisionMode"); }
            }

            private List<CodeableConcept> _decisionMode;

            /// <summary>
            /// Response to offer text
            /// </summary>
            [FhirElement("answer", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AnswerComponent> Answer
            {
                get { if (_answer==null) _answer = new List<AnswerComponent>(); return _answer; }
                set { _answer = value; OnPropertyChanged("Answer"); }
            }

            private List<AnswerComponent> _answer;

            /// <summary>
            /// Human readable offer text
            /// </summary>
            [FhirElement("text", Order=110)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Human readable offer text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// Pointer to text
            /// </summary>
            [FhirElement("linkId", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> LinkIdElement
            {
                get { if (_linkIdElement==null) _linkIdElement = new List<FhirString>(); return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private List<FhirString> _linkIdElement;

            /// <summary>
            /// Pointer to text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LinkIdElement = null;
                    else
                        LinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("LinkId");
                }
            }

            /// <summary>
            /// Offer restriction numbers
            /// </summary>
            [FhirElement("securityLabelNumber", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<UnsignedInt> SecurityLabelNumberElement
            {
                get { if (_securityLabelNumberElement==null) _securityLabelNumberElement = new List<UnsignedInt>(); return _securityLabelNumberElement; }
                set { _securityLabelNumberElement = value; OnPropertyChanged("SecurityLabelNumberElement"); }
            }

            private List<UnsignedInt> _securityLabelNumberElement;

            /// <summary>
            /// Offer restriction numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SecurityLabelNumber
            {
                get { return SecurityLabelNumberElement != null ? SecurityLabelNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SecurityLabelNumberElement = null;
                    else
                        SecurityLabelNumberElement = new List<UnsignedInt>(value.Select(elem=>new UnsignedInt(elem)));
                    OnPropertyChanged("SecurityLabelNumber");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContractOfferComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                    if (Party != null) dest.Party = new List<ContractPartyComponent>(Party.DeepCopy());
                    if (Topic != null) dest.Topic = (ResourceReference)Topic.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Decision != null) dest.Decision = (CodeableConcept)Decision.DeepCopy();
                    if (DecisionMode != null) dest.DecisionMode = new List<CodeableConcept>(DecisionMode.DeepCopy());
                    if (Answer != null) dest.Answer = new List<AnswerComponent>(Answer.DeepCopy());
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (LinkIdElement != null) dest.LinkIdElement = new List<FhirString>(LinkIdElement.DeepCopy());
                    if (SecurityLabelNumberElement != null) dest.SecurityLabelNumberElement = new List<UnsignedInt>(SecurityLabelNumberElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContractOfferComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContractOfferComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if ( !DeepComparable.Matches(Party, otherT.Party)) return false;
                if (!DeepComparable.Matches(Topic, otherT.Topic)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Decision, otherT.Decision)) return false;
                if ( !DeepComparable.Matches(DecisionMode, otherT.DecisionMode)) return false;
                if ( !DeepComparable.Matches(Answer, otherT.Answer)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if ( !DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if ( !DeepComparable.Matches(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContractOfferComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;
                if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Decision, otherT.Decision)) return false;
                if (!DeepComparable.IsExactly(DecisionMode, otherT.DecisionMode)) return false;
                if (!DeepComparable.IsExactly(Answer, otherT.Answer)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                    foreach (var elem in Party) { if (elem != null) yield return elem; }
                    if (Topic != null) yield return Topic;
                    if (Type != null) yield return Type;
                    if (Decision != null) yield return Decision;
                    foreach (var elem in DecisionMode) { if (elem != null) yield return elem; }
                    foreach (var elem in Answer) { if (elem != null) yield return elem; }
                    if (TextElement != null) yield return TextElement;
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                    foreach (var elem in Party) { if (elem != null) yield return new ElementValue("party", elem); }
                    if (Topic != null) yield return new ElementValue("topic", Topic);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Decision != null) yield return new ElementValue("decision", Decision);
                    foreach (var elem in DecisionMode) { if (elem != null) yield return new ElementValue("decisionMode", elem); }
                    foreach (var elem in Answer) { if (elem != null) yield return new ElementValue("answer", elem); }
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return new ElementValue("linkId", elem); }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return new ElementValue("securityLabelNumber", elem); }
                }
            }


        }


        [FhirType("ContractPartyComponent")]
        [DataContract]
        public partial class ContractPartyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContractPartyComponent"; } }

            /// <summary>
            /// Referenced entity
            /// </summary>
            [FhirElement("reference", Order=40)]
            [References("Patient","Person","RelatedPerson","Practitioner","Device","Group","Organization")]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceReference> Reference
            {
                get { if (_reference==null) _reference = new List<ResourceReference>(); return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private List<ResourceReference> _reference;

            /// <summary>
            /// Participant engagement type
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContractPartyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = new List<ResourceReference>(Reference.DeepCopy());
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContractPartyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContractPartyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContractPartyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Reference) { if (elem != null) yield return elem; }
                    if (Role != null) yield return Role;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Reference) { if (elem != null) yield return new ElementValue("reference", elem); }
                    if (Role != null) yield return new ElementValue("role", Role);
                }
            }


        }


        [FhirType("AnswerComponent")]
        [DataContract]
        public partial class AnswerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AnswerComponent"; } }

            /// <summary>
            /// The actual answer response
            /// </summary>
            [FhirElement("value", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(FhirDecimal),typeof(Integer),typeof(Date),typeof(FhirDateTime),typeof(Time),typeof(FhirString),typeof(FhirUri),typeof(Attachment),typeof(Coding),typeof(Quantity),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AnswerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AnswerComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AnswerComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AnswerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        [FhirType("ContractAssetComponent")]
        [DataContract]
        public partial class ContractAssetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContractAssetComponent"; } }

            /// <summary>
            /// Range of asset
            /// </summary>
            [FhirElement("scope", Order=40)]
            [DataMember]
            public CodeableConcept Scope
            {
                get { return _scope; }
                set { _scope = value; OnPropertyChanged("Scope"); }
            }

            private CodeableConcept _scope;

            /// <summary>
            /// Asset category
            /// </summary>
            [FhirElement("type", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Associated entities
            /// </summary>
            [FhirElement("typeReference", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> TypeReference
            {
                get { if (_typeReference==null) _typeReference = new List<ResourceReference>(); return _typeReference; }
                set { _typeReference = value; OnPropertyChanged("TypeReference"); }
            }

            private List<ResourceReference> _typeReference;

            /// <summary>
            /// Asset sub-category
            /// </summary>
            [FhirElement("subtype", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Subtype
            {
                get { if (_subtype==null) _subtype = new List<CodeableConcept>(); return _subtype; }
                set { _subtype = value; OnPropertyChanged("Subtype"); }
            }

            private List<CodeableConcept> _subtype;

            /// <summary>
            /// Kinship of the asset
            /// </summary>
            [FhirElement("relationship", Order=80)]
            [DataMember]
            public Coding Relationship
            {
                get { return _relationship; }
                set { _relationship = value; OnPropertyChanged("Relationship"); }
            }

            private Coding _relationship;

            /// <summary>
            /// Circumstance of the asset
            /// </summary>
            [FhirElement("context", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AssetContextComponent> Context
            {
                get { if (_context==null) _context = new List<AssetContextComponent>(); return _context; }
                set { _context = value; OnPropertyChanged("Context"); }
            }

            private List<AssetContextComponent> _context;

            /// <summary>
            /// Quality desctiption of asset
            /// </summary>
            [FhirElement("condition", Order=100)]
            [DataMember]
            public FhirString ConditionElement
            {
                get { return _conditionElement; }
                set { _conditionElement = value; OnPropertyChanged("ConditionElement"); }
            }

            private FhirString _conditionElement;

            /// <summary>
            /// Quality desctiption of asset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Condition
            {
                get { return ConditionElement != null ? ConditionElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionElement = null;
                    else
                        ConditionElement = new FhirString(value);
                    OnPropertyChanged("Condition");
                }
            }

            /// <summary>
            /// Asset availability types
            /// </summary>
            [FhirElement("periodType", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> PeriodType
            {
                get { if (_periodType==null) _periodType = new List<CodeableConcept>(); return _periodType; }
                set { _periodType = value; OnPropertyChanged("PeriodType"); }
            }

            private List<CodeableConcept> _periodType;

            /// <summary>
            /// Time period of the asset
            /// </summary>
            [FhirElement("period", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Period> Period
            {
                get { if (_period==null) _period = new List<Period>(); return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private List<Period> _period;

            /// <summary>
            /// Time period
            /// </summary>
            [FhirElement("usePeriod", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Period> UsePeriod
            {
                get { if (_usePeriod==null) _usePeriod = new List<Period>(); return _usePeriod; }
                set { _usePeriod = value; OnPropertyChanged("UsePeriod"); }
            }

            private List<Period> _usePeriod;

            /// <summary>
            /// Asset clause or question text
            /// </summary>
            [FhirElement("text", Order=140)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Asset clause or question text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// Pointer to asset text
            /// </summary>
            [FhirElement("linkId", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> LinkIdElement
            {
                get { if (_linkIdElement==null) _linkIdElement = new List<FhirString>(); return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private List<FhirString> _linkIdElement;

            /// <summary>
            /// Pointer to asset text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LinkIdElement = null;
                    else
                        LinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("LinkId");
                }
            }

            /// <summary>
            /// Response to assets
            /// </summary>
            [FhirElement("answer", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AnswerComponent> Answer
            {
                get { if (_answer==null) _answer = new List<AnswerComponent>(); return _answer; }
                set { _answer = value; OnPropertyChanged("Answer"); }
            }

            private List<AnswerComponent> _answer;

            /// <summary>
            /// Asset restriction numbers
            /// </summary>
            [FhirElement("securityLabelNumber", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<UnsignedInt> SecurityLabelNumberElement
            {
                get { if (_securityLabelNumberElement==null) _securityLabelNumberElement = new List<UnsignedInt>(); return _securityLabelNumberElement; }
                set { _securityLabelNumberElement = value; OnPropertyChanged("SecurityLabelNumberElement"); }
            }

            private List<UnsignedInt> _securityLabelNumberElement;

            /// <summary>
            /// Asset restriction numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SecurityLabelNumber
            {
                get { return SecurityLabelNumberElement != null ? SecurityLabelNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SecurityLabelNumberElement = null;
                    else
                        SecurityLabelNumberElement = new List<UnsignedInt>(value.Select(elem=>new UnsignedInt(elem)));
                    OnPropertyChanged("SecurityLabelNumber");
                }
            }

            /// <summary>
            /// Contract Valued Item List
            /// </summary>
            [FhirElement("valuedItem", Order=180)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ValuedItemComponent> ValuedItem
            {
                get { if (_valuedItem==null) _valuedItem = new List<ValuedItemComponent>(); return _valuedItem; }
                set { _valuedItem = value; OnPropertyChanged("ValuedItem"); }
            }

            private List<ValuedItemComponent> _valuedItem;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContractAssetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Scope != null) dest.Scope = (CodeableConcept)Scope.DeepCopy();
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (TypeReference != null) dest.TypeReference = new List<ResourceReference>(TypeReference.DeepCopy());
                    if (Subtype != null) dest.Subtype = new List<CodeableConcept>(Subtype.DeepCopy());
                    if (Relationship != null) dest.Relationship = (Coding)Relationship.DeepCopy();
                    if (Context != null) dest.Context = new List<AssetContextComponent>(Context.DeepCopy());
                    if (ConditionElement != null) dest.ConditionElement = (FhirString)ConditionElement.DeepCopy();
                    if (PeriodType != null) dest.PeriodType = new List<CodeableConcept>(PeriodType.DeepCopy());
                    if (Period != null) dest.Period = new List<Period>(Period.DeepCopy());
                    if (UsePeriod != null) dest.UsePeriod = new List<Period>(UsePeriod.DeepCopy());
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (LinkIdElement != null) dest.LinkIdElement = new List<FhirString>(LinkIdElement.DeepCopy());
                    if (Answer != null) dest.Answer = new List<AnswerComponent>(Answer.DeepCopy());
                    if (SecurityLabelNumberElement != null) dest.SecurityLabelNumberElement = new List<UnsignedInt>(SecurityLabelNumberElement.DeepCopy());
                    if (ValuedItem != null) dest.ValuedItem = new List<ValuedItemComponent>(ValuedItem.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContractAssetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContractAssetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Scope, otherT.Scope)) return false;
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(TypeReference, otherT.TypeReference)) return false;
                if ( !DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
                if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if ( !DeepComparable.Matches(Context, otherT.Context)) return false;
                if (!DeepComparable.Matches(ConditionElement, otherT.ConditionElement)) return false;
                if ( !DeepComparable.Matches(PeriodType, otherT.PeriodType)) return false;
                if ( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if ( !DeepComparable.Matches(UsePeriod, otherT.UsePeriod)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if ( !DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if ( !DeepComparable.Matches(Answer, otherT.Answer)) return false;
                if ( !DeepComparable.Matches(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;
                if ( !DeepComparable.Matches(ValuedItem, otherT.ValuedItem)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContractAssetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Scope, otherT.Scope)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(TypeReference, otherT.TypeReference)) return false;
                if (!DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
                if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
                if (!DeepComparable.IsExactly(ConditionElement, otherT.ConditionElement)) return false;
                if (!DeepComparable.IsExactly(PeriodType, otherT.PeriodType)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(UsePeriod, otherT.UsePeriod)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Answer, otherT.Answer)) return false;
                if (!DeepComparable.IsExactly(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;
                if (!DeepComparable.IsExactly(ValuedItem, otherT.ValuedItem)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Scope != null) yield return Scope;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    foreach (var elem in TypeReference) { if (elem != null) yield return elem; }
                    foreach (var elem in Subtype) { if (elem != null) yield return elem; }
                    if (Relationship != null) yield return Relationship;
                    foreach (var elem in Context) { if (elem != null) yield return elem; }
                    if (ConditionElement != null) yield return ConditionElement;
                    foreach (var elem in PeriodType) { if (elem != null) yield return elem; }
                    foreach (var elem in Period) { if (elem != null) yield return elem; }
                    foreach (var elem in UsePeriod) { if (elem != null) yield return elem; }
                    if (TextElement != null) yield return TextElement;
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Answer) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ValuedItem) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Scope != null) yield return new ElementValue("scope", Scope);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                    foreach (var elem in TypeReference) { if (elem != null) yield return new ElementValue("typeReference", elem); }
                    foreach (var elem in Subtype) { if (elem != null) yield return new ElementValue("subtype", elem); }
                    if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                    foreach (var elem in Context) { if (elem != null) yield return new ElementValue("context", elem); }
                    if (ConditionElement != null) yield return new ElementValue("condition", ConditionElement);
                    foreach (var elem in PeriodType) { if (elem != null) yield return new ElementValue("periodType", elem); }
                    foreach (var elem in Period) { if (elem != null) yield return new ElementValue("period", elem); }
                    foreach (var elem in UsePeriod) { if (elem != null) yield return new ElementValue("usePeriod", elem); }
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return new ElementValue("linkId", elem); }
                    foreach (var elem in Answer) { if (elem != null) yield return new ElementValue("answer", elem); }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return new ElementValue("securityLabelNumber", elem); }
                    foreach (var elem in ValuedItem) { if (elem != null) yield return new ElementValue("valuedItem", elem); }
                }
            }


        }


        [FhirType("AssetContextComponent")]
        [DataContract]
        public partial class AssetContextComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AssetContextComponent"; } }

            /// <summary>
            /// Creator,custodian or owner
            /// </summary>
            [FhirElement("reference", Order=40)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Codeable asset context
            /// </summary>
            [FhirElement("code", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Code
            {
                get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<CodeableConcept> _code;

            /// <summary>
            /// Context description
            /// </summary>
            [FhirElement("text", Order=60)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Context description
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AssetContextComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AssetContextComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AssetContextComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AssetContextComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Reference != null) yield return Reference;
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    if (TextElement != null) yield return TextElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                }
            }


        }


        [FhirType("ValuedItemComponent")]
        [DataContract]
        public partial class ValuedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ValuedItemComponent"; } }

            /// <summary>
            /// Contract Valued Item Type
            /// </summary>
            [FhirElement("entity", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private Element _entity;

            /// <summary>
            /// Contract Valued Item Number
            /// </summary>
            [FhirElement("identifier", Order=50)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            [FhirElement("effectiveTime", Order=60)]
            [DataMember]
            public FhirDateTime EffectiveTimeElement
            {
                get { return _effectiveTimeElement; }
                set { _effectiveTimeElement = value; OnPropertyChanged("EffectiveTimeElement"); }
            }

            private FhirDateTime _effectiveTimeElement;

            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string EffectiveTime
            {
                get { return EffectiveTimeElement != null ? EffectiveTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveTimeElement = null;
                    else
                        EffectiveTimeElement = new FhirDateTime(value);
                    OnPropertyChanged("EffectiveTime");
                }
            }

            /// <summary>
            /// Count of Contract Valued Items
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Contract Valued Item fee, charge, or cost
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            [FhirElement("factor", Order=90)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            [FhirElement("points", Order=100)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (value == null)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Total Contract Valued Item Value
            /// </summary>
            [FhirElement("net", Order=110)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            /// <summary>
            /// Terms of valuation
            /// </summary>
            [FhirElement("payment", Order=120)]
            [DataMember]
            public FhirString PaymentElement
            {
                get { return _paymentElement; }
                set { _paymentElement = value; OnPropertyChanged("PaymentElement"); }
            }

            private FhirString _paymentElement;

            /// <summary>
            /// Terms of valuation
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Payment
            {
                get { return PaymentElement != null ? PaymentElement.Value : null; }
                set
                {
                    if (value == null)
                        PaymentElement = null;
                    else
                        PaymentElement = new FhirString(value);
                    OnPropertyChanged("Payment");
                }
            }

            /// <summary>
            /// When payment is due
            /// </summary>
            [FhirElement("paymentDate", Order=130)]
            [DataMember]
            public FhirDateTime PaymentDateElement
            {
                get { return _paymentDateElement; }
                set { _paymentDateElement = value; OnPropertyChanged("PaymentDateElement"); }
            }

            private FhirDateTime _paymentDateElement;

            /// <summary>
            /// When payment is due
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PaymentDate
            {
                get { return PaymentDateElement != null ? PaymentDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PaymentDateElement = null;
                    else
                        PaymentDateElement = new FhirDateTime(value);
                    OnPropertyChanged("PaymentDate");
                }
            }

            /// <summary>
            /// Who will make payment
            /// </summary>
            [FhirElement("responsible", Order=140)]
            [References("Organization","Patient","Practitioner","RelatedPerson")]
            [DataMember]
            public ResourceReference Responsible
            {
                get { return _responsible; }
                set { _responsible = value; OnPropertyChanged("Responsible"); }
            }

            private ResourceReference _responsible;

            /// <summary>
            /// Who will receive payment
            /// </summary>
            [FhirElement("recipient", Order=150)]
            [References("Organization","Patient","Practitioner","RelatedPerson")]
            [DataMember]
            public ResourceReference Recipient
            {
                get { return _recipient; }
                set { _recipient = value; OnPropertyChanged("Recipient"); }
            }

            private ResourceReference _recipient;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            [FhirElement("linkId", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> LinkIdElement
            {
                get { if (_linkIdElement==null) _linkIdElement = new List<FhirString>(); return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private List<FhirString> _linkIdElement;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LinkIdElement = null;
                    else
                        LinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("LinkId");
                }
            }

            /// <summary>
            /// Security Labels that define affected terms
            /// </summary>
            [FhirElement("securityLabelNumber", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<UnsignedInt> SecurityLabelNumberElement
            {
                get { if (_securityLabelNumberElement==null) _securityLabelNumberElement = new List<UnsignedInt>(); return _securityLabelNumberElement; }
                set { _securityLabelNumberElement = value; OnPropertyChanged("SecurityLabelNumberElement"); }
            }

            private List<UnsignedInt> _securityLabelNumberElement;

            /// <summary>
            /// Security Labels that define affected terms
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SecurityLabelNumber
            {
                get { return SecurityLabelNumberElement != null ? SecurityLabelNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SecurityLabelNumberElement = null;
                    else
                        SecurityLabelNumberElement = new List<UnsignedInt>(value.Select(elem=>new UnsignedInt(elem)));
                    OnPropertyChanged("SecurityLabelNumber");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValuedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (Element)Entity.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (EffectiveTimeElement != null) dest.EffectiveTimeElement = (FhirDateTime)EffectiveTimeElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (PaymentElement != null) dest.PaymentElement = (FhirString)PaymentElement.DeepCopy();
                    if (PaymentDateElement != null) dest.PaymentDateElement = (FhirDateTime)PaymentDateElement.DeepCopy();
                    if (Responsible != null) dest.Responsible = (ResourceReference)Responsible.DeepCopy();
                    if (Recipient != null) dest.Recipient = (ResourceReference)Recipient.DeepCopy();
                    if (LinkIdElement != null) dest.LinkIdElement = new List<FhirString>(LinkIdElement.DeepCopy());
                    if (SecurityLabelNumberElement != null) dest.SecurityLabelNumberElement = new List<UnsignedInt>(SecurityLabelNumberElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ValuedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if (!DeepComparable.Matches(PaymentElement, otherT.PaymentElement)) return false;
                if (!DeepComparable.Matches(PaymentDateElement, otherT.PaymentDateElement)) return false;
                if (!DeepComparable.Matches(Responsible, otherT.Responsible)) return false;
                if (!DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
                if ( !DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if ( !DeepComparable.Matches(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(PaymentElement, otherT.PaymentElement)) return false;
                if (!DeepComparable.IsExactly(PaymentDateElement, otherT.PaymentDateElement)) return false;
                if (!DeepComparable.IsExactly(Responsible, otherT.Responsible)) return false;
                if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    if (Identifier != null) yield return Identifier;
                    if (EffectiveTimeElement != null) yield return EffectiveTimeElement;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                    if (PaymentElement != null) yield return PaymentElement;
                    if (PaymentDateElement != null) yield return PaymentDateElement;
                    if (Responsible != null) yield return Responsible;
                    if (Recipient != null) yield return Recipient;
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (EffectiveTimeElement != null) yield return new ElementValue("effectiveTime", EffectiveTimeElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    if (PaymentElement != null) yield return new ElementValue("payment", PaymentElement);
                    if (PaymentDateElement != null) yield return new ElementValue("paymentDate", PaymentDateElement);
                    if (Responsible != null) yield return new ElementValue("responsible", Responsible);
                    if (Recipient != null) yield return new ElementValue("recipient", Recipient);
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return new ElementValue("linkId", elem); }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return new ElementValue("securityLabelNumber", elem); }
                }
            }


        }


        [FhirType("ActionComponent")]
        [DataContract]
        public partial class ActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionComponent"; } }

            /// <summary>
            /// True if the term prohibits the  action
            /// </summary>
            [FhirElement("doNotPerform", Order=40)]
            [DataMember]
            public FhirBoolean DoNotPerformElement
            {
                get { return _doNotPerformElement; }
                set { _doNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
            }

            private FhirBoolean _doNotPerformElement;

            /// <summary>
            /// True if the term prohibits the  action
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? DoNotPerform
            {
                get { return DoNotPerformElement != null ? DoNotPerformElement.Value : null; }
                set
                {
                    if (value == null)
                        DoNotPerformElement = null;
                    else
                        DoNotPerformElement = new FhirBoolean(value);
                    OnPropertyChanged("DoNotPerform");
                }
            }

            /// <summary>
            /// Type or form of the action
            /// </summary>
            [FhirElement("type", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Entity of the action
            /// </summary>
            [FhirElement("subject", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ActionSubjectComponent> Subject
            {
                get { if (_subject==null) _subject = new List<ActionSubjectComponent>(); return _subject; }
                set { _subject = value; OnPropertyChanged("Subject"); }
            }

            private List<ActionSubjectComponent> _subject;

            /// <summary>
            /// Purpose for the Contract Term Action
            /// </summary>
            [FhirElement("intent", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Intent
            {
                get { return _intent; }
                set { _intent = value; OnPropertyChanged("Intent"); }
            }

            private CodeableConcept _intent;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            [FhirElement("linkId", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> LinkIdElement
            {
                get { if (_linkIdElement==null) _linkIdElement = new List<FhirString>(); return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private List<FhirString> _linkIdElement;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LinkIdElement = null;
                    else
                        LinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("LinkId");
                }
            }

            /// <summary>
            /// State of the action
            /// </summary>
            [FhirElement("status", Order=90)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Status
            {
                get { return _status; }
                set { _status = value; OnPropertyChanged("Status"); }
            }

            private CodeableConcept _status;

            /// <summary>
            /// Episode associated with action
            /// </summary>
            [FhirElement("context", Order=100)]
            [References("Encounter","EpisodeOfCare")]
            [DataMember]
            public ResourceReference Context
            {
                get { return _context; }
                set { _context = value; OnPropertyChanged("Context"); }
            }

            private ResourceReference _context;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            [FhirElement("contextLinkId", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ContextLinkIdElement
            {
                get { if (_contextLinkIdElement==null) _contextLinkIdElement = new List<FhirString>(); return _contextLinkIdElement; }
                set { _contextLinkIdElement = value; OnPropertyChanged("ContextLinkIdElement"); }
            }

            private List<FhirString> _contextLinkIdElement;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> ContextLinkId
            {
                get { return ContextLinkIdElement != null ? ContextLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ContextLinkIdElement = null;
                    else
                        ContextLinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("ContextLinkId");
                }
            }

            /// <summary>
            /// When action happens
            /// </summary>
            [FhirElement("occurrence", Order=120, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
            [DataMember]
            public Element Occurrence
            {
                get { return _occurrence; }
                set { _occurrence = value; OnPropertyChanged("Occurrence"); }
            }

            private Element _occurrence;

            /// <summary>
            /// Who asked for action
            /// </summary>
            [FhirElement("requester", Order=130)]
            [References("Patient","Person","RelatedPerson","Practitioner","Device","Group","Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Requester
            {
                get { if (_requester==null) _requester = new List<ResourceReference>(); return _requester; }
                set { _requester = value; OnPropertyChanged("Requester"); }
            }

            private List<ResourceReference> _requester;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            [FhirElement("requesterLinkId", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> RequesterLinkIdElement
            {
                get { if (_requesterLinkIdElement==null) _requesterLinkIdElement = new List<FhirString>(); return _requesterLinkIdElement; }
                set { _requesterLinkIdElement = value; OnPropertyChanged("RequesterLinkIdElement"); }
            }

            private List<FhirString> _requesterLinkIdElement;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> RequesterLinkId
            {
                get { return RequesterLinkIdElement != null ? RequesterLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        RequesterLinkIdElement = null;
                    else
                        RequesterLinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("RequesterLinkId");
                }
            }

            /// <summary>
            /// Kind of service performer
            /// </summary>
            [FhirElement("performerType", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> PerformerType
            {
                get { if (_performerType==null) _performerType = new List<CodeableConcept>(); return _performerType; }
                set { _performerType = value; OnPropertyChanged("PerformerType"); }
            }

            private List<CodeableConcept> _performerType;

            /// <summary>
            /// Competency of the performer
            /// </summary>
            [FhirElement("performerRole", Order=160)]
            [DataMember]
            public CodeableConcept PerformerRole
            {
                get { return _performerRole; }
                set { _performerRole = value; OnPropertyChanged("PerformerRole"); }
            }

            private CodeableConcept _performerRole;

            /// <summary>
            /// Actor that wil execute (or not) the action
            /// </summary>
            [FhirElement("performer", Order=170)]
            [References("Person","RelatedPerson","Patient","Practitioner","PractitionerRole","CareTeam","Device","Substance","Organization","Location")]
            [DataMember]
            public ResourceReference Performer
            {
                get { return _performer; }
                set { _performer = value; OnPropertyChanged("Performer"); }
            }

            private ResourceReference _performer;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            [FhirElement("performerLinkId", Order=180)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> PerformerLinkIdElement
            {
                get { if (_performerLinkIdElement==null) _performerLinkIdElement = new List<FhirString>(); return _performerLinkIdElement; }
                set { _performerLinkIdElement = value; OnPropertyChanged("PerformerLinkIdElement"); }
            }

            private List<FhirString> _performerLinkIdElement;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> PerformerLinkId
            {
                get { return PerformerLinkIdElement != null ? PerformerLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PerformerLinkIdElement = null;
                    else
                        PerformerLinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("PerformerLinkId");
                }
            }

            /// <summary>
            /// Why is action (not) needed?
            /// </summary>
            [FhirElement("reasonCode", Order=190)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ReasonCode
            {
                get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
                set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
            }

            private List<CodeableConcept> _reasonCode;

            /// <summary>
            /// Why is action (not) needed?
            /// </summary>
            [FhirElement("reasonReference", Order=200)]
            [References("Condition","Observation","DiagnosticReport","DocumentReference","Questionnaire","QuestionnaireResponse")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> ReasonReference
            {
                get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
                set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
            }

            private List<ResourceReference> _reasonReference;

            /// <summary>
            /// Why action is to be performed
            /// </summary>
            [FhirElement("reason", Order=210)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ReasonElement
            {
                get { if (_reasonElement==null) _reasonElement = new List<FhirString>(); return _reasonElement; }
                set { _reasonElement = value; OnPropertyChanged("ReasonElement"); }
            }

            private List<FhirString> _reasonElement;

            /// <summary>
            /// Why action is to be performed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Reason
            {
                get { return ReasonElement != null ? ReasonElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReasonElement = null;
                    else
                        ReasonElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Reason");
                }
            }

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            [FhirElement("reasonLinkId", Order=220)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ReasonLinkIdElement
            {
                get { if (_reasonLinkIdElement==null) _reasonLinkIdElement = new List<FhirString>(); return _reasonLinkIdElement; }
                set { _reasonLinkIdElement = value; OnPropertyChanged("ReasonLinkIdElement"); }
            }

            private List<FhirString> _reasonLinkIdElement;

            /// <summary>
            /// Pointer to specific item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> ReasonLinkId
            {
                get { return ReasonLinkIdElement != null ? ReasonLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReasonLinkIdElement = null;
                    else
                        ReasonLinkIdElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("ReasonLinkId");
                }
            }

            /// <summary>
            /// Comments about the action
            /// </summary>
            [FhirElement("note", Order=230)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Annotation> Note
            {
                get { if (_note==null) _note = new List<Annotation>(); return _note; }
                set { _note = value; OnPropertyChanged("Note"); }
            }

            private List<Annotation> _note;

            /// <summary>
            /// Action restriction numbers
            /// </summary>
            [FhirElement("securityLabelNumber", Order=240)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<UnsignedInt> SecurityLabelNumberElement
            {
                get { if (_securityLabelNumberElement==null) _securityLabelNumberElement = new List<UnsignedInt>(); return _securityLabelNumberElement; }
                set { _securityLabelNumberElement = value; OnPropertyChanged("SecurityLabelNumberElement"); }
            }

            private List<UnsignedInt> _securityLabelNumberElement;

            /// <summary>
            /// Action restriction numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SecurityLabelNumber
            {
                get { return SecurityLabelNumberElement != null ? SecurityLabelNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SecurityLabelNumberElement = null;
                    else
                        SecurityLabelNumberElement = new List<UnsignedInt>(value.Select(elem=>new UnsignedInt(elem)));
                    OnPropertyChanged("SecurityLabelNumber");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DoNotPerformElement != null) dest.DoNotPerformElement = (FhirBoolean)DoNotPerformElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Subject != null) dest.Subject = new List<ActionSubjectComponent>(Subject.DeepCopy());
                    if (Intent != null) dest.Intent = (CodeableConcept)Intent.DeepCopy();
                    if (LinkIdElement != null) dest.LinkIdElement = new List<FhirString>(LinkIdElement.DeepCopy());
                    if (Status != null) dest.Status = (CodeableConcept)Status.DeepCopy();
                    if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                    if (ContextLinkIdElement != null) dest.ContextLinkIdElement = new List<FhirString>(ContextLinkIdElement.DeepCopy());
                    if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                    if (Requester != null) dest.Requester = new List<ResourceReference>(Requester.DeepCopy());
                    if (RequesterLinkIdElement != null) dest.RequesterLinkIdElement = new List<FhirString>(RequesterLinkIdElement.DeepCopy());
                    if (PerformerType != null) dest.PerformerType = new List<CodeableConcept>(PerformerType.DeepCopy());
                    if (PerformerRole != null) dest.PerformerRole = (CodeableConcept)PerformerRole.DeepCopy();
                    if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                    if (PerformerLinkIdElement != null) dest.PerformerLinkIdElement = new List<FhirString>(PerformerLinkIdElement.DeepCopy());
                    if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                    if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                    if (ReasonElement != null) dest.ReasonElement = new List<FhirString>(ReasonElement.DeepCopy());
                    if (ReasonLinkIdElement != null) dest.ReasonLinkIdElement = new List<FhirString>(ReasonLinkIdElement.DeepCopy());
                    if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                    if (SecurityLabelNumberElement != null) dest.SecurityLabelNumberElement = new List<UnsignedInt>(SecurityLabelNumberElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
                if (!DeepComparable.Matches(Intent, otherT.Intent)) return false;
                if ( !DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.Matches(Status, otherT.Status)) return false;
                if (!DeepComparable.Matches(Context, otherT.Context)) return false;
                if ( !DeepComparable.Matches(ContextLinkIdElement, otherT.ContextLinkIdElement)) return false;
                if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
                if ( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
                if ( !DeepComparable.Matches(RequesterLinkIdElement, otherT.RequesterLinkIdElement)) return false;
                if ( !DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
                if (!DeepComparable.Matches(PerformerRole, otherT.PerformerRole)) return false;
                if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
                if ( !DeepComparable.Matches(PerformerLinkIdElement, otherT.PerformerLinkIdElement)) return false;
                if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
                if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
                if ( !DeepComparable.Matches(ReasonElement, otherT.ReasonElement)) return false;
                if ( !DeepComparable.Matches(ReasonLinkIdElement, otherT.ReasonLinkIdElement)) return false;
                if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
                if ( !DeepComparable.Matches(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
                if (!DeepComparable.IsExactly(Intent, otherT.Intent)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
                if (!DeepComparable.IsExactly(ContextLinkIdElement, otherT.ContextLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
                if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
                if (!DeepComparable.IsExactly(RequesterLinkIdElement, otherT.RequesterLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
                if (!DeepComparable.IsExactly(PerformerRole, otherT.PerformerRole)) return false;
                if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
                if (!DeepComparable.IsExactly(PerformerLinkIdElement, otherT.PerformerLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
                if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
                if (!DeepComparable.IsExactly(ReasonElement, otherT.ReasonElement)) return false;
                if (!DeepComparable.IsExactly(ReasonLinkIdElement, otherT.ReasonLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
                if (!DeepComparable.IsExactly(SecurityLabelNumberElement, otherT.SecurityLabelNumberElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DoNotPerformElement != null) yield return DoNotPerformElement;
                    if (Type != null) yield return Type;
                    foreach (var elem in Subject) { if (elem != null) yield return elem; }
                    if (Intent != null) yield return Intent;
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return elem; }
                    if (Status != null) yield return Status;
                    if (Context != null) yield return Context;
                    foreach (var elem in ContextLinkIdElement) { if (elem != null) yield return elem; }
                    if (Occurrence != null) yield return Occurrence;
                    foreach (var elem in Requester) { if (elem != null) yield return elem; }
                    foreach (var elem in RequesterLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in PerformerType) { if (elem != null) yield return elem; }
                    if (PerformerRole != null) yield return PerformerRole;
                    if (Performer != null) yield return Performer;
                    foreach (var elem in PerformerLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", DoNotPerformElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
                    if (Intent != null) yield return new ElementValue("intent", Intent);
                    foreach (var elem in LinkIdElement) { if (elem != null) yield return new ElementValue("linkId", elem); }
                    if (Status != null) yield return new ElementValue("status", Status);
                    if (Context != null) yield return new ElementValue("context", Context);
                    foreach (var elem in ContextLinkIdElement) { if (elem != null) yield return new ElementValue("contextLinkId", elem); }
                    if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                    foreach (var elem in Requester) { if (elem != null) yield return new ElementValue("requester", elem); }
                    foreach (var elem in RequesterLinkIdElement) { if (elem != null) yield return new ElementValue("requesterLinkId", elem); }
                    foreach (var elem in PerformerType) { if (elem != null) yield return new ElementValue("performerType", elem); }
                    if (PerformerRole != null) yield return new ElementValue("performerRole", PerformerRole);
                    if (Performer != null) yield return new ElementValue("performer", Performer);
                    foreach (var elem in PerformerLinkIdElement) { if (elem != null) yield return new ElementValue("performerLinkId", elem); }
                    foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                    foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                    foreach (var elem in ReasonElement) { if (elem != null) yield return new ElementValue("reason", elem); }
                    foreach (var elem in ReasonLinkIdElement) { if (elem != null) yield return new ElementValue("reasonLinkId", elem); }
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                    foreach (var elem in SecurityLabelNumberElement) { if (elem != null) yield return new ElementValue("securityLabelNumber", elem); }
                }
            }


        }


        [FhirType("ActionSubjectComponent")]
        [DataContract]
        public partial class ActionSubjectComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionSubjectComponent"; } }

            /// <summary>
            /// Entity of the action
            /// </summary>
            [FhirElement("reference", Order=40)]
            [References("Patient","Person","RelatedPerson","Practitioner","Device","Group","Organization")]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceReference> Reference
            {
                get { if (_reference==null) _reference = new List<ResourceReference>(); return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private List<ResourceReference> _reference;

            /// <summary>
            /// Role type of the agent
            /// </summary>
            [FhirElement("role", Order=50)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionSubjectComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reference != null) dest.Reference = new List<ResourceReference>(Reference.DeepCopy());
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionSubjectComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionSubjectComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionSubjectComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Reference) { if (elem != null) yield return elem; }
                    if (Role != null) yield return Role;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Reference) { if (elem != null) yield return new ElementValue("reference", elem); }
                    if (Role != null) yield return new ElementValue("role", Role);
                }
            }


        }


        [FhirType("SignatoryComponent")]
        [DataContract]
        public partial class SignatoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SignatoryComponent"; } }

            /// <summary>
            /// Contract Signatory Role
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Contract Signatory Party
            /// </summary>
            [FhirElement("party", Order=50)]
            [References("Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Party
            {
                get { return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private ResourceReference _party;

            /// <summary>
            /// Contract Documentation Signature
            /// </summary>
            [FhirElement("signature", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Signature> Signature
            {
                get { if (_signature==null) _signature = new List<Signature>(); return _signature; }
                set { _signature = value; OnPropertyChanged("Signature"); }
            }

            private List<Signature> _signature;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SignatoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Party != null) dest.Party = (ResourceReference)Party.DeepCopy();
                    if (Signature != null) dest.Signature = new List<Signature>(Signature.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SignatoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;
                if ( !DeepComparable.Matches(Signature, otherT.Signature)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;
                if (!DeepComparable.IsExactly(Signature, otherT.Signature)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Party != null) yield return Party;
                    foreach (var elem in Signature) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Party != null) yield return new ElementValue("party", Party);
                    foreach (var elem in Signature) { if (elem != null) yield return new ElementValue("signature", elem); }
                }
            }


        }


        [FhirType("FriendlyLanguageComponent")]
        [DataContract]
        public partial class FriendlyLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FriendlyLanguageComponent"; } }

            /// <summary>
            /// Easily comprehended representation of this Contract
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FriendlyLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FriendlyLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        [FhirType("LegalLanguageComponent")]
        [DataContract]
        public partial class LegalLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LegalLanguageComponent"; } }

            /// <summary>
            /// Contract Legal Text
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LegalLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LegalLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        [FhirType("ComputableLanguageComponent")]
        [DataContract]
        public partial class ComputableLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ComputableLanguageComponent"; } }

            /// <summary>
            /// Computable Contract Rules
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComputableLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ComputableLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        /// <summary>
        /// Contract number
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
        /// Basal definition
        /// </summary>
        [FhirElement("url", Order=100)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Basal definition
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
        /// Business edition
        /// </summary>
        [FhirElement("version", InSummary=true, Order=110)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business edition
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
        /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [DataMember]
        public Code<ContractResourceStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ContractResourceStatusCodes> _statusElement;

        /// <summary>
        /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ContractResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ContractResourceStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Negotiation status
        /// </summary>
        [FhirElement("legalState", Order=130)]
        [DataMember]
        public CodeableConcept LegalState
        {
            get { return _legalState; }
            set { _legalState = value; OnPropertyChanged("LegalState"); }
        }

        private CodeableConcept _legalState;

        /// <summary>
        /// Source Contract Definition
        /// </summary>
        [FhirElement("instantiatesCanonical", Order=140)]
        [References("Contract")]
        [DataMember]
        public ResourceReference InstantiatesCanonical
        {
            get { return _instantiatesCanonical; }
            set { _instantiatesCanonical = value; OnPropertyChanged("InstantiatesCanonical"); }
        }

        private ResourceReference _instantiatesCanonical;

        /// <summary>
        /// External Contract Definition
        /// </summary>
        [FhirElement("instantiatesUri", Order=150)]
        [DataMember]
        public FhirUri InstantiatesUriElement
        {
            get { return _instantiatesUriElement; }
            set { _instantiatesUriElement = value; OnPropertyChanged("InstantiatesUriElement"); }
        }

        private FhirUri _instantiatesUriElement;

        /// <summary>
        /// External Contract Definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string InstantiatesUri
        {
            get { return InstantiatesUriElement != null ? InstantiatesUriElement.Value : null; }
            set
            {
                if (value == null)
                    InstantiatesUriElement = null;
                else
                    InstantiatesUriElement = new FhirUri(value);
                OnPropertyChanged("InstantiatesUri");
            }
        }

        /// <summary>
        /// Content derived from the basal information
        /// </summary>
        [FhirElement("contentDerivative", Order=160)]
        [DataMember]
        public CodeableConcept ContentDerivative
        {
            get { return _contentDerivative; }
            set { _contentDerivative = value; OnPropertyChanged("ContentDerivative"); }
        }

        private CodeableConcept _contentDerivative;

        /// <summary>
        /// When this Contract was issued
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private FhirDateTime _issuedElement;

        /// <summary>
        /// When this Contract was issued
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new FhirDateTime(value);
                OnPropertyChanged("Issued");
            }
        }

        /// <summary>
        /// Effective time
        /// </summary>
        [FhirElement("applies", InSummary=true, Order=180)]
        [DataMember]
        public Period Applies
        {
            get { return _applies; }
            set { _applies = value; OnPropertyChanged("Applies"); }
        }

        private Period _applies;

        /// <summary>
        /// Contract cessation cause
        /// </summary>
        [FhirElement("expirationType", Order=190)]
        [DataMember]
        public CodeableConcept ExpirationType
        {
            get { return _expirationType; }
            set { _expirationType = value; OnPropertyChanged("ExpirationType"); }
        }

        private CodeableConcept _expirationType;

        /// <summary>
        /// Contract Target Entity
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Subject
        {
            get { if (_subject==null) _subject = new List<ResourceReference>(); return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private List<ResourceReference> _subject;

        /// <summary>
        /// Authority under which this Contract has standing
        /// </summary>
        [FhirElement("authority", Order=210)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Authority
        {
            get { if (_authority==null) _authority = new List<ResourceReference>(); return _authority; }
            set { _authority = value; OnPropertyChanged("Authority"); }
        }

        private List<ResourceReference> _authority;

        /// <summary>
        /// A sphere of control governed by an authoritative jurisdiction, organization, or person
        /// </summary>
        [FhirElement("domain", Order=220)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Domain
        {
            get { if (_domain==null) _domain = new List<ResourceReference>(); return _domain; }
            set { _domain = value; OnPropertyChanged("Domain"); }
        }

        private List<ResourceReference> _domain;

        /// <summary>
        /// Specific Location
        /// </summary>
        [FhirElement("site", Order=230)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Site
        {
            get { if (_site==null) _site = new List<ResourceReference>(); return _site; }
            set { _site = value; OnPropertyChanged("Site"); }
        }

        private List<ResourceReference> _site;

        /// <summary>
        /// Computer friendly designation
        /// </summary>
        [FhirElement("name", InSummary=true, Order=240)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Computer friendly designation
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
        /// Human Friendly name
        /// </summary>
        [FhirElement("title", InSummary=true, Order=250)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Human Friendly name
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Subordinate Friendly name
        /// </summary>
        [FhirElement("subtitle", Order=260)]
        [DataMember]
        public FhirString SubtitleElement
        {
            get { return _subtitleElement; }
            set { _subtitleElement = value; OnPropertyChanged("SubtitleElement"); }
        }

        private FhirString _subtitleElement;

        /// <summary>
        /// Subordinate Friendly name
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Subtitle
        {
            get { return SubtitleElement != null ? SubtitleElement.Value : null; }
            set
            {
                if (value == null)
                    SubtitleElement = null;
                else
                    SubtitleElement = new FhirString(value);
                OnPropertyChanged("Subtitle");
            }
        }

        /// <summary>
        /// Acronym or short name
        /// </summary>
        [FhirElement("alias", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> AliasElement
        {
            get { if (_aliasElement==null) _aliasElement = new List<FhirString>(); return _aliasElement; }
            set { _aliasElement = value; OnPropertyChanged("AliasElement"); }
        }

        private List<FhirString> _aliasElement;

        /// <summary>
        /// Acronym or short name
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Alias
        {
            get { return AliasElement != null ? AliasElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    AliasElement = null;
                else
                    AliasElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Alias");
            }
        }

        /// <summary>
        /// Source of Contract
        /// </summary>
        [FhirElement("author", Order=280)]
        [References("Person","Patient","Practitioner","Organization")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Range of Legal Concerns
        /// </summary>
        [FhirElement("scope", Order=290)]
        [DataMember]
        public CodeableConcept Scope
        {
            get { return _scope; }
            set { _scope = value; OnPropertyChanged("Scope"); }
        }

        private CodeableConcept _scope;

        /// <summary>
        /// Focus of contract interest
        /// </summary>
        [FhirElement("topic", Order=300, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Topic
        {
            get { return _topic; }
            set { _topic = value; OnPropertyChanged("Topic"); }
        }

        private Element _topic;

        /// <summary>
        /// Legal instrument category
        /// </summary>
        [FhirElement("type", InSummary=true, Order=310)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Subtype within the context of type
        /// </summary>
        [FhirElement("subType", InSummary=true, Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> SubType
        {
            get { if (_subType==null) _subType = new List<CodeableConcept>(); return _subType; }
            set { _subType = value; OnPropertyChanged("SubType"); }
        }

        private List<CodeableConcept> _subType;

        /// <summary>
        /// Contract precursor content
        /// </summary>
        [FhirElement("contentDefinition", Order=330)]
        [DataMember]
        public ContentDefinitionComponent ContentDefinition
        {
            get { return _contentDefinition; }
            set { _contentDefinition = value; OnPropertyChanged("ContentDefinition"); }
        }

        private ContentDefinitionComponent _contentDefinition;

        /// <summary>
        /// Contract Term List
        /// </summary>
        [FhirElement("term", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TermComponent> Term
        {
            get { if (_term==null) _term = new List<TermComponent>(); return _term; }
            set { _term = value; OnPropertyChanged("Term"); }
        }

        private List<TermComponent> _term;

        /// <summary>
        /// Extra Information
        /// </summary>
        [FhirElement("supportingInfo", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInfo
        {
            get { if (_supportingInfo==null) _supportingInfo = new List<ResourceReference>(); return _supportingInfo; }
            set { _supportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }

        private List<ResourceReference> _supportingInfo;

        /// <summary>
        /// Key event in Contract History
        /// </summary>
        [FhirElement("relevantHistory", Order=360)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> RelevantHistory
        {
            get { if (_relevantHistory==null) _relevantHistory = new List<ResourceReference>(); return _relevantHistory; }
            set { _relevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }

        private List<ResourceReference> _relevantHistory;

        /// <summary>
        /// Contract Signatory
        /// </summary>
        [FhirElement("signer", Order=370)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SignatoryComponent> Signer
        {
            get { if (_signer==null) _signer = new List<SignatoryComponent>(); return _signer; }
            set { _signer = value; OnPropertyChanged("Signer"); }
        }

        private List<SignatoryComponent> _signer;

        /// <summary>
        /// Contract Friendly Language
        /// </summary>
        [FhirElement("friendly", Order=380)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FriendlyLanguageComponent> Friendly
        {
            get { if (_friendly==null) _friendly = new List<FriendlyLanguageComponent>(); return _friendly; }
            set { _friendly = value; OnPropertyChanged("Friendly"); }
        }

        private List<FriendlyLanguageComponent> _friendly;

        /// <summary>
        /// Contract Legal Language
        /// </summary>
        [FhirElement("legal", Order=390)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LegalLanguageComponent> Legal
        {
            get { if (_legal==null) _legal = new List<LegalLanguageComponent>(); return _legal; }
            set { _legal = value; OnPropertyChanged("Legal"); }
        }

        private List<LegalLanguageComponent> _legal;

        /// <summary>
        /// Computable Contract Language
        /// </summary>
        [FhirElement("rule", Order=400)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ComputableLanguageComponent> Rule
        {
            get { if (_rule==null) _rule = new List<ComputableLanguageComponent>(); return _rule; }
            set { _rule = value; OnPropertyChanged("Rule"); }
        }

        private List<ComputableLanguageComponent> _rule;

        /// <summary>
        /// Binding Contract
        /// </summary>
        [FhirElement("legallyBinding", Order=410, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
        [DataMember]
        public Element LegallyBinding
        {
            get { return _legallyBinding; }
            set { _legallyBinding = value; OnPropertyChanged("LegallyBinding"); }
        }

        private Element _legallyBinding;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Contract;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ContractResourceStatusCodes>)StatusElement.DeepCopy();
                if (LegalState != null) dest.LegalState = (CodeableConcept)LegalState.DeepCopy();
                if (InstantiatesCanonical != null) dest.InstantiatesCanonical = (ResourceReference)InstantiatesCanonical.DeepCopy();
                if (InstantiatesUriElement != null) dest.InstantiatesUriElement = (FhirUri)InstantiatesUriElement.DeepCopy();
                if (ContentDerivative != null) dest.ContentDerivative = (CodeableConcept)ContentDerivative.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                if (Applies != null) dest.Applies = (Period)Applies.DeepCopy();
                if (ExpirationType != null) dest.ExpirationType = (CodeableConcept)ExpirationType.DeepCopy();
                if (Subject != null) dest.Subject = new List<ResourceReference>(Subject.DeepCopy());
                if (Authority != null) dest.Authority = new List<ResourceReference>(Authority.DeepCopy());
                if (Domain != null) dest.Domain = new List<ResourceReference>(Domain.DeepCopy());
                if (Site != null) dest.Site = new List<ResourceReference>(Site.DeepCopy());
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (SubtitleElement != null) dest.SubtitleElement = (FhirString)SubtitleElement.DeepCopy();
                if (AliasElement != null) dest.AliasElement = new List<FhirString>(AliasElement.DeepCopy());
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Scope != null) dest.Scope = (CodeableConcept)Scope.DeepCopy();
                if (Topic != null) dest.Topic = (Element)Topic.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (SubType != null) dest.SubType = new List<CodeableConcept>(SubType.DeepCopy());
                if (ContentDefinition != null) dest.ContentDefinition = (ContentDefinitionComponent)ContentDefinition.DeepCopy();
                if (Term != null) dest.Term = new List<TermComponent>(Term.DeepCopy());
                if (SupportingInfo != null) dest.SupportingInfo = new List<ResourceReference>(SupportingInfo.DeepCopy());
                if (RelevantHistory != null) dest.RelevantHistory = new List<ResourceReference>(RelevantHistory.DeepCopy());
                if (Signer != null) dest.Signer = new List<SignatoryComponent>(Signer.DeepCopy());
                if (Friendly != null) dest.Friendly = new List<FriendlyLanguageComponent>(Friendly.DeepCopy());
                if (Legal != null) dest.Legal = new List<LegalLanguageComponent>(Legal.DeepCopy());
                if (Rule != null) dest.Rule = new List<ComputableLanguageComponent>(Rule.DeepCopy());
                if (LegallyBinding != null) dest.LegallyBinding = (Element)LegallyBinding.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Contract());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Contract;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(LegalState, otherT.LegalState)) return false;
            if (!DeepComparable.Matches(InstantiatesCanonical, otherT.InstantiatesCanonical)) return false;
            if (!DeepComparable.Matches(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if (!DeepComparable.Matches(ContentDerivative, otherT.ContentDerivative)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.Matches(Applies, otherT.Applies)) return false;
            if (!DeepComparable.Matches(ExpirationType, otherT.ExpirationType)) return false;
            if ( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if ( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
            if ( !DeepComparable.Matches(Site, otherT.Site)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(SubtitleElement, otherT.SubtitleElement)) return false;
            if ( !DeepComparable.Matches(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Scope, otherT.Scope)) return false;
            if (!DeepComparable.Matches(Topic, otherT.Topic)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
            if (!DeepComparable.Matches(ContentDefinition, otherT.ContentDefinition)) return false;
            if ( !DeepComparable.Matches(Term, otherT.Term)) return false;
            if ( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if ( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;
            if ( !DeepComparable.Matches(Signer, otherT.Signer)) return false;
            if ( !DeepComparable.Matches(Friendly, otherT.Friendly)) return false;
            if ( !DeepComparable.Matches(Legal, otherT.Legal)) return false;
            if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
            if (!DeepComparable.Matches(LegallyBinding, otherT.LegallyBinding)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Contract;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(LegalState, otherT.LegalState)) return false;
            if (!DeepComparable.IsExactly(InstantiatesCanonical, otherT.InstantiatesCanonical)) return false;
            if (!DeepComparable.IsExactly(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if (!DeepComparable.IsExactly(ContentDerivative, otherT.ContentDerivative)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
            if (!DeepComparable.IsExactly(ExpirationType, otherT.ExpirationType)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if (!DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
            if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.IsExactly(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Scope, otherT.Scope)) return false;
            if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
            if (!DeepComparable.IsExactly(ContentDefinition, otherT.ContentDefinition)) return false;
            if (!DeepComparable.IsExactly(Term, otherT.Term)) return false;
            if (!DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if (!DeepComparable.IsExactly(RelevantHistory, otherT.RelevantHistory)) return false;
            if (!DeepComparable.IsExactly(Signer, otherT.Signer)) return false;
            if (!DeepComparable.IsExactly(Friendly, otherT.Friendly)) return false;
            if (!DeepComparable.IsExactly(Legal, otherT.Legal)) return false;
            if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
            if (!DeepComparable.IsExactly(LegallyBinding, otherT.LegallyBinding)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (StatusElement != null) yield return StatusElement;
                if (LegalState != null) yield return LegalState;
                if (InstantiatesCanonical != null) yield return InstantiatesCanonical;
                if (InstantiatesUriElement != null) yield return InstantiatesUriElement;
                if (ContentDerivative != null) yield return ContentDerivative;
                if (IssuedElement != null) yield return IssuedElement;
                if (Applies != null) yield return Applies;
                if (ExpirationType != null) yield return ExpirationType;
                foreach (var elem in Subject) { if (elem != null) yield return elem; }
                foreach (var elem in Authority) { if (elem != null) yield return elem; }
                foreach (var elem in Domain) { if (elem != null) yield return elem; }
                foreach (var elem in Site) { if (elem != null) yield return elem; }
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (SubtitleElement != null) yield return SubtitleElement;
                foreach (var elem in AliasElement) { if (elem != null) yield return elem; }
                if (Author != null) yield return Author;
                if (Scope != null) yield return Scope;
                if (Topic != null) yield return Topic;
                if (Type != null) yield return Type;
                foreach (var elem in SubType) { if (elem != null) yield return elem; }
                if (ContentDefinition != null) yield return ContentDefinition;
                foreach (var elem in Term) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return elem; }
                foreach (var elem in Signer) { if (elem != null) yield return elem; }
                foreach (var elem in Friendly) { if (elem != null) yield return elem; }
                foreach (var elem in Legal) { if (elem != null) yield return elem; }
                foreach (var elem in Rule) { if (elem != null) yield return elem; }
                if (LegallyBinding != null) yield return LegallyBinding;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (LegalState != null) yield return new ElementValue("legalState", LegalState);
                if (InstantiatesCanonical != null) yield return new ElementValue("instantiatesCanonical", InstantiatesCanonical);
                if (InstantiatesUriElement != null) yield return new ElementValue("instantiatesUri", InstantiatesUriElement);
                if (ContentDerivative != null) yield return new ElementValue("contentDerivative", ContentDerivative);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                if (Applies != null) yield return new ElementValue("applies", Applies);
                if (ExpirationType != null) yield return new ElementValue("expirationType", ExpirationType);
                foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
                foreach (var elem in Authority) { if (elem != null) yield return new ElementValue("authority", elem); }
                foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", elem); }
                foreach (var elem in Site) { if (elem != null) yield return new ElementValue("site", elem); }
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (SubtitleElement != null) yield return new ElementValue("subtitle", SubtitleElement);
                foreach (var elem in AliasElement) { if (elem != null) yield return new ElementValue("alias", elem); }
                if (Author != null) yield return new ElementValue("author", Author);
                if (Scope != null) yield return new ElementValue("scope", Scope);
                if (Topic != null) yield return new ElementValue("topic", Topic);
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in SubType) { if (elem != null) yield return new ElementValue("subType", elem); }
                if (ContentDefinition != null) yield return new ElementValue("contentDefinition", ContentDefinition);
                foreach (var elem in Term) { if (elem != null) yield return new ElementValue("term", elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", elem); }
                foreach (var elem in Signer) { if (elem != null) yield return new ElementValue("signer", elem); }
                foreach (var elem in Friendly) { if (elem != null) yield return new ElementValue("friendly", elem); }
                foreach (var elem in Legal) { if (elem != null) yield return new ElementValue("legal", elem); }
                foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
                if (LegallyBinding != null) yield return new ElementValue("legallyBinding", LegallyBinding);
            }
        }

    }

}
