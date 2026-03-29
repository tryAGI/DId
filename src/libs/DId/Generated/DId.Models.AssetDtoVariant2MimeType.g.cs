
#nullable enable

namespace DId
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    public enum AssetDtoVariant2MimeType
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
    public static class AssetDtoVariant2MimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetDtoVariant2MimeType value)
        {
            return value switch
            {
                AssetDtoVariant2MimeType.ImageDividegif => "image/gif",
                AssetDtoVariant2MimeType.ImageDividejpeg => "image/jpeg",
                AssetDtoVariant2MimeType.ImageDividejpg => "image/jpg",
                AssetDtoVariant2MimeType.ImageDividepng => "image/png",
                AssetDtoVariant2MimeType.ImageDividewebp => "image/webp",
                AssetDtoVariant2MimeType.VideoDividematroska => "video/matroska",
                AssetDtoVariant2MimeType.VideoDividemp4 => "video/mp4",
                AssetDtoVariant2MimeType.VideoDividequicktime => "video/quicktime",
                AssetDtoVariant2MimeType.VideoDividewebm => "video/webm",
                AssetDtoVariant2MimeType.VideoDividexMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetDtoVariant2MimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetDtoVariant2MimeType.ImageDividegif,
                "image/jpeg" => AssetDtoVariant2MimeType.ImageDividejpeg,
                "image/jpg" => AssetDtoVariant2MimeType.ImageDividejpg,
                "image/png" => AssetDtoVariant2MimeType.ImageDividepng,
                "image/webp" => AssetDtoVariant2MimeType.ImageDividewebp,
                "video/matroska" => AssetDtoVariant2MimeType.VideoDividematroska,
                "video/mp4" => AssetDtoVariant2MimeType.VideoDividemp4,
                "video/quicktime" => AssetDtoVariant2MimeType.VideoDividequicktime,
                "video/webm" => AssetDtoVariant2MimeType.VideoDividewebm,
                "video/x-matroska" => AssetDtoVariant2MimeType.VideoDividexMatroska,
                _ => null,
            };
        }
    }
}