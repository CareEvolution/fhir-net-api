﻿/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Hl7.Fhir.Serialization
{
    public partial class FhirJsonNode
    {
        public static ISourceNode Read(JsonReader reader, string rootName = null, FhirJsonNodeSettings settings = null)
        {
            if (reader == null) throw Error.ArgumentNull(nameof(reader));

            var doc = SerializationUtil.JObjectFromReader(reader);
            return new FhirJsonNode(doc, rootName, settings);
        }

        public static ISourceNode Parse(string json, string rootName = null, FhirJsonNodeSettings settings = null)
        {
            if (json == null) throw Error.ArgumentNull(nameof(json));

            using (var reader = SerializationUtil.JsonReaderFromJsonText(json))
            {
                return Read(reader, rootName, settings);
            }
        }

        public static ISourceNode Create(JObject root, string rootName = null, FhirJsonNodeSettings settings = null) => 
            new FhirJsonNode(root, rootName, settings);
    }
}
