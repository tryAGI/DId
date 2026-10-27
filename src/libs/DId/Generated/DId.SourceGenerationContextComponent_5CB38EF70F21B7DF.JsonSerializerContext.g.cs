
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5CB38EF70F21B7DF
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_297898A314C0BC55.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3F24DDD03E3A3B78.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9321807EFC7AF6FA.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0274.Create_SourceGenerationContextMetadataType_5CB38EF70F21B7DF(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0267.Create_SourceGenerationContextMetadataType_2E99E23EED2AFF74(options);
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