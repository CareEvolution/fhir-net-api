using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using Hl7.Fhir.Model;
using FhirModel = Hl7.Fhir.Model;
using FhirModel4 = Hl7.Fhir.Model.R4;
using FhirSerialization = Hl7.Fhir.Serialization;

namespace PerfTest
{
    class Program
    {
        static void Main()
        {
            ParseXml();
        }

        static void ParseJson()
        {
            var json = File.ReadAllText(@"bundle.json");

            const int count = 100;

            JsonSerializer.Deserialize<FhirModel4.Bundle>(json, FhirSerialization.JsonSerializerOptionsExtensions.ForFhir(new JsonSerializerOptions(), FhirModel.Version.R4));
            var initialMemory = GC.GetAllocatedBytesForCurrentThread();
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                JsonSerializer.Deserialize<FhirModel4.Bundle>(json, FhirSerialization.JsonSerializerOptionsExtensions.ForFhir(new JsonSerializerOptions(), FhirModel.Version.R4));
            }
            watch.Stop();
            var memoryUsed = GC.GetAllocatedBytesForCurrentThread() - initialMemory; 
            Console.WriteLine("JSON fast parse X {1:N0}: {0:N1}ms, {2:N0} bytes", watch.ElapsedMilliseconds, count, memoryUsed);
        }

        static void ParseXml()
        {
            var xml = File.ReadAllText(@"bundle.xml");

            const int count = 100;

            var xmlParser = new FhirSerialization.FhirXmlParser(FhirModel.Version.R4);
            xmlParser.Parse<FhirModel4.Bundle>(xml);
            var initialMemory = GC.GetAllocatedBytesForCurrentThread();
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                xmlParser.Parse<FhirModel4.Bundle>(xml);
            }
            watch.Stop();
            var memoryUsed = GC.GetAllocatedBytesForCurrentThread() - initialMemory;
            Console.WriteLine("XML fast parse X {1:N0}: {0:N1}ms, {2:N0} bytes", watch.ElapsedMilliseconds, count, memoryUsed);
        }

        static void Serialize()
        {
            var xml = File.ReadAllText(@"bundle.xml");

            var xmlParser = new FhirSerialization.FhirXmlParser(FhirModel.Version.R4);
            var bundle = xmlParser.Parse<FhirModel4.Bundle>(xml);

            const int count = 100;

            var watch = Stopwatch.StartNew();

            var jsonFastSerializer = new FhirSerialization.FhirJsonFastSerializer(FhirModel.Version.R4);
            jsonFastSerializer.SerializeToString(bundle);
            for (var i = 0; i < count; i++)
            {
                jsonFastSerializer.SerializeToString(bundle);
            }
            watch.Stop();
            Console.WriteLine("JSON fast serialize: {0:N2}ms", (double)watch.ElapsedMilliseconds / count);

            var xmlFastSerializer = new FhirSerialization.FhirXmlFastSerializer(FhirModel.Version.R4);
            xmlFastSerializer.SerializeToString(bundle);
            watch.Restart();
            for (var i = 0; i < count; i++)
            {
                xmlFastSerializer.SerializeToString(bundle);
            }
            watch.Stop();
            Console.WriteLine("XML fast serialize: {0:N2}ms", (double)watch.ElapsedMilliseconds / count);
        }

        static void CreatePatientsDirectly(int count)
        {
            var watch = Stopwatch.StartNew();

            for (var i = 0; i < count; i++)
            {
               new FhirModel4.Patient();
            }
            watch.Stop();
            Console.WriteLine("Create directly: {0:N2} micros", watch.ElapsedMilliseconds * 1_000.0 / count);
        }

        static void CreatePatientsIndirectly(int count)
        {
            var watch = Stopwatch.StartNew();

            for (var i = 0; i < count; i++)
            {
                Create(() => new FhirModel4.Patient());
            }
            watch.Stop();
            Console.WriteLine("Create indirectly: {0:N2} micros", (double)watch.ElapsedMilliseconds * 1_000.0 / count);
        }

        static T Create<T>(Func<T> create) where T : Base, new()
        {
            return create();
        }
    }
}
