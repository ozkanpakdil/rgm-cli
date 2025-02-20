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
///     BaseMonitorLocationDto
/// </summary>
[DataContract(Name = "BaseMonitorLocationDto")]
public class BaseMonitorLocationDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BaseMonitorLocationDto" /> class.
    /// </summary>
    /// <param name="networkName">networkName.</param>
    /// <param name="portNum">portNum.</param>
    /// <param name="alias">alias.</param>
    /// <param name="isDisconnected">isDisconnected.</param>
    /// <param name="isPrimary">isPrimary.</param>
    public BaseMonitorLocationDto(string networkName = default, int portNum = default, string alias = default,
        bool isDisconnected = default, bool isPrimary = default)
    {
        NetworkName = networkName;
        PortNum = portNum;
        Alias = alias;
        IsDisconnected = isDisconnected;
        IsPrimary = isPrimary;
    }

    /// <summary>
    ///     Gets or Sets NetworkName
    /// </summary>
    [DataMember(Name = "networkName", EmitDefaultValue = false)]
    public string NetworkName { get; set; }

    /// <summary>
    ///     Gets or Sets PortNum
    /// </summary>
    [DataMember(Name = "portNum", EmitDefaultValue = false)]
    public int PortNum { get; set; }

    /// <summary>
    ///     Gets or Sets Alias
    /// </summary>
    [DataMember(Name = "alias", EmitDefaultValue = true)]
    public string Alias { get; set; }

    /// <summary>
    ///     Gets or Sets IsDisconnected
    /// </summary>
    [DataMember(Name = "isDisconnected", EmitDefaultValue = true)]
    public bool IsDisconnected { get; set; }

    /// <summary>
    ///     Gets or Sets IsPrimary
    /// </summary>
    [DataMember(Name = "isPrimary", EmitDefaultValue = true)]
    public bool IsPrimary { get; set; }

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
        sb.Append("class BaseMonitorLocationDto {\n");
        sb.Append("  NetworkName: ").Append(NetworkName).Append("\n");
        sb.Append("  PortNum: ").Append(PortNum).Append("\n");
        sb.Append("  Alias: ").Append(Alias).Append("\n");
        sb.Append("  IsDisconnected: ").Append(IsDisconnected).Append("\n");
        sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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