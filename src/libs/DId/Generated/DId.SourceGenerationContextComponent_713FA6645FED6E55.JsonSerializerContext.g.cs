
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_713FA6645FED6E55
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.JSONValueJsonConverter>(static () => new global::DId.JsonConverters.JSONValueJsonConverter());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.JSONValue))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0147.Create_JSONValue2(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::DId.JSONValue?>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0290.Create_SourceGenerationContextMetadataType_C80FC85D68AF51FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::DId.JSONValue?>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0296.Create_SourceGenerationContextMetadataType_EDDB0C135E906AD5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::DId.JSONValue?>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0282.Create_SourceGenerationContextMetadataType_91006A94AA507B96(options);
                }
                if (type == typeof(global::DId.JSONValue?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0208.Create_NullableJSONValue2(options);
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