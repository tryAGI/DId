
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1F0972D9F07F43CB
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_162A27C7AED27DE2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_38F072BEDFC73CB2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4F4C51405EA82F7B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5339717EE75ED074.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_54F8191F6B785757.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_69BCDBC0C64964BE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnimationErrorJsonConverter>(static () => new global::DId.JsonConverters.AnimationErrorJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnimationError))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0024.Create_AnimationError2(options);
                }
                if (type == typeof(global::DId.AnimationError?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0170.Create_NullableAnimationError2(options);
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