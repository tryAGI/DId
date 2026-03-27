#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTalksDtoTalkConfigResultFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GetTalksDtoTalkConfigResultFormat>
    {
        /// <inheritdoc />
        public override global::DId.GetTalksDtoTalkConfigResultFormat Read(
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
                        return global::DId.GetTalksDtoTalkConfigResultFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.GetTalksDtoTalkConfigResultFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.GetTalksDtoTalkConfigResultFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GetTalksDtoTalkConfigResultFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.GetTalksDtoTalkConfigResultFormatExtensions.ToValueString(value));
        }
    }
}
