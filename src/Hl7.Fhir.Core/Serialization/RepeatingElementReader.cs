﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System.Collections;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Serialization.R4;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization.R4
{
    public class RepeatingElementReader
    {
#pragma warning disable 612, 618
        private IFhirReader _current;
        private ModelInspector _inspector;

        public ParserSettings Settings { get; private set; }

        public RepeatingElementReader(IFhirReader reader, ParserSettings settings)
        {
            _current = reader;
            _inspector = BaseFhirParser.Inspector;

            Settings = settings;
        }

#pragma warning restore 612, 618

        public IList Deserialize(PropertyMapping prop, string memberName, IList existing=null)
        {
            if (prop == null) throw Error.ArgumentNull(nameof(prop));

            IList result = existing;

            if (result == null) result = ReflectionHelper.CreateGenericList(prop.ElementType);

            var reader = new DispatchingReader(_current, Settings, arrayMode: true);                 
            result.Add(reader.Deserialize(prop, memberName));

            return result;
        }
    }
}
