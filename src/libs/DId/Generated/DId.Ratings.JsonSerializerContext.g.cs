
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class RatingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_5F691ECFB47A8770.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6FDD1BBF2E6D8BD1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_312506C4D77BE8E7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_18B8F4CCFB807FA7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FF6CEDA043DC4248.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_55BBD7DBAC2956DF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EF3E58C20AA381DA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_74751457FA09B3D4.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly RatingsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static RatingsSourceGenerationContext Default => DefaultHolder.Instance;
        private RatingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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