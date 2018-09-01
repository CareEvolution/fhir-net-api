﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Defines an expected trigger for a module
    /// </summary>
    [FhirType("TriggerDefinition")]
    [DataContract]
    public partial class TriggerDefinition : Element
    {
        [NotMapped]
        public override string TypeName { get { return "TriggerDefinition"; } }

        /// <summary>
        /// The type of trigger.
        /// (url: http://hl7.org/fhir/ValueSet/trigger-type)
        /// </summary>
        [FhirEnumeration("TriggerType")]
        public enum TriggerType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("named-event", "http://hl7.org/fhir/trigger-type"), Description("Named Event")]
            NamedEvent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("periodic", "http://hl7.org/fhir/trigger-type"), Description("Periodic")]
            Periodic,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("data-changed", "http://hl7.org/fhir/trigger-type"), Description("Data Changed")]
            DataChanged,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("data-added", "http://hl7.org/fhir/trigger-type"), Description("Data Added")]
            DataAdded,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("data-modified", "http://hl7.org/fhir/trigger-type"), Description("Data Updated")]
            DataModified,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("data-removed", "http://hl7.org/fhir/trigger-type"), Description("Data Removed")]
            DataRemoved,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("data-accessed", "http://hl7.org/fhir/trigger-type"), Description("Data Accessed")]
            DataAccessed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/trigger-type)
            /// </summary>
            [EnumLiteral("data-access-ended", "http://hl7.org/fhir/trigger-type"), Description("Data Access Ended")]
            DataAccessEnded,
        }


        /// <summary>
        /// named-event | periodic | data-changed | data-added | data-modified | data-removed | data-accessed | data-access-ended
        /// </summary>
        [FhirElement("type", InSummary=true, Order=30)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<TriggerType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<TriggerType> _typeElement;

        /// <summary>
        /// named-event | periodic | data-changed | data-added | data-modified | data-removed | data-accessed | data-access-ended
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public TriggerType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<TriggerType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Name or URI that identifies the event
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
        /// Name or URI that identifies the event
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
        /// Timing of the event
        /// </summary>
        [FhirElement("timing", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Timing),typeof(ResourceReference),typeof(Date),typeof(FhirDateTime))]
        [DataMember]
        public Element Timing
        {
            get { return _timing; }
            set { _timing = value; OnPropertyChanged("Timing"); }
        }

        private Element _timing;

        /// <summary>
        /// Triggering data of the event
        /// </summary>
        [FhirElement("data", InSummary=true, Order=60)]
        [DataMember]
        public DataRequirement Data
        {
            get { return _data; }
            set { _data = value; OnPropertyChanged("Data"); }
        }

        private DataRequirement _data;

        /// <summary>
        /// Whether the event triggers (boolean expression)
        /// </summary>
        [FhirElement("condition", InSummary=true, Order=70)]
        [DataMember]
        public Expression Condition
        {
            get { return _condition; }
            set { _condition = value; OnPropertyChanged("Condition"); }
        }

        private Expression _condition;


        public static ElementDefinition.ConstraintComponent TriggerDefinition_TRD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "condition.exists() implies data.exists()",
            Key = "trd-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A condition only if there is a data requirement",
            Xpath = "not(exists(f:condition)) or exists(f:data)"
        };

        public static ElementDefinition.ConstraintComponent TriggerDefinition_TRD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "data.empty() or timing.empty()",
            Key = "trd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either timing, or a data requirement, but not both",
            Xpath = "not(exists(f:data)) or not(exists(*[starts-with(local-name(.), 'timing')]))"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as TriggerDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<TriggerType>)TypeElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                if (Data != null) dest.Data = (DataRequirement)Data.DeepCopy();
                if (Condition != null) dest.Condition = (Expression)Condition.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new TriggerDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as TriggerDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if (!DeepComparable.Matches(Data, otherT.Data)) return false;
            if (!DeepComparable.Matches(Condition, otherT.Condition)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TriggerDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if (!DeepComparable.IsExactly(Data, otherT.Data)) return false;
            if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (TypeElement != null) yield return TypeElement;
                if (NameElement != null) yield return NameElement;
                if (Timing != null) yield return Timing;
                if (Data != null) yield return Data;
                if (Condition != null) yield return Condition;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (Timing != null) yield return new ElementValue("timing", Timing);
                if (Data != null) yield return new ElementValue("data", Data);
                if (Condition != null) yield return new ElementValue("condition", Condition);
            }
        }

    }

}
