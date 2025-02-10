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
///     AddOracleInstanceRequest
/// </summary>
[DataContract(Name = "AddOracleInstanceRequest")]
public class AddOracleInstanceRequest : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AddOracleInstanceRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddOracleInstanceRequest()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AddOracleInstanceRequest" /> class.
    /// </summary>
    /// <param name="address">address (required).</param>
    /// <param name="alias">alias.</param>
    /// <param name="port">port (required).</param>
    /// <param name="serviceName">serviceName (required).</param>
    /// <param name="groupId">groupId.</param>
    /// <param name="agentName">agentName.</param>
    /// <param name="machineConfiguration">machineConfiguration.</param>
    /// <param name="instanceCredentials">instanceCredentials (required).</param>
    /// <param name="failIfExists">failIfExists.</param>
    /// <param name="addToExistingLinuxMachine">addToExistingLinuxMachine.</param>
    /// <param name="useTcps">useTcps.</param>
    public AddOracleInstanceRequest(string address = default, string alias = default, int port = default,
        string serviceName = default, Guid? groupId = default, string agentName = default,
        LinuxMachineConfiguration machineConfiguration = default,
        OracleInstanceCredentialsDto instanceCredentials = default, bool failIfExists = default,
        bool addToExistingLinuxMachine = default, bool useTcps = default)
    {
        // to ensure "address" is required (not null)
        if (address == null)
            throw new ArgumentNullException(
                "address is a required property for AddOracleInstanceRequest and cannot be null");
        Address = address;
        Port = port;
        // to ensure "serviceName" is required (not null)
        if (serviceName == null)
            throw new ArgumentNullException(
                "serviceName is a required property for AddOracleInstanceRequest and cannot be null");
        ServiceName = serviceName;
        // to ensure "instanceCredentials" is required (not null)
        if (instanceCredentials == null)
            throw new ArgumentNullException(
                "instanceCredentials is a required property for AddOracleInstanceRequest and cannot be null");
        InstanceCredentials = instanceCredentials;
        Alias = alias;
        GroupId = groupId;
        AgentName = agentName;
        MachineConfiguration = machineConfiguration;
        FailIfExists = failIfExists;
        AddToExistingLinuxMachine = addToExistingLinuxMachine;
        UseTcps = useTcps;
    }

    /// <summary>
    ///     Gets or Sets Address
    /// </summary>
    [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
    public string Address { get; set; }

    /// <summary>
    ///     Gets or Sets Alias
    /// </summary>
    [DataMember(Name = "alias", EmitDefaultValue = true)]
    public string Alias { get; set; }

    /// <summary>
    ///     Gets or Sets Port
    /// </summary>
    [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
    public int Port { get; set; }

    /// <summary>
    ///     Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name = "serviceName", IsRequired = true, EmitDefaultValue = true)]
    public string ServiceName { get; set; }

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
    ///     Gets or Sets MachineConfiguration
    /// </summary>
    [DataMember(Name = "machineConfiguration", EmitDefaultValue = false)]
    public LinuxMachineConfiguration MachineConfiguration { get; set; }

    /// <summary>
    ///     Gets or Sets InstanceCredentials
    /// </summary>
    [DataMember(Name = "instanceCredentials", IsRequired = true, EmitDefaultValue = true)]
    public OracleInstanceCredentialsDto InstanceCredentials { get; set; }

    /// <summary>
    ///     Gets or Sets FailIfExists
    /// </summary>
    [DataMember(Name = "failIfExists", EmitDefaultValue = true)]
    public bool FailIfExists { get; set; }

    /// <summary>
    ///     Gets or Sets AddToExistingLinuxMachine
    /// </summary>
    [DataMember(Name = "addToExistingLinuxMachine", EmitDefaultValue = true)]
    public bool AddToExistingLinuxMachine { get; set; }

    /// <summary>
    ///     Gets or Sets UseTcps
    /// </summary>
    [DataMember(Name = "useTcps", EmitDefaultValue = true)]
    public bool UseTcps { get; set; }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        // Address (string) minLength
        if (Address != null && Address.Length < 1)
            yield return new ValidationResult("Invalid value for Address, length must be greater than 1.",
                new[] { "Address" });

        // Port (int) maximum
        if (Port > 65535)
            yield return new ValidationResult("Invalid value for Port, must be a value less than or equal to 65535.",
                new[] { "Port" });

        // Port (int) minimum
        if (Port < 1)
            yield return new ValidationResult("Invalid value for Port, must be a value greater than or equal to 1.",
                new[] { "Port" });

        // ServiceName (string) minLength
        if (ServiceName != null && ServiceName.Length < 1)
            yield return new ValidationResult("Invalid value for ServiceName, length must be greater than 1.",
                new[] { "ServiceName" });

        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddOracleInstanceRequest {\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Alias: ").Append(Alias).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  AgentName: ").Append(AgentName).Append("\n");
        sb.Append("  MachineConfiguration: ").Append(MachineConfiguration).Append("\n");
        sb.Append("  InstanceCredentials: ").Append(InstanceCredentials).Append("\n");
        sb.Append("  FailIfExists: ").Append(FailIfExists).Append("\n");
        sb.Append("  AddToExistingLinuxMachine: ").Append(AddToExistingLinuxMachine).Append("\n");
        sb.Append("  UseTcps: ").Append(UseTcps).Append("\n");
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