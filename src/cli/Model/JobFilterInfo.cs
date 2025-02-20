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
///     JobFilterInfo
/// </summary>
[DataContract(Name = "JobFilterInfo")]
public class JobFilterInfo : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="JobFilterInfo" /> class.
    /// </summary>
    /// <param name="numberOfDaysHistory">numberOfDaysHistory.</param>
    /// <param name="filterText">filterText.</param>
    /// <param name="categories">categories.</param>
    /// <param name="groups">groups.</param>
    public JobFilterInfo(int numberOfDaysHistory = default, string filterText = default,
        List<string> categories = default, List<string> groups = default)
    {
        NumberOfDaysHistory = numberOfDaysHistory;
        FilterText = filterText;
        Categories = categories;
        Groups = groups;
    }

    /// <summary>
    ///     Gets or Sets NumberOfDaysHistory
    /// </summary>
    [DataMember(Name = "numberOfDaysHistory", EmitDefaultValue = false)]
    public int NumberOfDaysHistory { get; set; }

    /// <summary>
    ///     Gets or Sets FilterText
    /// </summary>
    [DataMember(Name = "filterText", EmitDefaultValue = true)]
    public string FilterText { get; set; }

    /// <summary>
    ///     Gets or Sets Categories
    /// </summary>
    [DataMember(Name = "categories", EmitDefaultValue = true)]
    public List<string> Categories { get; set; }

    /// <summary>
    ///     Gets or Sets Groups
    /// </summary>
    [DataMember(Name = "groups", EmitDefaultValue = true)]
    public List<string> Groups { get; set; }

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
        sb.Append("class JobFilterInfo {\n");
        sb.Append("  NumberOfDaysHistory: ").Append(NumberOfDaysHistory).Append("\n");
        sb.Append("  FilterText: ").Append(FilterText).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
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