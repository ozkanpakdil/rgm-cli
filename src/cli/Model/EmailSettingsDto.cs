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
///     EmailSettingsDto
/// </summary>
[DataContract(Name = "EmailSettingsDto")]
public class EmailSettingsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="EmailSettingsDto" /> class.
    /// </summary>
    /// <param name="globalAlertsEnabled">globalAlertsEnabled.</param>
    /// <param name="alertOnEnded">alertOnEnded.</param>
    /// <param name="alertLimit">alertLimit.</param>
    /// <param name="defaultToAddresses">defaultToAddresses.</param>
    /// <param name="notificationLevel">notificationLevel.</param>
    /// <param name="emailOnBaseMonitorError">emailOnBaseMonitorError.</param>
    /// <param name="baseMonitorErrorEmailAddresses">baseMonitorErrorEmailAddresses.</param>
    public EmailSettingsDto(bool globalAlertsEnabled = default, bool alertOnEnded = default, int alertLimit = default,
        string defaultToAddresses = default, NotificationLevel? notificationLevel = default,
        bool emailOnBaseMonitorError = default, string baseMonitorErrorEmailAddresses = default)
    {
        GlobalAlertsEnabled = globalAlertsEnabled;
        AlertOnEnded = alertOnEnded;
        AlertLimit = alertLimit;
        DefaultToAddresses = defaultToAddresses;
        NotificationLevel = notificationLevel;
        EmailOnBaseMonitorError = emailOnBaseMonitorError;
        BaseMonitorErrorEmailAddresses = baseMonitorErrorEmailAddresses;
    }

    /// <summary>
    ///     Gets or Sets NotificationLevel
    /// </summary>
    [DataMember(Name = "notificationLevel", EmitDefaultValue = false)]
    public NotificationLevel? NotificationLevel { get; set; }

    /// <summary>
    ///     Gets or Sets GlobalAlertsEnabled
    /// </summary>
    [DataMember(Name = "globalAlertsEnabled", EmitDefaultValue = true)]
    public bool GlobalAlertsEnabled { get; set; }

    /// <summary>
    ///     Gets or Sets AlertOnEnded
    /// </summary>
    [DataMember(Name = "alertOnEnded", EmitDefaultValue = true)]
    public bool AlertOnEnded { get; set; }

    /// <summary>
    ///     Gets or Sets AlertLimit
    /// </summary>
    [DataMember(Name = "alertLimit", EmitDefaultValue = false)]
    public int AlertLimit { get; set; }

    /// <summary>
    ///     Gets or Sets DefaultToAddresses
    /// </summary>
    [DataMember(Name = "defaultToAddresses", EmitDefaultValue = true)]
    public string DefaultToAddresses { get; set; }

    /// <summary>
    ///     Gets or Sets EmailOnBaseMonitorError
    /// </summary>
    [DataMember(Name = "emailOnBaseMonitorError", EmitDefaultValue = true)]
    public bool EmailOnBaseMonitorError { get; set; }

    /// <summary>
    ///     Gets or Sets BaseMonitorErrorEmailAddresses
    /// </summary>
    [DataMember(Name = "baseMonitorErrorEmailAddresses", EmitDefaultValue = true)]
    public string BaseMonitorErrorEmailAddresses { get; set; }

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
        sb.Append("class EmailSettingsDto {\n");
        sb.Append("  GlobalAlertsEnabled: ").Append(GlobalAlertsEnabled).Append("\n");
        sb.Append("  AlertOnEnded: ").Append(AlertOnEnded).Append("\n");
        sb.Append("  AlertLimit: ").Append(AlertLimit).Append("\n");
        sb.Append("  DefaultToAddresses: ").Append(DefaultToAddresses).Append("\n");
        sb.Append("  NotificationLevel: ").Append(NotificationLevel).Append("\n");
        sb.Append("  EmailOnBaseMonitorError: ").Append(EmailOnBaseMonitorError).Append("\n");
        sb.Append("  BaseMonitorErrorEmailAddresses: ").Append(BaseMonitorErrorEmailAddresses).Append("\n");
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