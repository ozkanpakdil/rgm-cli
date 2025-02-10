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
///     GroupedPostgresConfigurationOptionsDto
/// </summary>
[DataContract(Name = "GroupedPostgresConfigurationOptionsDto")]
public class GroupedPostgresConfigurationOptionsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GroupedPostgresConfigurationOptionsDto" /> class.
    /// </summary>
    /// <param name="groupedOptions">groupedOptions.</param>
    public GroupedPostgresConfigurationOptionsDto(
        Dictionary<string, PostgresConfigurationOptionsDto> groupedOptions = default)
    {
        GroupedOptions = groupedOptions;
    }

    /// <summary>
    ///     Gets or Sets GroupedOptions
    /// </summary>
    [DataMember(Name = "groupedOptions", EmitDefaultValue = true)]
    public Dictionary<string, PostgresConfigurationOptionsDto> GroupedOptions { get; set; }

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
        sb.Append("class GroupedPostgresConfigurationOptionsDto {\n");
        sb.Append("  GroupedOptions: ").Append(GroupedOptions).Append("\n");
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