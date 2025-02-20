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
using RedGate.SqlMonitor.Common.Domain;

namespace cli.Model;

/// <summary>
///     ManagedEntityChildStatusViewModel
/// </summary>
[DataContract(Name = "ManagedEntityChildStatusViewModel")]
public class ManagedEntityChildStatusViewModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ManagedEntityChildStatusViewModel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ManagedEntityChildStatusViewModel()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManagedEntityChildStatusViewModel" /> class.
    /// </summary>
    /// <param name="name">name (required).</param>
    /// <param name="status">status (required).</param>
    /// <param name="entityType">entityType (required).</param>
    public ManagedEntityChildStatusViewModel(string name = default, MonitoredEntityStatusDto status = default,
        EntityType entityType = default)
    {
        // to ensure "name" is required (not null)
        if (name == null)
            throw new ArgumentNullException(
                "name is a required property for ManagedEntityChildStatusViewModel and cannot be null");
        Name = name;
        Status = status;
        EntityType = entityType;
    }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public MonitoredEntityStatusDto Status { get; set; }

    /// <summary>
    ///     Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", IsRequired = true, EmitDefaultValue = true)]
    public EntityType EntityType { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

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
        sb.Append("class ManagedEntityChildStatusViewModel {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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