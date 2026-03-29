
#nullable enable

namespace DId
{
    /// <summary>
    /// Supported MIME types for agent assets
    /// </summary>
    public enum AssetMimeType
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
    public static class AssetMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetMimeType value)
        {
            return value switch
            {
                AssetMimeType.ImageDividegif => "image/gif",
                AssetMimeType.ImageDividejpeg => "image/jpeg",
                AssetMimeType.ImageDividejpg => "image/jpg",
                AssetMimeType.ImageDividepng => "image/png",
                AssetMimeType.ImageDividewebp => "image/webp",
                AssetMimeType.VideoDividematroska => "video/matroska",
                AssetMimeType.VideoDividemp4 => "video/mp4",
                AssetMimeType.VideoDividequicktime => "video/quicktime",
                AssetMimeType.VideoDividewebm => "video/webm",
                AssetMimeType.VideoDividexMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetMimeType.ImageDividegif,
                "image/jpeg" => AssetMimeType.ImageDividejpeg,
                "image/jpg" => AssetMimeType.ImageDividejpg,
                "image/png" => AssetMimeType.ImageDividepng,
                "image/webp" => AssetMimeType.ImageDividewebp,
                "video/matroska" => AssetMimeType.VideoDividematroska,
                "video/mp4" => AssetMimeType.VideoDividemp4,
                "video/quicktime" => AssetMimeType.VideoDividequicktime,
                "video/webm" => AssetMimeType.VideoDividewebm,
                "video/x-matroska" => AssetMimeType.VideoDividexMatroska,
                _ => null,
            };
        }
    }
}