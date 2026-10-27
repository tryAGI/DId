
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F9BF629B6F050F09
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_787D5C4E33821955.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C142F170415147F9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_F9BF629B6F050F09(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0299.Create_SourceGenerationContextMetadataType_FF5F0DBFC50EEB40(options);
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