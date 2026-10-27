
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8BFFFE91ED941296
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_8BDCDD313A2FDD39.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D8F46B04896AE6E6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DC6BD222E96DF19F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateStreamTextScriptProviderMicrosoft, global::DId.CreateStreamTextScriptProviderElevenLabs, global::DId.CreateStreamTextScriptProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateStreamTextScriptProviderMicrosoft, global::DId.CreateStreamTextScriptProviderElevenLabs, global::DId.CreateStreamTextScriptProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateStreamTextScriptProviderMicrosoft, global::DId.CreateStreamTextScriptProviderElevenLabs, global::DId.CreateStreamTextScriptProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0282.Create_SourceGenerationContextMetadataType_8BFFFE91ED941296(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateStreamTextScriptProviderMicrosoft, global::DId.CreateStreamTextScriptProviderElevenLabs, global::DId.CreateStreamTextScriptProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0278.Create_SourceGenerationContextMetadataType_7237671B65238917(options);
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