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
///     ServerOverviewErrorLogModel
/// </summary>
[DataContract(Name = "ServerOverviewErrorLogModel")]
public class ServerOverviewErrorLogModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ServerOverviewErrorLogModel" /> class.
    /// </summary>
    /// <param name="errorLogs">errorLogs.</param>
    /// <param name="total">total.</param>
    public ServerOverviewErrorLogModel(List<ErrorLog> errorLogs = default, int total = default)
    {
        ErrorLogs = errorLogs;
        Total = total;
    }

    /// <summary>
    ///     Gets or Sets ErrorLogs
    /// </summary>
    [DataMember(Name = "errorLogs", EmitDefaultValue = true)]
    public List<ErrorLog> ErrorLogs { get; set; }

    /// <summary>
    ///     Gets or Sets Total
    /// </summary>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public int Total { get; set; }

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
        sb.Append("class ServerOverviewErrorLogModel {\n");
        sb.Append("  ErrorLogs: ").Append(ErrorLogs).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
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