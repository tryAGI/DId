
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SettingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_3EFB2E72412344A1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ED4D89AE693CFFC1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F87FB72911C2D9E8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ED517A9F99456AAB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CD7F5F0BCA08C8C9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FC7C63322F6BD6A5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8726CF31652B9250.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EF1765803EE1D3E5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E248BB24F2058220.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3FEAAEE9F647AC97.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6BA0F2A57487C61F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C4EDB37B67A84C48.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0FBD7461ADDE2736.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SettingsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SettingsSourceGenerationContext Default => DefaultHolder.Instance;
        private SettingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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