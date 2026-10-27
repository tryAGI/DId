
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E8FBC43B34E6E5BF
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_2533687D1BD9688B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2EC88B519A025A5E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A1E03AD89F4850C7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B55B47478FC6DD46.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F9F09C5540A7B6D5.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_E8FBC43B34E6E5BF(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0279.Create_SourceGenerationContextMetadataType_79350C63E4432870(options);
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