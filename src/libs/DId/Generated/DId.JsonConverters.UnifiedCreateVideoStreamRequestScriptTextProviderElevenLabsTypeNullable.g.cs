#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType?>
    {
        /// <inheritdoc />
        public override global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType? Read(
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
                        return global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
