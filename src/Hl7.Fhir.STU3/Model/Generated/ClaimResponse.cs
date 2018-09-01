using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequenceLinkId", Order=40)]
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
                    if (value == null)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
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
            [FhirElement("adjudication", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            /// <summary>
            /// Detail line items
            /// </summary>
            [FhirElement("detail", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ItemDetailComponent> Detail
            {
                get { if (_detail==null) _detail = new List<ItemDetailComponent>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<ItemDetailComponent> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
                    if (Detail != null) dest.Detail = new List<ItemDetailComponent>(Detail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
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


        [FhirType("AdjudicationComponent")]
        [DataContract]
        public partial class AdjudicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Explanation of Adjudication outcome
            /// </summary>
            [FhirElement("reason", Order=50)]
            [DataMember]
            public CodeableConcept Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private CodeableConcept _reason;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", Order=60)]
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
            [FhirElement("value", Order=70)]
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
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
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
                    if (Category != null) yield return Category;
                    if (Reason != null) yield return Reason;
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
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Reason != null) yield return new ElementValue("reason", Reason);
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
            [FhirElement("sequenceLinkId", Order=40)]
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
                    if (value == null)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
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
            /// Detail level adjudication details
            /// </summary>
            [FhirElement("adjudication", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            /// <summary>
            /// Subdetail line items
            /// </summary>
            [FhirElement("subDetail", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubDetailComponent> SubDetail
            {
                get { if (_subDetail==null) _subDetail = new List<SubDetailComponent>(); return _subDetail; }
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
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if ( !DeepComparable.Matches(SubDetail, otherT.SubDetail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
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
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
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
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                    foreach (var elem in SubDetail) { if (elem != null) yield return new ElementValue("subDetail", elem); }
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
            [FhirElement("sequenceLinkId", Order=40)]
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
                    if (value == null)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
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
            /// Subdetail level adjudication details
            /// </summary>
            [FhirElement("adjudication", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
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
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
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
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
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
            [FhirElement("sequenceLinkId", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> SequenceLinkIdElement
            {
                get { if (_sequenceLinkIdElement==null) _sequenceLinkIdElement = new List<PositiveInt>(); return _sequenceLinkIdElement; }
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
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=50)]
            [DataMember]
            public CodeableConcept Revenue
            {
                get { return _revenue; }
                set { _revenue = value; OnPropertyChanged("Revenue"); }
            }

            private CodeableConcept _revenue;

            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=60)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Group, Service or Product
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public CodeableConcept Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private CodeableConcept _service;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Professional fee or Product charge
            /// </summary>
            [FhirElement("fee", Order=90)]
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
            [FhirElement("noteNumber", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
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
            /// Added items adjudication
            /// </summary>
            [FhirElement("adjudication", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            /// <summary>
            /// Added items details
            /// </summary>
            [FhirElement("detail", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AddedItemsDetailComponent> Detail
            {
                get { if (_detail==null) _detail = new List<AddedItemsDetailComponent>(); return _detail; }
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
                    if (Revenue != null) dest.Revenue = (CodeableConcept)Revenue.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Service != null) dest.Service = (CodeableConcept)Service.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (Fee != null) dest.Fee = (Money)Fee.DeepCopy();
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if ( !DeepComparable.Matches(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.Matches(Fee, otherT.Fee)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceLinkIdElement, otherT.SequenceLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(Fee, otherT.Fee)) return false;
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
                    foreach (var elem in SequenceLinkIdElement) { if (elem != null) yield return elem; }
                    if (Revenue != null) yield return Revenue;
                    if (Category != null) yield return Category;
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    if (Fee != null) yield return Fee;
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
                    foreach (var elem in SequenceLinkIdElement) { if (elem != null) yield return new ElementValue("sequenceLinkId", elem); }
                    if (Revenue != null) yield return new ElementValue("revenue", Revenue);
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Service != null) yield return new ElementValue("service", Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    if (Fee != null) yield return new ElementValue("fee", Fee);
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
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
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=40)]
            [DataMember]
            public CodeableConcept Revenue
            {
                get { return _revenue; }
                set { _revenue = value; OnPropertyChanged("Revenue"); }
            }

            private CodeableConcept _revenue;

            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=50)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Service or Product
            /// </summary>
            [FhirElement("service", Order=60)]
            [DataMember]
            public CodeableConcept Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private CodeableConcept _service;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Professional fee or Product charge
            /// </summary>
            [FhirElement("fee", Order=80)]
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
            [FhirElement("noteNumber", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
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
            /// Added items detail adjudication
            /// </summary>
            [FhirElement("adjudication", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemsDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Revenue != null) dest.Revenue = (CodeableConcept)Revenue.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Service != null) dest.Service = (CodeableConcept)Service.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (Fee != null) dest.Fee = (Money)Fee.DeepCopy();
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if (!DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.Matches(Fee, otherT.Fee)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemsDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(Fee, otherT.Fee)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Revenue != null) yield return Revenue;
                    if (Category != null) yield return Category;
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    if (Fee != null) yield return Fee;
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Revenue != null) yield return new ElementValue("revenue", Revenue);
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Service != null) yield return new ElementValue("service", Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    if (Fee != null) yield return new ElementValue("fee", Fee);
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", elem); }
                }
            }


        }


        [FhirType("ErrorComponent")]
        [DataContract]
        public partial class ErrorComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ErrorComponent"; } }

            /// <summary>
            /// Item sequence number
            /// </summary>
            [FhirElement("sequenceLinkId", Order=40)]
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
                    if (value == null)
                        SequenceLinkIdElement = null;
                    else
                        SequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SequenceLinkId");
                }
            }

            /// <summary>
            /// Detail sequence number
            /// </summary>
            [FhirElement("detailSequenceLinkId", Order=50)]
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
                    if (value == null)
                        DetailSequenceLinkIdElement = null;
                    else
                        DetailSequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("DetailSequenceLinkId");
                }
            }

            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            [FhirElement("subdetailSequenceLinkId", Order=60)]
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
                    if (value == null)
                        SubdetailSequenceLinkIdElement = null;
                    else
                        SubdetailSequenceLinkIdElement = new PositiveInt(value);
                    OnPropertyChanged("SubdetailSequenceLinkId");
                }
            }

            /// <summary>
            /// Error code detailing processing issues
            /// </summary>
            [FhirElement("code", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ErrorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceLinkIdElement != null) dest.SequenceLinkIdElement = (PositiveInt)SequenceLinkIdElement.DeepCopy();
                    if (DetailSequenceLinkIdElement != null) dest.DetailSequenceLinkIdElement = (PositiveInt)DetailSequenceLinkIdElement.DeepCopy();
                    if (SubdetailSequenceLinkIdElement != null) dest.SubdetailSequenceLinkIdElement = (PositiveInt)SubdetailSequenceLinkIdElement.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ErrorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ErrorComponent;
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
                var otherT = other as ErrorComponent;
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


        [FhirType("PaymentComponent")]
        [DataContract]
        public partial class PaymentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PaymentComponent"; } }

            /// <summary>
            /// Partial or Complete
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Payment adjustment for non-Claim issues
            /// </summary>
            [FhirElement("adjustment", Order=50)]
            [DataMember]
            public Money Adjustment
            {
                get { return _adjustment; }
                set { _adjustment = value; OnPropertyChanged("Adjustment"); }
            }

            private Money _adjustment;

            /// <summary>
            /// Explanation for the non-claim adjustment
            /// </summary>
            [FhirElement("adjustmentReason", Order=60)]
            [DataMember]
            public CodeableConcept AdjustmentReason
            {
                get { return _adjustmentReason; }
                set { _adjustmentReason = value; OnPropertyChanged("AdjustmentReason"); }
            }

            private CodeableConcept _adjustmentReason;

            /// <summary>
            /// Expected data of Payment
            /// </summary>
            [FhirElement("date", Order=70)]
            [DataMember]
            public Date DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private Date _dateElement;

            /// <summary>
            /// Expected data of Payment
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
                        DateElement = new Date(value);
                    OnPropertyChanged("Date");
                }
            }

            /// <summary>
            /// Payable amount after adjustment
            /// </summary>
            [FhirElement("amount", Order=80)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Identifier of the payment instrument
            /// </summary>
            [FhirElement("identifier", Order=90)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PaymentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Adjustment != null) dest.Adjustment = (Money)Adjustment.DeepCopy();
                    if (AdjustmentReason != null) dest.AdjustmentReason = (CodeableConcept)AdjustmentReason.DeepCopy();
                    if (DateElement != null) dest.DateElement = (Date)DateElement.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PaymentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PaymentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Adjustment, otherT.Adjustment)) return false;
                if (!DeepComparable.Matches(AdjustmentReason, otherT.AdjustmentReason)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PaymentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Adjustment, otherT.Adjustment)) return false;
                if (!DeepComparable.IsExactly(AdjustmentReason, otherT.AdjustmentReason)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Adjustment != null) yield return Adjustment;
                    if (AdjustmentReason != null) yield return AdjustmentReason;
                    if (DateElement != null) yield return DateElement;
                    if (Amount != null) yield return Amount;
                    if (Identifier != null) yield return Identifier;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Adjustment != null) yield return new ElementValue("adjustment", Adjustment);
                    if (AdjustmentReason != null) yield return new ElementValue("adjustmentReason", AdjustmentReason);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                }
            }


        }


        [FhirType("NoteComponent")]
        [DataContract]
        public partial class NoteComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NoteComponent"; } }

            /// <summary>
            /// Sequence Number for this note
            /// </summary>
            [FhirElement("number", Order=40)]
            [DataMember]
            public PositiveInt NumberElement
            {
                get { return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private PositiveInt _numberElement;

            /// <summary>
            /// Sequence Number for this note
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new PositiveInt(value);
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Note explanatory text
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

            /// <summary>
            /// Language if different from the resource
            /// </summary>
            [FhirElement("language", Order=70)]
            [DataMember]
            public CodeableConcept Language
            {
                get { return _language; }
                set { _language = value; OnPropertyChanged("Language"); }
            }

            private CodeableConcept _language;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NoteComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NumberElement != null) dest.NumberElement = (PositiveInt)NumberElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (Language != null) dest.Language = (CodeableConcept)Language.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NoteComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NoteComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(Language, otherT.Language)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NoteComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(Language, otherT.Language)) return false;

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
                    if (Language != null) yield return Language;
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
                    if (Language != null) yield return new ElementValue("language", Language);
                }
            }


        }


        [FhirType("InsuranceComponent")]
        [DataContract]
        public partial class InsuranceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InsuranceComponent"; } }

            /// <summary>
            /// Service instance identifier
            /// </summary>
            [FhirElement("sequence", Order=40)]
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
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            [FhirElement("focal", Order=50)]
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
                    if (value == null)
                        FocalElement = null;
                    else
                        FocalElement = new FhirBoolean(value);
                    OnPropertyChanged("Focal");
                }
            }

            /// <summary>
            /// Insurance information
            /// </summary>
            [FhirElement("coverage", Order=60)]
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
            [FhirElement("businessArrangement", Order=70)]
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
            /// Pre-Authorization/Determination Reference
            /// </summary>
            [FhirElement("preAuthRef", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> PreAuthRefElement
            {
                get { if (_preAuthRefElement==null) _preAuthRefElement = new List<FhirString>(); return _preAuthRefElement; }
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
            [FhirElement("claimResponse", Order=90)]
            [References("ClaimResponse")]
            [DataMember]
            public ResourceReference ClaimResponse
            {
                get { return _claimResponse; }
                set { _claimResponse = value; OnPropertyChanged("ClaimResponse"); }
            }

            private ResourceReference _claimResponse;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InsuranceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (FocalElement != null) dest.FocalElement = (FhirBoolean)FocalElement.DeepCopy();
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (BusinessArrangementElement != null) dest.BusinessArrangementElement = (FhirString)BusinessArrangementElement.DeepCopy();
                    if (PreAuthRefElement != null) dest.PreAuthRefElement = new List<FhirString>(PreAuthRefElement.DeepCopy());
                    if (ClaimResponse != null) dest.ClaimResponse = (ResourceReference)ClaimResponse.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InsuranceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if ( !DeepComparable.Matches(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.Matches(ClaimResponse, otherT.ClaimResponse)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if (!DeepComparable.IsExactly(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.IsExactly(ClaimResponse, otherT.ClaimResponse)) return false;

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
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return elem; }
                    if (ClaimResponse != null) yield return ClaimResponse;
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
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return new ElementValue("preAuthRef", elem); }
                    if (ClaimResponse != null) yield return new ElementValue("claimResponse", ClaimResponse);
                }
            }


        }


        /// <summary>
        /// Response  number
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
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", Order=110)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=120)]
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
        /// Insurance issuing organization
        /// </summary>
        [FhirElement("insurer", Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Insurer
        {
            get { return _insurer; }
            set { _insurer = value; OnPropertyChanged("Insurer"); }
        }

        private ResourceReference _insurer;

        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("requestProvider", Order=140)]
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
        [FhirElement("requestOrganization", Order=150)]
        [References("Organization")]
        [DataMember]
        public ResourceReference RequestOrganization
        {
            get { return _requestOrganization; }
            set { _requestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }

        private ResourceReference _requestOrganization;

        /// <summary>
        /// Id of resource triggering adjudication
        /// </summary>
        [FhirElement("request", Order=160)]
        [References("Claim")]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// complete | error | partial
        /// </summary>
        [FhirElement("outcome", Order=170)]
        [DataMember]
        public CodeableConcept Outcome
        {
            get { return _outcome; }
            set { _outcome = value; OnPropertyChanged("Outcome"); }
        }

        private CodeableConcept _outcome;

        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", Order=180)]
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
        [FhirElement("payeeType", Order=190)]
        [DataMember]
        public CodeableConcept PayeeType
        {
            get { return _payeeType; }
            set { _payeeType = value; OnPropertyChanged("PayeeType"); }
        }

        private CodeableConcept _payeeType;

        /// <summary>
        /// Line items
        /// </summary>
        [FhirElement("item", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemComponent> _item;

        /// <summary>
        /// Insurer added line items
        /// </summary>
        [FhirElement("addItem", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AddedItemComponent> AddItem
        {
            get { if (_addItem==null) _addItem = new List<AddedItemComponent>(); return _addItem; }
            set { _addItem = value; OnPropertyChanged("AddItem"); }
        }

        private List<AddedItemComponent> _addItem;

        /// <summary>
        /// Processing errors
        /// </summary>
        [FhirElement("error", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ErrorComponent> Error
        {
            get { if (_error==null) _error = new List<ErrorComponent>(); return _error; }
            set { _error = value; OnPropertyChanged("Error"); }
        }

        private List<ErrorComponent> _error;

        /// <summary>
        /// Total Cost of service from the Claim
        /// </summary>
        [FhirElement("totalCost", Order=230)]
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
        [FhirElement("unallocDeductable", Order=240)]
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
        [FhirElement("totalBenefit", Order=250)]
        [DataMember]
        public Money TotalBenefit
        {
            get { return _totalBenefit; }
            set { _totalBenefit = value; OnPropertyChanged("TotalBenefit"); }
        }

        private Money _totalBenefit;

        /// <summary>
        /// Payment details, if paid
        /// </summary>
        [FhirElement("payment", Order=260)]
        [DataMember]
        public PaymentComponent Payment
        {
            get { return _payment; }
            set { _payment = value; OnPropertyChanged("Payment"); }
        }

        private PaymentComponent _payment;

        /// <summary>
        /// Funds reserved status
        /// </summary>
        [FhirElement("reserved", Order=270)]
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
        [FhirElement("form", Order=280)]
        [DataMember]
        public CodeableConcept Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private CodeableConcept _form;

        /// <summary>
        /// Processing notes
        /// </summary>
        [FhirElement("processNote", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NoteComponent> ProcessNote
        {
            get { if (_processNote==null) _processNote = new List<NoteComponent>(); return _processNote; }
            set { _processNote = value; OnPropertyChanged("ProcessNote"); }
        }

        private List<NoteComponent> _processNote;

        /// <summary>
        /// Request for additional information
        /// </summary>
        [FhirElement("communicationRequest", Order=300)]
        [References("CommunicationRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> CommunicationRequest
        {
            get { if (_communicationRequest==null) _communicationRequest = new List<ResourceReference>(); return _communicationRequest; }
            set { _communicationRequest = value; OnPropertyChanged("CommunicationRequest"); }
        }

        private List<ResourceReference> _communicationRequest;

        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("insurance", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InsuranceComponent> Insurance
        {
            get { if (_insurance==null) _insurance = new List<InsuranceComponent>(); return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private List<InsuranceComponent> _insurance;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ClaimResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Insurer != null) dest.Insurer = (ResourceReference)Insurer.DeepCopy();
                if (RequestProvider != null) dest.RequestProvider = (ResourceReference)RequestProvider.DeepCopy();
                if (RequestOrganization != null) dest.RequestOrganization = (ResourceReference)RequestOrganization.DeepCopy();
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (PayeeType != null) dest.PayeeType = (CodeableConcept)PayeeType.DeepCopy();
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                if (AddItem != null) dest.AddItem = new List<AddedItemComponent>(AddItem.DeepCopy());
                if (Error != null) dest.Error = new List<ErrorComponent>(Error.DeepCopy());
                if (TotalCost != null) dest.TotalCost = (Money)TotalCost.DeepCopy();
                if (UnallocDeductable != null) dest.UnallocDeductable = (Money)UnallocDeductable.DeepCopy();
                if (TotalBenefit != null) dest.TotalBenefit = (Money)TotalBenefit.DeepCopy();
                if (Payment != null) dest.Payment = (PaymentComponent)Payment.DeepCopy();
                if (Reserved != null) dest.Reserved = (Coding)Reserved.DeepCopy();
                if (Form != null) dest.Form = (CodeableConcept)Form.DeepCopy();
                if (ProcessNote != null) dest.ProcessNote = new List<NoteComponent>(ProcessNote.DeepCopy());
                if (CommunicationRequest != null) dest.CommunicationRequest = new List<ResourceReference>(CommunicationRequest.DeepCopy());
                if (Insurance != null) dest.Insurance = new List<InsuranceComponent>(Insurance.DeepCopy());
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
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.Matches(PayeeType, otherT.PayeeType)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;
            if ( !DeepComparable.Matches(AddItem, otherT.AddItem)) return false;
            if ( !DeepComparable.Matches(Error, otherT.Error)) return false;
            if (!DeepComparable.Matches(TotalCost, otherT.TotalCost)) return false;
            if (!DeepComparable.Matches(UnallocDeductable, otherT.UnallocDeductable)) return false;
            if (!DeepComparable.Matches(TotalBenefit, otherT.TotalBenefit)) return false;
            if (!DeepComparable.Matches(Payment, otherT.Payment)) return false;
            if (!DeepComparable.Matches(Reserved, otherT.Reserved)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if ( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;
            if ( !DeepComparable.Matches(CommunicationRequest, otherT.CommunicationRequest)) return false;
            if ( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ClaimResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(PayeeType, otherT.PayeeType)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(AddItem, otherT.AddItem)) return false;
            if (!DeepComparable.IsExactly(Error, otherT.Error)) return false;
            if (!DeepComparable.IsExactly(TotalCost, otherT.TotalCost)) return false;
            if (!DeepComparable.IsExactly(UnallocDeductable, otherT.UnallocDeductable)) return false;
            if (!DeepComparable.IsExactly(TotalBenefit, otherT.TotalBenefit)) return false;
            if (!DeepComparable.IsExactly(Payment, otherT.Payment)) return false;
            if (!DeepComparable.IsExactly(Reserved, otherT.Reserved)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;
            if (!DeepComparable.IsExactly(CommunicationRequest, otherT.CommunicationRequest)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;

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
                if (Patient != null) yield return Patient;
                if (CreatedElement != null) yield return CreatedElement;
                if (Insurer != null) yield return Insurer;
                if (RequestProvider != null) yield return RequestProvider;
                if (RequestOrganization != null) yield return RequestOrganization;
                if (Request != null) yield return Request;
                if (Outcome != null) yield return Outcome;
                if (DispositionElement != null) yield return DispositionElement;
                if (PayeeType != null) yield return PayeeType;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                foreach (var elem in AddItem) { if (elem != null) yield return elem; }
                foreach (var elem in Error) { if (elem != null) yield return elem; }
                if (TotalCost != null) yield return TotalCost;
                if (UnallocDeductable != null) yield return UnallocDeductable;
                if (TotalBenefit != null) yield return TotalBenefit;
                if (Payment != null) yield return Payment;
                if (Reserved != null) yield return Reserved;
                if (Form != null) yield return Form;
                foreach (var elem in ProcessNote) { if (elem != null) yield return elem; }
                foreach (var elem in CommunicationRequest) { if (elem != null) yield return elem; }
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
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
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Insurer != null) yield return new ElementValue("insurer", Insurer);
                if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
                if (RequestOrganization != null) yield return new ElementValue("requestOrganization", RequestOrganization);
                if (Request != null) yield return new ElementValue("request", Request);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
                if (PayeeType != null) yield return new ElementValue("payeeType", PayeeType);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                foreach (var elem in AddItem) { if (elem != null) yield return new ElementValue("addItem", elem); }
                foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", elem); }
                if (TotalCost != null) yield return new ElementValue("totalCost", TotalCost);
                if (UnallocDeductable != null) yield return new ElementValue("unallocDeductable", UnallocDeductable);
                if (TotalBenefit != null) yield return new ElementValue("totalBenefit", TotalBenefit);
                if (Payment != null) yield return new ElementValue("payment", Payment);
                if (Reserved != null) yield return new ElementValue("reserved", Reserved);
                if (Form != null) yield return new ElementValue("form", Form);
                foreach (var elem in ProcessNote) { if (elem != null) yield return new ElementValue("processNote", elem); }
                foreach (var elem in CommunicationRequest) { if (elem != null) yield return new ElementValue("communicationRequest", elem); }
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", elem); }
            }
        }

    }

}
