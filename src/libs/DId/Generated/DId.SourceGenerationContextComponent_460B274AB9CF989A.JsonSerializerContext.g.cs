
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_460B274AB9CF989A
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_60FB8F481A53CAB0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A23E4A4B5BF3D7EC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F1DB3700FAB1538E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0270.Create_SourceGenerationContextMetadataType_460B274AB9CF989A(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0272.Create_SourceGenerationContextMetadataType_52B61DF00FD81D18(options);
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