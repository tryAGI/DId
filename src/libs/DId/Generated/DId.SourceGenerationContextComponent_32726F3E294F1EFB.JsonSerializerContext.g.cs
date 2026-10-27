
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_32726F3E294F1EFB
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_62E132C114C7586F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_78D77979BCC81E75.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_947004F0882DED09.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AFA6BF06816913A7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D35C6A81522A7698.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0268.Create_SourceGenerationContextMetadataType_32726F3E294F1EFB(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0262.Create_SourceGenerationContextMetadataType_075D78DF2DFB42A4(options);
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