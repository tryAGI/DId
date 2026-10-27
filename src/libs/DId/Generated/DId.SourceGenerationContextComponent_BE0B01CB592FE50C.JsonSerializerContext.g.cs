
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BE0B01CB592FE50C
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_172BFF21E7E216E4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2B6F35AF22080578.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9AB251AF7902C35C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_BE0B01CB592FE50C(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_CE27012863CCF6FF(options);
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