
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1CA27EDAE4105AEF
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1CA043E020BFB4E1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_34D049C2D9E48F12.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E47507166EC6A68B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0265.Create_SourceGenerationContextMetadataType_1CA27EDAE4105AEF(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0272.Create_SourceGenerationContextMetadataType_52B31299369CC5D9(options);
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