
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0A087251365B08F4
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_08794B391E6997D9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_39FA77C63C7A4BF5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7BD1C88E956FBD79.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_94B993E1780347CB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9B5F38E4E1AA262A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D39833EA12A3781B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseErrorVariant1, global::DId.GetAnimationResponseErrorVariant2, global::DId.GetAnimationResponseErrorVariant3, global::DId.GetAnimationResponseErrorVariant4, global::DId.GetAnimationResponseErrorVariant5, global::DId.GetAnimationResponseErrorVariant6>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseErrorVariant1, global::DId.GetAnimationResponseErrorVariant2, global::DId.GetAnimationResponseErrorVariant3, global::DId.GetAnimationResponseErrorVariant4, global::DId.GetAnimationResponseErrorVariant5, global::DId.GetAnimationResponseErrorVariant6>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationResponseErrorVariant1, global::DId.GetAnimationResponseErrorVariant2, global::DId.GetAnimationResponseErrorVariant3, global::DId.GetAnimationResponseErrorVariant4, global::DId.GetAnimationResponseErrorVariant5, global::DId.GetAnimationResponseErrorVariant6>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0262.Create_SourceGenerationContextMetadataType_0A087251365B08F4(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.GetAnimationResponseErrorVariant1, global::DId.GetAnimationResponseErrorVariant2, global::DId.GetAnimationResponseErrorVariant3, global::DId.GetAnimationResponseErrorVariant4, global::DId.GetAnimationResponseErrorVariant5, global::DId.GetAnimationResponseErrorVariant6>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0264.Create_SourceGenerationContextMetadataType_157F2E378C1C684D(options);
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