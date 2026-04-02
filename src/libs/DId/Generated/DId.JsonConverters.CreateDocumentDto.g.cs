#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public class CreateDocumentDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateDocumentDto>
    {
        /// <inheritdoc />
        public override global::DId.CreateDocumentDto Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            if (__jsonProps.Contains("documentType")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("source_url")) __score1++;
            if (__jsonProps.Contains("title")) __score1++;
            if (__jsonProps.Contains("webhook")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::DId.CreateDocumentDtoVariant1? createDocumentDtoVariant1 = default;
            global::DId.CreateDocumentDtoVariant2? createDocumentDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        createDocumentDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.CreateDocumentDtoVariant1>(__rawJson, options);
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
                        createDocumentDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.CreateDocumentDtoVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createDocumentDtoVariant1 == null && createDocumentDtoVariant2 == null)
            {
                try
                {
                    createDocumentDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.CreateDocumentDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createDocumentDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.CreateDocumentDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::DId.CreateDocumentDto(
                createDocumentDtoVariant1,

                createDocumentDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateDocumentDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCreateDocumentDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateDocumentDtoVariant1, typeof(global::DId.CreateDocumentDtoVariant1), options);
            }
            else if (value.IsCreateDocumentDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateDocumentDtoVariant2, typeof(global::DId.CreateDocumentDtoVariant2), options);
            }
        }
    }
}