
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D933304781CF1562
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_05DBF597F74068DC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FC2538A151CCA302.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_D933304781CF1562(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0269.Create_SourceGenerationContextMetadataType_3D4ABB14009AD37A(options);
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