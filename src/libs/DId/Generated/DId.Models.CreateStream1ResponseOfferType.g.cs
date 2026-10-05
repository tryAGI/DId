
#nullable enable

namespace DId
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    public enum CreateStream1ResponseOfferType
    {
        /// <summary>
        ///
        /// </summary>
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStream1ResponseOfferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStream1ResponseOfferType value)
        {
            return value switch
            {
                CreateStream1ResponseOfferType.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStream1ResponseOfferType? ToEnum(string value)
        {
            return value switch
            {
                "offer" => CreateStream1ResponseOfferType.Offer,
                _ => null,
            };
        }
    }
}