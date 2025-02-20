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
///     PostgresErrorLogDto
/// </summary>
[DataContract(Name = "PostgresErrorLogDto")]
public class PostgresErrorLogDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PostgresErrorLogDto" /> class.
    /// </summary>
    /// <param name="logTime">logTime.</param>
    /// <param name="processId">processId.</param>
    /// <param name="errorSeverity">errorSeverity.</param>
    /// <param name="message">message.</param>
    public PostgresErrorLogDto(DateTime logTime = default, IntegerIdentifier processId = default,
        string errorSeverity = default, string message = default)
    {
        LogTime = logTime;
        ProcessId = processId;
        ErrorSeverity = errorSeverity;
        Message = message;
    }

    /// <summary>
    ///     Gets or Sets LogTime
    /// </summary>
    [DataMember(Name = "logTime", EmitDefaultValue = false)]
    public DateTime LogTime { get; set; }

    /// <summary>
    ///     Gets or Sets ProcessId
    /// </summary>
    [DataMember(Name = "processId", EmitDefaultValue = false)]
    public IntegerIdentifier ProcessId { get; set; }

    /// <summary>
    ///     Gets or Sets ErrorSeverity
    /// </summary>
    [DataMember(Name = "errorSeverity", EmitDefaultValue = true)]
    public string ErrorSeverity { get; set; }

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
        sb.Append("class PostgresErrorLogDto {\n");
        sb.Append("  LogTime: ").Append(LogTime).Append("\n");
        sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
        sb.Append("  ErrorSeverity: ").Append(ErrorSeverity).Append("\n");
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