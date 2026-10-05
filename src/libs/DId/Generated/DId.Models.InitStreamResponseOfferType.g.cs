
#nullable enable

namespace DId
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    public enum InitStreamResponseOfferType
    {
        /// <summary>
        ///
        /// </summary>
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InitStreamResponseOfferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitStreamResponseOfferType value)
        {
            return value switch
            {
                InitStreamResponseOfferType.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitStreamResponseOfferType? ToEnum(string value)
        {
            return value switch
            {
                "offer" => InitStreamResponseOfferType.Offer,
                _ => null,
            };
        }
    }
}