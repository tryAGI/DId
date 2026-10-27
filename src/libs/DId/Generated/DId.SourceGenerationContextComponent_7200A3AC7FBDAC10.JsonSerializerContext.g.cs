
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7200A3AC7FBDAC10
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
            collector.AddEnum(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template), static () => new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2TemplateJsonConverter());
            collector.AddEnum(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template?), static () => new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2TemplateNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0155.Create_ListMyAgentsResponseAgentVariant1LlmVariant2Template2(options);
                }
                if (type == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0212.Create_NullableListMyAgentsResponseAgentVariant1LlmVariant2Template2(options);
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