#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetClipResponseConfigResultFormat2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GetClipResponseConfigResultFormat2?>
    {
        /// <inheritdoc />
        public override global::DId.GetClipResponseConfigResultFormat2? Read(
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
                        return global::DId.GetClipResponseConfigResultFormat2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.GetClipResponseConfigResultFormat2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.GetClipResponseConfigResultFormat2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GetClipResponseConfigResultFormat2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.GetClipResponseConfigResultFormat2Extensions.ToValueString(value.Value));
            }
        }
    }
}
