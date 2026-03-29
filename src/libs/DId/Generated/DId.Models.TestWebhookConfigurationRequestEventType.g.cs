
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestWebhookConfigurationRequestEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatDivideend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestWebhookConfigurationRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestWebhookConfigurationRequestEventType value)
        {
            return value switch
            {
                TestWebhookConfigurationRequestEventType.ChatDivideend => "chat/end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestWebhookConfigurationRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/end" => TestWebhookConfigurationRequestEventType.ChatDivideend,
                _ => null,
            };
        }
    }
}