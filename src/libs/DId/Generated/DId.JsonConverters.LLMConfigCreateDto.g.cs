#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public class LLMConfigCreateDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.LLMConfigCreateDto>
    {
        /// <inheritdoc />
        public override global::DId.LLMConfigCreateDto Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("instructions")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("prompt_customization")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            if (__jsonProps.Contains("template")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("custom")) __score1++;
            if (__jsonProps.Contains("instructions")) __score1++;
            if (__jsonProps.Contains("prompt_customization")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            if (__jsonProps.Contains("template")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("prompt_customization")) __score2++;
            if (__jsonProps.Contains("secretId")) __score2++;
            if (__jsonProps.Contains("temperature")) __score2++;
            if (__jsonProps.Contains("template")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("instructions")) __score3++;
            if (__jsonProps.Contains("prompt_customization")) __score3++;
            if (__jsonProps.Contains("secretId")) __score3++;
            if (__jsonProps.Contains("temperature")) __score3++;
            if (__jsonProps.Contains("template")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("instructions")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("prompt_customization")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            if (__jsonProps.Contains("temperature")) __score4++;
            if (__jsonProps.Contains("template")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("instructions")) __score5++;
            if (__jsonProps.Contains("model")) __score5++;
            if (__jsonProps.Contains("prompt_customization")) __score5++;
            if (__jsonProps.Contains("provider")) __score5++;
            if (__jsonProps.Contains("temperature")) __score5++;
            if (__jsonProps.Contains("template")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::DId.LLMConfigCreateDtoVariant1? value1 = default;
            global::DId.LLMConfigCreateDtoVariant2? value2 = default;
            global::DId.LLMConfigCreateDtoVariant3? value3 = default;
            global::DId.LLMConfigCreateDtoVariant4? value4 = default;
            global::DId.LLMConfigCreateDtoVariant5? value5 = default;
            global::DId.LLMConfigCreateDtoVariant6? value6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant1).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant2).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant3).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant4).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant5).Name}");
                        value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant6).Name}");
                        value6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null && value6 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant3).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant4).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant5).Name}");
                    value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant6).Name}");
                    value6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::DId.LLMConfigCreateDto(
                value1,

                value2,

                value3,

                value4,

                value5,

                value6
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.LLMConfigCreateDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5!, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.LLMConfigCreateDtoVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.LLMConfigCreateDtoVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.LLMConfigCreateDtoVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6!, typeInfo);
            }
        }
    }
}