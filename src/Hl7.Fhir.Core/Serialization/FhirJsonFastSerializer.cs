using System;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.Serialization
{
    public class FhirJsonFastSerializer : BaseFhirSerializer
    {
        public FhirJsonFastSerializer(Model.Version version, bool unsafeRelaxedJsonEscaping = true) : base(version)
        {
            UnsafeRelaxedJsonEscaping = unsafeRelaxedJsonEscaping;
        }

        public FhirJsonFastSerializer(SerializerSettings settings, bool unsafeRelaxedJsonEscaping = true) : base(settings)
        {
            UnsafeRelaxedJsonEscaping = unsafeRelaxedJsonEscaping;
        }

        public bool UnsafeRelaxedJsonEscaping { get; }

        public string SerializeToString(Base instance, Rest.SummaryType summary = Rest.SummaryType.False, string[] elements = null) =>
            WriteJsonToString(jsonWriter => Serialize(instance, jsonWriter, summary, elements), UnsafeRelaxedJsonEscaping, Settings.Pretty);

        public byte[] SerializeToBytes(Base instance, Rest.SummaryType summary = Rest.SummaryType.False, string[] elements = null) =>
            WriteJsonToBytes(jsonWriter => Serialize(instance, jsonWriter, summary, elements), UnsafeRelaxedJsonEscaping);

        public void Serialize(Base instance, Utf8JsonWriter writer, Rest.SummaryType summary = Rest.SummaryType.False, string[] elements = null)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (writer == null) throw new ArgumentNullException(nameof(writer));

            var serializerSink = new JsonSerializerSink(writer, Settings.Version, summary, elements);
            instance.Serialize(serializerSink);
        }

        public JsonWriterOptions CreateJsonWriterOptions() => CreateJsonWriterOptions(UnsafeRelaxedJsonEscaping, Settings.Pretty);

        private static string WriteJsonToString(Action<Utf8JsonWriter> serializer, bool unsafeRelaxedJsonEscaping, bool pretty)
        {
            var memoryStream = WriteJsonToStream(serializer, unsafeRelaxedJsonEscaping, pretty);
            return Encoding.UTF8.GetString(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        private static byte[] WriteJsonToBytes(Action<Utf8JsonWriter> serializer, bool unsafeRelaxedJsonEscaping)
        {
            var memoryStream = WriteJsonToStream(serializer, unsafeRelaxedJsonEscaping, pretty: false);
            return memoryStream.ToArray();
        }

        private static MemoryStream WriteJsonToStream(Action<Utf8JsonWriter> serializer, bool unsafeRelaxedJsonEscaping, bool pretty)
        {
            var options = new JsonWriterOptions
            {
                Indented = pretty,
                Encoder = unsafeRelaxedJsonEscaping ?
                    JavaScriptEncoder.UnsafeRelaxedJsonEscaping :
                    JavaScriptEncoder.Default
            };
            var destination = new MemoryStream();
            using (var jsonWriter = new Utf8JsonWriter(destination, options))
            {
                serializer(jsonWriter);
            }
            return destination;
        }

        private static JsonWriterOptions CreateJsonWriterOptions(bool unsafeRelaxedJsonEscaping, bool pretty) =>
            new JsonWriterOptions
            {
                Indented = pretty,
                Encoder = unsafeRelaxedJsonEscaping ?
                    JavaScriptEncoder.UnsafeRelaxedJsonEscaping :
                    JavaScriptEncoder.Default
            };
    }
}
