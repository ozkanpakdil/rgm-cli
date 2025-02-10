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
///     AddAzureManagedInstanceCommandDto
/// </summary>
[DataContract(Name = "AddAzureManagedInstanceCommandDto")]
public class AddAzureManagedInstanceCommandDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AddAzureManagedInstanceCommandDto" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddAzureManagedInstanceCommandDto()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AddAzureManagedInstanceCommandDto" /> class.
    /// </summary>
    /// <param name="endpoint">endpoint (required).</param>
    /// <param name="username">username.</param>
    /// <param name="password">password.</param>
    /// <param name="sqlServerConnectionProperties">sqlServerConnectionProperties (required).</param>
    /// <param name="authenticationMode">authenticationMode (required).</param>
    /// <param name="groupId">groupId.</param>
    /// <param name="agentName">agentName.</param>
    public AddAzureManagedInstanceCommandDto(string endpoint = default, string username = default,
        string password = default, SqlServerConnectionPropertiesModel sqlServerConnectionProperties = default,
        AzureAuthenticationMode authenticationMode = default, Guid? groupId = default, string agentName = default)
    {
        // to ensure "endpoint" is required (not null)
        if (endpoint == null)
            throw new ArgumentNullException(
                "endpoint is a required property for AddAzureManagedInstanceCommandDto and cannot be null");
        Endpoint = endpoint;
        // to ensure "sqlServerConnectionProperties" is required (not null)
        if (sqlServerConnectionProperties == null)
            throw new ArgumentNullException(
                "sqlServerConnectionProperties is a required property for AddAzureManagedInstanceCommandDto and cannot be null");
        SqlServerConnectionProperties = sqlServerConnectionProperties;
        AuthenticationMode = authenticationMode;
        Username = username;
        Password = password;
        GroupId = groupId;
        AgentName = agentName;
    }

    /// <summary>
    ///     Gets or Sets AuthenticationMode
    /// </summary>
    [DataMember(Name = "authenticationMode", IsRequired = true, EmitDefaultValue = true)]
    public AzureAuthenticationMode AuthenticationMode { get; set; }

    /// <summary>
    ///     Gets or Sets Endpoint
    /// </summary>
    [DataMember(Name = "endpoint", IsRequired = true, EmitDefaultValue = true)]
    public string Endpoint { get; set; }

    /// <summary>
    ///     Gets or Sets Username
    /// </summary>
    [DataMember(Name = "username", EmitDefaultValue = false)]
    public string Username { get; set; }

    /// <summary>
    ///     Gets or Sets Password
    /// </summary>
    [DataMember(Name = "password", EmitDefaultValue = false)]
    public string Password { get; set; }

    /// <summary>
    ///     Gets or Sets SqlServerConnectionProperties
    /// </summary>
    [DataMember(Name = "sqlServerConnectionProperties", IsRequired = true, EmitDefaultValue = true)]
    public SqlServerConnectionPropertiesModel SqlServerConnectionProperties { get; set; }

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
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        // Endpoint (string) minLength
        if (Endpoint != null && Endpoint.Length < 1)
            yield return new ValidationResult("Invalid value for Endpoint, length must be greater than 1.",
                new[] { "Endpoint" });

        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddAzureManagedInstanceCommandDto {\n");
        sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  SqlServerConnectionProperties: ").Append(SqlServerConnectionProperties).Append("\n");
        sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  AgentName: ").Append(AgentName).Append("\n");
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