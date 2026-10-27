
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0F5D6139EE7F8F35
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_5B6D5D565DE8EA74.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_826AFF7D3EC3FA3C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FAE5154059FE1331.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0263.Create_SourceGenerationContextMetadataType_0F5D6139EE7F8F35(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0281.Create_SourceGenerationContextMetadataType_8A20C44E94B5B3BA(options);
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