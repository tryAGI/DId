
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D72A7E6BDD54CAA5
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_102C8D1E57804275.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_173B63A9F18F9345.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A8C477B46AA5DC88.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C14421B0A6202470.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F40C6B2F6BF50D71.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0292.Create_SourceGenerationContextMetadataType_D72A7E6BDD54CAA5(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0274.Create_SourceGenerationContextMetadataType_5D5F0810F9BF92FB(options);
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