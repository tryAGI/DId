
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7AE128D12FB787A2
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_37AA7AE854AB4C0D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_759E2B7619DD54B6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A2AD2C5B2ED64DBC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EE4C4C44BE4A2A1C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F2F1DE86E46C6B4E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0279.Create_SourceGenerationContextMetadataType_7AE128D12FB787A2(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0278.Create_SourceGenerationContextMetadataType_6F833662EEE852DF(options);
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