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
///     GuestStatus
/// </summary>
[DataContract(Name = "GuestStatus")]
public class GuestStatus : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GuestStatus" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GuestStatus()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="GuestStatus" /> class.
    /// </summary>
    /// <param name="name">name (required).</param>
    /// <param name="hostName">hostName (required).</param>
    /// <param name="status">status (required).</param>
    /// <param name="vMwareToolsStatus">vMwareToolsStatus (required).</param>
    public GuestStatus(string name = default, string hostName = default, string status = default,
        string vMwareToolsStatus = default)
    {
        // to ensure "name" is required (not null)
        if (name == null)
            throw new ArgumentNullException("name is a required property for GuestStatus and cannot be null");
        Name = name;
        // to ensure "hostName" is required (not null)
        if (hostName == null)
            throw new ArgumentNullException("hostName is a required property for GuestStatus and cannot be null");
        HostName = hostName;
        // to ensure "status" is required (not null)
        if (status == null)
            throw new ArgumentNullException("status is a required property for GuestStatus and cannot be null");
        Status = status;
        // to ensure "vMwareToolsStatus" is required (not null)
        if (vMwareToolsStatus == null)
            throw new ArgumentNullException(
                "vMwareToolsStatus is a required property for GuestStatus and cannot be null");
        VMwareToolsStatus = vMwareToolsStatus;
    }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets HostName
    /// </summary>
    [DataMember(Name = "hostName", IsRequired = true, EmitDefaultValue = true)]
    public string HostName { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public string Status { get; set; }

    /// <summary>
    ///     Gets or Sets VMwareToolsStatus
    /// </summary>
    [DataMember(Name = "vMwareToolsStatus", IsRequired = true, EmitDefaultValue = true)]
    public string VMwareToolsStatus { get; set; }

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
        sb.Append("class GuestStatus {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  HostName: ").Append(HostName).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  VMwareToolsStatus: ").Append(VMwareToolsStatus).Append("\n");
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