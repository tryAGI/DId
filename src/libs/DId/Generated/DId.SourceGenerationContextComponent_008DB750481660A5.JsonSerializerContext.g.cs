
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_008DB750481660A5
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1400E5045B7E9F73.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2DA84B92E663B68D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_455AC0C0BFBF054B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_98A0D4A9CD8BCA2D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A34E40CD4DB6D275.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipPresenterDtoVoiceMicrosoft, global::DId.ClipPresenterDtoVoiceElevenLabs, global::DId.ClipPresenterDtoVoiceAmazon, global::DId.ClipPresenterDtoVoiceGoogle, global::DId.ClipPresenterDtoVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipPresenterDtoVoiceMicrosoft, global::DId.ClipPresenterDtoVoiceElevenLabs, global::DId.ClipPresenterDtoVoiceAmazon, global::DId.ClipPresenterDtoVoiceGoogle, global::DId.ClipPresenterDtoVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.ClipPresenterDtoVoiceMicrosoft, global::DId.ClipPresenterDtoVoiceElevenLabs, global::DId.ClipPresenterDtoVoiceAmazon, global::DId.ClipPresenterDtoVoiceGoogle, global::DId.ClipPresenterDtoVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0261.Create_SourceGenerationContextMetadataType_008DB750481660A5(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.ClipPresenterDtoVoiceMicrosoft, global::DId.ClipPresenterDtoVoiceElevenLabs, global::DId.ClipPresenterDtoVoiceAmazon, global::DId.ClipPresenterDtoVoiceGoogle, global::DId.ClipPresenterDtoVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0288.Create_SourceGenerationContextMetadataType_B5C83EF6FCBB43F2(options);
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