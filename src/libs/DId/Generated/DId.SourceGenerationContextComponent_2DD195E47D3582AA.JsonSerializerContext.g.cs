
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_2DD195E47D3582AA
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_59FB590ACC5FFF1E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5F32CDEEFA9EDF7B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B0FF78FEAA378A13.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0267.Create_SourceGenerationContextMetadataType_2DD195E47D3582AA(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0278.Create_SourceGenerationContextMetadataType_6F08FA20B4949487(options);
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