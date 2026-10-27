
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A4344BFED0EF0804
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_061155D7614DFBED.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A26B46AA3681AA3E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E52AABEED2C9D2DC.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0284.Create_SourceGenerationContextMetadataType_A4344BFED0EF0804(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0288.Create_SourceGenerationContextMetadataType_BB7C0AB2DD880C10(options);
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