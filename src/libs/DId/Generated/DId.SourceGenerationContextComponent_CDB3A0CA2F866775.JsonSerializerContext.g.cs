
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_CDB3A0CA2F866775
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_7C6CC1AD826C46FA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8F9A28C5812DB0C2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B4AC3A699847CF11.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BD355F8E04FF4B99.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C8327805DCB7DF0F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_CDB3A0CA2F866775(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_DC94848DEBE963D0(options);
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