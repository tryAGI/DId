
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E37939C1E7D1D853
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_461C75F76009D83F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B491C6759718BCBE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C8D4D12A909436E9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_E37939C1E7D1D853(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0262.Create_SourceGenerationContextMetadataType_0955430760F79AD9(options);
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