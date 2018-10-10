﻿using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Serialization.DSTU2;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Tests;
using Hl7.Fhir.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class SerializeDemoPatientJson
    {
        public ITypedElement getJsonElement(string json, FhirJsonParsingSettings s = null) => 
            JsonParsingHelpers.ParseToTypedElement(json, DSTU2ModelInfo.Instance.StructureDefinitionProvider, settings: s);

        [TestMethod]
        public void CanSerializeThroughNavigatorAndCompare()
        {
            var json = File.ReadAllText(@"TestData\fp-test-patient.json");

            var nav = getJsonElement(json);
            var output = nav.ToJson();
            JsonAssert.AreSame(json, output);
        }

        [TestMethod]
        public void TestPruneEmptyNodes()
        {
            var tp = File.ReadAllText(@"TestData\test-empty-nodes.json");

            // Make sure permissive parsing is on - otherwise the parser will complain about all those empty nodes
            var nav = getJsonElement(tp, new FhirJsonParsingSettings { PermissiveParsing = true });

            var output = nav.ToJson();
            var doc = JObject.Parse(output);
            Assert.AreEqual(17, doc.DescendantsAndSelf().Count());
        }

       
        [TestMethod]
        public void CanSerializeFromPoco()
        {
            var tp = File.ReadAllText(@"TestData\fp-test-patient.json");
            var pser = new FhirJsonParser(DSTU2ModelInfo.Instance, new ParserSettings { DisallowXsiAttributesOnRoot = false } );
            var pat = pser.Parse<Patient>(tp);

            var output = pat.ToJson();
            JsonAssert.AreSame(tp, output);
        }

        [TestMethod]
        public void DoesPretty()
        {
            var json = File.ReadAllText(@"TestData\fp-test-patient.json");

            var nav = getJsonElement(json);
            var output = nav.ToJson();
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            var pretty = nav.ToJson(new FhirJsonSerializationSettings { Pretty = true });
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));

            var p = new FhirJsonParser(DSTU2ModelInfo.Instance).Parse<Patient>(json);
            output = (new FhirJsonSerializer(DSTU2ModelInfo.Instance, new SerializerSettings { Pretty = false })).SerializeToString(p);
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            pretty = (new FhirJsonSerializer(DSTU2ModelInfo.Instance, new SerializerSettings { Pretty = true })).SerializeToString(p);
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));
        }
    }
}