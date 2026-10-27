
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_95F77DB93CD91A7D
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_014C02D6E688908D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2298B360268E4DC1.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0283.Create_SourceGenerationContextMetadataType_95F77DB93CD91A7D(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0263.Create_SourceGenerationContextMetadataType_0D047273D37D9BE4(options);
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