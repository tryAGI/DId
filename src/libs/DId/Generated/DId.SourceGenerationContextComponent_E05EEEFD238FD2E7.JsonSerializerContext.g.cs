
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E05EEEFD238FD2E7
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1746BCA125307412.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_530A898908A64374.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FB8947DB9D14E75F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0294.Create_SourceGenerationContextMetadataType_E05EEEFD238FD2E7(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0279.Create_SourceGenerationContextMetadataType_7C4C72FD2B4698B6(options);
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