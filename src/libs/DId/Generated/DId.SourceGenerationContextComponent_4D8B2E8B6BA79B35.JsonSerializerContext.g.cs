
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4D8B2E8B6BA79B35
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_4A4B6775110E47B2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_873369BC38A4F41E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_90B893C78455A494.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_4D8B2E8B6BA79B35(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0264.Create_SourceGenerationContextMetadataType_15A83FD3D98B7D0D(options);
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