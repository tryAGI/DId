
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C2B6833FD35EFEFF
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_243FE886B1EF5723.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_291408B91091E8DF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_733F9C8A75861BD0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_914DBF2C49BE7AE4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A5C83521B2B8EF06.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_C2B6833FD35EFEFF(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_DB6C6328125A6A14(options);
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