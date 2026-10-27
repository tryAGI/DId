
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F4E677E024C44BFC
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType2), static () => new global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsType2JsonConverter());
            collector.AddEnum(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType2?), static () => new global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsType2NullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType2))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0012.Create_AgentPresenterVideoAvatarVoiceElevenLabsType22(options);
                }
                if (type == typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType2?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0165.Create_NullableAgentPresenterVideoAvatarVoiceElevenLabsType22(options);
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