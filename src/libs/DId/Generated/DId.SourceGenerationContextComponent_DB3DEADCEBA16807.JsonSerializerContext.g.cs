
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_DB3DEADCEBA16807
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_0B97A576ABA113AC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_67C0AAA3124856A7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AF82ECF6A9E358C5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B98327FCB9D41F03.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D23C2771C3E2DBEB.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_DB3DEADCEBA16807(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0280.Create_SourceGenerationContextMetadataType_8167E5C414FF70CF(options);
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