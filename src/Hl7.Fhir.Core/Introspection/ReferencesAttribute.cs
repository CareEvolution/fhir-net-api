using System;

namespace Hl7.Fhir.Introspection
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class ReferencesAttribute : Attribute
    {
        public ReferencesAttribute(params string[] resources)
        {
            Resources = resources;
        }

        public string[] Resources { get; set; }
    }
}
