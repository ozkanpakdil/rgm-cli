/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace cli.Model;

/// <summary>
///     FilterSettingsDto
/// </summary>
[DataContract(Name = "FilterSettingsDto")]
public class FilterSettingsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FilterSettingsDto" /> class.
    /// </summary>
    /// <param name="timeRange">timeRange.</param>
    /// <param name="includeStatus">includeStatus.</param>
    /// <param name="includeAlertTypeIds">includeAlertTypeIds.</param>
    /// <param name="selectedTags">selectedTags.</param>
    public FilterSettingsDto(TimeRangeDto timeRange = default, IncludeStatusDto includeStatus = default,
        List<string> includeAlertTypeIds = default, List<TagDto> selectedTags = default)
    {
        TimeRange = timeRange;
        IncludeStatus = includeStatus;
        IncludeAlertTypeIds = includeAlertTypeIds;
        SelectedTags = selectedTags;
    }

    /// <summary>
    ///     Gets or Sets TimeRange
    /// </summary>
    [DataMember(Name = "timeRange", EmitDefaultValue = false)]
    public TimeRangeDto TimeRange { get; set; }

    /// <summary>
    ///     Gets or Sets IncludeStatus
    /// </summary>
    [DataMember(Name = "includeStatus", EmitDefaultValue = false)]
    public IncludeStatusDto IncludeStatus { get; set; }

    /// <summary>
    ///     Gets or Sets IncludeAlertTypeIds
    /// </summary>
    [DataMember(Name = "includeAlertTypeIds", EmitDefaultValue = true)]
    public List<string> IncludeAlertTypeIds { get; set; }

    /// <summary>
    ///     Gets or Sets SelectedTags
    /// </summary>
    [DataMember(Name = "selectedTags", EmitDefaultValue = false)]
    public List<TagDto> SelectedTags { get; set; }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FilterSettingsDto {\n");
        sb.Append("  TimeRange: ").Append(TimeRange).Append("\n");
        sb.Append("  IncludeStatus: ").Append(IncludeStatus).Append("\n");
        sb.Append("  IncludeAlertTypeIds: ").Append(IncludeAlertTypeIds).Append("\n");
        sb.Append("  SelectedTags: ").Append(SelectedTags).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    ///     Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}