using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Fhir.Serialization
{
    public interface IParserSource
    {
        TProp GetProperty<TProp>(string name, Model.Version version);
        FhirDateTime GetDateTimeProperty(string name, Model.Version version);
        Date GetDateProperty(string name, Model.Version version);
        FhirString GetStringProperty(string name, Model.Version version);
        Code GetCodeProperty(string name, Model.Version version);
        Code<TEnum> GetCodeEnumProperty<TEnum>(string name, Model.Version version) where TEnum : struct;
        FhirBoolean GetBooleanProperty(string name, Model.Version version);
        Base64Binary GetBinaryProperty(string name, Model.Version version);
        FhirUri GetUriProperty(string name, Model.Version version);
        List<TProp> GetList<TProp>(string name, Model.Version version);
        List<FhirString> GetStringList(string name, Model.Version version);
    }

    public abstract class ParserSource : IParserSource
    {
        private readonly Model.Version _version;
        private readonly Stack<State> _stack = new Stack<State>();
        private State _current;
        private Resource _resource;

        protected ParserSource(Model.Version version)
        {
            _version = version;
        }

        public Model.Resource GetResource() => _resource;

        public virtual void StartElement(string propertyName, string resourceType = null)
        {
            //Console.WriteLine($"startElement {propertyName}|{resourceType}");
            if (_current != null)
            {
                _stack.Push(_current);
            }

            if (_current is UnsupportedState)
            {   // keep things Unsupported for the duration of this subtree
                _current = new UnsupportedState(_current);
                return;
            }

            var current = new ElementState(_current);

            if (resourceType != null)
            {
                current.ElementType = ModelInfos.Get(_version).GetTypeForFhirType(resourceType)
                    ?? throw new InvalidOperationException($"Resource type {resourceType} not supported for version {_version}");
            }
            else if (_current != null)
            {
                var parent = current.GetParentElementState();

                propertyName = propertyName ?? parent.CurrentProperty;

                if (propertyName == null) throw new InvalidOperationException("WTF");

                var propertyType = parent.Target.GetPropertyType(propertyName);

                if (propertyType == null)
                {
                    _current = new UnsupportedState(_current);
                    return;
                }

                current.ElementType = propertyType;

            }

            if (current.ElementType != null && !current.ElementType.GetTypeInfo().IsAbstract)
            {
                current.Target = (Base)Activator.CreateInstance(current.ElementType);
            }

            _current = current;
        }

        public virtual void SetResourceType(string resourceType)
        {
            var current = GetCurrent<ElementState>();

            if (current.Target != null) return;

            current.ElementType = ModelInfos.Get(_version).GetTypeForFhirType(resourceType)
                    ?? throw new InvalidOperationException($"Resource type {resourceType} not supported for version {_version}");

            current.Target = (Base)Activator.CreateInstance(current.ElementType);
        }

        public virtual void EndElement()
        {
            //Console.WriteLine($"EndElement {_current}");

            if (_current is UnsupportedState)
            {
                _current = _stack.Pop();
                return;
            }

            var current = GetCurrent<ElementState>();

            if (current.Target == null)
            {
                current.Target = (Base)Activator.CreateInstance(current.ElementType);
            }

            current.Target.Parse(this);

            if (_stack.Count == 0)
            {
                _resource = (current.Target as Resource) ?? throw new InvalidOperationException("Root element is not a resource");
            }
            else
            {
                _current = _stack.Pop();
            }
        }

        public virtual void StartList(string name)
        {
            //Console.WriteLine("StartList " + name);
            if (_current is UnsupportedState)
            {
                _stack.Push(_current);
                _current = new UnsupportedState(_current);
                return;
            }

            var current = GetCurrent<ElementState>();

            current.CurrentProperty = name;
            _stack.Push(current);

            _current = new ListState(_current);
        }

        public virtual void EndList()
        {
            //Console.WriteLine($"EndList { _current }");
            if (_current is UnsupportedState)
            {
                _current = _stack.Pop();
                return;
            }

            var current = GetCurrent<ListState>();

            var parent = (_stack.Pop() as ElementState) ?? throw new InvalidOperationException("List cannot contain another list");

            parent.AddList(current.List);

            _current = parent;
        }

        public virtual void Attribute(string name, object value)
        {
            if (_current is UnsupportedState) return;

            if (_current is ElementState elementState)
            {
                elementState.Properties.Add(name, value);
            }
            else if (_current is ListState listState)
            {
                listState.List.Add(value);
            }
        }

        #region IParserSource

        TProp IParserSource.GetProperty<TProp>(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return default;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return default;

            return (TProp)value;
        }

        FhirDateTime IParserSource.GetDateTimeProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is DateTime dateTime)
            {
                return new FhirDateTime(new DateTimeOffset(dateTime));
            }
            else if (value is string str)
            {
                return new FhirDateTime(str);
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a FhirDateTime but source value is {value.GetType()}");
            }
        }

        Date IParserSource.GetDateProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is DateTime dateTime)
            {
                return new Date(dateTime.Year, dateTime.Month, dateTime.Day);
            }
            else if (value is string str)
            {
                return new Date(str);
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a FhirDateTime but source value is {value.GetType()}");
            }
        }

        FhirString IParserSource.GetStringProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is string str)
            {
                return new FhirString(str);
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a FhirString but source value is {value.GetType()}");
            }
        }

        Code IParserSource.GetCodeProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is string str)
            {
                return new Code(str);
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a Code but source value is {value.GetType()}");
            }
        }

        Code<TEnum> IParserSource.GetCodeEnumProperty<TEnum>(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is string str)
            {
                var enumValue = Utility.EnumUtility.ParseLiteral<TEnum>(str);

                var code = new Code<TEnum>();

                if (enumValue.HasValue)
                {   // skip the extra parse layer and casting nonsense in Code<T>.Value
                    code.ObjectValue = str;
                }

                return code;
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a Code but source value is {value.GetType()}");
            }
        }

        FhirBoolean IParserSource.GetBooleanProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is bool b)
            {
                return new FhirBoolean(b);
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a FhirBoolean but source value is {value.GetType()}");
            }
        }

        Base64Binary IParserSource.GetBinaryProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is string str)
            {
                return new Base64Binary(System.Convert.FromBase64String(str));
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a FhirUri but source value is {value.GetType()}");
            }
        }

        FhirUri IParserSource.GetUriProperty(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            if (value is string str)
            {
                return new FhirUri(str);
            }
            else
            {
                throw new NotSupportedException($"Property {name} is a FhirUri but source value is {value.GetType()}");
            }
        }

        List<TProp> IParserSource.GetList<TProp>(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            var list = value as List<object> ?? throw new InvalidOperationException($"property {name} is not a List<object>, but {value.GetType()}");

            return list.Cast<TProp>().ToList();
        }

        List<FhirString> IParserSource.GetStringList(string name, Model.Version version)
        {
            if (!version.HasFlag(_version)) return null;

            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            var list = value as List<object> ?? throw new InvalidOperationException($"property {name} is not a List<object>, but {value.GetType()}");

            return list.Cast<string>().Select(str => new FhirString(str)).ToList();
        }
        #endregion

        private TState GetCurrent<TState>() where TState : State
        {
            if (_current == null) throw new InvalidOperationException("No current element");

            return (_current as TState) ?? throw new InvalidOperationException($"Current state is {_current.GetType()}, not {typeof(TState)}");
        }

        private abstract class State
        {
            public State(State parent)
            {
                Parent = parent;
            }
            public State Parent { get; }
            public abstract void EndElement(Base target);

            public ElementState GetParentElementState()
            {
                var p = Parent;

                if (p == null) return null;

                if (p is ElementState elementParent) return elementParent;

                // list cannot have a list as parent, so it has to be ElementState
                return (ElementState)p.Parent;
            }
        }

        private class UnsupportedState : State
        {
            public UnsupportedState(State parent) : base(parent)
            {
                // empty
            }

            public override void EndElement(Base target)
            {
                // empty
            }
        }

        private class ElementState : State
        {
            public ElementState(State parent) : base(parent)
            {
                // empty
            }

            public Dictionary<string, object> Properties = new Dictionary<string, object>();

            public Type ElementType;
            public string CurrentProperty;
            public Base Target;

            public override void EndElement(Base target)
            {
                Properties.Add(CurrentProperty, target);
                CurrentProperty = null;
            }

            public void AddList(List<object> list)
            {
                Properties.Add(CurrentProperty, list);
                CurrentProperty = null;
            }

            public override string ToString() => $"ElementState {ElementType} ({CurrentProperty})";
        }

        private class ListState : State
        {
            public ListState(State parent) : base(parent)
            {
                // empty
            }

            public List<object> List = new List<object>();

            public override void EndElement(Base target)
            {
                List.Add(target);
            }

            public override string ToString() => $"ListState {GetParentElementState().CurrentProperty} {List.Count} Items";
        }
    }

    public class JsonParserSource : ParserSource
    {
        public JsonParserSource(Model.Version version) : base(version)
        {

        }
    }

    public class XmlParserSource : ParserSource
    {
        public XmlParserSource(Model.Version version) : base(version)
        {

        }
    }
}
