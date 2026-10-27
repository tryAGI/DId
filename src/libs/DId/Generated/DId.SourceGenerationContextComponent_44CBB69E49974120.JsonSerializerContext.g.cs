
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_44CBB69E49974120
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_061E5B0250CE8DBC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0DE82B2A56216BA8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B6A24897A0717CB8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0270.Create_SourceGenerationContextMetadataType_44CBB69E49974120(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0276.Create_SourceGenerationContextMetadataType_624CC03B59CFCAC1(options);
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