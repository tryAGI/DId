#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRequestLlmVariant5ModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateRequestLlmVariant5Model?>
    {
        /// <inheritdoc />
        public override global::DId.CreateRequestLlmVariant5Model? Read(
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
                        return global::DId.CreateRequestLlmVariant5ModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateRequestLlmVariant5Model)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateRequestLlmVariant5Model?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateRequestLlmVariant5Model? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateRequestLlmVariant5ModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
