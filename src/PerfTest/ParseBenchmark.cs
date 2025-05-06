using BenchmarkDotNet.Attributes;
using System.IO;
using System.Text.Json;
using System.Xml;
using FhirModel = Hl7.Fhir.Model;
using FhirModel4 = Hl7.Fhir.Model.R4;
using FhirSerialization = Hl7.Fhir.Serialization;

namespace PerfTest
{
    [MemoryDiagnoser]
    public class ParseBenchmark
    {
        [GlobalSetup]
        public void Setup()
        {
            _bundleJson = File.ReadAllText(@"bundle.json");
            _bundleXml = File.ReadAllText(@"bundle.xml");
        }

        [Benchmark]
        public FhirModel4.Bundle ParseJsonPermissive() =>
            JsonSerializer.Deserialize<FhirModel4.Bundle>( _bundleJson, _jsonSerializerOptionsPermissive );

        [Benchmark]
        public FhirModel4.Bundle ParseJsonStrict() =>
            JsonSerializer.Deserialize<FhirModel4.Bundle>(_bundleJson, _jsonSerializerOptionsStrict);

        [Benchmark]
        public FhirModel4.Bundle ParseXml()
        {
            using (var stringReader = new StringReader(_bundleXml))
            using(var xmlReader = XmlReader.Create(stringReader))
            {
                return _xmlParser.Parse<FhirModel4.Bundle>(_bundleXml);
            }
        }

        private string _bundleJson;
        private string _bundleXml;

        private readonly JsonSerializerOptions _jsonSerializerOptionsPermissive = FhirSerialization.JsonSerializerOptionsExtensions.ForFhir(
            new JsonSerializerOptions(),
            new FhirSerialization.ParserSettings(FhirModel.Version.R4) { PermissiveParsing = true }
        );
        private readonly JsonSerializerOptions _jsonSerializerOptionsStrict = FhirSerialization.JsonSerializerOptionsExtensions.ForFhir(
            new JsonSerializerOptions(),
            new FhirSerialization.ParserSettings(FhirModel.Version.R4) { PermissiveParsing = false }
        );
        private readonly FhirSerialization.FhirXmlParser _xmlParser = new FhirSerialization.FhirXmlParser(FhirModel.Version.R4);
    }
}
