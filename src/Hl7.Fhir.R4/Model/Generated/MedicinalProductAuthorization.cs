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
    /// The regulatory authorization of a medicinal product
    /// </summary>
    [FhirType("MedicinalProductAuthorization", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductAuthorization : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductAuthorization; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductAuthorization"; } }


        [FhirType("JurisdictionalAuthorizationComponent")]
        [DataContract]
        public partial class JurisdictionalAuthorizationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "JurisdictionalAuthorizationComponent"; } }

            /// <summary>
            /// The assigned number for the marketing authorization
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
            /// Country of authorization
            /// </summary>
            [FhirElement("country", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Country
            {
                get { return _country; }
                set { _country = value; OnPropertyChanged("Country"); }
            }

            private CodeableConcept _country;

            /// <summary>
            /// Jurisdiction within a country
            /// </summary>
            [FhirElement("jurisdiction", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Jurisdiction
            {
                get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
                set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }

            private List<CodeableConcept> _jurisdiction;

            /// <summary>
            /// The legal status of supply in a jurisdiction or region
            /// </summary>
            [FhirElement("legalStatusOfSupply", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept LegalStatusOfSupply
            {
                get { return _legalStatusOfSupply; }
                set { _legalStatusOfSupply = value; OnPropertyChanged("LegalStatusOfSupply"); }
            }

            private CodeableConcept _legalStatusOfSupply;

            /// <summary>
            /// The start and expected end date of the authorization
            /// </summary>
            [FhirElement("validityPeriod", InSummary=true, Order=80)]
            [DataMember]
            public Period ValidityPeriod
            {
                get { return _validityPeriod; }
                set { _validityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
            }

            private Period _validityPeriod;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as JurisdictionalAuthorizationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                    if (Country != null) dest.Country = (CodeableConcept)Country.DeepCopy();
                    if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                    if (LegalStatusOfSupply != null) dest.LegalStatusOfSupply = (CodeableConcept)LegalStatusOfSupply.DeepCopy();
                    if (ValidityPeriod != null) dest.ValidityPeriod = (Period)ValidityPeriod.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new JurisdictionalAuthorizationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as JurisdictionalAuthorizationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Country, otherT.Country)) return false;
                if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if (!DeepComparable.Matches(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
                if (!DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as JurisdictionalAuthorizationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Country, otherT.Country)) return false;
                if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if (!DeepComparable.IsExactly(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
                if (!DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                    if (Country != null) yield return Country;
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                    if (LegalStatusOfSupply != null) yield return LegalStatusOfSupply;
                    if (ValidityPeriod != null) yield return ValidityPeriod;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                    if (Country != null) yield return new ElementValue("country", Country);
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                    if (LegalStatusOfSupply != null) yield return new ElementValue("legalStatusOfSupply", LegalStatusOfSupply);
                    if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", ValidityPeriod);
                }
            }


        }


        [FhirType("ProcedureComponent")]
        [DataContract]
        public partial class ProcedureComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProcedureComponent"; } }

            /// <summary>
            /// Identifier for this procedure
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
            /// Type of procedure
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Date of procedure
            /// </summary>
            [FhirElement("date", InSummary=true, Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Period),typeof(FhirDateTime))]
            [DataMember]
            public Element Date
            {
                get { return _date; }
                set { _date = value; OnPropertyChanged("Date"); }
            }

            private Element _date;

            /// <summary>
            /// Applcations submitted to obtain a marketing authorization
            /// </summary>
            [FhirElement("application", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ProcedureComponent> Application
            {
                get { if (_application==null) _application = new List<ProcedureComponent>(); return _application; }
                set { _application = value; OnPropertyChanged("Application"); }
            }

            private List<ProcedureComponent> _application;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcedureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Date != null) dest.Date = (Element)Date.DeepCopy();
                    if (Application != null) dest.Application = new List<ProcedureComponent>(Application.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProcedureComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcedureComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Date, otherT.Date)) return false;
                if ( !DeepComparable.Matches(Application, otherT.Application)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcedureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Date, otherT.Date)) return false;
                if (!DeepComparable.IsExactly(Application, otherT.Application)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Type != null) yield return Type;
                    if (Date != null) yield return Date;
                    foreach (var elem in Application) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Date != null) yield return new ElementValue("date", Date);
                    foreach (var elem in Application) { if (elem != null) yield return new ElementValue("application", elem); }
                }
            }


        }


        /// <summary>
        /// Business identifier for the marketing authorization, as assigned by a regulator
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
        /// The medicinal product that is being authorized
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=100)]
        [References("MedicinalProduct","MedicinalProductPackaged")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// The country in which the marketing authorization has been granted
        /// </summary>
        [FhirElement("country", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Country
        {
            get { if (_country==null) _country = new List<CodeableConcept>(); return _country; }
            set { _country = value; OnPropertyChanged("Country"); }
        }

        private List<CodeableConcept> _country;

        /// <summary>
        /// Jurisdiction within a country
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// The legal status of supply of the medicinal product as classified by the regulator
        /// </summary>
        [FhirElement("legalStatusOfSupply", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept LegalStatusOfSupply
        {
            get { return _legalStatusOfSupply; }
            set { _legalStatusOfSupply = value; OnPropertyChanged("LegalStatusOfSupply"); }
        }

        private CodeableConcept _legalStatusOfSupply;

        /// <summary>
        /// The status of the marketing authorization
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Status
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged("Status"); }
        }

        private CodeableConcept _status;

        /// <summary>
        /// The date at which the given status has become applicable
        /// </summary>
        [FhirElement("statusDate", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime StatusDateElement
        {
            get { return _statusDateElement; }
            set { _statusDateElement = value; OnPropertyChanged("StatusDateElement"); }
        }

        private FhirDateTime _statusDateElement;

        /// <summary>
        /// The date at which the given status has become applicable
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string StatusDate
        {
            get { return StatusDateElement != null ? StatusDateElement.Value : null; }
            set
            {
                if (value == null)
                    StatusDateElement = null;
                else
                    StatusDateElement = new FhirDateTime(value);
                OnPropertyChanged("StatusDate");
            }
        }

        /// <summary>
        /// The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored
        /// </summary>
        [FhirElement("restoreDate", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime RestoreDateElement
        {
            get { return _restoreDateElement; }
            set { _restoreDateElement = value; OnPropertyChanged("RestoreDateElement"); }
        }

        private FhirDateTime _restoreDateElement;

        /// <summary>
        /// The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RestoreDate
        {
            get { return RestoreDateElement != null ? RestoreDateElement.Value : null; }
            set
            {
                if (value == null)
                    RestoreDateElement = null;
                else
                    RestoreDateElement = new FhirDateTime(value);
                OnPropertyChanged("RestoreDate");
            }
        }

        /// <summary>
        /// The beginning of the time period in which the marketing authorization is in the specific status shall be specified A complete date consisting of day, month and year shall be specified using the ISO 8601 date format
        /// </summary>
        [FhirElement("validityPeriod", InSummary=true, Order=170)]
        [DataMember]
        public Period ValidityPeriod
        {
            get { return _validityPeriod; }
            set { _validityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
        }

        private Period _validityPeriod;

        /// <summary>
        /// A period of time after authorization before generic product applicatiosn can be submitted
        /// </summary>
        [FhirElement("dataExclusivityPeriod", InSummary=true, Order=180)]
        [DataMember]
        public Period DataExclusivityPeriod
        {
            get { return _dataExclusivityPeriod; }
            set { _dataExclusivityPeriod = value; OnPropertyChanged("DataExclusivityPeriod"); }
        }

        private Period _dataExclusivityPeriod;

        /// <summary>
        /// The date when the first authorization was granted by a Medicines Regulatory Agency
        /// </summary>
        [FhirElement("dateOfFirstAuthorization", InSummary=true, Order=190)]
        [DataMember]
        public FhirDateTime DateOfFirstAuthorizationElement
        {
            get { return _dateOfFirstAuthorizationElement; }
            set { _dateOfFirstAuthorizationElement = value; OnPropertyChanged("DateOfFirstAuthorizationElement"); }
        }

        private FhirDateTime _dateOfFirstAuthorizationElement;

        /// <summary>
        /// The date when the first authorization was granted by a Medicines Regulatory Agency
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateOfFirstAuthorization
        {
            get { return DateOfFirstAuthorizationElement != null ? DateOfFirstAuthorizationElement.Value : null; }
            set
            {
                if (value == null)
                    DateOfFirstAuthorizationElement = null;
                else
                    DateOfFirstAuthorizationElement = new FhirDateTime(value);
                OnPropertyChanged("DateOfFirstAuthorization");
            }
        }

        /// <summary>
        /// Date of first marketing authorization for a company's new medicinal product in any country in the World
        /// </summary>
        [FhirElement("internationalBirthDate", InSummary=true, Order=200)]
        [DataMember]
        public FhirDateTime InternationalBirthDateElement
        {
            get { return _internationalBirthDateElement; }
            set { _internationalBirthDateElement = value; OnPropertyChanged("InternationalBirthDateElement"); }
        }

        private FhirDateTime _internationalBirthDateElement;

        /// <summary>
        /// Date of first marketing authorization for a company's new medicinal product in any country in the World
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string InternationalBirthDate
        {
            get { return InternationalBirthDateElement != null ? InternationalBirthDateElement.Value : null; }
            set
            {
                if (value == null)
                    InternationalBirthDateElement = null;
                else
                    InternationalBirthDateElement = new FhirDateTime(value);
                OnPropertyChanged("InternationalBirthDate");
            }
        }

        /// <summary>
        /// The legal framework against which this authorization is granted
        /// </summary>
        [FhirElement("legalBasis", InSummary=true, Order=210)]
        [DataMember]
        public CodeableConcept LegalBasis
        {
            get { return _legalBasis; }
            set { _legalBasis = value; OnPropertyChanged("LegalBasis"); }
        }

        private CodeableConcept _legalBasis;

        /// <summary>
        /// Authorization in areas within a country
        /// </summary>
        [FhirElement("jurisdictionalAuthorization", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<JurisdictionalAuthorizationComponent> JurisdictionalAuthorization
        {
            get { if (_jurisdictionalAuthorization==null) _jurisdictionalAuthorization = new List<JurisdictionalAuthorizationComponent>(); return _jurisdictionalAuthorization; }
            set { _jurisdictionalAuthorization = value; OnPropertyChanged("JurisdictionalAuthorization"); }
        }

        private List<JurisdictionalAuthorizationComponent> _jurisdictionalAuthorization;

        /// <summary>
        /// Marketing Authorization Holder
        /// </summary>
        [FhirElement("holder", InSummary=true, Order=230)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Holder
        {
            get { return _holder; }
            set { _holder = value; OnPropertyChanged("Holder"); }
        }

        private ResourceReference _holder;

        /// <summary>
        /// Medicines Regulatory Agency
        /// </summary>
        [FhirElement("regulator", InSummary=true, Order=240)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Regulator
        {
            get { return _regulator; }
            set { _regulator = value; OnPropertyChanged("Regulator"); }
        }

        private ResourceReference _regulator;

        /// <summary>
        /// The regulatory procedure for granting or amending a marketing authorization
        /// </summary>
        [FhirElement("procedure", InSummary=true, Order=250)]
        [DataMember]
        public ProcedureComponent Procedure
        {
            get { return _procedure; }
            set { _procedure = value; OnPropertyChanged("Procedure"); }
        }

        private ProcedureComponent _procedure;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductAuthorization;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Country != null) dest.Country = new List<CodeableConcept>(Country.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (LegalStatusOfSupply != null) dest.LegalStatusOfSupply = (CodeableConcept)LegalStatusOfSupply.DeepCopy();
                if (Status != null) dest.Status = (CodeableConcept)Status.DeepCopy();
                if (StatusDateElement != null) dest.StatusDateElement = (FhirDateTime)StatusDateElement.DeepCopy();
                if (RestoreDateElement != null) dest.RestoreDateElement = (FhirDateTime)RestoreDateElement.DeepCopy();
                if (ValidityPeriod != null) dest.ValidityPeriod = (Period)ValidityPeriod.DeepCopy();
                if (DataExclusivityPeriod != null) dest.DataExclusivityPeriod = (Period)DataExclusivityPeriod.DeepCopy();
                if (DateOfFirstAuthorizationElement != null) dest.DateOfFirstAuthorizationElement = (FhirDateTime)DateOfFirstAuthorizationElement.DeepCopy();
                if (InternationalBirthDateElement != null) dest.InternationalBirthDateElement = (FhirDateTime)InternationalBirthDateElement.DeepCopy();
                if (LegalBasis != null) dest.LegalBasis = (CodeableConcept)LegalBasis.DeepCopy();
                if (JurisdictionalAuthorization != null) dest.JurisdictionalAuthorization = new List<JurisdictionalAuthorizationComponent>(JurisdictionalAuthorization.DeepCopy());
                if (Holder != null) dest.Holder = (ResourceReference)Holder.DeepCopy();
                if (Regulator != null) dest.Regulator = (ResourceReference)Regulator.DeepCopy();
                if (Procedure != null) dest.Procedure = (ProcedureComponent)Procedure.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProductAuthorization());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductAuthorization;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(Country, otherT.Country)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            if (!DeepComparable.Matches(Status, otherT.Status)) return false;
            if (!DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.Matches(RestoreDateElement, otherT.RestoreDateElement)) return false;
            if (!DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
            if (!DeepComparable.Matches(DataExclusivityPeriod, otherT.DataExclusivityPeriod)) return false;
            if (!DeepComparable.Matches(DateOfFirstAuthorizationElement, otherT.DateOfFirstAuthorizationElement)) return false;
            if (!DeepComparable.Matches(InternationalBirthDateElement, otherT.InternationalBirthDateElement)) return false;
            if (!DeepComparable.Matches(LegalBasis, otherT.LegalBasis)) return false;
            if ( !DeepComparable.Matches(JurisdictionalAuthorization, otherT.JurisdictionalAuthorization)) return false;
            if (!DeepComparable.Matches(Holder, otherT.Holder)) return false;
            if (!DeepComparable.Matches(Regulator, otherT.Regulator)) return false;
            if (!DeepComparable.Matches(Procedure, otherT.Procedure)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductAuthorization;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Country, otherT.Country)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            if (!DeepComparable.IsExactly(Status, otherT.Status)) return false;
            if (!DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.IsExactly(RestoreDateElement, otherT.RestoreDateElement)) return false;
            if (!DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
            if (!DeepComparable.IsExactly(DataExclusivityPeriod, otherT.DataExclusivityPeriod)) return false;
            if (!DeepComparable.IsExactly(DateOfFirstAuthorizationElement, otherT.DateOfFirstAuthorizationElement)) return false;
            if (!DeepComparable.IsExactly(InternationalBirthDateElement, otherT.InternationalBirthDateElement)) return false;
            if (!DeepComparable.IsExactly(LegalBasis, otherT.LegalBasis)) return false;
            if (!DeepComparable.IsExactly(JurisdictionalAuthorization, otherT.JurisdictionalAuthorization)) return false;
            if (!DeepComparable.IsExactly(Holder, otherT.Holder)) return false;
            if (!DeepComparable.IsExactly(Regulator, otherT.Regulator)) return false;
            if (!DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                foreach (var elem in Country) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (LegalStatusOfSupply != null) yield return LegalStatusOfSupply;
                if (Status != null) yield return Status;
                if (StatusDateElement != null) yield return StatusDateElement;
                if (RestoreDateElement != null) yield return RestoreDateElement;
                if (ValidityPeriod != null) yield return ValidityPeriod;
                if (DataExclusivityPeriod != null) yield return DataExclusivityPeriod;
                if (DateOfFirstAuthorizationElement != null) yield return DateOfFirstAuthorizationElement;
                if (InternationalBirthDateElement != null) yield return InternationalBirthDateElement;
                if (LegalBasis != null) yield return LegalBasis;
                foreach (var elem in JurisdictionalAuthorization) { if (elem != null) yield return elem; }
                if (Holder != null) yield return Holder;
                if (Regulator != null) yield return Regulator;
                if (Procedure != null) yield return Procedure;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                foreach (var elem in Country) { if (elem != null) yield return new ElementValue("country", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (LegalStatusOfSupply != null) yield return new ElementValue("legalStatusOfSupply", LegalStatusOfSupply);
                if (Status != null) yield return new ElementValue("status", Status);
                if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
                if (RestoreDateElement != null) yield return new ElementValue("restoreDate", RestoreDateElement);
                if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", ValidityPeriod);
                if (DataExclusivityPeriod != null) yield return new ElementValue("dataExclusivityPeriod", DataExclusivityPeriod);
                if (DateOfFirstAuthorizationElement != null) yield return new ElementValue("dateOfFirstAuthorization", DateOfFirstAuthorizationElement);
                if (InternationalBirthDateElement != null) yield return new ElementValue("internationalBirthDate", InternationalBirthDateElement);
                if (LegalBasis != null) yield return new ElementValue("legalBasis", LegalBasis);
                foreach (var elem in JurisdictionalAuthorization) { if (elem != null) yield return new ElementValue("jurisdictionalAuthorization", elem); }
                if (Holder != null) yield return new ElementValue("holder", Holder);
                if (Regulator != null) yield return new ElementValue("regulator", Regulator);
                if (Procedure != null) yield return new ElementValue("procedure", Procedure);
            }
        }

    }

}
