
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A45B7A120FB41B4D
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
            collector.AddEnum(typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsAccess), static () => new global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceElevenLabsAccessJsonConverter());
            collector.AddEnum(typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsAccess?), static () => new global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceElevenLabsAccessNullableJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsAccess))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0246.Create_PartialExpressiveAgentPresenterVoiceElevenLabsAccess2(options);
                }
                if (type == typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsAccess?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0219.Create_NullablePartialExpressiveAgentPresenterVoiceElevenLabsAccess2(options);
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