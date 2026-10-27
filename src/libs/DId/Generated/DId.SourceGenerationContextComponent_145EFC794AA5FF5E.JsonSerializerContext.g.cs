
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_145EFC794AA5FF5E
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_30BDE0875C722654.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3940BA81DF32B3BE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6350B5CF8BD82C5B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B2EAEC49B7327E9E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FAE86B4C447C8F93.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0264.Create_SourceGenerationContextMetadataType_145EFC794AA5FF5E(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6D5E41832D2CFED2(options);
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