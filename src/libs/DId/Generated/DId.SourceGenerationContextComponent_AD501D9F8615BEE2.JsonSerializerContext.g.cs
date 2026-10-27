
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_AD501D9F8615BEE2
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1A1A9FC5EB6FCC09.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7CB558A2BA5A4713.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B2EBBBC9CE3A8F5E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0286.Create_SourceGenerationContextMetadataType_AD501D9F8615BEE2(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0265.Create_SourceGenerationContextMetadataType_1BA32A3212968FB7(options);
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