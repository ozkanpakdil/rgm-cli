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
///     PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDto
/// </summary>
[DataContract(Name = "PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDto")]
public class PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the
    ///     <see cref="PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDto" /> class.
    /// </summary>
    /// <param name="queryHash">queryHash.</param>
    /// <param name="databaseName">databaseName.</param>
    /// <param name="queryId">queryId.</param>
    /// <param name="queryRecommendations">queryRecommendations.</param>
    public PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDto(string queryHash = default,
        string databaseName = default, string queryId = default,
        List<PostgresQueryRecommendationDto> queryRecommendations = default)
    {
        QueryHash = queryHash;
        DatabaseName = databaseName;
        QueryId = queryId;
        QueryRecommendations = queryRecommendations;
    }

    /// <summary>
    ///     Gets or Sets QueryHash
    /// </summary>
    [DataMember(Name = "queryHash", EmitDefaultValue = false)]
    public string QueryHash { get; set; }

    /// <summary>
    ///     Gets or Sets DatabaseName
    /// </summary>
    [DataMember(Name = "databaseName", EmitDefaultValue = false)]
    public string DatabaseName { get; set; }

    /// <summary>
    ///     Gets or Sets QueryId
    /// </summary>
    [DataMember(Name = "queryId", EmitDefaultValue = false)]
    public string QueryId { get; set; }

    /// <summary>
    ///     Gets or Sets QueryRecommendations
    /// </summary>
    [DataMember(Name = "queryRecommendations", EmitDefaultValue = false)]
    public List<PostgresQueryRecommendationDto> QueryRecommendations { get; set; }

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
        sb.Append("class PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDto {\n");
        sb.Append("  QueryHash: ").Append(QueryHash).Append("\n");
        sb.Append("  DatabaseName: ").Append(DatabaseName).Append("\n");
        sb.Append("  QueryId: ").Append(QueryId).Append("\n");
        sb.Append("  QueryRecommendations: ").Append(QueryRecommendations).Append("\n");
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