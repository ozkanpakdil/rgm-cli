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
///     ServerConfigResult
/// </summary>
[DataContract(Name = "ServerConfigResult")]
public class ServerConfigResult : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ServerConfigResult" /> class.
    /// </summary>
    /// <param name="clusterName">clusterName.</param>
    /// <param name="sqlServerVersion">sqlServerVersion.</param>
    /// <param name="edition">edition.</param>
    /// <param name="collation">collation.</param>
    /// <param name="varOperatingSystem">varOperatingSystem.</param>
    /// <param name="memory">memory.</param>
    /// <param name="clustered">clustered.</param>
    /// <param name="virtualized">virtualized.</param>
    /// <param name="monitoring">monitoring.</param>
    /// <param name="monitoringClass">monitoringClass.</param>
    /// <param name="availability">availability.</param>
    /// <param name="lastRestart">lastRestart.</param>
    /// <param name="integration">integration.</param>
    /// <param name="browser">browser.</param>
    /// <param name="sqlService">sqlService.</param>
    /// <param name="agent">agent.</param>
    /// <param name="dataUnavailableMessage">dataUnavailableMessage.</param>
    public ServerConfigResult(string clusterName = default, string sqlServerVersion = default, string edition = default,
        string collation = default, string varOperatingSystem = default, string memory = default,
        string clustered = default, string virtualized = default, string monitoring = default,
        string monitoringClass = default, string availability = default, string lastRestart = default,
        string integration = default, string browser = default, ServiceCountSummaryDto sqlService = default,
        ServiceCountSummaryDto agent = default, string dataUnavailableMessage = default)
    {
        ClusterName = clusterName;
        SqlServerVersion = sqlServerVersion;
        Edition = edition;
        Collation = collation;
        VarOperatingSystem = varOperatingSystem;
        Memory = memory;
        Clustered = clustered;
        Virtualized = virtualized;
        Monitoring = monitoring;
        MonitoringClass = monitoringClass;
        Availability = availability;
        LastRestart = lastRestart;
        Integration = integration;
        Browser = browser;
        SqlService = sqlService;
        Agent = agent;
        DataUnavailableMessage = dataUnavailableMessage;
    }

    /// <summary>
    ///     Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name = "clusterName", EmitDefaultValue = true)]
    public string ClusterName { get; set; }

    /// <summary>
    ///     Gets or Sets SqlServerVersion
    /// </summary>
    [DataMember(Name = "sqlServerVersion", EmitDefaultValue = true)]
    public string SqlServerVersion { get; set; }

    /// <summary>
    ///     Gets or Sets Edition
    /// </summary>
    [DataMember(Name = "edition", EmitDefaultValue = true)]
    public string Edition { get; set; }

    /// <summary>
    ///     Gets or Sets Collation
    /// </summary>
    [DataMember(Name = "collation", EmitDefaultValue = true)]
    public string Collation { get; set; }

    /// <summary>
    ///     Gets or Sets VarOperatingSystem
    /// </summary>
    [DataMember(Name = "operatingSystem", EmitDefaultValue = true)]
    public string VarOperatingSystem { get; set; }

    /// <summary>
    ///     Gets or Sets Memory
    /// </summary>
    [DataMember(Name = "memory", EmitDefaultValue = true)]
    public string Memory { get; set; }

    /// <summary>
    ///     Gets or Sets Clustered
    /// </summary>
    [DataMember(Name = "clustered", EmitDefaultValue = true)]
    public string Clustered { get; set; }

    /// <summary>
    ///     Gets or Sets Virtualized
    /// </summary>
    [DataMember(Name = "virtualized", EmitDefaultValue = true)]
    public string Virtualized { get; set; }

    /// <summary>
    ///     Gets or Sets Monitoring
    /// </summary>
    [DataMember(Name = "monitoring", EmitDefaultValue = true)]
    public string Monitoring { get; set; }

    /// <summary>
    ///     Gets or Sets MonitoringClass
    /// </summary>
    [DataMember(Name = "monitoringClass", EmitDefaultValue = true)]
    public string MonitoringClass { get; set; }

    /// <summary>
    ///     Gets or Sets Availability
    /// </summary>
    [DataMember(Name = "availability", EmitDefaultValue = true)]
    public string Availability { get; set; }

    /// <summary>
    ///     Gets or Sets LastRestart
    /// </summary>
    [DataMember(Name = "lastRestart", EmitDefaultValue = true)]
    public string LastRestart { get; set; }

    /// <summary>
    ///     Gets or Sets Integration
    /// </summary>
    [DataMember(Name = "integration", EmitDefaultValue = true)]
    public string Integration { get; set; }

    /// <summary>
    ///     Gets or Sets Browser
    /// </summary>
    [DataMember(Name = "browser", EmitDefaultValue = true)]
    public string Browser { get; set; }

    /// <summary>
    ///     Gets or Sets SqlService
    /// </summary>
    [DataMember(Name = "sqlService", EmitDefaultValue = false)]
    public ServiceCountSummaryDto SqlService { get; set; }

    /// <summary>
    ///     Gets or Sets Agent
    /// </summary>
    [DataMember(Name = "agent", EmitDefaultValue = false)]
    public ServiceCountSummaryDto Agent { get; set; }

    /// <summary>
    ///     Gets or Sets DataUnavailableMessage
    /// </summary>
    [DataMember(Name = "dataUnavailableMessage", EmitDefaultValue = true)]
    public string DataUnavailableMessage { get; set; }

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
        sb.Append("class ServerConfigResult {\n");
        sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
        sb.Append("  SqlServerVersion: ").Append(SqlServerVersion).Append("\n");
        sb.Append("  Edition: ").Append(Edition).Append("\n");
        sb.Append("  Collation: ").Append(Collation).Append("\n");
        sb.Append("  VarOperatingSystem: ").Append(VarOperatingSystem).Append("\n");
        sb.Append("  Memory: ").Append(Memory).Append("\n");
        sb.Append("  Clustered: ").Append(Clustered).Append("\n");
        sb.Append("  Virtualized: ").Append(Virtualized).Append("\n");
        sb.Append("  Monitoring: ").Append(Monitoring).Append("\n");
        sb.Append("  MonitoringClass: ").Append(MonitoringClass).Append("\n");
        sb.Append("  Availability: ").Append(Availability).Append("\n");
        sb.Append("  LastRestart: ").Append(LastRestart).Append("\n");
        sb.Append("  Integration: ").Append(Integration).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  SqlService: ").Append(SqlService).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  DataUnavailableMessage: ").Append(DataUnavailableMessage).Append("\n");
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