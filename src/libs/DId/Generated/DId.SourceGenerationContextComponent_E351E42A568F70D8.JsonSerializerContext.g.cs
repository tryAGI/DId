
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E351E42A568F70D8
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel), static () => new global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelJsonConverter());
            collector.AddEnum(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel?), static () => new global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0236.Create_OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel2(options);
                }
                if (type == typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0214.Create_NullableOmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel2(options);
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