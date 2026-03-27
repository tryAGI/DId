#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class ElevenlabsStreamTtsProviderTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.ElevenlabsStreamTtsProviderType?>
    {
        /// <inheritdoc />
        public override global::DId.ElevenlabsStreamTtsProviderType? Read(
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
                        return global::DId.ElevenlabsStreamTtsProviderTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.ElevenlabsStreamTtsProviderType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.ElevenlabsStreamTtsProviderType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.ElevenlabsStreamTtsProviderType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.ElevenlabsStreamTtsProviderTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
