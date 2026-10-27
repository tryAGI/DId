
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_AEFF44D41C5D7389.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C00A942176F93990.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7C26E0A8A91CD395.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F2E1B4CC5204C9FE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_854BF01D26E20A83.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B17BED07C1CF4E43.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F0E896F175D6CE24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9C4491C31D6CF1F8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BACD3B38483E62E3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_44F48C4AA3A6FEE9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_08F6D671F9A2BBE4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A5A2E33B44C518A7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A3377EC0AB668086.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8BC03DD89368D6C8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CCC2080C5806F50F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ImagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ImagesSourceGenerationContext Default => DefaultHolder.Instance;
        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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