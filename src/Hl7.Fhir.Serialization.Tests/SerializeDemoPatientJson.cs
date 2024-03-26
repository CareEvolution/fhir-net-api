using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class SerializeDemoPatientJson
    {
        [TestMethod]
        public void CanSerializeFromPoco()
        {
            var tp = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));
            var pser = new FhirJsonFastParser(new ParserSettings(Version.DSTU2) { DisallowXsiAttributesOnRoot = false } );
            var pat = pser.Parse<Model.DSTU2.Patient>(tp);

            var output = new FhirJsonFastSerializer(Version.DSTU2).SerializeToString(pat);
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

            var p = (new FhirJsonFastParser(Version.DSTU2)).Parse<Model.DSTU2.Patient>(json);
            var output = (new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = false })).SerializeToString(p);
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));
            var pretty = (new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = true })).SerializeToString(p);
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));
        }

        [TestMethod]
        public void DoesPrettyStreaming()
        {
            var json = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.json"));

            var p = new FhirJsonFastParser(Version.DSTU2).Parse<Model.DSTU2.Patient>(json);

            var serializer = new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = false });
            var destination = new MemoryStream();
            using (var writer = new Utf8JsonWriter(destination, serializer.CreateJsonWriterOptions()))
            {
                serializer.Serialize(p, writer);
            }
            var output = Encoding.UTF8.GetString(destination.ToArray());
            Assert.IsFalse(output.Substring(0, 20).Contains('\n'));

            serializer = new FhirJsonFastSerializer(new SerializerSettings(Version.DSTU2) { Pretty = true });
            destination = new MemoryStream();
            using (var writer = new Utf8JsonWriter(destination, serializer.CreateJsonWriterOptions()))
            {
                serializer.Serialize(p, writer);
            }
            var pretty = Encoding.UTF8.GetString(destination.ToArray());
            Assert.IsTrue(pretty.Substring(0, 20).Contains('\n'));
        }
    }
}