/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using Hl7.Fhir.Introspection.R4;

namespace Hl7.Fhir.Serialization.R4
{
    public interface IFhirWriter : IDisposable
    {
        void WriteStartRootObject(string name, bool contained);
        void WriteEndRootObject(bool contained);

        void WriteStartProperty(string name);
        void WriteEndProperty();

        void WriteStartComplexContent();
        void WriteEndComplexContent();

        void WritePrimitiveContents(object value,XmlSerializationHint xmlFormatHint);

        void WriteStartArray();
        //void WriteStartArrayElement(string name);
        //void WriteEndArrayElement();
        void WriteEndArray();

        bool HasValueElementSupport { get; }
    }
}
