
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6C0A7D132644EF60
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_412643E51472F68C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_597D39C8FBAB4CDE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5B6128FAA79BD3E1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A0BFB306902463FD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F801ABEA519DB45F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1LlmOpenAI, global::DId.AgentResponseDtoVariant1LlmVariant2, global::DId.AgentResponseDtoVariant1LlmVariant3, global::DId.AgentResponseDtoVariant1LlmDId, global::DId.AgentResponseDtoVariant1LlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1LlmOpenAI, global::DId.AgentResponseDtoVariant1LlmVariant2, global::DId.AgentResponseDtoVariant1LlmVariant3, global::DId.AgentResponseDtoVariant1LlmDId, global::DId.AgentResponseDtoVariant1LlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1LlmOpenAI, global::DId.AgentResponseDtoVariant1LlmVariant2, global::DId.AgentResponseDtoVariant1LlmVariant3, global::DId.AgentResponseDtoVariant1LlmDId, global::DId.AgentResponseDtoVariant1LlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6C0A7D132644EF60(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1LlmOpenAI, global::DId.AgentResponseDtoVariant1LlmVariant2, global::DId.AgentResponseDtoVariant1LlmVariant3, global::DId.AgentResponseDtoVariant1LlmDId, global::DId.AgentResponseDtoVariant1LlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0272.Create_SourceGenerationContextMetadataType_5359D4BE7759F647(options);
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