using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;
using System.IO;
using System.Text.Json;
using System.Xml;
using FhirModel = Hl7.Fhir.Model;
using FhirModel4 = Hl7.Fhir.Model.R4;
using FhirSerialization = Hl7.Fhir.Serialization;

namespace PerfTest
{
    [MemoryDiagnoser]
    [CPUUsageDiagnoser]
    public class SerializeBenchmark
    {
        [GlobalSetup]
        public void Setup()
        {
            var bundleJson = File.ReadAllText(@"bundle.json");

            var jsonParser = new FhirSerialization.FhirJsonFastParser(FhirModel.Version.R4);
            _bundle = jsonParser.Parse<FhirModel4.Bundle>(bundleJson);
        }

        [Benchmark]
        public void SerializeToJson()
        {
            var jsonWriter = new Utf8JsonWriter(new MemoryStream(), _jsonFastSerializer.CreateJsonWriterOptions());
            _jsonFastSerializer.Serialize(_bundle, jsonWriter);
        }

        [Benchmark]
        public void SerializeToXml()
        {
            SerializeToXml(new MemoryStream());
        }

        private void SerializeToXml( Stream destination )
        {
            using (var textWriter = new InvalidCharRemovingXmlWriter(destination))
            using (var xmlWriter = XmlWriter.Create(textWriter, _xmlWriterSetting))
            {
                _xmlFastSerializer.Serialize(_bundle, xmlWriter);
            }
        }

        private FhirModel4.Bundle _bundle;
        private readonly FhirSerialization.FhirJsonFastSerializer _jsonFastSerializer = new FhirSerialization.FhirJsonFastSerializer(FhirModel.Version.R4);
        private readonly FhirSerialization.FhirXmlFastSerializer _xmlFastSerializer = new FhirSerialization.FhirXmlFastSerializer(FhirModel.Version.R4);
        private readonly XmlWriterSettings _xmlWriterSetting = new XmlWriterSettings
        {
            OmitXmlDeclaration = true,
            NewLineHandling = NewLineHandling.Entitize,
            Indent = false,
        };
    }
}
