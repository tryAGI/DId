
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStartEventDataEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatDividestart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStartEventDataEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStartEventDataEventType value)
        {
            return value switch
            {
                ChatStartEventDataEventType.ChatDividestart => "chat/start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStartEventDataEventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/start" => ChatStartEventDataEventType.ChatDividestart,
                _ => null,
            };
        }
    }
}