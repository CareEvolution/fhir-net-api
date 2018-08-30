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
    /// Describes the results of a TestScript execution
    /// </summary>
    [FhirType("TestReport", IsResource=true)]
    [DataContract]
    public partial class TestReport : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.TestReport; } }
        [NotMapped]
        public override string TypeName { get { return "TestReport"; } }

        /// <summary>
        /// The current status of the test report.
        /// (url: http://hl7.org/fhir/ValueSet/report-status-codes)
        /// </summary>
        [FhirEnumeration("TestReportStatus")]
        public enum TestReportStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-status-codes)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/report-status-codes"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-status-codes)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/report-status-codes"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-status-codes)
            /// </summary>
            [EnumLiteral("waiting", "http://hl7.org/fhir/report-status-codes"), Description("Waiting")]
            Waiting,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-status-codes)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/report-status-codes"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-status-codes)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/report-status-codes"), Description("Entered In Error")]
            EnteredInError,
        }

        /// <summary>
        /// The reported execution result.
        /// (url: http://hl7.org/fhir/ValueSet/report-result-codes)
        /// </summary>
        [FhirEnumeration("TestReportResult")]
        public enum TestReportResult
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-result-codes)
            /// </summary>
            [EnumLiteral("pass", "http://hl7.org/fhir/report-result-codes"), Description("Pass")]
            Pass,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-result-codes)
            /// </summary>
            [EnumLiteral("fail", "http://hl7.org/fhir/report-result-codes"), Description("Fail")]
            Fail,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-result-codes)
            /// </summary>
            [EnumLiteral("pending", "http://hl7.org/fhir/report-result-codes"), Description("Pending")]
            Pending,
        }

        /// <summary>
        /// The type of participant.
        /// (url: http://hl7.org/fhir/ValueSet/report-participant-type)
        /// </summary>
        [FhirEnumeration("TestReportParticipantType")]
        public enum TestReportParticipantType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-participant-type)
            /// </summary>
            [EnumLiteral("test-engine", "http://hl7.org/fhir/report-participant-type"), Description("Test Engine")]
            TestEngine,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-participant-type)
            /// </summary>
            [EnumLiteral("client", "http://hl7.org/fhir/report-participant-type"), Description("Client")]
            Client,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-participant-type)
            /// </summary>
            [EnumLiteral("server", "http://hl7.org/fhir/report-participant-type"), Description("Server")]
            Server,
        }

        /// <summary>
        /// The results of executing an action.
        /// (url: http://hl7.org/fhir/ValueSet/report-action-result-codes)
        /// </summary>
        [FhirEnumeration("TestReportActionResult")]
        public enum TestReportActionResult
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-action-result-codes)
            /// </summary>
            [EnumLiteral("pass", "http://hl7.org/fhir/report-action-result-codes"), Description("Pass")]
            Pass,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-action-result-codes)
            /// </summary>
            [EnumLiteral("skip", "http://hl7.org/fhir/report-action-result-codes"), Description("Skip")]
            Skip,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-action-result-codes)
            /// </summary>
            [EnumLiteral("fail", "http://hl7.org/fhir/report-action-result-codes"), Description("Fail")]
            Fail,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-action-result-codes)
            /// </summary>
            [EnumLiteral("warning", "http://hl7.org/fhir/report-action-result-codes"), Description("Warning")]
            Warning,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/report-action-result-codes)
            /// </summary>
            [EnumLiteral("error", "http://hl7.org/fhir/report-action-result-codes"), Description("Error")]
            Error,
        }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// test-engine | client | server
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<TestReportParticipantType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<TestReportParticipantType> _typeElement;

            /// <summary>
            /// test-engine | client | server
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public TestReportParticipantType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<TestReportParticipantType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// The uri of the participant. An absolute URL is preferred
            /// </summary>
            [FhirElement("uri", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private FhirUri _uriElement;

            /// <summary>
            /// The uri of the participant. An absolute URL is preferred
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }

            /// <summary>
            /// The display name of the participant
            /// </summary>
            [FhirElement("display", Order=60)]
            [DataMember]
            public FhirString DisplayElement
            {
                get { return _displayElement; }
                set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
            }

            private FhirString _displayElement;

            /// <summary>
            /// The display name of the participant
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if (value == null)
                        DisplayElement = null;
                    else
                        DisplayElement = new FhirString(value);
                    OnPropertyChanged("Display");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<TestReportParticipantType>)TypeElement.DeepCopy();
                    if (UriElement != null) dest.UriElement = (FhirUri)UriElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (UriElement != null) yield return UriElement;
                    if (DisplayElement != null) yield return DisplayElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
                }
            }


        }


        [FhirType("SetupComponent")]
        [DataContract]
        public partial class SetupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SetupComponent"; } }

            /// <summary>
            /// A setup operation or assert that was executed
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<SetupActionComponent> Action
            {
                get { if (_action==null) _action = new List<SetupActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<SetupActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = new List<SetupActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SetupComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("SetupActionComponent")]
        [DataContract]
        public partial class SetupActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SetupActionComponent"; } }

            /// <summary>
            /// The operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// The assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public AssertComponent Assert
            {
                get { return _assert; }
                set { _assert = value; OnPropertyChanged("Assert"); }
            }

            private AssertComponent _assert;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Assert != null) dest.Assert = (AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SetupActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Assert, otherT.Assert)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Assert, otherT.Assert)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                    if (Assert != null) yield return Assert;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Assert != null) yield return new ElementValue("assert", Assert);
                }
            }


        }


        [FhirType("OperationComponent")]
        [DataContract]
        public partial class OperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OperationComponent"; } }

            /// <summary>
            /// pass | skip | fail | warning | error
            /// </summary>
            [FhirElement("result", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<TestReportActionResult> ResultElement
            {
                get { return _resultElement; }
                set { _resultElement = value; OnPropertyChanged("ResultElement"); }
            }

            private Code<TestReportActionResult> _resultElement;

            /// <summary>
            /// pass | skip | fail | warning | error
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public TestReportActionResult? Result
            {
                get { return ResultElement != null ? ResultElement.Value : null; }
                set
                {
                    if (value == null)
                        ResultElement = null;
                    else
                        ResultElement = new Code<TestReportActionResult>(value);
                    OnPropertyChanged("Result");
                }
            }

            /// <summary>
            /// A message associated with the result
            /// </summary>
            [FhirElement("message", Order=50)]
            [DataMember]
            public Markdown Message
            {
                get { return _message; }
                set { _message = value; OnPropertyChanged("Message"); }
            }

            private Markdown _message;

            /// <summary>
            /// A link to further details on the result
            /// </summary>
            [FhirElement("detail", Order=60)]
            [DataMember]
            public FhirUri DetailElement
            {
                get { return _detailElement; }
                set { _detailElement = value; OnPropertyChanged("DetailElement"); }
            }

            private FhirUri _detailElement;

            /// <summary>
            /// A link to further details on the result
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Detail
            {
                get { return DetailElement != null ? DetailElement.Value : null; }
                set
                {
                    if (value == null)
                        DetailElement = null;
                    else
                        DetailElement = new FhirUri(value);
                    OnPropertyChanged("Detail");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ResultElement != null) dest.ResultElement = (Code<TestReportActionResult>)ResultElement.DeepCopy();
                    if (Message != null) dest.Message = (Markdown)Message.DeepCopy();
                    if (DetailElement != null) dest.DetailElement = (FhirUri)DetailElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ResultElement, otherT.ResultElement)) return false;
                if (!DeepComparable.Matches(Message, otherT.Message)) return false;
                if (!DeepComparable.Matches(DetailElement, otherT.DetailElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ResultElement, otherT.ResultElement)) return false;
                if (!DeepComparable.IsExactly(Message, otherT.Message)) return false;
                if (!DeepComparable.IsExactly(DetailElement, otherT.DetailElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ResultElement != null) yield return ResultElement;
                    if (Message != null) yield return Message;
                    if (DetailElement != null) yield return DetailElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ResultElement != null) yield return new ElementValue("result", ResultElement);
                    if (Message != null) yield return new ElementValue("message", Message);
                    if (DetailElement != null) yield return new ElementValue("detail", DetailElement);
                }
            }


        }


        [FhirType("AssertComponent")]
        [DataContract]
        public partial class AssertComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AssertComponent"; } }

            /// <summary>
            /// pass | skip | fail | warning | error
            /// </summary>
            [FhirElement("result", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<TestReportActionResult> ResultElement
            {
                get { return _resultElement; }
                set { _resultElement = value; OnPropertyChanged("ResultElement"); }
            }

            private Code<TestReportActionResult> _resultElement;

            /// <summary>
            /// pass | skip | fail | warning | error
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public TestReportActionResult? Result
            {
                get { return ResultElement != null ? ResultElement.Value : null; }
                set
                {
                    if (value == null)
                        ResultElement = null;
                    else
                        ResultElement = new Code<TestReportActionResult>(value);
                    OnPropertyChanged("Result");
                }
            }

            /// <summary>
            /// A message associated with the result
            /// </summary>
            [FhirElement("message", Order=50)]
            [DataMember]
            public Markdown Message
            {
                get { return _message; }
                set { _message = value; OnPropertyChanged("Message"); }
            }

            private Markdown _message;

            /// <summary>
            /// A link to further details on the result
            /// </summary>
            [FhirElement("detail", Order=60)]
            [DataMember]
            public FhirString DetailElement
            {
                get { return _detailElement; }
                set { _detailElement = value; OnPropertyChanged("DetailElement"); }
            }

            private FhirString _detailElement;

            /// <summary>
            /// A link to further details on the result
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Detail
            {
                get { return DetailElement != null ? DetailElement.Value : null; }
                set
                {
                    if (value == null)
                        DetailElement = null;
                    else
                        DetailElement = new FhirString(value);
                    OnPropertyChanged("Detail");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AssertComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ResultElement != null) dest.ResultElement = (Code<TestReportActionResult>)ResultElement.DeepCopy();
                    if (Message != null) dest.Message = (Markdown)Message.DeepCopy();
                    if (DetailElement != null) dest.DetailElement = (FhirString)DetailElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AssertComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ResultElement, otherT.ResultElement)) return false;
                if (!DeepComparable.Matches(Message, otherT.Message)) return false;
                if (!DeepComparable.Matches(DetailElement, otherT.DetailElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ResultElement, otherT.ResultElement)) return false;
                if (!DeepComparable.IsExactly(Message, otherT.Message)) return false;
                if (!DeepComparable.IsExactly(DetailElement, otherT.DetailElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ResultElement != null) yield return ResultElement;
                    if (Message != null) yield return Message;
                    if (DetailElement != null) yield return DetailElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ResultElement != null) yield return new ElementValue("result", ResultElement);
                    if (Message != null) yield return new ElementValue("message", Message);
                    if (DetailElement != null) yield return new ElementValue("detail", DetailElement);
                }
            }


        }


        [FhirType("TestComponent")]
        [DataContract]
        public partial class TestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TestComponent"; } }

            /// <summary>
            /// Tracking/logging name of this test
            /// </summary>
            [FhirElement("name", Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Tracking/logging name of this test
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
            /// Tracking/reporting short description of the test
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
            /// Tracking/reporting short description of the test
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
            /// A test operation or assert that was performed
            /// </summary>
            [FhirElement("action", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<TestActionComponent> Action
            {
                get { if (_action==null) _action = new List<TestActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<TestActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Action != null) dest.Action = new List<TestActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("TestActionComponent")]
        [DataContract]
        public partial class TestActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TestActionComponent"; } }

            /// <summary>
            /// The operation performed
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// The assertion performed
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public AssertComponent Assert
            {
                get { return _assert; }
                set { _assert = value; OnPropertyChanged("Assert"); }
            }

            private AssertComponent _assert;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Assert != null) dest.Assert = (AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TestActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Assert, otherT.Assert)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Assert, otherT.Assert)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                    if (Assert != null) yield return Assert;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Assert != null) yield return new ElementValue("assert", Assert);
                }
            }


        }


        [FhirType("TeardownComponent")]
        [DataContract]
        public partial class TeardownComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownComponent"; } }

            /// <summary>
            /// One or more teardown operations performed
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<TeardownActionComponent> Action
            {
                get { if (_action==null) _action = new List<TeardownActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<TeardownActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = new List<TeardownActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TeardownComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("TeardownActionComponent")]
        [DataContract]
        public partial class TeardownActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownActionComponent"; } }

            /// <summary>
            /// The teardown operation performed
            /// </summary>
            [FhirElement("operation", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TeardownActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                }
            }


        }


        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Informal name of the executed TestScript
        /// </summary>
        [FhirElement("name", InSummary=true, Order=100)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Informal name of the executed TestScript
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
        /// completed | in-progress | waiting | stopped | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<TestReportStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<TestReportStatus> _statusElement;

        /// <summary>
        /// completed | in-progress | waiting | stopped | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public TestReportStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<TestReportStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Reference to the  version-specific TestScript that was executed to produce this TestReport
        /// </summary>
        [FhirElement("testScript", InSummary=true, Order=120)]
        [References("TestScript")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference TestScript
        {
            get { return _testScript; }
            set { _testScript = value; OnPropertyChanged("TestScript"); }
        }

        private ResourceReference _testScript;

        /// <summary>
        /// pass | fail | pending
        /// </summary>
        [FhirElement("result", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<TestReportResult> ResultElement
        {
            get { return _resultElement; }
            set { _resultElement = value; OnPropertyChanged("ResultElement"); }
        }

        private Code<TestReportResult> _resultElement;

        /// <summary>
        /// pass | fail | pending
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public TestReportResult? Result
        {
            get { return ResultElement != null ? ResultElement.Value : null; }
            set
            {
                if (value == null)
                    ResultElement = null;
                else
                    ResultElement = new Code<TestReportResult>(value);
                OnPropertyChanged("Result");
            }
        }

        /// <summary>
        /// The final score (percentage of tests passed) resulting from the execution of the TestScript
        /// </summary>
        [FhirElement("score", InSummary=true, Order=140)]
        [DataMember]
        public FhirDecimal ScoreElement
        {
            get { return _scoreElement; }
            set { _scoreElement = value; OnPropertyChanged("ScoreElement"); }
        }

        private FhirDecimal _scoreElement;

        /// <summary>
        /// The final score (percentage of tests passed) resulting from the execution of the TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public decimal? Score
        {
            get { return ScoreElement != null ? ScoreElement.Value : null; }
            set
            {
                if (value == null)
                    ScoreElement = null;
                else
                    ScoreElement = new FhirDecimal(value);
                OnPropertyChanged("Score");
            }
        }

        /// <summary>
        /// Name of the tester producing this report (Organization or individual)
        /// </summary>
        [FhirElement("tester", InSummary=true, Order=150)]
        [DataMember]
        public FhirString TesterElement
        {
            get { return _testerElement; }
            set { _testerElement = value; OnPropertyChanged("TesterElement"); }
        }

        private FhirString _testerElement;

        /// <summary>
        /// Name of the tester producing this report (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Tester
        {
            get { return TesterElement != null ? TesterElement.Value : null; }
            set
            {
                if (value == null)
                    TesterElement = null;
                else
                    TesterElement = new FhirString(value);
                OnPropertyChanged("Tester");
            }
        }

        /// <summary>
        /// When the TestScript was executed and this TestReport was generated
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private FhirDateTime _issuedElement;

        /// <summary>
        /// When the TestScript was executed and this TestReport was generated
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
        /// A participant in the test execution, either the execution engine, a client, or a server
        /// </summary>
        [FhirElement("participant", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// The results of the series of required setup operations before the tests were executed
        /// </summary>
        [FhirElement("setup", Order=180)]
        [DataMember]
        public SetupComponent Setup
        {
            get { return _setup; }
            set { _setup = value; OnPropertyChanged("Setup"); }
        }

        private SetupComponent _setup;

        /// <summary>
        /// A test executed from the test script
        /// </summary>
        [FhirElement("test", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TestComponent> Test
        {
            get { if (_test==null) _test = new List<TestComponent>(); return _test; }
            set { _test = value; OnPropertyChanged("Test"); }
        }

        private List<TestComponent> _test;

        /// <summary>
        /// The results of running the series of required clean up steps
        /// </summary>
        [FhirElement("teardown", Order=200)]
        [DataMember]
        public TeardownComponent Teardown
        {
            get { return _teardown; }
            set { _teardown = value; OnPropertyChanged("Teardown"); }
        }

        private TeardownComponent _teardown;


        public static ElementDefinition.ConstraintComponent TestReport_INV_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.all(operation.exists() xor assert.exists())",
            Key = "inv-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup action SHALL contain either an operation or assert but not both.",
            Xpath = "(f:operation or f:assert) and not(f:operation and f:assert)"
        };

        public static ElementDefinition.ConstraintComponent TestReport_INV_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.all(operation.exists() xor assert.exists())",
            Key = "inv-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test action SHALL contain either an operation or assert but not both.",
            Xpath = "(f:operation or f:assert) and not(f:operation and f:assert)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(TestReport_INV_1);
            InvariantConstraints.Add(TestReport_INV_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as TestReport;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<TestReportStatus>)StatusElement.DeepCopy();
                if (TestScript != null) dest.TestScript = (ResourceReference)TestScript.DeepCopy();
                if (ResultElement != null) dest.ResultElement = (Code<TestReportResult>)ResultElement.DeepCopy();
                if (ScoreElement != null) dest.ScoreElement = (FhirDecimal)ScoreElement.DeepCopy();
                if (TesterElement != null) dest.TesterElement = (FhirString)TesterElement.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (Setup != null) dest.Setup = (SetupComponent)Setup.DeepCopy();
                if (Test != null) dest.Test = new List<TestComponent>(Test.DeepCopy());
                if (Teardown != null) dest.Teardown = (TeardownComponent)Teardown.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new TestReport());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as TestReport;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(TestScript, otherT.TestScript)) return false;
            if (!DeepComparable.Matches(ResultElement, otherT.ResultElement)) return false;
            if (!DeepComparable.Matches(ScoreElement, otherT.ScoreElement)) return false;
            if (!DeepComparable.Matches(TesterElement, otherT.TesterElement)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if (!DeepComparable.Matches(Setup, otherT.Setup)) return false;
            if ( !DeepComparable.Matches(Test, otherT.Test)) return false;
            if (!DeepComparable.Matches(Teardown, otherT.Teardown)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TestReport;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(TestScript, otherT.TestScript)) return false;
            if (!DeepComparable.IsExactly(ResultElement, otherT.ResultElement)) return false;
            if (!DeepComparable.IsExactly(ScoreElement, otherT.ScoreElement)) return false;
            if (!DeepComparable.IsExactly(TesterElement, otherT.TesterElement)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(Setup, otherT.Setup)) return false;
            if (!DeepComparable.IsExactly(Test, otherT.Test)) return false;
            if (!DeepComparable.IsExactly(Teardown, otherT.Teardown)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (TestScript != null) yield return TestScript;
                if (ResultElement != null) yield return ResultElement;
                if (ScoreElement != null) yield return ScoreElement;
                if (TesterElement != null) yield return TesterElement;
                if (IssuedElement != null) yield return IssuedElement;
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                if (Setup != null) yield return Setup;
                foreach (var elem in Test) { if (elem != null) yield return elem; }
                if (Teardown != null) yield return Teardown;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (TestScript != null) yield return new ElementValue("testScript", TestScript);
                if (ResultElement != null) yield return new ElementValue("result", ResultElement);
                if (ScoreElement != null) yield return new ElementValue("score", ScoreElement);
                if (TesterElement != null) yield return new ElementValue("tester", TesterElement);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                if (Setup != null) yield return new ElementValue("setup", Setup);
                foreach (var elem in Test) { if (elem != null) yield return new ElementValue("test", elem); }
                if (Teardown != null) yield return new ElementValue("teardown", Teardown);
            }
        }

    }

}
