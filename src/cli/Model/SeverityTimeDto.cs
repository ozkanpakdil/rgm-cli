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
///     SeverityTimeDto
/// </summary>
[DataContract(Name = "SeverityTimeDto")]
public class SeverityTimeDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="SeverityTimeDto" /> class.
    /// </summary>
    /// <param name="time">time.</param>
    /// <param name="severity">severity.</param>
    public SeverityTimeDto(DateTime time = default, Severity? severity = default)
    {
        Time = time;
        Severity = severity;
    }

    /// <summary>
    ///     Gets or Sets Severity
    /// </summary>
    [DataMember(Name = "severity", EmitDefaultValue = false)]
    public Severity? Severity { get; set; }

    /// <summary>
    ///     Gets or Sets Time
    /// </summary>
    [DataMember(Name = "time", EmitDefaultValue = false)]
    public DateTime Time { get; set; }

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
        sb.Append("class SeverityTimeDto {\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  Severity: ").Append(Severity).Append("\n");
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