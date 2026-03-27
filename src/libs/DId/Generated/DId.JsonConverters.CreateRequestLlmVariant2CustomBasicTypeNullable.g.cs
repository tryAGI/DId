#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRequestLlmVariant2CustomBasicTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateRequestLlmVariant2CustomBasicType?>
    {
        /// <inheritdoc />
        public override global::DId.CreateRequestLlmVariant2CustomBasicType? Read(
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
                        return global::DId.CreateRequestLlmVariant2CustomBasicTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateRequestLlmVariant2CustomBasicType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateRequestLlmVariant2CustomBasicType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateRequestLlmVariant2CustomBasicType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateRequestLlmVariant2CustomBasicTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
