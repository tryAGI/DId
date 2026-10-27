
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9848EC3CA2C4A9D2
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_019AF6F06B963900.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_08374D7356BF8534.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_51A06B48A0CCFC4A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A632FB8E50091A1D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DA93D8F8292A059F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipRequestScriptVariant1ProviderAmazon, global::DId.CreateClipRequestScriptVariant1ProviderGoogle, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipRequestScriptVariant1ProviderAmazon, global::DId.CreateClipRequestScriptVariant1ProviderGoogle, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipRequestScriptVariant1ProviderAmazon, global::DId.CreateClipRequestScriptVariant1ProviderGoogle, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0283.Create_SourceGenerationContextMetadataType_9848EC3CA2C4A9D2(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipRequestScriptVariant1ProviderAmazon, global::DId.CreateClipRequestScriptVariant1ProviderGoogle, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0267.Create_SourceGenerationContextMetadataType_2B2F24EE51AA0B24(options);
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