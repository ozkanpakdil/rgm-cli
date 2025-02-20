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
///     ConfigurationComplianceTemplateDto
/// </summary>
[DataContract(Name = "ConfigurationComplianceTemplateDto")]
public class ConfigurationComplianceTemplateDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ConfigurationComplianceTemplateDto" /> class.
    /// </summary>
    /// <param name="id">id.</param>
    /// <param name="name">name.</param>
    /// <param name="options">options.</param>
    /// <param name="lastUpdated">lastUpdated.</param>
    /// <param name="isPreSet">isPreSet.</param>
    /// <param name="detailsMessage">detailsMessage.</param>
    public ConfigurationComplianceTemplateDto(Guid id = default, string name = default,
        Dictionary<string, object> options = default, DateTime lastUpdated = default, bool isPreSet = default,
        string detailsMessage = default)
    {
        Id = id;
        Name = name;
        Options = options;
        LastUpdated = lastUpdated;
        IsPreSet = isPreSet;
        DetailsMessage = detailsMessage;
    }

    /// <summary>
    ///     Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid Id { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Options
    /// </summary>
    [DataMember(Name = "options", EmitDefaultValue = true)]
    public Dictionary<string, object> Options { get; set; }

    /// <summary>
    ///     Gets or Sets LastUpdated
    /// </summary>
    [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    ///     Gets or Sets IsPreSet
    /// </summary>
    [DataMember(Name = "isPreSet", EmitDefaultValue = true)]
    public bool IsPreSet { get; set; }

    /// <summary>
    ///     Gets or Sets DetailsMessage
    /// </summary>
    [DataMember(Name = "detailsMessage", EmitDefaultValue = true)]
    public string DetailsMessage { get; set; }

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
        sb.Append("class ConfigurationComplianceTemplateDto {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Options: ").Append(Options).Append("\n");
        sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
        sb.Append("  IsPreSet: ").Append(IsPreSet).Append("\n");
        sb.Append("  DetailsMessage: ").Append(DetailsMessage).Append("\n");
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