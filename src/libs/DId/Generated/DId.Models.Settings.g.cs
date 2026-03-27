
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Settings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public global::DId.SettingsLogo? Logo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::DId.SettingsAgents? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents_insights_is_enabled")]
        public bool? AgentsInsightsIsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatars")]
        public global::DId.SettingsAvatars? Avatars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="agents"></param>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="avatars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Settings(
            global::DId.SettingsLogo? logo,
            global::DId.SettingsAgents? agents,
            bool? agentsInsightsIsEnabled,
            global::DId.SettingsAvatars? avatars)
        {
            this.Logo = logo;
            this.Agents = agents;
            this.AgentsInsightsIsEnabled = agentsInsightsIsEnabled;
            this.Avatars = avatars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
        }
    }
}