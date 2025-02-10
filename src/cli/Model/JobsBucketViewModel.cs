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
///     JobsBucketViewModel
/// </summary>
[DataContract(Name = "JobsBucketViewModel")]
public class JobsBucketViewModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="JobsBucketViewModel" /> class.
    /// </summary>
    /// <param name="date">date.</param>
    /// <param name="successCount">successCount.</param>
    /// <param name="failureCount">failureCount.</param>
    public JobsBucketViewModel(DateTime date = default, int successCount = default, int failureCount = default)
    {
        Date = date;
        SuccessCount = successCount;
        FailureCount = failureCount;
    }

    /// <summary>
    ///     Gets or Sets Date
    /// </summary>
    [DataMember(Name = "date", EmitDefaultValue = false)]
    public DateTime Date { get; set; }

    /// <summary>
    ///     Gets or Sets SuccessCount
    /// </summary>
    [DataMember(Name = "successCount", EmitDefaultValue = false)]
    public int SuccessCount { get; set; }

    /// <summary>
    ///     Gets or Sets FailureCount
    /// </summary>
    [DataMember(Name = "failureCount", EmitDefaultValue = false)]
    public int FailureCount { get; set; }

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
        sb.Append("class JobsBucketViewModel {\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
        sb.Append("  FailureCount: ").Append(FailureCount).Append("\n");
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