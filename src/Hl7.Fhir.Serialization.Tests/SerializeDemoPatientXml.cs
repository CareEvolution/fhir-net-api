using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class SerializeDemoPatientXml
    {
        [TestMethod]
        public void CanSerializeThroughNavigatorAndCompare()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.xml"));
            var nav = new FhirXmlParser(Model.Version.DSTU2).Parse<Patient>(tpXml);
            var output = new FhirXmlFastSerializer(Model.Version.DSTU2).SerializeToString(nav);
            XmlAssert.AreSame("fp-test-patient.xml", tpXml, output, ignoreSchemaLocation: true);
        }

        [TestMethod]
        public void TestPruneEmptyNodes()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "test-empty-nodes.xml"));

            // Make sure permissive parsing is on - otherwise the parser will complain about all those empty nodes
            var nav = new FhirXmlParser(new ParserSettings(Model.Version.DSTU2) {  PermissiveParsing = true }).Parse<Patient>(tpXml);
            var output = new FhirXmlFastSerializer(Model.Version.DSTU2).SerializeToString(nav);
            var doc = XDocument.Parse(output);
            Assert.AreEqual(8, doc.Root.DescendantNodesAndSelf().Count());  // only 8 nodes left after pruning
        }

        [TestMethod]
        public void TestElementReordering()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "patient-out-of-order.xml"));
            var nav = new FhirXmlParser(new ParserSettings(Model.Version.DSTU2) { PermissiveParsing = true }).Parse<Patient>(tpXml);
            var output = new FhirXmlFastSerializer(Model.Version.DSTU2).SerializeToString(nav);
            var doc = XDocument.Parse(output);
            var root = doc.Root;

            var orderedNames = root.Elements().Select(e => e.Name.LocalName).ToList();
            CollectionAssert.AreEqual(new[] { "id", "text", "identifier", "identifier", "active", "name", "telecom" }, orderedNames);

            var orderedNameNames = root.Element("{http://hl7.org/fhir}name")
                                    .Elements().Select(e => e.Name.LocalName).ToList();
            CollectionAssert.AreEqual(new[] { "use", "family", "given" }, orderedNameNames);
        }

        [TestMethod]
        public void CanSerializeFromPoco()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.xml"));
            var pser = new FhirXmlParser(new ParserSettings(Model.Version.DSTU2) { DisallowXsiAttributesOnRoot = false });
            var pat = pser.Parse<Model.DSTU2.Patient>(tpXml);

            var output = new FhirXmlFastSerializer(Model.Version.DSTU2).SerializeToString(pat);
            XmlAssert.AreSame("fp-test-patient.xml", tpXml, output, ignoreSchemaLocation: true);
        }

        [TestMethod]
        public void CanStreamingSerializeFromPoco()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.xml"));
            var pser = new FhirXmlParser(new ParserSettings(Model.Version.DSTU2) { DisallowXsiAttributesOnRoot = false });
            var pat = pser.Parse<Patient>(tpXml);

            var output = new FhirXmlFastSerializer(Model.Version.DSTU2).SerializeToString(pat);
            XmlAssert.AreSame("fp-test-patient.xml", tpXml, output, ignoreSchemaLocation: true);
        }

        [TestMethod]
        public void DoesPretty()
        {
            var xml = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.xml"));

            var p = (new FhirXmlParser(Model.Version.DSTU2)).Parse<Model.DSTU2.Patient>(xml);
            var output = (new FhirXmlFastSerializer(new SerializerSettings(Model.Version.DSTU2) { Pretty = false })).SerializeToString(p);
            Assert.IsFalse(output.Substring(0, 50).Contains('\n'));
            var pretty = (new FhirXmlFastSerializer(new SerializerSettings(Model.Version.DSTU2) { Pretty = true })).SerializeToString(p);
            Assert.IsTrue(pretty.Substring(0, 50).Contains('\n'));
        }

        [TestMethod]
        public void DoesPrettyStreaming()
        {
            var xml = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.xml"));

            var p = (new FhirXmlParser(Model.Version.DSTU2)).Parse<Model.DSTU2.Patient>(xml);
            var output = (new FhirXmlFastSerializer(new SerializerSettings(Model.Version.DSTU2) { Pretty = false })).SerializeToString(p);
            Assert.IsFalse(output.Substring(0, 50).Contains('\n'));
            var pretty = (new FhirXmlFastSerializer(new SerializerSettings(Model.Version.DSTU2) { Pretty = true })).SerializeToString(p);
            Assert.IsTrue(pretty.Substring(0, 50).Contains('\n'));
        }

    }
}