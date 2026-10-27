
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5C790183B5171413
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_61D610269A486468.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6666426EE39B0A30.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6AD2494DF6226C5B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_822409B27B4C2C60.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B155F9B7B051E92A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DE32A21249519DAC.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseDtoAnimationErrorVariant1, global::DId.GetAnimationsResponseDtoAnimationErrorVariant2, global::DId.GetAnimationsResponseDtoAnimationErrorVariant3, global::DId.GetAnimationsResponseDtoAnimationErrorVariant4, global::DId.GetAnimationsResponseDtoAnimationErrorVariant5, global::DId.GetAnimationsResponseDtoAnimationErrorVariant6>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseDtoAnimationErrorVariant1, global::DId.GetAnimationsResponseDtoAnimationErrorVariant2, global::DId.GetAnimationsResponseDtoAnimationErrorVariant3, global::DId.GetAnimationsResponseDtoAnimationErrorVariant4, global::DId.GetAnimationsResponseDtoAnimationErrorVariant5, global::DId.GetAnimationsResponseDtoAnimationErrorVariant6>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseDtoAnimationErrorVariant1, global::DId.GetAnimationsResponseDtoAnimationErrorVariant2, global::DId.GetAnimationsResponseDtoAnimationErrorVariant3, global::DId.GetAnimationsResponseDtoAnimationErrorVariant4, global::DId.GetAnimationsResponseDtoAnimationErrorVariant5, global::DId.GetAnimationsResponseDtoAnimationErrorVariant6>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0274.Create_SourceGenerationContextMetadataType_5C790183B5171413(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseDtoAnimationErrorVariant1, global::DId.GetAnimationsResponseDtoAnimationErrorVariant2, global::DId.GetAnimationsResponseDtoAnimationErrorVariant3, global::DId.GetAnimationsResponseDtoAnimationErrorVariant4, global::DId.GetAnimationsResponseDtoAnimationErrorVariant5, global::DId.GetAnimationsResponseDtoAnimationErrorVariant6>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0269.Create_SourceGenerationContextMetadataType_3E8F01393B4FFA32(options);
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