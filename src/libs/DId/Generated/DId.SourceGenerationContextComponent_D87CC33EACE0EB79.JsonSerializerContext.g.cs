
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D87CC33EACE0EB79
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_167B35E596033470.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9A1989B22F105C1D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_D87CC33EACE0EB79(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0267.Create_SourceGenerationContextMetadataType_295CF03E9D20DA4E(options);
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