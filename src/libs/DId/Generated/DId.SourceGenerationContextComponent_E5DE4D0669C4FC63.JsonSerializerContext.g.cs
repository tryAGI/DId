
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E5DE4D0669C4FC63
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1B91C0FACDBF2C6E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3F6D3424BD6BAF90.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5BE263FF0DAC7358.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5F5D3AEC5A508901.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_89EAC46622853B28.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_E5DE4D0669C4FC63(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6A5758ECFEA925D0(options);
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