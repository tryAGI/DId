
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6C37085EBED91767
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_121C320DFFC6FCFA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5D0AE6E4A67F3973.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_890BF2CE639A6C0A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9A534F566E0D068A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E4D1304C49679492.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6C37085EBED91767(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0265.Create_SourceGenerationContextMetadataType_1F4062DDED56A95B(options);
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