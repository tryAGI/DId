
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_118C8D12997C9051
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType), static () => new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeJsonConverter());
            collector.AddEnum(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType?), static () => new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0115.Create_GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType2(options);
                }
                if (type == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0198.Create_NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType2(options);
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