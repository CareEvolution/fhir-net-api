﻿/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */


using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Hl7.Fhir.Serialization
{
    public static class FhirJsonBuilderExtensions
    {
        private static void writeTo(this JObject root, JsonWriter destination, string rootName = null)
        {
            root.WriteTo(destination);
            destination.Flush();
        }

        public static void WriteTo(this ITypedElement source, JsonWriter destination, FhirJsonBuilderSettings settings = null) =>
            new FhirJsonBuilder(settings).Build(source).writeTo(destination);

        public static void WriteTo(this ISourceNode source, JsonWriter destination, FhirJsonBuilderSettings settings = null) =>
            new FhirJsonBuilder(settings).Build(source).writeTo(destination);

        public static JObject ToJObject(this ISourceNode source, FhirJsonBuilderSettings settings = null) =>
            new FhirJsonBuilder(settings).Build(source);

        public static JObject ToJObject(this ITypedElement source, FhirJsonBuilderSettings settings = null) =>
            new FhirJsonBuilder(settings).Build(source);

        public static string ToJson(this ITypedElement source, FhirJsonBuilderSettings settings = null)
            => SerializationUtil.WriteJsonToString(writer => source.WriteTo(writer, settings), settings?.Pretty ?? false);

        public static string ToJson(this ISourceNode source, FhirJsonBuilderSettings settings = null)
            => SerializationUtil.WriteJsonToString(writer => source.WriteTo(writer, settings), settings?.Pretty ?? false);

        public static byte[] ToJsonBytes(this ITypedElement source, FhirJsonBuilderSettings settings = null)
                => SerializationUtil.WriteJsonToBytes(writer => source.WriteTo(writer, settings));
    }
}
