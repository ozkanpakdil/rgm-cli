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
///     PostgresMetricPresentationDto
/// </summary>
[DataContract(Name = "PostgresMetricPresentationDto")]
public class PostgresMetricPresentationDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PostgresMetricPresentationDto" /> class.
    /// </summary>
    /// <param name="property">property.</param>
    /// <param name="name">name.</param>
    /// <param name="color">color.</param>
    /// <param name="units">units.</param>
    /// <param name="style">style.</param>
    public PostgresMetricPresentationDto(string property = default, string name = default, string color = default,
        string units = default, string style = default)
    {
        Property = property;
        Name = name;
        Color = color;
        Units = units;
        Style = style;
    }

    /// <summary>
    ///     Gets or Sets Property
    /// </summary>
    [DataMember(Name = "property", EmitDefaultValue = false)]
    public string Property { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Color
    /// </summary>
    [DataMember(Name = "color", EmitDefaultValue = false)]
    public string Color { get; set; }

    /// <summary>
    ///     Gets or Sets Units
    /// </summary>
    [DataMember(Name = "units", EmitDefaultValue = false)]
    public string Units { get; set; }

    /// <summary>
    ///     Gets or Sets Style
    /// </summary>
    [DataMember(Name = "style", EmitDefaultValue = false)]
    public string Style { get; set; }

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
        sb.Append("class PostgresMetricPresentationDto {\n");
        sb.Append("  Property: ").Append(Property).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Color: ").Append(Color).Append("\n");
        sb.Append("  Units: ").Append(Units).Append("\n");
        sb.Append("  Style: ").Append(Style).Append("\n");
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