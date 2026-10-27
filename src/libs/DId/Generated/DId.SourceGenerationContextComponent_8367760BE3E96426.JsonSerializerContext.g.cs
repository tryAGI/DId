
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8367760BE3E96426
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_A12C962D1338C6DC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CB2F33CDD538800C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestScriptVariant12, global::DId.CreateClipStreamRequestScriptVariant22>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestScriptVariant12, global::DId.CreateClipStreamRequestScriptVariant22>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant12, global::DId.CreateClipStreamRequestScriptVariant22>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0280.Create_SourceGenerationContextMetadataType_8367760BE3E96426(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant12, global::DId.CreateClipStreamRequestScriptVariant22>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_E56160BAD016C716(options);
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