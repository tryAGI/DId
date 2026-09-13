
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesProvider), TypeInfoPropertyName = "VoicesProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.VoicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemAccess), TypeInfoPropertyName = "VoicesResponseItemAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemProvider), TypeInfoPropertyName = "VoicesResponseItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.VoicesResponseItemLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemVoiceType), TypeInfoPropertyName = "VoicesResponseItemVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloneVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesProvider?), TypeInfoPropertyName = "NullableVoicesProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemAccess?), TypeInfoPropertyName = "NullableVoicesResponseItemAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemProvider?), TypeInfoPropertyName = "NullableVoicesResponseItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemVoiceType?), TypeInfoPropertyName = "NullableVoicesResponseItemVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.VoicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.VoicesResponseItemLanguage>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::DId.VoicesProvider)

                    || typeToConvert == typeof(global::DId.VoicesProvider?)

                    || typeToConvert == typeof(global::DId.VoicesResponseItemAccess)

                    || typeToConvert == typeof(global::DId.VoicesResponseItemAccess?)

                    || typeToConvert == typeof(global::DId.VoicesResponseItemProvider)

                    || typeToConvert == typeof(global::DId.VoicesResponseItemProvider?)

                    || typeToConvert == typeof(global::DId.VoicesResponseItemVoiceType)

                    || typeToConvert == typeof(global::DId.VoicesResponseItemVoiceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.VoicesProvider))
                {
                    return new global::DId.JsonConverters.VoicesProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesProvider?))
                {
                    return new global::DId.JsonConverters.VoicesProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesResponseItemAccess))
                {
                    return new global::DId.JsonConverters.VoicesResponseItemAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesResponseItemAccess?))
                {
                    return new global::DId.JsonConverters.VoicesResponseItemAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesResponseItemProvider))
                {
                    return new global::DId.JsonConverters.VoicesResponseItemProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesResponseItemProvider?))
                {
                    return new global::DId.JsonConverters.VoicesResponseItemProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesResponseItemVoiceType))
                {
                    return new global::DId.JsonConverters.VoicesResponseItemVoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.VoicesResponseItemVoiceType?))
                {
                    return new global::DId.JsonConverters.VoicesResponseItemVoiceTypeNullableJsonConverter();
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
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}