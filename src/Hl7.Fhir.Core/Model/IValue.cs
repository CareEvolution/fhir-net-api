using System;

namespace Hl7.Fhir.Model
{
    // [WMR 20160615]
    // Motivation: we want to enable polymorphism against subclasses of Primitive<T>, especially the Value property
    // However subclasses of Primitive<T> don't implement Value in a consistent way
    // e.g. Code<T> is derived from Primitive<T> but exposes a Value property of type T?
    // => As workaround, subclasses can implement a common IValue<T> interface

    /// <summary>Common generic Value property interface.</summary>
    /// <typeparam name="T">The value type.</typeparam>
    public interface IValue<T>
    {
        /// <summary>Gets or sets the value</summary>
        T Value { get; set; }
    }

    /// <summary>Common string Value property interface.</summary>
    public interface IStringValue : IValue<string> { }

    /// <summary>Common generic nullable value property interface.</summary>
    /// <typeparam name="T">The value type.</typeparam>
    public interface INullableValue<T> : IValue<T?> where T : struct { }

    /// <summary>Common nullable integer value property interface.</summary>
    public interface INullableIntegerValue : INullableValue<int> { }

    /// <summary>
    /// Provides a way to access the system and code from a Code&lt;T&gt; derived class, without having to mess
    /// about with the generic types/additional nasty reflection
    /// </summary>
    public interface ISystemAndCode
    {
        string System { get; }
        string Code { get; }
    }
}
