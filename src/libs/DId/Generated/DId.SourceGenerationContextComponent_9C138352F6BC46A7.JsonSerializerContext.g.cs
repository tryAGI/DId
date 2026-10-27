
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9C138352F6BC46A7
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_2119B12CDEA0331B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_400336416726583E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6A3A378EEF2C99A7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7319C0C624C16FE4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_884B2385D8823BFD.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ScriptVariant1ProviderMicrosoft, global::DId.ScriptVariant1ProviderElevenLabs, global::DId.ScriptVariant1ProviderAmazon, global::DId.ScriptVariant1ProviderGoogle, global::DId.ScriptVariant1ProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ScriptVariant1ProviderMicrosoft, global::DId.ScriptVariant1ProviderElevenLabs, global::DId.ScriptVariant1ProviderAmazon, global::DId.ScriptVariant1ProviderGoogle, global::DId.ScriptVariant1ProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.ScriptVariant1ProviderMicrosoft, global::DId.ScriptVariant1ProviderElevenLabs, global::DId.ScriptVariant1ProviderAmazon, global::DId.ScriptVariant1ProviderGoogle, global::DId.ScriptVariant1ProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0284.Create_SourceGenerationContextMetadataType_9C138352F6BC46A7(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.ScriptVariant1ProviderMicrosoft, global::DId.ScriptVariant1ProviderElevenLabs, global::DId.ScriptVariant1ProviderAmazon, global::DId.ScriptVariant1ProviderGoogle, global::DId.ScriptVariant1ProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0276.Create_SourceGenerationContextMetadataType_63253329371FF326(options);
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