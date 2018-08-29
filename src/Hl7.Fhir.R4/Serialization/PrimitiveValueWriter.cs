/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Serialization.R4;
using Hl7.Fhir.Utility;


namespace Hl7.Fhir.Serialization.R4
{
    internal class PrimitiveValueWriter
    {
        private IFhirWriter _writer;
        private ModelInspector _inspector;

        public PrimitiveValueWriter(IFhirWriter data)
        {
            _writer = data;
            _inspector = BaseFhirParser.Inspector;
        }


        internal void Serialize(object value, XmlSerializationHint hint)
        {
            if (value != null)
            {
                var nativeType = value.GetType();

                if (nativeType.IsEnum())
                {
                    value = ((Enum)value).GetLiteral();
                }
            }

            _writer.WritePrimitiveContents(value, hint);
        }
    }

}
