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
    /// Links records for 'same' item
    /// </summary>
    [FhirType("Linkage", IsResource=true)]
    [DataContract]
    public partial class Linkage : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Linkage; } }
        [NotMapped]
        public override string TypeName { get { return "Linkage"; } }


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// source | alternate | historical
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<LinkageType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<LinkageType> _typeElement;

            /// <summary>
            /// source | alternate | historical
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public LinkageType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<LinkageType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Resource being linked
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private ResourceReference _resource;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<LinkageType>)TypeElement.DeepCopy();
                    if (Resource != null) dest.Resource = (ResourceReference)Resource.DeepCopy();
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
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Resource != null) yield return Resource;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (Resource != null) yield return new ElementValue("resource", false, Resource);
                }
            }


        }


        /// <summary>
        /// Whether this linkage assertion is active or not
        /// </summary>
        [FhirElement("active", InSummary=true, Order=90)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// Whether this linkage assertion is active or not
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// Who is responsible for linkages
        /// </summary>
        [FhirElement("author", InSummary=true, Order=100)]
        [References("Practitioner","Organization")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Item to be linked
        /// </summary>
        [FhirElement("item", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemComponent> _item;


        public static ElementDefinition.ConstraintComponent Linkage_LNK_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.count()>1",
            Key = "lnk-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Must have at least two items",
            Xpath = "count(f:item)>1"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Linkage_LNK_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Linkage;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Linkage());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Linkage;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Linkage;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (ActiveElement != null) yield return ActiveElement;
                if (Author != null) yield return Author;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (ActiveElement != null) yield return new ElementValue("active", false, ActiveElement);
                if (Author != null) yield return new ElementValue("author", false, Author);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", true, elem); }
            }
        }

    }

}
