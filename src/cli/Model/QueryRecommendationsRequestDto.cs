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
///     QueryRecommendationsRequestDto
/// </summary>
[DataContract(Name = "QueryRecommendationsRequestDto")]
public class QueryRecommendationsRequestDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="QueryRecommendationsRequestDto" /> class.
    /// </summary>
    /// <param name="cir">cir.</param>
    /// <param name="startDate">startDate.</param>
    /// <param name="endDate">endDate.</param>
    /// <param name="queryRecommendationKeys">queryRecommendationKeys.</param>
    public QueryRecommendationsRequestDto(SqlInstanceChannelInstanceRef cir = default, DateTime startDate = default,
        DateTime endDate = default, List<QueryPlanKeysDto> queryRecommendationKeys = default)
    {
        Cir = cir;
        StartDate = startDate;
        EndDate = endDate;
        QueryRecommendationKeys = queryRecommendationKeys;
    }

    /// <summary>
    ///     Gets or Sets Cir
    /// </summary>
    [DataMember(Name = "cir", EmitDefaultValue = false)]
    public SqlInstanceChannelInstanceRef Cir { get; set; }

    /// <summary>
    ///     Gets or Sets StartDate
    /// </summary>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime StartDate { get; set; }

    /// <summary>
    ///     Gets or Sets EndDate
    /// </summary>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime EndDate { get; set; }

    /// <summary>
    ///     Gets or Sets QueryRecommendationKeys
    /// </summary>
    [DataMember(Name = "queryRecommendationKeys", EmitDefaultValue = true)]
    public List<QueryPlanKeysDto> QueryRecommendationKeys { get; set; }

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
        sb.Append("class QueryRecommendationsRequestDto {\n");
        sb.Append("  Cir: ").Append(Cir).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  QueryRecommendationKeys: ").Append(QueryRecommendationKeys).Append("\n");
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