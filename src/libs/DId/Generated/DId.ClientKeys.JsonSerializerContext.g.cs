
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ClientKeysSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_3DBF2769E60B4D92.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4DD7B9E1A7366063.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_534703079C35B074.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F9BDC7DC50351902.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0A75E190E0580C11.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8121B8C2B5200950.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FD1722344D2E2300.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C78F518CA053738E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A0DC88A6745C698D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D92FAB7F5E239C2E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_039958721EDA643F.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ClientKeysSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ClientKeysSourceGenerationContext Default => DefaultHolder.Instance;
        private ClientKeysSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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