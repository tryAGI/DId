#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class TalkAgentPresenterTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.TalkAgentPresenterType?>
    {
        /// <inheritdoc />
        public override global::DId.TalkAgentPresenterType? Read(
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
                        return global::DId.TalkAgentPresenterTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.TalkAgentPresenterType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.TalkAgentPresenterType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.TalkAgentPresenterType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.TalkAgentPresenterTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
