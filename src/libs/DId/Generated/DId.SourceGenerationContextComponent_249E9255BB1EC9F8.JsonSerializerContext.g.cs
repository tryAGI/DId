
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_249E9255BB1EC9F8
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1183777E2F63291D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_58B90720FAB5B39C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_97A94652E2A32544.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BFE9B216D7491352.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C6909E1E4B52AE0C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0266.Create_SourceGenerationContextMetadataType_249E9255BB1EC9F8(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_48EF96F4D9AAA382(options);
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