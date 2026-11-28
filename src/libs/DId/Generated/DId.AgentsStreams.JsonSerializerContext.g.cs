
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
                    static () => global::DId.SourceGenerationContextComponent_55E060DBB9572028.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_87724F523DA86186.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_358C8191F0ED2C9C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_39D89D64B2044C0C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F4C1C5914F9DD529.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E9D5E5E8A141C858.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ED1973A029A978F5.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_241FEC1FF5B67C5C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2DD61B167E2A1C19.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_09CDEECADF7AA3AD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E4142BCC11388215.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_90381A6FB0102A29.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BAEEDE0D635B72F2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_671EE2EA91A11BDE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_819163A966F211B4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2036ADEF86E926C7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_24ADC5B6866D76FF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6540D9F6BF9DB606.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_329DEDE1306BC57A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_31311B1EE390BBB9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F695B36F30F11E5B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8D539BD7DB7001DE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_021427127B219C99.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D8CC9FEB892BB053.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_39F07FFD377F1310.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_23DE3D64E94A431F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_00FF51CD4D4DD6E9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C118943447D88AC0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_36C925831E5DD6A7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FE52996806874339.MetadataScope,
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