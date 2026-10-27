
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_19B86D80F59528D4
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_261D1BFBEE71BFF4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_35F1BC0615C19A6D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4162AACF351646EF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_42E2C4CCF555EBE0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_56C581885E60CABA.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.TextToSpeechProvidersJsonConverter>(static () => new global::DId.JsonConverters.TextToSpeechProvidersJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.TextToSpeechProviders))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0307.Create_TextToSpeechProviders2(options);
                }
                if (type == typeof(global::DId.TextToSpeechProviders?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0226.Create_NullableTextToSpeechProviders2(options);
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