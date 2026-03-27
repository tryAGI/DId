#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkResponseDtoStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateTalkResponseDtoStatus>
    {
        /// <inheritdoc />
        public override global::DId.CreateTalkResponseDtoStatus Read(
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
                        return global::DId.CreateTalkResponseDtoStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateTalkResponseDtoStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateTalkResponseDtoStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateTalkResponseDtoStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.CreateTalkResponseDtoStatusExtensions.ToValueString(value));
        }
    }
}
