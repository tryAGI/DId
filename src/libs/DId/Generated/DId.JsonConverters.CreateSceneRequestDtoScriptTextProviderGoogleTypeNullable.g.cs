#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSceneRequestDtoScriptTextProviderGoogleTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType?>
    {
        /// <inheritdoc />
        public override global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType? Read(
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
                        return global::DId.CreateSceneRequestDtoScriptTextProviderGoogleTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateSceneRequestDtoScriptTextProviderGoogleTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
