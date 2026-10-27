
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AudiosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_98B15C643001432C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D64036175481C7F0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F07FB00196300649.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CE1A14AC69D2F8E8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3EA72312CD26F6F1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4CF887F8C6B8BE69.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2AFCE33FCDEB4111.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C397A0AF22931A81.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_46FEBD0DC351490F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AudiosSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AudiosSourceGenerationContext Default => DefaultHolder.Instance;
        private AudiosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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