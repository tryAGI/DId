
#nullable enable

namespace DId
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    public enum AssetCreateDtoMimeType
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
    public static class AssetCreateDtoMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetCreateDtoMimeType value)
        {
            return value switch
            {
                AssetCreateDtoMimeType.ImageDividegif => "image/gif",
                AssetCreateDtoMimeType.ImageDividejpeg => "image/jpeg",
                AssetCreateDtoMimeType.ImageDividejpg => "image/jpg",
                AssetCreateDtoMimeType.ImageDividepng => "image/png",
                AssetCreateDtoMimeType.ImageDividewebp => "image/webp",
                AssetCreateDtoMimeType.VideoDividematroska => "video/matroska",
                AssetCreateDtoMimeType.VideoDividemp4 => "video/mp4",
                AssetCreateDtoMimeType.VideoDividequicktime => "video/quicktime",
                AssetCreateDtoMimeType.VideoDividewebm => "video/webm",
                AssetCreateDtoMimeType.VideoDividexMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetCreateDtoMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetCreateDtoMimeType.ImageDividegif,
                "image/jpeg" => AssetCreateDtoMimeType.ImageDividejpeg,
                "image/jpg" => AssetCreateDtoMimeType.ImageDividejpg,
                "image/png" => AssetCreateDtoMimeType.ImageDividepng,
                "image/webp" => AssetCreateDtoMimeType.ImageDividewebp,
                "video/matroska" => AssetCreateDtoMimeType.VideoDividematroska,
                "video/mp4" => AssetCreateDtoMimeType.VideoDividemp4,
                "video/quicktime" => AssetCreateDtoMimeType.VideoDividequicktime,
                "video/webm" => AssetCreateDtoMimeType.VideoDividewebm,
                "video/x-matroska" => AssetCreateDtoMimeType.VideoDividexMatroska,
                _ => null,
            };
        }
    }
}