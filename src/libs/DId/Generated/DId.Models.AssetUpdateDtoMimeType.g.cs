
#nullable enable

namespace DId
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    public enum AssetUpdateDtoMimeType
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
    public static class AssetUpdateDtoMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetUpdateDtoMimeType value)
        {
            return value switch
            {
                AssetUpdateDtoMimeType.ImageDividegif => "image/gif",
                AssetUpdateDtoMimeType.ImageDividejpeg => "image/jpeg",
                AssetUpdateDtoMimeType.ImageDividejpg => "image/jpg",
                AssetUpdateDtoMimeType.ImageDividepng => "image/png",
                AssetUpdateDtoMimeType.ImageDividewebp => "image/webp",
                AssetUpdateDtoMimeType.VideoDividematroska => "video/matroska",
                AssetUpdateDtoMimeType.VideoDividemp4 => "video/mp4",
                AssetUpdateDtoMimeType.VideoDividequicktime => "video/quicktime",
                AssetUpdateDtoMimeType.VideoDividewebm => "video/webm",
                AssetUpdateDtoMimeType.VideoDividexMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetUpdateDtoMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetUpdateDtoMimeType.ImageDividegif,
                "image/jpeg" => AssetUpdateDtoMimeType.ImageDividejpeg,
                "image/jpg" => AssetUpdateDtoMimeType.ImageDividejpg,
                "image/png" => AssetUpdateDtoMimeType.ImageDividepng,
                "image/webp" => AssetUpdateDtoMimeType.ImageDividewebp,
                "video/matroska" => AssetUpdateDtoMimeType.VideoDividematroska,
                "video/mp4" => AssetUpdateDtoMimeType.VideoDividemp4,
                "video/quicktime" => AssetUpdateDtoMimeType.VideoDividequicktime,
                "video/webm" => AssetUpdateDtoMimeType.VideoDividewebm,
                "video/x-matroska" => AssetUpdateDtoMimeType.VideoDividexMatroska,
                _ => null,
            };
        }
    }
}