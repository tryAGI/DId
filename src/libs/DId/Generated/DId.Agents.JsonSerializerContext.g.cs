
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceOpenAI_d4d9abbdbe86a41f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceOpenAI_e131a922bef8293f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceOpenAI_21e79600dd34b970")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>), TypeInfoPropertyName = "CreateRequestLlmVariant6_3a9eb09a61432b36")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceOpenAI_82920c893e106c43")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceOpenAI_55b0e7e4a6df2d1c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatar_637c32a96c9767f9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_e177054a1a123a6e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI_fa442d7758e743da")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_602045e1a4e7ac9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogle_ece1aa9f67c8645b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar_54b8365fb9f20db9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI_402ad322b161a840")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI_553d8322b6452c66")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI_c8f2e94d9af219c8")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogle_329c22cab5394ecd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatar_283882696207e448")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI_8fad7572e7535074")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceOpenAI_ed2423a7a7012734")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_acf25956ddb401b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>), TypeInfoPropertyName = "GetResponseVariant1LlmGoogle_1140b839713e1dbf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatar_0c6ad5429f3026ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_4327448c8a8f3fc9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI_8ca43dde27c31d9d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_c55e40babcb4f4fe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogle_902306a7f01a1d1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatar_6351537e83565de0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI_fbbdb068e22a1766")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI_460668eab315e92d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_874fa76543854511")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogle_8040fb4fae77057a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceOpenAI_38f727912996757a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceOpenAI_2d47f78719f53130")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceOpenAI_2535d548218ffd68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>?), TypeInfoPropertyName = "CreateRequestLlmVariant6_72d8cbf21b6712f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceOpenAI_850d9da0f86b9f40")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceOpenAI_b498b336ab8bd129")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>?), TypeInfoPropertyName = "UpdateRequestLlmGoogle_7c8be2c0a38edbda")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatar_de5d998107078190")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_eccfb4449143f130")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI_ffcca9137591f01f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_2bfdd53d0d3c062b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogle_146be95261dda434")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar_cd309396290c3210")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI_60db2c128b912bc4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI_6ae3632149736c4f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI_05654cd10b084608")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogle_93faa8ce0640006b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatar_c81aab0c17111a06")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI_23422f2452fb2a9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceOpenAI_932d8dfca3150a5e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_a5be291b66a23723")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "GetResponseVariant1LlmGoogle_bc114ca75b603f26")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatar_507886860780214f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_4466c117a705ccff")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI_171bac21c8084af1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_dbfe1758f017019e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogle_09c571db3f701797")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatar_b841c0b3ee1c1e46")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI_373b704a9769bef4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI_06812a1a8a5a282f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_2021cb313d88f460")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogle_4b1a4b9c1a31bd1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JSONValue), TypeInfoPropertyName = "JSONValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.JSONValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DId.JSONValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutput), TypeInfoPropertyName = "ToolResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant1Type), TypeInfoPropertyName = "ToolResultOutputVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant2Type), TypeInfoPropertyName = "ToolResultOutputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IMessageRole), TypeInfoPropertyName = "IMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.IMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatPlan), TypeInfoPropertyName = "ILogicalChatPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatEndEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatEndEventDataEventType), TypeInfoPropertyName = "ChatEndEventDataEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventData), TypeInfoPropertyName = "TriggerEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventDataVariant2EventType), TypeInfoPropertyName = "TriggerEventDataVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequestEventType), TypeInfoPropertyName = "TestWebhookConfigurationRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequestAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>), TypeInfoPropertyName = "AnyOfCreateRequestPresenterPhotoAvatarCreateRequestPresenterVideoAvatarCreateRequestPresenterExpressiveAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarType), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarType), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarType), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Provider), TypeInfoPropertyName = "CreateRequestLlmVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Template), TypeInfoPropertyName = "CreateRequestLlmVariant1Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateRequestLlmVariant1PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Model), TypeInfoPropertyName = "CreateRequestLlmVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2Provider), TypeInfoPropertyName = "CreateRequestLlmVariant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2Template), TypeInfoPropertyName = "CreateRequestLlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateRequestLlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>), TypeInfoPropertyName = "AnyOfCreateRequestLlmVariant2CustomBasicCreateRequestLlmVariant2CustomOAuth22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomBasicType), TypeInfoPropertyName = "CreateRequestLlmVariant2CustomBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type), TypeInfoPropertyName = "CreateRequestLlmVariant2CustomOAuth2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3Template), TypeInfoPropertyName = "CreateRequestLlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateRequestLlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4Template), TypeInfoPropertyName = "CreateRequestLlmVariant4Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateRequestLlmVariant4PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Provider), TypeInfoPropertyName = "CreateRequestLlmVariant5Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Template), TypeInfoPropertyName = "CreateRequestLlmVariant5Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateRequestLlmVariant5PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Model), TypeInfoPropertyName = "CreateRequestLlmVariant5Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Provider), TypeInfoPropertyName = "CreateRequestLlmVariant6Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Template), TypeInfoPropertyName = "CreateRequestLlmVariant6Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateRequestLlmVariant6PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Model), TypeInfoPropertyName = "CreateRequestLlmVariant6Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.CreateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>), TypeInfoPropertyName = "AnyOfUpdateRequestPresenterPhotoAvatarUpdateRequestPresenterVideoAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarType), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarType), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>), TypeInfoPropertyName = "AnyOfUpdateRequestLlmOpenAIUpdateRequestLlmVariant2UpdateRequestLlmVariant3UpdateRequestLlmDIdUpdateRequestLlmGoogle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIProvider), TypeInfoPropertyName = "UpdateRequestLlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAITemplate), TypeInfoPropertyName = "UpdateRequestLlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIModel), TypeInfoPropertyName = "UpdateRequestLlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2Template), TypeInfoPropertyName = "UpdateRequestLlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3Template), TypeInfoPropertyName = "UpdateRequestLlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdProvider), TypeInfoPropertyName = "UpdateRequestLlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdTemplate), TypeInfoPropertyName = "UpdateRequestLlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateRequestLlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdModel), TypeInfoPropertyName = "UpdateRequestLlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleProvider), TypeInfoPropertyName = "UpdateRequestLlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleTemplate), TypeInfoPropertyName = "UpdateRequestLlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateRequestLlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleModel), TypeInfoPropertyName = "UpdateRequestLlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UpdateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestTriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsSortBy), TypeInfoPropertyName = "ListMyAgentsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsOrder), TypeInfoPropertyName = "ListMyAgentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateResponseVariant1, global::DId.CreateResponseVariant2>), TypeInfoPropertyName = "AllOfCreateResponseVariant1CreateResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider), TypeInfoPropertyName = "CreateResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate), TypeInfoPropertyName = "CreateResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIModel), TypeInfoPropertyName = "CreateResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2Template), TypeInfoPropertyName = "CreateResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3Template), TypeInfoPropertyName = "CreateResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdProvider), TypeInfoPropertyName = "CreateResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdTemplate), TypeInfoPropertyName = "CreateResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdModel), TypeInfoPropertyName = "CreateResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleProvider), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource), TypeInfoPropertyName = "CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleModel), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Provider), TypeInfoPropertyName = "CreateResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1KnowledgeProvider), TypeInfoPropertyName = "CreateResponseVariant1KnowledgeProvider2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>), TypeInfoPropertyName = "AllOfListMyAgentsResponseAgentVariant1ListMyAgentsResponseAgentVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1KnowledgeProvider2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>), TypeInfoPropertyName = "AllOfGetResponseVariant1GetResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIProvider), TypeInfoPropertyName = "GetResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAITemplate), TypeInfoPropertyName = "GetResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIModel), TypeInfoPropertyName = "GetResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2Template), TypeInfoPropertyName = "GetResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3Template), TypeInfoPropertyName = "GetResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdProvider), TypeInfoPropertyName = "GetResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdTemplate), TypeInfoPropertyName = "GetResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdModel), TypeInfoPropertyName = "GetResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleProvider), TypeInfoPropertyName = "GetResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleTemplate), TypeInfoPropertyName = "GetResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource), TypeInfoPropertyName = "GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleModel), TypeInfoPropertyName = "GetResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Provider), TypeInfoPropertyName = "GetResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1KnowledgeProvider), TypeInfoPropertyName = "GetResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.GetResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>), TypeInfoPropertyName = "AllOfUpdateResponseVariant1UpdateResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceOpenAI_d4d9abbdbe86a41f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceOpenAI_e131a922bef8293f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceOpenAI_21e79600dd34b970")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>), TypeInfoPropertyName = "CreateRequestLlmVariant6_3a9eb09a61432b36")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceOpenAI_82920c893e106c43")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceOpenAI_55b0e7e4a6df2d1c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatar_637c32a96c9767f9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_e177054a1a123a6e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI_fa442d7758e743da")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_602045e1a4e7ac9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogle_ece1aa9f67c8645b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar_54b8365fb9f20db9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI_402ad322b161a840")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI_553d8322b6452c66")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI_c8f2e94d9af219c8")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogle_329c22cab5394ecd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatar_283882696207e448")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI_8fad7572e7535074")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceOpenAI_ed2423a7a7012734")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_acf25956ddb401b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>), TypeInfoPropertyName = "GetResponseVariant1LlmGoogle_1140b839713e1dbf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatar_0c6ad5429f3026ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_4327448c8a8f3fc9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI_8ca43dde27c31d9d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_c55e40babcb4f4fe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogle_902306a7f01a1d1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatar_6351537e83565de0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI_fbbdb068e22a1766")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI_460668eab315e92d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_874fa76543854511")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogle_8040fb4fae77057a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateRequestPresenterPhotoAvatarVoiceOpenAI_38f727912996757a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateRequestPresenterVideoAvatarVoiceOpenAI_2d47f78719f53130")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateRequestPresenterExpressiveAvatarVoiceOpenAI_2535d548218ffd68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>?), TypeInfoPropertyName = "CreateRequestLlmVariant6_72d8cbf21b6712f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateRequestPresenterPhotoAvatarVoiceOpenAI_850d9da0f86b9f40")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateRequestPresenterVideoAvatarVoiceOpenAI_b498b336ab8bd129")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>?), TypeInfoPropertyName = "UpdateRequestLlmGoogle_7c8be2c0a38edbda")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatar_de5d998107078190")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_eccfb4449143f130")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI_ffcca9137591f01f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_2bfdd53d0d3c062b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "CreateResponseVariant1LlmGoogle_146be95261dda434")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar_cd309396290c3210")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI_60db2c128b912bc4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI_6ae3632149736c4f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI_05654cd10b084608")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>?), TypeInfoPropertyName = "ListMyAgentsResponseAgentVariant1LlmGoogle_93faa8ce0640006b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatar_c81aab0c17111a06")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI_23422f2452fb2a9e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "GetResponseVariant1PresenterVideoAvatarVoiceOpenAI_932d8dfca3150a5e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_a5be291b66a23723")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "GetResponseVariant1LlmGoogle_bc114ca75b603f26")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatar_507886860780214f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI_4466c117a705ccff")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI_171bac21c8084af1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_dbfe1758f017019e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogle_09c571db3f701797")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatar_b841c0b3ee1c1e46")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI_373b704a9769bef4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI_06812a1a8a5a282f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>?), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI_2021cb313d88f460")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>?), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogle_4b1a4b9c1a31bd1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType), TypeInfoPropertyName = "UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider), TypeInfoPropertyName = "UpdateResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate), TypeInfoPropertyName = "UpdateResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel), TypeInfoPropertyName = "UpdateResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2Template), TypeInfoPropertyName = "UpdateResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3Template), TypeInfoPropertyName = "UpdateResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdProvider), TypeInfoPropertyName = "UpdateResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate), TypeInfoPropertyName = "UpdateResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdModel), TypeInfoPropertyName = "UpdateResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource), TypeInfoPropertyName = "UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleModel), TypeInfoPropertyName = "UpdateResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Provider), TypeInfoPropertyName = "UpdateResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1KnowledgeProvider), TypeInfoPropertyName = "UpdateResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.UpdateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>), TypeInfoPropertyName = "AllOfDeleteResponseVariant1DeleteResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType), TypeInfoPropertyName = "DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider), TypeInfoPropertyName = "DeleteResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate), TypeInfoPropertyName = "DeleteResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel), TypeInfoPropertyName = "DeleteResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2Template), TypeInfoPropertyName = "DeleteResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3Template), TypeInfoPropertyName = "DeleteResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource), TypeInfoPropertyName = "DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdProvider), TypeInfoPropertyName = "DeleteResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate), TypeInfoPropertyName = "DeleteResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource), TypeInfoPropertyName = "DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdModel), TypeInfoPropertyName = "DeleteResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource), TypeInfoPropertyName = "DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleModel), TypeInfoPropertyName = "DeleteResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Provider), TypeInfoPropertyName = "DeleteResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Knowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1KnowledgeProvider), TypeInfoPropertyName = "DeleteResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Triggers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1TriggersChatEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DId.DeleteResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1TriggersChatEndWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1TriggersChatEndWebhookAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.JSONValue?), TypeInfoPropertyName = "NullableJSONValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutput?), TypeInfoPropertyName = "NullableToolResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant1Type?), TypeInfoPropertyName = "NullableToolResultOutputVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ToolResultOutputVariant2Type?), TypeInfoPropertyName = "NullableToolResultOutputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.IMessageRole?), TypeInfoPropertyName = "NullableIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ILogicalChatPlan?), TypeInfoPropertyName = "NullableILogicalChatPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ChatEndEventDataEventType?), TypeInfoPropertyName = "NullableChatEndEventDataEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventData?), TypeInfoPropertyName = "NullableTriggerEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TriggerEventDataVariant2EventType?), TypeInfoPropertyName = "NullableTriggerEventDataVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.TestWebhookConfigurationRequestEventType?), TypeInfoPropertyName = "NullableTestWebhookConfigurationRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>?), TypeInfoPropertyName = "NullableAnyOfCreateRequestPresenterPhotoAvatarCreateRequestPresenterVideoAvatarCreateRequestPresenterExpressiveAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableCreateRequestPresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableCreateRequestPresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableCreateRequestPresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableCreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableCreateRequestPresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarType?), TypeInfoPropertyName = "NullableCreateRequestPresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableCreateRequestPresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableCreateRequestPresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableCreateRequestPresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableCreateRequestPresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarType?), TypeInfoPropertyName = "NullableCreateRequestPresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableCreateRequestPresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableCreateRequestPresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableCreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableCreateRequestPresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Provider?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Template?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant1Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant1PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant1Model?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2Provider?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2Template?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>?), TypeInfoPropertyName = "NullableAnyOfCreateRequestLlmVariant2CustomBasicCreateRequestLlmVariant2CustomOAuth22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomBasicType?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant2CustomBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant2CustomOAuth2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3Template?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4Template?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant4Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant4PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Provider?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant5Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Template?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant5Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant5PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant5Model?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant5Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Provider?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant6Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Template?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant6Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant6PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateRequestLlmVariant6Model?), TypeInfoPropertyName = "NullableCreateRequestLlmVariant6Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AnyOf<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>?), TypeInfoPropertyName = "NullableAnyOfUpdateRequestPresenterPhotoAvatarUpdateRequestPresenterVideoAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableUpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableUpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableUpdateRequestPresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIProvider?), TypeInfoPropertyName = "NullableUpdateRequestLlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAITemplate?), TypeInfoPropertyName = "NullableUpdateRequestLlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmOpenAIModel?), TypeInfoPropertyName = "NullableUpdateRequestLlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2Template?), TypeInfoPropertyName = "NullableUpdateRequestLlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateRequestLlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3Template?), TypeInfoPropertyName = "NullableUpdateRequestLlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateRequestLlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdProvider?), TypeInfoPropertyName = "NullableUpdateRequestLlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdTemplate?), TypeInfoPropertyName = "NullableUpdateRequestLlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateRequestLlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmDIdModel?), TypeInfoPropertyName = "NullableUpdateRequestLlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleProvider?), TypeInfoPropertyName = "NullableUpdateRequestLlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleTemplate?), TypeInfoPropertyName = "NullableUpdateRequestLlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateRequestLlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateRequestLlmGoogleModel?), TypeInfoPropertyName = "NullableUpdateRequestLlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsSortBy?), TypeInfoPropertyName = "NullableListMyAgentsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsOrder?), TypeInfoPropertyName = "NullableListMyAgentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.CreateResponseVariant1, global::DId.CreateResponseVariant2>?), TypeInfoPropertyName = "NullableAllOfCreateResponseVariant1CreateResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableCreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmOpenAIModel?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2Template?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3Template?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdProvider?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdTemplate?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmDIdModel?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleProvider?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1LlmGoogleModel?), TypeInfoPropertyName = "NullableCreateResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1Provider?), TypeInfoPropertyName = "NullableCreateResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.CreateResponseVariant1KnowledgeProvider?), TypeInfoPropertyName = "NullableCreateResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>?), TypeInfoPropertyName = "NullableAllOfListMyAgentsResponseAgentVariant1ListMyAgentsResponseAgentVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider?), TypeInfoPropertyName = "NullableListMyAgentsResponseAgentVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>?), TypeInfoPropertyName = "NullableAllOfGetResponseVariant1GetResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableGetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIProvider?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAITemplate?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmOpenAIModel?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2Template?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3Template?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdProvider?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdTemplate?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmDIdModel?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleProvider?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleTemplate?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1LlmGoogleModel?), TypeInfoPropertyName = "NullableGetResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1Provider?), TypeInfoPropertyName = "NullableGetResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.GetResponseVariant1KnowledgeProvider?), TypeInfoPropertyName = "NullableGetResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>?), TypeInfoPropertyName = "NullableAllOfUpdateResponseVariant1UpdateResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableUpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2Template?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3Template?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdProvider?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmDIdModel?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1LlmGoogleModel?), TypeInfoPropertyName = "NullableUpdateResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1Provider?), TypeInfoPropertyName = "NullableUpdateResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.UpdateResponseVariant1KnowledgeProvider?), TypeInfoPropertyName = "NullableUpdateResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.AllOf<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>?), TypeInfoPropertyName = "NullableAllOfDeleteResponseVariant1DeleteResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterPhotoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterVideoAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterExpressiveAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?), TypeInfoPropertyName = "NullableDeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmOpenAIProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmOpenAITemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmOpenAIModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2Template?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmVariant2Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3Template?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmVariant3Template2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdProvider?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmDIdProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmDIdTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmDIdModel?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmDIdModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmGoogleProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmGoogleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1LlmGoogleModel?), TypeInfoPropertyName = "NullableDeleteResponseVariant1LlmGoogleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1Provider?), TypeInfoPropertyName = "NullableDeleteResponseVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DId.DeleteResponseVariant1KnowledgeProvider?), TypeInfoPropertyName = "NullableDeleteResponseVariant1KnowledgeProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.JSONValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.IMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UpdateRequestTriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.CreateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.AllOf<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.ListMyAgentsResponseAgentVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.GetResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.UpdateResponseVariant1TriggersChatEndWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DId.DeleteResponseVariant1TriggersChatEndWebhook>))]
    internal sealed partial class AgentsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DId.JsonConverters.JSONValueJsonConverter());
            options.Converters.Add(new global::DId.JsonConverters.ToolResultOutputJsonConverter());
            options.Converters.Add(new global::DId.JsonConverters.TriggerEventDataJsonConverter());
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
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatar, global::DId.CreateRequestPresenterVideoAvatar, global::DId.CreateRequestPresenterExpressiveAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant1, global::DId.CreateRequestLlmVariant2, global::DId.CreateRequestLlmVariant3, global::DId.CreateRequestLlmVariant4, global::DId.CreateRequestLlmVariant5, global::DId.CreateRequestLlmVariant6>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateRequestLlmVariant2CustomBasic, global::DId.CreateRequestLlmVariant2CustomOAuth2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterPhotoAvatar, global::DId.UpdateRequestPresenterVideoAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateRequestLlmOpenAI, global::DId.UpdateRequestLlmVariant2, global::DId.UpdateRequestLlmVariant3, global::DId.UpdateRequestLlmDId, global::DId.UpdateRequestLlmGoogle>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.CreateResponseVariant1, global::DId.CreateResponseVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterPhotoAvatar, global::DId.CreateResponseVariant1PresenterVideoAvatar, global::DId.CreateResponseVariant1PresenterExpressiveAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.CreateResponseVariant1LlmOpenAI, global::DId.CreateResponseVariant1LlmVariant2, global::DId.CreateResponseVariant1LlmVariant3, global::DId.CreateResponseVariant1LlmDId, global::DId.CreateResponseVariant1LlmGoogle>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1, global::DId.ListMyAgentsResponseAgentVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatar, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAI, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2, global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3, global::DId.ListMyAgentsResponseAgentVariant1LlmDId, global::DId.ListMyAgentsResponseAgentVariant1LlmGoogle>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.GetResponseVariant1, global::DId.GetResponseVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterPhotoAvatar, global::DId.GetResponseVariant1PresenterVideoAvatar, global::DId.GetResponseVariant1PresenterExpressiveAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.GetResponseVariant1LlmOpenAI, global::DId.GetResponseVariant1LlmVariant2, global::DId.GetResponseVariant1LlmVariant3, global::DId.GetResponseVariant1LlmDId, global::DId.GetResponseVariant1LlmGoogle>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.UpdateResponseVariant1, global::DId.UpdateResponseVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatar, global::DId.UpdateResponseVariant1PresenterVideoAvatar, global::DId.UpdateResponseVariant1PresenterExpressiveAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.UpdateResponseVariant1LlmOpenAI, global::DId.UpdateResponseVariant1LlmVariant2, global::DId.UpdateResponseVariant1LlmVariant3, global::DId.UpdateResponseVariant1LlmDId, global::DId.UpdateResponseVariant1LlmGoogle>());
            options.Converters.Add(new global::DId.JsonConverters.AllOfJsonConverter<global::DId.DeleteResponseVariant1, global::DId.DeleteResponseVariant2>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatar, global::DId.DeleteResponseVariant1PresenterVideoAvatar, global::DId.DeleteResponseVariant1PresenterExpressiveAvatar>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>());
            options.Converters.Add(new global::DId.JsonConverters.AnyOfJsonConverter<global::DId.DeleteResponseVariant1LlmOpenAI, global::DId.DeleteResponseVariant1LlmVariant2, global::DId.DeleteResponseVariant1LlmVariant3, global::DId.DeleteResponseVariant1LlmDId, global::DId.DeleteResponseVariant1LlmGoogle>());
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
                    typeToConvert == typeof(global::DId.ToolResultOutputVariant1Type)

                    || typeToConvert == typeof(global::DId.ToolResultOutputVariant1Type?)

                    || typeToConvert == typeof(global::DId.ToolResultOutputVariant2Type)

                    || typeToConvert == typeof(global::DId.ToolResultOutputVariant2Type?)

                    || typeToConvert == typeof(global::DId.IMessageRole)

                    || typeToConvert == typeof(global::DId.IMessageRole?)

                    || typeToConvert == typeof(global::DId.ILogicalChatPlan)

                    || typeToConvert == typeof(global::DId.ILogicalChatPlan?)

                    || typeToConvert == typeof(global::DId.ChatEndEventDataEventType)

                    || typeToConvert == typeof(global::DId.ChatEndEventDataEventType?)

                    || typeToConvert == typeof(global::DId.TriggerEventDataVariant2EventType)

                    || typeToConvert == typeof(global::DId.TriggerEventDataVariant2EventType?)

                    || typeToConvert == typeof(global::DId.TestWebhookConfigurationRequestEventType)

                    || typeToConvert == typeof(global::DId.TestWebhookConfigurationRequestEventType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Provider)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Provider?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Template)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Template?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Model)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Model?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Provider)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Provider?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Template)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomBasicType)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomBasicType?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant3Template)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant4Template)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant4Template?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Provider)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Provider?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Template)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Template?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Model)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Model?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Provider)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Provider?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Template)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Template?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Model)

                    || typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Model?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIProvider)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIProvider?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAITemplate)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAITemplate?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIModel)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIModel?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2Template)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3Template)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdProvider)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdProvider?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdTemplate)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdTemplate?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdModel)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmDIdModel?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleProvider)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleProvider?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleTemplate)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleTemplate?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleModel)

                    || typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleModel?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsSortBy)

                    || typeToConvert == typeof(global::DId.ListMyAgentsSortBy?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsOrder)

                    || typeToConvert == typeof(global::DId.ListMyAgentsOrder?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIModel)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIModel?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2Template)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3Template)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdProvider)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdProvider?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdTemplate)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdTemplate?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdModel)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdModel?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleProvider)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleProvider?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleModel)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleModel?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1Provider)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1Provider?)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1KnowledgeProvider)

                    || typeToConvert == typeof(global::DId.CreateResponseVariant1KnowledgeProvider?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider?)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider)

                    || typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIProvider)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIProvider?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAITemplate)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAITemplate?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIModel)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIModel?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2Template)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3Template)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdProvider)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdProvider?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdTemplate)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdTemplate?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdModel)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdModel?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleProvider)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleProvider?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleTemplate)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleTemplate?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleModel)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleModel?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1Provider)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1Provider?)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1KnowledgeProvider)

                    || typeToConvert == typeof(global::DId.GetResponseVariant1KnowledgeProvider?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2Template)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3Template)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdProvider)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdProvider?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdModel)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdModel?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleModel)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleModel?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1Provider)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1Provider?)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1KnowledgeProvider)

                    || typeToConvert == typeof(global::DId.UpdateResponseVariant1KnowledgeProvider?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2Template)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2Template?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3Template)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3Template?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdProvider)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdProvider?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdModel)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdModel?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleModel)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleModel?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1Provider)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1Provider?)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1KnowledgeProvider)

                    || typeToConvert == typeof(global::DId.DeleteResponseVariant1KnowledgeProvider?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DId.ToolResultOutputVariant1Type))
                {
                    return new global::DId.JsonConverters.ToolResultOutputVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ToolResultOutputVariant1Type?))
                {
                    return new global::DId.JsonConverters.ToolResultOutputVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ToolResultOutputVariant2Type))
                {
                    return new global::DId.JsonConverters.ToolResultOutputVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ToolResultOutputVariant2Type?))
                {
                    return new global::DId.JsonConverters.ToolResultOutputVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.IMessageRole))
                {
                    return new global::DId.JsonConverters.IMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.IMessageRole?))
                {
                    return new global::DId.JsonConverters.IMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ILogicalChatPlan))
                {
                    return new global::DId.JsonConverters.ILogicalChatPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ILogicalChatPlan?))
                {
                    return new global::DId.JsonConverters.ILogicalChatPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatEndEventDataEventType))
                {
                    return new global::DId.JsonConverters.ChatEndEventDataEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ChatEndEventDataEventType?))
                {
                    return new global::DId.JsonConverters.ChatEndEventDataEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.TriggerEventDataVariant2EventType))
                {
                    return new global::DId.JsonConverters.TriggerEventDataVariant2EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.TriggerEventDataVariant2EventType?))
                {
                    return new global::DId.JsonConverters.TriggerEventDataVariant2EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.TestWebhookConfigurationRequestEventType))
                {
                    return new global::DId.JsonConverters.TestWebhookConfigurationRequestEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.TestWebhookConfigurationRequestEventType?))
                {
                    return new global::DId.JsonConverters.TestWebhookConfigurationRequestEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestPresenterExpressiveAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.CreateRequestPresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Provider))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Provider?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Template))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Template?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Model))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant1Model?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant1ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Provider))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Provider?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Template))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomBasicType))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2CustomBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomBasicType?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2CustomBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2CustomOAuth2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant2CustomOAuth2Type?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant2CustomOAuth2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant3Template))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant4Template))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant4TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant4Template?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant4TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant4PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant4PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant4PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Provider))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Provider?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Template))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Template?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Model))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant5Model?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant5ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Provider))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Provider?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Template))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Template?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Model))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6ModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateRequestLlmVariant6Model?))
                {
                    return new global::DId.JsonConverters.CreateRequestLlmVariant6ModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestPresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.UpdateRequestPresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIProvider))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAIProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIProvider?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAIProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAITemplate))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAITemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAITemplate?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAITemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIModel))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAIModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmOpenAIModel?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmOpenAIModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2Template))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3Template))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdProvider))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdProvider?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdTemplate))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdTemplate?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdModel))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmDIdModel?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmDIdModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleProvider))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGoogleProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleProvider?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGoogleProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleTemplate))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGoogleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleTemplate?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGoogleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGooglePromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGooglePromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleModel))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGoogleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateRequestLlmGoogleModel?))
                {
                    return new global::DId.JsonConverters.UpdateRequestLlmGoogleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsSortBy))
                {
                    return new global::DId.JsonConverters.ListMyAgentsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsSortBy?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsOrder))
                {
                    return new global::DId.JsonConverters.ListMyAgentsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsOrder?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIProvider?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAITemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAITemplate?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAITemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIModel))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmOpenAIModel?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmOpenAIModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2Template))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3Template))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdProvider))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdProvider?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdTemplate))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdTemplate?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdModel))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmDIdModel?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmDIdModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleProvider))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGoogleProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleProvider?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGoogleProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGoogleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleTemplate?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGoogleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleModel))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGoogleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1LlmGoogleModel?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1LlmGoogleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1Provider))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1Provider?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1KnowledgeProvider))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1KnowledgeProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.CreateResponseVariant1KnowledgeProvider?))
                {
                    return new global::DId.JsonConverters.CreateResponseVariant1KnowledgeProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIProvider?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAITemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAITemplate?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAITemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmOpenAIModel?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmOpenAIModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdProvider?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdTemplate?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmDIdModel?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmDIdModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleProvider?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1LlmGoogleModel?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1LlmGoogleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1Provider?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1KnowledgeProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.ListMyAgentsResponseAgentVariant1KnowledgeProvider?))
                {
                    return new global::DId.JsonConverters.ListMyAgentsResponseAgentVariant1KnowledgeProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIProvider))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAIProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIProvider?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAIProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAITemplate))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAITemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAITemplate?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAITemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIModel))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAIModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmOpenAIModel?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmOpenAIModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2Template))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3Template))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdProvider))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdProvider?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdTemplate))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdTemplate?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdModel))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmDIdModel?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmDIdModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleProvider))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGoogleProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleProvider?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGoogleProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleTemplate))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGoogleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleTemplate?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGoogleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleModel))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGoogleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1LlmGoogleModel?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1LlmGoogleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1Provider))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1Provider?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1KnowledgeProvider))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1KnowledgeProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.GetResponseVariant1KnowledgeProvider?))
                {
                    return new global::DId.JsonConverters.GetResponseVariant1KnowledgeProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIProvider?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAITemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAITemplate?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAITemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmOpenAIModel?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmOpenAIModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2Template))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3Template))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdProvider))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdProvider?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdTemplate?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdModel))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmDIdModel?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmDIdModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleProvider?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleTemplate?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleModel))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1LlmGoogleModel?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1LlmGoogleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1Provider))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1Provider?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1KnowledgeProvider))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1KnowledgeProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.UpdateResponseVariant1KnowledgeProvider?))
                {
                    return new global::DId.JsonConverters.UpdateResponseVariant1KnowledgeProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIProvider?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAITemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAITemplate?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAITemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmOpenAIModel?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmOpenAIModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2Template))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2Template?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant2PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3Template))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3TemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3Template?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3TemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmVariant3PromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdProvider))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdProvider?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdTemplate?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdPromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdModel))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmDIdModel?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmDIdModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleProvider?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleTemplate?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSource?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGooglePromptCustomizationKnowledgeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleModel))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1LlmGoogleModel?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1LlmGoogleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1Provider))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1Provider?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1KnowledgeProvider))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1KnowledgeProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::DId.DeleteResponseVariant1KnowledgeProvider?))
                {
                    return new global::DId.JsonConverters.DeleteResponseVariant1KnowledgeProviderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new AgentsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}