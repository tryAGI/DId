
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7FC6FE205B2A09DA
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_07D5E8F9817014A6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_48F65BAE14039009.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9EBDBE26363D4AA4.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0280.Create_SourceGenerationContextMetadataType_7FC6FE205B2A09DA(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0287.Create_SourceGenerationContextMetadataType_B4344FA53C407EF2(options);
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