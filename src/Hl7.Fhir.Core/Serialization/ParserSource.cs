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

        public string GetElementId()
        {
            return GetNonEmptyString();
        }

        public string GetExtensionUrl()
        {
            return GetNonEmptyString();
        }

        public string GetXHtml()
        {
            SetHasNonEmptyElements();   // At the very least we have the root element
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

        public byte[] GetBase64BinaryValue()
        {
            if (!TryGetNonEmptyString(out var valueString))
            {
                return null;
            }
            if (!TryFromBase64String(valueString, out var value))
            {
                ThrowIfStrictParsing($"'{SourceHelpers.Truncate(valueString)}' is not a valid base64 binary");
                return null;
            }
            SetHasNonEmptyElements();
            return value;

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

        public string GetCodeValue()
        {
            return GetNonEmptyString();
        }

        public TEnum? GetCodeValue<TEnum>() where TEnum : struct
        {
            if (!TryGetNonEmptyString(out var code))
            {
                return null;
            }
            var codeValue = EnumUtility.ParseLiteral<TEnum>(code);
            if (codeValue == null)
            {
                if (!_settings.AllowUnrecognizedEnums)
                {
                    throw CreateException($"'{code}' is not a valid {EnumUtility.GetName<TEnum>()}");
                }
                return null;
            }
            SetHasNonEmptyElements();
            return codeValue;
        }

        public bool? GetFhirBooleanValue()
        {
            if (!TryGetNonEmptyString(out var valueString))
            {
                return null;
            }

            switch (valueString)
            {
                case "true":
                    SetHasNonEmptyElements();
                    return true;
                case "false":
                    SetHasNonEmptyElements();
                    return false;
            }

            ThrowIfStrictParsing($"'{valueString}' is not a valid boolean");
            return null;
        }

        public string GetDateValue()
        {
            if (!TryGetNonEmptyString(out var value))
            {
                return null;
            }
            if (!SourceHelpers.IsValidDate(value))
            {
                ThrowIfStrictParsing($"'{value}' is not a valid date");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public string GetFhirDateTimeValue()
        {
            if (!TryGetNonEmptyString(out var value))
            {
                return null;
            }
            if (!SourceHelpers.IsValidDate(value)
                && !SourceHelpers.TryParseFhirInstant(value, out var _))
            {
                ThrowIfStrictParsing($"'{value}' is not a valid date-time");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public DateTimeOffset? GetInstantValue()
        {
            if (!TryGetNonEmptyString(out var valueString))
            {
                return null;
            }
            if (!SourceHelpers.TryParseFhirInstant(valueString, out var value))
            {
                ThrowIfStrictParsing($"'{valueString}' is not a valid instant");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public string GetTimeValue()
        {
            if (!TryGetNonEmptyString(out var value))
            {
                return null;
            }
            if (!SourceHelpers.IsValidTime(value))
            {
                ThrowIfStrictParsing($"'{value}' is not a valid time");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public string GetFhirStringValue()
        {
            return GetNonEmptyString();
        }

        public string GetMarkdownValue()
        {
            return GetNonEmptyString();
        }

        public string GetFhirUriValue()
        {
            return GetNonEmptyString();
        }

        public string GetUrlValue()
        {
            return GetNonEmptyString();
        }

        public string GetUuidValue()
        {
            return GetNonEmptyString();
        }

        public string GetOidValue()
        {
            return GetNonEmptyString();
        }

        public string GetCanonicalValue()
        {
            return GetNonEmptyString();
        }

        public int? GetIntegerValue()
        {
            if (!TryGetInteger(out var value))
            {
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public int? GetPositiveIntValue()
        {
            if (!TryGetInteger(out var value))
            {
                return null;
            }
            if (value <= 0)
            {
                ThrowIfStrictParsing($"'{value}' is not a valid positive integer");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public int? GetUnsignedIntValue()
        {
            if (!TryGetInteger(out var value))
            {
                return null;
            }
            if (value < 0)
            {
                ThrowIfStrictParsing($"'{value}' is not a valid unsigned integer");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public decimal? GetFhirDecimalValue()
        {
            if (!TryGetNonEmptyString(out var valueString))
            {
                return null;
            }
            if (!decimal.TryParse(valueString, out var value))
            {
                ThrowIfStrictParsing($"'{valueString}' is not a valid decimal");
                return null;
            }
            SetHasNonEmptyElements();
            return value;
        }

        public string GetIdValue()
        {
            return GetNonEmptyString();
        }

        public TBase Get<TBase>() where TBase : Base, new()
        {
            var result = new TBase();
            if (PopulateBaseCheckEmpty(result))
            {
                return result;
            }
            return null;
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
            if (!PopulateBaseCheckEmpty(result))
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
                // We accept root empty element (as we do for JSON because we consider the resourceType property enough to make it non-empty)
                PopulateBase(result);
                return result;
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

        private string GetNonEmptyString()
        {
            if (!TryGetNonEmptyString(out var result))
            {
                return null;
            }
            SetHasNonEmptyElements();
            return result;
        }

        private bool TryGetInteger(out int value)
        {
            value = default;
            if (!TryGetNonEmptyString(out var valueString))
            {
                return false;
            }
            if (!int.TryParse(valueString, out value))
            {
                ThrowIfStrictParsing($"'{valueString}' is not a valid integer");
                return false;
            }
            return true;
        }

        private bool TryGetNonEmptyString(out string value)
        {
            value = _reader.Value;
            if (string.IsNullOrWhiteSpace(value))
            {
                if (!_settings.PermissiveParsing)
                {
                    throw CreateException("Empty strings are not allowed");
                }
                return false;
            }
            value = value.Trim();
            return true;
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

        private bool PopulateBaseCheckEmpty(Base element)
        {
            if (!PopulateBase(element))
            {
                ThrowEmptyNotAllowedIfStrictParsing();
                return false;
            }
            SetHasNonEmptyElements();
            return true;
        }

        private bool PopulateBase(Base element)
        {
            var state = new State();
            _states.Push(state);
            if (_reader.MoveToFirstAttribute())
            {
                do
                {
                    if (string.IsNullOrEmpty(_reader.NamespaceURI))
                    {
                        var attributeName = _reader.LocalName;
                        if (IsValidAttributeName(attributeName))
                        {
                            var elementName = $"@{attributeName}";
                            if (!SetElementFromSource(elementName) && !_settings.AcceptUnknownMembers)
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
