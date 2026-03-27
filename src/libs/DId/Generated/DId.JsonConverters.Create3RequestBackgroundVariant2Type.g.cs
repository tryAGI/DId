#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create3RequestBackgroundVariant2TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.Create3RequestBackgroundVariant2Type>
    {
        /// <inheritdoc />
        public override global::DId.Create3RequestBackgroundVariant2Type Read(
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
                        return global::DId.Create3RequestBackgroundVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.Create3RequestBackgroundVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.Create3RequestBackgroundVariant2Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.Create3RequestBackgroundVariant2Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.Create3RequestBackgroundVariant2TypeExtensions.ToValueString(value));
        }
    }
}
