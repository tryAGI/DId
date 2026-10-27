
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F54270367A9302FD
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_163170B4C851B2DC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_54D673F53CA1787C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B7DF555593D77D05.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0297.Create_SourceGenerationContextMetadataType_F54270367A9302FD(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_CB769139213F34DF(options);
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