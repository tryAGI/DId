
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ChatsExportSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_4CFB34391EF85C59.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0768C515207510A8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4DDB39F260A679C3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B56DDEF7D55D5CEE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EE82E3D99F676688.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_964B33DACF2BFD64.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_57D1E37F3CA1BBFC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6FCEF41CCD884298.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_782533794029201F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2BE0D98A4DDBA160.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CDB618BB41D6D95B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ChatsExportSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ChatsExportSourceGenerationContext Default => DefaultHolder.Instance;
        private ChatsExportSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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