#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteResponseVariant1LlmDIdProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.DeleteResponseVariant1LlmDIdProvider>
    {
        /// <inheritdoc />
        public override global::DId.DeleteResponseVariant1LlmDIdProvider Read(
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
                        return global::DId.DeleteResponseVariant1LlmDIdProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.DeleteResponseVariant1LlmDIdProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.DeleteResponseVariant1LlmDIdProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.DeleteResponseVariant1LlmDIdProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.DeleteResponseVariant1LlmDIdProviderExtensions.ToValueString(value));
        }
    }
}
