
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_07380C3E0CD1A9C1
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_3D3F1493CADA5475.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7127FE2294585310.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0262.Create_SourceGenerationContextMetadataType_07380C3E0CD1A9C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_CA5E5D695FDF6676(options);
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