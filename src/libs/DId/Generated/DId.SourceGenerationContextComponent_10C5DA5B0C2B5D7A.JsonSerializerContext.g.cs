
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_10C5DA5B0C2B5D7A
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_5D5AE8B7B4B7F94A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E7711B714D9C5E91.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F3542EB20AE3A542.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0263.Create_SourceGenerationContextMetadataType_10C5DA5B0C2B5D7A(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_F88E04E8B0B2F1F0(options);
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