
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9451062E53BE830B
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_01EA502C0458D1FF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_776EAE18CCBA3CBF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A272C8ED6AF012BF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B66421C41D5B3EFC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EA00FFD1B0760A9C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TextScriptProviderMicrosoft, global::DId.TextScriptProviderElevenLabs, global::DId.TextScriptProviderAmazon, global::DId.TextScriptProviderGoogle, global::DId.TextScriptProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TextScriptProviderMicrosoft, global::DId.TextScriptProviderElevenLabs, global::DId.TextScriptProviderAmazon, global::DId.TextScriptProviderGoogle, global::DId.TextScriptProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.TextScriptProviderMicrosoft, global::DId.TextScriptProviderElevenLabs, global::DId.TextScriptProviderAmazon, global::DId.TextScriptProviderGoogle, global::DId.TextScriptProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0283.Create_SourceGenerationContextMetadataType_9451062E53BE830B(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.TextScriptProviderMicrosoft, global::DId.TextScriptProviderElevenLabs, global::DId.TextScriptProviderAmazon, global::DId.TextScriptProviderGoogle, global::DId.TextScriptProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0283.Create_SourceGenerationContextMetadataType_934AAFE05EB048D4(options);
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