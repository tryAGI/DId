
#nullable enable

namespace DId
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    public enum AssetDtoVariant1MimeType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageDividegif,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividepng,
        /// <summary>
        /// 
        /// </summary>
        ImageDividewebp,
        /// <summary>
        /// 
        /// </summary>
        VideoDividematroska,
        /// <summary>
        /// 
        /// </summary>
        VideoDividemp4,
        /// <summary>
        /// 
        /// </summary>
        VideoDividequicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoDividewebm,
        /// <summary>
        /// 
        /// </summary>
        VideoDividexMatroska,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetDtoVariant1MimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetDtoVariant1MimeType value)
        {
            return value switch
            {
                AssetDtoVariant1MimeType.ImageDividegif => "image/gif",
                AssetDtoVariant1MimeType.ImageDividejpeg => "image/jpeg",
                AssetDtoVariant1MimeType.ImageDividejpg => "image/jpg",
                AssetDtoVariant1MimeType.ImageDividepng => "image/png",
                AssetDtoVariant1MimeType.ImageDividewebp => "image/webp",
                AssetDtoVariant1MimeType.VideoDividematroska => "video/matroska",
                AssetDtoVariant1MimeType.VideoDividemp4 => "video/mp4",
                AssetDtoVariant1MimeType.VideoDividequicktime => "video/quicktime",
                AssetDtoVariant1MimeType.VideoDividewebm => "video/webm",
                AssetDtoVariant1MimeType.VideoDividexMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetDtoVariant1MimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetDtoVariant1MimeType.ImageDividegif,
                "image/jpeg" => AssetDtoVariant1MimeType.ImageDividejpeg,
                "image/jpg" => AssetDtoVariant1MimeType.ImageDividejpg,
                "image/png" => AssetDtoVariant1MimeType.ImageDividepng,
                "image/webp" => AssetDtoVariant1MimeType.ImageDividewebp,
                "video/matroska" => AssetDtoVariant1MimeType.VideoDividematroska,
                "video/mp4" => AssetDtoVariant1MimeType.VideoDividemp4,
                "video/quicktime" => AssetDtoVariant1MimeType.VideoDividequicktime,
                "video/webm" => AssetDtoVariant1MimeType.VideoDividewebm,
                "video/x-matroska" => AssetDtoVariant1MimeType.VideoDividexMatroska,
                _ => null,
            };
        }
    }
}