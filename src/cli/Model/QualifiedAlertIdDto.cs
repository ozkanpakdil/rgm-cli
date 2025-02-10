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
///     QualifiedAlertIdDto
/// </summary>
[DataContract(Name = "QualifiedAlertIdDto")]
public class QualifiedAlertIdDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="QualifiedAlertIdDto" /> class.
    /// </summary>
    /// <param name="alertId">alertId.</param>
    /// <param name="baseMonitorName">baseMonitorName.</param>
    public QualifiedAlertIdDto(IntegerIdentifier alertId = default, string baseMonitorName = default)
    {
        AlertId = alertId;
        BaseMonitorName = baseMonitorName;
    }

    /// <summary>
    ///     Gets or Sets AlertId
    /// </summary>
    [DataMember(Name = "alertId", EmitDefaultValue = false)]
    public IntegerIdentifier AlertId { get; set; }

    /// <summary>
    ///     Gets or Sets BaseMonitorName
    /// </summary>
    [DataMember(Name = "baseMonitorName", EmitDefaultValue = true)]
    public string BaseMonitorName { get; set; }

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
        sb.Append("class QualifiedAlertIdDto {\n");
        sb.Append("  AlertId: ").Append(AlertId).Append("\n");
        sb.Append("  BaseMonitorName: ").Append(BaseMonitorName).Append("\n");
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