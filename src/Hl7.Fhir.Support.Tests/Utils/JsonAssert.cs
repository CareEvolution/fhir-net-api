/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/FirelyTeam/fhir-net-api/blob/master/LICENSE
 */

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Hl7.Fhir.Tests
{
    public class JsonAssert
    {
        public static void AreSame(string expected, string actual)
        {
            var exp = JsonDocument.Parse(expected);
            var act = JsonDocument.Parse(actual);

            AreSame(exp.RootElement, act.RootElement);
        }

        public static void AreSame(JsonElement expected, JsonElement actual)
        {
            if (expected.ValueKind != actual.ValueKind)
                throw new AssertFailedException($"Token types are not the same (actual: {actual.ValueKind}, expected: {expected.ValueKind})");

            switch (expected.ValueKind)
            {
                case JsonValueKind.Object:
                    areSameObject(expected, actual);
                    break;
                case JsonValueKind.Array:
                    areSameArray(expected, actual);
                    break;
                case JsonValueKind.String:
                    compareStringValues(expected.GetString(), actual.GetString());
                    break;
                case JsonValueKind.Number:
                    if (expected.GetDecimal() != actual.GetDecimal())
                    {
                        throw new AssertFailedException($"Values are not equal, expected '{expected.GetDecimal()}', actual '{actual.GetDecimal()}'");
                    }
                    break;
            }
        }

        private static void areSameObject(JsonElement expected, JsonElement actual)
        {
            bool isRelevant(JsonProperty t)
            {
                if (t.Name == "fhir_comments") return false;
                if(t.Name.StartsWith("_") && t.Value.ValueKind == JsonValueKind.Object)
                {
                    var children = t.Value.EnumerateObject().ToList();
                    if (children.Count == 1 && children.Any(p => p.Name == "fhir_comments")) return false;
                }
                return true;
            }

            var expecteds = expected.EnumerateObject().Where(c => isRelevant(c));
            var actuals = actual.EnumerateObject().Where(c => isRelevant(c));

            var expectedList = expecteds.OrderBy(t => t.Name).ToList();
            var actualList = actuals.OrderBy(t => t.Name).ToList();

            if (expectedList.Count != actualList.Count)
                throw new AssertFailedException($"Number of elements are not the same: expected <{expectedList.Count}>, actual <{actualList.Count}>");

            for (int elemNr = 0; elemNr < expectedList.Count; elemNr++)
            {
                var ex = expectedList[elemNr];
                var ac = actualList[elemNr];

                AreSame(ex.Value, ac.Value);
            }
        }

        private static void areSameArray(JsonElement expected, JsonElement actual)
        {
            var expectedList = expected.EnumerateArray().ToList();
            var actualList = actual.EnumerateArray().ToList();

            if (expectedList.Count != actualList.Count)
                throw new AssertFailedException($"Number of elements are not the same: expected <{expectedList.Count}>, actual <{actualList.Count}>");

            for (int elemNr = 0; elemNr < expectedList.Count(); elemNr++)
            {
                var ex = expectedList[elemNr];
                var ac = actualList[elemNr];

                AreSame(ex, ac);
            }
        }

        public static void compareStringValues(string expS, string actS)
        {
            if (expS.TrimStart().StartsWith("<div"))
            {
                // Don't check the narrative, namespaces are not correctly generated in DSTU2
                return;
            }

            // Hack for timestamps, binaries and narrative html
            if (expS.EndsWith("+00:00")) expS = expS.Replace("+00:00", "Z");
            if (actS.EndsWith("+00:00")) actS = actS.Replace("+00:00", "Z");
            if (expS.Contains(".000+")) expS = expS.Replace(".000+", "+");
            if (actS.Contains(".000+")) actS = actS.Replace(".000+", "+");
            if (expS.Contains(".000Z")) expS = expS.Replace(".000Z", "Z");
            if (actS.Contains(".000Z")) actS = actS.Replace(".000Z", "Z");
            actS = actS.Replace("\n", "");
            actS = actS.Replace("\r", "");
            expS = expS.Replace("\n", "");
            expS = expS.Replace("\r", "");

            expS = expS.Trim();
            actS = actS.Trim();

            if (expS != actS)
            {
                throw new AssertFailedException($"Values are not equal, expected '{expS}', actual '{actS}'");
            }
        }
    }
}
