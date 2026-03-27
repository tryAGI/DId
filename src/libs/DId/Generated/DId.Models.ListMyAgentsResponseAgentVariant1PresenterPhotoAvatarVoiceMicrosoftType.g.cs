
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}