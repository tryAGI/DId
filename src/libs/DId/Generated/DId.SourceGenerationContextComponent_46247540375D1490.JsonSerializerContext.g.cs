
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_46247540375D1490
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_54037D302DF7E3DD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EE7512FED91AEC2D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F1908BF15D5848DE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0270.Create_SourceGenerationContextMetadataType_46247540375D1490(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_4D8263CED2B0B762(options);
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