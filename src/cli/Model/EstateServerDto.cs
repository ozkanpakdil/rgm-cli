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
///     EstateServerDto
/// </summary>
[DataContract(Name = "EstateServerDto")]
public class EstateServerDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="EstateServerDto" /> class.
    /// </summary>
    /// <param name="cir">cir.</param>
    /// <param name="fullyQualifiedName">fullyQualifiedName.</param>
    /// <param name="clusterName">clusterName.</param>
    /// <param name="displayName">displayName.</param>
    /// <param name="alias">alias.</param>
    /// <param name="tags">tags.</param>
    public EstateServerDto(string cir = default, string fullyQualifiedName = default, string clusterName = default,
        string displayName = default, string alias = default, List<TagDto> tags = default)
    {
        Cir = cir;
        FullyQualifiedName = fullyQualifiedName;
        ClusterName = clusterName;
        DisplayName = displayName;
        Alias = alias;
        Tags = tags;
    }

    /// <summary>
    ///     Gets or Sets Cir
    /// </summary>
    [DataMember(Name = "cir", EmitDefaultValue = false)]
    public string Cir { get; set; }

    /// <summary>
    ///     Gets or Sets FullyQualifiedName
    /// </summary>
    [DataMember(Name = "fullyQualifiedName", EmitDefaultValue = false)]
    public string FullyQualifiedName { get; set; }

    /// <summary>
    ///     Gets or Sets ClusterName
    /// </summary>
    [DataMember(Name = "clusterName", EmitDefaultValue = false)]
    public string ClusterName { get; set; }

    /// <summary>
    ///     Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    /// <summary>
    ///     Gets or Sets Alias
    /// </summary>
    [DataMember(Name = "alias", EmitDefaultValue = true)]
    public string Alias { get; set; }

    /// <summary>
    ///     Gets or Sets Tags
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public List<TagDto> Tags { get; set; }

    /// <summary>
    ///     Gets or Sets ServerDisplayName
    /// </summary>
    [DataMember(Name = "serverDisplayName", EmitDefaultValue = false)]
    public string ServerDisplayName { get; private set; }

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
    ///     Returns false as ServerDisplayName should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeServerDisplayName()
    {
        return false;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstateServerDto {\n");
        sb.Append("  Cir: ").Append(Cir).Append("\n");
        sb.Append("  FullyQualifiedName: ").Append(FullyQualifiedName).Append("\n");
        sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Alias: ").Append(Alias).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  ServerDisplayName: ").Append(ServerDisplayName).Append("\n");
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