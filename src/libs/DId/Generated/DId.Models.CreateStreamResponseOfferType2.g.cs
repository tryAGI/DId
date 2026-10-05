
#nullable enable

namespace DId
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    public enum CreateStreamResponseOfferType2
    {
        /// <summary>
        ///
        /// </summary>
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStreamResponseOfferType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamResponseOfferType2 value)
        {
            return value switch
            {
                CreateStreamResponseOfferType2.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamResponseOfferType2? ToEnum(string value)
        {
            return value switch
            {
                "offer" => CreateStreamResponseOfferType2.Offer,
                _ => null,
            };
        }
    }
}