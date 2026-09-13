
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderOpenAI_6f322c722f082968")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI_8ac4edfe0623d9c0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceOpenAI_ecab93a8d83a5bf5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>?), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderOpenAI_ab424bc3115b09af")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>?), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI_d6c16afa39598d0f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>?), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceOpenAI_1636f4a27594518e")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestConfigLogo, bool?>), TypeInfoPropertyName = "AnyOfCreate3RequestConfigLogoBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfigResultFormat), TypeInfoPropertyName = "Create3RequestConfigResultFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestBackgroundVariant1, global::DId.Create3RequestBackgroundVariant2>), TypeInfoPropertyName = "AnyOfCreate3RequestBackgroundVariant1Create3RequestBackgroundVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant1Type), TypeInfoPropertyName = "Create3RequestBackgroundVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant2Type), TypeInfoPropertyName = "Create3RequestBackgroundVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1, global::DId.Create3RequestScriptVariant2>), TypeInfoPropertyName = "AnyOfCreate3RequestScriptVariant1Create3RequestScriptVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1Type), TypeInfoPropertyName = "Create3RequestScriptVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType), TypeInfoPropertyName = "Create3RequestScriptVariant1ProviderOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant2Type), TypeInfoPropertyName = "Create3RequestScriptVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>), TypeInfoPropertyName = "AllOfAllOfGetAvatars1ResponseAvatarVariant1ObjectGetAvatars1ResponseAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>), TypeInfoPropertyName = "AllOfGetAvatars1ResponseAvatarVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>), TypeInfoPropertyName = "AllOfGetAvatars1ResponseAvatarSentimentVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType), TypeInfoPropertyName = "GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>), TypeInfoPropertyName = "AllOfAllOfGetAvatarByIdResponseVariant12ObjectGetAvatarByIdResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>), TypeInfoPropertyName = "AllOfGetAvatarByIdResponseVariant12Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>), TypeInfoPropertyName = "AllOfGetAvatarByIdResponseSentimentVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType), TypeInfoPropertyName = "GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.Create3ResponseVariant1, global::DId.Create3ResponseVariant2>), TypeInfoPropertyName = "AllOfCreate3ResponseVariant1Create3ResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant1Status), TypeInfoPropertyName = "Create3ResponseVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant2Object), TypeInfoPropertyName = "Create3ResponseVariant2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseExpressive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressiveStatus), TypeInfoPropertyName = "GetExpressivesResponseExpressiveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressiveError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2ResponseStatus), TypeInfoPropertyName = "Get2ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestConfigLogo, bool?>?), TypeInfoPropertyName = "NullableAnyOfCreate3RequestConfigLogoBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfigResultFormat?), TypeInfoPropertyName = "NullableCreate3RequestConfigResultFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestBackgroundVariant1, global::DId.Create3RequestBackgroundVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreate3RequestBackgroundVariant1Create3RequestBackgroundVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant1Type?), TypeInfoPropertyName = "NullableCreate3RequestBackgroundVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant2Type?), TypeInfoPropertyName = "NullableCreate3RequestBackgroundVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1, global::DId.Create3RequestScriptVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreate3RequestScriptVariant1Create3RequestScriptVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1Type?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1ProviderMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1ProviderElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1ProviderAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1ProviderAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1ProviderGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant1ProviderOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant2Type?), TypeInfoPropertyName = "NullableCreate3RequestScriptVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>?), TypeInfoPropertyName = "NullableAllOfAllOfGetAvatars1ResponseAvatarVariant1ObjectGetAvatars1ResponseAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?), TypeInfoPropertyName = "NullableAllOfGetAvatars1ResponseAvatarVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>?), TypeInfoPropertyName = "NullableAllOfGetAvatars1ResponseAvatarSentimentVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType?), TypeInfoPropertyName = "NullableGetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>?), TypeInfoPropertyName = "NullableAllOfAllOfGetAvatarByIdResponseVariant12ObjectGetAvatarByIdResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?), TypeInfoPropertyName = "NullableAllOfGetAvatarByIdResponseVariant12Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>?), TypeInfoPropertyName = "NullableAllOfGetAvatarByIdResponseSentimentVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1VoiceAmazonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1VoiceGoogleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType?), TypeInfoPropertyName = "NullableGetAvatarByIdResponseSentimentVariant1VoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.Create3ResponseVariant1, global::DId.Create3ResponseVariant2>?), TypeInfoPropertyName = "NullableAllOfCreate3ResponseVariant1Create3ResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant1Status?), TypeInfoPropertyName = "NullableCreate3ResponseVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant2Object?), TypeInfoPropertyName = "NullableCreate3ResponseVariant2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressiveStatus?), TypeInfoPropertyName = "NullableGetExpressivesResponseExpressiveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2ResponseStatus?), TypeInfoPropertyName = "NullableGet2ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetExpressivesResponseExpressive>))]
    internal sealed partial class V4AvatarsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V4AvatarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static V4AvatarsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private V4AvatarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestConfigLogo, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestBackgroundVariant1, global::DId.Create3RequestBackgroundVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestScriptVariant1, global::DId.Create3RequestScriptVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatars1ResponseAvatarVariant1, object>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatarByIdResponseVariant12, object>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1, object>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.Create3ResponseVariant1, global::DId.Create3ResponseVariant2>());
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
                    typeToConvert == typeof(global::DId.Create3RequestConfigResultFormat)

                    || typeToConvert == typeof(global::DId.Create3RequestConfigResultFormat?)

                    || typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant1Type)

                    || typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant1Type?)

                    || typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant2Type)

                    || typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant2Type?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1Type)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1Type?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType?)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant2Type)

                    || typeToConvert == typeof(global::DId.Create3RequestScriptVariant2Type?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType?)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType?)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.Create3ResponseVariant1Status)

                    || typeToConvert == typeof(global::DId.Create3ResponseVariant1Status?)

                    || typeToConvert == typeof(global::DId.Create3ResponseVariant2Object)

                    || typeToConvert == typeof(global::DId.Create3ResponseVariant2Object?)

                    || typeToConvert == typeof(global::DId.GetExpressivesResponseExpressiveStatus)

                    || typeToConvert == typeof(global::DId.GetExpressivesResponseExpressiveStatus?)

                    || typeToConvert == typeof(global::DId.Get2ResponseStatus)

                    || typeToConvert == typeof(global::DId.Get2ResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.Create3RequestConfigResultFormat))
                {
                    return new global::DId.JsonConverters.Create3RequestConfigResultFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestConfigResultFormat?))
                {
                    return new global::DId.JsonConverters.Create3RequestConfigResultFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant1Type))
                {
                    return new global::DId.JsonConverters.Create3RequestBackgroundVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant1Type?))
                {
                    return new global::DId.JsonConverters.Create3RequestBackgroundVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant2Type))
                {
                    return new global::DId.JsonConverters.Create3RequestBackgroundVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestBackgroundVariant2Type?))
                {
                    return new global::DId.JsonConverters.Create3RequestBackgroundVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1Type))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1Type?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderGoogleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderGoogleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant1ProviderOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant2Type))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3RequestScriptVariant2Type?))
                {
                    return new global::DId.JsonConverters.Create3RequestScriptVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1SentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1SentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1SentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1SentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3ResponseVariant1Status))
                {
                    return new global::DId.JsonConverters.Create3ResponseVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3ResponseVariant1Status?))
                {
                    return new global::DId.JsonConverters.Create3ResponseVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3ResponseVariant2Object))
                {
                    return new global::DId.JsonConverters.Create3ResponseVariant2ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Create3ResponseVariant2Object?))
                {
                    return new global::DId.JsonConverters.Create3ResponseVariant2ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetExpressivesResponseExpressiveStatus))
                {
                    return new global::DId.JsonConverters.GetExpressivesResponseExpressiveStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetExpressivesResponseExpressiveStatus?))
                {
                    return new global::DId.JsonConverters.GetExpressivesResponseExpressiveStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Get2ResponseStatus))
                {
                    return new global::DId.JsonConverters.Get2ResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.Get2ResponseStatus?))
                {
                    return new global::DId.JsonConverters.Get2ResponseStatusNullableJsonConverter();
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
                    0 => new V4AvatarsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}