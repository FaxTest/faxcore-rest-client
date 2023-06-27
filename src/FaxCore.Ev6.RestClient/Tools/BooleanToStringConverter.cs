using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Tools
{
    public class BooleanToStringConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.True)
                return true;
            if (reader.TokenType == JsonTokenType.False)
                return false;
            if (reader.TokenType == JsonTokenType.String && reader.GetString() == "Yes")
                return true;
            if (reader.TokenType == JsonTokenType.String && reader.GetString() == "No") return false;

            throw new JsonException("Unable to parse boolean value.");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            var stringValue = value ? "Yes" : "No";
            writer.WriteStringValue(stringValue);
        }
    }
}