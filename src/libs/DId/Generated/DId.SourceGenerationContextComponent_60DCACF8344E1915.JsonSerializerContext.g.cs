
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_60DCACF8344E1915
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_C060B255AD1B0CD3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D790DD23B5384B4F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E38416BC7DB61CF7.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar, global::DId.AgentResponseDtoVariant1PresenterVideoAvatar, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar, global::DId.AgentResponseDtoVariant1PresenterVideoAvatar, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar, global::DId.AgentResponseDtoVariant1PresenterVideoAvatar, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0275.Create_SourceGenerationContextMetadataType_60DCACF8344E1915(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar, global::DId.AgentResponseDtoVariant1PresenterVideoAvatar, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0264.Create_SourceGenerationContextMetadataType_144BC3745FCC8BB3(options);
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