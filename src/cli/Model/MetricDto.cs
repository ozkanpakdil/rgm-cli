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
///     MetricDto
/// </summary>
[DataContract(Name = "MetricDto")]
public class MetricDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MetricDto" /> class.
    /// </summary>
    /// <param name="metricType">metricType.</param>
    /// <param name="targetName">targetName.</param>
    /// <param name="monitoredEntity">monitoredEntity.</param>
    /// <param name="data">data.</param>
    public MetricDto(MetricTypeDisplayDto metricType = default, string targetName = default,
        EntityDto monitoredEntity = default, List<MetricTimeSeriesDto> data = default)
    {
        MetricType = metricType;
        TargetName = targetName;
        MonitoredEntity = monitoredEntity;
        Data = data;
    }

    /// <summary>
    ///     Gets or Sets MetricType
    /// </summary>
    [DataMember(Name = "metricType", EmitDefaultValue = false)]
    public MetricTypeDisplayDto MetricType { get; set; }

    /// <summary>
    ///     Gets or Sets TargetName
    /// </summary>
    [DataMember(Name = "targetName", EmitDefaultValue = true)]
    public string TargetName { get; set; }

    /// <summary>
    ///     Gets or Sets MonitoredEntity
    /// </summary>
    [DataMember(Name = "monitoredEntity", EmitDefaultValue = false)]
    public EntityDto MonitoredEntity { get; set; }

    /// <summary>
    ///     Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", EmitDefaultValue = true)]
    public List<MetricTimeSeriesDto> Data { get; set; }

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
        sb.Append("class MetricDto {\n");
        sb.Append("  MetricType: ").Append(MetricType).Append("\n");
        sb.Append("  TargetName: ").Append(TargetName).Append("\n");
        sb.Append("  MonitoredEntity: ").Append(MonitoredEntity).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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