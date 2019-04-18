﻿using System.IO;
using System.Linq;
using System.Xml.Linq;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class SummaryTests
    {
        public ITypedElement getXmlNode(string xml, FhirXmlParsingSettings s = null) =>
            XmlParsingHelpers.ParseToTypedElement(xml, DSTU2ModelInfo.Instance.StructureDefinitionProvider, s);

        [TestMethod]
        public void Summary()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "fp-test-patient.xml"));
            var typeinfo = DSTU2ModelInfo.Instance.StructureDefinitionProvider.Provide("Patient");
            var inSummary = typeinfo.Elements.Where(e => e.InSummary).ToList();

            var nav = new ScopedNode(getXmlNode(tpXml));
            var masker = MaskingNode.ForSummary(nav);
            var output = masker.ToXml();

            var maskedChildren = masker.Children().ToList();
            Assert.IsTrue(maskedChildren.Count < inSummary.Count);
            Assert.IsTrue(maskedChildren.Select(c => c.Name).All(c => inSummary.Any(s => s.ElementName == c)));
        }

        [TestMethod]
        public void SummaryText()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "mask-text.xml"));
            var typeinfo = DSTU2ModelInfo.Instance.StructureDefinitionProvider.Provide("ValueSet");

            var nav = new ScopedNode(getXmlNode(tpXml));
            var masker = MaskingNode.ForText(nav);
            var output = masker.ToXml();

            var m = masker.Descendants().ToList();
            var maskedChildren = masker.Descendants().Count();
            Assert.AreEqual(8, maskedChildren);
        }

        [TestMethod]
        public void SummaryData()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "mask-text.xml"));
            var typeinfo = DSTU2ModelInfo.Instance.StructureDefinitionProvider.Provide("ValueSet");

            var nav = new ScopedNode(getXmlNode(tpXml));
            var masker = MaskingNode.ForData(nav);
            var output = masker.ToXml();

            var maskedChildren = masker.Descendants().Count();
            Assert.AreEqual(nav.Descendants().Count() - 3, maskedChildren);
        }

        [TestMethod]
        public void SummaryCountUsingStructureDefinitionSummaryProvider()
        {
            var tpXml = File.ReadAllText(Path.Combine("TestData", "mask-text.xml"));

            var nav = new ScopedNode(getXmlNodeSDSP(tpXml));
            var masker = MaskingNode.ForCount(nav);

            var maskedChildren = masker.Descendants().Count();
            Assert.AreEqual(maskedChildren, 2);

            ITypedElement getXmlNodeSDSP(string xml, FhirXmlParsingSettings s = null) =>
                XmlParsingHelpers.ParseToTypedElement(xml, new StructureDefinitionSummaryProvider(ZipSource.CreateValidationSource()), s);
        }
    }
}