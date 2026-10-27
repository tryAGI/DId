
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class V4AvatarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_6023D43F4D176064.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5DE50698644CFB1D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1DCD0EE2DE97A4CA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_EA74D180EC8BBE69.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7C65D61771BC12D6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F4525B82C8AB8D04.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_13BE4D005F03E451.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B4699BBBC6FFB55D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_014131D050BE383D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_45A48DEC3BE40631.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2FBAA92D9A9622BF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E1267EBF1A418E8A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_27CC93CEEAECF4C2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8A4844568A107AE5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_295174DC6023E414.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0B1E920FE183100C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_99B1A3F1DBF5556B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0BF2687CF03249F8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly V4AvatarsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static V4AvatarsSourceGenerationContext Default => DefaultHolder.Instance;
        private V4AvatarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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