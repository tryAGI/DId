
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DId
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>), TypeInfoPropertyName = "Create2RequestScriptTextProviderOpenAI_88f01f7ea4812d4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>?), TypeInfoPropertyName = "Create2RequestScriptTextProviderOpenAI_1c92adaadd6dec63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<string, bool?>), TypeInfoPropertyName = "AnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio>), TypeInfoPropertyName = "AnyOfCreate2RequestScriptTextCreate2RequestScriptAudio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextType), TypeInfoPropertyName = "Create2RequestScriptTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType), TypeInfoPropertyName = "Create2RequestScriptTextProviderMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType), TypeInfoPropertyName = "Create2RequestScriptTextProviderElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazonType), TypeInfoPropertyName = "Create2RequestScriptTextProviderAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId), TypeInfoPropertyName = "Create2RequestScriptTextProviderAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderGoogleType), TypeInfoPropertyName = "Create2RequestScriptTextProviderGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAIType), TypeInfoPropertyName = "Create2RequestScriptTextProviderOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptAudioType), TypeInfoPropertyName = "Create2RequestScriptAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseStatus), TypeInfoPropertyName = "Create1ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseObject), TypeInfoPropertyName = "Create1ResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarStatus), TypeInfoPropertyName = "GetAvatarsResponseAvatarStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarObject), TypeInfoPropertyName = "GetAvatarsResponseAvatarObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarCreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseStatus), TypeInfoPropertyName = "GetResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseObject), TypeInfoPropertyName = "GetResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseCreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetResponseCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseCreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2ResponseObject), TypeInfoPropertyName = "Create2ResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2ResponseStatus), TypeInfoPropertyName = "Create2ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetScenesResponseScene>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseScene))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneStatus), TypeInfoPropertyName = "GetScenesResponseSceneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseStatus), TypeInfoPropertyName = "Get1ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<string, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio>?), TypeInfoPropertyName = "NullableAnyOfCreate2RequestScriptTextCreate2RequestScriptAudio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextType?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextProviderMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextProviderElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazonType?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextProviderAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextProviderAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderGoogleType?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextProviderGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAIType?), TypeInfoPropertyName = "NullableCreate2RequestScriptTextProviderOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptAudioType?), TypeInfoPropertyName = "NullableCreate2RequestScriptAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseStatus?), TypeInfoPropertyName = "NullableCreate1ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseObject?), TypeInfoPropertyName = "NullableCreate1ResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarStatus?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarObject?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseStatus?), TypeInfoPropertyName = "NullableGetResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseObject?), TypeInfoPropertyName = "NullableGetResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2ResponseObject?), TypeInfoPropertyName = "NullableCreate2ResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2ResponseStatus?), TypeInfoPropertyName = "NullableCreate2ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneStatus?), TypeInfoPropertyName = "NullableGetScenesResponseSceneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseStatus?), TypeInfoPropertyName = "NullableGet1ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarsResponseAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetResponseCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetScenesResponseScene>))]
    internal sealed partial class ScenesExpressAvatarsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScenesExpressAvatarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ScenesExpressAvatarsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ScenesExpressAvatarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::DId.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::DId.Create2RequestScriptTextType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextType?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonType?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderGoogleType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderGoogleType?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderOpenAIType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderOpenAIType?)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptAudioType)

                    || typeToConvert == typeof(global::DId.Create2RequestScriptAudioType?)

                    || typeToConvert == typeof(global::DId.Create1ResponseStatus)

                    || typeToConvert == typeof(global::DId.Create1ResponseStatus?)

                    || typeToConvert == typeof(global::DId.Create1ResponseObject)

                    || typeToConvert == typeof(global::DId.Create1ResponseObject?)

                    || typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarStatus)

                    || typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarStatus?)

                    || typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarObject)

                    || typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarObject?)

                    || typeToConvert == typeof(global::DId.GetResponseStatus)

                    || typeToConvert == typeof(global::DId.GetResponseStatus?)

                    || typeToConvert == typeof(global::DId.GetResponseObject)

                    || typeToConvert == typeof(global::DId.GetResponseObject?)

                    || typeToConvert == typeof(global::DId.Create2ResponseObject)

                    || typeToConvert == typeof(global::DId.Create2ResponseObject?)

                    || typeToConvert == typeof(global::DId.Create2ResponseStatus)

                    || typeToConvert == typeof(global::DId.Create2ResponseStatus?)

                    || typeToConvert == typeof(global::DId.GetScenesResponseSceneStatus)

                    || typeToConvert == typeof(global::DId.GetScenesResponseSceneStatus?)

                    || typeToConvert == typeof(global::DId.Get1ResponseStatus)

                    || typeToConvert == typeof(global::DId.Get1ResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderGoogleType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderGoogleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderGoogleType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderGoogleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderOpenAIType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptTextProviderOpenAIType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptTextProviderOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptAudioType))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2RequestScriptAudioType?))
                {
                    return new global::DId.JsonConverters.Create2RequestScriptAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create1ResponseStatus))
                {
                    return new global::DId.JsonConverters.Create1ResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create1ResponseStatus?))
                {
                    return new global::DId.JsonConverters.Create1ResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create1ResponseObject))
                {
                    return new global::DId.JsonConverters.Create1ResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create1ResponseObject?))
                {
                    return new global::DId.JsonConverters.Create1ResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarStatus))
                {
                    return new global::DId.JsonConverters.GetAvatarsResponseAvatarStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarStatus?))
                {
                    return new global::DId.JsonConverters.GetAvatarsResponseAvatarStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarObject))
                {
                    return new global::DId.JsonConverters.GetAvatarsResponseAvatarObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarsResponseAvatarObject?))
                {
                    return new global::DId.JsonConverters.GetAvatarsResponseAvatarObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseStatus))
                {
                    return new global::DId.JsonConverters.GetResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseStatus?))
                {
                    return new global::DId.JsonConverters.GetResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseObject))
                {
                    return new global::DId.JsonConverters.GetResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseObject?))
                {
                    return new global::DId.JsonConverters.GetResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2ResponseObject))
                {
                    return new global::DId.JsonConverters.Create2ResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2ResponseObject?))
                {
                    return new global::DId.JsonConverters.Create2ResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2ResponseStatus))
                {
                    return new global::DId.JsonConverters.Create2ResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create2ResponseStatus?))
                {
                    return new global::DId.JsonConverters.Create2ResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetScenesResponseSceneStatus))
                {
                    return new global::DId.JsonConverters.GetScenesResponseSceneStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetScenesResponseSceneStatus?))
                {
                    return new global::DId.JsonConverters.GetScenesResponseSceneStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Get1ResponseStatus))
                {
                    return new global::DId.JsonConverters.Get1ResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Get1ResponseStatus?))
                {
                    return new global::DId.JsonConverters.Get1ResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ScenesExpressAvatarsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}