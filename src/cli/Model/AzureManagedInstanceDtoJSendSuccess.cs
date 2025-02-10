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
using Newtonsoft.Json.Converters;

namespace cli.Model;

/// <summary>
///     AzureManagedInstanceDtoJSendSuccess
/// </summary>
[DataContract(Name = "AzureManagedInstanceDtoJSendSuccess")]
public class AzureManagedInstanceDtoJSendSuccess : IValidatableObject
{
    /// <summary>
    ///     Defines Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        ///     Enum Success for value: success
        /// </summary>
        [EnumMember(Value = "success")] Success = 1
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AzureManagedInstanceDtoJSendSuccess" /> class.
    /// </summary>
    /// <param name="data">data.</param>
    public AzureManagedInstanceDtoJSendSuccess(AzureManagedInstanceDto data = default)
    {
        Data = data;
    }


    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    ///     Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public AzureManagedInstanceDto Data { get; set; }

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
    ///     Returns false as Status should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeStatus()
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
        sb.Append("class AzureManagedInstanceDtoJSendSuccess {\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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