
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A124DABAE9A691A3
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1B81C6935B2247FA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3E37A583B2F45DBA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_501A8177159E5E25.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8510D273109A223B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CAD3091122293119.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DF7F4310925DDC4C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.LLMConfigCreateDtoJsonConverter>(static () => new global::DId.JsonConverters.LLMConfigCreateDtoJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.LLMConfigCreateDto))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0149.Create_LLMConfigCreateDto2(options);
                }
                if (type == typeof(global::DId.LLMConfigCreateDto?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0209.Create_NullableLLMConfigCreateDto2(options);
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