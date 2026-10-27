
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3F6EA31DC2FA689F
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_34CC6C396115904B.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_4528D9BF63A16A7C.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_E15F7B5A3A5A2B3D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>>(static () => new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0269.Create_SourceGenerationContextMetadataType_3F6EA31DC2FA689F(options);
                }
                if (type == typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0277.Create_SourceGenerationContextMetadataType_6A4BD363B618EB9F(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}