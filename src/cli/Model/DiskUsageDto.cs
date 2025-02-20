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
///     DiskUsageDto
/// </summary>
[DataContract(Name = "DiskUsageDto")]
public class DiskUsageDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DiskUsageDto" /> class.
    /// </summary>
    /// <param name="monitoredEntity">monitoredEntity.</param>
    /// <param name="groupName">groupName.</param>
    /// <param name="clusterName">clusterName.</param>
    /// <param name="machineName">machineName.</param>
    /// <param name="diskName">diskName.</param>
    /// <param name="diskLabel">diskLabel.</param>
    /// <param name="diskUsed">diskUsed.</param>
    /// <param name="diskSize">diskSize.</param>
    /// <param name="projectedSizeNow">projectedSizeNow.</param>
    /// <param name="projectedSizeInOneYear">projectedSizeInOneYear.</param>
    /// <param name="projectedDateForFullCapacityUsed">projectedDateForFullCapacityUsed.</param>
    /// <param name="sqlInstances">sqlInstances.</param>
    public DiskUsageDto(EntityDto monitoredEntity = default, string groupName = default, string clusterName = default,
        string machineName = default, string diskName = default, string diskLabel = default, long diskUsed = default,
        long diskSize = default, double? projectedSizeNow = default, double? projectedSizeInOneYear = default,
        DateTime? projectedDateForFullCapacityUsed = default, List<SqlInstanceDto> sqlInstances = default)
    {
        MonitoredEntity = monitoredEntity;
        GroupName = groupName;
        ClusterName = clusterName;
        MachineName = machineName;
        DiskName = diskName;
        DiskLabel = diskLabel;
        DiskUsed = diskUsed;
        DiskSize = diskSize;
        ProjectedSizeNow = projectedSizeNow;
        ProjectedSizeInOneYear = projectedSizeInOneYear;
        ProjectedDateForFullCapacityUsed = projectedDateForFullCapacityUsed;
        SqlInstances = sqlInstances;
    }

    /// <summary>
    ///     Gets or Sets MonitoredEntity
    /// </summary>
    [DataMember(Name = "monitoredEntity", EmitDefaultValue = false)]
    public EntityDto MonitoredEntity { get; set; }

    /// <summary>
    ///     Gets or Sets GroupName
    /// </summary>
    [DataMember(Name = "groupName", EmitDefaultValue = true)]
    public string GroupName { get; set; }

    /// <summary>
    ///     Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name = "clusterName", EmitDefaultValue = true)]
    public string ClusterName { get; set; }

    /// <summary>
    ///     Gets or Sets MachineName
    /// </summary>
    [DataMember(Name = "machineName", EmitDefaultValue = true)]
    public string MachineName { get; set; }

    /// <summary>
    ///     Gets or Sets DiskName
    /// </summary>
    [DataMember(Name = "diskName", EmitDefaultValue = true)]
    public string DiskName { get; set; }

    /// <summary>
    ///     Gets or Sets DiskLabel
    /// </summary>
    [DataMember(Name = "diskLabel", EmitDefaultValue = true)]
    public string DiskLabel { get; set; }

    /// <summary>
    ///     Gets or Sets DiskUsed
    /// </summary>
    [DataMember(Name = "diskUsed", EmitDefaultValue = false)]
    public long DiskUsed { get; set; }

    /// <summary>
    ///     Gets or Sets DiskSize
    /// </summary>
    [DataMember(Name = "diskSize", EmitDefaultValue = false)]
    public long DiskSize { get; set; }

    /// <summary>
    ///     Gets or Sets ProjectedSizeNow
    /// </summary>
    [DataMember(Name = "projectedSizeNow", EmitDefaultValue = true)]
    public double? ProjectedSizeNow { get; set; }

    /// <summary>
    ///     Gets or Sets ProjectedSizeInOneYear
    /// </summary>
    [DataMember(Name = "projectedSizeInOneYear", EmitDefaultValue = true)]
    public double? ProjectedSizeInOneYear { get; set; }

    /// <summary>
    ///     Gets or Sets ProjectedDateForFullCapacityUsed
    /// </summary>
    [DataMember(Name = "projectedDateForFullCapacityUsed", EmitDefaultValue = true)]
    public DateTime? ProjectedDateForFullCapacityUsed { get; set; }

    /// <summary>
    ///     Gets or Sets SqlInstances
    /// </summary>
    [DataMember(Name = "sqlInstances", EmitDefaultValue = true)]
    public List<SqlInstanceDto> SqlInstances { get; set; }

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
        sb.Append("class DiskUsageDto {\n");
        sb.Append("  MonitoredEntity: ").Append(MonitoredEntity).Append("\n");
        sb.Append("  GroupName: ").Append(GroupName).Append("\n");
        sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
        sb.Append("  MachineName: ").Append(MachineName).Append("\n");
        sb.Append("  DiskName: ").Append(DiskName).Append("\n");
        sb.Append("  DiskLabel: ").Append(DiskLabel).Append("\n");
        sb.Append("  DiskUsed: ").Append(DiskUsed).Append("\n");
        sb.Append("  DiskSize: ").Append(DiskSize).Append("\n");
        sb.Append("  ProjectedSizeNow: ").Append(ProjectedSizeNow).Append("\n");
        sb.Append("  ProjectedSizeInOneYear: ").Append(ProjectedSizeInOneYear).Append("\n");
        sb.Append("  ProjectedDateForFullCapacityUsed: ").Append(ProjectedDateForFullCapacityUsed).Append("\n");
        sb.Append("  SqlInstances: ").Append(SqlInstances).Append("\n");
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