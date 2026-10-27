
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0B1E920FE183100C
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_58DA94A8E6604D9A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AED86E7982157529.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D3AF54B9C9990DDC.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0263.Create_SourceGenerationContextMetadataType_0B1E920FE183100C(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0275.Create_SourceGenerationContextMetadataType_5EF02E627E75D323(options);
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