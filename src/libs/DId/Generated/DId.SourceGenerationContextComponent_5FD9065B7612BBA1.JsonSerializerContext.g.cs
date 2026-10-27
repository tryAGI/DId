
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5FD9065B7612BBA1
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_0244D8B93D1FB387.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_31FA283FAFDB3234.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CC82040DB57A8CDB.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0275.Create_SourceGenerationContextMetadataType_5FD9065B7612BBA1(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0290.Create_SourceGenerationContextMetadataType_C550B9C03DB3DEF9(options);
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