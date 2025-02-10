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
using RedGate.SqlMonitor.Common.Domain;

namespace cli.Model;

/// <summary>
///     DuplicateMonitoredEntityWarningDto
/// </summary>
[DataContract(Name = "DuplicateMonitoredEntityWarningDto")]
public class DuplicateMonitoredEntityWarningDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DuplicateMonitoredEntityWarningDto" /> class.
    /// </summary>
    /// <param name="entityType">entityType.</param>
    /// <param name="name">name.</param>
    /// <param name="baseMonitors">baseMonitors.</param>
    public DuplicateMonitoredEntityWarningDto(EntityType? entityType = default, string name = default,
        List<string> baseMonitors = default)
    {
        EntityType = entityType;
        Name = name;
        BaseMonitors = baseMonitors;
    }

    /// <summary>
    ///     Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public EntityType? EntityType { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets BaseMonitors
    /// </summary>
    [DataMember(Name = "baseMonitors", EmitDefaultValue = true)]
    public List<string> BaseMonitors { get; set; }

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
        sb.Append("class DuplicateMonitoredEntityWarningDto {\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  BaseMonitors: ").Append(BaseMonitors).Append("\n");
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