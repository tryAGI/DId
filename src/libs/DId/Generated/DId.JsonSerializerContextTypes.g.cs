
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DId
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkStatus? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponseDto? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponseDtoStatus? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JsonError? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ProvidersMicrosoft? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoiceConfigMicrosoft? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.MicrosoftTtsProvider? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.MicrosoftTtsProviderType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.MicrosoftTtsProviderVoiceConfig? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ProvidersElevenlabs? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoiceConfigElevenlabs? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsTtsProvider? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsTtsProviderType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsTtsProviderVoiceConfig? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ProvidersAmazon? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoiceIdsAmazon? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AmazonTtsProvider? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AmazonTtsProviderType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AmazonTtsProviderVoiceId? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ProvidersGoogle? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleTtsProvider? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleTtsProviderType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ProvidersAzureOpenAi? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAiTtsProvider? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAiTtsProviderVoiceConfig? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAiTtsProviderType? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProviders? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersMicrosoft? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersMicrosoftType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersMicrosoftVoiceConfig? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersElevenLabs? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersElevenLabsType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersElevenLabsVoiceConfig? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersAmazon? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersAmazonType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersAmazonVoiceId? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersGoogle? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersGoogleType? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersOpenAI? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersOpenAIVoiceConfig? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextToSpeechProvidersOpenAIType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScript? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderMicrosoft? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderMicrosoftType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderMicrosoftVoiceConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderElevenLabs? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderElevenLabsType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderElevenLabsVoiceConfig? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderAmazon? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderAmazonType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderAmazonVoiceId? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderGoogle? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderGoogleType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderOpenAI? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderOpenAIVoiceConfig? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TextScriptProviderOpenAIType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AudioScript? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AudioScriptType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Script? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1Type? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderMicrosoft? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderMicrosoftType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderMicrosoftVoiceConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderElevenLabs? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderElevenLabsType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderElevenLabsVoiceConfig? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderAmazon? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderAmazonType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderAmazonVoiceId? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderGoogle? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderGoogleType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderOpenAI? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderOpenAIVoiceConfig? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant1ProviderOpenAIType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant2? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ScriptVariant2Type? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Logo? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ResultFormat? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Expression? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TimedExpression? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TimedExpressionExpression? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressionConfig? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ExpressionConfigExpression>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressionConfigExpression? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressionConfigExpressionExpression? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalksConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalksConfigLogo? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalksConfigResultFormat? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalksConfigDriverExpressions? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.TalksConfigDriverExpressionsExpression>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalksConfigDriverExpressionsExpression? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalksConfigDriverExpressionsExpressionExpression? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OverlapKind? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Rect? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceSquareDto? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceSquareDtoOverlap? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceSquareDtoDetection? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateTalkRequestScriptVariant1, global::DId.CreateTalkRequestScriptVariant2>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1Type? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoft? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoftType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderMicrosoftVoiceConfig? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabs? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderElevenLabsVoiceConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderAmazon? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderAmazonType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderAmazonVoiceId? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderGoogle? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderGoogleType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderOpenAI? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderOpenAIVoiceConfig? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant1ProviderOpenAIType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant2? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestScriptVariant2Type? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestConfig? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestConfigLogo? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestConfigResultFormat? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestConfigDriverExpressions? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateTalkRequestConfigDriverExpressionsExpression>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestConfigDriverExpressionsExpression? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkRequestConfigDriverExpressionsExpressionExpression? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.RecordStringAny? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDto? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoStatus? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoConfig? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoConfigLogo? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoConfigResultFormat? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoConfigDriverExpressions? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTalkDtoConfigDriverExpressionsExpression>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoConfigDriverExpressionsExpression? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkDtoConfigDriverExpressionsExpressionExpression? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDto? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTalksDtoTalk>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalk? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkStatus? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkConfig? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkConfigLogo? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkConfigResultFormat? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkConfigDriverExpressions? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTalksDtoTalkConfigDriverExpressionsExpression>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkConfigDriverExpressionsExpression? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OfferJsep? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OfferJsepType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IceServer? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CompatibilityMode? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoiceAccess? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsStreamTtsProvider? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsStreamTtsProviderType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsStreamTtsProviderVoiceConfig? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ElevenlabsStreamTtsProviderAccess? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProviders? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersMicrosoft? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersMicrosoftType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersMicrosoftVoiceConfig? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersElevenLabs? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersElevenLabsType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersElevenLabsVoiceConfig? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersElevenLabsAccess? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersOpenAI? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersOpenAIVoiceConfig? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsTextToSpeechProvidersOpenAIType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenter? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.TalkAgentPresenterVoiceMicrosoft, global::DId.TalkAgentPresenterVoiceElevenLabs, global::DId.TalkAgentPresenterVoiceOpenAI>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceMicrosoft? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceMicrosoftType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceMicrosoftVoiceConfig? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceElevenLabs? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceElevenLabsType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceElevenLabsVoiceConfig? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceElevenLabsAccess? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceOpenAI? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceOpenAIVoiceConfig? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TalkAgentPresenterVoiceOpenAIType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PresenterBackground? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenter? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.ClipAgentPresenterVoiceMicrosoft, global::DId.ClipAgentPresenterVoiceElevenLabs, global::DId.ClipAgentPresenterVoiceOpenAI>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceMicrosoft? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceMicrosoftType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceMicrosoftVoiceConfig? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceElevenLabs? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceElevenLabsType? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceElevenLabsVoiceConfig? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceElevenLabsAccess? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceOpenAI? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceOpenAIVoiceConfig? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterVoiceOpenAIType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAgentPresenterBackground? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionIdOrSentiment? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionIdOrSentimentSentiment? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentSentiment? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentSentimentSentiment? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenter? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceMicrosoft? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceMicrosoftType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceMicrosoftVoiceConfig? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceElevenLabs? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceElevenLabsType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceElevenLabsVoiceConfig? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceElevenLabsAccess? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceOpenAI? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceOpenAIVoiceConfig? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterVoiceOpenAIType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAgentPresenterBackground? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenter? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatar? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceMicrosoft? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceMicrosoftType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceElevenLabs? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceElevenLabsAccess? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceOpenAI? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterPhotoAvatarVoiceOpenAIType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatar? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceMicrosoft? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceMicrosoftType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceElevenLabs? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceElevenLabsType? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceElevenLabsAccess? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceOpenAI? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarVoiceOpenAIType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterVideoAvatarBackground? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatar? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoft? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoftType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabs? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceElevenLabsAccess? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceOpenAI? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarVoiceOpenAIType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentPresenterExpressiveAvatarBackground? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsLLMModel? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTemplate? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PromptCustomization? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PromptCustomizationKnowledgeSource? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLM? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMProvider? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMTemplate? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMPromptCustomization? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMPromptCustomizationKnowledgeSource? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMModel? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomBasicKeyConfig? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomBasicKeyConfigType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthOauth2Config? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthOauth2ConfigType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthConfig? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthConfigBasic? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthConfigBasicType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthConfigOAuth2? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomAuthConfigOAuth2Type? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLM? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMTemplate? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMPromptCustomization? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMPromptCustomizationKnowledgeSource? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLM? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMTemplate? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMPromptCustomization? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMPromptCustomizationKnowledgeSource? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMModel? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLM? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMProvider? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMTemplate? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMPromptCustomization? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMPromptCustomizationKnowledgeSource? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMModel? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLM? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMProvider? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMTemplate? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMPromptCustomization? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMPromptCustomizationKnowledgeSource? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfig? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigOpenAI? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigOpenAIProvider? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigOpenAITemplate? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigOpenAIPromptCustomization? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigOpenAIPromptCustomizationKnowledgeSource? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigOpenAIModel? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant2? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant2Template? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant2PromptCustomization? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant2PromptCustomizationKnowledgeSource? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant3? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant3Template? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant3PromptCustomization? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigVariant3PromptCustomizationKnowledgeSource? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigDId? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigDIdProvider? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigDIdTemplate? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigDIdPromptCustomization? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigDIdPromptCustomizationKnowledgeSource? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigDIdModel? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigGoogle? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigGoogleProvider? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigGoogleTemplate? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigGooglePromptCustomization? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigGooglePromptCustomizationKnowledgeSource? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigGoogleModel? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.KnowledgeProvider? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EmbeddingProvider? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EmbeddingTrim? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.KnowledgeEmbedder? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.KnowledgeEmbedderProvider? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.KnowledgeEmbedderTrim? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Knowledge? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUseCase? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentStatus? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Auth? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.WebhookConfig? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.WebhookConfigAuth? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventToolConfig? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolChoiceStrategy? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventTriggerConfig? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.EventTriggerConfigWebhook>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventTriggerConfigWebhook? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventTriggerConfigWebhookAuth? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfig? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigChatEnd? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AgentTriggersConfigChatEndWebhook>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigChatEndWebhook? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigChatEndWebhookAuth? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentAdvancedSettings? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CloudProvider? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetStatus? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Asset? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetCloudProvider? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetError? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Agent? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AgentPresenterPhotoAvatar, global::DId.AgentPresenterVideoAvatar, global::DId.AgentPresenterExpressiveAvatar>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AgentLlmOpenAI, global::DId.AgentLlmVariant2, global::DId.AgentLlmVariant3, global::DId.AgentLlmDId, global::DId.AgentLlmGoogle>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmOpenAI? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmOpenAIProvider? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmOpenAITemplate? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmOpenAIPromptCustomization? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmOpenAIPromptCustomizationKnowledgeSource? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmOpenAIModel? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant2? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant2Template? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant2PromptCustomization? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant2PromptCustomizationKnowledgeSource? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant3? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant3Template? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant3PromptCustomization? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmVariant3PromptCustomizationKnowledgeSource? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmDId? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmDIdProvider? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmDIdTemplate? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmDIdPromptCustomization? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmDIdPromptCustomizationKnowledgeSource? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmDIdModel? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmGoogle? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmGoogleProvider? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmGoogleTemplate? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmGooglePromptCustomization? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmGooglePromptCustomizationKnowledgeSource? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentLlmGoogleModel? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentProvider? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentKnowledge? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentKnowledgeProvider? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentError? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggers? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersChatEnd? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AgentTriggersChatEndWebhook>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersChatEndWebhook? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersChatEndWebhookAuth? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnswerJsep? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnswerJsepType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IceCandidate? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScript? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptType? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.StreamTextScriptProviderMicrosoft, global::DId.StreamTextScriptProviderElevenLabs, global::DId.StreamTextScriptProviderOpenAI>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderMicrosoft? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderMicrosoftType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderMicrosoftVoiceConfig? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderElevenLabs? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderElevenLabsType? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderElevenLabsVoiceConfig? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderElevenLabsAccess? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderOpenAI? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderOpenAIVoiceConfig? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamTextScriptProviderOpenAIType? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamAudioScript? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamAudioScriptType? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Role? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Message? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.MessageRole2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OptionsInterface? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OptionsInterfaceCustom? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScript? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1Type? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderMicrosoft? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderMicrosoftType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderMicrosoftVoiceConfig? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderElevenLabs? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderElevenLabsType? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderElevenLabsVoiceConfig? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderElevenLabsAccess? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderOpenAI? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderOpenAIVoiceConfig? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant1ProviderOpenAIType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StreamScriptVariant2Type? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressions? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitTalksConfigLogoOrDriverExpressions? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitTalksConfigLogoOrDriverExpressionsResultFormat? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeprecatedTalksConfig? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StickyStreamRequest? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceRect? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.A2eModel? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDto? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceMicrosoft? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceMicrosoftType? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceMicrosoftVoiceConfig? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceElevenLabs? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceElevenLabsType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceElevenLabsVoiceConfig? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceAmazon? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceAmazonType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceAmazonVoiceId? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceGoogle? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceGoogleType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceOpenAI? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceOpenAIVoiceConfig? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoVoiceOpenAIType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoStatus? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterDtoFaceRect? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponse? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetClipsPresentersResponsePresenter>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenter? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoft? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoftType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceMicrosoftVoiceConfig? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabs? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabsType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceElevenLabsVoiceConfig? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceAmazon? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceAmazonType? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceAmazonVoiceId? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceGoogle? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceGoogleType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceOpenAI? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceOpenAIVoiceConfig? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterVoiceOpenAIType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterStatus? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsPresentersResponsePresenterFaceRect? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributes? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoft? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoftType? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceMicrosoftVoiceConfig? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabs? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabsType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceElevenLabsVoiceConfig? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceAmazon? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceAmazonType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceAmazonVoiceId? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceGoogle? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceGoogleType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceOpenAI? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceOpenAIVoiceConfig? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1VoiceOpenAIType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1A2eModel? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant1FaceRect? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant2? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesVariant3? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipDriverDto? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsDriversResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetClipsDriversResponseClipsDriver>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsDriversResponseClipsDriver? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipAvatarStatus? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GreenscreenConfig? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainConfig? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipTrainRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipTrainRequestGender? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipTrainRequestConfig? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Providers? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipStatus? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponse? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponseObject? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponseStatus? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipConfig? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipConfigLogo? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipConfigResultFormat? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.WideCrop? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.WideCropType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.RectangleCrop? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.RectangleCropType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.RectangleCropRectangle? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Crop? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CropVariant1? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CropVariant1Type? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CropVariant2? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CropVariant2Type? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CropVariant2Rectangle? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterConfig? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.ClipPresenterConfigCropVariant1, global::DId.ClipPresenterConfigCropVariant2>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterConfigCropVariant1? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterConfigCropVariant1Type? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterConfigCropVariant2? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterConfigCropVariant2Type? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipPresenterConfigCropVariant2Rectangle? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipBackground? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<string, bool?>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequest? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateClipRequestScriptVariant1, global::DId.CreateClipRequestScriptVariant2>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1Type? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderMicrosoft? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderMicrosoftType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderMicrosoftVoiceConfig? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderElevenLabs? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderElevenLabsType? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderElevenLabsVoiceConfig? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderAmazon? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderAmazonType? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderAmazonVoiceId? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderGoogle? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderGoogleType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderOpenAI? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderOpenAIVoiceConfig? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant1ProviderOpenAIType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant2? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestScriptVariant2Type? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestConfig? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestConfigLogo? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestConfigResultFormat? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestPresenterConfig? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateClipRequestPresenterConfigCropVariant1, global::DId.CreateClipRequestPresenterConfigCropVariant2>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestPresenterConfigCropVariant1? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestPresenterConfigCropVariant1Type? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestPresenterConfigCropVariant2? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestPresenterConfigCropVariant2Type? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestPresenterConfigCropVariant2Rectangle? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipRequestBackground? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponseConfig? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponseConfigLogo? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponseConfigResultFormat? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponseStatus? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponse? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetClipsResponseClip>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponseClip? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponseClipConfig? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponseClipConfigLogo? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponseClipConfigResultFormat? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponseClipStatus? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolutionBackground? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitStreamVideoConfigResolution? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitStreamVideoConfigResolutionBackground? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipStreamConfig? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.ClipStreamConfigLogo, bool?>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipStreamConfigLogo? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClipStreamConfigResultFormat? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TranslationStatus? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TranscriptionVersion? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Transcription? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationResponse? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationResponseStatus? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTranslationResponseTranscription>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationResponseTranscription? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationResponseTranscriptionVersion? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTranslationResponseDto? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateTranslationResponseDtoTranslation>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTranslationResponseDtoTranslation? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTranslationResponseDtoTranslationStatus? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateTranslationResponseDtoTranslationTranscription>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTranslationResponseDtoTranslationTranscription? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTranslationResponseDtoTranslationTranscriptionVersion? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTranslationRequestDto? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GroupStatus? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GroupTranslation? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GroupTranslationStatus? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GroupTranslationTranscription>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GroupTranslationTranscription? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GroupTranslationTranscriptionVersion? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponse? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponseStatus? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslation>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponseTranslation? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponseTranslationStatus? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetGroupResponseTranslationTranscription>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponseTranslationTranscription? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponseTranslationTranscriptionVersion? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickGetGroupResponseName? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialPickGetTranslationResponseName? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Caption? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationsResponse? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslation>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationsResponseTranslation? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationsResponseTranslationStatus? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTranslationsResponseTranslationTranscription>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationsResponseTranslationTranscription? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationsResponseTranslationTranscriptionVersion? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SceneAvatarStatus? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAvatarResponseDto? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAvatarResponseDtoStatus? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAvatarResponseDtoObject? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAvatarRequestDto? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreationNotes? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreationNotesWorkerError>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreationNotesWorkerError? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDto? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDtoStatus? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDtoObject? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDtoError? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDtoFaceRect? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDtoCreationNotes? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAvatarResponseDtoCreationNotesWorkerError>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarResponseDtoCreationNotesWorkerError? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SceneAvatarStatusDraft? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDraftAvatarRequestDto? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDto? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseDtoAvatar>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatar? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatarStatus? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatarObject? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatarError? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatarFaceRect? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatarCreationNotes? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseDtoAvatarCreationNotesWorkerError>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseDtoAvatarCreationNotesWorkerError? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SceneStatus? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneResponseDto? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneResponseDtoObject? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneResponseDtoStatus? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SceneConfig? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SceneConfigLogo? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SceneBackground? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDto? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateSceneRequestDtoScriptText, global::DId.CreateSceneRequestDtoScriptAudio>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptText? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoft? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoftType? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderMicrosoftVoiceConfig? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabs? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabsType? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderElevenLabsVoiceConfig? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderAmazon? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderAmazonType? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderAmazonVoiceId? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderGoogle? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderGoogleType? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderOpenAI? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderOpenAIVoiceConfig? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptTextProviderOpenAIType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptAudio? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoScriptAudioType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoConfig? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoConfigLogo? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSceneRequestDtoBackground? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSceneResponseDto? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSceneResponseDtoStatus? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSceneResponseDtoConfig? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSceneResponseDtoConfigLogo? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSceneResponseDtoError? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseDto? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetScenesResponseDtoScene>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseDtoScene? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseDtoSceneStatus? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseDtoSceneConfig? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseDtoSceneConfigLogo? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseDtoSceneError? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarAvatarPublicAllowedAttributes? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarPublicDto? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialOmitExpressiveAvatarInternalDtoKeyofExpressiveAvatarPublicDto? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarDto? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarDtoVariant1? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributes? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoft? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftVoiceConfig? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabs? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsVoiceConfig? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazon? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonVoiceId? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogle? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceGoogleType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAI? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIVoiceConfig? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceOpenAIType? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDto? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoSentiment? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoft? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftVoiceConfig? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabs? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceElevenLabsVoiceConfig? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazon? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogle? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceGoogleType? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAI? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIVoiceConfig? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialOmitExpressiveAvatarExpressionInternalDtoKeyofExpressiveAvatarExpressionPublicDto? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDto? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1Sentiment? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoftType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoftVoiceConfig? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsType? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabsVoiceConfig? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAIVoiceConfig? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAIType? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDto? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant1Variant1? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoft? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftVoiceConfig? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabs? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsType? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceElevenLabsVoiceConfig? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogle? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceGoogleType? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAI? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIVoiceConfig? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDto? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarVariant1? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatar? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoft? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftVoiceConfig? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabs? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsType? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceElevenLabsVoiceConfig? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazon? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonVoiceId? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAI? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIVoiceConfig? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainingStatus? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PostTrainingResponseItem? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PostTrainingResponseItemStatus? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SentimentConfig? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SentimentConfigVoiceType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.RecordStringSentimentConfig? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PostTrainingRequestItem? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PostTrainingRequestItemSentiments? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveStatus? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveVideoIdOrStatusOrCreatedAt? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveVideoIdOrStatusOrCreatedAtStatus? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveResponseDto? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveResponseDtoVariant1? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveResponseDtoVariant1Status? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveResponseDtoVariant2? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveResponseDtoVariant2Object? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoConfig? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.ExpressiveVideoConfigLogo, bool?>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoConfigLogo? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoConfigResultFormat? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ColorBackground? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ColorBackgroundType? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveImageBackground? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveImageBackgroundType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoBackground? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoBackgroundVariant1? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoBackgroundVariant1Type? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoBackgroundVariant2? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveVideoBackgroundVariant2Type? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExpressiveInferenceMode? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InternalCallConfig? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InternalCallConfigInferenceMode? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDto? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoConfig? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoConfigLogo, bool?>? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoConfigLogo? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoConfigResultFormat? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoBackgroundVariant1, global::DId.CreateExpressiveRequestDtoBackgroundVariant2>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoBackgroundVariant1? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoBackgroundVariant1Type? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoBackgroundVariant2? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoBackgroundVariant2Type? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateExpressiveRequestDtoScriptVariant1, global::DId.CreateExpressiveRequestDtoScriptVariant2>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1Type? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoft? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftVoiceConfig? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabs? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabsType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderElevenLabsVoiceConfig? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazon? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderAmazonVoiceId? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderGoogle? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAI? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIVoiceConfig? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant2? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateExpressiveRequestDtoScriptVariant2Type? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveVideoExpressivePublicAllowedAttributes? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveVideoExpressivePublicAllowedAttributesStatus? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickExpressiveVideoExpressivePublicAllowedAttributesError? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveResponseDto? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveResponseDtoStatus? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressiveResponseDtoError? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseDto? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseDtoExpressive>? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseDtoExpressive? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseDtoExpressiveStatus? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseDtoExpressiveError? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ClientKeyResponseDto? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResourceClientKeyDto? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResourceClientKeyDto? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TriggerEventTypeChatEnd? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.MessageRole? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JSONValue? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.JSONValue?>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::DId.JSONValue?>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolResultOutput? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolResultOutputVariant1? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolResultOutputVariant1Type? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolResultOutputVariant2? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolResultOutputVariant2Type? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ToolResult? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IMessage? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IMessageRole? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ToolResult>? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UserPlan? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentInfo? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Insights? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalChat? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.IMessage>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalChatPlan? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalChatAgent? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalChatInsights? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatEndEventData? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatEndEventDataEventType? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TriggerEventTypeChatStart? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatStartEventData? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatStartEventDataEventType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TriggerEventData? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TriggerEventDataVariant2? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TriggerEventDataVariant2EventType? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookResponseDto? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookRequestDto? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookRequestDtoEventType? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookRequestDtoAuth? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarType? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsType? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccess? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIType? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftType? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccess? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarBackground? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsType? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIType? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarBackground? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProvider? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomization? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSource? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomization? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSource? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProvider? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomization? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSource? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModel? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProvider? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplate? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomization? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSource? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModel? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledge? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsError? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEnd? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssets? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarType? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoft? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftType? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabs? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsType? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceElevenLabsAccess? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAI? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatarVoiceOpenAIType? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarType? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoft? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftType? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabs? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsType? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceElevenLabsAccess? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAI? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarVoiceOpenAIType? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatarBackground? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarType? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsType? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabsAccess? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAIType? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarBackground? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIProvider? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAITemplate? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomization? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIPromptCustomizationKnowledgeSource? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAIModel? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSource? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3Template? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomization? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3PromptCustomizationKnowledgeSource? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdProvider? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdTemplate? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomization? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdPromptCustomizationKnowledgeSource? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDIdModel? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleProvider? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleTemplate? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomization? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGooglePromptCustomizationKnowledgeSource? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogleModel? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledge? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsError? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEnd? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhookAuth? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetResponseDto? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetResponseDtoStatus? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetResponseDtoModerationError? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentAdvancedSettingsResponse? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentAdvancedSettingsResponseDefaults? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDto? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatar? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarType? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoft? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoftType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabs? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAI? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatar? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarType? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoft? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabs? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsType? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceElevenLabsAccess? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAI? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarVoiceOpenAIType? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterVideoAvatarBackground? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatar? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarType? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoft? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoftType? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabs? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAI? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1PresenterExpressiveAvatarBackground? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmOpenAI? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmOpenAIProvider? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmOpenAITemplate? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmOpenAIPromptCustomization? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmOpenAIPromptCustomizationKnowledgeSource? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmOpenAIModel? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant2? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant2Template? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant2PromptCustomization? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant2PromptCustomizationKnowledgeSource? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant3? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant3Template? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant3PromptCustomization? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmVariant3PromptCustomizationKnowledgeSource? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmDId? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmDIdProvider? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmDIdTemplate? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmDIdPromptCustomization? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmDIdPromptCustomizationKnowledgeSource? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmDIdModel? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmGoogle? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmGoogleProvider? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmGoogleTemplate? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmGooglePromptCustomization? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmGooglePromptCustomizationKnowledgeSource? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1LlmGoogleModel? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1Provider? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1Knowledge? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1KnowledgeProvider? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1Error? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1Triggers? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1TriggersChatEnd? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AgentResponseDtoVariant1TriggersChatEndWebhook>? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1TriggersChatEndWebhook? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant1TriggersChatEndWebhookAuth? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant2? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentResponseDtoVariant2Metadata? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMCreateDto? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMCreateDtoProvider? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMCreateDtoTemplate? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMCreateDtoPromptCustomization? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMCreateDtoPromptCustomizationKnowledgeSource? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAILLMCreateDtoModel? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDto? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoProvider? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoTemplate? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoPromptCustomization? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoPromptCustomizationKnowledgeSource? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CustomLLMCreateDtoCustomBasic, global::DId.CustomLLMCreateDtoCustomOAuth2>? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoCustomBasic? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoCustomBasicType? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoCustomOAuth2? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CustomLLMCreateDtoCustomOAuth2Type? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMCreateDto? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMCreateDtoTemplate? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMCreateDtoPromptCustomization? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSource? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMCreateDto? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMCreateDtoTemplate? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMCreateDtoPromptCustomization? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AzureOpenAIExternalLLMCreateDtoPromptCustomizationKnowledgeSource? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMCreateDto? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMCreateDtoProvider? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMCreateDtoTemplate? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMCreateDtoPromptCustomization? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMCreateDtoPromptCustomizationKnowledgeSource? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DIdLLMCreateDtoModel? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMCreateDto? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMCreateDtoProvider? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMCreateDtoTemplate? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMCreateDtoPromptCustomization? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMCreateDtoPromptCustomizationKnowledgeSource? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GoogleLLMCreateDtoModel? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDto? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant1? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant1Provider? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant1Template? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant1PromptCustomization? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant1PromptCustomizationKnowledgeSource? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant1Model? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2Provider? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2Template? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2PromptCustomization? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2PromptCustomizationKnowledgeSource? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.LLMConfigCreateDtoVariant2CustomBasic, global::DId.LLMConfigCreateDtoVariant2CustomOAuth2>? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2CustomBasic? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2CustomBasicType? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2CustomOAuth2? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant2CustomOAuth2Type? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant3? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant3Template? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant3PromptCustomization? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant3PromptCustomizationKnowledgeSource? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant4? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant4Template? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant4PromptCustomization? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant4PromptCustomizationKnowledgeSource? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant5? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant5Provider? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant5Template? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant5PromptCustomization? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant5PromptCustomizationKnowledgeSource? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant5Model? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant6? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant6Provider? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant6Template? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant6PromptCustomization? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant6PromptCustomizationKnowledgeSource? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LLMConfigCreateDtoVariant6Model? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickKnowledgeId? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.WebhookConfigDto? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.WebhookConfigDtoAuth? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventTriggerConfigDto? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.EventTriggerConfigDtoWebhook>? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventTriggerConfigDtoWebhook? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.EventTriggerConfigDtoWebhookAuth? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigDto? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigDtoChatEnd? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AgentTriggersConfigDtoChatEndWebhook>? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigDtoChatEndWebhook? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentTriggersConfigDtoChatEndWebhookAuth? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetMimeType? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetCreateDto? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetCreateDtoMimeType? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetUpdateDto? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetUpdateDtoMimeType? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetDto? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetDtoVariant1? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetDtoVariant1MimeType? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetDtoVariant2? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AssetDtoVariant2MimeType? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDto? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AgentCreateDtoPresenterPhotoAvatar, global::DId.AgentCreateDtoPresenterVideoAvatar, global::DId.AgentCreateDtoPresenterExpressiveAvatar>? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatar? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarType? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftType? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabs? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsType? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceElevenLabsAccess? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAI? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterPhotoAvatarVoiceOpenAIType? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatar? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarType? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsType? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabsAccess? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarVoiceOpenAIType? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterVideoAvatarBackground? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatar? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarType? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoft? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoftType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabs? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsType? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceElevenLabsAccess? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAI? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarVoiceOpenAIType? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoPresenterExpressiveAvatarBackground? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant1? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant1Provider? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant1Template? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant1PromptCustomization? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant1PromptCustomizationKnowledgeSource? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant1Model? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2Provider? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2Template? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2PromptCustomization? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2PromptCustomizationKnowledgeSource? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AgentCreateDtoLlmVariant2CustomBasic, global::DId.AgentCreateDtoLlmVariant2CustomOAuth2>? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2CustomBasic? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2CustomBasicType? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2CustomOAuth2? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant2CustomOAuth2Type? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant3? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant3Template? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant3PromptCustomization? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant3PromptCustomizationKnowledgeSource? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant4? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant4Template? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant4PromptCustomization? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant4PromptCustomizationKnowledgeSource? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant5? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant5Provider? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant5Template? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant5PromptCustomization? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant5PromptCustomizationKnowledgeSource? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant5Model? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant6? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant6Provider? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant6Template? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant6PromptCustomization? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant6PromptCustomizationKnowledgeSource? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoLlmVariant6Model? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoKnowledge? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoTriggers? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoTriggersChatEnd? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AgentCreateDtoTriggersChatEndWebhook>? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoTriggersChatEndWebhook? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentCreateDtoTriggersChatEndWebhookAuth? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SortBy? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OrderBy? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenter? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterType? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceMicrosoft? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceMicrosoftType? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceMicrosoftVoiceConfig? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceElevenLabs? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceElevenLabsType? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceElevenLabsVoiceConfig? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceElevenLabsAccess? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceOpenAI? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceOpenAIVoiceConfig? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialTalkAgentPresenterVoiceOpenAIType? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenter? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterType? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceMicrosoft? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceMicrosoftType? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceMicrosoftVoiceConfig? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceElevenLabs? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceElevenLabsType? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceElevenLabsVoiceConfig? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceElevenLabsAccess? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceOpenAI? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceOpenAIVoiceConfig? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentTalkPresenterVoiceOpenAIType? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenter? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterType? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterBackground? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceMicrosoft? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceMicrosoftType? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceMicrosoftVoiceConfig? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceElevenLabs? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceElevenLabsType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceElevenLabsVoiceConfig? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceElevenLabsAccess? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceOpenAI? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceOpenAIVoiceConfig? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialClipAgentPresenterVoiceOpenAIType? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenter? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterType? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterBackground? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceMicrosoft? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceMicrosoftType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceMicrosoftVoiceConfig? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceElevenLabs? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceElevenLabsType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceElevenLabsVoiceConfig? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceElevenLabsAccess? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceOpenAI? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceOpenAIVoiceConfig? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentClipPresenterVoiceOpenAIType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenter? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterBackground? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceMicrosoft? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceMicrosoftType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceMicrosoftVoiceConfig? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceElevenLabs? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsType? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsVoiceConfig? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceElevenLabsAccess? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceOpenAI? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceOpenAIVoiceConfig? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialExpressiveAgentPresenterVoiceOpenAIType? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenter? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatar? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarType? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoft? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoftType? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabs? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabsType? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceElevenLabsAccess? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAI? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterPhotoAvatarVoiceOpenAIType? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatar? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarType? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarBackground? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoft? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoftType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabs? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabsType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceElevenLabsAccess? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAI? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialAgentPresenterVideoAvatarVoiceOpenAIType? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDto? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AgentUpdateDtoPresenterPhotoAvatar, global::DId.AgentUpdateDtoPresenterVideoAvatar>? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatar? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarType? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoftType? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabsAccess? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAIType? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatar? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarType? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarBackground? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoftType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsType? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabsAccess? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAIType? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmOpenAI? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmOpenAIProvider? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmOpenAITemplate? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmOpenAIPromptCustomization? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmOpenAIPromptCustomizationKnowledgeSource? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmOpenAIModel? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant2? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant2Template? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant2PromptCustomization? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant2PromptCustomizationKnowledgeSource? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant3? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant3Template? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant3PromptCustomization? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmVariant3PromptCustomizationKnowledgeSource? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmDId? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmDIdProvider? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmDIdTemplate? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmDIdPromptCustomization? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmDIdPromptCustomizationKnowledgeSource? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmDIdModel? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmGoogle? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmGoogleProvider? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmGoogleTemplate? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmGooglePromptCustomization? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmGooglePromptCustomizationKnowledgeSource? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoLlmGoogleModel? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoKnowledge? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoTriggers? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoTriggersChatEnd? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AgentUpdateDtoTriggersChatEndWebhook>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoTriggersChatEndWebhook? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentUpdateDtoTriggersChatEndWebhookAuth? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalRating? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitRatingPayloadAgentIdOrChatId? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialRatingPayload? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitStreamResponse? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitStreamResponseOffer? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitStreamResponseOfferType? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.InitStreamResponseIceServer>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitStreamResponseIceServer? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitVideoStreamRequest? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitVideoStreamRequestCompatibilityMode? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Status? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStartStreamRequest? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStartStreamRequestAnswer? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStartStreamRequestAnswerType? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateIceCandidateStreamRequest? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateIceCandidateStreamRequestVariant1Variant1, object>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateIceCandidateStreamRequestVariant1Variant1? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateIceCandidateStreamRequestVariant2? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamResponse? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamResponseVariant1? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamResponseVariant2? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScript? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptType? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderMicrosoft? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderMicrosoftType? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderMicrosoftVoiceConfig? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderElevenLabs? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderElevenLabsType? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderElevenLabsVoiceConfig? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderElevenLabsAccess? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderOpenAI? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderOpenAIVoiceConfig? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamTextScriptProviderOpenAIType? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamAudioScript? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamAudioScriptType? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScript? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptText? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextType? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderMicrosoft? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderMicrosoftType? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderMicrosoftVoiceConfig? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderElevenLabs? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderElevenLabsType? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderElevenLabsVoiceConfig? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderElevenLabsAccess? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderOpenAI? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderOpenAIVoiceConfig? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptTextProviderOpenAIType? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptAudio? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamScriptAudioType? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequest? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.UnifiedCreateVideoStreamRequestScriptText, global::DId.UnifiedCreateVideoStreamRequestScriptAudio>? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptText? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextType? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoft? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftVoiceConfig? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabs? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsVoiceConfig? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsAccess? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAI? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIVoiceConfig? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptAudio? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnifiedCreateVideoStreamRequestScriptAudioType? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequest? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateVideoStreamRequestScriptText, global::DId.CreateVideoStreamRequestScriptAudio>? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptText? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextType? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoft? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftType? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderMicrosoftVoiceConfig? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabs? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsType? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsVoiceConfig? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderOpenAI? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIVoiceConfig? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptTextProviderOpenAIType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptAudio? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamRequestScriptAudioType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamRequest? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatRequest? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IRetrivalMetadata? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatMode? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatResponse? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ChatResponseMatche>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatResponseMatche? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatResponseChatMode? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IChatPayload? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.IChatPayloadMessage>? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IChatPayloadMessage? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IChatPayloadMessageRole? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IChatPayloadChatMode? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TransportProvider? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TransportProviderLiveKit? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitLiveKitRoomTransport? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitLiveKitRoomTransportProvider? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitSessionTransport? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitSessionTransportProvider? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JoinLiveKitRoomTransport? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JoinLiveKitRoomTransportProvider? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AudioConfig? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JoinLivekitRoomRequest? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JoinLivekitRoomRequestAudioConfig? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JoinLivekitRoomRequestTransport? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.JoinLivekitRoomRequestTransportProvider? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionAgentDto? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OutcomeType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionInsightsDto? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionInsightsDtoOutcome? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionSummaryDto? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionSummaryDtoAgent? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionSummaryDtoInsights? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionSummaryDtoInsightsOutcome? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SessionParticipantDto? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportParams? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportDto? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportDtoVariant1? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportDtoVariant2? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportStatus? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportWithId? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportWithIdStatus? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExportWithIdResult? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.KnowledgeType? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalKnowledge? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalKnowledgeType? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickKnowledgeDataExcludeKeyofKnowledgeDataCreatedByOrTypeOrStatus? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitKnowledgeDataCreatedByOrTypeOrStatus? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.KnowledgeCreateDto? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DocumentType? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Subject? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalDocument? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalDocumentDocumentType? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalDocumentType? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ILogicalDocumentStatus? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SupportedDocumentType? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickDocumentDataExcludeKeyofDocumentDataCreatedByOrParsedUrlOrStatusOrTypeOrErrorOrDocumentType? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitDocumentDataCreatedByOrParsedUrlOrStatusOrTypeOrErrorOrDocumentType? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentDto? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentDtoVariant1? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentDtoVariant1DocumentType? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentDtoVariant2? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PartialKnowledgeDto? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DocumentPayload? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DocumentPayloadDocumentType? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IKnowledgeMessage? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IKnowledgeMessageRole? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.OmitIPineconeQueryConfigNamespace? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.MemoryItemDto? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.PutMemoryItemDto? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoiceLanguage? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoiceType? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IVoice? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IVoiceAccess? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IVoiceConfig? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IVoiceProvider? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.IVoiceLanguage>? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IVoiceLanguage? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.IVoiceVoiceType? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceSquare? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceSquareOverlap? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceSquareDetection? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadImageResponseDto? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.UploadImageResponseDtoFace>? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadImageResponseDtoFace? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadImageResponseDtoFaceOverlap? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadImageResponseDtoFaceDetection? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ImageMetadata? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceDetectionDto? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.FaceDetectionDtoFaceCrop>? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceDetectionDtoFaceCrop? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceDetectionDtoMetadata? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceDetectionRequest? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAudioResponseDto? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAudioResponseDtoModerationMetadata? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreditsItem? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreditsItemProductBillingInterval? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UserCredits? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.UserCreditsCredit>? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UserCreditsCredit? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UserCreditsCreditProductBillingInterval? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreditsUsageItem? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateConsentResponseDto? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateConsentRequestDto? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadVideoResponseDto? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadConsentRequestBodyDto? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ConsentStatus? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseDto? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseDtoStatus? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseDtoError? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseDto? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ListResponseDtoConsent>? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseDtoConsent? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseDtoConsentStatus? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseDtoConsentError? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsSettings? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AgentsSettingsLlmModel? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AvatarsSettings? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Settings? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SettingsLogo? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SettingsAgents? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SettingsAgentsLlmModel? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SettingsAvatars? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExternalSettingsRequestDTO? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ExternalSettingsRequestDTOLogo? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SecretAuthType? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SanitizedSecretDto? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SanitizedSecretDtoType? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SecretAuthTypeBasic? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateBasicAuthSecretRequestDto? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateBasicAuthSecretRequestDtoType? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SecretAuthTypeBearer? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateBearerAuthSecretRequestDto? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateBearerAuthSecretRequestDtoType? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SecretAuthTypeApiKey? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateApiKeyAuthSecretRequestDto? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateApiKeyAuthSecretRequestDtoType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDto? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDtoBasicAuthentication? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDtoBasicAuthenticationType? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDtoBearerToken? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDtoBearerTokenType? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDtoApiKey? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestDtoApiKeyType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretOpenAIRequestDto? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretOpenAIRequestDtoProvider? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretAzureOpenAIRequestDto? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretAzureOpenAIRequestDtoProvider? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretExternalLLMRequestDto? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfigurationProvider? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretExternalLLMRequestDtoVariant2? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretExternalLLMRequestDtoVariant2Provider? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateBasicAuthSecretRequestDto? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateBasicAuthSecretRequestDtoType? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateBearerAuthSecretRequestDto? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateBearerAuthSecretRequestDtoType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateApiKeyAuthSecretRequestDto? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateApiKeyAuthSecretRequestDtoType? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDto? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDtoBasicAuthentication? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDtoBasicAuthenticationType? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDtoBearerToken? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDtoBearerTokenType? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDtoApiKey? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateAuthSecretRequestDtoApiKeyType? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretOpenAIRequestDto? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretOpenAIRequestDtoProvider? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretAzureOpenAIRequestDto? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretAzureOpenAIRequestDtoProvider? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretExternalLLMRequestDto? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretExternalLLMRequestDtoVariant2? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretExternalLLMRequestDtoVariant2Provider? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationStatus? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponseDto? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponseDtoStatus? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LogoDto? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LogoDtoVariant1? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimateConfigDto? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AnimateConfigDtoLogo, bool?>? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimateConfigDtoLogo? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimateConfigDtoResultFormat? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDto? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDtoFace? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDtoFaceOverlap? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDtoFaceDetection? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDtoConfig? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateAnimationDtoConfigLogo, bool?>? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDtoConfigLogo? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationDtoConfigResultFormat? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DriverError? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.LogoError? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.SourceError? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.FaceError? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VideoEnhanceError? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UnknownError? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationError? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationErrorVariant1? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationErrorVariant2? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationErrorVariant3? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationErrorVariant4? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationErrorVariant5? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnimationErrorVariant6? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDto? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoStatus? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoErrorVariant1? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoErrorVariant2? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoErrorVariant3? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoErrorVariant4? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoErrorVariant5? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoErrorVariant6? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoConfig? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.GetAnimationResponseDtoConfigLogo, bool?>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoConfigLogo? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseDtoConfigResultFormat? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDto? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAnimationsResponseDtoAnimation>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimation? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationStatus? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationErrorVariant1? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationErrorVariant2? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationErrorVariant3? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationErrorVariant4? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationErrorVariant5? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationErrorVariant6? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationConfig? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.GetAnimationsResponseDtoAnimationConfigLogo, bool?>? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationConfigLogo? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseDtoAnimationConfigResultFormat? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitTalkStreamRequest? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitTalkStreamRequestFace? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitTalkStreamRequestFaceOverlap? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitTalkStreamRequestFaceDetection? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitTalkStreamRequestConfig? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitTalkStreamRequestCompatibilityMode? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequest? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateTalkStreamRequestScriptVariant1, global::DId.CreateTalkStreamRequestScriptVariant2>? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1Type? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsVoiceConfig? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsAccess? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAI? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAIVoiceConfig? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant2? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestScriptVariant2Type? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.CreateTalkStreamRequestConfigVariant1, global::DId.CreateTalkStreamRequestConfigVariant2>? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestConfigVariant1? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestConfigVariant1ResultFormat? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamRequestConfigVariant2? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitClipStreamRequest? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.InitClipStreamRequestCompatibilityMode? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequest? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateClipStreamRequestScriptVariant1, global::DId.CreateClipStreamRequestScriptVariant2>? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1Type? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoft? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabs? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsVoiceConfig? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderElevenLabsAccess? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAI? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAIVoiceConfig? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant1ProviderOpenAIType? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant2? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestScriptVariant2Type? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestConfig? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateClipStreamRequestConfigLogo, bool?>? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestConfigLogo? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestConfigResultFormat? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestPresenterConfig? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateClipStreamRequestPresenterConfigCropVariant1, global::DId.CreateClipStreamRequestPresenterConfigCropVariant2>? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestPresenterConfigCropVariant1? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestPresenterConfigCropVariant1Type? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestPresenterConfigCropVariant2? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestPresenterConfigCropVariant2Type? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestPresenterConfigCropVariant2Rectangle? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamRequestBackground? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoft? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftVoiceConfig? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabs? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsType? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceElevenLabsVoiceConfig? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazon? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazonType? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogle? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceGoogleType? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAI? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAIVoiceConfig? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1VoiceOpenAIType? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1A2eModel? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant1FaceRect? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant2? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesRequestVariant3? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipRequest? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipRequestGender? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipRequestConfig? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequest? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Request2? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2Request? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.Create2RequestScriptText, global::DId.Create2RequestScriptAudio>? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptText? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextType? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderMicrosoft? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderMicrosoftType? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderMicrosoftVoiceConfig? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderElevenLabs? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderElevenLabsType? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderElevenLabsVoiceConfig? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderAmazon? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderAmazonType? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderAmazonVoiceId? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderGoogle? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderGoogleType? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderOpenAI? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderOpenAIVoiceConfig? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptTextProviderOpenAIType? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptAudio? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestScriptAudioType? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestConfig? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestConfigLogo? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2RequestBackground? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3Request? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestConfig? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.Create3RequestConfigLogo, bool?>? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestConfigLogo? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestConfigResultFormat? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.Create3RequestBackgroundVariant1, global::DId.Create3RequestBackgroundVariant2>? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestBackgroundVariant1? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestBackgroundVariant1Type? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestBackgroundVariant2? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestBackgroundVariant2Type? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.Create3RequestScriptVariant1, global::DId.Create3RequestScriptVariant2>? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1Type? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderMicrosoft? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderMicrosoftType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderMicrosoftVoiceConfig? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderElevenLabs? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderElevenLabsType? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderElevenLabsVoiceConfig? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderAmazon? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderAmazonType? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderAmazonVoiceId? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderGoogle? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderGoogleType? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderOpenAI? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderOpenAIVoiceConfig? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant1ProviderOpenAIType? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant2? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3RequestScriptVariant2Type? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClientKeyRequest? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateClientKeyRequest? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResourceClientKeyRequest? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResourceClientKeyRequest? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookConfigurationRequest? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookConfigurationRequestEventType? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookConfigurationRequestAuth? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequest2? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatar? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarType? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatar? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarType? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterVideoAvatarBackground? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatar? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarType? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestPresenterExpressiveAvatarBackground? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant1? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant1Provider? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant1Template? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant1PromptCustomization? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant1Model? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2Provider? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2Template? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2PromptCustomization? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2CustomBasic? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2CustomBasicType? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2CustomOAuth2? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant2CustomOAuth2Type? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant3? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant3Template? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant3PromptCustomization? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant4? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant4Template? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant4PromptCustomization? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant5? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant5Provider? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant5Template? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant5PromptCustomization? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant5Model? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant6? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant6Provider? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant6Template? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant6PromptCustomization? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestLlmVariant6Model? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestKnowledge? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestTriggers? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestTriggersChatEnd? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateRequestTriggersChatEndWebhook>? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestTriggersChatEndWebhook? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequestTriggersChatEndWebhookAuth? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequest? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatar? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarType? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatar? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarType? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarBackground? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIVoiceConfig? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmOpenAI? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmOpenAIProvider? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmOpenAITemplate? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmOpenAIPromptCustomization? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmOpenAIModel? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant2? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant2Template? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant2PromptCustomization? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant3? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant3Template? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant3PromptCustomization? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmDId? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmDIdProvider? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmDIdTemplate? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmDIdPromptCustomization? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmDIdModel? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmGoogle? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmGoogleProvider? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmGoogleTemplate? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmGooglePromptCustomization? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestLlmGoogleModel? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestKnowledge? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestTriggers? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestTriggersChatEnd? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.UpdateRequestTriggersChatEndWebhook>? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestTriggersChatEndWebhook? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRequestTriggersChatEndWebhookAuth? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRatingRequest? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRatingRequest? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequest2? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequestCompatibilityMode? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionRequest? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionRequestAnswer? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionRequestAnswerType? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>?, global::DId.AddIceCandidateRequest4>? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant14, object>? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateRequestVariant14? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateRequest4? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatRequest? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ChatRequestMessage>? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatRequestMessage? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatRequestMessageRole? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatRequestChatMode? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.CreateChatLogsRequestVariant1, global::DId.CreateChatLogsRequestVariant2>? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatLogsRequestVariant1? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatLogsRequestVariant2? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Request? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.CreateDocumentRequestVariant1, global::DId.CreateDocumentRequestVariant2>? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentRequestVariant1? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentRequestVariant1DocumentType? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentRequestVariant2? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Update1Request? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CloneVoiceRequest? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageRequest? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionRequest? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioRequest? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRequest3? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadVideoRequest? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateLogoRequest? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsRequest? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsRequestLogo? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthentication? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestCreateSecretRequest1BasicAuthenticationType? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestCreateSecretRequest1BearerToken? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestCreateSecretRequest1BearerTokenType? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestCreateSecretRequest1ApiKey? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestCreateSecretRequest1ApiKeyType? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateSecretRequestVariant2OpenAIConfiguration, global::DId.CreateSecretRequestVariant2Variant2>? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestVariant2OpenAIConfiguration? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestVariant2OpenAIConfigurationProvider? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestVariant2Variant2? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretRequestVariant2Variant2Provider? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestUpdateSecretRequest1BearerToken? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestUpdateSecretRequest1BearerTokenType? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKey? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestUpdateSecretRequest1ApiKeyType? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.UpdateSecretRequestVariant2OpenAIConfiguration, global::DId.UpdateSecretRequestVariant2Variant2>? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestVariant2OpenAIConfiguration? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestVariant2OpenAIConfigurationProvider? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestVariant2Variant2? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretRequestVariant2Variant2Provider? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequest? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequestFace? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequestFaceOverlap? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequestFaceDetection? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequestConfig? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.CreateAnimationRequestConfigLogo, bool?>? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequestConfigLogo? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationRequestConfigResultFormat? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequest? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequestFace? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequestFaceOverlap? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequestFaceDetection? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamRequestConfig? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>?, global::DId.AddIceCandidateRequest2>? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AddIceCandidateRequestVariant12, object>? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateRequestVariant12? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateRequest2? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1Request? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1RequestCompatibilityMode? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnection1Request? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnection1RequestAnswer? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnection1RequestAnswerType? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>?, global::DId.AddIceCandidate1Request2>? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.AddIceCandidate1RequestVariant12, object>? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidate1RequestVariant12? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidate1Request2? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStream1Request? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsSortBy? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsOrder? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesProvider? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponse? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponseStatus? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponse2? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponse3? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponse4? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponse5? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkResponse6? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponse? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTalksResponseTalk>? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalk? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkStatus? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkConfig? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkConfigLogo? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkConfigResultFormat? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkConfigDriverExpressions? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTalksResponseTalkConfigDriverExpressionsExpression>? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkConfigDriverExpressionsExpression? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponseTalkConfigDriverExpressionsExpressionExpression? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalksResponse2? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponse? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseStatus? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseConfig? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseConfigLogo? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseConfigResultFormat? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseConfigDriverExpressions? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetTalkResponseConfigDriverExpressionsExpression>? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseConfigDriverExpressionsExpression? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponseConfigDriverExpressionsExpressionExpression? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponse2? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTalkResponse3? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponse? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseStatus? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseConfig? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseConfigLogo? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseConfigResultFormat? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseConfigDriverExpressions? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.DeleteTalkResponseConfigDriverExpressionsExpression>? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseConfigDriverExpressionsExpression? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponseConfigDriverExpressionsExpressionExpression? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponse2? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponse3? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteTalkResponse4? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponse? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetPresentersResponsePresenter>? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenter? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceMicrosoft? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceMicrosoftType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceMicrosoftVoiceConfig? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceElevenLabs? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceElevenLabsType? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceElevenLabsVoiceConfig? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceAmazon? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceAmazonType? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceAmazonVoiceId? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceGoogle? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceGoogleType? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceOpenAI? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceOpenAIVoiceConfig? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterVoiceOpenAIType? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterStatus? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresentersResponsePresenterFaceRect? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponse? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetPresenterByIdResponsePresenter>? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenter? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoft? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoftType? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceMicrosoftVoiceConfig? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabs? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabsType? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceElevenLabsVoiceConfig? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceAmazon? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceAmazonType? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceAmazonVoiceId? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceGoogle? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceGoogleType? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceOpenAI? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceOpenAIVoiceConfig? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterVoiceOpenAIType? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterStatus? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterByIdResponsePresenterFaceRect? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdatePresenterAttributesResponse? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeletePresenterResponse? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterDriversByIdResponse? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetPresenterDriversByIdResponseClipsDriver>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetPresenterDriversByIdResponseClipsDriver? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipResponse? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipResponseGender? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipResponseStatus? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TrainClipResponse2? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponse2? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponse3? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponse4? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponse5? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipResponse6? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipsResponse2? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponse2? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClipResponse3? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponse? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponseConfig? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponseConfigLogo? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponseConfigResultFormat? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponseStatus? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponse2? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponse3? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteClipResponse4? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateResponseTranslation>? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseTranslation? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseTranslationStatus? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateResponseTranslationTranscription>? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseTranslationTranscription? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseTranslationTranscriptionVersion? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse2? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse3? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse4? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse5? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationsResponse2? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponse2? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetGroupResponse3? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationResponse2? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetTranslationResponse3? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponse4? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponse5? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponse6? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Response3? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1ResponseStatus? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1ResponseObject? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Response4? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Response5? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Response6? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponse? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseAvatar>? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatar? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatarStatus? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatarObject? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatarError? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatarFaceRect? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatarCreationNotes? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError>? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse6? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseStatus2? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseObject? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseError? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseFaceRect? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseCreationNotes? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetResponseCreationNotesWorkerError>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseCreationNotesWorkerError? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse7? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse8? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse9? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Delete1Response? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2Response? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2ResponseObject? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2ResponseStatus? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2Response2? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2Response3? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create2Response4? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponse? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetScenesResponseScene>? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseScene? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseSceneStatus? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseSceneConfig? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseSceneConfigLogo? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetScenesResponseSceneError? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1Response2? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1ResponseStatus? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1ResponseConfig? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1ResponseConfigLogo? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1ResponseError? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1Response? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Delete2Response? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1Response? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarVariant1? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatar? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1Sentiment? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoft? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftVoiceConfig? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabs? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceElevenLabsVoiceConfig? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazon? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonType? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceAmazonVoiceId? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogle? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceGoogleType? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAI? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIVoiceConfig? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>?, global::DId.GetAvatarByIdResponse2>? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetAvatarByIdResponseVariant12, object>? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseVariant12? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponse2? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>>? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1Sentiment? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoft? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftVoiceConfig? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabs? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsType? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceElevenLabsVoiceConfig? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazon? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonType? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogle? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAI? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIVoiceConfig? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.Create3ResponseVariant1, global::DId.Create3ResponseVariant2>? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3ResponseVariant1? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3ResponseVariant1Status? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3ResponseVariant2? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3ResponseVariant2Object? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3Response2? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3Response3? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create3Response4? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponse? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetExpressivesResponseExpressive>? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseExpressive? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseExpressiveStatus? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetExpressivesResponseExpressiveError? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get2Response? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get2ResponseStatus? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get2ResponseError? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get2Response2? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get2Response3? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get2Response4? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Delete3Response? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClientKeyResponse? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClientKeyResponse2? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetClientKeyResponse3? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClientKeyResponse2? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClientKeyResponse3? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResourceClientKeyResponse? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResourceClientKeyResponse2? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResourceClientKeyResponse3? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResourceClientKeyResponse4? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ListResourceClientKeysResponseItem>? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResourceClientKeysResponseItem? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResourceClientKeysResponse? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResourceClientKeyResponse? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResourceClientKeyResponse? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.TestWebhookConfigurationResponse? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.CreateResponseVariant1, global::DId.CreateResponseVariant2>? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatar? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarType? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatar? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarType? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterVideoAvatarBackground? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatar? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarType? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1PresenterExpressiveAvatarBackground? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmOpenAI? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmOpenAIProvider? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmOpenAITemplate? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmOpenAIPromptCustomization? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmOpenAIModel? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant2? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant2Template? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant2PromptCustomization? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant3? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant3Template? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant3PromptCustomization? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmDId? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmDIdProvider? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmDIdTemplate? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmDIdPromptCustomization? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmDIdModel? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmGoogle? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmGoogleProvider? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmGoogleTemplate? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmGooglePromptCustomization? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1LlmGoogleModel? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1Provider? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1Knowledge? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1KnowledgeProvider? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1Error? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1Triggers? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1TriggersChatEnd? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateResponseVariant1TriggersChatEndWebhook>? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1TriggersChatEndWebhook? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant1TriggersChatEndWebhookAuth? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant2? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponseVariant2Metadata? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse7? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponse? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>>? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarBackground? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomization? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomization? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomization? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmDId? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomization? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomization? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1Provider? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1Knowledge? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1Error? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1Triggers? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEnd? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook>? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhookAuth? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant2? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponseAgentVariant2Metadata? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListMyAgentsResponse2? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteChatsDataResponse? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatar? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarType? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatar? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarType? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterVideoAvatarBackground? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatar? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarType? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1PresenterExpressiveAvatarBackground? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmOpenAI? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmOpenAIProvider? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmOpenAITemplate? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmOpenAIPromptCustomization? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmOpenAIModel? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant2? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant2Template? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant2PromptCustomization? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant3? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant3Template? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant3PromptCustomization? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmDId? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmDIdProvider? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmDIdTemplate? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmDIdPromptCustomization? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmDIdModel? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmGoogle? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmGoogleProvider? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmGoogleTemplate? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmGooglePromptCustomization? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1LlmGoogleModel? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1Provider? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1Knowledge? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1KnowledgeProvider? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1Error? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1Triggers? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1TriggersChatEnd? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetResponseVariant1TriggersChatEndWebhook>? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1TriggersChatEndWebhook? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant1TriggersChatEndWebhookAuth? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant2? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseVariant2Metadata? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse2? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatar? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarType? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatar? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarType? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterVideoAvatarBackground? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatar? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1PresenterExpressiveAvatarBackground? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmOpenAI? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmOpenAIProvider? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmOpenAITemplate? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomization? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmOpenAIModel? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant2? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant2Template? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant2PromptCustomization? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant3? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant3Template? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant3PromptCustomization? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmDId? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmDIdProvider? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmDIdTemplate? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmDIdPromptCustomization? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmDIdModel? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmGoogle? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmGoogleProvider? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmGoogleTemplate? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmGooglePromptCustomization? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1LlmGoogleModel? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1Provider? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1Knowledge? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1KnowledgeProvider? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1Error? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1Triggers? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1TriggersChatEnd? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.UpdateResponseVariant1TriggersChatEndWebhook>? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1TriggersChatEndWebhook? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant1TriggersChatEndWebhookAuth? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant2? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponseVariant2Metadata? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateResponse2? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatar? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarType? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatar? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarType? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterVideoAvatarBackground? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatar? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1PresenterExpressiveAvatarBackground? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmOpenAI? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmOpenAIProvider? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmOpenAITemplate? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomization? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmOpenAIModel? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant2? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant2Template? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant2PromptCustomization? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant3? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant3Template? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant3PromptCustomization? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmDId? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmDIdProvider? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmDIdTemplate? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmDIdPromptCustomization? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmDIdModel? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmGoogle? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmGoogleProvider? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmGoogleTemplate? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmGooglePromptCustomization? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1LlmGoogleModel? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1Provider? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1Knowledge? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1KnowledgeProvider? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1Error? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1Triggers? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1TriggersChatEnd? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.DeleteResponseVariant1TriggersChatEndWebhook>? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1TriggersChatEndWebhook? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant1TriggersChatEndWebhookAuth? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant2? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponseVariant2Metadata? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponse2? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRatingResponse? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateRatingResponse2? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRatingResponse? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateRatingResponse2? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteRatingResponse? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteRatingResponse2? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamResponse? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamResponseOffer? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamResponseOfferType? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateStreamResponseIceServer>? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamResponseIceServer? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamResponse3? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionResponse4? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionResponse5? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionResponse6? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateResponse4? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateResponse5? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateResponse6? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AllOf<global::DId.CreateVideoStreamResponseVariant1, global::DId.CreateVideoStreamResponseVariant2>? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamResponse2? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateVideoStreamResponse3? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse5? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse6? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse7? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse8? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatResponse2? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ChatResponse2? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatLogsResponse? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatLogsResponse2? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatLogsResponse3? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateChatLogsResponse4? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetChatLogsResponse? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetChatLogsResponseStatus? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetChatLogsResponseResult? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetChatLogsResponse2? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetChatLogsResponse3? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteChatLogsResponse? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteChatLogsResponseStatus? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteChatLogsResponseResult? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteChatLogsResponse2? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteChatLogsResponse3? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Response? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1ResponseType? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Create1Response2? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.Get1ResponseItem>? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1ResponseItem? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Get1ResponseItemType? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentResponse? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentResponseDocumentType? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentResponseType? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentResponseStatus? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateDocumentResponse2? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetDocumentsResponseItem>? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentsResponseItem? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentsResponseItemDocumentType? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentsResponseItemType? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentsResponseItemStatus? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentsResponse? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetByIdResponse? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetByIdResponseType? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetByIdResponse2? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Update1Response? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Update1ResponseType? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Update1Response2? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.Delete1Response2? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentResponse? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentResponseDocumentType? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentResponseType? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentResponseStatus? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetDocumentResponse2? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.DeleteDocumentResponseItem>? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteDocumentResponseItem? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteDocumentResponse? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.VoicesResponseItem>? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponseItem? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponseItemAccess? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponseItemConfig? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponseItemProvider? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.VoicesResponseItemLanguage>? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponseItemLanguage? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponseItemVoiceType? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.VoicesResponse? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CloneVoiceResponse? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CloneVoiceResponse2? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteResponse3? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponse? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.UploadAnImageResponseFace>? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponseFace? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponseFaceOverlap? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponseFaceDetection? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponse2? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponse3? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponse4? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponse5? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnImageResponse6? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteImageResponse? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponse? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetFaceDetectionResponseFaceCrop>? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponseFaceCrop? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponseMetadata? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponse2? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponse3? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponse4? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetFaceDetectionResponse5? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponse? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponseModerationMetadata? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponse2? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponse3? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponse4? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponse5? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadAnAudioResponse6? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAudioResponse? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetCreditsResponse? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetCreditsResponseCredit>? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetCreditsResponseCredit? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetCreditsResponseCreditProductBillingInterval? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetCreditsResponse2? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse8? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateResponse9? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponse? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.ListResponseConsent>? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseConsent? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseConsentStatus? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponseConsentError? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.ListResponse2? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadVideoResponse? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadVideoResponse2? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadVideoResponse3? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UploadVideoResponse4? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse3? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponseStatus? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse4? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetResponse5? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetLogoResponse2? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetLogoResponse3? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateLogoResponse? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteLogoResponse? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSettingsResponse2? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSettingsResponseLogo? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSettingsResponseAgents? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSettingsResponseAgentsLlmModel? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSettingsResponseAvatars? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSettingsResponse3? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsResponse? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsResponseLogo? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsResponseAgents? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsResponseAgentsLlmModel? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsResponseAvatars? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSettingsResponse2? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretResponse? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretResponseType? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateSecretResponse2? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAllSecretsResponseItem>? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAllSecretsResponseItem? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAllSecretsResponseItemType? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSecretByIdResponse? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSecretByIdResponseType? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetSecretByIdResponse2? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretResponse? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretResponseType? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.UpdateSecretResponse2? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteSecretResponse? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteSecretResponseType? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteSecretResponse2? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponse? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponseStatus? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponse2? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponse3? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponse4? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateAnimationResponse5? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponse? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.GetAnimationsResponseAnimation>? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimation? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationStatus? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationErrorVariant1? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationErrorVariant2? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationErrorVariant3? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationErrorVariant4? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationErrorVariant5? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationErrorVariant6? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationConfig? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.GetAnimationsResponseAnimationConfigLogo, bool?>? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationConfigLogo? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponseAnimationConfigResultFormat? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationsResponse2? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponse? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseStatus? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseErrorVariant1? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseErrorVariant2? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseErrorVariant3? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseErrorVariant4? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseErrorVariant5? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseErrorVariant6? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseConfig? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.GetAnimationResponseConfigLogo, bool?>? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseConfigLogo? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponseConfigResultFormat? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponse2? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.GetAnimationResponse3? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponse? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseStatus? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseErrorVariant1? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseErrorVariant2? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseErrorVariant3? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseErrorVariant4? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseErrorVariant5? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseErrorVariant6? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseConfig? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::DId.DeleteAnimationResponseConfigLogo, bool?>? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseConfigLogo? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponseConfigResultFormat? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponse2? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponse3? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteAnimationResponse4? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStreamResponse2? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionResponse? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionResponse2? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnectionResponse3? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateResponse? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateResponse2? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidateResponse3? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamResponse? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamResponse2? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateTalkStreamResponse3? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse2? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse3? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStreamResponse4? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1Response? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1ResponseOffer? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1ResponseOfferType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DId.CreateStream1ResponseIceServer>? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1ResponseIceServer? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1Response2? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateStream1Response3? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnection1Response? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnection1Response2? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.StartConnection1Response3? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidate1Response? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidate1Response2? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AddIceCandidate1Response3? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamResponse? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamResponse2? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.CreateClipStreamResponse3? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStream1Response? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStream1Response2? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStream1Response3? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.DeleteStream1Response4? Type3032 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ExpressionConfigExpression>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.TalksConfigDriverExpressionsExpression>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateTalkRequestConfigDriverExpressionsExpression>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTalkDtoConfigDriverExpressionsExpression>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTalksDtoTalk>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTalksDtoTalkConfigDriverExpressionsExpression>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DId.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.EventTriggerConfigWebhook>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AgentTriggersConfigChatEndWebhook>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AgentTriggersChatEndWebhook>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetClipsPresentersResponsePresenter>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetClipsDriversResponseClipsDriver>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetClipsResponseClip>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTranslationResponseTranscription>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateTranslationResponseDtoTranslation>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateTranslationResponseDtoTranslationTranscription>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GroupTranslationTranscription>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslation>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetGroupResponseTranslationTranscription>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslation>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTranslationsResponseTranslationTranscription>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreationNotesWorkerError>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAvatarResponseDtoCreationNotesWorkerError>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAvatarsResponseDtoAvatar>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAvatarsResponseDtoAvatarCreationNotesWorkerError>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetScenesResponseDtoScene>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarVariant1, object>?, global::DId.GetExpressiveAvatarsDtoAvatar>>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetExpressivesResponseDtoExpressive>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.JSONValue?>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ToolResult>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.IMessage>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEndWebhook>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AgentResponseDtoVariant1TriggersChatEndWebhook>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.EventTriggerConfigDtoWebhook>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AgentTriggersConfigDtoChatEndWebhook>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AgentCreateDtoTriggersChatEndWebhook>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AgentUpdateDtoTriggersChatEndWebhook>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.InitStreamResponseIceServer>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ChatResponseMatche>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.IChatPayloadMessage>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.IVoiceLanguage>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.UploadImageResponseDtoFace>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.FaceDetectionDtoFaceCrop>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.UserCreditsCredit>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ListResponseDtoConsent>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAnimationsResponseDtoAnimation>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateRequestTriggersChatEndWebhook>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.UpdateRequestTriggersChatEndWebhook>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ChatRequestMessage>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTalksResponseTalk>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTalksResponseTalkConfigDriverExpressionsExpression>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetTalkResponseConfigDriverExpressionsExpression>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.DeleteTalkResponseConfigDriverExpressionsExpression>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetPresentersResponsePresenter>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetPresenterByIdResponsePresenter>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetPresenterDriversByIdResponseClipsDriver>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateResponseTranslation>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateResponseTranslationTranscription>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAvatarsResponseAvatar>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAvatarsResponseAvatarCreationNotesWorkerError>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetResponseCreationNotesWorkerError>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetScenesResponseScene>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarVariant1, object>?, global::DId.GetAvatars1ResponseAvatar>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatars1ResponseAvatarSentimentVariant1, object>>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.GetAvatarByIdResponseSentimentVariant1, object>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetExpressivesResponseExpressive>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ListResourceClientKeysResponseItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateResponseVariant1TriggersChatEndWebhook>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetResponseVariant1TriggersChatEndWebhook>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.UpdateResponseVariant1TriggersChatEndWebhook>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.DeleteResponseVariant1TriggersChatEndWebhook>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateStreamResponseIceServer>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.Get1ResponseItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetDocumentsResponseItem>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.DeleteDocumentResponseItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.VoicesResponseItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.VoicesResponseItemLanguage>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.UploadAnImageResponseFace>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetFaceDetectionResponseFaceCrop>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetCreditsResponseCredit>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.ListResponseConsent>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAllSecretsResponseItem>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.GetAnimationsResponseAnimation>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DId.CreateStream1ResponseIceServer>? ListType91 { get; set; }
    }
}