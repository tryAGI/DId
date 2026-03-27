#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAuthSecretRequestDtoApiKeyTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.UpdateAuthSecretRequestDtoApiKeyType>
    {
        /// <inheritdoc />
        public override global::DId.UpdateAuthSecretRequestDtoApiKeyType Read(
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
                        return global::DId.UpdateAuthSecretRequestDtoApiKeyTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.UpdateAuthSecretRequestDtoApiKeyType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.UpdateAuthSecretRequestDtoApiKeyType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.UpdateAuthSecretRequestDtoApiKeyType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.UpdateAuthSecretRequestDtoApiKeyTypeExtensions.ToValueString(value));
        }
    }
}
