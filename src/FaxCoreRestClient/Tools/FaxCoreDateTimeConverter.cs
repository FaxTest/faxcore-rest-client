using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Tools
{
    public class FaxCoreDateTimeConverter : JsonConverter<DateTime>
    {
        private const string DateTimeFormat = "ddd, dd MMM yyyy HH:mm:ss 'GMT'";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString(), DateTimeFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(DateTimeFormat, CultureInfo.InvariantCulture));
        }
    }

    public class FaxCoreRequestDateTimeConverter : JsonConverter<DateTime>
    {
        private const string DateTimeFormat = "yyyyMMddd HH:mm:ss";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString(), DateTimeFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(DateTimeFormat, CultureInfo.InvariantCulture));
        }
    }
}