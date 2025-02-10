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
///     TaskQueueStats
/// </summary>
[DataContract(Name = "TaskQueueStats")]
public class TaskQueueStats : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TaskQueueStats" /> class.
    /// </summary>
    /// <param name="priority">priority.</param>
    /// <param name="dataCollection">dataCollection.</param>
    public TaskQueueStats(TaskStats priority = default, TaskStats dataCollection = default)
    {
        Priority = priority;
        DataCollection = dataCollection;
    }

    /// <summary>
    ///     Gets or Sets Priority
    /// </summary>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public TaskStats Priority { get; set; }

    /// <summary>
    ///     Gets or Sets DataCollection
    /// </summary>
    [DataMember(Name = "dataCollection", EmitDefaultValue = false)]
    public TaskStats DataCollection { get; set; }

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
        sb.Append("class TaskQueueStats {\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DataCollection: ").Append(DataCollection).Append("\n");
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