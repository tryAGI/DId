
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5B2266E0CEB2DCB2
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_3ED658A3A688C601.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3F854ACDE4363439.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_97E514348C027172.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0274.Create_SourceGenerationContextMetadataType_5B2266E0CEB2DCB2(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0282.Create_SourceGenerationContextMetadataType_9144516596BDD8CE(options);
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