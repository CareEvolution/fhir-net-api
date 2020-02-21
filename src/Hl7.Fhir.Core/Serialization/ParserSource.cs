using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;

namespace Hl7.Fhir.Serialization
{
    public interface IParserSource
    {
        TProp GetProperty<TProp>(string name);
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

        public virtual void StartElement(string resourceType = null)
        {
            if (_current != null)
            {
                _stack.Push(_current);
            }

            _current = new ElementState
            {
                ResourceType = resourceType,
            };
        }

        public virtual void SetResourceType(string resourceType)
        {
            var current = GetCurrent<ElementState>();
            current.ResourceType = resourceType;
        }

        public virtual void EndElement()
        {
            var current = GetCurrent<ElementState>();

            // create the resource;

            if (_stack.Count == 0)
            {
                _resource = current.Resource;
            }
            else
            {
                var parent = _stack.Pop();
                parent.AddResource(current.Resource);
                _current = parent;
            }
        }

        public virtual void StartList(string name)
        {
            var current = GetCurrent<ElementState>();

            current.CurrentProperty = name;
            _stack.Push(current);

            _current = new ListState();
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

        TProp IParserSource.GetProperty<TProp>(string name)
        {
            var current = GetCurrent<ElementState>();

            current.Properties.TryGetValue(name, out var value);

            return (TProp)value;
        }

        private TState GetCurrent<TState>() where TState : State
        {
            if (_current != null) throw new InvalidOperationException("No current element");

            return (_current as TState) ?? throw new InvalidOperationException($"Current state is {_current.GetType()}, not {typeof(TState)}");
        }

        private abstract class State
        {
            public abstract void AddResource(Resource resource);
        }

        private class ElementState : State
        {
            public Dictionary<string, object> Properties = new Dictionary<string, object>();

            public string ResourceType;
            public string CurrentProperty;
            public Resource Resource;

            public override void AddResource(Resource resource)
            {
                Properties.Add(CurrentProperty, resource);
                CurrentProperty = null;
            }

            public void AddList(List<Resource> list)
            {
                Properties.Add(CurrentProperty, list);
                CurrentProperty = null;
            }
        }

        private class ListState : State
        {
            public List<Resource> List = new List<Resource>();

            public override void AddResource(Resource resource)
            {
                List.Add(resource);
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
