
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?>), TypeInfoPropertyName = "CreateSecretRequestVariant2Variant2_996b5d5fd8c48a7f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>), TypeInfoPropertyName = "CreateSecretRequestCreateSecretRequest1ApiKey_cefdf8e29680a663")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?>), TypeInfoPropertyName = "UpdateSecretRequestVariant2Variant2_1028af05b486b8ef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>), TypeInfoPropertyName = "UpdateSecretRequestUpdateSecretRequest1ApiKey_a5a2c8e648f44688")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?>?), TypeInfoPropertyName = "CreateSecretRequestVariant2Variant2_e792afb4786d10fe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?), TypeInfoPropertyName = "CreateSecretRequestCreateSecretRequest1ApiKey_ebe4de682c2f813a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?>?), TypeInfoPropertyName = "UpdateSecretRequestVariant2Variant2_8aac1e685c1c03f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?), TypeInfoPropertyName = "UpdateSecretRequestUpdateSecretRequest1ApiKey_6b252aa488225f2e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType), TypeInfoPropertyName = "CreateSecretRequestCreateSecretRequest1BasicAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType), TypeInfoPropertyName = "CreateSecretRequestCreateSecretRequest1BearerTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType), TypeInfoPropertyName = "CreateSecretRequestCreateSecretRequest1ApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>), TypeInfoPropertyName = "AnyOfCreateSecretRequestVariant2OpenAIConfigurationCreateSecretRequestVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2OpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider), TypeInfoPropertyName = "CreateSecretRequestVariant2OpenAIConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2Variant2Provider), TypeInfoPropertyName = "CreateSecretRequestVariant2Variant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType), TypeInfoPropertyName = "UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType), TypeInfoPropertyName = "UpdateSecretRequestUpdateSecretRequest1BearerTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType), TypeInfoPropertyName = "UpdateSecretRequestUpdateSecretRequest1ApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>), TypeInfoPropertyName = "AnyOfUpdateSecretRequestVariant2OpenAIConfigurationUpdateSecretRequestVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider), TypeInfoPropertyName = "UpdateSecretRequestVariant2OpenAIConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider), TypeInfoPropertyName = "UpdateSecretRequestVariant2Variant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponseType), TypeInfoPropertyName = "CreateSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAllSecretsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAllSecretsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAllSecretsResponseItemType), TypeInfoPropertyName = "GetAllSecretsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponseType), TypeInfoPropertyName = "GetSecretByIdResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponseType), TypeInfoPropertyName = "UpdateSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponseType), TypeInfoPropertyName = "DeleteSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType?), TypeInfoPropertyName = "NullableCreateSecretRequestCreateSecretRequest1BasicAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType?), TypeInfoPropertyName = "NullableCreateSecretRequestCreateSecretRequest1BearerTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType?), TypeInfoPropertyName = "NullableCreateSecretRequestCreateSecretRequest1ApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?), TypeInfoPropertyName = "NullableAnyOfCreateSecretRequestVariant2OpenAIConfigurationCreateSecretRequestVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider?), TypeInfoPropertyName = "NullableCreateSecretRequestVariant2OpenAIConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2Variant2Provider?), TypeInfoPropertyName = "NullableCreateSecretRequestVariant2Variant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType?), TypeInfoPropertyName = "NullableUpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType?), TypeInfoPropertyName = "NullableUpdateSecretRequestUpdateSecretRequest1BearerTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType?), TypeInfoPropertyName = "NullableUpdateSecretRequestUpdateSecretRequest1ApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?), TypeInfoPropertyName = "NullableAnyOfUpdateSecretRequestVariant2OpenAIConfigurationUpdateSecretRequestVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider?), TypeInfoPropertyName = "NullableUpdateSecretRequestVariant2OpenAIConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider?), TypeInfoPropertyName = "NullableUpdateSecretRequestVariant2Variant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponseType?), TypeInfoPropertyName = "NullableCreateSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAllSecretsResponseItemType?), TypeInfoPropertyName = "NullableGetAllSecretsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponseType?), TypeInfoPropertyName = "NullableGetSecretByIdResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponseType?), TypeInfoPropertyName = "NullableUpdateSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponseType?), TypeInfoPropertyName = "NullableDeleteSecretResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAllSecretsResponseItem>))]
    internal sealed partial class SecretsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SecretsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SecretsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>());
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
                    typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType?)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType?)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType?)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider?)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestVariant2Variant2Provider)

                    || typeToConvert == typeof(global::DId.CreateSecretRequestVariant2Variant2Provider?)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType?)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType?)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType?)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider?)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider)

                    || typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider?)

                    || typeToConvert == typeof(global::DId.CreateSecretResponseType)

                    || typeToConvert == typeof(global::DId.CreateSecretResponseType?)

                    || typeToConvert == typeof(global::DId.GetAllSecretsResponseItemType)

                    || typeToConvert == typeof(global::DId.GetAllSecretsResponseItemType?)

                    || typeToConvert == typeof(global::DId.GetSecretByIdResponseType)

                    || typeToConvert == typeof(global::DId.GetSecretByIdResponseType?)

                    || typeToConvert == typeof(global::DId.UpdateSecretResponseType)

                    || typeToConvert == typeof(global::DId.UpdateSecretResponseType?)

                    || typeToConvert == typeof(global::DId.DeleteSecretResponseType)

                    || typeToConvert == typeof(global::DId.DeleteSecretResponseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType?))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BearerTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType?))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BearerTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1ApiKeyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType?))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1ApiKeyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestVariant2OpenAIConfigurationProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider?))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestVariant2OpenAIConfigurationProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestVariant2Variant2Provider))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestVariant2Variant2ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretRequestVariant2Variant2Provider?))
                {
                    return new global::DId.JsonConverters.CreateSecretRequestVariant2Variant2ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType?))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType?))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType?))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestVariant2OpenAIConfigurationProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider?))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestVariant2OpenAIConfigurationProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestVariant2Variant2ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider?))
                {
                    return new global::DId.JsonConverters.UpdateSecretRequestVariant2Variant2ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretResponseType))
                {
                    return new global::DId.JsonConverters.CreateSecretResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateSecretResponseType?))
                {
                    return new global::DId.JsonConverters.CreateSecretResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAllSecretsResponseItemType))
                {
                    return new global::DId.JsonConverters.GetAllSecretsResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAllSecretsResponseItemType?))
                {
                    return new global::DId.JsonConverters.GetAllSecretsResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetSecretByIdResponseType))
                {
                    return new global::DId.JsonConverters.GetSecretByIdResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetSecretByIdResponseType?))
                {
                    return new global::DId.JsonConverters.GetSecretByIdResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretResponseType))
                {
                    return new global::DId.JsonConverters.UpdateSecretResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateSecretResponseType?))
                {
                    return new global::DId.JsonConverters.UpdateSecretResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteSecretResponseType))
                {
                    return new global::DId.JsonConverters.DeleteSecretResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteSecretResponseType?))
                {
                    return new global::DId.JsonConverters.DeleteSecretResponseTypeNullableJsonConverter();
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
                    0 => new SecretsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}