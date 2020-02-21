using System;
using System.Diagnostics;
using System.IO;
using FhirModel = Hl7.Fhir.Model;
using FhirModel2 = Hl7.Fhir.Model.DSTU2;
using FhirSerialization = Hl7.Fhir.Serialization;

namespace PerfTest
{
    class Program
    {
        static async System.Threading.Tasks.Task Main()
        {
            var bytes = File.ReadAllBytes(@"patient.json");

            const int count = 10_000;

            var sw = Stopwatch.StartNew();

            for (int i = 0; i < count; i++)
            {
                var stream = new MemoryStream(bytes);
                var jsonParser = new FhirSerialization.FhirJsonFastParser(FhirModel.Version.DSTU2);
                await jsonParser.ParseAsync(stream, System.Threading.CancellationToken.None);
            }
            sw.Stop();

            Console.WriteLine("JSON Parse FAST X {1:N0}: {0:N1}ms", sw.ElapsedMilliseconds, count);

            //sw = Stopwatch.StartNew();

            //var slowParser = new FhirSerialization.FhirJsonParser(FhirModel.Version.DSTU2);
            //for (int i = 0; i < count; i++)
            //{
            //    using (var stream = File.OpenRead("patient.json"))
            //    using (var reader = new StreamReader(stream))
            //    using (var jsonReader = new Newtonsoft.Json.JsonTextReader(reader))
            //    {
            //        slowParser.Parse(jsonReader);
            //    }
            //}
            //sw.Stop();

            //Console.WriteLine("JSON Parse Orig X {1:N0}: {0:N1}ms", sw.ElapsedMilliseconds, count);


            //var xml = File.ReadAllText(@"bundle.xml");

            //const int count = 10_000;

            //var xmlParser = new FhirSerialization.FhirXmlParser(FhirModel.Version.DSTU2);
            //FhirModel2.Bundle bundle = null;
            //var sw = Stopwatch.StartNew();

            //for (var i = 0; i < count; i++)
            //{
            //    bundle = xmlParser.Parse<FhirModel2.Bundle>(xml);
            //}
            //sw.Stop();

            //Console.WriteLine("XML Parse X {1:N0}: {0:N1}ms", sw.ElapsedMilliseconds, count);

            //if (xml != null) return;

            //var watch = Stopwatch.StartNew();

            //var jsonSerializer = new FhirSerialization.FhirJsonSerializer(FhirModel.Version.DSTU2);
            //jsonSerializer.SerializeToString(bundle);
            //watch.Restart();
            //for (var i = 0; i < count; i++)
            //{
            //    jsonSerializer.SerializeToString(bundle);
            //}
            //watch.Stop();
            //Console.WriteLine("JSON serialize X {1:N0}: {0:N1}ms", watch.ElapsedMilliseconds, count);

            //var jsonFastSerializer = new FhirSerialization.FhirJsonFastSerializer(FhirModel.Version.DSTU2);
            //jsonFastSerializer.SerializeToString(bundle);
            //watch.Restart();
            //for (var i = 0; i < count; i++)
            //{
            //    jsonFastSerializer.SerializeToString(bundle);
            //}
            //watch.Stop();
            //Console.WriteLine("JSON fast serialize X {1:N0}: {0:N1}ms", watch.ElapsedMilliseconds, count);

            //var xmlSerializer = new FhirSerialization.FhirXmlSerializer(FhirModel.Version.DSTU2);
            //xmlSerializer.SerializeToString(bundle);
            //watch.Restart();
            //for (var i = 0; i < count; i++)
            //{
            //    xmlSerializer.SerializeToString(bundle);
            //}
            //watch.Stop();
            //Console.WriteLine("XML serialize X {1:N0}: {0:N1}ms", watch.ElapsedMilliseconds, count);

            //var xmlFastSerializer = new FhirSerialization.FhirXmlFastSerializer(FhirModel.Version.DSTU2);
            //xmlFastSerializer.SerializeToString(bundle);
            //watch.Restart();
            //for (var i = 0; i < count; i++)
            //{
            //    xmlFastSerializer.SerializeToString(bundle);
            //}
            //watch.Stop();
            //Console.WriteLine("XML fast serialize X {1:N0}: {0:N1}ms", watch.ElapsedMilliseconds, count);
        }
    }

}
