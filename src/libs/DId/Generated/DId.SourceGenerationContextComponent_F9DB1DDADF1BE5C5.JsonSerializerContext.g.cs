
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F9DB1DDADF1BE5C5
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_837D6C9CBCC610BB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F7585E9A203FFB55.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_F9DB1DDADF1BE5C5(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0281.Create_SourceGenerationContextMetadataType_87A9D24E4725F8ED(options);
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