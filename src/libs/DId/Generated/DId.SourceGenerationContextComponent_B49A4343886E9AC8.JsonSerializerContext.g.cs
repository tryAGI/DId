
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B49A4343886E9AC8
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_13BA6658962AAE04.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B2715F30525532F4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E6E3FF262FB39AA4.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0287.Create_SourceGenerationContextMetadataType_B49A4343886E9AC8(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_4812C6C231A7F493(options);
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