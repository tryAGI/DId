
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ClipsPremiumAvatarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_E2F3FABAF68BAFA6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6537EF3F5C07F263.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1E48D535B9B36E33.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8E0F22300837200F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_970D3FE603411CB4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_348CE90722381670.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3C287024FA861163.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_02BFE21E745996D9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AE90276AFA299A16.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_42B57B727D0D5F27.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9226357311208742.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_613DFF2D60DD0978.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_714843CC2492602B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E1F8316FAFB19D2C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F08C692FEAECC309.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0BECE877218122C5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C00884C4876DDC69.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A1C817E5FF5B938C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E0F994452173C8B5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_75EFAA64BF855BD1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_320F08E5E8DEE915.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9AFFEF9EF8A52906.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7E3FEA1C318FD461.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_003DDDE4195935AB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AF813DBB39D45EB0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CFF14476111F5E2C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9B04B5EDA036CBBD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DE29B5EA86B02D07.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A97F7A1695E87303.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_16D694C91697F45B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AF03B519D2CFC3DE.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ClipsPremiumAvatarsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ClipsPremiumAvatarsSourceGenerationContext Default => DefaultHolder.Instance;
        private ClipsPremiumAvatarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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