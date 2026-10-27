
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8A8DCC571C0947B8
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_37FAE62B1CD63FE9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8604ED4C7170D187.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8725AA1B73E221E3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A51D6D7C7D09E99D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A798AC337A4C70AE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B5517BFDF590A794.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteAnimationResponseErrorVariant1, global::DId.DeleteAnimationResponseErrorVariant2, global::DId.DeleteAnimationResponseErrorVariant3, global::DId.DeleteAnimationResponseErrorVariant4, global::DId.DeleteAnimationResponseErrorVariant5, global::DId.DeleteAnimationResponseErrorVariant6>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteAnimationResponseErrorVariant1, global::DId.DeleteAnimationResponseErrorVariant2, global::DId.DeleteAnimationResponseErrorVariant3, global::DId.DeleteAnimationResponseErrorVariant4, global::DId.DeleteAnimationResponseErrorVariant5, global::DId.DeleteAnimationResponseErrorVariant6>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteAnimationResponseErrorVariant1, global::DId.DeleteAnimationResponseErrorVariant2, global::DId.DeleteAnimationResponseErrorVariant3, global::DId.DeleteAnimationResponseErrorVariant4, global::DId.DeleteAnimationResponseErrorVariant5, global::DId.DeleteAnimationResponseErrorVariant6>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0281.Create_SourceGenerationContextMetadataType_8A8DCC571C0947B8(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.DeleteAnimationResponseErrorVariant1, global::DId.DeleteAnimationResponseErrorVariant2, global::DId.DeleteAnimationResponseErrorVariant3, global::DId.DeleteAnimationResponseErrorVariant4, global::DId.DeleteAnimationResponseErrorVariant5, global::DId.DeleteAnimationResponseErrorVariant6>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0286.Create_SourceGenerationContextMetadataType_AC318DFD7DC5AAB0(options);
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