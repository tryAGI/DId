
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum TalkAgentPresenterVoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TalkAgentPresenterVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalkAgentPresenterVoiceMicrosoftType value)
        {
            return value switch
            {
                TalkAgentPresenterVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalkAgentPresenterVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => TalkAgentPresenterVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}