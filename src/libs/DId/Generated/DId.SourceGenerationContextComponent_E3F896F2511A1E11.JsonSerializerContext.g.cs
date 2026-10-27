
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E3F896F2511A1E11
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_6061E52CE85C4D8D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8BDD0F5100742701.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CB4E8E2A3BB826EB.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_E3F896F2511A1E11(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_4960C80A0C6FDB67(options);
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