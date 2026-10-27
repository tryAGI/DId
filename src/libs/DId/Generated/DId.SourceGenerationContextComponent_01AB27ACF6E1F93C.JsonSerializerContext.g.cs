
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_01AB27ACF6E1F93C
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_735B78ECA6DC9B7D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_93D1354FEB7E4410.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B04029E3A5A26385.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C3333B2A31AB1B0A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D174A796A09070A0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F73001B0A0886714.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0261.Create_SourceGenerationContextMetadataType_01AB27ACF6E1F93C(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0297.Create_SourceGenerationContextMetadataType_F1FA1C8BE9F3D278(options);
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