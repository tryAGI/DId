
#nullable enable
namespace DId
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F114F9130CA859DC
    {

        internal static readonly global::DId.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::DId.SourceGenerationContextMetadataScope>[] {
                    static () => global::DId.SourceGenerationContextComponent_13A8D004E4F102FA.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_2D593F148D13BBB8.MetadataScope,                    static () => global::DId.SourceGenerationContextComponent_ABF305DABDBC77B6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::DId.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>>(static () => new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>());
            collector.AddEager<global::DId.JsonConverters.UnixTimestampJsonConverter>(static () => new global::DId.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0297.Create_SourceGenerationContextMetadataType_F114F9130CA859DC(options);
                }
                if (type == typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>?))
                {
                    return global::DId.SourceGenerationContextMetadata0FactoryBatch0285.Create_SourceGenerationContextMetadataType_AA550EECF680126D(options);
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