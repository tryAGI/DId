
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AgentsStreamsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_84E387E25814ED28.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ACCFE7794F3F489B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CE4F0FE1E0A3BE75.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C0D18F6F068FF9CA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F4C1C5914F9DD529.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ED1973A029A978F5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A7364DEF6AC4C2EC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_241FEC1FF5B67C5C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2DD61B167E2A1C19.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_479A00F580F82FA8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E4142BCC11388215.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E836B07EF4A08020.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BAEEDE0D635B72F2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1662FCFE013048C7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_819163A966F211B4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_33B735FC17C904C5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5080228D8137B5C9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_329DEDE1306BC57A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9EB50DF6BB1FC93A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_905FC17A9F4CE3C1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_46C05E940F4921BF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D2F10DAD718BBD49.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_32A1F077D024DA9D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_107B4AC7889F8C6C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0A256571031135FB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_23DE3D64E94A431F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6683F19EA3E85ADA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B8D2A5402B3E660A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8663671385A6B9DA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FE52996806874339.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AgentsStreamsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AgentsStreamsSourceGenerationContext Default => DefaultHolder.Instance;
        private AgentsStreamsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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