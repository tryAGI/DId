#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkRequestScriptVariant1ProviderGoogleTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType?>
    {
        /// <inheritdoc />
        public override global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType? Read(
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
                        return global::DId.CreateTalkRequestScriptVariant1ProviderGoogleTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateTalkRequestScriptVariant1ProviderGoogleTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
