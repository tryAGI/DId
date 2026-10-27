
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_2BCD065D74530DD7
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_296FB2A94EB2EB27.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5BCE3BF83076FD89.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FFF13F4077610DB1.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0267.Create_SourceGenerationContextMetadataType_2BCD065D74530DD7(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0278.Create_SourceGenerationContextMetadataType_73CA5432B0330B7A(options);
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