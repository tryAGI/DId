
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextProviderOpenAI2_11089aa6e237c3a7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>?), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextProviderOpenAI2_5891966cb53d7dbd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestCompatibilityMode), TypeInfoPropertyName = "CreateStreamRequestCompatibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswerType), TypeInfoPropertyName = "StartConnectionRequestAnswerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2>), TypeInfoPropertyName = "AllOfAnyOfAddIceCandidateRequestVariant12ObjectAddIceCandidateRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>), TypeInfoPropertyName = "AnyOfAddIceCandidateRequestVariant12Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateRequestVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptText2, global::DId.CreateVideoStreamRequestScriptAudio2>), TypeInfoPropertyName = "AnyOfCreateVideoStreamRequestScriptText2CreateVideoStreamRequestScriptAudio22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptText2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextType2), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextProviderMicrosoftType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextProviderElevenLabsType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextProviderElevenLabsAccess22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2), TypeInfoPropertyName = "CreateVideoStreamRequestScriptTextProviderOpenAIType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudioType2), TypeInfoPropertyName = "CreateVideoStreamRequestScriptAudioType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestMessageRole), TypeInfoPropertyName = "ChatRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestChatMode), TypeInfoPropertyName = "ChatRequestChatMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsepType), TypeInfoPropertyName = "CreateStreamResponseJsepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateStreamResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseIceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>), TypeInfoPropertyName = "AllOfCreateVideoStreamResponseVariant12CreateVideoStreamResponseVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponseVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponseVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ChatResponseMatche2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponseMatche2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponseChatMode2), TypeInfoPropertyName = "ChatResponseChatMode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestCompatibilityMode?), TypeInfoPropertyName = "NullableCreateStreamRequestCompatibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswerType?), TypeInfoPropertyName = "NullableStartConnectionRequestAnswerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2>?), TypeInfoPropertyName = "NullableAllOfAnyOfAddIceCandidateRequestVariant12ObjectAddIceCandidateRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?), TypeInfoPropertyName = "NullableAnyOfAddIceCandidateRequestVariant12Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptText2, global::DId.CreateVideoStreamRequestScriptAudio2>?), TypeInfoPropertyName = "NullableAnyOfCreateVideoStreamRequestScriptText2CreateVideoStreamRequestScriptAudio22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextType2?), TypeInfoPropertyName = "NullableCreateVideoStreamRequestScriptTextType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2?), TypeInfoPropertyName = "NullableCreateVideoStreamRequestScriptTextProviderMicrosoftType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2?), TypeInfoPropertyName = "NullableCreateVideoStreamRequestScriptTextProviderElevenLabsType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2?), TypeInfoPropertyName = "NullableCreateVideoStreamRequestScriptTextProviderElevenLabsAccess22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2?), TypeInfoPropertyName = "NullableCreateVideoStreamRequestScriptTextProviderOpenAIType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudioType2?), TypeInfoPropertyName = "NullableCreateVideoStreamRequestScriptAudioType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestMessageRole?), TypeInfoPropertyName = "NullableChatRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestChatMode?), TypeInfoPropertyName = "NullableChatRequestChatMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsepType?), TypeInfoPropertyName = "NullableCreateStreamResponseJsepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>?), TypeInfoPropertyName = "NullableAllOfCreateVideoStreamResponseVariant12CreateVideoStreamResponseVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponseChatMode2?), TypeInfoPropertyName = "NullableChatResponseChatMode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateStreamResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ChatResponseMatche2>))]
    internal sealed partial class AgentsStreamsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsStreamsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsStreamsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsStreamsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AddIceCandidateRequestVariant12, object>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptText2, global::DId.CreateVideoStreamRequestScriptAudio2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>());
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
                    typeToConvert == typeof(global::DId.CreateStreamRequestCompatibilityMode)

                    || typeToConvert == typeof(global::DId.CreateStreamRequestCompatibilityMode?)

                    || typeToConvert == typeof(global::DId.StartConnectionRequestAnswerType)

                    || typeToConvert == typeof(global::DId.StartConnectionRequestAnswerType?)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextType2)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextType2?)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2?)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2?)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2?)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2?)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptAudioType2)

                    || typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptAudioType2?)

                    || typeToConvert == typeof(global::DId.ChatRequestMessageRole)

                    || typeToConvert == typeof(global::DId.ChatRequestMessageRole?)

                    || typeToConvert == typeof(global::DId.ChatRequestChatMode)

                    || typeToConvert == typeof(global::DId.ChatRequestChatMode?)

                    || typeToConvert == typeof(global::DId.CreateStreamResponseJsepType)

                    || typeToConvert == typeof(global::DId.CreateStreamResponseJsepType?)

                    || typeToConvert == typeof(global::DId.ChatResponseChatMode2)

                    || typeToConvert == typeof(global::DId.ChatResponseChatMode2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.CreateStreamRequestCompatibilityMode))
                {
                    return new global::DId.JsonConverters.CreateStreamRequestCompatibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateStreamRequestCompatibilityMode?))
                {
                    return new global::DId.JsonConverters.CreateStreamRequestCompatibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.StartConnectionRequestAnswerType))
                {
                    return new global::DId.JsonConverters.StartConnectionRequestAnswerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.StartConnectionRequestAnswerType?))
                {
                    return new global::DId.JsonConverters.StartConnectionRequestAnswerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextType2))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextType2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextType2?))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderMicrosoftType2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2?))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderMicrosoftType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsType2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2?))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2?))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderOpenAIType2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2?))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderOpenAIType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptAudioType2))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptAudioType2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateVideoStreamRequestScriptAudioType2?))
                {
                    return new global::DId.JsonConverters.CreateVideoStreamRequestScriptAudioType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatRequestMessageRole))
                {
                    return new global::DId.JsonConverters.ChatRequestMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatRequestMessageRole?))
                {
                    return new global::DId.JsonConverters.ChatRequestMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatRequestChatMode))
                {
                    return new global::DId.JsonConverters.ChatRequestChatModeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatRequestChatMode?))
                {
                    return new global::DId.JsonConverters.ChatRequestChatModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateStreamResponseJsepType))
                {
                    return new global::DId.JsonConverters.CreateStreamResponseJsepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateStreamResponseJsepType?))
                {
                    return new global::DId.JsonConverters.CreateStreamResponseJsepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatResponseChatMode2))
                {
                    return new global::DId.JsonConverters.ChatResponseChatMode2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatResponseChatMode2?))
                {
                    return new global::DId.JsonConverters.ChatResponseChatMode2NullableJsonConverter();
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
                    0 => new AgentsStreamsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}