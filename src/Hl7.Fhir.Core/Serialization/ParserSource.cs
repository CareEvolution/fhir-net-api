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
        TProp GetProperty<TProp>(string name);
        List<TProp> GetList<TProp>(string name);
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
            if (_current != null)
            {
                _stack.Push(_current);
            }

            var current = new ElementState(_current);

            if (resourceType != null)
            {
                current.ResourceType = resourceType;
                var type = ModelInfos.Get(_version).GetTypeForFhirType(current.ResourceType) ?? throw new InvalidOperationException($"Resource type {resourceType} not supported for version {_version}");
                current.Target = (Base)Activator.CreateInstance(type);
            }
            else if (propertyName != null && _current != null)
            {
                var parentElement = current.GetParentElementState();

                var properties = parentElement.Target.GetType().GetProperties();

                foreach (var property in properties)
                {
                    var fhirAttr = property.GetCustomAttributes(typeof(FhirElementAttribute), inherit: false)
                        .Cast<FhirElementAttribute>()
                        .FirstOrDefault();

                    if (fhirAttr == null) continue;

                    if (fhirAttr.Name == parentElement.CurrentProperty)
                    {
                        current.Target = (Base)Activator.CreateInstance(property.PropertyType);
                    }
                }
            }

            _current = current;
        }

        public virtual void SetResourceType(string resourceType)
        {
            var current = GetCurrent<ElementState>();
            current.ResourceType = resourceType;
            var type = ModelInfos.Get(_version).GetTypeForFhirType(current.ResourceType) ?? throw new InvalidOperationException($"Resource type {resourceType} not supported for version {_version}");
            current.Target = (Base)Activator.CreateInstance(type);
        }

        public virtual void EndElement()
        {
            var current = GetCurrent<ElementState>();

            if (current.Target == null)
            {
                throw new InvalidOperationException("No target");
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
            var current = GetCurrent<ElementState>();

            current.CurrentProperty = name;
            _stack.Push(current);

            _current = new ListState(_current);
        }

        public virtual void EndList()
        {
            var current = GetCurrent<ListState>();

            var parent = (_stack.Pop() as ElementState) ?? throw new InvalidOperationException("List cannot contain another list");

            parent.AddList(current.List);

            _current = parent;
        }

        public virtual void Attribute(string name, object value)
        {
            var current = GetCurrent<ElementState>();

            current.Properties.Add(name, value);
        }

        #region IParserSource
        TProp IParserSource.GetProperty<TProp>(string name)
        {
            var current = GetCurrent<ElementState>();

            current.Properties.TryGetValue(name, out var value);

            return (TProp)value;
        }

        List<TProp> IParserSource.GetList<TProp>(string name)
        {
            var current = GetCurrent<ElementState>();

            if (!current.Properties.TryGetValue(name, out var value)) return null;

            var list = value as List<object> ?? throw new InvalidOperationException($"property {name} is not a List<object>, but {value.GetType()}");

            return list.Cast<TProp>().ToList();
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
            public abstract void EndElement(State child);

            public ElementState GetParentElementState()
            {
                var p = Parent;

                if (p == null) return null;

                if (p is ElementState elementParent) return elementParent;

                // list cannot have a list as parent, so it has to be ElementState
                return (ElementState)p.Parent;
            }
        }

        private class ElementState : State
        {
            public ElementState(State parent) : base(parent)
            {
                // empty
            }

            public Dictionary<string, object> Properties = new Dictionary<string, object>();

            public string ResourceType;
            public string CurrentProperty;
            public Base Target;

            public override void EndElement(State child)
            {
                Properties.Add(CurrentProperty, child);
                CurrentProperty = null;
            }

            public void AddList(List<State> list)
            {
                Properties.Add(CurrentProperty, list);
                CurrentProperty = null;
            }
        }

        private class ListState : State
        {
            public ListState(State parent) : base(parent)
            {
                // empty
            }

            public List<State> List = new List<State>();

            public override void EndElement(State child)
            {
                List.Add(child);
            }
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
