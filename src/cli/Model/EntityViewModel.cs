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
using RedGate.SqlMonitor.Channels.Data;
using RedGate.SqlMonitor.Common.Domain;

namespace cli.Model;

/// <summary>
///     EntityViewModel
/// </summary>
[DataContract(Name = "EntityViewModel")]
public class EntityViewModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="EntityViewModel" /> class.
    /// </summary>
    /// <param name="name">name.</param>
    /// <param name="status">status.</param>
    /// <param name="metrics">metrics.</param>
    /// <param name="baseMonitorName">baseMonitorName.</param>
    /// <param name="displayName">displayName.</param>
    /// <param name="userHasPermissionToClearAlerts">userHasPermissionToClearAlerts.</param>
    /// <param name="getCir">getCir.</param>
    /// <param name="suspended">suspended.</param>
    /// <param name="instanceUrl">instanceUrl.</param>
    /// <param name="group">group.</param>
    /// <param name="tags">tags.</param>
    /// <param name="availabilityGroups">availabilityGroups.</param>
    /// <param name="alertInboxUrl">alertInboxUrl.</param>
    /// <param name="metadata">metadata.</param>
    public EntityViewModel(string name = default, EntityStatus status = default, List<EntityMetric> metrics = default,
        string baseMonitorName = default, string displayName = default, bool userHasPermissionToClearAlerts = default,
        ChannelInstanceRef getCir = default, bool suspended = default, string instanceUrl = default,
        EntityGroup group = default, List<TagDto> tags = default, List<LinkedEntity> availabilityGroups = default,
        string alertInboxUrl = default, List<EntityMetadataDto> metadata = default)
    {
        Name = name;
        Status = status;
        Metrics = metrics;
        BaseMonitorName = baseMonitorName;
        DisplayName = displayName;
        UserHasPermissionToClearAlerts = userHasPermissionToClearAlerts;
        GetCir = getCir;
        Suspended = suspended;
        InstanceUrl = instanceUrl;
        Group = group;
        Tags = tags;
        AvailabilityGroups = availabilityGroups;
        AlertInboxUrl = alertInboxUrl;
        Metadata = metadata;
    }

    /// <summary>
    ///     Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public EntityType? EntityType { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public EntityStatus Status { get; set; }

    /// <summary>
    ///     Gets or Sets Metrics
    /// </summary>
    [DataMember(Name = "metrics", EmitDefaultValue = true)]
    public List<EntityMetric> Metrics { get; set; }

    /// <summary>
    ///     Gets or Sets BaseMonitorName
    /// </summary>
    [DataMember(Name = "baseMonitorName", EmitDefaultValue = true)]
    public string BaseMonitorName { get; set; }

    /// <summary>
    ///     Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = true)]
    public string DisplayName { get; set; }

    /// <summary>
    ///     Gets or Sets UserHasPermissionToClearAlerts
    /// </summary>
    [DataMember(Name = "userHasPermissionToClearAlerts", EmitDefaultValue = true)]
    public bool UserHasPermissionToClearAlerts { get; set; }

    /// <summary>
    ///     Gets or Sets GetCir
    /// </summary>
    [DataMember(Name = "getCir", EmitDefaultValue = true)]
    public ChannelInstanceRef GetCir { get; set; }

    /// <summary>
    ///     Gets or Sets Suspended
    /// </summary>
    [DataMember(Name = "suspended", EmitDefaultValue = true)]
    public bool Suspended { get; set; }

    /// <summary>
    ///     Gets or Sets InstanceUrl
    /// </summary>
    [DataMember(Name = "instanceUrl", EmitDefaultValue = true)]
    public string InstanceUrl { get; set; }

    /// <summary>
    ///     Gets or Sets Group
    /// </summary>
    [DataMember(Name = "group", EmitDefaultValue = false)]
    public EntityGroup Group { get; set; }

    /// <summary>
    ///     Gets or Sets Tags
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = true)]
    public List<TagDto> Tags { get; set; }

    /// <summary>
    ///     Gets or Sets AvailabilityGroups
    /// </summary>
    [DataMember(Name = "availabilityGroups", EmitDefaultValue = true)]
    public List<LinkedEntity> AvailabilityGroups { get; set; }

    /// <summary>
    ///     Gets or Sets AlertInboxUrl
    /// </summary>
    [DataMember(Name = "alertInboxUrl", EmitDefaultValue = true)]
    public string AlertInboxUrl { get; set; }

    /// <summary>
    ///     Gets or Sets Metadata
    /// </summary>
    [DataMember(Name = "metadata", EmitDefaultValue = true)]
    public List<EntityMetadataDto> Metadata { get; set; }

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
    ///     Returns false as EntityType should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeEntityType()
    {
        return false;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EntityViewModel {\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  BaseMonitorName: ").Append(BaseMonitorName).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  UserHasPermissionToClearAlerts: ").Append(UserHasPermissionToClearAlerts).Append("\n");
        sb.Append("  GetCir: ").Append(GetCir).Append("\n");
        sb.Append("  Suspended: ").Append(Suspended).Append("\n");
        sb.Append("  InstanceUrl: ").Append(InstanceUrl).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  AvailabilityGroups: ").Append(AvailabilityGroups).Append("\n");
        sb.Append("  AlertInboxUrl: ").Append(AlertInboxUrl).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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