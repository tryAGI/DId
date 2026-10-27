
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_CFCAAD4158D0E1EA
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
            collector.AddEnum(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType), static () => new global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderElevenLabsTypeJsonConverter());
            collector.AddEnum(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType?), static () => new global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0073.Create_CreateTalkRequestScriptVariant1ProviderElevenLabsType2_3(options);
                }
                if (type == typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0187.Create_NullableCreateTalkRequestScriptVariant1ProviderElevenLabsType2_3(options);
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