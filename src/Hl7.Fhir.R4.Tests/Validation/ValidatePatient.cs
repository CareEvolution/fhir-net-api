﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml;
using Hl7.Fhir.Model.R4;
using Hl7.Fhir.Serialization.R4;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.R4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Fhir.Tests.Validation
{
    [TestClass]
	public class ValidatePatient
    {
        [TestMethod]
        public void ValidateDemoPatient()
        {
            var s = new StringReader(TestDataHelper.ReadTestData(@"TestPatient.xml"));

            var patient = new FhirXmlParser().Parse<Patient>(XmlReader.Create(s));

            ICollection<ValidationResult> results = new List<ValidationResult>();

            foreach (var contained in patient.Contained) ((DomainResource)contained).Text = new Narrative() { Div = "<wrong />" };

            Assert.IsFalse(DotNetAttributeValidation.TryValidate(patient, results, true));
            Assert.IsTrue(results.Count > 0);

            results.Clear();
            foreach (DomainResource contained in patient.Contained) contained.Text = null;

            // Try again
            Assert.IsTrue(DotNetAttributeValidation.TryValidate(patient, results, true));

            patient.Identifier[0].System = "urn:oid:crap really not valid";

            results = new List<ValidationResult>();
            
            Assert.IsFalse(DotNetAttributeValidation.TryValidate(patient, results, true));
            Assert.IsTrue(results.Count > 0);
        }
    }
}