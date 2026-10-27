
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_AE91A419726E46A4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2FCEEEA289CA198B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_27CDCF40751D8981.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BD7B9E59CE9A30D1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_579F5B887E850947.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D10EC2B735AC6213.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6AA5CAA430FAB95A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0DCD4FC9A07B29A3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_89BCD3C7FAF0222D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DD1AE1F5085B8504.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1D3A95697196FE13.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1009FDE6F5704FB4.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly VoicesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static VoicesSourceGenerationContext Default => DefaultHolder.Instance;
        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}