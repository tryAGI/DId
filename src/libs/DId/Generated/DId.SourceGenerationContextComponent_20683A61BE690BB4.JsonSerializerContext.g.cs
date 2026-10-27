
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_20683A61BE690BB4
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_5C08CA7F4C3545D0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8C75EDAFDA77A7AD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AD71A86B141E3524.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D7023985A708399E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FE3F501D73DC4333.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0265.Create_SourceGenerationContextMetadataType_20683A61BE690BB4(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0285.Create_SourceGenerationContextMetadataType_A85D367D812AADB1(options);
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