using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.Serialization
{
    public static class JsonSerializerOptionsExtensions
    {
        public static JsonSerializerOptions ForFhir(this JsonSerializerOptions options, Model.Version version)
            => ForFhirPrimitive(options, new ParserSettings(version));

        public static JsonSerializerOptions ForFhir(this JsonSerializerOptions options, ParserSettings settings)
        {
            if (settings == null) throw new ArgumentNullException(nameof(settings));
            return ForFhirPrimitive(options, settings.Clone());
        }

        private static JsonSerializerOptions ForFhirPrimitive(this JsonSerializerOptions options, ParserSettings settings)
        {
            var result = new JsonSerializerOptions(options);
            result.Converters.Add(new FhirResourceJsonConverter(settings));
            result.Converters.Add(new FhirDataTypeJsonConverterFactory(settings));
            if (settings.PermissiveParsing)
            {
                // The old parser always allowed commas after the last element in an array or object, here we do that only in PermissiveParsing mode
                result.AllowTrailingCommas = true;
            }
            return result;
        }
    }

    internal class FhirResourceJsonConverter : JsonConverter<Resource>
    {
        public FhirResourceJsonConverter(ParserSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(Resource).IsAssignableFrom(typeToConvert);
        }

        public override Resource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var source = new JsonSource(ref reader, _settings);
            try
            {
                var result = source.GetResource(typeToConvert);
                if (!typeToConvert.IsAssignableFrom(result.GetType()))
                {
                    throw source.CreateWrongResourceTypeException(typeToConvert, result);
                }
                source.GetReader(ref reader);
                return result;
            }
            catch (SourceException jsonSourceException)
            {
                throw new JsonException(jsonSourceException.Message, jsonSourceException.Path, jsonSourceException.LineNumber, jsonSourceException.BytePositionInLine);
            }
        }

        public override void Write(Utf8JsonWriter writer, Resource value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        private readonly ParserSettings _settings;
    }

    public class FhirDataTypeJsonConverterFactory : JsonConverterFactory
    {
        public FhirDataTypeJsonConverterFactory(ParserSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(Base).IsAssignableFrom(typeToConvert)
                && !typeof(Resource).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return (JsonConverter)Activator.CreateInstance(
                typeof(FhirDataTypeJsonConverter<>)
                    .MakeGenericType(new Type[] { typeToConvert }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { _settings },
                culture: null);
        }

        private readonly ParserSettings _settings;
    }

    internal class FhirDataTypeJsonConverter<TBase> : JsonConverter<TBase> where TBase : Base
    {
        public FhirDataTypeJsonConverter(ParserSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public override TBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var source = new JsonSource(ref reader, _settings);
            try
            {
                var result = (TBase)source.GetDataType(typeToConvert);
                source.GetReader(ref reader);
                return result;
            }
            catch (SourceException jsonSourceException)
            {
                throw new JsonException(jsonSourceException.Message, jsonSourceException.Path, jsonSourceException.LineNumber, jsonSourceException.BytePositionInLine);
            }
        }

        public override void Write(Utf8JsonWriter writer, TBase value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        private readonly ParserSettings _settings;
    }
}
