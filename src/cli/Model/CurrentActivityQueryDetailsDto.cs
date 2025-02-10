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
///     CurrentActivityQueryDetailsDto
/// </summary>
[DataContract(Name = "CurrentActivityQueryDetailsDto")]
public class CurrentActivityQueryDetailsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CurrentActivityQueryDetailsDto" /> class.
    /// </summary>
    /// <param name="entityType">entityType.</param>
    public CurrentActivityQueryDetailsDto(CurrentActivityEntityTypeDto? entityType = default)
    {
        EntityType = entityType;
    }

    /// <summary>
    ///     Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public CurrentActivityEntityTypeDto? EntityType { get; set; }

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
        sb.Append("class CurrentActivityQueryDetailsDto {\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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