using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.FhirPath.DSTU2;
using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Serialization.DSTU2;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Tests;
using Hl7.FhirPath;
using Hl7.FhirPath.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Fhir
{
    [TestClass]
    public class PocoNavigatorTests
    {
#pragma warning disable 612,618
        [TestMethod]
        public void TestPocoPath()
        {
            // Ensure the FHIR extensions are registered
            ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();
            FhirPathCompiler.DefaultSymbolTable.Add("shortpathname",
            (object f) =>
            {
                if (f is IEnumerable<ITypedElement>)
                {
                    object[] bits = (f as IEnumerable<ITypedElement>).Select(i =>
                    {
                        return i is PocoElementNode ? (i as PocoElementNode).ShortPath : "?";
                    }).ToArray();
                    return FhirValueList.Create(bits);
                }
                return FhirValueList.Create(new object[] { "?" });
            });

            Patient p = new Patient
            {
                Active = true
            };
            p.ActiveElement.Id = "314";
            p.ActiveElement.AddExtension("http://something.org", new FhirBoolean(false));
            p.ActiveElement.AddExtension("http://something.org", new Integer(314));
            p.Telecom = new List<ContactPoint>
            {
                new ContactPoint(ContactPoint.ContactPointSystem.Phone, null, "555-phone")
            };
            p.Telecom[0].Rank = 1;

            Assert.IsTrue(new FhirString("Patient.active").IsExactly(p.Select("descendants().shortpathname()").FirstOrDefault()));

            var patient = p.ToTypedElement();

            Assert.AreEqual("Patient", patient.Location);

            var active = patient.Children("active").FirstOrDefault() as PocoElementNode;
            Assert.AreEqual("Patient.active[0]", active.Location);
            Assert.AreEqual("Patient.active", active.ShortPath);

            var firstActiveChild = active.Children(null).FirstOrDefault() as PocoElementNode;
            Assert.AreEqual("Patient.active[0].id[0]", firstActiveChild.Location);
            Assert.AreEqual("Patient.active.id", firstActiveChild.ShortPath);

            var secondActiveChild = active.Children(null).Skip(1).FirstOrDefault() as PocoElementNode;
            Assert.AreEqual("Patient.active[0].extension[0]", secondActiveChild.Location);
            Assert.AreEqual("Patient.active.extension[0]", secondActiveChild.ShortPath);

            var secondActiveGrandChild = secondActiveChild.Children(null).Skip(1).FirstOrDefault() as PocoElementNode;
            Assert.AreEqual("Patient.active[0].extension[0].value[0]", secondActiveGrandChild.Location);
            Assert.AreEqual("Patient.active.extension[0].value", secondActiveGrandChild.ShortPath);

            // Ensure that the original navigator hasn't changed
            Assert.AreEqual("Patient.active[0].extension[0]", secondActiveChild.Location);
            Assert.AreEqual("Patient.active.extension[0]", secondActiveChild.ShortPath);

            var thirdActiveGrandChild = active.Children(null).Skip(2).FirstOrDefault().Children().Skip(1).FirstOrDefault() as PocoElementNode;
            Assert.AreEqual("Patient.active[0].extension[1].value[0]", thirdActiveGrandChild.Location);
            Assert.AreEqual("Patient.active.extension[1].value", thirdActiveGrandChild.ShortPath);

            var telecom = patient.Children().Skip(1).FirstOrDefault().Children("system").FirstOrDefault() as PocoElementNode;
            Assert.AreEqual("Patient.telecom[0].system[0]", telecom.Location);
            Assert.AreEqual("Patient.telecom[0].system", telecom.ShortPath);

            // Now check navigation bits
            Assert.AreEqual("Patient.telecom[0].system",
                (p.ToTypedElement().Select("Patient.telecom.where(system='phone').system").First() as PocoElementNode).ShortPath);
            Assert.AreEqual("Patient.telecom[0].system",
                (patient.Select("Patient.telecom.where(system='phone').system").First() as PocoElementNode).ShortPath);
            Assert.AreEqual("Patient.telecom[0].system[0]",
                (patient.Select("Patient.telecom.where(system='phone').system").First() as PocoElementNode).Location);
            Assert.AreEqual("Patient.telecom[0].system",
                (patient.Select("Patient.telecom[0].system").First() as PocoElementNode).ShortPath);
        }
#pragma warning restore 612,618

        [TestMethod]
        public void PocoExtensionTest()
        {
            Patient p = new Patient
            {
                Active = true
            };
            p.ActiveElement.Id = "314";
            p.ActiveElement.AddExtension("http://something.org", new FhirBoolean(false));
            p.ActiveElement.AddExtension("http://something.org", new Integer(314));

            Assert.AreEqual(true, p.Scalar("Patient.active.first()"));
            Assert.AreEqual(true, p.Scalar("Patient.active[0]"));
            Assert.AreEqual("314", p.Scalar("Patient.active[0].id[0]"));

            var extensions = p.Select("Patient.active[0].extension");
            Assert.AreEqual(2, extensions.Count());
        }

        [TestMethod]
        public void PocoHasValueTest()
        {
            // Ensure the FHIR extensions are registered
            ElementNavFhirExtensions.PrepareFhirSymbolTableFunctions();

            Patient p = new Patient();

            Assert.AreEqual(false, p.Predicate("Patient.active.hasValue()"));
            Assert.AreEqual(false, p.Predicate("Patient.active.exists()"));

            p.Active = true;
            Assert.AreEqual(true, p.Predicate("Patient.active.hasValue()"));
            Assert.AreEqual(true, p.Predicate("Patient.active.exists()"));

            p.ActiveElement.AddExtension("http://something.org", new FhirBoolean(false));
            Assert.AreEqual(true, p.Predicate("Patient.active.hasValue()"));
            Assert.AreEqual(true, p.Predicate("Patient.active.exists()"));

            p.ActiveElement = new FhirBoolean();
            p.ActiveElement.AddExtension("http://something.org", new FhirBoolean(false));
            Assert.AreEqual(false, p.Predicate("Patient.active.hasValue()"));
            Assert.AreEqual(true, p.Predicate("Patient.active.exists()"));
        }

        [TestMethod]
        public void CompareToOtherElementNavigator()
        {
            var json = TestDataHelper.ReadTestData("TestPatient.json");
            var xml = TestDataHelper.ReadTestData("TestPatient.xml");

            var pocoP = new FhirJsonParser(DSTU2ModelInfo.Instance).Parse<Patient>(json).ToTypedElement();
            var jsonP = FhirJsonNode.Parse(json, settings: new FhirJsonParsingSettings { AllowJsonComments = true })
                .ToTypedElement(DSTU2ModelInfo.Instance.StructureDefinitionProvider);
            var xmlP = FhirXmlNode.Parse(xml).ToTypedElement(DSTU2ModelInfo.Instance.StructureDefinitionProvider);

            doCompare(pocoP, jsonP, "poco<->json");
            doCompare(pocoP, xmlP, "poco<->xml");

            void doCompare(ITypedElement one, ITypedElement two, string what)
            {
                var compare = one.IsEqualTo(two);

                if (compare.Success == false)
                {
                    Debug.WriteLine($"{what}: Difference in {compare.Details} at {compare.FailureLocation}");
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void IncorrectPathInTwoSuccessiveRepeatingMembers()
        {
            var xml = File.ReadAllText(@"TestData\issue-444-testdata.xml");
            var cs = new FhirXmlParser(DSTU2ModelInfo.Instance).Parse<Conformance>(xml);
            var nav = cs.ToTypedElement();

            var rest = nav.Children().Where(c => c.Name == "rest").FirstOrDefault();

            Assert.IsNotNull(rest);

            Assert.IsTrue(rest.Location.Contains("Conformance.rest[0]"));
        }


        [TestMethod]
        public void PocoNavPerformance()
        {
            var xml = File.ReadAllText(@"TestData\fp-test-patient.xml");
            var cs = new FhirXmlParser(DSTU2ModelInfo.Instance).Parse<Patient>(xml);
            var nav = cs.ToTypedElement();

            ElementNavPerformance(nav);
        }

        private static void ElementNavPerformance(ITypedElement nav)
        {
            // run extraction once to allow for caching
            extract();

            //System.Threading.Thread.Sleep(20000);

            var sw = new Stopwatch();
            sw.Start();
            for (var i = 0; i < 5_000; i++)
            {
                extract();
            }
            sw.Stop();

            Debug.WriteLine($"Navigating took {sw.ElapsedMilliseconds / 5 } micros");

            void extract()
            {
                var usual = nav.Children("identifier").First().Children("use").First().Value;
                var phone = nav.Children("telecom").First().Children("system").First().Value;
                var prefs = nav.Children("communication").Where(c => c.Children("preferred").Any(pr => pr.Value is string s && s == "true")).Count();
                var link = nav.Children("link").Children("other").Children("reference");
            }
        }


    }

}
