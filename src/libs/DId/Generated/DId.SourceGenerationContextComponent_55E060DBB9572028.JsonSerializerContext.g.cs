
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_55E060DBB9572028
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_35F9295038F4CA4C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_800204ADA3C7784A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_830021C7D24015A6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0273.Create_SourceGenerationContextMetadataType_55E060DBB9572028(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0285.Create_SourceGenerationContextMetadataType_A64C71B3D252632C(options);
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