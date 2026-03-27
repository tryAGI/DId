
#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalSettingsRequestDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents_insights_is_enabled")]
        public bool? AgentsInsightsIsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public global::DId.ExternalSettingsRequestDTOLogo? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSettingsRequestDTO" /> class.
        /// </summary>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="logo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalSettingsRequestDTO(
            bool? agentsInsightsIsEnabled,
            global::DId.ExternalSettingsRequestDTOLogo? logo)
        {
            this.AgentsInsightsIsEnabled = agentsInsightsIsEnabled;
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSettingsRequestDTO" /> class.
        /// </summary>
        public ExternalSettingsRequestDTO()
        {
        }
    }
}