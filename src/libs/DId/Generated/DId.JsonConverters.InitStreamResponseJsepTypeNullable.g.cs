#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class InitStreamResponseJsepTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.InitStreamResponseJsepType?>
    {
        /// <inheritdoc />
        public override global::DId.InitStreamResponseJsepType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DId.InitStreamResponseJsepTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.InitStreamResponseJsepType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.InitStreamResponseJsepType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.InitStreamResponseJsepType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.InitStreamResponseJsepTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
