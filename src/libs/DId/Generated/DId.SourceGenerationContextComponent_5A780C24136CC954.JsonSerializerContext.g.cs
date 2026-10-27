
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5A780C24136CC954
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_436ACC1CCBCF9893.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8DCE89669E60A97C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CAF9A3C71823BFF9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0273.Create_SourceGenerationContextMetadataType_5A780C24136CC954(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0264.Create_SourceGenerationContextMetadataType_133FD32D7CC42CE4(options);
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