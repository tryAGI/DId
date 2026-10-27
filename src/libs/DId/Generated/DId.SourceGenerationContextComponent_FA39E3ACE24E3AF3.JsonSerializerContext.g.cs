
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FA39E3ACE24E3AF3
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_136B5775F23EBD7F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8491C7BD108C84B4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9E287D5804EA406D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_FA39E3ACE24E3AF3(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0286.Create_SourceGenerationContextMetadataType_AABF1FA00EE92E76(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}