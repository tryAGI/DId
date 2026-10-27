
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_AEC7E62C3E5206DB
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1A0618FEFE6499F4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_33B23AAB0386E522.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E180A7F7D91FC100.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0286.Create_SourceGenerationContextMetadataType_AEC7E62C3E5206DB(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_CCF0E07B8BDC35F9(options);
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