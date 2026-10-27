
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1A956B8CA7543EC5
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_0DA71069D8FEC9B9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0FDAD73B3A5F63E2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1D69ADCCE867122B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_670525028E59DB4C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D01881811196833F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft, global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs, global::DId.GetPresenterByIdResponsePresenterVoiceAmazon, global::DId.GetPresenterByIdResponsePresenterVoiceGoogle, global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft, global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs, global::DId.GetPresenterByIdResponsePresenterVoiceAmazon, global::DId.GetPresenterByIdResponsePresenterVoiceGoogle, global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft, global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs, global::DId.GetPresenterByIdResponsePresenterVoiceAmazon, global::DId.GetPresenterByIdResponsePresenterVoiceGoogle, global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0265.Create_SourceGenerationContextMetadataType_1A956B8CA7543EC5(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft, global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs, global::DId.GetPresenterByIdResponsePresenterVoiceAmazon, global::DId.GetPresenterByIdResponsePresenterVoiceGoogle, global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0290.Create_SourceGenerationContextMetadataType_C5475395F2C807FB(options);
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