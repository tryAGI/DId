
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
            typeof(global::DId.JsonConverters.TalkStatusJsonConverter),

            typeof(global::DId.JsonConverters.TalkStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersMicrosoftJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersMicrosoftNullableJsonConverter),

            typeof(global::DId.JsonConverters.MicrosoftTtsProviderTypeJsonConverter),

            typeof(global::DId.JsonConverters.MicrosoftTtsProviderTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersElevenlabsJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersElevenlabsNullableJsonConverter),

            typeof(global::DId.JsonConverters.ElevenlabsTtsProviderTypeJsonConverter),

            typeof(global::DId.JsonConverters.ElevenlabsTtsProviderTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersAmazonJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersAmazonNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoiceIdsAmazonJsonConverter),

            typeof(global::DId.JsonConverters.VoiceIdsAmazonNullableJsonConverter),

            typeof(global::DId.JsonConverters.AmazonTtsProviderTypeJsonConverter),

            typeof(global::DId.JsonConverters.AmazonTtsProviderTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AmazonTtsProviderVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.AmazonTtsProviderVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersGoogleJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersGoogleNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleTtsProviderTypeJsonConverter),

            typeof(global::DId.JsonConverters.GoogleTtsProviderTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersAzureOpenAiJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersAzureOpenAiNullableJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAiTtsProviderTypeJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAiTtsProviderTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScriptProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AudioScriptTypeJsonConverter),

            typeof(global::DId.JsonConverters.AudioScriptTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.ScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.ResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressionJsonConverter),

            typeof(global::DId.JsonConverters.ExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.TimedExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.TimedExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressionConfigExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.ExpressionConfigExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalksConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.TalksConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalksConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.TalksConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.OverlapKindJsonConverter),

            typeof(global::DId.JsonConverters.OverlapKindNullableJsonConverter),

            typeof(global::DId.JsonConverters.FaceSquareDtoOverlapJsonConverter),

            typeof(global::DId.JsonConverters.FaceSquareDtoOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkDtoConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkDtoConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkDtoConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkDtoConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksDtoTalkStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksDtoTalkStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksDtoTalkConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksDtoTalkConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.OfferJsepTypeJsonConverter),

            typeof(global::DId.JsonConverters.OfferJsepTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CompatibilityModeJsonConverter),

            typeof(global::DId.JsonConverters.CompatibilityModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoiceAccessJsonConverter),

            typeof(global::DId.JsonConverters.VoiceAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.ElevenlabsStreamTtsProviderTypeJsonConverter),

            typeof(global::DId.JsonConverters.ElevenlabsStreamTtsProviderTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ElevenlabsStreamTtsProviderAccessJsonConverter),

            typeof(global::DId.JsonConverters.ElevenlabsStreamTtsProviderAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.TalkAgentPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipAgentPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionIdOrSentimentSentimentJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionIdOrSentimentSentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentSentimentSentimentJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentSentimentSentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAgentPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentsLLMModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentsLLMModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMProviderJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMTemplateJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMModelJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomBasicKeyConfigTypeJsonConverter),

            typeof(global::DId.JsonConverters.CustomBasicKeyConfigTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthOauth2ConfigTypeJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthOauth2ConfigTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthConfigBasicTypeJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthConfigBasicTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthConfigOAuth2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthConfigOAuth2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMTemplateJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMModelJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMProviderJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMTemplateJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMModel2JsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMModel2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMModelJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMProviderJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMTemplateJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMModel2JsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMModel2NullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.EmbeddingProviderJsonConverter),

            typeof(global::DId.JsonConverters.EmbeddingProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeEmbedderProviderJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeEmbedderProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeProvider2JsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeProvider2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUseCaseJsonConverter),

            typeof(global::DId.JsonConverters.AgentUseCaseNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentStatusJsonConverter),

            typeof(global::DId.JsonConverters.AgentStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.ToolChoiceStrategyJsonConverter),

            typeof(global::DId.JsonConverters.ToolChoiceStrategyNullableJsonConverter),

            typeof(global::DId.JsonConverters.CloudProviderJsonConverter),

            typeof(global::DId.JsonConverters.CloudProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetStatusJsonConverter),

            typeof(global::DId.JsonConverters.AssetStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetCloudProviderJsonConverter),

            typeof(global::DId.JsonConverters.AssetCloudProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetStatus2JsonConverter),

            typeof(global::DId.JsonConverters.AssetStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsAccess2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceElevenLabsAccess2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterPhotoAvatarVoiceOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsAccess2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceElevenLabsAccess2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterVideoAvatarVoiceOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterExpressiveAvatarVoiceOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentLlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentKnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentKnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AnswerJsepTypeJsonConverter),

            typeof(global::DId.JsonConverters.AnswerJsepTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptTypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamTextScriptProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamAudioScriptTypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamAudioScriptTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.RoleJsonConverter),

            typeof(global::DId.JsonConverters.RoleNullableJsonConverter),

            typeof(global::DId.JsonConverters.MessageRoleJsonConverter),

            typeof(global::DId.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitTalksConfigLogoOrDriverExpressionsResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.OmitTalksConfigLogoOrDriverExpressionsResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.A2eModelJsonConverter),

            typeof(global::DId.JsonConverters.A2eModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsPresentersResponsePresenterStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtA2eModelJsonConverter),

            typeof(global::DId.JsonConverters.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtA2eModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1A2eModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesVariant1A2eModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipAvatarStatusJsonConverter),

            typeof(global::DId.JsonConverters.ClipAvatarStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipTrainRequestGenderJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipTrainRequestGenderNullableJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersJsonConverter),

            typeof(global::DId.JsonConverters.ProvidersNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipStatusJsonConverter),

            typeof(global::DId.JsonConverters.ClipStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseObjectJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.ClipConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.WideCropTypeJsonConverter),

            typeof(global::DId.JsonConverters.WideCropTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.RectangleCropTypeJsonConverter),

            typeof(global::DId.JsonConverters.RectangleCropTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CropVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CropVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CropVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CropVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterConfigCropVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterConfigCropVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterConfigCropVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.ClipPresenterConfigCropVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.ClipStreamConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.ClipStreamConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.TranslationStatusJsonConverter),

            typeof(global::DId.JsonConverters.TranslationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.TranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.TranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.TranscriptionVersion2JsonConverter),

            typeof(global::DId.JsonConverters.TranscriptionVersion2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTranslationResponseDtoTranslationStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateTranslationResponseDtoTranslationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTranslationResponseDtoTranslationTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.CreateTranslationResponseDtoTranslationTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GroupStatusJsonConverter),

            typeof(global::DId.JsonConverters.GroupStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatusJsonConverter),

            typeof(global::DId.JsonConverters.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GroupTranslationStatusJsonConverter),

            typeof(global::DId.JsonConverters.GroupTranslationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GroupTranslationTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.GroupTranslationTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.SceneAvatarStatusJsonConverter),

            typeof(global::DId.JsonConverters.SceneAvatarStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAvatarResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateAvatarResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAvatarResponseDtoObjectJsonConverter),

            typeof(global::DId.JsonConverters.CreateAvatarResponseDtoObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarResponseDtoObjectJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarResponseDtoObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.SceneAvatarStatusDraftJsonConverter),

            typeof(global::DId.JsonConverters.SceneAvatarStatusDraftNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseDtoAvatarStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseDtoAvatarStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseDtoAvatarObjectJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseDtoAvatarObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.SceneStatusJsonConverter),

            typeof(global::DId.JsonConverters.SceneStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneResponseDtoObjectJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneResponseDtoObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptTextProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptAudioTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSceneRequestDtoScriptAudioTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetSceneResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetSceneResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetScenesResponseDtoSceneStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetScenesResponseDtoSceneStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoSentimentJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoSentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionPublicDtoVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1SentimentJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1SentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1SentimentJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1SentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1SentimentJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1SentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TrainingStatusJsonConverter),

            typeof(global::DId.JsonConverters.TrainingStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.PostTrainingResponseItemStatusJsonConverter),

            typeof(global::DId.JsonConverters.PostTrainingResponseItemStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.SentimentConfigVoiceTypeJsonConverter),

            typeof(global::DId.JsonConverters.SentimentConfigVoiceTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveStatusJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveVideoIdOrStatusOrCreatedAtStatusJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveVideoIdOrStatusOrCreatedAtStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveResponseDtoVariant1StatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveResponseDtoVariant1StatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveResponseDtoVariant2ObjectJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveResponseDtoVariant2ObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.ColorBackgroundTypeJsonConverter),

            typeof(global::DId.JsonConverters.ColorBackgroundTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveImageBackgroundTypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveImageBackgroundTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoBackgroundVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoBackgroundVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoBackgroundVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoBackgroundVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveInferenceModeJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveInferenceModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.InternalCallConfigInferenceModeJsonConverter),

            typeof(global::DId.JsonConverters.InternalCallConfigInferenceModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3TypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.TextScript3ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AudioScript3TypeJsonConverter),

            typeof(global::DId.JsonConverters.AudioScript3TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoBackgroundVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoBackgroundVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoBackgroundVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoBackgroundVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveRequestDtoScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveVideoExpressivePublicAllowedAttributesStatusJsonConverter),

            typeof(global::DId.JsonConverters.PickExpressiveVideoExpressivePublicAllowedAttributesStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressivesResponseDtoExpressiveStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressivesResponseDtoExpressiveStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventTypeChatEndJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventTypeChatEndNullableJsonConverter),

            typeof(global::DId.JsonConverters.MessageRole2JsonConverter),

            typeof(global::DId.JsonConverters.MessageRole2NullableJsonConverter),

            typeof(global::DId.JsonConverters.ToolResultOutputVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.ToolResultOutputVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ToolResultOutputVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.ToolResultOutputVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.IMessageRoleJsonConverter),

            typeof(global::DId.JsonConverters.IMessageRoleNullableJsonConverter),

            typeof(global::DId.JsonConverters.UserPlanJsonConverter),

            typeof(global::DId.JsonConverters.UserPlanNullableJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalChatPlanJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalChatPlanNullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatEndEventDataEventTypeJsonConverter),

            typeof(global::DId.JsonConverters.ChatEndEventDataEventTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventTypeChatStartJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventTypeChatStartNullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatStartEventDataEventTypeJsonConverter),

            typeof(global::DId.JsonConverters.ChatStartEventDataEventTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventDataVariant2EventTypeJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventDataVariant2EventTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TestWebhookRequestDtoEventTypeJsonConverter),

            typeof(global::DId.JsonConverters.TestWebhookRequestDtoEventTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProviderJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProviderJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.AssetResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1LlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoVariant1KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoTemplateJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoModelJsonConverter),

            typeof(global::DId.JsonConverters.OpenAILLMCreateDtoModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoTemplateJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoCustomBasicTypeJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoCustomBasicTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoCustomOAuth2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CustomLLMCreateDtoCustomOAuth2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMCreateDtoTemplateJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMCreateDtoTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.OpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMCreateDtoTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMCreateDtoTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AzureOpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoTemplateJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoModelJsonConverter),

            typeof(global::DId.JsonConverters.DIdLLMCreateDtoModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoTemplateJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoModelJsonConverter),

            typeof(global::DId.JsonConverters.GoogleLLMCreateDtoModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1ModelJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant1ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2CustomBasicTypeJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2CustomBasicTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2CustomOAuth2TypeJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant2CustomOAuth2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant4TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant4TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5ProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5ModelJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant5ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6ProviderJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6TemplateJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6ModelJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoVariant6ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetMimeTypeJsonConverter),

            typeof(global::DId.JsonConverters.AssetMimeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetCreateDtoMimeTypeJsonConverter),

            typeof(global::DId.JsonConverters.AssetCreateDtoMimeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetUpdateDtoMimeTypeJsonConverter),

            typeof(global::DId.JsonConverters.AssetUpdateDtoMimeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetDtoVariant1MimeTypeJsonConverter),

            typeof(global::DId.JsonConverters.AssetDtoVariant1MimeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AssetDtoVariant2MimeTypeJsonConverter),

            typeof(global::DId.JsonConverters.AssetDtoVariant2MimeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1ModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant1ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2CustomBasicTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2CustomBasicTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2CustomOAuth2TypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant2CustomOAuth2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant4TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant4TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5ProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5ModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant5ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6ProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6ModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentCreateDtoLlmVariant6ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.SortByJsonConverter),

            typeof(global::DId.JsonConverters.SortByNullableJsonConverter),

            typeof(global::DId.JsonConverters.OrderByJsonConverter),

            typeof(global::DId.JsonConverters.OrderByNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialTalkAgentPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentTalkPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialClipAgentPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentClipPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialExpressiveAgentPresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentUpdateDtoLlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitStreamResponseJsepTypeJsonConverter),

            typeof(global::DId.JsonConverters.InitStreamResponseJsepTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitVideoStreamRequestCompatibilityModeJsonConverter),

            typeof(global::DId.JsonConverters.InitVideoStreamRequestCompatibilityModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStartStreamRequestAnswerTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStartStreamRequestAnswerTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamTextScriptProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamAudioScriptTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamAudioScriptTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptTextProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptAudioTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptAudioTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextTypeJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptAudioTypeJsonConverter),

            typeof(global::DId.JsonConverters.UnifiedCreateVideoStreamRequestScriptAudioTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptAudioTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptAudioTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatModeJsonConverter),

            typeof(global::DId.JsonConverters.ChatModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatResponseChatModeJsonConverter),

            typeof(global::DId.JsonConverters.ChatResponseChatModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.IChatPayloadMessageRoleJsonConverter),

            typeof(global::DId.JsonConverters.IChatPayloadMessageRoleNullableJsonConverter),

            typeof(global::DId.JsonConverters.IChatPayloadChatModeJsonConverter),

            typeof(global::DId.JsonConverters.IChatPayloadChatModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TransportProviderJsonConverter),

            typeof(global::DId.JsonConverters.TransportProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.TransportProviderLiveKitJsonConverter),

            typeof(global::DId.JsonConverters.TransportProviderLiveKitNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitLiveKitRoomTransportProviderJsonConverter),

            typeof(global::DId.JsonConverters.InitLiveKitRoomTransportProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitSessionTransportProviderJsonConverter),

            typeof(global::DId.JsonConverters.InitSessionTransportProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.JoinLiveKitRoomTransportProviderJsonConverter),

            typeof(global::DId.JsonConverters.JoinLiveKitRoomTransportProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.JoinLivekitRoomRequestTransportProviderJsonConverter),

            typeof(global::DId.JsonConverters.JoinLivekitRoomRequestTransportProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.OutcomeTypeJsonConverter),

            typeof(global::DId.JsonConverters.OutcomeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SessionInsightsDtoOutcomeJsonConverter),

            typeof(global::DId.JsonConverters.SessionInsightsDtoOutcomeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SessionSummaryDtoInsightsOutcomeJsonConverter),

            typeof(global::DId.JsonConverters.SessionSummaryDtoInsightsOutcomeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExportStatusJsonConverter),

            typeof(global::DId.JsonConverters.ExportStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.ExportWithIdStatusJsonConverter),

            typeof(global::DId.JsonConverters.ExportWithIdStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeTypeJsonConverter),

            typeof(global::DId.JsonConverters.KnowledgeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalKnowledgeTypeJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalKnowledgeTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.DocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SubjectJsonConverter),

            typeof(global::DId.JsonConverters.SubjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalDocumentDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalDocumentDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalDocumentStatusJsonConverter),

            typeof(global::DId.JsonConverters.ILogicalDocumentStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.SupportedDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.SupportedDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentDtoVariant1DocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentDtoVariant1DocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DocumentPayloadDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.DocumentPayloadDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.IKnowledgeMessageRoleJsonConverter),

            typeof(global::DId.JsonConverters.IKnowledgeMessageRoleNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoiceTypeJsonConverter),

            typeof(global::DId.JsonConverters.VoiceTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.IVoiceAccessJsonConverter),

            typeof(global::DId.JsonConverters.IVoiceAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.IVoiceProviderJsonConverter),

            typeof(global::DId.JsonConverters.IVoiceProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.IVoiceVoiceTypeJsonConverter),

            typeof(global::DId.JsonConverters.IVoiceVoiceTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.FaceSquareOverlapJsonConverter),

            typeof(global::DId.JsonConverters.FaceSquareOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.UploadImageResponseDtoFaceOverlapJsonConverter),

            typeof(global::DId.JsonConverters.UploadImageResponseDtoFaceOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreditsItemProductBillingIntervalJsonConverter),

            typeof(global::DId.JsonConverters.CreditsItemProductBillingIntervalNullableJsonConverter),

            typeof(global::DId.JsonConverters.UserCreditsCreditProductBillingIntervalJsonConverter),

            typeof(global::DId.JsonConverters.UserCreditsCreditProductBillingIntervalNullableJsonConverter),

            typeof(global::DId.JsonConverters.ConsentStatusJsonConverter),

            typeof(global::DId.JsonConverters.ConsentStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListResponseDtoConsentStatusJsonConverter),

            typeof(global::DId.JsonConverters.ListResponseDtoConsentStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.AgentsSettingsLlmModelJsonConverter),

            typeof(global::DId.JsonConverters.AgentsSettingsLlmModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.SettingsAgentsLlmModelJsonConverter),

            typeof(global::DId.JsonConverters.SettingsAgentsLlmModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SanitizedSecretDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.SanitizedSecretDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeBasicJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeBasicNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateBasicAuthSecretRequestDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateBasicAuthSecretRequestDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeBearerJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeBearerNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateBearerAuthSecretRequestDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateBearerAuthSecretRequestDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeApiKeyJsonConverter),

            typeof(global::DId.JsonConverters.SecretAuthTypeApiKeyNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateApiKeyAuthSecretRequestDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateApiKeyAuthSecretRequestDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoBasicAuthenticationTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoBasicAuthenticationTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoBearerTokenTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoBearerTokenTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoApiKeyTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoApiKeyTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretOpenAIRequestDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretOpenAIRequestDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretAzureOpenAIRequestDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretAzureOpenAIRequestDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretExternalLLMRequestDtoVariant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretExternalLLMRequestDtoVariant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateBasicAuthSecretRequestDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateBasicAuthSecretRequestDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateBearerAuthSecretRequestDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateBearerAuthSecretRequestDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateApiKeyAuthSecretRequestDtoTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateApiKeyAuthSecretRequestDtoTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoBasicAuthenticationTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoBasicAuthenticationTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoBearerTokenTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoBearerTokenTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoApiKeyTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoApiKeyTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretOpenAIRequestDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretOpenAIRequestDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretAzureOpenAIRequestDtoProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretAzureOpenAIRequestDtoProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretExternalLLMRequestDtoVariant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretExternalLLMRequestDtoVariant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.AnimationStatusJsonConverter),

            typeof(global::DId.JsonConverters.AnimationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.AnimateConfigDtoResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.AnimateConfigDtoResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationDtoFaceOverlapJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationDtoFaceOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationDtoConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationDtoConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseDtoStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseDtoStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseDtoConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseDtoConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseDtoAnimationStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseDtoAnimationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseDtoAnimationConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseDtoAnimationConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitTalkStreamRequestFaceOverlapJsonConverter),

            typeof(global::DId.JsonConverters.InitTalkStreamRequestFaceOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitTalkStreamRequestCompatibilityModeJsonConverter),

            typeof(global::DId.JsonConverters.InitTalkStreamRequestCompatibilityModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.InitClipStreamRequestCompatibilityModeJsonConverter),

            typeof(global::DId.JsonConverters.InitClipStreamRequestCompatibilityModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderGoogleType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderGoogleType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant1ProviderOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant2Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestScriptVariant2Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigResultFormat2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigResultFormat2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigDriverExpressionsExpressionExpression2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkRequestConfigDriverExpressionsExpressionExpression2NullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1A2eModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesRequestVariant1A2eModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.TrainClipRequestGenderJsonConverter),

            typeof(global::DId.JsonConverters.TrainClipRequestGenderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderGoogleType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderGoogleType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant1ProviderOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant2Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestScriptVariant2Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestConfigResultFormat2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestConfigResultFormat2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant1Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant1Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant2Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipRequestPresenterConfigCropVariant2Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptTextProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptAudioTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create2RequestScriptAudioTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestBackgroundVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestBackgroundVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestBackgroundVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestBackgroundVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1TypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant1ProviderOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant2TypeJsonConverter),

            typeof(global::DId.JsonConverters.Create3RequestScriptVariant2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TestWebhookConfigurationRequestEventTypeJsonConverter),

            typeof(global::DId.JsonConverters.TestWebhookConfigurationRequestEventTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1ModelJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant1ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2CustomBasicTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2CustomBasicTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2CustomOAuth2TypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant2CustomOAuth2TypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant4TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant4TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant4PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant4PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5ModelJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant5ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6ModelJsonConverter),

            typeof(global::DId.JsonConverters.CreateRequestLlmVariant6ModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateRequestLlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamRequestCompatibilityModeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamRequestCompatibilityModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StartConnectionRequestAnswerTypeJsonConverter),

            typeof(global::DId.JsonConverters.StartConnectionRequestAnswerTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2JsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptTextProviderOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptAudioType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamRequestScriptAudioType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatRequestMessageRoleJsonConverter),

            typeof(global::DId.JsonConverters.ChatRequestMessageRoleNullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatRequestChatModeJsonConverter),

            typeof(global::DId.JsonConverters.ChatRequestChatModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentRequestVariant1DocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentRequestVariant1DocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BasicAuthenticationTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BearerTokenTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1BearerTokenTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1ApiKeyTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestCreateSecretRequest1ApiKeyTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestVariant2OpenAIConfigurationProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestVariant2OpenAIConfigurationProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestVariant2Variant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestVariant2Variant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestVariant2OpenAIConfigurationProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestVariant2OpenAIConfigurationProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestVariant2Variant2ProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretRequestVariant2Variant2ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationRequestFaceOverlapJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationRequestFaceOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationRequestConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationRequestConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamRequestFaceOverlapJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamRequestFaceOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamRequestCompatibilityMode2JsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamRequestCompatibilityMode2NullableJsonConverter),

            typeof(global::DId.JsonConverters.StartConnectionRequestAnswerType2JsonConverter),

            typeof(global::DId.JsonConverters.StartConnectionRequestAnswerType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant2Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestScriptVariant2Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormat2JsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormat2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStream1RequestCompatibilityModeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStream1RequestCompatibilityModeNullableJsonConverter),

            typeof(global::DId.JsonConverters.StartConnection1RequestAnswerTypeJsonConverter),

            typeof(global::DId.JsonConverters.StartConnection1RequestAnswerTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderOpenAIType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderOpenAIType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant2Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestScriptVariant2Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestConfigResultFormat2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestConfigResultFormat2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant1Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant1Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant2Type2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipStreamRequestPresenterConfigCropVariant2Type2NullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsSortByJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsSortByNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsOrderJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsOrderNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoicesProviderJsonConverter),

            typeof(global::DId.JsonConverters.VoicesProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateTalkResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksResponseTalkStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksResponseTalkStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksResponseTalkConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksResponseTalkConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksResponseTalkConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.GetTalksResponseTalkConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkResponseConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkResponseConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkResponseConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.GetTalkResponseConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteTalkResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.DeleteTalkResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteTalkResponseConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.DeleteTalkResponseConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteTalkResponseConfigDriverExpressionsExpressionExpressionJsonConverter),

            typeof(global::DId.JsonConverters.DeleteTalkResponseConfigDriverExpressionsExpressionExpressionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetPresentersResponsePresenterStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetPresenterByIdResponsePresenterStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.TrainClipResponseGenderJsonConverter),

            typeof(global::DId.JsonConverters.TrainClipResponseGenderNullableJsonConverter),

            typeof(global::DId.JsonConverters.TrainClipResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.TrainClipResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseObject2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseObject2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseStatus2JsonConverter),

            typeof(global::DId.JsonConverters.CreateClipResponseStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipConfigResultFormat2JsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipConfigResultFormat2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetClipsResponseClipStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseConfigResultFormat2JsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseConfigResultFormat2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetClipResponseStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteClipResponseConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.DeleteClipResponseConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteClipResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.DeleteClipResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseTranslationStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseTranslationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseTranslationTranscriptionVersionJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseTranslationTranscriptionVersionNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersion2JsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersion2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationTranscriptionVersion2JsonConverter),

            typeof(global::DId.JsonConverters.GetGroupResponseTranslationTranscriptionVersion2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseTranscriptionVersion2JsonConverter),

            typeof(global::DId.JsonConverters.GetTranslationResponseTranscriptionVersion2NullableJsonConverter),

            typeof(global::DId.JsonConverters.Create1ResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.Create1ResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create1ResponseObjectJsonConverter),

            typeof(global::DId.JsonConverters.Create1ResponseObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseAvatarStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseAvatarStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseAvatarObjectJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarsResponseAvatarObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseObjectJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2ResponseObjectJsonConverter),

            typeof(global::DId.JsonConverters.Create2ResponseObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create2ResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.Create2ResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetScenesResponseSceneStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetScenesResponseSceneStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.Get1ResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.Get1ResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1SentimentJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1SentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1SentimentJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1SentimentNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3ResponseVariant1StatusJsonConverter),

            typeof(global::DId.JsonConverters.Create3ResponseVariant1StatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create3ResponseVariant2ObjectJsonConverter),

            typeof(global::DId.JsonConverters.Create3ResponseVariant2ObjectNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressivesResponseExpressiveStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressivesResponseExpressiveStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.Get2ResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.Get2ResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1LlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.CreateResponseVariant1KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1LlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseVariant1KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.UpdateResponseVariant1KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIProviderJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAITemplateJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAITemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIModelJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2TemplateJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3TemplateJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3TemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdProviderJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdTemplateJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdModelJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmDIdModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleProviderJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleTemplateJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleTemplateNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleModelJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1ProviderJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1ProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1KnowledgeProviderJsonConverter),

            typeof(global::DId.JsonConverters.DeleteResponseVariant1KnowledgeProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamResponseJsepTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamResponseJsepTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.ChatResponseChatMode2JsonConverter),

            typeof(global::DId.JsonConverters.ChatResponseChatMode2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetChatLogsResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetChatLogsResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteChatLogsResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.DeleteChatLogsResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.Create1ResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.Create1ResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Get1ResponseItemTypeJsonConverter),

            typeof(global::DId.JsonConverters.Get1ResponseItemTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentResponseDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentResponseDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentsResponseItemDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentsResponseItemDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentsResponseItemTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentsResponseItemTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentsResponseItemStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentsResponseItemStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetByIdResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetByIdResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.Update1ResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.Update1ResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentResponseDocumentTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentResponseDocumentTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetDocumentResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoicesResponseItemAccessJsonConverter),

            typeof(global::DId.JsonConverters.VoicesResponseItemAccessNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoicesResponseItemProviderJsonConverter),

            typeof(global::DId.JsonConverters.VoicesResponseItemProviderNullableJsonConverter),

            typeof(global::DId.JsonConverters.VoicesResponseItemVoiceTypeJsonConverter),

            typeof(global::DId.JsonConverters.VoicesResponseItemVoiceTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UploadAnImageResponseFaceOverlapJsonConverter),

            typeof(global::DId.JsonConverters.UploadAnImageResponseFaceOverlapNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetCreditsResponseCreditProductBillingIntervalJsonConverter),

            typeof(global::DId.JsonConverters.GetCreditsResponseCreditProductBillingIntervalNullableJsonConverter),

            typeof(global::DId.JsonConverters.ListResponseConsentStatusJsonConverter),

            typeof(global::DId.JsonConverters.ListResponseConsentStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetResponseStatus2JsonConverter),

            typeof(global::DId.JsonConverters.GetResponseStatus2NullableJsonConverter),

            typeof(global::DId.JsonConverters.GetSettingsResponseAgentsLlmModelJsonConverter),

            typeof(global::DId.JsonConverters.GetSettingsResponseAgentsLlmModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSettingsResponseAgentsLlmModelJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSettingsResponseAgentsLlmModelNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAllSecretsResponseItemTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetAllSecretsResponseItemTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetSecretByIdResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.GetSecretByIdResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteSecretResponseTypeJsonConverter),

            typeof(global::DId.JsonConverters.DeleteSecretResponseTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.CreateAnimationResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseAnimationStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseAnimationStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseAnimationConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationsResponseAnimationConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.GetAnimationResponseConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteAnimationResponseStatusJsonConverter),

            typeof(global::DId.JsonConverters.DeleteAnimationResponseStatusNullableJsonConverter),

            typeof(global::DId.JsonConverters.DeleteAnimationResponseConfigResultFormatJsonConverter),

            typeof(global::DId.JsonConverters.DeleteAnimationResponseConfigResultFormatNullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamResponseJsepType2JsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamResponseJsepType2NullableJsonConverter),

            typeof(global::DId.JsonConverters.CreateStream1ResponseJsepTypeJsonConverter),

            typeof(global::DId.JsonConverters.CreateStream1ResponseJsepTypeNullableJsonConverter),

            typeof(global::DId.JsonConverters.TextToSpeechProvidersJsonConverter),

            typeof(global::DId.JsonConverters.ScriptJsonConverter),

            typeof(global::DId.JsonConverters.AgentsTextToSpeechProvidersJsonConverter),

            typeof(global::DId.JsonConverters.AgentPresenterJsonConverter),

            typeof(global::DId.JsonConverters.CustomAuthConfigJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigJsonConverter),

            typeof(global::DId.JsonConverters.StreamScriptJsonConverter),

            typeof(global::DId.JsonConverters.UpdatePresenterAttributesJsonConverter),

            typeof(global::DId.JsonConverters.CropJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarDtoJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveAvatarExpressionDtoJsonConverter),

            typeof(global::DId.JsonConverters.GetExpressiveAvatarDtoJsonConverter),

            typeof(global::DId.JsonConverters.CreateExpressiveResponseDtoJsonConverter),

            typeof(global::DId.JsonConverters.ExpressiveVideoBackgroundJsonConverter),

            typeof(global::DId.JsonConverters.JSONValueJsonConverter),

            typeof(global::DId.JsonConverters.ToolResultOutputJsonConverter),

            typeof(global::DId.JsonConverters.TriggerEventDataJsonConverter),

            typeof(global::DId.JsonConverters.AgentResponseDtoJsonConverter),

            typeof(global::DId.JsonConverters.LLMConfigCreateDtoJsonConverter),

            typeof(global::DId.JsonConverters.AssetDtoJsonConverter),

            typeof(global::DId.JsonConverters.PartialAgentPresenterJsonConverter),

            typeof(global::DId.JsonConverters.CreateIceCandidateStreamRequestJsonConverter),

            typeof(global::DId.JsonConverters.CreateVideoStreamResponseJsonConverter),

            typeof(global::DId.JsonConverters.CreateStreamScriptJsonConverter),

            typeof(global::DId.JsonConverters.ExportDtoJsonConverter),

            typeof(global::DId.JsonConverters.CreateDocumentDtoJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretRequestDtoJsonConverter),

            typeof(global::DId.JsonConverters.CreateSecretExternalLLMRequestDtoJsonConverter),

            typeof(global::DId.JsonConverters.UpdateAuthSecretRequestDtoJsonConverter),

            typeof(global::DId.JsonConverters.UpdateSecretExternalLLMRequestDtoJsonConverter),

            typeof(global::DId.JsonConverters.LogoDtoJsonConverter),

            typeof(global::DId.JsonConverters.AnimationErrorJsonConverter),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TextScriptProviderMicrosoft, global::DId.TextScriptProviderElevenLabs, global::DId.TextScriptProviderAmazon, global::DId.TextScriptProviderGoogle, global::DId.TextScriptProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ScriptVariant1ProviderMicrosoft, global::DId.ScriptVariant1ProviderElevenLabs, global::DId.ScriptVariant1ProviderAmazon, global::DId.ScriptVariant1ProviderGoogle, global::DId.ScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1, global::DId.CreateTalkRequestScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TalkAgentPresenterVoiceMicrosoft, global::DId.TalkAgentPresenterVoiceElevenLabs, global::DId.TalkAgentPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipAgentPresenterVoiceMicrosoft, global::DId.ClipAgentPresenterVoiceElevenLabs, global::DId.ClipAgentPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAgentPresenterVoiceMicrosoft, global::DId.ExpressiveAgentPresenterVoiceElevenLabs, global::DId.ExpressiveAgentPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterVideoAvatarVoiceMicrosoft, global::DId.AgentPresenterVideoAvatarVoiceElevenLabs, global::DId.AgentPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterPhotoAvatar2, global::DId.AgentPresenterVideoAvatar2, global::DId.AgentPresenterExpressiveAvatar2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterVideoAvatarVoiceMicrosoft2, global::DId.AgentPresenterVideoAvatarVoiceElevenLabs2, global::DId.AgentPresenterVideoAvatarVoiceOpenAI2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.StreamScriptVariant1ProviderMicrosoft, global::DId.StreamScriptVariant1ProviderElevenLabs, global::DId.StreamScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipPresenterDtoVoiceMicrosoft, global::DId.ClipPresenterDtoVoiceElevenLabs, global::DId.ClipPresenterDtoVoiceAmazon, global::DId.ClipPresenterDtoVoiceGoogle, global::DId.ClipPresenterDtoVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoft, global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabs, global::DId.GetClipsPresentersResponsePresenterVoiceAmazon, global::DId.GetClipsPresentersResponsePresenterVoiceGoogle, global::DId.GetClipsPresentersResponsePresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoft, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabs, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazon, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceGoogle, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipPresenterConfigCropVariant1, global::DId.ClipPresenterConfigCropVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1, global::DId.CreateClipRequestScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipRequestScriptVariant1ProviderAmazon, global::DId.CreateClipRequestScriptVariant1ProviderGoogle, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ClipStreamConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSceneRequestDtoScriptText, global::DId.CreateSceneRequestDtoScriptAudio>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft, global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs, global::DId.CreateSceneRequestDtoScriptTextProviderAmazon, global::DId.CreateSceneRequestDtoScriptTextProviderGoogle, global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ExpressiveVideoConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.TextScript3ProviderMicrosoft, global::DId.TextScript3ProviderElevenLabs, global::DId.TextScript3ProviderAmazon, global::DId.TextScript3ProviderGoogle, global::DId.TextScript3ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoft, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabs, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazon, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderGoogle, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateExpressiveRequestDtoConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateExpressiveRequestDtoBackgroundVariant1, global::DId.CreateExpressiveRequestDtoBackgroundVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabs, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazon, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderGoogle, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar, global::DId.AgentResponseDtoVariant1PresenterVideoAvatar, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentResponseDtoVariant1LlmOpenAI, global::DId.AgentResponseDtoVariant1LlmVariant2, global::DId.AgentResponseDtoVariant1LlmVariant3, global::DId.AgentResponseDtoVariant1LlmDId, global::DId.AgentResponseDtoVariant1LlmGoogle>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CustomLLMCreateDtoCustomBasic, global::DId.CustomLLMCreateDtoCustomOAuth2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.LLMConfigCreateDtoVariant2CustomBasic, global::DId.LLMConfigCreateDtoVariant2CustomOAuth2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoLlmVariant1, global::DId.AgentCreateDtoLlmVariant2, global::DId.AgentCreateDtoLlmVariant3, global::DId.AgentCreateDtoLlmVariant4, global::DId.AgentCreateDtoLlmVariant5, global::DId.AgentCreateDtoLlmVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialTalkAgentPresenterVoiceMicrosoft, global::DId.PartialTalkAgentPresenterVoiceElevenLabs, global::DId.PartialTalkAgentPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentTalkPresenterVoiceMicrosoft, global::DId.PartialAgentTalkPresenterVoiceElevenLabs, global::DId.PartialAgentTalkPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentClipPresenterVoiceMicrosoft, global::DId.PartialAgentClipPresenterVoiceElevenLabs, global::DId.PartialAgentClipPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentUpdateDtoPresenterPhotoAvatar, global::DId.AgentUpdateDtoPresenterVideoAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft, global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs, global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AgentUpdateDtoLlmOpenAI, global::DId.AgentUpdateDtoLlmVariant2, global::DId.AgentUpdateDtoLlmVariant3, global::DId.AgentUpdateDtoLlmDId, global::DId.AgentUpdateDtoLlmGoogle>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateIceCandidateStreamRequestVariant1Variant1, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateStreamTextScriptProviderMicrosoft, global::DId.CreateStreamTextScriptProviderElevenLabs, global::DId.CreateStreamTextScriptProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateStreamScriptTextProviderMicrosoft, global::DId.CreateStreamScriptTextProviderElevenLabs, global::DId.CreateStreamScriptTextProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptText, global::DId.CreateVideoStreamRequestScriptAudio>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AnimateConfigDtoLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateAnimationDtoConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseDtoErrorVariant1, global::DId.GetAnimationResponseDtoErrorVariant2, global::DId.GetAnimationResponseDtoErrorVariant3, global::DId.GetAnimationResponseDtoErrorVariant4, global::DId.GetAnimationResponseDtoErrorVariant5, global::DId.GetAnimationResponseDtoErrorVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseDtoConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseDtoAnimationErrorVariant1, global::DId.GetAnimationsResponseDtoAnimationErrorVariant2, global::DId.GetAnimationsResponseDtoAnimationErrorVariant3, global::DId.GetAnimationsResponseDtoAnimationErrorVariant4, global::DId.GetAnimationsResponseDtoAnimationErrorVariant5, global::DId.GetAnimationsResponseDtoAnimationErrorVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseDtoAnimationConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkStreamRequestScriptVariant1, global::DId.CreateTalkStreamRequestScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateTalkStreamRequestConfigVariant1, global::DId.CreateTalkStreamRequestConfigVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestScriptVariant1, global::DId.CreateClipStreamRequestScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestPresenterConfigCropVariant1, global::DId.CreateClipStreamRequestPresenterConfigCropVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant12, global::DId.CreateTalkRequestScriptVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.UpdatePresenterAttributesRequestVariant1, global::DId.UpdatePresenterAttributesRequestVariant2, global::DId.UpdatePresenterAttributesRequestVariant3>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant12, global::DId.CreateClipRequestScriptVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipRequestScriptVariant1ProviderAmazon2, global::DId.CreateClipRequestScriptVariant1ProviderGoogle2, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipRequestPresenterConfigCropVariant12, global::DId.CreateClipRequestPresenterConfigCropVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestBackgroundVariant1, global::DId.Create3RequestBackgroundVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestScriptVariant1, global::DId.Create3RequestScriptVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AddIceCandidateRequestVariant12, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptText2, global::DId.CreateVideoStreamRequestScriptAudio2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateAnimationRequestConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AddIceCandidateRequestVariant14, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkStreamRequestScriptVariant12, global::DId.CreateTalkStreamRequestScriptVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI2>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateTalkStreamRequestConfigVariant12, global::DId.CreateTalkStreamRequestConfigVariant22>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.AddIceCandidate1RequestVariant12, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestScriptVariant12, global::DId.CreateClipStreamRequestScriptVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestConfigLogo2, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateClipStreamRequestPresenterConfigCropVariant12, global::DId.CreateClipStreamRequestPresenterConfigCropVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetPresentersResponsePresenterVoiceMicrosoft, global::DId.GetPresentersResponsePresenterVoiceElevenLabs, global::DId.GetPresentersResponsePresenterVoiceAmazon, global::DId.GetPresentersResponsePresenterVoiceGoogle, global::DId.GetPresentersResponsePresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft, global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs, global::DId.GetPresenterByIdResponsePresenterVoiceAmazon, global::DId.GetPresenterByIdResponsePresenterVoiceGoogle, global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatars1ResponseAvatarVariant1, object>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatarByIdResponseVariant12, object>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1, object>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.Create3ResponseVariant1, global::DId.Create3ResponseVariant2>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateResponseVariant1, global::DId.CreateResponseVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseAnimationErrorVariant1, global::DId.GetAnimationsResponseAnimationErrorVariant2, global::DId.GetAnimationsResponseAnimationErrorVariant3, global::DId.GetAnimationsResponseAnimationErrorVariant4, global::DId.GetAnimationsResponseAnimationErrorVariant5, global::DId.GetAnimationsResponseAnimationErrorVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationsResponseAnimationConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseErrorVariant1, global::DId.GetAnimationResponseErrorVariant2, global::DId.GetAnimationResponseErrorVariant3, global::DId.GetAnimationResponseErrorVariant4, global::DId.GetAnimationResponseErrorVariant5, global::DId.GetAnimationResponseErrorVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetAnimationResponseConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteAnimationResponseErrorVariant1, global::DId.DeleteAnimationResponseErrorVariant2, global::DId.DeleteAnimationResponseErrorVariant3, global::DId.DeleteAnimationResponseErrorVariant4, global::DId.DeleteAnimationResponseErrorVariant5, global::DId.DeleteAnimationResponseErrorVariant6>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteAnimationResponseConfigLogo, bool?>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::DId.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JsonError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ProvidersMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoiceConfigMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.MicrosoftTtsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.MicrosoftTtsProviderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.MicrosoftTtsProviderVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ProvidersElevenlabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoiceConfigElevenlabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsTtsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsTtsProviderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsTtsProviderVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ProvidersAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoiceIdsAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AmazonTtsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AmazonTtsProviderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AmazonTtsProviderVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ProvidersGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleTtsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleTtsProviderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ProvidersAzureOpenAi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAiTtsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAiTtsProviderVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAiTtsProviderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProviders))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextToSpeechProvidersOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.TextScriptProviderMicrosoft, global::DId.TextScriptProviderElevenLabs, global::DId.TextScriptProviderAmazon, global::DId.TextScriptProviderGoogle, global::DId.TextScriptProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScriptProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AudioScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AudioScriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Script))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ScriptVariant1ProviderMicrosoft, global::DId.ScriptVariant1ProviderElevenLabs, global::DId.ScriptVariant1ProviderAmazon, global::DId.ScriptVariant1ProviderGoogle, global::DId.ScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Logo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Expression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TimedExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TimedExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ExpressionConfigExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressionConfigExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressionConfigExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalksConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalksConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalksConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalksConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.TalksConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalksConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalksConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OverlapKind))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Rect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceSquareDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceSquareDtoOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceSquareDtoDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1, global::DId.CreateTalkRequestScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateTalkRequestConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTalkDtoConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkDtoConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTalksDtoTalk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTalksDtoTalkConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OfferJsep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OfferJsepType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::System.Collections.Generic.IList<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoiceAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsStreamTtsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsStreamTtsProviderType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsStreamTtsProviderVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ElevenlabsStreamTtsProviderAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProviders))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsTextToSpeechProvidersOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.TalkAgentPresenterVoiceMicrosoft, global::DId.TalkAgentPresenterVoiceElevenLabs, global::DId.TalkAgentPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TalkAgentPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PresenterBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ClipAgentPresenterVoiceMicrosoft, global::DId.ClipAgentPresenterVoiceElevenLabs, global::DId.ClipAgentPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAgentPresenterBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionIdOrSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionIdOrSentimentSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentSentimentSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ExpressiveAgentPresenterVoiceMicrosoft, global::DId.ExpressiveAgentPresenterVoiceElevenLabs, global::DId.ExpressiveAgentPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAgentPresenterBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterVideoAvatarVoiceMicrosoft, global::DId.AgentPresenterVideoAvatarVoiceElevenLabs, global::DId.AgentPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomBasicKeyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomBasicKeyConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthOauth2Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthOauth2ConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthConfigBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthConfigBasicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthConfigOAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomAuthConfigOAuth2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMModel2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMModel2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EmbeddingProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EmbeddingTrim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeEmbedder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeEmbedderProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeEmbedderTrim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeProvider2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUseCase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Auth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.WebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.WebhookConfigAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolChoiceStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventTriggerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.EventTriggerConfigWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventTriggerConfigWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventTriggerConfigWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AgentTriggersConfigChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentAdvancedSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloudProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetCloudProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterPhotoAvatar2, global::DId.AgentPresenterVideoAvatar2, global::DId.AgentPresenterExpressiveAvatar2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatar2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2, global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2, global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterPhotoAvatarVoiceOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatar2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterVideoAvatarVoiceMicrosoft2, global::DId.AgentPresenterVideoAvatarVoiceElevenLabs2, global::DId.AgentPresenterVideoAvatarVoiceOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceElevenLabsAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarVoiceOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterVideoAvatarBackground2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatar2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarVoiceOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentPresenterExpressiveAvatarBackground2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentLlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentKnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AgentTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnswerJsep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnswerJsepType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IceCandidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamTextScriptProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamAudioScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamAudioScriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.MessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OptionsInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OptionsInterfaceCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.StreamScriptVariant1ProviderMicrosoft, global::DId.StreamScriptVariant1ProviderElevenLabs, global::DId.StreamScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StreamScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitTalksConfigLogoOrDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitTalksConfigLogoOrDriverExpressionsResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeprecatedTalksConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StickyStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.A2eModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ClipPresenterDtoVoiceMicrosoft, global::DId.ClipPresenterDtoVoiceElevenLabs, global::DId.ClipPresenterDtoVoiceAmazon, global::DId.ClipPresenterDtoVoiceGoogle, global::DId.ClipPresenterDtoVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterDtoFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetClipsPresentersResponsePresenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoft, global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabs, global::DId.GetClipsPresentersResponsePresenterVoiceAmazon, global::DId.GetClipsPresentersResponsePresenterVoiceGoogle, global::DId.GetClipsPresentersResponsePresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsPresentersResponsePresenterFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoft, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabs, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazon, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceGoogle, global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtA2eModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialOmitPresenterOwnerIdOrPresenterIdOrCreatedAtOrCreatedByOrCreatedByCreatedAtOrCreatedByModifiedAtOrEntityCreatedAtFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1A2eModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant1FaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipDriverDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsDriversResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetClipsDriversResponseClipsDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsDriversResponseClipsDriver))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipAvatarStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GreenscreenConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipTrainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipTrainRequestGender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipTrainRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Providers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.WideCrop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.WideCropType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.RectangleCrop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.RectangleCropType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.RectangleCropRectangle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Crop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CropVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CropVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CropVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CropVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CropVariant2Rectangle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ClipPresenterConfigCropVariant1, global::DId.ClipPresenterConfigCropVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterConfigCropVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterConfigCropVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterConfigCropVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterConfigCropVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipPresenterConfigCropVariant2Rectangle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<string, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1, global::DId.CreateClipRequestScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipRequestScriptVariant1ProviderAmazon, global::DId.CreateClipRequestScriptVariant1ProviderGoogle, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant2Rectangle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetClipsResponseClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolutionBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitStreamVideoConfigResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitStreamVideoConfigResolutionBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipStreamConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ClipStreamConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipStreamConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClipStreamConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TranslationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Transcription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TranscriptionVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationResponseTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTranslationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateTranslationResponseDtoTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTranslationResponseDtoTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTranslationResponseDtoTranslationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateTranslationResponseDtoTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTranslationResponseDtoTranslationTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTranslationResponseDtoTranslationTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTranslationRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GroupStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GroupTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GroupTranslationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GroupTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GroupTranslationTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GroupTranslationTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickGetGroupResponseName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialPickGetTranslationResponseName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Caption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SceneAvatarStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAvatarResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAvatarResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAvatarResponseDtoObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAvatarRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDtoObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDtoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDtoFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDtoCreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarResponseDtoCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarResponseDtoCreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SceneAvatarStatusDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDraftAvatarRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseDtoAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatarStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatarObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatarError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatarFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatarCreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseDtoAvatarCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseDtoAvatarCreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SceneStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneResponseDtoObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SceneConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SceneConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SceneBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSceneRequestDtoScriptText, global::DId.CreateSceneRequestDtoScriptAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft, global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs, global::DId.CreateSceneRequestDtoScriptTextProviderAmazon, global::DId.CreateSceneRequestDtoScriptTextProviderGoogle, global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptTextProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoScriptAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSceneRequestDtoBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSceneResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSceneResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSceneResponseDtoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSceneResponseDtoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSceneResponseDtoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetScenesResponseDtoScene>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseDtoScene))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseDtoSceneStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseDtoSceneConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseDtoSceneConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseDtoSceneError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarAvatarPublicAllowedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarPublicDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle, global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoSentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle, global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant1Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle, global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainingStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PostTrainingResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PostTrainingResponseItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SentimentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SentimentConfigVoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.RecordStringSentimentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PostTrainingRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PostTrainingRequestItemSentiments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveVideoIdOrStatusOrCreatedAt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveVideoIdOrStatusOrCreatedAtStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveResponseDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveResponseDtoVariant1Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveResponseDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveResponseDtoVariant2Object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ExpressiveVideoConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ColorBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ColorBackgroundType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveImageBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveImageBackgroundType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoBackgroundVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoBackgroundVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoBackgroundVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveVideoBackgroundVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExpressiveInferenceMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InternalCallConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InternalCallConfigInferenceMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.TextScript3ProviderMicrosoft, global::DId.TextScript3ProviderElevenLabs, global::DId.TextScript3ProviderAmazon, global::DId.TextScript3ProviderGoogle, global::DId.TextScript3ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TextScript3ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AudioScript3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AudioScript3Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptBackgroundVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoft, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabs, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazon, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderGoogle, global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FlattenPickExpressiveVideoAvatarIdOrSentimentIdOrNameOrConfigOrBackgroundOrUserDataOrPersistOrResultUrlOrWebhookOrInternalCallConfigAndScriptScriptScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoBackgroundVariant1, global::DId.CreateExpressiveRequestDtoBackgroundVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoBackgroundVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoBackgroundVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoBackgroundVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoBackgroundVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabs, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazon, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderGoogle, global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateExpressiveRequestDtoScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveVideoExpressivePublicAllowedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveVideoExpressivePublicAllowedAttributesStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickExpressiveVideoExpressivePublicAllowedAttributesError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressiveResponseDtoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseDtoExpressive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseDtoExpressive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseDtoExpressiveStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseDtoExpressiveError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ClientKeyResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResourceClientKeyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResourceClientKeyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventTypeChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.MessageRole2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JSONValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.JSONValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DId.JSONValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UserPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Insights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.IMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatEndEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatEndEventDataEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventTypeChatStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatStartEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatStartEventDataEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventDataVariant2EventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookRequestDtoEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookRequestDtoAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetResponseDtoModerationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentAdvancedSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentAdvancedSettingsResponseDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar, global::DId.AgentResponseDtoVariant1PresenterVideoAvatar, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentResponseDtoVariant1LlmOpenAI, global::DId.AgentResponseDtoVariant1LlmVariant2, global::DId.AgentResponseDtoVariant1LlmVariant3, global::DId.AgentResponseDtoVariant1LlmDId, global::DId.AgentResponseDtoVariant1LlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1LlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AgentResponseDtoVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentResponseDtoVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMCreateDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMCreateDtoTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMCreateDtoPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMCreateDtoPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAILLMCreateDtoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CustomLLMCreateDtoCustomBasic, global::DId.CustomLLMCreateDtoCustomOAuth2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoCustomBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoCustomBasicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoCustomOAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CustomLLMCreateDtoCustomOAuth2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMCreateDtoTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMCreateDtoPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMCreateDtoTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMCreateDtoPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AzureOpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMCreateDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMCreateDtoTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMCreateDtoPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMCreateDtoPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DIdLLMCreateDtoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMCreateDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMCreateDtoTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMCreateDtoPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMCreateDtoPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GoogleLLMCreateDtoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant1Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant1PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant1PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant1Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.LLMConfigCreateDtoVariant2CustomBasic, global::DId.LLMConfigCreateDtoVariant2CustomOAuth2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2CustomBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2CustomBasicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2CustomOAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant2CustomOAuth2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant4Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant4PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant5Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant5Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant5PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant5Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant6Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant6Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant6PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant6PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LLMConfigCreateDtoVariant6Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickKnowledgeId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.WebhookConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.WebhookConfigDtoAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventTriggerConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.EventTriggerConfigDtoWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventTriggerConfigDtoWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.EventTriggerConfigDtoWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigDtoChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AgentTriggersConfigDtoChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigDtoChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentTriggersConfigDtoChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetMimeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetCreateDtoMimeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetUpdateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetUpdateDtoMimeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetDtoVariant1MimeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AssetDtoVariant2MimeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs, global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoPresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentCreateDtoLlmVariant1, global::DId.AgentCreateDtoLlmVariant2, global::DId.AgentCreateDtoLlmVariant3, global::DId.AgentCreateDtoLlmVariant4, global::DId.AgentCreateDtoLlmVariant5, global::DId.AgentCreateDtoLlmVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant1Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant1PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant1PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant1Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2CustomBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2CustomBasicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2CustomOAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant2CustomOAuth2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant4Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant4PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant5Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant5Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant5PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant5Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant6Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant6Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant6PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant6PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoLlmVariant6Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AgentCreateDtoTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentCreateDtoTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialTalkAgentPresenterVoiceMicrosoft, global::DId.PartialTalkAgentPresenterVoiceElevenLabs, global::DId.PartialTalkAgentPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialTalkAgentPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialAgentTalkPresenterVoiceMicrosoft, global::DId.PartialAgentTalkPresenterVoiceElevenLabs, global::DId.PartialAgentTalkPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentTalkPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialClipAgentPresenterVoiceMicrosoft, global::DId.PartialClipAgentPresenterVoiceElevenLabs, global::DId.PartialClipAgentPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialClipAgentPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialAgentClipPresenterVoiceMicrosoft, global::DId.PartialAgentClipPresenterVoiceElevenLabs, global::DId.PartialAgentClipPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentClipPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft, global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs, global::DId.PartialExpressiveAgentPresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialExpressiveAgentPresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentUpdateDtoPresenterPhotoAvatar, global::DId.AgentUpdateDtoPresenterVideoAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft, global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs, global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft, global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs, global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AgentUpdateDtoLlmOpenAI, global::DId.AgentUpdateDtoLlmVariant2, global::DId.AgentUpdateDtoLlmVariant3, global::DId.AgentUpdateDtoLlmDId, global::DId.AgentUpdateDtoLlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoLlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AgentUpdateDtoTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentUpdateDtoTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalRating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitRatingPayloadAgentIdOrChatId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialRatingPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitStreamResponseJsep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitStreamResponseJsepType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.InitStreamResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitStreamResponseIceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitVideoStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitVideoStreamRequestCompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStartStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStartStreamRequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStartStreamRequestAnswerType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateIceCandidateStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateIceCandidateStreamRequestVariant1Variant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateIceCandidateStreamRequestVariant1Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateIceCandidateStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateStreamTextScriptProviderMicrosoft, global::DId.CreateStreamTextScriptProviderElevenLabs, global::DId.CreateStreamTextScriptProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamTextScriptProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamAudioScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamAudioScriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateStreamScriptTextProviderMicrosoft, global::DId.CreateStreamScriptTextProviderElevenLabs, global::DId.CreateStreamScriptTextProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptTextProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamScriptAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnifiedCreateVideoStreamRequestScriptAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptText, global::DId.CreateVideoStreamRequestScriptAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IRetrivalMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ChatResponseMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponseMatche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponseChatMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IChatPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.IChatPayloadMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IChatPayloadMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IChatPayloadMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IChatPayloadChatMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TransportProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TransportProviderLiveKit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitLiveKitRoomTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitLiveKitRoomTransportProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitSessionTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitSessionTransportProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JoinLiveKitRoomTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JoinLiveKitRoomTransportProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JoinLivekitRoomRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JoinLivekitRoomRequestAudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JoinLivekitRoomRequestTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JoinLivekitRoomRequestTransportProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionAgentDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OutcomeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionInsightsDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionInsightsDtoOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionSummaryDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionSummaryDtoAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionSummaryDtoInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionSummaryDtoInsightsOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SessionParticipantDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportWithId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportWithIdStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExportWithIdResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalKnowledgeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitKnowledgeDataCreatedByOrTypeOrStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.KnowledgeCreateDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Subject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalDocumentDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalDocumentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SupportedDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickDocumentDataExcludeKeyofDocumentDataCreatedByOrParsedUrlOrStatusOrTypeOrErrorOrDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitDocumentDataCreatedByOrParsedUrlOrStatusOrTypeOrErrorOrDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentDtoVariant1DocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PartialKnowledgeDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DocumentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DocumentPayloadDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IKnowledgeMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IKnowledgeMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.OmitIPineconeQueryConfigNamespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.MemoryItemDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.PutMemoryItemDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IVoiceAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.IVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IVoiceVoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceSquare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceSquareOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceSquareDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadImageResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UploadImageResponseDtoFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadImageResponseDtoFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadImageResponseDtoFaceOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadImageResponseDtoFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JsonError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ImageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceDetectionDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.FaceDetectionDtoFaceCrop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceDetectionDtoFaceCrop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceDetectionDtoMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAudioResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAudioResponseDtoModerationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JsonError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreditsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreditsItemProductBillingInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UserCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UserCreditsCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UserCreditsCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UserCreditsCreditProductBillingInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JsonError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreditsUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateConsentResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateConsentRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadVideoResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadConsentRequestBodyDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ConsentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseDtoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ListResponseDtoConsent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseDtoConsent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseDtoConsentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseDtoConsentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JsonError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AgentsSettingsLlmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AvatarsSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Settings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SettingsLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SettingsAgents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SettingsAgentsLlmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SettingsAvatars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExternalSettingsRequestDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ExternalSettingsRequestDTOLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SecretAuthType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SanitizedSecretDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SanitizedSecretDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SecretAuthTypeBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateBasicAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateBasicAuthSecretRequestDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SecretAuthTypeBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateBearerAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateBearerAuthSecretRequestDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SecretAuthTypeApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateApiKeyAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateApiKeyAuthSecretRequestDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDtoBasicAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDtoBasicAuthenticationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDtoBearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDtoBearerTokenType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDtoApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestDtoApiKeyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretOpenAIRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretOpenAIRequestDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretAzureOpenAIRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretAzureOpenAIRequestDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretExternalLLMRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretExternalLLMRequestDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretExternalLLMRequestDtoVariant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateBasicAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateBasicAuthSecretRequestDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateBearerAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateBearerAuthSecretRequestDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateApiKeyAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateApiKeyAuthSecretRequestDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDtoBasicAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDtoBasicAuthenticationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDtoBearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDtoBearerTokenType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDtoApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateAuthSecretRequestDtoApiKeyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretOpenAIRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretOpenAIRequestDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretAzureOpenAIRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretAzureOpenAIRequestDtoProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretExternalLLMRequestDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretExternalLLMRequestDtoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretExternalLLMRequestDtoVariant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LogoDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LogoDtoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimateConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnimateConfigDtoLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimateConfigDtoLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimateConfigDtoResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDtoFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDtoFaceOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDtoFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDtoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateAnimationDtoConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDtoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationDtoConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DriverError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.LogoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.SourceError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.FaceError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VideoEnhanceError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UnknownError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnimationErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationResponseDtoErrorVariant1, global::DId.GetAnimationResponseDtoErrorVariant2, global::DId.GetAnimationResponseDtoErrorVariant3, global::DId.GetAnimationResponseDtoErrorVariant4, global::DId.GetAnimationResponseDtoErrorVariant5, global::DId.GetAnimationResponseDtoErrorVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationResponseDtoConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseDtoConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAnimationsResponseDtoAnimation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseDtoAnimationErrorVariant1, global::DId.GetAnimationsResponseDtoAnimationErrorVariant2, global::DId.GetAnimationsResponseDtoAnimationErrorVariant3, global::DId.GetAnimationsResponseDtoAnimationErrorVariant4, global::DId.GetAnimationsResponseDtoAnimationErrorVariant5, global::DId.GetAnimationsResponseDtoAnimationErrorVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseDtoAnimationConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseDtoAnimationConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitTalkStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitTalkStreamRequestFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitTalkStreamRequestFaceOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitTalkStreamRequestFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitTalkStreamRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitTalkStreamRequestCompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant1, global::DId.CreateTalkStreamRequestScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateTalkStreamRequestConfigVariant1, global::DId.CreateTalkStreamRequestConfigVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitClipStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.InitClipStreamRequestCompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant1, global::DId.CreateClipStreamRequestScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft, global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs, global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestPresenterConfigCropVariant1, global::DId.CreateClipStreamRequestPresenterConfigCropVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant2Rectangle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant12, global::DId.CreateTalkRequestScriptVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2, global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2, global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderAmazon2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderAmazonType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderGoogle2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant1ProviderOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestScriptVariant2Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigLogo2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigResultFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigDriverExpressions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateTalkRequestConfigDriverExpressionsExpression2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigDriverExpressionsExpression2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkRequestConfigDriverExpressionsExpressionExpression2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.UpdatePresenterAttributesRequestVariant1, global::DId.UpdatePresenterAttributesRequestVariant2, global::DId.UpdatePresenterAttributesRequestVariant3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft, global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs, global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon, global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle, global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1A2eModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant1FaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesRequestVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipRequestGender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant12, global::DId.CreateClipRequestScriptVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipRequestScriptVariant1ProviderAmazon2, global::DId.CreateClipRequestScriptVariant1ProviderGoogle2, global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderAmazon2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderAmazonType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderGoogle2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderGoogleType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant1ProviderOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestScriptVariant2Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestConfigLogo2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestConfigResultFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipRequestPresenterConfigCropVariant12, global::DId.CreateClipRequestPresenterConfigCropVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant1Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant2Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestPresenterConfigCropVariant2Rectangle2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipRequestBackground2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create2RequestScriptTextProviderMicrosoft, global::DId.Create2RequestScriptTextProviderElevenLabs, global::DId.Create2RequestScriptTextProviderAmazon, global::DId.Create2RequestScriptTextProviderGoogle, global::DId.Create2RequestScriptTextProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptTextProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestScriptAudioType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2RequestBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestBackgroundVariant1, global::DId.Create3RequestBackgroundVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestBackgroundVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1, global::DId.Create3RequestScriptVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.Create3RequestScriptVariant1ProviderMicrosoft, global::DId.Create3RequestScriptVariant1ProviderElevenLabs, global::DId.Create3RequestScriptVariant1ProviderAmazon, global::DId.Create3RequestScriptVariant1ProviderGoogle, global::DId.Create3RequestScriptVariant1ProviderOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant1ProviderOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3RequestScriptVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClientKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateClientKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResourceClientKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResourceClientKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequestEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequestAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomBasicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UpdateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRatingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRatingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestCompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswerType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateRequestVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptText2, global::DId.CreateVideoStreamRequestScriptAudio2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptText2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2, global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2, global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateVideoStreamRequestScriptAudioType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatRequestChatMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatLogsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatLogsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Request2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant1DocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateLogoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsRequestLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::DId.CreateSecretRequestCreateSecretRequest1BearerToken, global::DId.CreateSecretRequestCreateSecretRequest1ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2OpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretRequestVariant2Variant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretRequestVariant2Variant2Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequestFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequestFaceOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequestFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateAnimationRequestConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequestConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationRequestConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestFaceOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamRequestCompatibilityMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswer2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionRequestAnswerType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateRequestVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant12, global::DId.CreateTalkStreamRequestScriptVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestScriptVariant2Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateTalkStreamRequestConfigVariant12, global::DId.CreateTalkStreamRequestConfigVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestConfigVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamRequestConfigVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1RequestCompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnection1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnection1RequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnection1RequestAnswerType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidate1RequestVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidate1Request2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant12, global::DId.CreateClipStreamRequestScriptVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft2, global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs2, global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAIVoiceConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAIType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestScriptVariant2Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestConfigLogo2, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestConfigLogo2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestConfigResultFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateClipStreamRequestPresenterConfigCropVariant12, global::DId.CreateClipStreamRequestPresenterConfigCropVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant1Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant2Type2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestPresenterConfigCropVariant2Rectangle2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamRequestBackground2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStream1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTalksResponseTalk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTalksResponseTalkConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponseTalkConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTalkResponseConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponseConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTalkResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseConfigDriverExpressions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.DeleteTalkResponseConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseConfigDriverExpressionsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponseConfigDriverExpressionsExpressionExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteTalkResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetPresentersResponsePresenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetPresentersResponsePresenterVoiceMicrosoft, global::DId.GetPresentersResponsePresenterVoiceElevenLabs, global::DId.GetPresentersResponsePresenterVoiceAmazon, global::DId.GetPresentersResponsePresenterVoiceGoogle, global::DId.GetPresentersResponsePresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresentersResponsePresenterFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetPresenterByIdResponsePresenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft, global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs, global::DId.GetPresenterByIdResponsePresenterVoiceAmazon, global::DId.GetPresenterByIdResponsePresenterVoiceGoogle, global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterByIdResponsePresenterFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdatePresenterAttributesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeletePresenterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeletePresenterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterDriversByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetPresenterDriversByIdResponseClipsDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetPresenterDriversByIdResponseClipsDriver))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipResponseGender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TrainClipResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponseObject2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetClipsResponseClip2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClip2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipConfigLogo2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipConfigResultFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponseClipStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseConfigLogo2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseConfigResultFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClipResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponseConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteClipResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseTranslationTranscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscription2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponseTranslationTranscriptionVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscription2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponseTranslationTranscriptionVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetGroupResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetTranslationResponseTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscription2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponseTranscriptionVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetTranslationResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarCreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseFaceRect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseCreationNotes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetResponseCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseCreationNotesWorkerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetScenesResponseScene>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseScene))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetScenesResponseSceneError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle, global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle, global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.Create3ResponseVariant1, global::DId.Create3ResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant1Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3ResponseVariant2Object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create3Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseExpressive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressiveStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetExpressivesResponseExpressiveError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClientKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClientKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetClientKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClientKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClientKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResourceClientKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResourceClientKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResourceClientKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResourceClientKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ListResourceClientKeysResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResourceClientKeysResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResourceClientKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResourceClientKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResourceClientKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResourceClientKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateResponseVariant1, global::DId.CreateResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteChatsDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UpdateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1KnowledgeProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.DeleteResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRatingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRatingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRatingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRatingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteRatingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteRatingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsepType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateStreamResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseIceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateVideoStreamResponseVariant12, global::DId.CreateVideoStreamResponseVariant22>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponseChatMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatLogsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatLogsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateChatLogsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetChatLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetChatLogsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetChatLogsResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetChatLogsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetChatLogsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteChatLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteChatLogsResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteChatLogsResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteChatLogsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteChatLogsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1ResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Create1Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.Get1ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1ResponseItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Get1Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateDocumentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetDocumentsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponseItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1ResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Update1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetDocumentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.DeleteDocumentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteDocumentResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.VoicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.VoicesResponseItemLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponseItemVoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.VoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CloneVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UploadAnImageResponseFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponseFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponseFaceOverlap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponseFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetFaceDetectionResponseFaceCrop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponseFaceCrop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetFaceDetectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponseModerationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadAnAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetCreditsResponseCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetCreditsResponseCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetCreditsResponseCreditProductBillingInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetCreditsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ListResponseConsent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseConsent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseConsentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponseConsentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UploadVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.Delete1Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetLogoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetLogoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateLogoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateLogoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateLogoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteLogoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSettingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSettingsResponseLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSettingsResponseAgents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSettingsResponseAgentsLlmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSettingsResponseAvatars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSettingsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsResponseLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsResponseAgents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsResponseAgentsLlmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsResponseAvatars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSettingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateSecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAllSecretsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAllSecretsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAllSecretsResponseItemType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetSecretByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateSecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteSecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateAnimationResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetAnimationsResponseAnimation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseAnimationErrorVariant1, global::DId.GetAnimationsResponseAnimationErrorVariant2, global::DId.GetAnimationsResponseAnimationErrorVariant3, global::DId.GetAnimationsResponseAnimationErrorVariant4, global::DId.GetAnimationsResponseAnimationErrorVariant5, global::DId.GetAnimationsResponseAnimationErrorVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationsResponseAnimationConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponseAnimationConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationResponseErrorVariant1, global::DId.GetAnimationResponseErrorVariant2, global::DId.GetAnimationResponseErrorVariant3, global::DId.GetAnimationResponseErrorVariant4, global::DId.GetAnimationResponseErrorVariant5, global::DId.GetAnimationResponseErrorVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetAnimationResponseConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponseConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetAnimationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteAnimationResponseErrorVariant1, global::DId.DeleteAnimationResponseErrorVariant2, global::DId.DeleteAnimationResponseErrorVariant3, global::DId.DeleteAnimationResponseErrorVariant4, global::DId.DeleteAnimationResponseErrorVariant5, global::DId.DeleteAnimationResponseErrorVariant6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteAnimationResponseConfigLogo, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseConfigLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponseConfigResultFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteAnimationResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsep2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseJsepType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateStreamResponseIceServer2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponseIceServer2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStreamResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidateResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateTalkStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStreamResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1ResponseJsep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1ResponseJsepType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateStream1ResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1ResponseIceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateStream1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnection1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnection1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.StartConnection1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidate1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidate1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AddIceCandidate1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateClipStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStream1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStream1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStream1Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteStream1Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ExpressionConfigExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.TalksConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateTalkRequestConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTalkDtoConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTalksDtoTalk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTalksDtoTalkConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.EventTriggerConfigWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AgentTriggersConfigChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AgentTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetClipsPresentersResponsePresenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetClipsDriversResponseClipsDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetClipsResponseClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationResponseTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateTranslationResponseDtoTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateTranslationResponseDtoTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GroupTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarResponseDtoCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarsResponseDtoAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarsResponseDtoAvatarCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetScenesResponseDtoScene>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetExpressivesResponseDtoExpressive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.JSONValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.IMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AgentResponseDtoVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.EventTriggerConfigDtoWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AgentTriggersConfigDtoChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AgentCreateDtoTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AgentUpdateDtoTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.InitStreamResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ChatResponseMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.IChatPayloadMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.IVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UploadImageResponseDtoFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.FaceDetectionDtoFaceCrop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UserCreditsCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ListResponseDtoConsent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAnimationsResponseDtoAnimation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateTalkRequestConfigDriverExpressionsExpression2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UpdateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTalksResponseTalk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTalksResponseTalkConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTalkResponseConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.DeleteTalkResponseConfigDriverExpressionsExpression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetPresentersResponsePresenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetPresenterByIdResponsePresenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetPresenterDriversByIdResponseClipsDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetClipsResponseClip2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateResponseTranslationTranscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslationTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetTranslationResponseTranscription2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarsResponseAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetResponseCreationNotesWorkerError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetScenesResponseScene>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetExpressivesResponseExpressive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ListResourceClientKeysResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UpdateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.DeleteResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateStreamResponseIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ChatResponseMatche2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.Get1ResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetDocumentsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.DeleteDocumentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.VoicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.VoicesResponseItemLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UploadAnImageResponseFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetFaceDetectionResponseFaceCrop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetCreditsResponseCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ListResponseConsent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAllSecretsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetAnimationsResponseAnimation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateStreamResponseIceServer2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateStream1ResponseIceServer>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}