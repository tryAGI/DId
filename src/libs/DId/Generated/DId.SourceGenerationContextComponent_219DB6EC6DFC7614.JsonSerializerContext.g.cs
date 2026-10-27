
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_219DB6EC6DFC7614
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_28709751D8E2CFA7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3772D1C11562CE8E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_503ED3EF3CCC3942.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C41F9E8EB8F54EE7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FCEC9587E7F29B62.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0266.Create_SourceGenerationContextMetadataType_219DB6EC6DFC7614(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_BE73027860798339(options);
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