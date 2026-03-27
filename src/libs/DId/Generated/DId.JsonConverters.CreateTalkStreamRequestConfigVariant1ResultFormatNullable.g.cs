#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkStreamRequestConfigVariant1ResultFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat?>
    {
        /// <inheritdoc />
        public override global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat? Read(
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
                        return global::DId.CreateTalkStreamRequestConfigVariant1ResultFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.CreateTalkStreamRequestConfigVariant1ResultFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
