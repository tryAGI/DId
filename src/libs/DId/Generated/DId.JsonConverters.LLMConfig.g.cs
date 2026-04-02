#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public class LLMConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.LLMConfig>
    {
        /// <inheritdoc />
        public override global::DId.LLMConfig Read(
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
            if (__jsonProps.Contains("instructions")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("prompt_customization")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            if (__jsonProps.Contains("template")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("instructions")) __score1++;
            if (__jsonProps.Contains("prompt_customization")) __score1++;
            if (__jsonProps.Contains("secretId")) __score1++;
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
            if (__jsonProps.Contains("model")) __score3++;
            if (__jsonProps.Contains("prompt_customization")) __score3++;
            if (__jsonProps.Contains("provider")) __score3++;
            if (__jsonProps.Contains("temperature")) __score3++;
            if (__jsonProps.Contains("template")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("instructions")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("prompt_customization")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            if (__jsonProps.Contains("temperature")) __score4++;
            if (__jsonProps.Contains("template")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::DId.LLMConfigOpenAI? openAI = default;
            global::DId.LLMConfigVariant2? lLMConfigVariant2 = default;
            global::DId.LLMConfigVariant3? lLMConfigVariant3 = default;
            global::DId.LLMConfigDId? dId = default;
            global::DId.LLMConfigGoogle? google = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        openAI = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigOpenAI>(__rawJson, options);
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
                        lLMConfigVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigVariant2>(__rawJson, options);
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
                        lLMConfigVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigVariant3>(__rawJson, options);
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
                        dId = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigDId>(__rawJson, options);
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
                        google = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigGoogle>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAI == null && lLMConfigVariant2 == null && lLMConfigVariant3 == null && dId == null && google == null)
            {
                try
                {
                    openAI = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigOpenAI>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lLMConfigVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    dId = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigDId>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    google = global::System.Text.Json.JsonSerializer.Deserialize<global::DId.LLMConfigGoogle>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::DId.LLMConfig(
                openAI,

                lLMConfigVariant2,

                lLMConfigVariant3,

                dId,

                google
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.LLMConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOpenAI)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAI, typeof(global::DId.LLMConfigOpenAI), options);
            }
            else if (value.IsLLMConfigVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigVariant2, typeof(global::DId.LLMConfigVariant2), options);
            }
            else if (value.IsLLMConfigVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMConfigVariant3, typeof(global::DId.LLMConfigVariant3), options);
            }
            else if (value.IsDId)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DId, typeof(global::DId.LLMConfigDId), options);
            }
            else if (value.IsGoogle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google, typeof(global::DId.LLMConfigGoogle), options);
            }
        }
    }
}