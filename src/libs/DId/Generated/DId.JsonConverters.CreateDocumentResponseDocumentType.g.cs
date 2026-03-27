#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDocumentResponseDocumentTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateDocumentResponseDocumentType>
    {
        /// <inheritdoc />
        public override global::DId.CreateDocumentResponseDocumentType Read(
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
                        return global::DId.CreateDocumentResponseDocumentTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.CreateDocumentResponseDocumentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.CreateDocumentResponseDocumentType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateDocumentResponseDocumentType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DId.CreateDocumentResponseDocumentTypeExtensions.ToValueString(value));
        }
    }
}
