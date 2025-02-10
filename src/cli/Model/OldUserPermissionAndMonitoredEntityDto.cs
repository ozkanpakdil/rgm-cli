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
///     OldUserPermissionAndMonitoredEntityDto
/// </summary>
[DataContract(Name = "OldUserPermissionAndMonitoredEntityDto")]
public class OldUserPermissionAndMonitoredEntityDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="OldUserPermissionAndMonitoredEntityDto" /> class.
    /// </summary>
    /// <param name="userPermissions">userPermissions.</param>
    /// <param name="monitoredEntityInfo">monitoredEntityInfo.</param>
    public OldUserPermissionAndMonitoredEntityDto(List<OldUserPermissionsDto> userPermissions = default,
        List<MonitoredEntityInfoDto> monitoredEntityInfo = default)
    {
        UserPermissions = userPermissions;
        MonitoredEntityInfo = monitoredEntityInfo;
    }

    /// <summary>
    ///     Gets or Sets UserPermissions
    /// </summary>
    [DataMember(Name = "userPermissions", EmitDefaultValue = true)]
    public List<OldUserPermissionsDto> UserPermissions { get; set; }

    /// <summary>
    ///     Gets or Sets MonitoredEntityInfo
    /// </summary>
    [DataMember(Name = "monitoredEntityInfo", EmitDefaultValue = true)]
    public List<MonitoredEntityInfoDto> MonitoredEntityInfo { get; set; }

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
        sb.Append("class OldUserPermissionAndMonitoredEntityDto {\n");
        sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
        sb.Append("  MonitoredEntityInfo: ").Append(MonitoredEntityInfo).Append("\n");
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