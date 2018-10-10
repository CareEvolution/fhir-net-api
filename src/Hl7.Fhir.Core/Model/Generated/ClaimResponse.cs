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
    /// Remittance resource
    /// </summary>
    [FhirType("ClaimResponse", IsResource=true)]
    [DataContract]
    public partial class ClaimResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ClaimResponse; } }
        [NotMapped]
        public override string TypeName { get { return "ClaimResponse"; } }


        [FhirType("ItemsComponent")]
        [DataContract]
        public partial class ItemsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemsComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequenceLinkId", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceLinkIdElement
            {
                get { return _sequenceLinkIdElement; }
                set { _sequenceLinkIdElement = value; OnPropertyChanged("SequenceLinkIdElement"); }
            }

            private PositiveInt _sequenceLinkIdElement;

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
                    if (!value.HasValue)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement == null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
                set { _noteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }

            private List<PositiveInt> _noteNumberElement;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("NoteNumber");
                }
            }

            /// <summary>
            /// Adjudication details
            /// </summary>
            [FhirElement("adjudication", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ItemAdjudicationComponent> Adjudication
            {
                get { if (_adjudication == null) _adjudication = new List<ItemAdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<ItemAdjudicationComponent> _adjudication;

            /// <summary>
            /// Detail line items
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ItemDetailComponent> Detail
            {
                get { if (_detail == null) _detail = new List<ItemDetailComponent>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<ItemDetailComponent> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<ItemAdjudicationComponent>(Adjudication.DeepCopy());
                    if (Detail != null) dest.Detail = new List<ItemDetailComponent>(Detail.DeepCopy());
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
                if (!DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceLinkIdElement != null) yield return SequenceLinkIdElement;
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceLinkIdElement != null) yield return new ElementValue("sequenceLinkId", SequenceLinkIdElement);
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                }
            }


        }


        [FhirType("ItemAdjudicationComponent")]
        [DataContract]
        public partial class ItemAdjudicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemAdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=60)]
            [DataMember]
            public FhirDecimal ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDecimal _valueElement;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemAdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemAdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Amount != null) yield return Amount;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("ItemDetailComponent")]
        [DataContract]
        public partial class ItemDetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemDetailComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequenceLinkId", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceLinkIdElement
            {
                get { return _sequenceLinkIdElement; }
                set { _sequenceLinkIdElement = value; OnPropertyChanged("SequenceLinkIdElement"); }
            }

            private PositiveInt _sequenceLinkIdElement;

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
                    if (!value.HasValue)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// Detail adjudication
            /// </summary>
            [FhirElement("adjudication", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DetailAdjudicationComponent> Adjudication
            {
                get { if (_adjudication == null) _adjudication = new List<DetailAdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<DetailAdjudicationComponent> _adjudication;

            /// <summary>
            /// Subdetail line items
            /// </summary>
            [FhirElement("subDetail", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubDetailComponent> SubDetail
            {
                get { if (_subDetail == null) _subDetail = new List<SubDetailComponent>(); return _subDetail; }
                set { _subDetail = value; OnPropertyChanged("SubDetail"); }
            }

            private List<SubDetailComponent> _subDetail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (Adjudication != null) dest.Adjudication = new List<DetailAdjudicationComponent>(Adjudication.DeepCopy());
                    if (SubDetail != null) dest.SubDetail = new List<SubDetailComponent>(SubDetail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemDetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemDetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.Matches(SubDetail, otherT.SubDetail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.IsExactly(SubDetail, otherT.SubDetail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceLinkIdElement != null) yield return SequenceLinkIdElement;
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                    foreach (var elem in SubDetail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceLinkIdElement != null) yield return new ElementValue("sequenceLinkId", SequenceLinkIdElement);
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                    foreach (var elem in SubDetail) { if (elem != null) yield return new ElementValue("subDetail", elem); }
                }
            }


        }


        [FhirType("DetailAdjudicationComponent")]
        [DataContract]
        public partial class DetailAdjudicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailAdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=60)]
            [DataMember]
            public FhirDecimal ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDecimal _valueElement;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailAdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DetailAdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DetailAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Amount != null) yield return Amount;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("SubDetailComponent")]
        [DataContract]
        public partial class SubDetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubDetailComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequenceLinkId", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceLinkIdElement
            {
                get { return _sequenceLinkIdElement; }
                set { _sequenceLinkIdElement = value; OnPropertyChanged("SequenceLinkIdElement"); }
            }

            private PositiveInt _sequenceLinkIdElement;

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
                    if (!value.HasValue)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// Subdetail adjudication
            /// </summary>
            [FhirElement("adjudication", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubdetailAdjudicationComponent> Adjudication
            {
                get { if (_adjudication == null) _adjudication = new List<SubdetailAdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<SubdetailAdjudicationComponent> _adjudication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (Adjudication != null) dest.Adjudication = new List<SubdetailAdjudicationComponent>(Adjudication.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubDetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceLinkIdElement != null) yield return SequenceLinkIdElement;
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceLinkIdElement != null) yield return new ElementValue("sequenceLinkId", SequenceLinkIdElement);
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                }
            }


        }


        [FhirType("SubdetailAdjudicationComponent")]
        [DataContract]
        public partial class SubdetailAdjudicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubdetailAdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=60)]
            [DataMember]
            public FhirDecimal ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDecimal _valueElement;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubdetailAdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubdetailAdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubdetailAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubdetailAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Amount != null) yield return Amount;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("AddedItemComponent")]
        [DataContract]
        public partial class AddedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AddedItemComponent"; } }

            /// <summary>
            /// Service instances
            /// </summary>
            [FhirElement("sequenceLinkId", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> SequenceLinkIdElement
            {
                get { if (_sequenceLinkIdElement == null) _sequenceLinkIdElement = new List<PositiveInt>(); return _sequenceLinkIdElement; }
                set { _sequenceLinkIdElement = value; OnPropertyChanged("SequenceLinkIdElement"); }
            }

            private List<PositiveInt> _sequenceLinkIdElement;

            /// <summary>
            /// Service instances
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SequenceLinkId
            {
                get { return SequenceLinkIdElement != null ? SequenceLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// Group, Service or Product
            /// </summary>
            [FhirElement("service", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private Coding _service;

            /// <summary>
            /// Professional fee or Product charge
            /// </summary>
            [FhirElement("fee", InSummary=true, Order=60)]
            [DataMember]
            public Money Fee
            {
                get { return _fee; }
                set { _fee = value; OnPropertyChanged("Fee"); }
            }

            private Money _fee;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumberLinkId", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberLinkIdElement
            {
                get { if (_noteNumberLinkIdElement == null) _noteNumberLinkIdElement = new List<PositiveInt>(); return _noteNumberLinkIdElement; }
                set { _noteNumberLinkIdElement = value; OnPropertyChanged("NoteNumberLinkIdElement"); }
            }

            private List<PositiveInt> _noteNumberLinkIdElement;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NoteNumberLinkId
            {
                get { return NoteNumberLinkIdElement != null ? NoteNumberLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberLinkIdElement = null;
                    else
                        NoteNumberLinkIdElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("NoteNumberLinkId");
                }
            }

            /// <summary>
            /// Added items adjudication
            /// </summary>
            [FhirElement("adjudication", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AddedItemAdjudicationComponent> Adjudication
            {
                get { if (_adjudication == null) _adjudication = new List<AddedItemAdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AddedItemAdjudicationComponent> _adjudication;

            /// <summary>
            /// Added items details
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AddedItemsDetailComponent> Detail
            {
                get { if (_detail == null) _detail = new List<AddedItemsDetailComponent>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<AddedItemsDetailComponent> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = new List<PositiveInt>(SequenceLinkIdElement.DeepCopy());
                    if (Service != null) dest.Service = (Coding)Service.DeepCopy();
                    if (Fee != null) dest.Fee = (Money)Fee.DeepCopy();
                    if (NoteNumberLinkIdElement != null) dest.NoteNumberLinkIdElement = new List<PositiveInt>(NoteNumberLinkIdElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AddedItemAdjudicationComponent>(Adjudication.DeepCopy());
                    if (Detail != null) dest.Detail = new List<AddedItemsDetailComponent>(Detail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AddedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AddedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if (!DeepComparable.Matches(Fee, otherT.Fee)) return false;
                if (!DeepComparable.Matches(NoteNumberLinkIdElement, otherT.NoteNumberLinkIdElement)) return false;
                if (!DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Fee, otherT.Fee)) return false;
                if (!DeepComparable.IsExactly(NoteNumberLinkIdElement, otherT.NoteNumberLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in SequenceLinkIdElement) { if (elem != null) yield return elem; }
                    if (Service != null) yield return Service;
                    if (Fee != null) yield return Fee;
                    foreach (var elem in NoteNumberLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in SequenceLinkIdElement) { if (elem != null) yield return new ElementValue("sequenceLinkId", elem); }
                    if (Service != null) yield return new ElementValue("service", Service);
                    if (Fee != null) yield return new ElementValue("fee", Fee);
                    foreach (var elem in NoteNumberLinkIdElement) { if (elem != null) yield return new ElementValue("noteNumberLinkId", elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                }
            }


        }


        [FhirType("AddedItemAdjudicationComponent")]
        [DataContract]
        public partial class AddedItemAdjudicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AddedItemAdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=60)]
            [DataMember]
            public FhirDecimal ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDecimal _valueElement;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemAdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AddedItemAdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AddedItemAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Amount != null) yield return Amount;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("AddedItemsDetailComponent")]
        [DataContract]
        public partial class AddedItemsDetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AddedItemsDetailComponent"; } }

            /// <summary>
            /// Service or Product
            /// </summary>
            [FhirElement("service", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private Coding _service;

            /// <summary>
            /// Professional fee or Product charge
            /// </summary>
            [FhirElement("fee", InSummary=true, Order=50)]
            [DataMember]
            public Money Fee
            {
                get { return _fee; }
                set { _fee = value; OnPropertyChanged("Fee"); }
            }

            private Money _fee;

            /// <summary>
            /// Added items detail adjudication
            /// </summary>
            [FhirElement("adjudication", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AddedItemDetailAdjudicationComponent> Adjudication
            {
                get { if (_adjudication == null) _adjudication = new List<AddedItemDetailAdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AddedItemDetailAdjudicationComponent> _adjudication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemsDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Service != null) dest.Service = (Coding)Service.DeepCopy();
                    if (Fee != null) dest.Fee = (Money)Fee.DeepCopy();
                    if (Adjudication != null) dest.Adjudication = new List<AddedItemDetailAdjudicationComponent>(Adjudication.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AddedItemsDetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AddedItemsDetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if (!DeepComparable.Matches(Fee, otherT.Fee)) return false;
                if (!DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemsDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Fee, otherT.Fee)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Service != null) yield return Service;
                    if (Fee != null) yield return Fee;
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Service != null) yield return new ElementValue("service", Service);
                    if (Fee != null) yield return new ElementValue("fee", Fee);
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                }
            }


        }


        [FhirType("AddedItemDetailAdjudicationComponent")]
        [DataContract]
        public partial class AddedItemDetailAdjudicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AddedItemDetailAdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=60)]
            [DataMember]
            public FhirDecimal ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDecimal _valueElement;

            /// <summary>
            /// Non-monetary value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemDetailAdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AddedItemDetailAdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AddedItemDetailAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemDetailAdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Amount != null) yield return Amount;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("ErrorsComponent")]
        [DataContract]
        public partial class ErrorsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ErrorsComponent"; } }

            /// <summary>
            /// Item sequence number
            /// </summary>
            [FhirElement("sequenceLinkId", InSummary=true, Order=40)]
            [DataMember]
            public PositiveInt SequenceLinkIdElement
            {
                get { return _sequenceLinkIdElement; }
                set { _sequenceLinkIdElement = value; OnPropertyChanged("SequenceLinkIdElement"); }
            }

            private PositiveInt _sequenceLinkIdElement;

            /// <summary>
            /// Item sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? SequenceLinkId
            {
                get { return SequenceLinkIdElement != null ? SequenceLinkIdElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// Detail sequence number
            /// </summary>
            [FhirElement("detailSequenceLinkId", InSummary=true, Order=50)]
            [DataMember]
            public PositiveInt DetailSequenceLinkIdElement
            {
                get { return _detailSequenceLinkIdElement; }
                set { _detailSequenceLinkIdElement = value; OnPropertyChanged("DetailSequenceLinkIdElement"); }
            }

            private PositiveInt _detailSequenceLinkIdElement;

            /// <summary>
            /// Detail sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? DetailSequenceLinkId
            {
                get { return DetailSequenceLinkIdElement != null ? DetailSequenceLinkIdElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DetailSequenceLinkIdElement = null;
                    else
                        DetailSequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("DetailSequenceLinkId");
                }
            }

            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            [FhirElement("subdetailSequenceLinkId", InSummary=true, Order=60)]
            [DataMember]
            public PositiveInt SubdetailSequenceLinkIdElement
            {
                get { return _subdetailSequenceLinkIdElement; }
                set { _subdetailSequenceLinkIdElement = value; OnPropertyChanged("SubdetailSequenceLinkIdElement"); }
            }

            private PositiveInt _subdetailSequenceLinkIdElement;

            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? SubdetailSequenceLinkId
            {
                get { return SubdetailSequenceLinkIdElement != null ? SubdetailSequenceLinkIdElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SubdetailSequenceLinkIdElement = null;
                    else
                        SubdetailSequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SubdetailSequenceLinkId");
                }
            }

            /// <summary>
            /// Error code detailing processing issues
            /// </summary>
            [FhirElement("code", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ErrorsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (DetailSequenceLinkIdElement != null) dest.DetailSequenceLinkIdElement = (PositiveInt)DetailSequenceLinkIdElement.DeepCopy();
                    if (SubdetailSequenceLinkIdElement != null) dest.SubdetailSequenceLinkIdElement = (PositiveInt)SubdetailSequenceLinkIdElement.DeepCopy();
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ErrorsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ErrorsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(DetailSequenceLinkIdElement, otherT.DetailSequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(SubdetailSequenceLinkIdElement, otherT.SubdetailSequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ErrorsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(DetailSequenceLinkIdElement, otherT.DetailSequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(SubdetailSequenceLinkIdElement, otherT.SubdetailSequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceLinkIdElement != null) yield return SequenceLinkIdElement;
                    if (DetailSequenceLinkIdElement != null) yield return DetailSequenceLinkIdElement;
                    if (SubdetailSequenceLinkIdElement != null) yield return SubdetailSequenceLinkIdElement;
                    if (Code != null) yield return Code;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceLinkIdElement != null) yield return new ElementValue("sequenceLinkId", SequenceLinkIdElement);
                    if (DetailSequenceLinkIdElement != null) yield return new ElementValue("detailSequenceLinkId", DetailSequenceLinkIdElement);
                    if (SubdetailSequenceLinkIdElement != null) yield return new ElementValue("subdetailSequenceLinkId", SubdetailSequenceLinkIdElement);
                    if (Code != null) yield return new ElementValue("code", Code);
                }
            }


        }


        [FhirType("NotesComponent")]
        [DataContract]
        public partial class NotesComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NotesComponent"; } }

            /// <summary>
            /// Note Number for this note
            /// </summary>
            [FhirElement("number", InSummary=true, Order=40)]
            [DataMember]
            public PositiveInt NumberElement
            {
                get { return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private PositiveInt _numberElement;

            /// <summary>
            /// Note Number for this note
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        NumberElement = null;
                    else
                        NumberElement = new PositiveInt(value);
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Note explanatory text
            /// </summary>
            [FhirElement("text", InSummary=true, Order=60)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Note explanatory text
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
                var dest = other as NotesComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NumberElement != null) dest.NumberElement = (PositiveInt)NumberElement.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NotesComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NotesComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NotesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NumberElement != null) yield return NumberElement;
                    if (Type != null) yield return Type;
                    if (TextElement != null) yield return TextElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NumberElement != null) yield return new ElementValue("number", NumberElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                }
            }


        }


        [FhirType("CoverageComponent")]
        [DataContract]
        public partial class CoverageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CoverageComponent"; } }

            /// <summary>
            /// Service instance identifier
            /// </summary>
            [FhirElement("sequence", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Service instance identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            [FhirElement("focal", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean FocalElement
            {
                get { return _focalElement; }
                set { _focalElement = value; OnPropertyChanged("FocalElement"); }
            }

            private FhirBoolean _focalElement;

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Focal
            {
                get { return FocalElement != null ? FocalElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        FocalElement = null;
                    else
                        FocalElement = new FhirBoolean(value);
                    OnPropertyChanged("Focal");
                }
            }

            /// <summary>
            /// Insurance information
            /// </summary>
            [FhirElement("coverage", InSummary=true, Order=60)]
            [References("Coverage")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Coverage
            {
                get { return _coverage; }
                set { _coverage = value; OnPropertyChanged("Coverage"); }
            }

            private ResourceReference _coverage;

            /// <summary>
            /// Business agreement
            /// </summary>
            [FhirElement("businessArrangement", InSummary=true, Order=70)]
            [DataMember]
            public FhirString BusinessArrangementElement
            {
                get { return _businessArrangementElement; }
                set { _businessArrangementElement = value; OnPropertyChanged("BusinessArrangementElement"); }
            }

            private FhirString _businessArrangementElement;

            /// <summary>
            /// Business agreement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string BusinessArrangement
            {
                get { return BusinessArrangementElement != null ? BusinessArrangementElement.Value : null; }
                set
                {
                    if (value == null)
                        BusinessArrangementElement = null;
                    else
                        BusinessArrangementElement = new FhirString(value);
                    OnPropertyChanged("BusinessArrangement");
                }
            }

            /// <summary>
            /// Patient relationship to subscriber
            /// </summary>
            [FhirElement("relationship", InSummary=true, Order=80)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Relationship
            {
                get { return _relationship; }
                set { _relationship = value; OnPropertyChanged("Relationship"); }
            }

            private Coding _relationship;

            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            [FhirElement("preAuthRef", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> PreAuthRefElement
            {
                get { if (_preAuthRefElement == null) _preAuthRefElement = new List<FhirString>(); return _preAuthRefElement; }
                set { _preAuthRefElement = value; OnPropertyChanged("PreAuthRefElement"); }
            }

            private List<FhirString> _preAuthRefElement;

            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> PreAuthRef
            {
                get { return PreAuthRefElement != null ? PreAuthRefElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PreAuthRefElement = null;
                    else
                        PreAuthRefElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("PreAuthRef");
                }
            }

            /// <summary>
            /// Adjudication results
            /// </summary>
            [FhirElement("claimResponse", InSummary=true, Order=100)]
            [References("ClaimResponse")]
            [DataMember]
            public ResourceReference ClaimResponse
            {
                get { return _claimResponse; }
                set { _claimResponse = value; OnPropertyChanged("ClaimResponse"); }
            }

            private ResourceReference _claimResponse;

            /// <summary>
            /// Original version
            /// </summary>
            [FhirElement("originalRuleset", InSummary=true, Order=110)]
            [DataMember]
            public Coding OriginalRuleset
            {
                get { return _originalRuleset; }
                set { _originalRuleset = value; OnPropertyChanged("OriginalRuleset"); }
            }

            private Coding _originalRuleset;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoverageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (FocalElement != null) dest.FocalElement = (FhirBoolean)FocalElement.DeepCopy();
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (BusinessArrangementElement != null) dest.BusinessArrangementElement = (FhirString)BusinessArrangementElement.DeepCopy();
                    if (Relationship != null) dest.Relationship = (Coding)Relationship.DeepCopy();
                    if (PreAuthRefElement != null) dest.PreAuthRefElement = new List<FhirString>(PreAuthRefElement.DeepCopy());
                    if (ClaimResponse != null) dest.ClaimResponse = (ResourceReference)ClaimResponse.DeepCopy();
                    if (OriginalRuleset != null) dest.OriginalRuleset = (Coding)OriginalRuleset.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CoverageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.Matches(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.Matches(ClaimResponse, otherT.ClaimResponse)) return false;
                if (!DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.IsExactly(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.IsExactly(ClaimResponse, otherT.ClaimResponse)) return false;
                if (!DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (FocalElement != null) yield return FocalElement;
                    if (Coverage != null) yield return Coverage;
                    if (BusinessArrangementElement != null) yield return BusinessArrangementElement;
                    if (Relationship != null) yield return Relationship;
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return elem; }
                    if (ClaimResponse != null) yield return ClaimResponse;
                    if (OriginalRuleset != null) yield return OriginalRuleset;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (FocalElement != null) yield return new ElementValue("focal", FocalElement);
                    if (Coverage != null) yield return new ElementValue("coverage", Coverage);
                    if (BusinessArrangementElement != null) yield return new ElementValue("businessArrangement", BusinessArrangementElement);
                    if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return new ElementValue("preAuthRef", elem); }
                    if (ClaimResponse != null) yield return new ElementValue("claimResponse", ClaimResponse);
                    if (OriginalRuleset != null) yield return new ElementValue("originalRuleset", OriginalRuleset);
                }
            }


        }


        /// <summary>
        /// Response  number
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Id of resource triggering adjudication
        /// </summary>
        [FhirElement("request", InSummary=true, Order=100)]
        [References("Claim")]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// Resource version
        /// </summary>
        [FhirElement("ruleset", InSummary=true, Order=110)]
        [DataMember]
        public Coding Ruleset
        {
            get { return _ruleset; }
            set { _ruleset = value; OnPropertyChanged("Ruleset"); }
        }

        private Coding _ruleset;

        /// <summary>
        /// Original version
        /// </summary>
        [FhirElement("originalRuleset", InSummary=true, Order=120)]
        [DataMember]
        public Coding OriginalRuleset
        {
            get { return _originalRuleset; }
            set { _originalRuleset = value; OnPropertyChanged("OriginalRuleset"); }
        }

        private Coding _originalRuleset;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", InSummary=true, Order=130)]
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
        /// Insurer
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=140)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("requestProvider", InSummary=true, Order=150)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference RequestProvider
        {
            get { return _requestProvider; }
            set { _requestProvider = value; OnPropertyChanged("RequestProvider"); }
        }

        private ResourceReference _requestProvider;

        /// <summary>
        /// Responsible organization
        /// </summary>
        [FhirElement("requestOrganization", InSummary=true, Order=160)]
        [References("Organization")]
        [DataMember]
        public ResourceReference RequestOrganization
        {
            get { return _requestOrganization; }
            set { _requestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }

        private ResourceReference _requestOrganization;

        /// <summary>
        /// complete | error
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=170)]
        [DataMember]
        public Code<RemittanceOutcome> OutcomeElement
        {
            get { return _outcomeElement; }
            set { _outcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }

        private Code<RemittanceOutcome> _outcomeElement;

        /// <summary>
        /// complete | error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RemittanceOutcome? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Code<RemittanceOutcome>(value);
                OnPropertyChanged("Outcome");
            }
        }

        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", InSummary=true, Order=180)]
        [DataMember]
        public FhirString DispositionElement
        {
            get { return _dispositionElement; }
            set { _dispositionElement = value; OnPropertyChanged("DispositionElement"); }
        }

        private FhirString _dispositionElement;

        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Disposition
        {
            get { return DispositionElement != null ? DispositionElement.Value : null; }
            set
            {
                if (value == null)
                    DispositionElement = null;
                else
                    DispositionElement = new FhirString(value);
                OnPropertyChanged("Disposition");
            }
        }

        /// <summary>
        /// Party to be paid any benefits payable
        /// </summary>
        [FhirElement("payeeType", InSummary=true, Order=190)]
        [DataMember]
        public Coding PayeeType
        {
            get { return _payeeType; }
            set { _payeeType = value; OnPropertyChanged("PayeeType"); }
        }

        private Coding _payeeType;

        /// <summary>
        /// Line items
        /// </summary>
        [FhirElement("item", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemsComponent> Item
        {
            get { if (_item == null) _item = new List<ItemsComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemsComponent> _item;

        /// <summary>
        /// Insurer added line items
        /// </summary>
        [FhirElement("addItem", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AddedItemComponent> AddItem
        {
            get { if (_addItem == null) _addItem = new List<AddedItemComponent>(); return _addItem; }
            set { _addItem = value; OnPropertyChanged("AddItem"); }
        }

        private List<AddedItemComponent> _addItem;

        /// <summary>
        /// Processing errors
        /// </summary>
        [FhirElement("error", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ErrorsComponent> Error
        {
            get { if (_error == null) _error = new List<ErrorsComponent>(); return _error; }
            set { _error = value; OnPropertyChanged("Error"); }
        }

        private List<ErrorsComponent> _error;

        /// <summary>
        /// Total Cost of service from the Claim
        /// </summary>
        [FhirElement("totalCost", InSummary=true, Order=230)]
        [DataMember]
        public Money TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; OnPropertyChanged("TotalCost"); }
        }

        private Money _totalCost;

        /// <summary>
        /// Unallocated deductible
        /// </summary>
        [FhirElement("unallocDeductable", InSummary=true, Order=240)]
        [DataMember]
        public Money UnallocDeductable
        {
            get { return _unallocDeductable; }
            set { _unallocDeductable = value; OnPropertyChanged("UnallocDeductable"); }
        }

        private Money _unallocDeductable;

        /// <summary>
        /// Total benefit payable for the Claim
        /// </summary>
        [FhirElement("totalBenefit", InSummary=true, Order=250)]
        [DataMember]
        public Money TotalBenefit
        {
            get { return _totalBenefit; }
            set { _totalBenefit = value; OnPropertyChanged("TotalBenefit"); }
        }

        private Money _totalBenefit;

        /// <summary>
        /// Payment adjustment for non-Claim issues
        /// </summary>
        [FhirElement("paymentAdjustment", InSummary=true, Order=260)]
        [DataMember]
        public Money PaymentAdjustment
        {
            get { return _paymentAdjustment; }
            set { _paymentAdjustment = value; OnPropertyChanged("PaymentAdjustment"); }
        }

        private Money _paymentAdjustment;

        /// <summary>
        /// Reason for Payment adjustment
        /// </summary>
        [FhirElement("paymentAdjustmentReason", InSummary=true, Order=270)]
        [DataMember]
        public Coding PaymentAdjustmentReason
        {
            get { return _paymentAdjustmentReason; }
            set { _paymentAdjustmentReason = value; OnPropertyChanged("PaymentAdjustmentReason"); }
        }

        private Coding _paymentAdjustmentReason;

        /// <summary>
        /// Expected data of Payment
        /// </summary>
        [FhirElement("paymentDate", InSummary=true, Order=280)]
        [DataMember]
        public Date PaymentDateElement
        {
            get { return _paymentDateElement; }
            set { _paymentDateElement = value; OnPropertyChanged("PaymentDateElement"); }
        }

        private Date _paymentDateElement;

        /// <summary>
        /// Expected data of Payment
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
                    PaymentDateElement = new Date(value);
                OnPropertyChanged("PaymentDate");
            }
        }

        /// <summary>
        /// Payment amount
        /// </summary>
        [FhirElement("paymentAmount", InSummary=true, Order=290)]
        [DataMember]
        public Money PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; OnPropertyChanged("PaymentAmount"); }
        }

        private Money _paymentAmount;

        /// <summary>
        /// Payment identifier
        /// </summary>
        [FhirElement("paymentRef", InSummary=true, Order=300)]
        [DataMember]
        public Identifier PaymentRef
        {
            get { return _paymentRef; }
            set { _paymentRef = value; OnPropertyChanged("PaymentRef"); }
        }

        private Identifier _paymentRef;

        /// <summary>
        /// Funds reserved status
        /// </summary>
        [FhirElement("reserved", InSummary=true, Order=310)]
        [DataMember]
        public Coding Reserved
        {
            get { return _reserved; }
            set { _reserved = value; OnPropertyChanged("Reserved"); }
        }

        private Coding _reserved;

        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", InSummary=true, Order=320)]
        [DataMember]
        public Coding Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private Coding _form;

        /// <summary>
        /// Processing notes
        /// </summary>
        [FhirElement("note", InSummary=true, Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NotesComponent> Note
        {
            get { if (_note == null) _note = new List<NotesComponent>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<NotesComponent> _note;

        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("coverage", InSummary=true, Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CoverageComponent> Coverage
        {
            get { if (_coverage == null) _coverage = new List<CoverageComponent>(); return _coverage; }
            set { _coverage = value; OnPropertyChanged("Coverage"); }
        }

        private List<CoverageComponent> _coverage;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ClaimResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Ruleset != null) dest.Ruleset = (Coding)Ruleset.DeepCopy();
                if (OriginalRuleset != null) dest.OriginalRuleset = (Coding)OriginalRuleset.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (RequestProvider != null) dest.RequestProvider = (ResourceReference)RequestProvider.DeepCopy();
                if (RequestOrganization != null) dest.RequestOrganization = (ResourceReference)RequestOrganization.DeepCopy();
                if (OutcomeElement != null) dest.OutcomeElement = (Code<RemittanceOutcome>)OutcomeElement.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (PayeeType != null) dest.PayeeType = (Coding)PayeeType.DeepCopy();
                if (Item != null) dest.Item = new List<ItemsComponent>(Item.DeepCopy());
                if (AddItem != null) dest.AddItem = new List<AddedItemComponent>(AddItem.DeepCopy());
                if (Error != null) dest.Error = new List<ErrorsComponent>(Error.DeepCopy());
                if (TotalCost != null) dest.TotalCost = (Money)TotalCost.DeepCopy();
                if (UnallocDeductable != null) dest.UnallocDeductable = (Money)UnallocDeductable.DeepCopy();
                if (TotalBenefit != null) dest.TotalBenefit = (Money)TotalBenefit.DeepCopy();
                if (PaymentAdjustment != null) dest.PaymentAdjustment = (Money)PaymentAdjustment.DeepCopy();
                if (PaymentAdjustmentReason != null) dest.PaymentAdjustmentReason = (Coding)PaymentAdjustmentReason.DeepCopy();
                if (PaymentDateElement != null) dest.PaymentDateElement = (Date)PaymentDateElement.DeepCopy();
                if (PaymentAmount != null) dest.PaymentAmount = (Money)PaymentAmount.DeepCopy();
                if (PaymentRef != null) dest.PaymentRef = (Identifier)PaymentRef.DeepCopy();
                if (Reserved != null) dest.Reserved = (Coding)Reserved.DeepCopy();
                if (Form != null) dest.Form = (Coding)Form.DeepCopy();
                if (Note != null) dest.Note = new List<NotesComponent>(Note.DeepCopy());
                if (Coverage != null) dest.Coverage = new List<CoverageComponent>(Coverage.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ClaimResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ClaimResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.Matches(PayeeType, otherT.PayeeType)) return false;
            if (!DeepComparable.Matches(Item, otherT.Item)) return false;
            if (!DeepComparable.Matches(AddItem, otherT.AddItem)) return false;
            if (!DeepComparable.Matches(Error, otherT.Error)) return false;
            if (!DeepComparable.Matches(TotalCost, otherT.TotalCost)) return false;
            if (!DeepComparable.Matches(UnallocDeductable, otherT.UnallocDeductable)) return false;
            if (!DeepComparable.Matches(TotalBenefit, otherT.TotalBenefit)) return false;
            if (!DeepComparable.Matches(PaymentAdjustment, otherT.PaymentAdjustment)) return false;
            if (!DeepComparable.Matches(PaymentAdjustmentReason, otherT.PaymentAdjustmentReason)) return false;
            if (!DeepComparable.Matches(PaymentDateElement, otherT.PaymentDateElement)) return false;
            if (!DeepComparable.Matches(PaymentAmount, otherT.PaymentAmount)) return false;
            if (!DeepComparable.Matches(PaymentRef, otherT.PaymentRef)) return false;
            if (!DeepComparable.Matches(Reserved, otherT.Reserved)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if (!DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ClaimResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(PayeeType, otherT.PayeeType)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(AddItem, otherT.AddItem)) return false;
            if (!DeepComparable.IsExactly(Error, otherT.Error)) return false;
            if (!DeepComparable.IsExactly(TotalCost, otherT.TotalCost)) return false;
            if (!DeepComparable.IsExactly(UnallocDeductable, otherT.UnallocDeductable)) return false;
            if (!DeepComparable.IsExactly(TotalBenefit, otherT.TotalBenefit)) return false;
            if (!DeepComparable.IsExactly(PaymentAdjustment, otherT.PaymentAdjustment)) return false;
            if (!DeepComparable.IsExactly(PaymentAdjustmentReason, otherT.PaymentAdjustmentReason)) return false;
            if (!DeepComparable.IsExactly(PaymentDateElement, otherT.PaymentDateElement)) return false;
            if (!DeepComparable.IsExactly(PaymentAmount, otherT.PaymentAmount)) return false;
            if (!DeepComparable.IsExactly(PaymentRef, otherT.PaymentRef)) return false;
            if (!DeepComparable.IsExactly(Reserved, otherT.Reserved)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Request != null) yield return Request;
                if (Ruleset != null) yield return Ruleset;
                if (OriginalRuleset != null) yield return OriginalRuleset;
                if (CreatedElement != null) yield return CreatedElement;
                if (Organization != null) yield return Organization;
                if (RequestProvider != null) yield return RequestProvider;
                if (RequestOrganization != null) yield return RequestOrganization;
                if (OutcomeElement != null) yield return OutcomeElement;
                if (DispositionElement != null) yield return DispositionElement;
                if (PayeeType != null) yield return PayeeType;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                foreach (var elem in AddItem) { if (elem != null) yield return elem; }
                foreach (var elem in Error) { if (elem != null) yield return elem; }
                if (TotalCost != null) yield return TotalCost;
                if (UnallocDeductable != null) yield return UnallocDeductable;
                if (TotalBenefit != null) yield return TotalBenefit;
                if (PaymentAdjustment != null) yield return PaymentAdjustment;
                if (PaymentAdjustmentReason != null) yield return PaymentAdjustmentReason;
                if (PaymentDateElement != null) yield return PaymentDateElement;
                if (PaymentAmount != null) yield return PaymentAmount;
                if (PaymentRef != null) yield return PaymentRef;
                if (Reserved != null) yield return Reserved;
                if (Form != null) yield return Form;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Coverage) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Request != null) yield return new ElementValue("request", Request);
                if (Ruleset != null) yield return new ElementValue("ruleset", Ruleset);
                if (OriginalRuleset != null) yield return new ElementValue("originalRuleset", OriginalRuleset);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
                if (RequestOrganization != null) yield return new ElementValue("requestOrganization", RequestOrganization);
                if (OutcomeElement != null) yield return new ElementValue("outcome", OutcomeElement);
                if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
                if (PayeeType != null) yield return new ElementValue("payeeType", PayeeType);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                foreach (var elem in AddItem) { if (elem != null) yield return new ElementValue("addItem", elem); }
                foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", elem); }
                if (TotalCost != null) yield return new ElementValue("totalCost", TotalCost);
                if (UnallocDeductable != null) yield return new ElementValue("unallocDeductable", UnallocDeductable);
                if (TotalBenefit != null) yield return new ElementValue("totalBenefit", TotalBenefit);
                if (PaymentAdjustment != null) yield return new ElementValue("paymentAdjustment", PaymentAdjustment);
                if (PaymentAdjustmentReason != null) yield return new ElementValue("paymentAdjustmentReason", PaymentAdjustmentReason);
                if (PaymentDateElement != null) yield return new ElementValue("paymentDate", PaymentDateElement);
                if (PaymentAmount != null) yield return new ElementValue("paymentAmount", PaymentAmount);
                if (PaymentRef != null) yield return new ElementValue("paymentRef", PaymentRef);
                if (Reserved != null) yield return new ElementValue("reserved", Reserved);
                if (Form != null) yield return new ElementValue("form", Form);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Coverage) { if (elem != null) yield return new ElementValue("coverage", elem); }
            }
        }

    }

}
