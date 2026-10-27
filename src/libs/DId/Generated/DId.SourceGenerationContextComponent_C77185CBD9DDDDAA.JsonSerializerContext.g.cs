
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C77185CBD9DDDDAA
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_9E2C35B7E9EA1D79.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BCB19D5CD4C2757B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E35E0C797F30CC12.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E439C0AD282BACDF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F119DD8A2AA67DB6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0290.Create_SourceGenerationContextMetadataType_C77185CBD9DDDDAA(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0294.Create_SourceGenerationContextMetadataType_E0EE1DBE33BC6993(options);
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