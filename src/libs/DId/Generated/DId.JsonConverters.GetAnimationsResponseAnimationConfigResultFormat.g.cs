#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnimationsResponseAnimationConfigResultFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.GetAnimationsResponseAnimationConfigResultFormat>
    {
        /// <inheritdoc />
        public override global::DId.GetAnimationsResponseAnimationConfigResultFormat Read(
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
                        return global::DId.GetAnimationsResponseAnimationConfigResultFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.GetAnimationsResponseAnimationConfigResultFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.GetAnimationsResponseAnimationConfigResultFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.GetAnimationsResponseAnimationConfigResultFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.GetAnimationsResponseAnimationConfigResultFormatExtensions.ToValueString(value));
        }
    }
}
