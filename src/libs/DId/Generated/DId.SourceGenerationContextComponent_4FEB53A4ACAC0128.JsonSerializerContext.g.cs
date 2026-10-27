
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4FEB53A4ACAC0128
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_88078AB1D27CE685.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A04666A7ACDF05C8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A9ED8E0B34B795E2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DC8253059D345A80.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DF185CB74CFDBB7B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0272.Create_SourceGenerationContextMetadataType_4FEB53A4ACAC0128(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0283.Create_SourceGenerationContextMetadataType_97C6E7BE89E0B5B6(options);
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