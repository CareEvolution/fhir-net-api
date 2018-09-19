﻿using System;
using System.Linq;
using Hl7.Fhir.Model.R4;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Rest.R4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Fhir.Core.AsyncTests
{
    [TestClass]
    public class ReadAsyncTests
    {
        private string _endpoint = "https://api.hspconsortium.org/rpineda/open";

        [TestMethod]
        [TestCategory("IntegrationTest")]
        public async System.Threading.Tasks.Task Read_UsingResourceIdentity_ResultReturnedWebClient()
        {
            var client = new FhirClient(_endpoint)
            {
                PreferredFormat = ResourceFormat.Json,
                PreferredReturn = Prefer.ReturnRepresentation
            };

            Patient p = await client.ReadAsync<Patient>(new ResourceIdentity("/Patient/SMART-1288992"));
            Assert.IsNotNull(p);
            Assert.IsNotNull(p.Name[0].Given);
            Assert.IsNotNull(p.Name[0].Family);
            Console.WriteLine($"NAME: {p.Name[0].Given.FirstOrDefault()} {p.Name[0].Family.FirstOrDefault()}");
            Console.WriteLine("Test Completed");
        }

        [TestMethod]
        [TestCategory("IntegrationTest")]
        public async System.Threading.Tasks.Task Read_UsingLocationString_ResultReturnedWebClient()
        {
            var client = new FhirClient(_endpoint)
            {
                PreferredFormat = ResourceFormat.Json,
                PreferredReturn = Prefer.ReturnRepresentation
            };

            Patient p = await client.ReadAsync<Patient>("/Patient/SMART-1288992");
            Assert.IsNotNull(p);
            Assert.IsNotNull(p.Name[0].Given);
            Assert.IsNotNull(p.Name[0].Family);
            Console.WriteLine($"NAME: {p.Name[0].Given.FirstOrDefault()} {p.Name[0].Family.FirstOrDefault()}");
            Console.WriteLine("Test Completed");
        }
    }
}