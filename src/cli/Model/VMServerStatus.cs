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
///     VMServerStatus
/// </summary>
[DataContract(Name = "VMServerStatus")]
public class VMServerStatus : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="VMServerStatus" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected VMServerStatus()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="VMServerStatus" /> class.
    /// </summary>
    /// <param name="name">name (required).</param>
    /// <param name="status">status (required).</param>
    /// <param name="hosts">hosts (required).</param>
    public VMServerStatus(string name = default, VMwareServerStatus status = default, List<HostStatus> hosts = default)
    {
        // to ensure "name" is required (not null)
        if (name == null)
            throw new ArgumentNullException("name is a required property for VMServerStatus and cannot be null");
        Name = name;
        Status = status;
        // to ensure "hosts" is required (not null)
        if (hosts == null)
            throw new ArgumentNullException("hosts is a required property for VMServerStatus and cannot be null");
        Hosts = hosts;
    }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public VMwareServerStatus Status { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Hosts
    /// </summary>
    [DataMember(Name = "hosts", IsRequired = true, EmitDefaultValue = true)]
    public List<HostStatus> Hosts { get; set; }

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
        sb.Append("class VMServerStatus {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Hosts: ").Append(Hosts).Append("\n");
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