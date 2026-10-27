
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_949A15AECA49786A
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_52C74DA7A88DBFE1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8DFC9485C4E0AEEE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E33B4976DD763BEC.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0283.Create_SourceGenerationContextMetadataType_949A15AECA49786A(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6DC8186978E0ACF5(options);
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