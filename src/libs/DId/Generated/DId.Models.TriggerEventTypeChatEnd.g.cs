
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerEventTypeChatEnd
    {
        /// <summary>
        /// 
        /// </summary>
        ChatDivideend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerEventTypeChatEndExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerEventTypeChatEnd value)
        {
            return value switch
            {
                TriggerEventTypeChatEnd.ChatDivideend => "chat/end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerEventTypeChatEnd? ToEnum(string value)
        {
            return value switch
            {
                "chat/end" => TriggerEventTypeChatEnd.ChatDivideend,
                _ => null,
            };
        }
    }
}