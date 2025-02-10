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
///     ActualPlanRuntimeMetricsDto
/// </summary>
[DataContract(Name = "ActualPlanRuntimeMetricsDto")]
public class ActualPlanRuntimeMetricsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ActualPlanRuntimeMetricsDto" /> class.
    /// </summary>
    /// <param name="collectionDate">collectionDate.</param>
    /// <param name="createDate">createDate.</param>
    /// <param name="planHandle">planHandle.</param>
    /// <param name="mostExpensiveOperation">mostExpensiveOperation.</param>
    public ActualPlanRuntimeMetricsDto(DateTime collectionDate = default, DateTime createDate = default,
        string planHandle = default, ParsedRelOpDto mostExpensiveOperation = default)
    {
        CollectionDate = collectionDate;
        CreateDate = createDate;
        PlanHandle = planHandle;
        MostExpensiveOperation = mostExpensiveOperation;
    }

    /// <summary>
    ///     Gets or Sets CollectionDate
    /// </summary>
    [DataMember(Name = "collectionDate", EmitDefaultValue = false)]
    public DateTime CollectionDate { get; set; }

    /// <summary>
    ///     Gets or Sets CreateDate
    /// </summary>
    [DataMember(Name = "createDate", EmitDefaultValue = false)]
    public DateTime CreateDate { get; set; }

    /// <summary>
    ///     Gets or Sets PlanHandle
    /// </summary>
    [DataMember(Name = "planHandle", EmitDefaultValue = true)]
    public string PlanHandle { get; set; }

    /// <summary>
    ///     Gets or Sets MostExpensiveOperation
    /// </summary>
    [DataMember(Name = "mostExpensiveOperation", EmitDefaultValue = false)]
    public ParsedRelOpDto MostExpensiveOperation { get; set; }

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
        sb.Append("class ActualPlanRuntimeMetricsDto {\n");
        sb.Append("  CollectionDate: ").Append(CollectionDate).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  PlanHandle: ").Append(PlanHandle).Append("\n");
        sb.Append("  MostExpensiveOperation: ").Append(MostExpensiveOperation).Append("\n");
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