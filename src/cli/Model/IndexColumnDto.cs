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
///     IndexColumnDto
/// </summary>
[DataContract(Name = "IndexColumnDto")]
public class IndexColumnDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IndexColumnDto" /> class.
    /// </summary>
    /// <param name="name">name.</param>
    /// <param name="isDescending">isDescending.</param>
    /// <param name="isComputed">isComputed.</param>
    /// <param name="isIncluded">isIncluded.</param>
    /// <param name="keyOrdinal">keyOrdinal.</param>
    public IndexColumnDto(string name = default, bool isDescending = default, bool isComputed = default,
        bool isIncluded = default, long keyOrdinal = default)
    {
        Name = name;
        IsDescending = isDescending;
        IsComputed = isComputed;
        IsIncluded = isIncluded;
        KeyOrdinal = keyOrdinal;
    }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets IsDescending
    /// </summary>
    [DataMember(Name = "isDescending", EmitDefaultValue = true)]
    public bool IsDescending { get; set; }

    /// <summary>
    ///     Gets or Sets IsComputed
    /// </summary>
    [DataMember(Name = "isComputed", EmitDefaultValue = true)]
    public bool IsComputed { get; set; }

    /// <summary>
    ///     Gets or Sets IsIncluded
    /// </summary>
    [DataMember(Name = "isIncluded", EmitDefaultValue = true)]
    public bool IsIncluded { get; set; }

    /// <summary>
    ///     Gets or Sets KeyOrdinal
    /// </summary>
    [DataMember(Name = "keyOrdinal", EmitDefaultValue = false)]
    public long KeyOrdinal { get; set; }

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
        sb.Append("class IndexColumnDto {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IsDescending: ").Append(IsDescending).Append("\n");
        sb.Append("  IsComputed: ").Append(IsComputed).Append("\n");
        sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
        sb.Append("  KeyOrdinal: ").Append(KeyOrdinal).Append("\n");
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