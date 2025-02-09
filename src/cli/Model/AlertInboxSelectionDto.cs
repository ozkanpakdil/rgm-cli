/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cli.Client.OpenAPIDateConverter;

namespace cli.Model
{
    /// <summary>
    /// AlertInboxSelectionDto
    /// </summary>
    [DataContract(Name = "AlertInboxSelectionDto")]
    public partial class AlertInboxSelectionDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertInboxSelectionDto" /> class.
        /// </summary>
        /// <param name="lastUpdate">lastUpdate.</param>
        /// <param name="selectedGroupIds">selectedGroupIds.</param>
        /// <param name="selectedAlertIds">selectedAlertIds.</param>
        /// <param name="filterSettings">filterSettings.</param>
        /// <param name="channelInstanceRefs">channelInstanceRefs.</param>
        public AlertInboxSelectionDto(string lastUpdate = default(string), List<GroupIdDto> selectedGroupIds = default(List<GroupIdDto>), List<QualifiedAlertIdDto> selectedAlertIds = default(List<QualifiedAlertIdDto>), FilterSettingsDto filterSettings = default(FilterSettingsDto), List<string> channelInstanceRefs = default(List<string>))
        {
            this.LastUpdate = lastUpdate;
            this.SelectedGroupIds = selectedGroupIds;
            this.SelectedAlertIds = selectedAlertIds;
            this.FilterSettings = filterSettings;
            this.ChannelInstanceRefs = channelInstanceRefs;
        }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = true)]
        public string LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets SelectedGroupIds
        /// </summary>
        [DataMember(Name = "selectedGroupIds", EmitDefaultValue = true)]
        public List<GroupIdDto> SelectedGroupIds { get; set; }

        /// <summary>
        /// Gets or Sets SelectedAlertIds
        /// </summary>
        [DataMember(Name = "selectedAlertIds", EmitDefaultValue = true)]
        public List<QualifiedAlertIdDto> SelectedAlertIds { get; set; }

        /// <summary>
        /// Gets or Sets FilterSettings
        /// </summary>
        [DataMember(Name = "filterSettings", EmitDefaultValue = false)]
        public FilterSettingsDto FilterSettings { get; set; }

        /// <summary>
        /// Gets or Sets ChannelInstanceRefs
        /// </summary>
        [DataMember(Name = "channelInstanceRefs", EmitDefaultValue = true)]
        public List<string> ChannelInstanceRefs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlertInboxSelectionDto {\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  SelectedGroupIds: ").Append(SelectedGroupIds).Append("\n");
            sb.Append("  SelectedAlertIds: ").Append(SelectedAlertIds).Append("\n");
            sb.Append("  FilterSettings: ").Append(FilterSettings).Append("\n");
            sb.Append("  ChannelInstanceRefs: ").Append(ChannelInstanceRefs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
