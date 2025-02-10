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
///     AddInstanceResult
/// </summary>
[DataContract(Name = "AddInstanceResult")]
public class AddInstanceResult : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AddInstanceResult" /> class.
    /// </summary>
    /// <param name="success">success.</param>
    /// <param name="message">message.</param>
    public AddInstanceResult(bool success = default, string message = default)
    {
        Success = success;
        Message = message;
    }

    /// <summary>
    ///     Gets or Sets Success
    /// </summary>
    [DataMember(Name = "success", EmitDefaultValue = true)]
    public bool Success { get; set; }

    /// <summary>
    ///     Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = true)]
    public string Message { get; set; }

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
        sb.Append("class AddInstanceResult {\n");
        sb.Append("  Success: ").Append(Success).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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