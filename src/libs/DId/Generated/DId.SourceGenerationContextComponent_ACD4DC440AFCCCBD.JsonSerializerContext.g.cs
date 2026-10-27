
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_ACD4DC440AFCCCBD
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_001C2F8C6223D091.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_28CB79222351383B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BB261A9DAFAD5FE4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C45AE760B7F78449.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E3DE1BE5E795465B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FC5DB7735EA61292.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseDtoErrorVariant1, global::DId.GetAnimationResponseDtoErrorVariant2, global::DId.GetAnimationResponseDtoErrorVariant3, global::DId.GetAnimationResponseDtoErrorVariant4, global::DId.GetAnimationResponseDtoErrorVariant5, global::DId.GetAnimationResponseDtoErrorVariant6>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseDtoErrorVariant1, global::DId.GetAnimationResponseDtoErrorVariant2, global::DId.GetAnimationResponseDtoErrorVariant3, global::DId.GetAnimationResponseDtoErrorVariant4, global::DId.GetAnimationResponseDtoErrorVariant5, global::DId.GetAnimationResponseDtoErrorVariant6>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationResponseDtoErrorVariant1, global::DId.GetAnimationResponseDtoErrorVariant2, global::DId.GetAnimationResponseDtoErrorVariant3, global::DId.GetAnimationResponseDtoErrorVariant4, global::DId.GetAnimationResponseDtoErrorVariant5, global::DId.GetAnimationResponseDtoErrorVariant6>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0286.Create_SourceGenerationContextMetadataType_ACD4DC440AFCCCBD(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationResponseDtoErrorVariant1, global::DId.GetAnimationResponseDtoErrorVariant2, global::DId.GetAnimationResponseDtoErrorVariant3, global::DId.GetAnimationResponseDtoErrorVariant4, global::DId.GetAnimationResponseDtoErrorVariant5, global::DId.GetAnimationResponseDtoErrorVariant6>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0262.Create_SourceGenerationContextMetadataType_03E263DEA590E4FC(options);
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