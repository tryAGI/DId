
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4CFB34391EF85C59
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1C462F6696363D8A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B0B57B8857FE02F9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_4CFB34391EF85C59(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0288.Create_SourceGenerationContextMetadataType_B8751B8C44424143(options);
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