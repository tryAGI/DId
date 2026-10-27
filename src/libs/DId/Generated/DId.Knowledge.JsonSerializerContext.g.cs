
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class KnowledgeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_3648E61F7178A768.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_361CCAA7C9713A79.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7042ECD70A3CF2DF.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2F588BBFDF5BD02A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_BB89B6168B3C90FA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4E5A7A37E094275B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_741F14D73947BAB4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8937BBD3D8E12039.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_1ADB844A626F30A1.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6C71B8BDD76BFFAD.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6FBB5A5D3A816934.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6F7C4A8742507194.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_135AC87045E9845A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8D07D26023364322.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AFD38EE20BEA55C0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_22834794AB938C64.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CED2A52BA4EC303B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A0D903D8F93B152C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F46B4A0A02205E17.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6DBB94554A4A40A6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0F8D8CD0F4CA3FDE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_51C570FF1975855E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D867B1759BE9E52D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F4FC4C618DA25246.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FE884D03987F55D8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A6141542063487F2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_32EC051A88EBD1AB.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D109CFEEEDD5EAA9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A886F36D9BE0F680.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ACC0BDE4BEAB26B2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_620854ECEA5018AC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_278C329A39CE6EC6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_9669D9A8EF9D4F51.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3A7F5BF431B4B886.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_782F2875FE7D0F1C.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly KnowledgeSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static KnowledgeSourceGenerationContext Default => DefaultHolder.Instance;
        private KnowledgeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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