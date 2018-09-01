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
    /// Details of a Technology mediated contact point (phone, fax, email, etc.)
    /// </summary>
    [FhirType("ContactPoint")]
    [DataContract]
    public partial class ContactPoint : Element
    {
        [NotMapped]
        public override string TypeName { get { return "ContactPoint"; } }

        /// <summary>
        /// Telecommunications form for contact point
        /// (url: http://hl7.org/fhir/ValueSet/contact-point-system)
        /// </summary>
        [FhirEnumeration("ContactPointSystem")]
        public enum ContactPointSystem
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("phone", "http://hl7.org/fhir/contact-point-system"), Description("Phone")]
            Phone,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("fax", "http://hl7.org/fhir/contact-point-system"), Description("Fax")]
            Fax,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("email", "http://hl7.org/fhir/contact-point-system"), Description("Email")]
            Email,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("pager", "http://hl7.org/fhir/contact-point-system"), Description("Pager")]
            Pager,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("url", "http://hl7.org/fhir/contact-point-system"), Description("URL")]
            Url,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("sms", "http://hl7.org/fhir/contact-point-system"), Description("SMS")]
            Sms,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/contact-point-system"), Description("Other")]
            Other,
        }

        /// <summary>
        /// Use of contact point
        /// (url: http://hl7.org/fhir/ValueSet/contact-point-use)
        /// </summary>
        [FhirEnumeration("ContactPointUse")]
        public enum ContactPointUse
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("home", "http://hl7.org/fhir/contact-point-use"), Description("Home")]
            Home,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("work", "http://hl7.org/fhir/contact-point-use"), Description("Work")]
            Work,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("temp", "http://hl7.org/fhir/contact-point-use"), Description("Temp")]
            Temp,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("old", "http://hl7.org/fhir/contact-point-use"), Description("Old")]
            Old,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("mobile", "http://hl7.org/fhir/contact-point-use"), Description("Mobile")]
            Mobile,
        }


        /// <summary>
        /// phone | fax | email | pager | url | sms | other
        /// </summary>
        [FhirElement("system", InSummary=true, Order=30)]
        [DataMember]
        public Code<ContactPointSystem> SystemElement
        {
            get { return _systemElement; }
            set { _systemElement = value; OnPropertyChanged("SystemElement"); }
        }

        private Code<ContactPointSystem> _systemElement;

        /// <summary>
        /// phone | fax | email | pager | url | sms | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ContactPointSystem? System
        {
            get { return SystemElement != null ? SystemElement.Value : null; }
            set
            {
                if (value == null)
                    SystemElement = null;
                else
                    SystemElement = new Code<ContactPointSystem>(value);
                OnPropertyChanged("System");
            }
        }

        /// <summary>
        /// The actual contact point details
        /// </summary>
        [FhirElement("value", InSummary=true, Order=40)]
        [DataMember]
        public FhirString ValueElement
        {
            get { return _valueElement; }
            set { _valueElement = value; OnPropertyChanged("ValueElement"); }
        }

        private FhirString _valueElement;

        /// <summary>
        /// The actual contact point details
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
        /// home | work | temp | old | mobile - purpose of this contact point
        /// </summary>
        [FhirElement("use", InSummary=true, Order=50)]
        [DataMember]
        public Code<ContactPointUse> UseElement
        {
            get { return _useElement; }
            set { _useElement = value; OnPropertyChanged("UseElement"); }
        }

        private Code<ContactPointUse> _useElement;

        /// <summary>
        /// home | work | temp | old | mobile - purpose of this contact point
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ContactPointUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (value == null)
                    UseElement = null;
                else
                    UseElement = new Code<ContactPointUse>(value);
                OnPropertyChanged("Use");
            }
        }

        /// <summary>
        /// Specify preferred order of use (1 = highest)
        /// </summary>
        [FhirElement("rank", InSummary=true, Order=60)]
        [DataMember]
        public PositiveInt RankElement
        {
            get { return _rankElement; }
            set { _rankElement = value; OnPropertyChanged("RankElement"); }
        }

        private PositiveInt _rankElement;

        /// <summary>
        /// Specify preferred order of use (1 = highest)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Rank
        {
            get { return RankElement != null ? RankElement.Value : null; }
            set
            {
                if (value == null)
                    RankElement = null;
                else
                    RankElement = new PositiveInt(value);
                OnPropertyChanged("Rank");
            }
        }

        /// <summary>
        /// Time period when the contact point was/is in use
        /// </summary>
        [FhirElement("period", InSummary=true, Order=70)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;


        public static ElementDefinition.ConstraintComponent ContactPoint_CPT_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "value.empty() or system.exists()",
            Key = "cpt-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A system is required if a value is provided.",
            Xpath = "not(exists(f:value)) or exists(f:system)"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ContactPoint;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (SystemElement != null) dest.SystemElement = (Code<ContactPointSystem>)SystemElement.DeepCopy();
                if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                if (UseElement != null) dest.UseElement = (Code<ContactPointUse>)UseElement.DeepCopy();
                if (RankElement != null) dest.RankElement = (PositiveInt)RankElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ContactPoint());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ContactPoint;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.Matches(RankElement, otherT.RankElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ContactPoint;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.IsExactly(RankElement, otherT.RankElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (SystemElement != null) yield return SystemElement;
                if (ValueElement != null) yield return ValueElement;
                if (UseElement != null) yield return UseElement;
                if (RankElement != null) yield return RankElement;
                if (Period != null) yield return Period;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                if (UseElement != null) yield return new ElementValue("use", UseElement);
                if (RankElement != null) yield return new ElementValue("rank", RankElement);
                if (Period != null) yield return new ElementValue("period", Period);
            }
        }

    }

}
