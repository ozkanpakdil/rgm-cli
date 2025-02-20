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
///     ErrorLog
/// </summary>
[DataContract(Name = "ErrorLog")]
public class ErrorLog : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ErrorLog" /> class.
    /// </summary>
    /// <param name="date">date.</param>
    /// <param name="process">process.</param>
    /// <param name="text">text.</param>
    public ErrorLog(DateTime date = default, string process = default, string text = default)
    {
        Date = date;
        Process = process;
        Text = text;
    }

    /// <summary>
    ///     Gets or Sets Date
    /// </summary>
    [DataMember(Name = "date", EmitDefaultValue = false)]
    public DateTime Date { get; set; }

    /// <summary>
    ///     Gets or Sets Process
    /// </summary>
    [DataMember(Name = "process", EmitDefaultValue = true)]
    public string Process { get; set; }

    /// <summary>
    ///     Gets or Sets Text
    /// </summary>
    [DataMember(Name = "text", EmitDefaultValue = true)]
    public string Text { get; set; }

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
        sb.Append("class ErrorLog {\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  Process: ").Append(Process).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
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