
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A7418E6160BB9CB9
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
            collector.AddEnum(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment), static () => new global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1SentimentJsonConverter());
            collector.AddEnum(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment?), static () => new global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1SentimentNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0122.Create_GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment2(options);
                }
                if (type == typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0200.Create_NullableGetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment2(options);
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