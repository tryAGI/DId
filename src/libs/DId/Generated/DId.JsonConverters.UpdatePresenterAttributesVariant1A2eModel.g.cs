#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdatePresenterAttributesVariant1A2eModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.UpdatePresenterAttributesVariant1A2eModel>
    {
        /// <inheritdoc />
        public override global::DId.UpdatePresenterAttributesVariant1A2eModel Read(
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
                        return global::DId.UpdatePresenterAttributesVariant1A2eModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.UpdatePresenterAttributesVariant1A2eModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.UpdatePresenterAttributesVariant1A2eModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.UpdatePresenterAttributesVariant1A2eModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.UpdatePresenterAttributesVariant1A2eModelExtensions.ToValueString(value));
        }
    }
}
