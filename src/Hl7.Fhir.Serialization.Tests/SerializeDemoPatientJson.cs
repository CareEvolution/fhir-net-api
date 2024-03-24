using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class SerializeDemoPatientJson
    {
        public ITypedElement getJsonElement(string json, FhirJsonParsingSettings s = null) => 
            JsonParsingHelpers.ParseToTypedElement(json, new PocoStructureDefinitionSummaryProvider(Version.DSTU2), settings: s);

        [TestMethod]
        public void CanSerializeThroughNavigatorAndCompare()
        {
            var json = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));

            var nav = getJsonElement(json);
            var output = nav.ToJson();
            JsonAssert.AreSame(json, output);
        }
       
        [TestMethod]
        public void CanSerializeFromPoco()
        {
            var tp = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));
            var pser = new FhirJsonFastParser(new ParserSettings(Version.DSTU2) { DisallowXsiAttributesOnRoot = false } );
            var pat = pser.Parse<Model.DSTU2.Patient>(tp);

            var output = pat.ToJson(Version.DSTU2);
            JsonAssert.AreSame(tp, output);
        }

        [TestMethod]
        public void CanStreamingSerializeFromPoco()
        {
            var tp = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));
            var pser = new FhirJsonFastParser(new ParserSettings(Version.DSTU2) { DisallowXsiAttributesOnRoot = false });
            var pat = pser.Parse<Model.DSTU2.Patient>(tp);

            var output = new FhirJsonFastSerializer(Version.DSTU2).SerializeToString(pat);
            JsonAssert.AreSame(tp, output);
        }

        [TestMethod]
        public void DoesPretty()
        {
            var json = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));

            var nav = getJsonElement(json);
            var output = nav.ToJson();
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            var pretty = nav.ToJson(new FhirJsonSerializationSettings { Pretty = true });
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));

            var p = (new FhirJsonFastParser(Version.DSTU2)).Parse<Model.DSTU2.Patient>(json);
            output = (new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = false })).SerializeToString(p);
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            pretty = (new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = true })).SerializeToString(p);
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));
        }

        [TestMethod]
        public void DoesPrettyStreaming()
        {
            var json = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));

            var nav = getJsonElement(json);
            var output = nav.ToJson();
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            var pretty = nav.ToJson(new FhirJsonSerializationSettings { Pretty = true });
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));

            var p = (new FhirJsonFastParser(Version.DSTU2)).Parse<Model.DSTU2.Patient>(json);
            output = (new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = false })).SerializeToString(p);
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            pretty = (new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = true })).SerializeToString(p);
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));
        }
    }
}