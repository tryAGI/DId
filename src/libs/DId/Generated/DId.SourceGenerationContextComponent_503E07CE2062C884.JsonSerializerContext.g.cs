
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_503E07CE2062C884
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_12E6367F994F1192.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_78FAA2EFE8F61706.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_89B4A5D8ACCA28F2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DA044A59414F0336.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DC5A31AB0A80B4BA.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipRequestScriptVariant1ProviderAmazon2, global::DId.CreateClipRequestScriptVariant1ProviderGoogle2, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipRequestScriptVariant1ProviderAmazon2, global::DId.CreateClipRequestScriptVariant1ProviderGoogle2, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipRequestScriptVariant1ProviderAmazon2, global::DId.CreateClipRequestScriptVariant1ProviderGoogle2, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0272.Create_SourceGenerationContextMetadataType_503E07CE2062C884(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipRequestScriptVariant1ProviderAmazon2, global::DId.CreateClipRequestScriptVariant1ProviderGoogle2, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6E2BB8ABDB57921F(options);
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