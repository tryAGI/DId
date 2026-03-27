#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class InitTalkStreamRequestFaceOverlapJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.InitTalkStreamRequestFaceOverlap>
    {
        /// <inheritdoc />
        public override global::DId.InitTalkStreamRequestFaceOverlap Read(
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
                        return global::DId.InitTalkStreamRequestFaceOverlapExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.InitTalkStreamRequestFaceOverlap)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.InitTalkStreamRequestFaceOverlap);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.InitTalkStreamRequestFaceOverlap value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.InitTalkStreamRequestFaceOverlapExtensions.ToValueString(value));
        }
    }
}
