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
///     DiscoveryOptionsDto
/// </summary>
[DataContract(Name = "DiscoveryOptionsDto")]
public class DiscoveryOptionsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DiscoveryOptionsDto" /> class.
    /// </summary>
    /// <param name="domain">domain.</param>
    /// <param name="username">username.</param>
    /// <param name="password">password.</param>
    /// <param name="probeTcp">probeTcp.</param>
    /// <param name="probeBrowser">probeBrowser.</param>
    /// <param name="tcpPort">tcpPort.</param>
    /// <param name="searchBase">searchBase.</param>
    public DiscoveryOptionsDto(string domain = default, string username = default, string password = default,
        bool probeTcp = default, bool probeBrowser = default, int tcpPort = default, string searchBase = default)
    {
        Domain = domain;
        Username = username;
        Password = password;
        ProbeTcp = probeTcp;
        ProbeBrowser = probeBrowser;
        TcpPort = tcpPort;
        SearchBase = searchBase;
    }

    /// <summary>
    ///     Gets or Sets Domain
    /// </summary>
    [DataMember(Name = "domain", EmitDefaultValue = true)]
    public string Domain { get; set; }

    /// <summary>
    ///     Gets or Sets Username
    /// </summary>
    [DataMember(Name = "username", EmitDefaultValue = true)]
    public string Username { get; set; }

    /// <summary>
    ///     Gets or Sets Password
    /// </summary>
    [DataMember(Name = "password", EmitDefaultValue = true)]
    public string Password { get; set; }

    /// <summary>
    ///     Gets or Sets ProbeTcp
    /// </summary>
    [DataMember(Name = "probeTcp", EmitDefaultValue = true)]
    public bool ProbeTcp { get; set; }

    /// <summary>
    ///     Gets or Sets ProbeBrowser
    /// </summary>
    [DataMember(Name = "probeBrowser", EmitDefaultValue = true)]
    public bool ProbeBrowser { get; set; }

    /// <summary>
    ///     Gets or Sets TcpPort
    /// </summary>
    [DataMember(Name = "tcpPort", EmitDefaultValue = false)]
    public int TcpPort { get; set; }

    /// <summary>
    ///     Gets or Sets SearchBase
    /// </summary>
    [DataMember(Name = "searchBase", EmitDefaultValue = true)]
    public string SearchBase { get; set; }

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
        sb.Append("class DiscoveryOptionsDto {\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  ProbeTcp: ").Append(ProbeTcp).Append("\n");
        sb.Append("  ProbeBrowser: ").Append(ProbeBrowser).Append("\n");
        sb.Append("  TcpPort: ").Append(TcpPort).Append("\n");
        sb.Append("  SearchBase: ").Append(SearchBase).Append("\n");
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