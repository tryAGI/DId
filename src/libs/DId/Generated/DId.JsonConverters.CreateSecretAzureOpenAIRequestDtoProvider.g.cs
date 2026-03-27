#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecretAzureOpenAIRequestDtoProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateSecretAzureOpenAIRequestDtoProvider>
    {
        /// <inheritdoc />
        public override global::DId.CreateSecretAzureOpenAIRequestDtoProvider Read(
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
                        return global::DId.CreateSecretAzureOpenAIRequestDtoProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateSecretAzureOpenAIRequestDtoProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateSecretAzureOpenAIRequestDtoProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateSecretAzureOpenAIRequestDtoProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.CreateSecretAzureOpenAIRequestDtoProviderExtensions.ToValueString(value));
        }
    }
}
