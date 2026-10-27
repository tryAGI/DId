
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FBE493CC883C0A5D
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_250F1B6AEFE66E59.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_77BF12C4CEB8088E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_912DBDD5B1A10D97.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9170F5A59E72F60F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B28ABB401085450E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_FBE493CC883C0A5D(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0273.Create_SourceGenerationContextMetadataType_568FF1268ECD0031(options);
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