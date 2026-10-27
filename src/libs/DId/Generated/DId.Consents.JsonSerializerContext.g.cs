
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ConsentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::DId.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::DId.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_737DC1B2BB42DD28.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6B78D988A13CD7FC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C9225AE1A3622FC2.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AB1E46160553F8EC.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_01AB27ACF6E1F93C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3297377B15B390D9.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_69B688B7B954EDA3.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_888970B6FC4354C4.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D30359BCA906593F.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_46A79AB4FD451936.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_D4484FB633B7B113.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_B58A188208081E6D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A7EB17F8F270E57D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3E029F3119AA7B47.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C5E3BD596359373E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A2211BE5E06CB6F6.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_6F7C4A8742507194.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_135AC87045E9845A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_8D07D26023364322.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_AFD38EE20BEA55C0.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_22834794AB938C64.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_CED2A52BA4EC303B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_A0D903D8F93B152C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_F0D74CD780F50560.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_5CDFEF576F4D3E9D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_57E14E9CD242AB9E.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_C1606402CBC89499.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0AB7EEF78852C000.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_276486E0A74F388A.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_0DA36BA7B5D29EE8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7159CB7316B5A9F8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2F2EE88585F994D7.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_54DF57B9460C328C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_274DEDCC25B0C294.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_3289CDD1EC616697.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_7E6F63BE827F077D.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_69399D3000FFF7CE.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_DE159BC8A3F14B7C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_FA0D43D69903CD31.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ConsentsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ConsentsSourceGenerationContext Default => DefaultHolder.Instance;
        private ConsentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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