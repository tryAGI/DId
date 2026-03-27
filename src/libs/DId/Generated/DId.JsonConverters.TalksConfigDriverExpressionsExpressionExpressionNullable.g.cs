#nullable enable

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public sealed class TalksConfigDriverExpressionsExpressionExpressionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.TalksConfigDriverExpressionsExpressionExpression?>
    {
        /// <inheritdoc />
        public override global::DId.TalksConfigDriverExpressionsExpressionExpression? Read(
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
                        return global::DId.TalksConfigDriverExpressionsExpressionExpressionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DId.TalksConfigDriverExpressionsExpressionExpression)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DId.TalksConfigDriverExpressionsExpressionExpression?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.TalksConfigDriverExpressionsExpressionExpression? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DId.TalksConfigDriverExpressionsExpressionExpressionExtensions.ToValueString(value.Value));
            }
        }
    }
}
