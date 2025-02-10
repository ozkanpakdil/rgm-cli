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
///     AlertTypeDto
/// </summary>
[DataContract(Name = "AlertTypeDto")]
public class AlertTypeDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AlertTypeDto" /> class.
    /// </summary>
    /// <param name="id">id.</param>
    /// <param name="name">name.</param>
    /// <param name="description">description.</param>
    /// <param name="shortName">shortName.</param>
    public AlertTypeDto(string id = default, string name = default, string description = default,
        string shortName = default)
    {
        Id = id;
        Name = name;
        Description = description;
        ShortName = shortName;
    }

    /// <summary>
    ///     Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = true)]
    public string Id { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = true)]
    public string Description { get; set; }

    /// <summary>
    ///     Gets or Sets ShortName
    /// </summary>
    [DataMember(Name = "shortName", EmitDefaultValue = true)]
    public string ShortName { get; set; }

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
        sb.Append("class AlertTypeDto {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ShortName: ").Append(ShortName).Append("\n");
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