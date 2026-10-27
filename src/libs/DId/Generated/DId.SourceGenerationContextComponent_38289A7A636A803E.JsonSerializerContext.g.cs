
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_38289A7A636A803E
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_20F60F85195334D6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CCDE4FAAC644C863.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D28D1646F24D5C62.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0268.Create_SourceGenerationContextMetadataType_38289A7A636A803E(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0272.Create_SourceGenerationContextMetadataType_5036A384DCE24CCE(options);
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