using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.Serialization
{
    public class SerializerSinkException : Exception
    {
        public SerializerSinkException(string message) : base(message)
        {}
    }

    internal abstract class SerializerSink
    {
        public SerializerSink(Model.Version version, Rest.SummaryType summary, IEnumerable<string> elements)
        {
            if (summary != Rest.SummaryType.False && elements != null) throw new ArgumentException("Must be null when specifying a non-False summary value", nameof(elements));
            _version = version;
            _summary = summary;
            _elements = elements == null ?
                null :
                new HashSet<string>(elements);
        }

        /// <summary>
        /// Serialize a Meta data type value - requires its own special method to output the SUBSETTED tags when summarizing
        /// </summary>
        /// <param name="meta">The Meta value to serialize</param>
        public void Serialize(Meta meta)
        {
            var isSubsetted = _summary != Rest.SummaryType.False
                || _elements != null;
            var isBundleRoot = _currentStateIndex == 0 
                && _states[0].Kind == StateKind.DataType 
                && _states[0].Type == "Bundle";
            if (!isSubsetted || isBundleRoot)
            {
                meta?.Serialize(this);
            }
            else
            {
                var observationValueSystem = _version == Model.Version.DSTU2 || _version == Model.Version.STU3 ?
                    OldObservationValueSystem :
                    ObservationValueSystem;
                var subsettedMeta = meta == null ?
                    new Meta() :
                    (Meta)meta.DeepCopy();
                if (!subsettedMeta.Tag.Any(t => t.System == observationValueSystem && t.Code == ObservationValueCodeSubsetted))
                {
                    var subsettedTag = new Coding(observationValueSystem, ObservationValueCodeSubsetted);
                    subsettedMeta.Tag.Add(subsettedTag);
                }
                subsettedMeta.Serialize(this);
            }
        }

        /// <summary>
        /// Describe an element within a resource or data type - it is followed by a call to BeginDataType or BeginResource or Serialize(Primitive)
        /// with the element content
        /// </summary>
        /// <param name="name">Name of the element</param>
        /// <param name="elementVersions">FHIR versions the element belongs to</param>
        /// <param name="summaryVersions">FHIR versions for which the element is part of the summary</param>
        /// <param name="isRequired">True if the element is required - ie min. cardinality 1</param>
        /// <param name="isChoice">True if the element is a type choice one - ie supporting values of different type - eg. Observation.value[x].
        /// Note that is such cases the name is just the prefix part - eg value</param>
        public void Element(string name, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false, bool isChoice = false)
        {
            ref var currentState = ref GetCurrentState();
            if (currentState.Kind == StateKind.None)
            {
                throw new SerializerSinkException("Missing call to BeginResource(), BeginDataType() or BeginList()");
            }
            if (ShouldSkip(name, elementVersions, summaryVersions, isRequired))
            {
                currentState.SetSkipElement();
            }
            else
            {
                currentState.SetActualElement( name, isChoice );
            }
        }

        /// <summary>
        /// Begin of a data type - eg HumanName
        /// </summary>
        /// <param name="type">The data type</param>
        public void BeginDataType(string type)
        {
            BeginDataTypePrimitive(type, false);
        }

        /// <summary>
        /// Begin of a resource - eg Patient
        /// </summary>
        /// <param name="type">The resource type</param>
        public void BeginResource(string type)
        {
            ref var currentState = ref GetCurrentState();
            if (currentState.Kind == StateKind.None)
            {
                PushState().DataTypeState(type, name: null);
            }
            else
            {
                var elementName = currentState.GetElementName(type, isResource: true);
                if (elementName == null)
                {
                    PushState().SkipState();
                }
                else
                {
                    PushState().DataTypeState(type, elementName);
                }
            }
        }

        /// <summary>
        /// Begin of a list - eg Patient.name
        /// </summary>
        /// <param name="name">Name of the list element</param>
        /// <param name="elementVersions">FHIR versions the list element belongs to</param>
        /// <param name="summaryVersions">FHIR versions for which the list element is part of the summary</param>
        /// <param name="isRequired">True if the list element is required - ie min. cardinality 1</param>
        public void BeginList(string name, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            if (IsSkipping() || ShouldSkip(name, elementVersions, summaryVersions, isRequired))
            {
                PushState().SkipState();
            }
            else
            {
                PushState().ListState(name);
            }
        }

        /// <summary>
        /// Special elements with string value - used for Extension.url and Element.id that have special handling in XML
        /// </summary>
        /// <param name="name">Name of the element</param>
        /// <param name="value">Value of the element</param>
        /// <param name="elementVersions">FHIR versions the element belongs to</param>
        /// <param name="summaryVersions">FHIR versions for which the element is part of the summary</param>
        /// <param name="isRequired">True if the element is required - ie min. cardinality 1</param>
        public abstract void StringValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false);

        /// <summary>
        /// Special elements with XHTML value - used for Narrative.div that has special handling in XML
        /// </summary>
        /// <param name="name">Name of the element</param>
        /// <param name="value">Value of the element as a valid XHTML string</param>
        /// <param name="elementVersions">FHIR versions the element belongs to</param>
        /// <param name="summaryVersions">FHIR versions for which the element is part of the summary</param>
        /// <param name="isRequired">True if the element is required - ie min. cardinality 1</param>
        public abstract void XhtmlValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false);

        /// <summary>
        /// Primitive data type value - with a value and optional (sub)elements. Handled differently between JSON and XML
        /// </summary>
        /// <param name="primitive">The primitive data type value</param>
        public abstract void Serialize(Primitive primitive);

        /// <summary>
        /// List of primitive data type values - 
        /// handled specially in JSON so it requires it own separate method instead of simply calling Serialize(Primitive) in a loop
        /// </summary>
        /// <param name="primitives">The primitive data type values</param>
        public abstract void Serialize(IReadOnlyList<Primitive> primitives);

        /// <summary>
        /// End of a resource, data type or list
        /// </summary>
        public void End()
        {
            if (_currentStateIndex < 0)
            {
                throw new SerializerSinkException("Missing call to BeginResource(), BeginDataType() or BeginList()");
            }

            if (_currentStateIndex == 0 && _notRenderedStateIndex >= 0)
            {
                // No empty output
                RenderStates();
            }

            var renderedState = _notRenderedStateIndex == -1 ?
                ref _states[ _currentStateIndex ] :
                ref _noneState;
            if (_notRenderedStateIndex == _currentStateIndex)
            {
                _notRenderedStateIndex = -1;
            }
            _currentStateIndex--;

            if (renderedState.Kind != StateKind.None)
            {
                RenderEndState(ref renderedState);
            }
        }

        protected bool BeginDataTypePrimitive(string type, bool isPrimitiveType)
        {
            ref var currentState = ref GetCurrentState();
            if (currentState.Kind == StateKind.None)
            {
                if (isPrimitiveType)
                {
                    throw new SerializerSinkException("Primitive data type cannot be the root");
                }
                // Special case: a data type as the root - we use the type as the element name
                PushState().DataTypeState(type, isPrimitiveType: false);
                return true;
            }

            var elementName = currentState.GetElementName(type, isResource: false);
            if (elementName == null)
            {
                PushState().SkipState();
                return false;
            }

            PushState().DataTypeState(elementName, isPrimitiveType);
            return true;
        }

        protected void RenderStates()
        {
            while (_notRenderedStateIndex >= 0)
            {
                RenderBeginState(
                    ref _states[_notRenderedStateIndex],
                    ref _notRenderedStateIndex > 0 ?
                        ref _states[_notRenderedStateIndex - 1] :
                        ref _noneState
                );
                _notRenderedStateIndex++;
                if (_notRenderedStateIndex > _currentStateIndex)
                {
                    _notRenderedStateIndex = -1;
                }
            }
        }

        protected abstract void RenderBeginState(ref State state, ref State previousState);

        protected abstract void RenderEndState(ref State renderedState);

        protected bool IsSkipping()
        {
            ref var currentState = ref GetCurrentState();
            return currentState.Kind == StateKind.Skip;
        }

        /// <summary>
        /// Check if the element should be skipped (no output) - based on the element FHIR versions and the summarization settings
        /// </summary>
        /// <param name="name">Element name</param>
        /// <param name="elementVersions">FHIR versions this element applies to</param>
        /// <param name="summaryVersions">FHIR versions in which the element is part of the summary</param>
        /// <param name="isRequired">True if the element is a required one (min. cardinality 1)</param>
        /// <returns>True if the element should be skipped</returns>
        protected bool ShouldSkip(string name, Model.Version elementVersions, Model.Version summaryVersions, bool isRequired)
        {
            if ((elementVersions & _version) == 0)
            {
                return true;
            }
            switch (_summary)
            {
                case Rest.SummaryType.False:
                    return _elements != null
                        && !_elements.Contains(name)
                        && IsResourceElement();
                case Rest.SummaryType.Data:
                    return !isRequired
                        && name == "text"
                        && IsResourceElement();
                case Rest.SummaryType.True:
                    return (summaryVersions & _version) == 0
                        && !isRequired;
                case Rest.SummaryType.Text:
                    return !isRequired
                        && !(name == "id" || name == "meta" || name == "text")
                        && IsNonBundleResourceElement();
                case Rest.SummaryType.Count:
                    return !isRequired
                        && (name != "id")
                        && IsResourceElement()
                        && !(name == "total" && IsBundleElement());
                default:
                    throw new InvalidOperationException($"Unknown or not supported summary type '{_summary}'");
            }

            bool IsResourceElement()
            {
                ref var currentState = ref GetCurrentState();
                return currentState.Kind == StateKind.DataType && currentState.Type != null;
            }

            bool IsNonBundleResourceElement()
            {
                var resourceOrDataElementType = GetCurrentResourceOrDataElementType();
                return resourceOrDataElementType != null && resourceOrDataElementType != "Bundle";
            }

            bool IsBundleElement()
            {
                return GetCurrentResourceOrDataElementType() == "Bundle";
            }

            string GetCurrentResourceOrDataElementType()
            {
                ref var currentState = ref GetCurrentState();
                return currentState.Kind == StateKind.DataType ?
                    currentState.Type :
                    null;
            }
        }

        /// <summary>
        /// Computes the value that should be written to the output - checking for empty values and trimming spaces as needed
        /// </summary>
        /// <param name="value">Value to process</param>
        /// <returns>Value to write - null if nothing should be written</returns>
        protected static object ValueToWrite(object value)
        {
            if (value is string stringValueToTrim)
            {
                if (string.IsNullOrWhiteSpace(stringValueToTrim))
                {
                    return null;
                }
                return stringValueToTrim.Trim();
            }

            return value;
        }

        protected ref State GetCurrentState()
        {
            if ( _currentStateIndex >= 0 )
            {
                return ref _states[_currentStateIndex];
            }
            return ref _noneState;
        }

        private ref State PushState()
        {
            _currentStateIndex++;
            if (_currentStateIndex >= _states.Length)
            {
                var newStates = new State[_states.Length * 2];
                Array.Copy(_states, newStates, _states.Length);
                _states = newStates;
            }
            if (_notRenderedStateIndex == -1)
            {
                _notRenderedStateIndex = _currentStateIndex;
            }
            return ref _states[_currentStateIndex];
        }
        
        private delegate void SetState(ref State state);

        protected enum StateKind
        {
            None = 0,

            /// <summary>
            /// We are in an element that is being skipped 
            /// (either because belongs to a different FHIR version or is being removed due to summarization)
            /// </summary>
            Skip = 1,

            /// <summary>
            /// We are in a list - ie element with max cardinality > 1
            /// </summary>
            List = 2,

            /// <summary>
            /// We are in a resource or data type
            /// </summary>
            DataType = 3,
        }

        protected struct State
        {
            public StateKind Kind { get; private set; }
            public string Name { get; private set; }

            public string Type
            {
                get
                {
                    if (Kind != StateKind.DataType) throw new InvalidOperationException($"Unexpected state {Kind}");
                    return _type;
                }
            }

            public bool IsPrimitiveType
            {
                get
                {
                    if (Kind != StateKind.DataType) throw new InvalidOperationException( $"Unexpected state {Kind}");
                    return _isPrimitiveType;
                }
            }

            public void SkipState()
            {
                Kind = StateKind.Skip;
                Name = null;
            }

            public void ListState(string name)
            {
                Kind = StateKind.List;
                Name = name ?? throw new ArgumentNullException(nameof(name));
            }

            /// <summary>
            /// A resource
            /// </summary>
            /// <param name="type">The resource type</param>
            /// <param name="name">The name of the (optional) element containing the resource - eg set to 'resource' in a Bundle.entry. 
            /// Null if the resource is at the root or in a list (eg DomainResource.contained)</param>
            public void DataTypeState(string type, string name)
            {
                Kind = StateKind.DataType;
                Name = name;
                _type = type ?? throw new ArgumentNullException(nameof(type));
                _isPrimitiveType = false;
            }

            /// <summary>
            /// A data type
            /// </summary>
            /// <param name="name">The name of the element containing the data type</param>
            /// <param name="isPrimitiveType">True if it is a primitive data type</param>
            public void DataTypeState(string name, bool isPrimitiveType)
            {
                Kind = StateKind.DataType;
                Name = name ?? throw new ArgumentNullException(nameof(name));
                _type = null;
                _isPrimitiveType = isPrimitiveType;
            }

            public string GetElementName(string type, bool isResource)
            {
                switch (Kind)
                {
                    case StateKind.Skip:
                        return null;
                    case StateKind.List:
                        return Name;
                    case StateKind.DataType:
                        switch (_elementKind)
                        {
                            case ElementKind.Skip:
                                return null;
                            case ElementKind.Actual:
                                if (isResource)
                                {
                                    if (_elementIsChoice)
                                    {
                                        throw new SerializerSinkException("Choice elements cannot be followed by BeginResource()");
                                    }
                                    return _elementName;
                                }
                                return GetElementName(type);
                            default:
                                throw new SerializerSinkException($"Unexpected element {_elementKind}");
                        }
                    default:
                        throw new SerializerSinkException($"Unexpected state {Kind}");
                }
            }

            public void SetSkipElement()
            {
                switch (Kind)
                {
                    case StateKind.Skip:
                        // Do nothing - we are already skipping
                        break;
                    case StateKind.List:
                        throw new SerializerSinkException("Missing call to BeginResource() or BeginDataType()");
                    case StateKind.DataType:
                        _elementKind = ElementKind.Skip;
                        break;
                    default:
                        throw new SerializerSinkException($"Unexpected state {Kind}");
                }
            }

            public void SetActualElement(string name, bool isChoice)
            {
                switch (Kind)
                {
                    case StateKind.Skip:
                        // Do nothing - we are already skipping
                        break;
                    case StateKind.List:
                        throw new SerializerSinkException("Missing call to BeginResource() or BeginDataType()");
                    case StateKind.DataType:
                        _elementKind = ElementKind.Actual;
                        _elementName = name ?? throw new ArgumentNullException(nameof(name));
                        _elementIsChoice = isChoice;
                        break;
                    default:
                        throw new SerializerSinkException($"Unexpected state {Kind}");
                }

            }

            private string GetElementName(string type)
            {
                return _elementIsChoice ?
                    _choiceElementName.GetOrAdd( (_elementName, type), tuple => CreateChoiceElementName( tuple.Item1, tuple.Item2 ) ) : 
                    _elementName;
            }

            private static string CreateChoiceElementName(string elementName, string type)
            {
                return elementName + type.Substring(0, 1).ToUpperInvariant() + type.Substring(1);
            }

            private static readonly ConcurrentDictionary<(string, string), string> _choiceElementName = new ConcurrentDictionary<(string, string), string>();

            private string _type;               // Valid only when Kind = DataType
            private bool _isPrimitiveType;      // Valid only when Kind = DataType
            private ElementKind _elementKind;   // Valid only when Kind = DataType
            private string _elementName;        // Valid only when Kind = DataType and _elementKind = Actual
            private bool _elementIsChoice;      // Valid only when Kind = DataType and _elementKind = Actual
        }

        protected enum ElementKind
        {
            None = 0,
            Skip = 1,
            Actual = 2,
        }

        private const string OldObservationValueSystem = "http://hl7.org/fhir/v3/ObservationValue";
        private const string ObservationValueSystem = "http://terminology.hl7.org/CodeSystem/v3-ObservationValue";
        private const string ObservationValueCodeSubsetted = "SUBSETTED";

        private readonly Model.Version _version;
        private readonly Rest.SummaryType _summary;
        private readonly HashSet<string> _elements;

        private static State _noneState = new State();

        private State[] _states = new State[ 16 ];
        private int _currentStateIndex = -1;
        private int _notRenderedStateIndex = -1;
    }

    /// <summary>
    /// Sink that generates no output, used to determine if any output would be generated
    /// </summary>
    internal class NullSerializerSink : SerializerSink
    {
        public NullSerializerSink(Model.Version version, Rest.SummaryType summary, IEnumerable<string> elements) :
            base(version, summary, elements)
        { }

        public bool IsDirty { get; set; }

        public override void Serialize(Primitive primitive)
        {
            if (primitive != null)
            {
                if (BeginDataTypePrimitive(primitive.TypeName, true) && ValueToWrite(primitive.ObjectValue) != null)
                {
                    IsDirty = true;
                }
                primitive.SerializeElement(this);
                End();
            }
        }

        public override void Serialize(IReadOnlyList<Primitive> primitives)
        {
            if (primitives != null)
            {
                // We do not use foreach to avoid allocating the enumerator
                for (var i=0; i<primitives.Count; i++)
                {
                    Serialize(primitives[i]);
                }
            }
        }

        public override void StringValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            if (!IsSkipping() && !ShouldSkip(name, elementVersions, summaryVersions, isRequired) && !string.IsNullOrWhiteSpace(value))
            {
                IsDirty = true;
            }
        }

        public override void XhtmlValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            StringValue(name, value, elementVersions, summaryVersions, isRequired);
        }

        protected override void RenderBeginState(ref State state, ref State previousState)
        {
            // Nothing to do
        }

        protected override void RenderEndState(ref State renderedState)
        {
            // Nothing to do
        }
    }

    /// <summary>
    /// Sink generating JSON output - via a Utf8JsonWriter
    /// </summary>
    internal class JsonSerializerSink : SerializerSink
    {
        public JsonSerializerSink(Utf8JsonWriter writer, Model.Version version, Rest.SummaryType summary = Rest.SummaryType.False, IEnumerable<string> elements = null) :
            base(version, summary, elements)
        {
            _nullSink = new NullSerializerSink(version, summary, elements);
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public override void Serialize(Primitive primitive)
        {
            if (primitive != null)
            {
                ref var currentState = ref GetCurrentState();
                if (currentState.Kind == StateKind.None)
                {
                    throw new SerializerSinkException("Missing call to BeginResource(), BeginDataType() or BeginList()");
                }
                var elementName = currentState.GetElementName(primitive.TypeName, isResource: false);
                if (elementName != null)
                {
                    ValuePrimitive(elementName, primitive.ObjectValue);
                    BeginDataTypePrimitive(primitive.TypeName, true);
                    primitive.SerializeElement(this);
                    End();
                }
            }
        }

        public override void Serialize(IReadOnlyList<Primitive> primitives)
        {
            if (primitives != null && primitives.Count > 0 && !IsSkipping())
            {
                var anyNonEmpty = false;
                if (_elements.Length < primitives.Count)
                {
                    _elements = new ElementHandling[Math.Max(primitives.Count, _elements.Length * 2)];
                }
                // We do not use foreach to avoid allocating the enumerator
                for (var i = 0; i < primitives.Count; i++)
                {
                    var primitive = primitives[i];
                    var objectValue = ValueToWrite(primitive.ObjectValue);
                    var noElement = !HasElement(primitive);
                    if (objectValue == null && noElement)
                    {
                        _elements[i] = ElementHandling.Skip;
                    }
                    else
                    {
                        RenderStates();
                        if (objectValue == null)
                        {
                            _writer.WriteNullValue();
                        }
                        else
                        {
                            WriteValue(objectValue);
                        }
                        if (noElement)
                        {
                            _elements[i] = ElementHandling.Null;
                        }
                        else
                        {
                            anyNonEmpty = true;
                            _elements[i] = ElementHandling.Serialize;
                        }
                    }
                }
                if (anyNonEmpty)
                {
                    ref var currentState = ref GetCurrentState();
                    _writer.WriteEndArray();
                    _writer.WritePropertyName(PropertyName(currentState.Name, isExtension: true));
                    _writer.WriteStartArray();

                    for (var i = 0; i < primitives.Count; i++)
                    {
                        var element = _elements[i];
                        var primitive = primitives[i];
                        switch (element)
                        {
                            case ElementHandling.Null:
                                _writer.WriteNullValue();
                                break;
                            case ElementHandling.Skip:
                                break;
                            case ElementHandling.Serialize:
                                BeginDataTypePrimitive(primitive.TypeName, true);
                                primitive.SerializeElement(this);
                                End();
                                break;
                            default:
                                throw new InvalidOperationException($"Unknown or not supported ElementHandling '{element}'");
                        }
                    }
                }
            }
        }

        public override void StringValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            if (!IsSkipping() && !ShouldSkip(name, elementVersions, summaryVersions, isRequired))
            {
                ValuePrimitive(name, value);
            }
        }

        public override void XhtmlValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            StringValue(name, value, elementVersions, summaryVersions, isRequired);
        }

        protected override void RenderBeginState(ref State state, ref State previousState)
        {
            if (state.Kind == StateKind.DataType)
            {
                if (previousState.Kind != StateKind.None && previousState.Kind != StateKind.List && state.Name != null)
                {
                    _writer.WritePropertyName(PropertyName(state.Name, state.IsPrimitiveType));
                }
                _writer.WriteStartObject();
                if (state.Type != null)
                {
                    _writer.WritePropertyName("resourceType");
                    _writer.WriteStringValue(state.Type);
                }
            }
            else if (state.Kind == StateKind.List)
            {
                _writer.WritePropertyName(state.Name);
                _writer.WriteStartArray();
            }
            else
            {
                throw new SerializerSinkException($"Unexpected state {state.GetType()}");
            }
        }

        protected override void RenderEndState(ref State renderedState)
        {
            if (renderedState.Kind == StateKind.List)
            {
                _writer.WriteEndArray();
            }
            else
            {
                _writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Checks if the primitive data type has non-empty element id or extensions 
        /// </summary>
        private bool HasElement(Primitive primitive)
        {
            _nullSink.IsDirty = false;
            _nullSink.BeginDataType(primitive.TypeName);
            primitive.SerializeElement(_nullSink);
            _nullSink.End();
            return _nullSink.IsDirty;
        }

        private ReadOnlySpan<char> PropertyName(string name, bool isExtension)
        {
            if ( !isExtension )
            {
                return name.AsSpan();
            }
            if (_extensionPropertyName.Length <= name.Length)
            {
                _extensionPropertyName = new char[Math.Max(name.Length+1, _extensionPropertyName.Length*2)];
                _extensionPropertyName[0] = '_';
            }
            name.CopyTo(0, _extensionPropertyName, 1, name.Length);
            return new ReadOnlySpan<char>( _extensionPropertyName, 0, name.Length + 1 );
        }

        private void ValuePrimitive(string propertyName, object value)
        {
            var valueToWrite = ValueToWrite(value);
            if (valueToWrite != null)
            {
                RenderStates();

                _writer.WritePropertyName(propertyName);
                WriteValue(valueToWrite);
            }
        }

        private void WriteValue(object valueToWrite)
        {
            switch (valueToWrite)
            {
                case string stringToWrite:
                    _writer.WriteStringValue(stringToWrite);
                    break;
                case bool boolToWrite:
                    _writer.WriteBooleanValue(boolToWrite);
                    break;
                case decimal decimalToWrite:
                    _writer.WriteNumberValue(decimalToWrite);
                    break;
                case int intToWrite:
                    _writer.WriteNumberValue(intToWrite);
                    break;
                case long longToWrite:
                    _writer.WriteNumberValue(longToWrite);
                    break;
                case uint uintToWrite:
                    _writer.WriteNumberValue(uintToWrite);
                    break;
                case ulong ulongToWrite:
                    _writer.WriteNumberValue(ulongToWrite);
                    break;
                case double doubleToWrite:
                    _writer.WriteNumberValue(doubleToWrite);
                    break;
                case float floatToWrite:
                    _writer.WriteNumberValue(floatToWrite);
                    break;
                case byte[] bytesToWrite:
                    _writer.WriteBase64StringValue(bytesToWrite);
                    break;
                case DateTimeOffset dateTimeOffsetToWrite:
                    _writer.WriteStringValue(dateTimeOffsetToWrite);
                    break;
                default:
                    throw new SerializerSinkException($"Not supported primitive value type {valueToWrite.GetType()}");
            }
        }

        private enum ElementHandling
        {
            Skip,
            Null,
            Serialize
        }

        private ElementHandling[] _elements = new ElementHandling[16];
        private char[] _extensionPropertyName = new char[0];
        private readonly Utf8JsonWriter _writer;
        private readonly NullSerializerSink _nullSink;
    }

    /// <summary>
    /// Serializer target to use with GenericSerializerSink to generate the standard FHIR XML representation 
    /// </summary>
    internal class XmlSerializerTarget : ISerializerTarget
    {
        public XmlSerializerTarget(XmlWriter writer, string root = null)
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
            _root = root;
        }

        public void BeginObject(string name, string resourceType)
        {
            if (name != null)
            {
                WriteStartElement(name);
            }
            if (resourceType != null)
            {
                WriteStartElement(resourceType);
            }
        }

        public void EndObject(string name, string resourceType)
        {
            if (name != null)
            {
                _writer.WriteEndElement();
            }
            if (resourceType != null)
            {
                _writer.WriteEndElement();
            }
        }

        public void BeginList(string name)
        {
            // Empty
        }

        public void EndList(string name)
        {
            // Empty
        }

        public void WriteAttribute(string name, string value)
        {
            _writer.WriteAttributeString(name, value);
        }

        public void WriteXhtmlElement(string name, string value)
        {
            if (!value.StartsWith("<"))
            {
                value = $"<{name}>{value}</{name}>";
            }
            var addedRootElement = false;
            var firstElement = true;
            using (var xmlReader = SerializationUtil.XmlReaderFromXmlText(value))
            {
                    while (xmlReader.Read())
                {
                    // Remove comments, processing instructions, non-significative whitespaces
                    // Put all elements in the XHTML namespace
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (firstElement)
                            {
                                if (xmlReader.LocalName != name)
                                {
                                    _writer.WriteStartElement(name, Utility.XmlNs.XHTML);
                                    addedRootElement = true;
                                }
                                firstElement = false;
                            }
                            _writer.WriteStartElement(xmlReader.LocalName, Utility.XmlNs.XHTML);
                            _writer.WriteAttributes(xmlReader, defattr: false);
                            if (xmlReader.IsEmptyElement)
                            {
                                _writer.WriteEndElement();
                            }
                            break;
                        case XmlNodeType.Text:
                            _writer.WriteString(xmlReader.Value);
                            break;
                        case XmlNodeType.SignificantWhitespace:
                            _writer.WriteWhitespace(xmlReader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            _writer.WriteCData(xmlReader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            _writer.WriteEndElement();
                            break;
                    }
                }
                if (addedRootElement)
                {
                    _writer.WriteEndElement();
                }
            }
        }

        public void WriteValue(string stringValue)
        {
            _writer.WriteStartAttribute("value");
            _writer.WriteValue(stringValue);
            _writer.WriteEndAttribute();
        }

        public void WriteValue(bool boolValue)
        {
            _writer.WriteStartAttribute("value");
            _writer.WriteValue(boolValue);
            _writer.WriteEndAttribute();
        }

        public void WriteValue(int intValue)
        {
            _writer.WriteStartAttribute("value");
            _writer.WriteValue(intValue);
            _writer.WriteEndAttribute();
        }

        public void WriteValue(decimal decimalValue)
        {
            _writer.WriteStartAttribute("value");
            _writer.WriteValue(decimalValue);
            _writer.WriteEndAttribute();
        }

        public void WriteValue(DateTimeOffset dateTimeOffsetValue)
        {
            _writer.WriteStartAttribute("value");
            _writer.WriteValue(dateTimeOffsetValue);
            _writer.WriteEndAttribute();
        }

        public void WriteValue(byte[] bytesValue)
        {
            _writer.WriteStartAttribute("value");
            _writer.WriteValue(bytesValue);
            _writer.WriteEndAttribute();
        }

        private void WriteStartElement(string localName)
        {
            if (_root != null)
            {
                localName = _root;
                _root = null;
            }
            _writer.WriteStartElement(localName, "http://hl7.org/fhir");
        }

        private readonly XmlWriter _writer;
        private string _root;
    }

    /// <summary>
    /// Sink generating custom outputs via a <see cref="ISerializerTarget"/> implementation.
    /// One of these outputs is the standard FHIR XML via a <see cref="XmlSerializerTarget"/>
    /// </summary>
    internal class GenericSerializerSink : SerializerSink
    {
        public GenericSerializerSink(ISerializerTarget target, Model.Version version, Rest.SummaryType summary = Rest.SummaryType.False, IEnumerable<string> elements = null) :
            base(version, summary, elements)
        {
            _target = target ?? throw new ArgumentNullException(nameof(target));
        }

        public override void Serialize(Primitive primitive)
        {
            if (primitive != null)
            {
                if (BeginDataTypePrimitive(primitive.TypeName, isPrimitiveType: true))
                {
                    if (primitive.ObjectValue is string stringValue)
                    {
                        if (!string.IsNullOrWhiteSpace(stringValue))
                        {
                            RenderStates();
                            _target.WriteValue(stringValue.Trim());
                        }
                    }
                    else if (primitive.ObjectValue is bool boolValue)
                    {
                        RenderStates();
                        _target.WriteValue(boolValue);
                    }
                    else if (primitive.ObjectValue is int intValue)
                    {
                        RenderStates();
                        _target.WriteValue(intValue);
                    }
                    else if (primitive.ObjectValue is decimal decimalValue)
                    {
                        RenderStates();
                        _target.WriteValue(decimalValue);
                    }
                    else if (primitive.ObjectValue is byte[] bytesValue)
                    {
                        RenderStates();
                        _target.WriteValue(bytesValue);
                    }
                    else if (primitive.ObjectValue is DateTimeOffset dateTimeOffsetValue)
                    {
                        RenderStates();
                        _target.WriteValue(dateTimeOffsetValue);
                    }
                    else if (primitive.ObjectValue != null)
                    {
                        throw new SerializerSinkException($"Not supported primitive type {primitive.ObjectValue.GetType().Name}");
                    }
                }
                primitive.SerializeElement(this);
                End();
            }
        }

        public override void Serialize(IReadOnlyList<Primitive> primitives)
        {
            if (primitives != null)
            {
                // We do not use foreach to avoid allocating the enumerator
                for (var i = 0; i < primitives.Count; i++)
                {
                    Serialize(primitives[i]);
                }
            }
        }

        public override void StringValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            if (!IsSkipping() && !ShouldSkip(name, elementVersions, summaryVersions, isRequired) && !string.IsNullOrWhiteSpace(value))
            {
                RenderStates();
                _target.WriteAttribute(name, value.Trim());
            }
        }

        public override void XhtmlValue(string name, string value, Model.Version elementVersions = Model.Version.All, Model.Version summaryVersions = Model.Version.All, bool isRequired = false)
        {
            if (!IsSkipping() && !ShouldSkip(name, elementVersions, summaryVersions, isRequired) && !string.IsNullOrWhiteSpace(value))
            {
                RenderStates();
                _target.WriteXhtmlElement(name, value.Trim());
            }
        }

        protected override void RenderBeginState(ref State state, ref State previousState)
        {
            if (state.Kind == StateKind.List)
            {
                if (state.Name == null)
                {
                    throw new SerializerSinkException("List must have a name");
                }
                _target.BeginList(state.Name);
            }
            else if (state.Kind == StateKind.DataType)
            {
                _target.BeginObject(state.Name, state.Type);
            }
            else
            {
                throw new SerializerSinkException($"Unexpected state {state.GetType()}");
            }
        }

        protected override void RenderEndState(ref State renderedState)
        {
            if (renderedState.Kind == StateKind.List)
            {
                _target.EndList(renderedState.Name);
            }
            else if (renderedState.Kind == StateKind.DataType)
            {
                _target.EndObject(renderedState.Name, renderedState.Type);
            }
            else
            {
                throw new SerializerSinkException($"Unexpected state {renderedState.GetType()}");
            }
        }

        private readonly ISerializerTarget _target;
    }
}
