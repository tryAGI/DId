
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationStatus), TypeInfoPropertyName = "CreateResponseTranslationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationTranscriptionVersion), TypeInfoPropertyName = "CreateResponseTranslationTranscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationStatus2), TypeInfoPropertyName = "GetTranslationsResponseTranslationStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscription2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2), TypeInfoPropertyName = "GetTranslationsResponseTranslationTranscriptionVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseStatus2), TypeInfoPropertyName = "GetGroupResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationStatus2), TypeInfoPropertyName = "GetGroupResponseTranslationStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscription2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2), TypeInfoPropertyName = "GetGroupResponseTranslationTranscriptionVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseStatus2), TypeInfoPropertyName = "GetTranslationResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationResponseTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscription2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscriptionVersion2), TypeInfoPropertyName = "GetTranslationResponseTranscriptionVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationStatus?), TypeInfoPropertyName = "NullableCreateResponseTranslationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationTranscriptionVersion?), TypeInfoPropertyName = "NullableCreateResponseTranslationTranscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationStatus2?), TypeInfoPropertyName = "NullableGetTranslationsResponseTranslationStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2?), TypeInfoPropertyName = "NullableGetTranslationsResponseTranslationTranscriptionVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseStatus2?), TypeInfoPropertyName = "NullableGetGroupResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationStatus2?), TypeInfoPropertyName = "NullableGetGroupResponseTranslationStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2?), TypeInfoPropertyName = "NullableGetGroupResponseTranslationTranscriptionVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseStatus2?), TypeInfoPropertyName = "NullableGetTranslationResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscriptionVersion2?), TypeInfoPropertyName = "NullableGetTranslationResponseTranscriptionVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationResponseTranscription2>))]
    internal sealed partial class VideoTranslateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoTranslateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoTranslateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoTranslateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::DId.CreateResponseTranslationStatus)

                    || typeToConvert == typeof(global::DId.CreateResponseTranslationStatus?)

                    || typeToConvert == typeof(global::DId.CreateResponseTranslationTranscriptionVersion)

                    || typeToConvert == typeof(global::DId.CreateResponseTranslationTranscriptionVersion?)

                    || typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationStatus2)

                    || typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationStatus2?)

                    || typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2)

                    || typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2?)

                    || typeToConvert == typeof(global::DId.GetGroupResponseStatus2)

                    || typeToConvert == typeof(global::DId.GetGroupResponseStatus2?)

                    || typeToConvert == typeof(global::DId.GetGroupResponseTranslationStatus2)

                    || typeToConvert == typeof(global::DId.GetGroupResponseTranslationStatus2?)

                    || typeToConvert == typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2)

                    || typeToConvert == typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2?)

                    || typeToConvert == typeof(global::DId.GetTranslationResponseStatus2)

                    || typeToConvert == typeof(global::DId.GetTranslationResponseStatus2?)

                    || typeToConvert == typeof(global::DId.GetTranslationResponseTranscriptionVersion2)

                    || typeToConvert == typeof(global::DId.GetTranslationResponseTranscriptionVersion2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.CreateResponseTranslationStatus))
                {
                    return new global::DId.JsonConverters.CreateResponseTranslationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseTranslationStatus?))
                {
                    return new global::DId.JsonConverters.CreateResponseTranslationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseTranslationTranscriptionVersion))
                {
                    return new global::DId.JsonConverters.CreateResponseTranslationTranscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseTranslationTranscriptionVersion?))
                {
                    return new global::DId.JsonConverters.CreateResponseTranslationTranscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationStatus2))
                {
                    return new global::DId.JsonConverters.GetTranslationsResponseTranslationStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationStatus2?))
                {
                    return new global::DId.JsonConverters.GetTranslationsResponseTranslationStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2))
                {
                    return new global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersion2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2?))
                {
                    return new global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersion2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetGroupResponseStatus2))
                {
                    return new global::DId.JsonConverters.GetGroupResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetGroupResponseStatus2?))
                {
                    return new global::DId.JsonConverters.GetGroupResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetGroupResponseTranslationStatus2))
                {
                    return new global::DId.JsonConverters.GetGroupResponseTranslationStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetGroupResponseTranslationStatus2?))
                {
                    return new global::DId.JsonConverters.GetGroupResponseTranslationStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2))
                {
                    return new global::DId.JsonConverters.GetGroupResponseTranslationTranscriptionVersion2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2?))
                {
                    return new global::DId.JsonConverters.GetGroupResponseTranslationTranscriptionVersion2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationResponseStatus2))
                {
                    return new global::DId.JsonConverters.GetTranslationResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationResponseStatus2?))
                {
                    return new global::DId.JsonConverters.GetTranslationResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationResponseTranscriptionVersion2))
                {
                    return new global::DId.JsonConverters.GetTranslationResponseTranscriptionVersion2JsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetTranslationResponseTranscriptionVersion2?))
                {
                    return new global::DId.JsonConverters.GetTranslationResponseTranscriptionVersion2NullableJsonConverter();
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
                    0 => new VideoTranslateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}