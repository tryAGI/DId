
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestWebhookRequestDtoEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatDivideend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestWebhookRequestDtoEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestWebhookRequestDtoEventType value)
        {
            return value switch
            {
                TestWebhookRequestDtoEventType.ChatDivideend => "chat/end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestWebhookRequestDtoEventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/end" => TestWebhookRequestDtoEventType.ChatDivideend,
                _ => null,
            };
        }
    }
}