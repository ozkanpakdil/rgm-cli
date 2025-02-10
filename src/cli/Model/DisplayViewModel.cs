/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace cli.Model;

/// <summary>
///     DisplayViewModel
/// </summary>
[DataContract(Name = "DisplayViewModel")]
public class DisplayViewModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DisplayViewModel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DisplayViewModel()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DisplayViewModel" /> class.
    /// </summary>
    /// <param name="timeFormatOption">timeFormatOption (required).</param>
    /// <param name="customReportLogo">customReportLogo (required).</param>
    /// <param name="failoverClusterDisplayOption">failoverClusterDisplayOption (required).</param>
    /// <param name="showSuspendedEntitiesOnGlobalDashboard">showSuspendedEntitiesOnGlobalDashboard (required).</param>
    /// <param name="forceErroredEntitiesOnGlobalDashboard">forceErroredEntitiesOnGlobalDashboard (required).</param>
    public DisplayViewModel(string timeFormatOption = default, string customReportLogo = default,
        FailoverClusterDisplayOption failoverClusterDisplayOption = default,
        bool showSuspendedEntitiesOnGlobalDashboard = default, bool forceErroredEntitiesOnGlobalDashboard = default)
    {
        // to ensure "timeFormatOption" is required (not null)
        if (timeFormatOption == null)
            throw new ArgumentNullException(
                "timeFormatOption is a required property for DisplayViewModel and cannot be null");
        TimeFormatOption = timeFormatOption;
        // to ensure "customReportLogo" is required (not null)
        if (customReportLogo == null)
            throw new ArgumentNullException(
                "customReportLogo is a required property for DisplayViewModel and cannot be null");
        CustomReportLogo = customReportLogo;
        FailoverClusterDisplayOption = failoverClusterDisplayOption;
        ShowSuspendedEntitiesOnGlobalDashboard = showSuspendedEntitiesOnGlobalDashboard;
        ForceErroredEntitiesOnGlobalDashboard = forceErroredEntitiesOnGlobalDashboard;
    }

    /// <summary>
    ///     Gets or Sets FailoverClusterDisplayOption
    /// </summary>
    [DataMember(Name = "failoverClusterDisplayOption", IsRequired = true, EmitDefaultValue = true)]
    public FailoverClusterDisplayOption FailoverClusterDisplayOption { get; set; }

    /// <summary>
    ///     Gets or Sets TimeFormatOption
    /// </summary>
    [DataMember(Name = "timeFormatOption", IsRequired = true, EmitDefaultValue = true)]
    public string TimeFormatOption { get; set; }

    /// <summary>
    ///     Gets or Sets CustomReportLogo
    /// </summary>
    [DataMember(Name = "customReportLogo", IsRequired = true, EmitDefaultValue = true)]
    public string CustomReportLogo { get; set; }

    /// <summary>
    ///     Gets or Sets ShowSuspendedEntitiesOnGlobalDashboard
    /// </summary>
    [DataMember(Name = "showSuspendedEntitiesOnGlobalDashboard", IsRequired = true, EmitDefaultValue = true)]
    public bool ShowSuspendedEntitiesOnGlobalDashboard { get; set; }

    /// <summary>
    ///     Gets or Sets ForceErroredEntitiesOnGlobalDashboard
    /// </summary>
    [DataMember(Name = "forceErroredEntitiesOnGlobalDashboard", IsRequired = true, EmitDefaultValue = true)]
    public bool ForceErroredEntitiesOnGlobalDashboard { get; set; }

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
        sb.Append("class DisplayViewModel {\n");
        sb.Append("  TimeFormatOption: ").Append(TimeFormatOption).Append("\n");
        sb.Append("  CustomReportLogo: ").Append(CustomReportLogo).Append("\n");
        sb.Append("  FailoverClusterDisplayOption: ").Append(FailoverClusterDisplayOption).Append("\n");
        sb.Append("  ShowSuspendedEntitiesOnGlobalDashboard: ").Append(ShowSuspendedEntitiesOnGlobalDashboard)
            .Append("\n");
        sb.Append("  ForceErroredEntitiesOnGlobalDashboard: ").Append(ForceErroredEntitiesOnGlobalDashboard)
            .Append("\n");
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