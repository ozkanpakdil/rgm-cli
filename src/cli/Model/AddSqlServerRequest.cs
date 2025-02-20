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
///     AddSqlServerRequest
/// </summary>
[DataContract(Name = "AddSqlServerRequest")]
public class AddSqlServerRequest : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AddSqlServerRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddSqlServerRequest()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AddSqlServerRequest" /> class.
    /// </summary>
    /// <param name="serverName">serverName (required).</param>
    /// <param name="groupId">groupId.</param>
    /// <param name="agentName">agentName.</param>
    /// <param name="environmentType">environmentType.</param>
    /// <param name="machineConfig">machineConfig (required).</param>
    /// <param name="sqlServerInstanceConfig">sqlServerInstanceConfig (required).</param>
    public AddSqlServerRequest(string serverName = default, Guid? groupId = default, string agentName = default,
        EnvironmentTypeDto? environmentType = default, MachineConfiguration machineConfig = default,
        SqlServerInstanceConfiguration sqlServerInstanceConfig = default)
    {
        // to ensure "serverName" is required (not null)
        if (serverName == null)
            throw new ArgumentNullException(
                "serverName is a required property for AddSqlServerRequest and cannot be null");
        ServerName = serverName;
        // to ensure "machineConfig" is required (not null)
        if (machineConfig == null)
            throw new ArgumentNullException(
                "machineConfig is a required property for AddSqlServerRequest and cannot be null");
        MachineConfig = machineConfig;
        // to ensure "sqlServerInstanceConfig" is required (not null)
        if (sqlServerInstanceConfig == null)
            throw new ArgumentNullException(
                "sqlServerInstanceConfig is a required property for AddSqlServerRequest and cannot be null");
        SqlServerInstanceConfig = sqlServerInstanceConfig;
        GroupId = groupId;
        AgentName = agentName;
        EnvironmentType = environmentType;
    }

    /// <summary>
    ///     Gets or Sets EnvironmentType
    /// </summary>
    [DataMember(Name = "environmentType", EmitDefaultValue = false)]
    public EnvironmentTypeDto? EnvironmentType { get; set; }

    /// <summary>
    ///     Gets or Sets ServerName
    /// </summary>
    [DataMember(Name = "serverName", IsRequired = true, EmitDefaultValue = true)]
    public string ServerName { get; set; }

    /// <summary>
    ///     Gets or Sets GroupId
    /// </summary>
    [DataMember(Name = "groupId", EmitDefaultValue = true)]
    public Guid? GroupId { get; set; }

    /// <summary>
    ///     Gets or Sets AgentName
    /// </summary>
    [DataMember(Name = "agentName", EmitDefaultValue = true)]
    public string AgentName { get; set; }

    /// <summary>
    ///     Gets or Sets MachineConfig
    /// </summary>
    [DataMember(Name = "machineConfig", IsRequired = true, EmitDefaultValue = true)]
    public MachineConfiguration MachineConfig { get; set; }

    /// <summary>
    ///     Gets or Sets SqlServerInstanceConfig
    /// </summary>
    [DataMember(Name = "sqlServerInstanceConfig", IsRequired = true, EmitDefaultValue = true)]
    public SqlServerInstanceConfiguration SqlServerInstanceConfig { get; set; }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        // ServerName (string) minLength
        if (ServerName != null && ServerName.Length < 1)
            yield return new ValidationResult("Invalid value for ServerName, length must be greater than 1.",
                new[] { "ServerName" });

        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddSqlServerRequest {\n");
        sb.Append("  ServerName: ").Append(ServerName).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  AgentName: ").Append(AgentName).Append("\n");
        sb.Append("  EnvironmentType: ").Append(EnvironmentType).Append("\n");
        sb.Append("  MachineConfig: ").Append(MachineConfig).Append("\n");
        sb.Append("  SqlServerInstanceConfig: ").Append(SqlServerInstanceConfig).Append("\n");
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