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
    /// FilterSettingsDto
    /// </summary>
    [DataContract(Name = "FilterSettingsDto")]
    public partial class FilterSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterSettingsDto" /> class.
        /// </summary>
        /// <param name="timeRange">timeRange.</param>
        /// <param name="includeStatus">includeStatus.</param>
        /// <param name="includeAlertTypeIds">includeAlertTypeIds.</param>
        /// <param name="selectedTags">selectedTags.</param>
        public FilterSettingsDto(TimeRangeDto timeRange = default(TimeRangeDto), IncludeStatusDto includeStatus = default(IncludeStatusDto), List<string> includeAlertTypeIds = default(List<string>), List<TagDto> selectedTags = default(List<TagDto>))
        {
            this.TimeRange = timeRange;
            this.IncludeStatus = includeStatus;
            this.IncludeAlertTypeIds = includeAlertTypeIds;
            this.SelectedTags = selectedTags;
        }

        /// <summary>
        /// Gets or Sets TimeRange
        /// </summary>
        [DataMember(Name = "timeRange", EmitDefaultValue = false)]
        public TimeRangeDto TimeRange { get; set; }

        /// <summary>
        /// Gets or Sets IncludeStatus
        /// </summary>
        [DataMember(Name = "includeStatus", EmitDefaultValue = false)]
        public IncludeStatusDto IncludeStatus { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAlertTypeIds
        /// </summary>
        [DataMember(Name = "includeAlertTypeIds", EmitDefaultValue = true)]
        public List<string> IncludeAlertTypeIds { get; set; }

        /// <summary>
        /// Gets or Sets SelectedTags
        /// </summary>
        [DataMember(Name = "selectedTags", EmitDefaultValue = false)]
        public List<TagDto> SelectedTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilterSettingsDto {\n");
            sb.Append("  TimeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  IncludeStatus: ").Append(IncludeStatus).Append("\n");
            sb.Append("  IncludeAlertTypeIds: ").Append(IncludeAlertTypeIds).Append("\n");
            sb.Append("  SelectedTags: ").Append(SelectedTags).Append("\n");
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
