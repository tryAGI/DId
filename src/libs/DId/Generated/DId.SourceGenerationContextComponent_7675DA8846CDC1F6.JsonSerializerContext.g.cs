
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7675DA8846CDC1F6
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_4CD22979F487A003.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B57BBCEED277D189.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FC2D8B007903DD13.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialTalkAgentPresenterVoiceMicrosoft, global::DId.PartialTalkAgentPresenterVoiceElevenLabs, global::DId.PartialTalkAgentPresenterVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialTalkAgentPresenterVoiceMicrosoft, global::DId.PartialTalkAgentPresenterVoiceElevenLabs, global::DId.PartialTalkAgentPresenterVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.PartialTalkAgentPresenterVoiceMicrosoft, global::DId.PartialTalkAgentPresenterVoiceElevenLabs, global::DId.PartialTalkAgentPresenterVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0279.Create_SourceGenerationContextMetadataType_7675DA8846CDC1F6(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.PartialTalkAgentPresenterVoiceMicrosoft, global::DId.PartialTalkAgentPresenterVoiceElevenLabs, global::DId.PartialTalkAgentPresenterVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0263.Create_SourceGenerationContextMetadataType_0F5FBEA06FEA2C98(options);
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