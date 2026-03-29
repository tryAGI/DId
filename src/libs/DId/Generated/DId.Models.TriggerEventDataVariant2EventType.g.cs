
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerEventDataVariant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatDividestart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerEventDataVariant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerEventDataVariant2EventType value)
        {
            return value switch
            {
                TriggerEventDataVariant2EventType.ChatDividestart => "chat/start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerEventDataVariant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/start" => TriggerEventDataVariant2EventType.ChatDividestart,
                _ => null,
            };
        }
    }
}