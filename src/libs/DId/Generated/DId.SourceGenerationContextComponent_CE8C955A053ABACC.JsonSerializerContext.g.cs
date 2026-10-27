
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_CE8C955A053ABACC
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_11B1CE83ECD9ADFB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1AC20C237059BBE3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3F648A1463DABF41.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_911FF0CE0CBB8152.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FA2D80AE435078BE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TextScript3ProviderMicrosoft, global::DId.TextScript3ProviderElevenLabs, global::DId.TextScript3ProviderAmazon, global::DId.TextScript3ProviderGoogle, global::DId.TextScript3ProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TextScript3ProviderMicrosoft, global::DId.TextScript3ProviderElevenLabs, global::DId.TextScript3ProviderAmazon, global::DId.TextScript3ProviderGoogle, global::DId.TextScript3ProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.TextScript3ProviderMicrosoft, global::DId.TextScript3ProviderElevenLabs, global::DId.TextScript3ProviderAmazon, global::DId.TextScript3ProviderGoogle, global::DId.TextScript3ProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_CE8C955A053ABACC(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.TextScript3ProviderMicrosoft, global::DId.TextScript3ProviderElevenLabs, global::DId.TextScript3ProviderAmazon, global::DId.TextScript3ProviderGoogle, global::DId.TextScript3ProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0275.Create_SourceGenerationContextMetadataType_612FC31C61E117E3(options);
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