
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Request2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2>), TypeInfoPropertyName = "AllOfCreateDocumentRequestVariant1CreateDocumentRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant1DocumentType), TypeInfoPropertyName = "CreateDocumentRequestVariant1DocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseType), TypeInfoPropertyName = "Create1ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.Get1ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseItemType), TypeInfoPropertyName = "Get1ResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseDocumentType), TypeInfoPropertyName = "CreateDocumentResponseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseType), TypeInfoPropertyName = "CreateDocumentResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseStatus), TypeInfoPropertyName = "CreateDocumentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetDocumentsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemDocumentType), TypeInfoPropertyName = "GetDocumentsResponseItemDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemType), TypeInfoPropertyName = "GetDocumentsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemStatus), TypeInfoPropertyName = "GetDocumentsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponseType), TypeInfoPropertyName = "GetByIdResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1ResponseType), TypeInfoPropertyName = "Update1ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseDocumentType), TypeInfoPropertyName = "GetDocumentResponseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseType), TypeInfoPropertyName = "GetDocumentResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseStatus), TypeInfoPropertyName = "GetDocumentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.DeleteDocumentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteDocumentResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2>?), TypeInfoPropertyName = "NullableAllOfCreateDocumentRequestVariant1CreateDocumentRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant1DocumentType?), TypeInfoPropertyName = "NullableCreateDocumentRequestVariant1DocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseType?), TypeInfoPropertyName = "NullableCreate1ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseItemType?), TypeInfoPropertyName = "NullableGet1ResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseDocumentType?), TypeInfoPropertyName = "NullableCreateDocumentResponseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseType?), TypeInfoPropertyName = "NullableCreateDocumentResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseStatus?), TypeInfoPropertyName = "NullableCreateDocumentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemDocumentType?), TypeInfoPropertyName = "NullableGetDocumentsResponseItemDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemType?), TypeInfoPropertyName = "NullableGetDocumentsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemStatus?), TypeInfoPropertyName = "NullableGetDocumentsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponseType?), TypeInfoPropertyName = "NullableGetByIdResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1ResponseType?), TypeInfoPropertyName = "NullableUpdate1ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseDocumentType?), TypeInfoPropertyName = "NullableGetDocumentResponseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseType?), TypeInfoPropertyName = "NullableGetDocumentResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseStatus?), TypeInfoPropertyName = "NullableGetDocumentResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.Get1ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetDocumentsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.DeleteDocumentResponseItem>))]
    internal sealed partial class KnowledgeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KnowledgeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2>());
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
                    typeToConvert == typeof(global::DId.CreateDocumentRequestVariant1DocumentType)

                    || typeToConvert == typeof(global::DId.CreateDocumentRequestVariant1DocumentType?)

                    || typeToConvert == typeof(global::DId.Create1ResponseType)

                    || typeToConvert == typeof(global::DId.Create1ResponseType?)

                    || typeToConvert == typeof(global::DId.Get1ResponseItemType)

                    || typeToConvert == typeof(global::DId.Get1ResponseItemType?)

                    || typeToConvert == typeof(global::DId.CreateDocumentResponseDocumentType)

                    || typeToConvert == typeof(global::DId.CreateDocumentResponseDocumentType?)

                    || typeToConvert == typeof(global::DId.CreateDocumentResponseType)

                    || typeToConvert == typeof(global::DId.CreateDocumentResponseType?)

                    || typeToConvert == typeof(global::DId.CreateDocumentResponseStatus)

                    || typeToConvert == typeof(global::DId.CreateDocumentResponseStatus?)

                    || typeToConvert == typeof(global::DId.GetDocumentsResponseItemDocumentType)

                    || typeToConvert == typeof(global::DId.GetDocumentsResponseItemDocumentType?)

                    || typeToConvert == typeof(global::DId.GetDocumentsResponseItemType)

                    || typeToConvert == typeof(global::DId.GetDocumentsResponseItemType?)

                    || typeToConvert == typeof(global::DId.GetDocumentsResponseItemStatus)

                    || typeToConvert == typeof(global::DId.GetDocumentsResponseItemStatus?)

                    || typeToConvert == typeof(global::DId.GetByIdResponseType)

                    || typeToConvert == typeof(global::DId.GetByIdResponseType?)

                    || typeToConvert == typeof(global::DId.Update1ResponseType)

                    || typeToConvert == typeof(global::DId.Update1ResponseType?)

                    || typeToConvert == typeof(global::DId.GetDocumentResponseDocumentType)

                    || typeToConvert == typeof(global::DId.GetDocumentResponseDocumentType?)

                    || typeToConvert == typeof(global::DId.GetDocumentResponseType)

                    || typeToConvert == typeof(global::DId.GetDocumentResponseType?)

                    || typeToConvert == typeof(global::DId.GetDocumentResponseStatus)

                    || typeToConvert == typeof(global::DId.GetDocumentResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.CreateDocumentRequestVariant1DocumentType))
                {
                    return new global::DId.JsonConverters.CreateDocumentRequestVariant1DocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentRequestVariant1DocumentType?))
                {
                    return new global::DId.JsonConverters.CreateDocumentRequestVariant1DocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create1ResponseType))
                {
                    return new global::DId.JsonConverters.Create1ResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create1ResponseType?))
                {
                    return new global::DId.JsonConverters.Create1ResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Get1ResponseItemType))
                {
                    return new global::DId.JsonConverters.Get1ResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Get1ResponseItemType?))
                {
                    return new global::DId.JsonConverters.Get1ResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentResponseDocumentType))
                {
                    return new global::DId.JsonConverters.CreateDocumentResponseDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentResponseDocumentType?))
                {
                    return new global::DId.JsonConverters.CreateDocumentResponseDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentResponseType))
                {
                    return new global::DId.JsonConverters.CreateDocumentResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentResponseType?))
                {
                    return new global::DId.JsonConverters.CreateDocumentResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentResponseStatus))
                {
                    return new global::DId.JsonConverters.CreateDocumentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateDocumentResponseStatus?))
                {
                    return new global::DId.JsonConverters.CreateDocumentResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentsResponseItemDocumentType))
                {
                    return new global::DId.JsonConverters.GetDocumentsResponseItemDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentsResponseItemDocumentType?))
                {
                    return new global::DId.JsonConverters.GetDocumentsResponseItemDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentsResponseItemType))
                {
                    return new global::DId.JsonConverters.GetDocumentsResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentsResponseItemType?))
                {
                    return new global::DId.JsonConverters.GetDocumentsResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentsResponseItemStatus))
                {
                    return new global::DId.JsonConverters.GetDocumentsResponseItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentsResponseItemStatus?))
                {
                    return new global::DId.JsonConverters.GetDocumentsResponseItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetByIdResponseType))
                {
                    return new global::DId.JsonConverters.GetByIdResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetByIdResponseType?))
                {
                    return new global::DId.JsonConverters.GetByIdResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Update1ResponseType))
                {
                    return new global::DId.JsonConverters.Update1ResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Update1ResponseType?))
                {
                    return new global::DId.JsonConverters.Update1ResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentResponseDocumentType))
                {
                    return new global::DId.JsonConverters.GetDocumentResponseDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentResponseDocumentType?))
                {
                    return new global::DId.JsonConverters.GetDocumentResponseDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentResponseType))
                {
                    return new global::DId.JsonConverters.GetDocumentResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentResponseType?))
                {
                    return new global::DId.JsonConverters.GetDocumentResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentResponseStatus))
                {
                    return new global::DId.JsonConverters.GetDocumentResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetDocumentResponseStatus?))
                {
                    return new global::DId.JsonConverters.GetDocumentResponseStatusNullableJsonConverter();
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
                    0 => new KnowledgeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}