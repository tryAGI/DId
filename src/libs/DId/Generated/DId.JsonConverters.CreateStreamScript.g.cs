#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DId.JsonConverters
{
    /// <inheritdoc />
    public class CreateStreamScriptJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DId.CreateStreamScript>
    {
        /// <inheritdoc />
        public override global::DId.CreateStreamScript Read(
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
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("ssml")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audio_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::DId.CreateStreamScriptText? text = default;
            global::DId.CreateStreamScriptAudio? audio = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.CreateStreamScriptText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.CreateStreamScriptText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.CreateStreamScriptText).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.CreateStreamScriptAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.CreateStreamScriptAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.CreateStreamScriptAudio).Name}");
                        audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (text == null && audio == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.CreateStreamScriptText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.CreateStreamScriptText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.CreateStreamScriptText).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.CreateStreamScriptAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.CreateStreamScriptAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.CreateStreamScriptAudio).Name}");
                    audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::DId.CreateStreamScript(
                text,

                audio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DId.CreateStreamScript value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.CreateStreamScriptText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.CreateStreamScriptText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.CreateStreamScriptText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DId.CreateStreamScriptAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DId.CreateStreamScriptAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DId.CreateStreamScriptAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
        }
    }
}