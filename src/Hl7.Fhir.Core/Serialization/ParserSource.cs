using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization
{
    internal class ParserSource
    {
        public ParserSource(XmlReader reader, ParserSettings settings)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            _model = ModelInfos.Get(_settings.Version);
            _states = new Stack<State>();
        }

        public bool IsVersion(Model.Version versions)
        {
            return (versions & _settings.Version) != 0;
        }

        public string GetString()
        {
            var result = _reader.Value;
            if (string.IsNullOrWhiteSpace(result))
            {
                return null;
            }
            SetHasNonEmptyElements();
            return result.Trim();
        }

        public string GetXHtml()
        {
            // TODO: validation
            SetHasNonEmptyElements();   // At the very list we have the root element
            // We cannot use ReadOuterXml() because we want to convert \n to \r\n
            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true
            };
            using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
            {
                xmlWriter.WriteNode(_reader, defattr: false);
            }
            return stringWriter.ToString();
        }


        public TBase Get<TBase>() where TBase : Base, new()
        {
            var result = new TBase();
            if (PopulateBase(result))
            {
                return result;
            }
            return null;
        }

        public Base64Binary GetBase64Binary()
        {
            var result = new Base64Binary();
            if (TryPopulateStringPrimitive(result, out var hasNonEmptyElements, out var valueString))
            {
                if (!TryFromBase64String(valueString, out var value))
                {
                    ThrowIfStrictParsing($"'\"{SourceHelpers.Truncate(valueString)}\"' is not a valid base64 binary");
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = value;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);

            bool TryFromBase64String(string str, out byte[] bytes)
            {
                try
                {
                    bytes = Convert.FromBase64String(str);
                    return true;
                }
                catch (FormatException)
                {
                    bytes = null;
                    return false;
                }
            }
        }

        public List<Code> GetCodeList()
        {
            return GetListPrimitive(
                () => GetCode()
            );
        }

        public Code GetCode()
        {
            var result = new Code();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<Code<TEnum>> GetCodeList<TEnum>() where TEnum : struct
        {
            return GetListPrimitive(
                () => GetCode<TEnum>()
            );
        }

        public Code<TEnum> GetCode<TEnum>() where TEnum : struct
        {
            var result = new Code<TEnum>();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var code))
            {
                var codeValue = EnumUtility.ParseLiteral<TEnum>(code);
                if (codeValue == null)
                {
                    if (!_settings.AllowUnrecognizedEnums)
                    {
                        throw CreateException($"'{code}' is not a valid {EnumUtility.GetName<TEnum>()}");
                    }
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = codeValue;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public FhirBoolean GetFhirBoolean()
        {
            var result = new FhirBoolean();
            if (TryPopulateBooleanPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public Date GetDate()
        {
            var result = new Date();
            if (TryPopulateStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                if (!SourceHelpers.IsValidDate(value))
                {
                    ThrowIfStrictParsing($"'{value}' is not a valid date");
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = value;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<FhirDateTime> GetFhirDateTimeList()
        {
            return GetListPrimitive(
                () => GetFhirDateTime()
            );
        }

        public FhirDateTime GetFhirDateTime()
        {
            var result = new FhirDateTime();
            if (TryPopulateStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                if (!SourceHelpers.IsValidDate(value)
                    && !SourceHelpers.TryParseFhirInstant(value, out var _))
                {
                    ThrowIfStrictParsing($"'{value}' is not a valid date-time");
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = value;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public Instant GetInstant()
        {
            var result = new Instant();
            if (TryPopulateDateTimeOffsetPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<Time> GetTimeList()
        {
            return GetListPrimitive(
                () => GetTime()
            );
        }

        public Time GetTime()
        {
            var result = new Time();
            if (TryPopulateStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                if (!SourceHelpers.IsValidTime(value))
                {
                    ThrowIfStrictParsing($"'{value}' is not a valid time");
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = value;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<FhirString> GetFhirStringList()
        {
            return GetListPrimitive(
                () => GetFhirString()
            );
        }

        public FhirString GetFhirString()
        {
            var result = new FhirString();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<Markdown> GetMarkdownList()
        {
            return GetListPrimitive(
                () => GetMarkdown()
            );
        }

        public Markdown GetMarkdown()
        {
            var result = new Markdown();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<FhirUri> GetFhirUriList()
        {
            return GetListPrimitive(
                () => GetFhirUri()
            );
        }

        public FhirUri GetFhirUri()
        {
            var result = new FhirUri();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public Url GetUrl()
        {
            var result = new Url();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public Uuid GetUuid()
        {
            var result = new Uuid();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public Oid GetOid()
        {
            var result = new Oid();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<Canonical> GetCanonicalList()
        {
            return GetListPrimitive(
                () => GetCanonical()
            );
        }

        public Canonical GetCanonical()
        {
            var result = new Canonical();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<Integer> GetIntegerList()
        {
            return GetListPrimitive(
                () => GetInteger()
            );
        }

        public Integer GetInteger()
        {
            var result = new Integer();
            if (TryPopulateIntegerPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<PositiveInt> GetPositiveIntList()
        {
            return GetListPrimitive(
                () => GetPositiveInt()
            );
        }

        public PositiveInt GetPositiveInt()
        {
            var result = new PositiveInt();
            if (TryPopulateIntegerPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                if (value <= 0)
                {
                    ThrowIfStrictParsing($"'{value}' is not a valid positive integer");
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = value;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<UnsignedInt> GetUnsignedIntList()
        {
            return GetListPrimitive(
                () => GetUnsignedInt()
            );
        }

        public UnsignedInt GetUnsignedInt()
        {
            var result = new UnsignedInt();
            if (TryPopulateIntegerPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                if (value < 0)
                {
                    ThrowIfStrictParsing($"'{value}' is not a valid unsigned integer");
                }
                else
                {
                    hasNonEmptyElements = true;
                    result.Value = value;
                }
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<FhirDecimal> GetFhirDecimalList()
        {
            return GetListPrimitive(
                () => GetFhirDecimal()
            );
        }

        public FhirDecimal GetFhirDecimal()
        {
            var result = new FhirDecimal();
            if (TryPopulateDecimalPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<Id> GetIdList()
        {
            return GetListPrimitive(
                () => GetId()
            );
        }

        public Id GetId()
        {
            var result = new Id();
            if (TryPopulateNonEmptyStringPrimitive(result, out var hasNonEmptyElements, out var value))
            {
                hasNonEmptyElements = true;
                result.Value = value;
            }
            return HandleEmpty(result, hasNonEmptyElements);
        }

        public List<TBase> GetList<TBase>() where TBase : Base, new()
        {
            return GetListPrimitive(
                () => Get<TBase>()
            );
        }

        public Resource GetResource()
        {
            // We have: <element><resource> . . .</resource></element>

            if (!_settings.PermissiveParsing && _reader.MoveToFirstAttribute())
            {
                do
                {
                    if (string.IsNullOrEmpty(_reader.NamespaceURI) && IsValidAttributeName(_reader.LocalName))
                    {
                        throw CreateException($"Unknown attribute '{_reader.LocalName}'");
                    }
                } while (_reader.MoveToNextAttribute());
                _reader.MoveToElement();
            }

            if (_reader.IsEmptyElement)
            {
                ThrowEmptyNotAllowedIfStrictParsing();
                _reader.Skip();
                return null;
            }

            _reader.Read();

            if (!MoveToValidElement())
            {
                ThrowEmptyNotAllowedIfStrictParsing();
                _reader.Skip();
                return null;
            }

            var resourceType = _reader.LocalName;
            var result = _model.CreateResource(resourceType)
                ?? throw CreateUnknownResourceTypeException(resourceType);
            if (!PopulateBase(result))
            {
                result = null;
            }

            // Move after the </element> node
            while (MoveToValidElement())
            {
                ThrowIfStrictParsing($"Unexpected element '{_reader.LocalName}'");
                _reader.Skip();
            }
            _reader.Read();

            return result;
        }

        public Base GetRoot(Type targetType)
        {
            try
            {
                if (_reader.MoveToContent() != XmlNodeType.Element)
                {
                    throw CreateException($"Unexpected {_reader.NodeType} node");
                }

                Base result;
                if (targetType == null || targetType.IsAbstract || typeof(Resource).IsAssignableFrom(targetType))
                {
                    if (_reader.NamespaceURI != _fhirNamespaceURI)
                    {
                        var message = string.IsNullOrEmpty(_reader.NamespaceURI) ?
                            $"The element '{_reader.LocalName}' has no namespace, expected the HL7 FHIR namespace ({_fhirNamespaceURI})" :
                            $"The element '{_reader.LocalName}' uses the namespace '{_reader.NamespaceURI}', expected the HL7 FHIR namespace ({_fhirNamespaceURI})";
                        throw CreateException(message);
                    }
                    var resourceType = _reader.LocalName;
                    result = _model.CreateResource(resourceType)
                        ?? throw CreateUnknownResourceTypeException(resourceType);
                    if (targetType != null && !targetType.IsAssignableFrom(result.GetType()))
                    {
                        var expectedType = _model.GetFhirTypeNameForType(targetType) ?? targetType.Name;
                        throw CreateException($"Expected a {expectedType} but found a {resourceType}");
                    }
                }
                else
                {
                    if (!typeof(Base).IsAssignableFrom(targetType) || _model.GetFhirTypeNameForType(targetType) == null)
                    {
                        throw CreateException($"Unknown resource type or data type '{targetType.Name}'");
                    }
                    // This is slow but it is a very rare case that we want to create directly a data type
                    result = (Base)Activator.CreateInstance(targetType);
                }
                if (PopulateBase(result))
                {
                    return result;
                }
                return null;
            }
            catch (XmlException xmlException)
            {
                throw new SourceException($"Invalid XML: {xmlException.Message}", GetCurrentPath(), xmlException.LineNumber - 1, xmlException.LinePosition - 1);
            }
        }

        public List<Resource> GetResourceList()
        {
            return GetListPrimitive(
                () => GetResource()
            );
        }

        public void CheckDuplicates<TElement>(Element element, string rootName) where TElement : Element
        {
            if (!(element is null || element is TElement)
                && !_settings.PermissiveParsing)
            {
                throw CreateException($"Element '{rootName}[x]' must not repeat");
            }
        }

        private List<TBase> GetListPrimitive<TBase>(Func<TBase> get) where TBase : Base
        {
            var result = new List<TBase>();
            var elementName = _reader.LocalName;
            var index = 0;
            var currentState = _states.Peek();
            do
            {
                currentState.CurrentListIndex = index++;
                var item = get();
                if (item != null)
                {
                    result.Add(item);
                }
            } while (MoveToValidElement() && _reader.LocalName == elementName && _reader.NamespaceURI == _fhirNamespaceURI );
            return result;
        }

        private bool PopulateBase(Base element)
        {
            var isRoot = _states.Count == 0;
            if (!PopulateBase(element, isPrimitive: false, out var _))
            {
                if (isRoot || !_settings.PermissiveParsing)
                {
                    throw CreateException("Empty elements are not allowed");
                }
                return false;
            }
            if (!isRoot)
            {
                SetHasNonEmptyElements();
            }
            return true;
        }

        private bool TryPopulateNonEmptyStringPrimitive(Primitive primitive, out bool hasNonEmptyElements, out string value)
        {
            if (!TryPopulateStringPrimitive(primitive, out hasNonEmptyElements, out value))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                if (!_settings.PermissiveParsing)
                {
                    throw CreateException("Empty strings are not allowed");
                }
                return false;
            }
            return true;
        }

        private bool TryPopulateStringPrimitive(Primitive primitive, out bool hasNonEmptyElements, out string value)
        {
            hasNonEmptyElements = PopulateBase(primitive, isPrimitive: true, out value);
            if (value == null)
            {
                return false;
            }
            value = value.Trim();
            return true;
        }

        private bool TryPopulateBooleanPrimitive(Primitive primitive, out bool hasNonEmptyElements, out bool value)
        {
            hasNonEmptyElements = PopulateBase(primitive, isPrimitive: true, out var valueString);
            if (valueString == null)
            {
                value = default;
                return false;
            }

            switch (valueString.Trim())
            {
                case "true":
                    value = true;
                    return true;
                case "false":
                    value = false;
                    return true;
            }

            ThrowIfStrictParsing($"'{valueString}' is not a valid boolean");
            value = default;
            return false;
        }

        private bool TryPopulateDateTimeOffsetPrimitive(Primitive primitive, out bool hasNonEmptyElements, out DateTimeOffset value)
        {
            hasNonEmptyElements = PopulateBase(primitive, isPrimitive: true, out var valueString);
            if (valueString == null)
            {
                value = default;
                return false;
            }

            if (SourceHelpers.TryParseFhirInstant(valueString, out value))
            {
                return true;
            }

            ThrowIfStrictParsing($"'{valueString}' is not a valid instant");
            return false;
        }

        private bool TryPopulateIntegerPrimitive(Primitive primitive, out bool hasNonEmptyElements, out int value)
        {
            hasNonEmptyElements = PopulateBase(primitive, isPrimitive: true, out var valueString);
            if (valueString == null)
            {
                value = default;
                return false;
            }

            if (int.TryParse(valueString, out value))
            {
                return true;
            }

            ThrowIfStrictParsing($"'{valueString}' is not a valid integer");
            return false;
        }

        private bool TryPopulateDecimalPrimitive(Primitive primitive, out bool hasNonEmptyElements, out decimal value)
        {
            hasNonEmptyElements = PopulateBase(primitive, isPrimitive: true, out var valueString);
            if (valueString == null)
            {
                value = default;
                return false;
            }

            if (decimal.TryParse(valueString, out value))
            {
                return true;
            }

            ThrowIfStrictParsing($"'{valueString}' is not a valid decimal");
            return false;
        }

        private bool PopulateBase(Base element, bool isPrimitive, out string primitiveValueString)
        {
            var state = new State();
            _states.Push(state);
            primitiveValueString = null;
            if (_reader.MoveToFirstAttribute())
            {
                do
                {
                    if (string.IsNullOrEmpty(_reader.NamespaceURI))
                    {
                        var attributeName = _reader.LocalName;
                        if (IsValidAttributeName(attributeName))
                        {
                            if (isPrimitive && attributeName == "value")
                            {
                                primitiveValueString = _reader.Value;
                            }
                            else if (!SetElementFromSource(attributeName) && !_settings.AcceptUnknownMembers)
                            {
                                throw CreateException($"Unknown attribute '{attributeName}'");
                            }
                        }
                    }
                    else if (_settings.DisallowXsiAttributesOnRoot && _reader.Depth == 1 && _reader.NamespaceURI == _xsiNamespaceURI)
                    {
                        throw CreateException($"The '{_reader.LocalName}' attribute is not allowed");

                    }
                } while (_reader.MoveToNextAttribute());
                _reader.MoveToElement();
            }
            if (!_reader.IsEmptyElement)
            {
                _reader.Read();
                while (MoveToValidElement())
                {
                    if (!SetElementFromSource(_reader.LocalName))
                    {
                        if (!_settings.AcceptUnknownMembers)
                        {
                            throw CreateException($"Encountered unknown element '{_reader.LocalName}'");
                        }
                        _reader.Skip();
                    }
                }
            }
            _reader.Read();
            _states.Pop();
            return state.HasNonEmptyElements;

            bool SetElementFromSource(string elementName)
            {
                state.CurrentElementName = elementName;
                return element.SetElementFromSource(elementName, this);
            }
        }

        private bool MoveToValidElement()
        {
            while (true)
            {
                switch (_reader.MoveToContent())
                {
                    case XmlNodeType.None:
                    case XmlNodeType.EndElement:
                        return false;
                    case XmlNodeType.Element:
                        if (IsOnValidElement())
                        {
                            return true;
                        }
                        _reader.Skip();
                        break;
                    default:
                        ThrowIfStrictParsing($"Unexpected {_reader.NodeType} node");
                        _reader.Skip();
                        break;
                }
            }
        }

        private bool IsOnValidElement()
        {
            return _reader.NodeType == XmlNodeType.Element
                && _reader.NamespaceURI == _fhirNamespaceURI || _reader.NamespaceURI == _xhtmlNamespaceURI && _reader.LocalName == "div";
        }

        private void ThrowEmptyNotAllowedIfStrictParsing()
        {
            ThrowIfStrictParsing("Empty elements are not allowed");
        }

        private void ThrowIfStrictParsing(string message)
        {
            if (!_settings.PermissiveParsing)
            {
                throw CreateException(message);
            }
        }

        private SourceException CreateUnknownResourceTypeException(string resourceType)
        {
            return CreateException($"Unknown resource type '{resourceType}'");
        }

        private SourceException CreateException(string message)
        {
            long? lineNumber = null;
            long? bytePositionInLine = null;
            if (_reader is IXmlLineInfo lineInfo && lineInfo.HasLineInfo())
            {
                lineNumber = lineInfo.LineNumber - 1;
                bytePositionInLine = lineInfo.LinePosition - 1;
            }
            return new SourceException(message, GetCurrentPath(), lineNumber, bytePositionInLine);
        }

        private TBase HandleEmpty<TBase>(TBase element, bool hasNonEmptyElements) where TBase : class
        {
            if (hasNonEmptyElements)
            {
                SetHasNonEmptyElements();
                return element;
            }
            ThrowEmptyNotAllowedIfStrictParsing();
            return null;
        }

        private void SetHasNonEmptyElements()
        {
            _states.Peek().HasNonEmptyElements = true;
        }

        private static bool IsValidAttributeName(string attributeName)
        {
            return attributeName != "xmlns";
        }

        private string GetCurrentPath()
        {
            var result = string.Empty;
            foreach (var state in _states.Reverse())
            {
                if (state.CurrentElementName != null)
                {
                    if (result.Length > 0)
                    {
                        result += ".";
                    }
                    result += state.CurrentElementName;
                }
                if (state.CurrentListIndex != null)
                {
                    result += $"[{state.CurrentListIndex}]";
                }
            }
            return result;
        }

        private class State
        {
            public string CurrentElementName { get; set; } = null;

            public int? CurrentListIndex { get; set; } = null;

            public bool HasNonEmptyElements { get; set; } = false;
        }

        const string _fhirNamespaceURI = "http://hl7.org/fhir";
        const string _xsiNamespaceURI = "http://www.w3.org/2001/XMLSchema-instance";
        const string _xhtmlNamespaceURI = "http://www.w3.org/1999/xhtml";

        private readonly XmlReader _reader;
        private readonly ParserSettings _settings;
        private readonly IModelInfo _model;
        private readonly Stack<State> _states;
    }
}
