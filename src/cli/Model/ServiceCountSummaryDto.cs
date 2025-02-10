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
///     ServiceCountSummaryDto
/// </summary>
[DataContract(Name = "ServiceCountSummaryDto")]
public class ServiceCountSummaryDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ServiceCountSummaryDto" /> class.
    /// </summary>
    /// <param name="running">running.</param>
    /// <param name="total">total.</param>
    public ServiceCountSummaryDto(int running = default, int total = default)
    {
        Running = running;
        Total = total;
    }

    /// <summary>
    ///     Gets or Sets Running
    /// </summary>
    [DataMember(Name = "running", EmitDefaultValue = false)]
    public int Running { get; set; }

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
        sb.Append("class ServiceCountSummaryDto {\n");
        sb.Append("  Running: ").Append(Running).Append("\n");
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