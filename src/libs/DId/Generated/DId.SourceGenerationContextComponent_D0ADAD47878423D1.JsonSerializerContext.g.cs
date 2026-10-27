
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D0ADAD47878423D1
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_2E5941B0319A8FA1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5295CEC626FFEEB3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_66146A080F8B1E28.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A806185B1F590090.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FE110D6045652AE1.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft, global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs, global::DId.CreateSceneRequestDtoScriptTextProviderAmazon, global::DId.CreateSceneRequestDtoScriptTextProviderGoogle, global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft, global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs, global::DId.CreateSceneRequestDtoScriptTextProviderAmazon, global::DId.CreateSceneRequestDtoScriptTextProviderGoogle, global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft, global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs, global::DId.CreateSceneRequestDtoScriptTextProviderAmazon, global::DId.CreateSceneRequestDtoScriptTextProviderGoogle, global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0292.Create_SourceGenerationContextMetadataType_D0ADAD47878423D1(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft, global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs, global::DId.CreateSceneRequestDtoScriptTextProviderAmazon, global::DId.CreateSceneRequestDtoScriptTextProviderGoogle, global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0294.Create_SourceGenerationContextMetadataType_DFA54A5DC1D806A1(options);
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