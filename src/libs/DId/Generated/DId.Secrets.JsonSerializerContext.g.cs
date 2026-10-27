
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SecretsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_C02DB6946A2E9597.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_161A0C39BCDDBDAE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C96D9809742A2DB6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5126B92377EF6B2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C83927A17FD3B74F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B579E50655735C34.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7B07B8E57A72BC85.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F5C4C7B56E3A7997.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DF989D1106715E45.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_943BE1448B2F3204.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4A8DF27837B8EDEC.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SecretsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SecretsSourceGenerationContext Default => DefaultHolder.Instance;
        private SecretsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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