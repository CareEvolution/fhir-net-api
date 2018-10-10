using Hl7.Fhir.Model.DSTU2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Fhir.Serialization.Tests
{
    [TestClass]
    public class PocoSerializationInfoTests
    {
        //[TestMethod]
        //public void TestResourceInfo()
        //{
        //    var ip = new PocoModelMetadataProvider();
        //    Assert.IsTrue(ip.IsResource("Patient"));
        //    Assert.IsTrue(ip.IsResource("DomainResource"));
        //    Assert.IsTrue(ip.IsResource("Resource"));
        //    Assert.IsFalse(ip.IsResource("Identifier"));
        //}

        [TestMethod]
        public void TestCanLocateTypes() => SerializationInfoTestHelpers.TestCanLocateTypes(DSTU2ModelInfo.Instance.StructureDefinitionProvider);

        [TestMethod]
        public void TestCanGetElements() => SerializationInfoTestHelpers.TestCanGetElements(DSTU2ModelInfo.Instance.StructureDefinitionProvider);

        [TestMethod]
        public void TestSpecialTypes() => SerializationInfoTestHelpers.TestSpecialTypes(DSTU2ModelInfo.Instance.StructureDefinitionProvider);

        [TestMethod]
        public void TestProvidedOrder() => SerializationInfoTestHelpers.TestProvidedOrder(DSTU2ModelInfo.Instance.StructureDefinitionProvider);

        [TestMethod]
        public void TestValueIsNotAChild() => SerializationInfoTestHelpers.TestValueIsNotAChild(DSTU2ModelInfo.Instance.StructureDefinitionProvider);
    }
}
