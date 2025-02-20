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
///     RemoveEntityRequest
/// </summary>
[DataContract(Name = "RemoveEntityRequest")]
public class RemoveEntityRequest : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RemoveEntityRequest" /> class.
    /// </summary>
    /// <param name="ids">ids.</param>
    /// <param name="fullyQualifiedNames">fullyQualifiedNames.</param>
    /// <param name="deleteAllAssociatedData">deleteAllAssociatedData.</param>
    public RemoveEntityRequest(List<string> ids = default, List<string> fullyQualifiedNames = default,
        bool deleteAllAssociatedData = default)
    {
        Ids = ids;
        FullyQualifiedNames = fullyQualifiedNames;
        DeleteAllAssociatedData = deleteAllAssociatedData;
    }

    /// <summary>
    ///     Gets or Sets Ids
    /// </summary>
    [DataMember(Name = "ids", EmitDefaultValue = true)]
    public List<string> Ids { get; set; }

    /// <summary>
    ///     Gets or Sets FullyQualifiedNames
    /// </summary>
    [DataMember(Name = "fullyQualifiedNames", EmitDefaultValue = true)]
    public List<string> FullyQualifiedNames { get; set; }

    /// <summary>
    ///     Gets or Sets DeleteAllAssociatedData
    /// </summary>
    [DataMember(Name = "deleteAllAssociatedData", EmitDefaultValue = true)]
    public bool DeleteAllAssociatedData { get; set; }

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
        sb.Append("class RemoveEntityRequest {\n");
        sb.Append("  Ids: ").Append(Ids).Append("\n");
        sb.Append("  FullyQualifiedNames: ").Append(FullyQualifiedNames).Append("\n");
        sb.Append("  DeleteAllAssociatedData: ").Append(DeleteAllAssociatedData).Append("\n");
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