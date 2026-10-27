
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C13789FFE083A34C
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1F6E72B4D903DE38.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CFE64E8129753780.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant12, global::DId.CreateClipRequestScriptVariant22>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant12, global::DId.CreateClipRequestScriptVariant22>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant12, global::DId.CreateClipRequestScriptVariant22>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_C13789FFE083A34C(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant12, global::DId.CreateClipRequestScriptVariant22>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0266.Create_SourceGenerationContextMetadataType_2426FE7CA633B184(options);
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