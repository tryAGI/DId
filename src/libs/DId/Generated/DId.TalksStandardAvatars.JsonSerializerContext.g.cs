
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class TalksStandardAvatarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_A682EFB831ABB4BA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4BC1DF0A073B1540.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_63FDDCC1B19224FB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7735C5559EECFF1B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_30585A5FEE5DD13E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2F0D1E2AC6A4E517.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CA8D8BFCE17B06A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DBF7487F202E2CE7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E6DEE039219A2BE1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4C55A876981E5235.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_725DD7CD90C7A385.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7753DEFBB0872F46.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9BEFD39BF715E92F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DC71AD0CC474B484.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4EAC11A0F4D83CB9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0FCEE014C61F31D3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_062CCAF656966D65.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6CE113D712796CFC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly TalksStandardAvatarsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static TalksStandardAvatarsSourceGenerationContext Default => DefaultHolder.Instance;
        private TalksStandardAvatarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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