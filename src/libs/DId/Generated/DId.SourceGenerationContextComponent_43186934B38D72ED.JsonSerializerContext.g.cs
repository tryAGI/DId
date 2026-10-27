
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_43186934B38D72ED
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_35F77A5F240C3AD5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_49B40403458F56EC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A652D50FD2231356.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AF7779091AE733D9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F67A7B9B9B676671.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0270.Create_SourceGenerationContextMetadataType_43186934B38D72ED(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0267.Create_SourceGenerationContextMetadataType_2E459C1B5EDF1A30(options);
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