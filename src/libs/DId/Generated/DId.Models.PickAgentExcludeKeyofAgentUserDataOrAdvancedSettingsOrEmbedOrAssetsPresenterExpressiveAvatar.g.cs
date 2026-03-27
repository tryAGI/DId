
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarTypeJsonConverter))]
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DId.JsonConverters.AnyOfJsonConverter<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>))]
        public global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        /// <param name="presenterId">
        /// Id of avatar that will be shown for user
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar(
            string presenterId,
            global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarType type,
            global::DId.AnyOf<global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceMicrosoft, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceElevenLabs, global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarVoiceOpenAI>? voice,
            global::DId.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatarBackground? background)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Type = type;
            this.Voice = voice;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar" /> class.
        /// </summary>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar()
        {
        }
    }
}