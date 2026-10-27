
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F95795FCE1D83E1C
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_2B29FFE5BEFC556D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4770FF0136C4F317.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8208F723E35EC688.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_F95795FCE1D83E1C(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6D2F0AE77C3780DE(options);
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