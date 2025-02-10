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
using RedGate.SqlMonitor.Channels.Data;
using RedGate.SqlMonitor.Common.Domain;

namespace cli.Model;

/// <summary>
///     MicrosoftEntraIdDto
/// </summary>
[DataContract(Name = "MicrosoftEntraIdDto")]
public class MicrosoftEntraIdDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MicrosoftEntraIdDto" /> class.
    /// </summary>
    /// <param name="name">name.</param>
    /// <param name="id">id.</param>
    /// <param name="cir">cir.</param>
    /// <param name="baseMonitor">baseMonitor.</param>
    public MicrosoftEntraIdDto(string name = default, Guid id = default, ChannelInstanceRef cir = default,
        BaseMonitorDto baseMonitor = default)
    {
        Name = name;
        Id = id;
        Cir = cir;
        BaseMonitor = baseMonitor;
    }

    /// <summary>
    ///     Gets or Sets DisplayType
    /// </summary>
    [DataMember(Name = "displayType", EmitDefaultValue = false)]
    public EntityType? DisplayType { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid Id { get; set; }

    /// <summary>
    ///     Gets or Sets Cir
    /// </summary>
    [DataMember(Name = "cir", EmitDefaultValue = true)]
    public ChannelInstanceRef Cir { get; set; }

    /// <summary>
    ///     Gets or Sets BaseMonitor
    /// </summary>
    [DataMember(Name = "baseMonitor", EmitDefaultValue = false)]
    public BaseMonitorDto BaseMonitor { get; set; }

    /// <summary>
    ///     Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = true)]
    public string Type { get; private set; }

    /// <summary>
    ///     Gets or Sets FullName
    /// </summary>
    [DataMember(Name = "fullName", EmitDefaultValue = true)]
    public string FullName { get; private set; }

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
    ///     Returns false as DisplayType should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeDisplayType()
    {
        return false;
    }

    /// <summary>
    ///     Returns false as Type should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeType()
    {
        return false;
    }

    /// <summary>
    ///     Returns false as FullName should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeFullName()
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
        sb.Append("class MicrosoftEntraIdDto {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Cir: ").Append(Cir).Append("\n");
        sb.Append("  BaseMonitor: ").Append(BaseMonitor).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
        sb.Append("  FullName: ").Append(FullName).Append("\n");
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