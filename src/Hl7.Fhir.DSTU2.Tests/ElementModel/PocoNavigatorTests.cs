using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model.DSTU2;

namespace Hl7.Fhir.Core.Tests.ElementModel
{
    [TestClass]
    public class PocoNavigatorTests
    {
        [TestMethod]
        public void PocoTypedElementPocoRoundtrip()
        {
            var patient = new Patient();
            var actual = patient.ToTypedElement().ToPoco<Patient>(DSTU2ModelInfo.Instance);
            Assert.IsNotNull(actual, "Roundtrip POCO -> ITypedElement -> POCO should succeed.");
        }
    }
}
