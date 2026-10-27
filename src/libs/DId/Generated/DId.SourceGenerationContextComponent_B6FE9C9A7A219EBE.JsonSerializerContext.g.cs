
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B6FE9C9A7A219EBE
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_7B300407C739CD43.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7FDA2DB847C5EE40.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A1D5C6C323CB42FF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C515B6776B04E8CD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F39F3B44E333610C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0288.Create_SourceGenerationContextMetadataType_B6FE9C9A7A219EBE(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_E393E7F461D6A77B(options);
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