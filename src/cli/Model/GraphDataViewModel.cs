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
///     GraphDataViewModel
/// </summary>
[DataContract(Name = "GraphDataViewModel")]
public class GraphDataViewModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GraphDataViewModel" /> class.
    /// </summary>
    /// <param name="allocatedSql">allocatedSql.</param>
    /// <param name="other">other.</param>
    /// <param name="freeSpace">freeSpace.</param>
    /// <param name="usedSql">usedSql.</param>
    public GraphDataViewModel(List<List<long>> allocatedSql = default, List<List<long>> other = default,
        List<List<long>> freeSpace = default, List<List<long>> usedSql = default)
    {
        AllocatedSql = allocatedSql;
        Other = other;
        FreeSpace = freeSpace;
        UsedSql = usedSql;
    }

    /// <summary>
    ///     Gets or Sets AllocatedSql
    /// </summary>
    [DataMember(Name = "allocatedSql", EmitDefaultValue = true)]
    public List<List<long>> AllocatedSql { get; set; }

    /// <summary>
    ///     Gets or Sets Other
    /// </summary>
    [DataMember(Name = "other", EmitDefaultValue = true)]
    public List<List<long>> Other { get; set; }

    /// <summary>
    ///     Gets or Sets FreeSpace
    /// </summary>
    [DataMember(Name = "freeSpace", EmitDefaultValue = true)]
    public List<List<long>> FreeSpace { get; set; }

    /// <summary>
    ///     Gets or Sets UsedSql
    /// </summary>
    [DataMember(Name = "usedSql", EmitDefaultValue = true)]
    public List<List<long>> UsedSql { get; set; }

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
        sb.Append("class GraphDataViewModel {\n");
        sb.Append("  AllocatedSql: ").Append(AllocatedSql).Append("\n");
        sb.Append("  Other: ").Append(Other).Append("\n");
        sb.Append("  FreeSpace: ").Append(FreeSpace).Append("\n");
        sb.Append("  UsedSql: ").Append(UsedSql).Append("\n");
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