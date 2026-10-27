
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_408F0514AF62792D
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_1264F4F84A6C00E1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5C44ED92B22780D5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_94E71EA6C87F94A7.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0269.Create_SourceGenerationContextMetadataType_408F0514AF62792D(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0276.Create_SourceGenerationContextMetadataType_672E32BD46333423(options);
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