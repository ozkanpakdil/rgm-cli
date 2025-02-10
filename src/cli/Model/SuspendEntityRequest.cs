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
///     SuspendEntityRequest
/// </summary>
[DataContract(Name = "SuspendEntityRequest")]
public class SuspendEntityRequest : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="SuspendEntityRequest" /> class.
    /// </summary>
    /// <param name="ids">ids.</param>
    /// <param name="makeSuspended">makeSuspended.</param>
    public SuspendEntityRequest(List<string> ids = default, bool makeSuspended = default)
    {
        Ids = ids;
        MakeSuspended = makeSuspended;
    }

    /// <summary>
    ///     Gets or Sets Ids
    /// </summary>
    [DataMember(Name = "ids", EmitDefaultValue = true)]
    public List<string> Ids { get; set; }

    /// <summary>
    ///     Gets or Sets MakeSuspended
    /// </summary>
    [DataMember(Name = "makeSuspended", EmitDefaultValue = true)]
    public bool MakeSuspended { get; set; }

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
        sb.Append("class SuspendEntityRequest {\n");
        sb.Append("  Ids: ").Append(Ids).Append("\n");
        sb.Append("  MakeSuspended: ").Append(MakeSuspended).Append("\n");
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