
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9EAA7AA468AFECCA
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_2995D35180612010.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4B61320BC8874761.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_59CEBC5DE2B387A0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_79FF49C7F933AF88.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A1DDAC307F298813.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FF3DD35170319A24.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseAnimationErrorVariant1, global::DId.GetAnimationsResponseAnimationErrorVariant2, global::DId.GetAnimationsResponseAnimationErrorVariant3, global::DId.GetAnimationsResponseAnimationErrorVariant4, global::DId.GetAnimationsResponseAnimationErrorVariant5, global::DId.GetAnimationsResponseAnimationErrorVariant6>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseAnimationErrorVariant1, global::DId.GetAnimationsResponseAnimationErrorVariant2, global::DId.GetAnimationsResponseAnimationErrorVariant3, global::DId.GetAnimationsResponseAnimationErrorVariant4, global::DId.GetAnimationsResponseAnimationErrorVariant5, global::DId.GetAnimationsResponseAnimationErrorVariant6>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseAnimationErrorVariant1, global::DId.GetAnimationsResponseAnimationErrorVariant2, global::DId.GetAnimationsResponseAnimationErrorVariant3, global::DId.GetAnimationsResponseAnimationErrorVariant4, global::DId.GetAnimationsResponseAnimationErrorVariant5, global::DId.GetAnimationsResponseAnimationErrorVariant6>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0284.Create_SourceGenerationContextMetadataType_9EAA7AA468AFECCA(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseAnimationErrorVariant1, global::DId.GetAnimationsResponseAnimationErrorVariant2, global::DId.GetAnimationsResponseAnimationErrorVariant3, global::DId.GetAnimationsResponseAnimationErrorVariant4, global::DId.GetAnimationsResponseAnimationErrorVariant5, global::DId.GetAnimationsResponseAnimationErrorVariant6>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0296.Create_SourceGenerationContextMetadataType_EF3100E5E6B38E57(options);
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