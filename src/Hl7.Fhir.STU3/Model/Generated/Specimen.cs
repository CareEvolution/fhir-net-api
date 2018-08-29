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
    /// Sample for analysis
    /// </summary>
    [FhirType("Specimen", IsResource=true)]
    [DataContract]
    public partial class Specimen : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Specimen; } }
        [NotMapped]
        public override string TypeName { get { return "Specimen"; } }


        [FhirType("CollectionComponent")]
        [DataContract]
        public partial class CollectionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CollectionComponent"; } }

            /// <summary>
            /// Who collected the specimen
            /// </summary>
            [FhirElement("collector", InSummary=true, Order=40)]
            [References("Practitioner")]
            [DataMember]
            public ResourceReference Collector
            {
                get { return _collector; }
                set { _collector = value; OnPropertyChanged("Collector"); }
            }

            private ResourceReference _collector;

            /// <summary>
            /// Collection time
            /// </summary>
            [FhirElement("collected", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
            [DataMember]
            public Element Collected
            {
                get { return _collected; }
                set { _collected = value; OnPropertyChanged("Collected"); }
            }

            private Element _collected;

            /// <summary>
            /// The quantity of specimen collected
            /// </summary>
            [FhirElement("quantity", Order=60)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Technique used to perform collection
            /// </summary>
            [FhirElement("method", Order=70)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// Anatomical collection site
            /// </summary>
            [FhirElement("bodySite", Order=80)]
            [DataMember]
            public CodeableConcept BodySite
            {
                get { return _bodySite; }
                set { _bodySite = value; OnPropertyChanged("BodySite"); }
            }

            private CodeableConcept _bodySite;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CollectionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Collector != null) dest.Collector = (ResourceReference)Collector.DeepCopy();
                    if (Collected != null) dest.Collected = (Element)Collected.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (BodySite != null) dest.BodySite = (CodeableConcept)BodySite.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CollectionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CollectionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Collector, otherT.Collector)) return false;
                if (!DeepComparable.Matches(Collected, otherT.Collected)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CollectionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Collector, otherT.Collector)) return false;
                if (!DeepComparable.IsExactly(Collected, otherT.Collected)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Collector != null) yield return Collector;
                    if (Collected != null) yield return Collected;
                    if (Quantity != null) yield return Quantity;
                    if (Method != null) yield return Method;
                    if (BodySite != null) yield return BodySite;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Collector != null) yield return new ElementValue("collector", Collector);
                    if (Collected != null) yield return new ElementValue("collected", Collected);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                }
            }


        }


        [FhirType("ProcessingComponent")]
        [DataContract]
        public partial class ProcessingComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProcessingComponent"; } }

            /// <summary>
            /// Textual description of procedure
            /// </summary>
            [FhirElement("description", Order=40)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Textual description of procedure
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
            /// Indicates the treatment step  applied to the specimen
            /// </summary>
            [FhirElement("procedure", Order=50)]
            [DataMember]
            public CodeableConcept Procedure
            {
                get { return _procedure; }
                set { _procedure = value; OnPropertyChanged("Procedure"); }
            }

            private CodeableConcept _procedure;

            /// <summary>
            /// Material used in the processing step
            /// </summary>
            [FhirElement("additive", Order=60)]
            [References("Substance")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Additive
            {
                get { if (_additive==null) _additive = new List<ResourceReference>(); return _additive; }
                set { _additive = value; OnPropertyChanged("Additive"); }
            }

            private List<ResourceReference> _additive;

            /// <summary>
            /// Date and time of specimen processing
            /// </summary>
            [FhirElement("time", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
            [DataMember]
            public Element Time
            {
                get { return _time; }
                set { _time = value; OnPropertyChanged("Time"); }
            }

            private Element _time;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcessingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Procedure != null) dest.Procedure = (CodeableConcept)Procedure.DeepCopy();
                    if (Additive != null) dest.Additive = new List<ResourceReference>(Additive.DeepCopy());
                    if (Time != null) dest.Time = (Element)Time.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProcessingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcessingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Procedure, otherT.Procedure)) return false;
                if ( !DeepComparable.Matches(Additive, otherT.Additive)) return false;
                if (!DeepComparable.Matches(Time, otherT.Time)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcessingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;
                if (!DeepComparable.IsExactly(Additive, otherT.Additive)) return false;
                if (!DeepComparable.IsExactly(Time, otherT.Time)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Procedure != null) yield return Procedure;
                    foreach (var elem in Additive) { if (elem != null) yield return elem; }
                    if (Time != null) yield return Time;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Procedure != null) yield return new ElementValue("procedure", Procedure);
                    foreach (var elem in Additive) { if (elem != null) yield return new ElementValue("additive", elem); }
                    if (Time != null) yield return new ElementValue("time", Time);
                }
            }


        }


        [FhirType("ContainerComponent")]
        [DataContract]
        public partial class ContainerComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContainerComponent"; } }

            /// <summary>
            /// Id for the container
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Identifier> Identifier
            {
                get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private List<Identifier> _identifier;

            /// <summary>
            /// Textual description of the container
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
            /// Textual description of the container
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
            /// Kind of container directly associated with specimen
            /// </summary>
            [FhirElement("type", Order=60)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Container volume or size
            /// </summary>
            [FhirElement("capacity", Order=70)]
            [DataMember]
            public SimpleQuantity Capacity
            {
                get { return _capacity; }
                set { _capacity = value; OnPropertyChanged("Capacity"); }
            }

            private SimpleQuantity _capacity;

            /// <summary>
            /// Quantity of specimen within container
            /// </summary>
            [FhirElement("specimenQuantity", Order=80)]
            [DataMember]
            public SimpleQuantity SpecimenQuantity
            {
                get { return _specimenQuantity; }
                set { _specimenQuantity = value; OnPropertyChanged("SpecimenQuantity"); }
            }

            private SimpleQuantity _specimenQuantity;

            /// <summary>
            /// Additive associated with container
            /// </summary>
            [FhirElement("additive", Order=90, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Additive
            {
                get { return _additive; }
                set { _additive = value; OnPropertyChanged("Additive"); }
            }

            private Element _additive;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContainerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Capacity != null) dest.Capacity = (SimpleQuantity)Capacity.DeepCopy();
                    if (SpecimenQuantity != null) dest.SpecimenQuantity = (SimpleQuantity)SpecimenQuantity.DeepCopy();
                    if (Additive != null) dest.Additive = (Element)Additive.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContainerComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContainerComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Capacity, otherT.Capacity)) return false;
                if (!DeepComparable.Matches(SpecimenQuantity, otherT.SpecimenQuantity)) return false;
                if (!DeepComparable.Matches(Additive, otherT.Additive)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContainerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Capacity, otherT.Capacity)) return false;
                if (!DeepComparable.IsExactly(SpecimenQuantity, otherT.SpecimenQuantity)) return false;
                if (!DeepComparable.IsExactly(Additive, otherT.Additive)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Type != null) yield return Type;
                    if (Capacity != null) yield return Capacity;
                    if (SpecimenQuantity != null) yield return SpecimenQuantity;
                    if (Additive != null) yield return Additive;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Capacity != null) yield return new ElementValue("capacity", Capacity);
                    if (SpecimenQuantity != null) yield return new ElementValue("specimenQuantity", SpecimenQuantity);
                    if (Additive != null) yield return new ElementValue("additive", Additive);
                }
            }


        }


        /// <summary>
        /// External Identifier
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
        /// Identifier assigned by the lab
        /// </summary>
        [FhirElement("accessionIdentifier", InSummary=true, Order=100)]
        [DataMember]
        public Identifier AccessionIdentifier
        {
            get { return _accessionIdentifier; }
            set { _accessionIdentifier = value; OnPropertyChanged("AccessionIdentifier"); }
        }

        private Identifier _accessionIdentifier;

        /// <summary>
        /// available | unavailable | unsatisfactory | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [DataMember]
        public Code<SpecimenStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<SpecimenStatus> _statusElement;

        /// <summary>
        /// available | unavailable | unsatisfactory | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SpecimenStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<SpecimenStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Kind of material that forms the specimen
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Where the specimen came from. This may be from the patient(s) or from the environment or a device
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Group","Device","Substance")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// The time when specimen was received for processing
        /// </summary>
        [FhirElement("receivedTime", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime ReceivedTimeElement
        {
            get { return _receivedTimeElement; }
            set { _receivedTimeElement = value; OnPropertyChanged("ReceivedTimeElement"); }
        }

        private FhirDateTime _receivedTimeElement;

        /// <summary>
        /// The time when specimen was received for processing
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ReceivedTime
        {
            get { return ReceivedTimeElement != null ? ReceivedTimeElement.Value : null; }
            set
            {
                if (value == null)
                    ReceivedTimeElement = null;
                else
                    ReceivedTimeElement = new FhirDateTime(value);
                OnPropertyChanged("ReceivedTime");
            }
        }

        /// <summary>
        /// Specimen from which this specimen originated
        /// </summary>
        [FhirElement("parent", Order=150)]
        [References("Specimen")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Parent
        {
            get { if (_parent==null) _parent = new List<ResourceReference>(); return _parent; }
            set { _parent = value; OnPropertyChanged("Parent"); }
        }

        private List<ResourceReference> _parent;

        /// <summary>
        /// Why the specimen was collected
        /// </summary>
        [FhirElement("request", Order=160)]
        [References("ProcedureRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Request
        {
            get { if (_request==null) _request = new List<ResourceReference>(); return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private List<ResourceReference> _request;

        /// <summary>
        /// Collection details
        /// </summary>
        [FhirElement("collection", Order=170)]
        [DataMember]
        public CollectionComponent Collection
        {
            get { return _collection; }
            set { _collection = value; OnPropertyChanged("Collection"); }
        }

        private CollectionComponent _collection;

        /// <summary>
        /// Processing and processing step details
        /// </summary>
        [FhirElement("processing", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProcessingComponent> Processing
        {
            get { if (_processing==null) _processing = new List<ProcessingComponent>(); return _processing; }
            set { _processing = value; OnPropertyChanged("Processing"); }
        }

        private List<ProcessingComponent> _processing;

        /// <summary>
        /// Direct container of specimen (tube/slide, etc.)
        /// </summary>
        [FhirElement("container", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContainerComponent> Container
        {
            get { if (_container==null) _container = new List<ContainerComponent>(); return _container; }
            set { _container = value; OnPropertyChanged("Container"); }
        }

        private List<ContainerComponent> _container;

        /// <summary>
        /// Comments
        /// </summary>
        [FhirElement("note", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Specimen;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (AccessionIdentifier != null) dest.AccessionIdentifier = (Identifier)AccessionIdentifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<SpecimenStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (ReceivedTimeElement != null) dest.ReceivedTimeElement = (FhirDateTime)ReceivedTimeElement.DeepCopy();
                if (Parent != null) dest.Parent = new List<ResourceReference>(Parent.DeepCopy());
                if (Request != null) dest.Request = new List<ResourceReference>(Request.DeepCopy());
                if (Collection != null) dest.Collection = (CollectionComponent)Collection.DeepCopy();
                if (Processing != null) dest.Processing = new List<ProcessingComponent>(Processing.DeepCopy());
                if (Container != null) dest.Container = new List<ContainerComponent>(Container.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Specimen());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Specimen;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(AccessionIdentifier, otherT.AccessionIdentifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(ReceivedTimeElement, otherT.ReceivedTimeElement)) return false;
            if ( !DeepComparable.Matches(Parent, otherT.Parent)) return false;
            if ( !DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Collection, otherT.Collection)) return false;
            if ( !DeepComparable.Matches(Processing, otherT.Processing)) return false;
            if ( !DeepComparable.Matches(Container, otherT.Container)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Specimen;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(AccessionIdentifier, otherT.AccessionIdentifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(ReceivedTimeElement, otherT.ReceivedTimeElement)) return false;
            if (!DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Collection, otherT.Collection)) return false;
            if (!DeepComparable.IsExactly(Processing, otherT.Processing)) return false;
            if (!DeepComparable.IsExactly(Container, otherT.Container)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (AccessionIdentifier != null) yield return AccessionIdentifier;
                if (StatusElement != null) yield return StatusElement;
                if (Type != null) yield return Type;
                if (Subject != null) yield return Subject;
                if (ReceivedTimeElement != null) yield return ReceivedTimeElement;
                foreach (var elem in Parent) { if (elem != null) yield return elem; }
                foreach (var elem in Request) { if (elem != null) yield return elem; }
                if (Collection != null) yield return Collection;
                foreach (var elem in Processing) { if (elem != null) yield return elem; }
                foreach (var elem in Container) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (AccessionIdentifier != null) yield return new ElementValue("accessionIdentifier", AccessionIdentifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (ReceivedTimeElement != null) yield return new ElementValue("receivedTime", ReceivedTimeElement);
                foreach (var elem in Parent) { if (elem != null) yield return new ElementValue("parent", elem); }
                foreach (var elem in Request) { if (elem != null) yield return new ElementValue("request", elem); }
                if (Collection != null) yield return new ElementValue("collection", Collection);
                foreach (var elem in Processing) { if (elem != null) yield return new ElementValue("processing", elem); }
                foreach (var elem in Container) { if (elem != null) yield return new ElementValue("container", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
