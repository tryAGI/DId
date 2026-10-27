
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F731335EBBC5A989
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_28BFBBD3F4E36D6E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_37C164D8C9261D99.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5F11C1C6FAE4EC8A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8A96368F2BEEA10C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FE6A58C814D28079.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0297.Create_SourceGenerationContextMetadataType_F731335EBBC5A989(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0280.Create_SourceGenerationContextMetadataType_7D97B0A6D8E512FB(options);
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