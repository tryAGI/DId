
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_247D14CE06C4E446
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
            collector.AddEnum(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazonType), static () => new global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceAmazonTypeJsonConverter());
            collector.AddEnum(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazonType?), static () => new global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceAmazonTypeNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazonType))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0314.Create_UpdatePresenterAttributesVariant1VoiceAmazonType2(options);
                }
                if (type == typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazonType?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0229.Create_NullableUpdatePresenterAttributesVariant1VoiceAmazonType2(options);
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