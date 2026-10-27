
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class VideoTranslateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_737DC1B2BB42DD28.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6B78D988A13CD7FC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C9225AE1A3622FC2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AB1E46160553F8EC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_01AB27ACF6E1F93C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3297377B15B390D9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_69B688B7B954EDA3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_888970B6FC4354C4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D30359BCA906593F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_46A79AB4FD451936.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D4484FB633B7B113.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B58A188208081E6D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A7EB17F8F270E57D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3E029F3119AA7B47.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5E3BD596359373E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A2211BE5E06CB6F6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BD7B9E59CE9A30D1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_579F5B887E850947.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D10EC2B735AC6213.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6AA5CAA430FAB95A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0DCD4FC9A07B29A3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_89BCD3C7FAF0222D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_618C9F3A4CBF8A5B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8C9BFB375CE25449.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_66132DE105378FD6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9251B6B2E52807E2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_28C3A64847B1BD18.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_28C860E6936FA394.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_74753CEB9DFF8585.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_71372A9EF2D39B91.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly VideoTranslateSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static VideoTranslateSourceGenerationContext Default => DefaultHolder.Instance;
        private VideoTranslateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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